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
        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "AltaAnalisisParametro",
            .ActiveConnection = conexion
        }

        For Each p As E_Analisis.Parametro In a.Parametros
            cmd.Parameters.Append(cmd.CreateParameter("@NOMBRE", adVarChar, adParamInput, 90, p.Nombre))
            cmd.Parameters.Append(cmd.CreateParameter("@UNIDAD", adVarChar, adParamInput, 20, p.Unidad))
            cmd.Parameters.Append(cmd.CreateParameter("@REFERENCIA_MIN", adDouble, adParamInput, 8, p.ValorMinimo))
            cmd.Parameters.Append(cmd.CreateParameter("@REFERENCIA_MAX", adDouble, adParamInput, 8, p.ValorMaximo))

            Try
                cmd.Execute()
            Catch ex As Exception
                conexion.Close()
                Return 0 'no se pudo ingresar parametro
            End Try
        Next

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
                Return 0 'no se pudo ingresar parametro
            End Try

        Next

        Return 1
    End Function

End Class
