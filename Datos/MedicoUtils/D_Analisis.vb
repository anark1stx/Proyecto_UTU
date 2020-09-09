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

        cmd.Parameters.Add("NOMBRE", MySqlDbType.VarChar, 90).Value = a.Nombre
        cmd.Parameters.Add("ID_analisis", MySqlDbType.Int32).Direction = ParameterDirection.Output

        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Try
            leer = cmd.ExecuteReader() 'porque preciso el ID del analisis, sino seria NonQuery.
        Catch ex As Exception
            Cerrar(conexion)
            Return 2 'no se pudo ingresar analisis
        End Try

        Cerrar(conexion)

        a.ID = cmd.Parameters("ID_analisis").Value

        Dim exitCodeParametro = AltaParametros(a)
        Select Case exitCodeParametro
            Case -1, 5, 3
                Return exitCodeParametro
        End Select

        Dim exitCodeIndicacion = AltaIndicacion(a)

        Return exitCodeIndicacion

    End Function

    Public Function AltaParametros(a As E_Analisis) As Integer 'hacer algo para verificar existencia del parametro antes

        Dim leer As MySqlDataReader

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
                cmd.Parameters.Add("NOMBRE", MySqlDbType.VarChar, 90).Value = p.Nombre
                cmd.Parameters.Add("UNIDAD", MySqlDbType.VarChar, 20).Value = p.Unidad
                cmd.Parameters.Add("REFERENCIA_MIN", MySqlDbType.Double, 8).Value = p.ValorMinimo
                cmd.Parameters.Add("REFERENCIA_MAX", MySqlDbType.Double, 8).Value = p.ValorMaximo
                cmd.Parameters.Add("ID_PARAMETRO", MySqlDbType.Int32).Direction = ParameterDirection.Output
                Try
                    leer = cmd.ExecuteReader()
                    p.ID = cmd.Parameters("ID_PARAMETRO").Value
                Catch ex As Exception
                    Cerrar(conexion)
                    Return 5 'no se pudo ingresar parametro
                End Try
            Else
                Console.WriteLine("El parametro ya esta registrado en la BD")
            End If

            Dim cmd2 As New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "AltaAnalisisTieneParametro",
                .Connection = conexion
            }

            cmd2.Parameters.Add("ID_analisis", MySqlDbType.Int32).Value = a.ID
            cmd2.Parameters.Add("ID_parametro", MySqlDbType.Int32).Value = p.ID
            Try
                cmd2.ExecuteNonQuery()
            Catch ex As Exception
                Cerrar(conexion)
                Return 3
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
            .CommandText = "AltaAnalisisIndicacion",
            .Connection = conexion
            }
            cmd.Parameters.Add("ID_analisis", MySqlDbType.Int32).Value = a.ID
            cmd.Parameters.Add("NOMBRE", MySqlDbType.VarChar).Value = i.Nombre
            cmd.Parameters.Add("INDICACION", MySqlDbType.VarChar).Value = i.Indicacion

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Cerrar(conexion)
                Return 6 'no se pudo ingresar indicacion
            End Try
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

End Class
