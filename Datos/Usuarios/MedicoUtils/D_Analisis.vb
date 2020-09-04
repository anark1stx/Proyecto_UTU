Imports Entidades
Imports ADODB
Imports ADODB.DataTypeEnum
Imports ADODB.CommandTypeEnum
Imports ADODB.ParameterDirectionEnum
Imports ADODB.CursorLocationEnum
Public Class D_Analisis
    Dim conexion As New Connection

    Public Function AltaAnalisis(a As E_Analisis) As Integer

        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "AltaAnalisis",
            .ActiveConnection = conexion
        }
        Dim leer As New Recordset

        cmd.Parameters.Append(cmd.CreateParameter("@NOMBRE", adVarChar, adParamInput, a.Nombre.Length, a.Nombre))
        cmd.Parameters.Append(cmd.CreateParameter("ID_analisis", adInteger, adParamOutput, , a.ID))

        Try
            leer = cmd.Execute()
        Catch ex As Exception
            conexion.Close()
            Console.WriteLine(ex.Message)
            Return 0 'no se pudo ingresar analisis
        End Try

        leer.Close()
        conexion.Close()

        If AltaParametros(a) = 0 Then
            Return 2 'no se pudo ingresar parametros
        End If

        For Each indicacion As E_Analisis.Indicacion In a.Indicaciones
            If AltaIndicacion(a) = 0 Then
                Return 3 'no se pudo ingresar indicaciones
            End If
        Next

        Return 1
    End Function

    Public Function AltaParametros(a As E_Analisis) As Integer 'hacer algo para verificar existencia del parametro antes
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = adUseClient
        conexion.Open()

        For Each p As E_Analisis.Parametro In a.Parametros
            Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "AltaAnalisisParametro",
            .ActiveConnection = conexion
            }
            If p.ID = 0 Then
                cmd.Parameters.Append(cmd.CreateParameter("@NOMBRE", adVarChar, adParamInput, 90, p.Nombre))
                cmd.Parameters.Append(cmd.CreateParameter("@UNIDAD", adVarChar, adParamInput, 20, p.Unidad))
                cmd.Parameters.Append(cmd.CreateParameter("@REFERENCIA_MIN", adDouble, adParamInput, 8, p.ValorMinimo))
                cmd.Parameters.Append(cmd.CreateParameter("@REFERENCIA_MAX", adDouble, adParamInput, 8, p.ValorMaximo))

                cmd.Parameters.Append(cmd.CreateParameter("ID_PARAMETRO", adInteger, adParamOutput, , p.ID))
                Try
                    cmd.Execute()
                Catch ex As Exception
                    conexion.Close()
                    Return 0 'no se pudo ingresar parametro
                End Try
            Else
                Console.WriteLine("El parametro ya esta registrado en la BD")
            End If

            Dim cmd2 As New Command With {
                .CommandType = adCmdStoredProc,
                .CommandText = "AltaAnalisisTieneParametro",
                .ActiveConnection = conexion
            }

            cmd2.Parameters.Append(cmd.CreateParameter("@ID_analisis", adInteger, adParamInput, , a.ID))
            cmd2.Parameters.Append(cmd.CreateParameter("@ID_parametro", adInteger, adParamInput, , p.ID))

            Try
                cmd2.Execute()
            Catch ex As Exception
                conexion.Close()
                Return 0
            End Try

        Next
        conexion.Close()
        Return 1
    End Function

    Public Function AltaIndicacion(a As E_Analisis) As Integer
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = adUseClient
        conexion.Open()
        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "AltaAnalisisIndicacion",
            .ActiveConnection = conexion
        }

        For Each i As E_Analisis.Indicacion In a.Indicaciones
            cmd.Parameters.Append(cmd.CreateParameter("@ID_ANALISIS", adInteger, adParamInput, , a.ID))
            cmd.Parameters.Append(cmd.CreateParameter("@NOMBRE", adVarChar, adParamInput, 90, i.Nombre))
            cmd.Parameters.Append(cmd.CreateParameter("@INDICACION", adVarChar, adParamInput, 1200, i.Indicacion))

            Try
                cmd.Execute()
            Catch ex As Exception
                conexion.Close()
                Return 0 'no se pudo ingresar parametro
            End Try

        Next

        conexion.Close()
        Return 1
    End Function

    Public Function RetornarParametrosConNombre(nombre As String) As List(Of E_Analisis.Parametro)
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = adUseClient
        conexion.Open()

        Dim pList As New List(Of E_Analisis.Parametro)

        Dim leer As New Recordset
        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "BuscarParametro",
            .ActiveConnection = conexion
        }

        cmd.Parameters.Append(cmd.CreateParameter("@buscar", adVarChar, adParamInput, 90, nombre))

        Try
            leer = cmd.Execute()
        Catch ex As Exception
            conexion.Close()
            pList.Add(New E_Analisis.Parametro With {.ID = 0})
            Return pList
        End Try

        If leer.RecordCount < 1 Then
            conexion.Close()
            pList.Add(New E_Analisis.Parametro With {.ID = 0})
            Return pList
        End If

        While Not leer.EOF
            Console.WriteLine("reading parametros")
            pList.Add(New E_Analisis.Parametro With {
            .ID = leer("ID").Value,
            .Nombre = leer("nombre").Value,
            .Unidad = leer("unidad").Value,
            .ValorMinimo = leer("referencia_min").Value,
            .ValorMaximo = leer("referencia_max").Value
            })

            leer.MoveNext()
        End While

        leer.Close()
        conexion.Close()
        Return pList
    End Function

    Public Function AnalisisExiste(nombreanalisis As String) As Integer 'si el analisis ya existe avisar y pedir que cambie el nombre
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "AnalisisExiste",
            .ActiveConnection = conexion
        }
        Dim leer As New Recordset
        Dim existe As Integer = 0
        cmd.Parameters.Append(cmd.CreateParameter("@NOM", adVarChar, adParamInput, 90, nombreanalisis))

        Try
            leer = cmd.Execute()
        Catch ex As Exception
            Console.WriteLine("excepcion")
            conexion.Close()
            Return 0
        End Try

        existe = leer("EXISTE").Value
        leer.Close()
        conexion.Close()
        Console.WriteLine("existeeE: " & existe)
        Return existe

    End Function

End Class
