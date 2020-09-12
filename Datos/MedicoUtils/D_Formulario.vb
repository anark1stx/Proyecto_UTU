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

    Public Function ModificarFormulario(form As E_Formulario) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "ModificarFormulario",
            .Connection = conexion
        }

        Console.WriteLine("este form tiene id: " & form.ID)
        cmd.Parameters.Add("ID_F", MySqlDbType.Int32).Value = form.ID
        cmd.Parameters.Add("NOMBRE", MySqlDbType.VarChar, 90).Value = form.Nombre
        cmd.Parameters.Add("XML", MySqlDbType.MediumText).Value = form.XML
        cmd.Parameters.Add("V_PREVIA", MySqlDbType.MediumBlob).Value = form.VistaPrevia
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            Return 2
        End Try
        Cerrar(conexion)
        Return 1
    End Function

    Public Function BajaFormulario(form As E_Formulario) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BajaFormulario",
            .Connection = conexion
        }

        Console.WriteLine("este form tiene id: " & form.ID)
        cmd.Parameters.Add("ID_F", MySqlDbType.Int32).Value = form.ID
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            Return 2
        End Try
        Cerrar(conexion)
        Return 1
    End Function

    Function BuscarFormularios(buscar As String) As List(Of E_Formulario)
        Dim leer As MySqlDataReader
        Dim formList As New List(Of E_Formulario)
        If Conectar(conexion) = -1 Then
            formList.Add(New E_Formulario With {.ID = -1})
            Return formList '-1 exit code para conexion fallida
        End If

        Dim cmd = New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "BuscarFormulariosXNombre",
                .Connection = conexion
        }

        cmd.Parameters.Add("NOM_F", MySqlDbType.VarChar, 90).Value = buscar

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            formList.Add(New E_Formulario With {.ID = -2})
            Return formList
        End Try

        If leer.HasRows Then
            While leer.Read()
                Dim f = New E_Formulario With {
                     .ID = leer.GetInt32("ID"),
                     .Nombre = leer.GetString("nombre"),
                     .XML = leer.GetString("xml")
                }
                Dim previa = CType(leer("v_previa"), Byte())
                Dim stream As New IO.MemoryStream(previa)
                f.VistaPrevia = stream.ToArray()
                stream.Close()
                formList.Add(f)
            End While
        Else
            formList.Add(New E_Formulario With {.ID = -8})
        End If

        Cerrar(conexion)

        Return formList
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

    Public Function ConsultaDatosDeFormulario(ID_consulta As Integer) As E_Formulario 'retornar el objeto formulario con todas las respuestas
        Dim formularioConDatos As New E_Formulario
    End Function

    Public Function GuardarDatosFormulario(form As E_Formulario) As Integer 'guardar todas las respuestas a las preguntas hechas.

    End Function

End Class
