Imports Entidades
Imports MySql.Data.MySqlClient
Public Class D_Analisis
    Dim conexion As New MySqlConnection

    Public Function AltaAnalisis(a As E_Analisis) As Integer

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaAnalisis",
            .Connection = conexion
        }
        Dim leer As MySqlDataReader

        cmd.Parameters.Add("NOM", MySqlDbType.VarChar, 90).Value = a.Nombre
        cmd.Parameters.Add("ID_AN", MySqlDbType.Int32).Direction = ParameterDirection.Output

        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Try
            leer = cmd.ExecuteReader() 'porque preciso el ID del analisis, sino seria NonQuery.
        Catch ex As Exception
            Cerrar(conexion)
            Return 2 'no se pudo ingresar analisis
        End Try

        a.ID = cmd.Parameters("ID_AN").Value
        Cerrar(conexion)

        Dim exitCodeParametro = AltaParametros(a)
        Select Case exitCodeParametro
            Case <> 1
                Return exitCodeParametro
        End Select

        Return AltaIndicacion(a)
    End Function

    Public Function AltaParametros(a As E_Analisis) As Integer 'hacer algo para verificar existencia del parametro antes
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        For Each p As E_Analisis.Parametro In a.Parametros
            Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaAnalisisParametro",
            .Connection = conexion
            }
            If p.ID = 0 Then
                cmd.Parameters.Add("NOM", MySqlDbType.VarChar, 90).Value = p.Nombre
                cmd.Parameters.Add("UNI", MySqlDbType.VarChar, 20).Value = p.Unidad
                cmd.Parameters.Add("REF_MIN", MySqlDbType.Double, 8).Value = p.ValorMinimo
                cmd.Parameters.Add("REF_MAX", MySqlDbType.Double, 8).Value = p.ValorMaximo
                cmd.Parameters.Add("ID_P", MySqlDbType.Int32).Direction = ParameterDirection.Output
                Try
                    cmd.ExecuteReader()
                    p.ID = cmd.Parameters("ID_P").Value
                Catch ex As Exception
                    Cerrar(conexion)
                    Console.WriteLine("ERR" & ex.Message)
                    Return -5 'no se pudo ingresar parametro
                End Try
            Else
                Console.WriteLine("El parametro ya esta registrado en la BD")
            End If

            Dim cmd2 As New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "AltaAnalisisTieneParametro",
                .Connection = conexion
            }

            cmd2.Parameters.Add("ID_AN", MySqlDbType.Int32).Value = a.ID
            cmd2.Parameters.Add("ID_P", MySqlDbType.Int32).Value = p.ID
            Try
                cmd2.ExecuteNonQuery()
            Catch ex As Exception
                Cerrar(conexion)
                Console.WriteLine("ERR2" & ex.Message)
                Return -3
            End Try
        Next
        Cerrar(conexion)
        Return 1
    End Function

    Public Function AltaIndicacion(a As E_Analisis) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If
        For Each i As E_Analisis.Indicacion In a.Indicaciones
            Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaIndicacion",
            .Connection = conexion
            }

            cmd.Parameters.Add("NOM", MySqlDbType.VarChar, 90).Value = i.Nombre

            Try
                cmd.ExecuteNonQuery()
                Cerrar(conexion)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Cerrar(conexion)
                Return -6 'no se pudo ingresar indicacion
            End Try

            Dim cmd2 As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaEspecificacion",
            .Connection = conexion
            }

            cmd2.Parameters.Add("ID_AN", MySqlDbType.Int32).Value = a.ID
            cmd2.Parameters.Add("NOM_I", MySqlDbType.VarChar, 90).Value = i.Nombre
            cmd2.Parameters.Add("DESCR", MySqlDbType.VarChar, 500).Value = i.Nombre

        Next
        Cerrar(conexion)
        Return 1
    End Function

    Public Function RetornarParametros() As List(Of E_Analisis.Parametro)

        Dim pList As New List(Of E_Analisis.Parametro)

        Dim leer As MySqlDataReader
        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BuscarParametros",
            .Connection = conexion
        }

        If Conectar(conexion) = -1 Then
            Cerrar(conexion)
            pList.Add(New E_Analisis.Parametro With {.ID = -1})
            Return pList
        End If

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            pList.Add(New E_Analisis.Parametro With {.ID = -2})
            Return pList
        End Try
        If leer.HasRows Then
            While leer.Read()
                pList.Add(New E_Analisis.Parametro With {
                .ID = leer.GetInt32("ID"),
                .Nombre = leer.GetString("nombre"),
                .Unidad = leer.GetString("unidad"),
                .ValorMinimo = leer.GetDouble("referencia_min"),
                .ValorMaximo = leer.GetDouble("referencia_max")
                })
            End While
        Else
            pList.Add(New E_Analisis.Parametro With {.ID = -8})
        End If
        Cerrar(conexion)
        Return pList
    End Function

    Public Function AnalisisExiste(nombreanalisis As String) As Integer 'si el analisis ya existe avisar y pedir que cambie el nombre
        If Conectar(conexion) = -1 Then
            Return -1
        End If
        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AnalisisExiste",
            .Connection = conexion
        }
        Dim leer As MySqlDataReader

        cmd.Parameters.Add("NOM", MySqlDbType.VarChar, 90).Value = nombreanalisis
        cmd.Parameters.Add("EXISTE", MySqlDbType.Bit).Direction = ParameterDirection.Output

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            Console.WriteLine(ex.Message)
            Return 2
        End Try

        Dim existe As Integer = cmd.Parameters("EXISTE").Value
        Cerrar(conexion)
        Return existe

    End Function



    Public Function ConsultarResultadosAnalisis(consulta As E_Atiende, a As E_Analisis) As E_Analisis

    End Function

    Public Function BuscarAnalisisXNombre(nom As String) As List(Of E_Analisis)

        Dim aList As New List(Of E_Analisis)
        If Conectar(conexion) = -1 Then
            Cerrar(conexion)
            aList.Add(New E_Analisis With {.ID = -1})
            Return aList
        End If

        Dim leer As MySqlDataReader

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BuscarAnalisisXNombre",
            .Connection = conexion
        }
        cmd.Parameters.Add("NOM_A", MySqlDbType.VarChar, 160).Value = nom

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            aList.Add(New E_Analisis With {.ID = -2})
            Return aList
        End Try

        If leer.HasRows Then
            While leer.Read()
                aList.Add(New E_Analisis With {
                .ID = leer.GetInt32("ID"),
                .Nombre = leer.GetString("nombre")
                })
            End While
        Else
            aList.Add(New E_Analisis With {.ID = -8})
        End If

        Cerrar(conexion)
        Return aList
    End Function


    Public Function ListarAnalisisDePaciente(CI_P As Integer)

        Dim pList As New List(Of E_Analisis.Parametro)

        Dim leer As MySqlDataReader
        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BuscarParametros",
            .Connection = conexion
        }

        If Conectar(conexion) = -1 Then
            Cerrar(conexion)
            pList.Add(New E_Analisis.Parametro With {.ID = -1})
            Return pList
        End If

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            pList.Add(New E_Analisis.Parametro With {.ID = -2})
            Return pList
        End Try
        If leer.HasRows Then
            While leer.Read()
                Console.WriteLine("reading parametros")
                pList.Add(New E_Analisis.Parametro With {
                .ID = leer.GetInt32("ID"),
                .Nombre = leer.GetString("nombre"),
                .Unidad = leer.GetString("unidad"),
                .ValorMinimo = leer.GetDouble("referencia_min"),
                .ValorMaximo = leer.GetDouble("referencia_max")
                })

            End While
        Else
            pList.Add(New E_Analisis.Parametro With {.ID = -8})
        End If


        Cerrar(conexion)
        Return pList
    End Function

End Class
