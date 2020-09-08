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
        cmd.Parameters.Add("ID_analisis", MySqlDbType.Int32)
        cmd.Parameters("ID_analisis").Direction = ParameterDirection.Output

        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Try
            leer = cmd.ExecuteReader() 'porque preciso el ID del analisis, sino seria NonQuery.
        Catch ex As Exception
            Cerrar(conexion)
            Return 2 'no se pudo ingresar analisis
        End Try

        While leer.Read()
            a.ID = leer.GetInt32("ID_analisis")
        End While

        Cerrar(conexion)

        If AltaParametros(a) = 0 Then
            Return 5 'no se pudo ingresar parametros
        End If

        For Each indicacion As E_Analisis.Indicacion In a.Indicaciones
            If AltaIndicacion(a) = 0 Then
                Return 6 'no se pudo ingresar indicaciones
            End If
        Next

        Return 1
    End Function

    Public Function AltaParametros(a As E_Analisis) As Integer 'hacer algo para verificar existencia del parametro antes

        Dim leer As MySqlDataReader
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
                Try
                    cmd.Connection.Open()
                    leer = cmd.ExecuteReader()
                    While leer.Read()
                        p.ID = leer.GetInt32("ID_PARAMETRO")
                    End While
                    leer.Close()
                    cmd.Connection.Close()
                Catch ex As Exception
                    cmd.Connection.Close()
                    Return 0 'no se pudo ingresar parametro
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
                cmd2.Connection.Open()
                cmd2.ExecuteNonQuery()
                cmd2.Connection.Close()
            Catch ex As Exception
                cmd2.Connection.Close()
                Return 0
            End Try
        Next
        Return 1
    End Function

    Public Function AltaIndicacion(a As E_Analisis) As Integer

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
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()
                cmd.Connection.Close()
            Catch ex As Exception
                cmd.Connection.Close()
                Console.WriteLine(ex.Message)
                Return 0 'no se pudo ingresar indicacion
            End Try
        Next

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
        Try
            cmd.Connection.Open()
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            cmd.Connection.Close()
            pList.Add(New E_Analisis.Parametro With {.ID = 0})
            Return pList
        End Try

        If Not leer.HasRows Then
            cmd.Connection.Close()
            pList.Add(New E_Analisis.Parametro With {.ID = 0})
            Return pList
        End If

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

        leer.Close()
        cmd.Connection.Close()
        Return pList
    End Function

    Public Function AnalisisExiste(nombreanalisis As String) As Integer 'si el analisis ya existe avisar y pedir que cambie el nombre

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AnalisisExiste",
            .Connection = conexion
        }
        Dim leer As MySqlDataReader

        cmd.Parameters.Add("NOM", MySqlDbType.VarChar, 90).Value = nombreanalisis
        cmd.Parameters.Add("EXISTE", MySqlDbType.Int32).Direction = ParameterDirection.Output
        Try
            Dim existe As Integer = 0
            cmd.Connection.Open()
            leer = cmd.ExecuteReader()
            existe = leer.GetInt32("EXISTE")
            cmd.Connection.Close()
            Return existe
        Catch ex As Exception
            Console.WriteLine("excepcion")
            cmd.Connection.Close()
            Return 3
        End Try

    End Function

End Class
