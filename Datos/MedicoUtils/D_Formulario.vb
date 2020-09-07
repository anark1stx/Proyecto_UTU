Imports Entidades
Imports ADODB
Imports ADODB.DataTypeEnum
Imports ADODB.CommandTypeEnum
Imports ADODB.ParameterDirectionEnum
Imports ADODB.CursorLocationEnum
Public Class D_Formulario
    Dim conexion As New Connection

    Public Function AltaFormulario(form As E_Formulario) As Integer

        conexion.ConnectionString = retornarCStringBD()
        conexion.CursorLocation = adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "AltaFormulario",
            .ActiveConnection = conexion
        }

        cmd.Parameters.Append(cmd.CreateParameter("@NOMBRE", adVarChar, adParamInput, 30, form.Nombre))
        cmd.Parameters.Append(cmd.CreateParameter("@XML", adVarChar, adParamInput, 500, form.XML))
        cmd.Parameters.Append(cmd.CreateParameter("@VPREVIA", adVarChar, adParamInput, 500, form.VistaPrevia))

        Try
            cmd.Execute() 'alta tabla formulario
            conexion.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            conexion.Close()
            Return 0
        End Try

        Return 1
        conexion.Close()
    End Function

    Public Function AltaPreguntas(textoPregunta) As Integer
        'hacer alta a la tabla preguntas 
        Dim cmd = New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "AltaPregunta",
            .ActiveConnection = conexion
        } 'si ya existe retornar la id, como hice con los parametros de los analisis que ya existian.

        Try
            cmd.Execute()
        Catch ex As Exception

        End Try
    End Function

    Public Function ListarFormularios() As List(Of E_Formulario)

    End Function


    Public Function ConsultaDatosDeFormulario() As E_Formulario

    End Function

End Class
