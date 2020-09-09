Imports Entidades
Imports MySql.Data.MySqlClient

Public Class D_Formulario
    Dim conexion As New MySqlConnection

    Public Function AltaFormulario(form As E_Formulario) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaFormulario",
            .Connection = conexion
        }

        cmd.Parameters.Add("NOMBRE", MySqlDbType.VarChar, 90).Value = form.Nombre
        cmd.Parameters.Add("XML", MySqlDbType.MediumText).Value = form.XML
        cmd.Parameters.Add("V_PREVIA", MySqlDbType.MediumBlob).Value = form.VistaPrevia
        cmd.Parameters.Add("ID_F", MySqlDbType.Int32).Direction = ParameterDirection.Output
        Try
            cmd.ExecuteReader()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            Return 2
        End Try
        Cerrar(conexion)

        form.ID = cmd.Parameters("ID_F").Value
        Console.WriteLine("este form tiene id: " & form.ID)
        Return 1
    End Function

    Public Function AltaPreguntas(form As E_Formulario) As Integer

        For Each p As PreguntaRespuesta In form.PreguntasYRespuestas
            'hacer alta a la tabla preguntas 
            Dim cmd As New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "AltaPregunta",
                .Connection = conexion
            } 'si ya existe retornar la id, como hice con los parametros de los analisis que ya existian.

            cmd.Parameters.Add("PREGUNTA", MySqlDbType.VarChar).Value = p.PreguntaTexto

            Try
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                cmd.Connection.Close()
                Console.WriteLine(ex.Message)
                Return 0
            End Try
        Next

        Return 1
    End Function

    Public Function ListarFormularios() As List(Of E_Formulario)

    End Function


    Public Function ConsultaDatosDeFormulario() As E_Formulario

    End Function

End Class
