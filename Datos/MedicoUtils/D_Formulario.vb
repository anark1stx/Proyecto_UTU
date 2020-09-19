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

        Dim result = AltaPreguntas(form)

        Return result
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

        Dim result = BorrarPreguntasDeFormulario(form)
        Select Case result
            Case -1, 2
                Return result
        End Select
        Dim result2 = AltaPreguntas(form)
        Return result2
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

    Public Function CargarIDpregunta(pList As List(Of PreguntaRespuesta)) As Integer

        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim leer As MySqlDataReader
        For Each p As PreguntaRespuesta In pList
            Dim cmd As New MySqlCommand With {
                    .CommandType = CommandType.StoredProcedure,
                    .CommandText = "BuscarPregunta",
                    .Connection = conexion
            }
            cmd.Parameters.Add("PREG", MySqlDbType.VarChar).Value = p.Pregunta.Text

            'busco la pregunta, leo la ID y la guardo
            Try
                leer = cmd.ExecuteReader()
            Catch ex As Exception
                Console.WriteLine("ERROR BUSCANDO IDPREG: " & ex.Message)
                Cerrar(conexion)
                Return 2
            End Try
            If leer.HasRows Then
                While leer.Read()
                    p.ID_Pregunta = leer.GetInt32("ID")
                    Console.WriteLine("la ID de la pregunta " & p.Pregunta.Text & " es: " & p.ID_Pregunta)
                End While
                leer.Close()
            End If

        Next
        Return 1
    End Function
    Public Function BorrarPreguntasDeFormulario(form As E_Formulario) 'voy a usar este metodo en modificar, borro todas las preguntas y las vuelvo a agregar.
        If Conectar(conexion) = -1 Then
            Return -1
        End If
        Dim cmd As New MySqlCommand With {
                    .CommandType = CommandType.StoredProcedure,
                    .CommandText = "BajaPreguntasDeFormulario",
                    .Connection = conexion
        }
        cmd.Parameters.Add("ID_F", MySqlDbType.Int32).Value = form.ID
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Cerrar(conexion)
            Console.WriteLine(ex.Message)
            Return 2
        End Try
        Cerrar(conexion)
        Return 1
    End Function
    Public Function AltaPreguntas(form As E_Formulario) As Integer
        For Each p As PreguntaRespuesta In form.PreguntasYRespuestas
            If Conectar(conexion) = -1 Then
                Return -1
            End If
            'hacer alta a la tabla preguntas 
            Dim cmd As New MySqlCommand With {
                    .CommandType = CommandType.StoredProcedure,
                    .CommandText = "AltaPregunta", 'este proc usa insert ignore, y devuelve la ID de la pregunta
                    .Connection = conexion
            }
            If p.ID_Pregunta = 0 Then
                Console.WriteLine("preguntatext: " & p.Pregunta.Text)
                cmd.Parameters.Add("PREG", MySqlDbType.VarChar).Value = p.Pregunta.Text
                cmd.Parameters.Add("ID_P", MySqlDbType.Int32).Direction = ParameterDirection.Output

                Try
                    cmd.ExecuteNonQuery()
                    p.ID_Pregunta = cmd.Parameters("ID_P").Value
                    Console.WriteLine("La ID pregunta es: " & p.ID_Pregunta)
                    Cerrar(conexion)
                Catch ex As Exception
                    Cerrar(conexion)
                    Console.WriteLine(ex.Message)
                    Return 2
                End Try
            End If

            If Conectar(conexion) = -1 Then
                Return -1
            End If

            Dim cmd2 As New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "AltaPreguntaDeFormulario", 'alta a la tabla "de"
                .Connection = conexion
            }

            cmd2.Parameters.Add("ID_P", MySqlDbType.Int32).Value = p.ID_Pregunta
            cmd2.Parameters.Add("ID_F", MySqlDbType.Int32).Value = form.ID
            cmd2.Parameters.Add("NOM_CONTROL_P", MySqlDbType.VarChar).Value = p.Pregunta.Name
            cmd2.Parameters.Add("NOM_CONTROL_R", MySqlDbType.VarChar).Value = p.Respuesta.Name
            Try
                cmd2.ExecuteNonQuery()
                Console.WriteLine("INSERTO: pregunta" & p.ID_Pregunta & " formulario: " & form.ID & " nomcontrolp: " & p.Pregunta.Name & " nomcontrolr: " & p.Respuesta.Name)
                Cerrar(conexion)
            Catch ex As Exception
                Cerrar(conexion)
                Console.WriteLine(ex.Message)
                Return 0
            End Try
        Next
        Cerrar(conexion)
        Return 1
    End Function

    Public Function ConsultaDatosDeFormulario(ID_consulta As Integer) As E_Formulario 'retornar el objeto formulario con todas las respuestas
        Dim formularioConDatos As New E_Formulario
        'leer la id de las preguntas
    End Function

    Public Function AltaFormularioDatos(form As E_Formulario) As Integer
        Dim resultatiende = AltaAtiende(form)
        If resultatiende = 1 Then
            Dim resultresponde = AltaResponde(form)
            If resultresponde = 1 Then
                Dim resultsignoclinico = AltaSignosClinicos(form)
                If resultsignoclinico = 1 Then
                    Dim resultsintoma = AltaSintomas(form)
                    If resultsintoma = 1 Then
                        Return AltaDeterminaEnfermedad(form)
                    Else
                        Return resultsintoma
                    End If
                Else
                    Return resultsignoclinico
                End If
            Else
                Return resultresponde
            End If
        Else
            Return resultatiende
        End If
    End Function
    Public Function AltaAtiende(form As E_Formulario)
        If Conectar(conexion) = -1 Then
            Return -1
        End If
        Dim leer As MySqlDataReader
        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaAtiende", '*Alta a la tabla atiende*.
            .Connection = conexion
        }
        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = form.Paciente.Cedula
        cmd.Parameters.Add("CI_M", MySqlDbType.Int32).Value = form.Medico.Cedula
        cmd.Parameters.Add("NOM_CONSULTA", MySqlDbType.VarChar).Value = form.NombreConsulta

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            Return 2
        End Try

        While leer.Read()
            form.Id_consulta = leer.GetInt32("ID_consulta")
        End While

        Cerrar(conexion)

        Return 1
    End Function
    Public Function AltaResponde(form As E_Formulario)
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        For Each pyr As PreguntaRespuesta In form.PreguntasYRespuestas
            Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaResponde", '*Alta a la tabla responde*, sintoma,enfermedad,registra,examenfisico.
            .Connection = conexion
            }
            cmd.Parameters.Add("ID_C", MySqlDbType.Int32).Value = form.Id_consulta
            cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = form.Paciente.Cedula
            cmd.Parameters.Add("CI_M", MySqlDbType.Int32).Value = form.Medico.Cedula
            cmd.Parameters.Add("ID_F", MySqlDbType.Int32).Value = form.ID
            cmd.Parameters.Add("ID_PREG", MySqlDbType.Int32).Value = pyr.ID_Pregunta

            Select Case pyr.Respuesta.GetType
                Case GetType(Windows.Forms.ListBox)
                    Dim lb = DirectCast(pyr.Respuesta, Windows.Forms.ListBox)
                    Dim strings = ""
                    For i = 0 To lb.Items.Count - 1
                        strings &= lb.Items(i)
                        If i <> lb.Items.Count - 1 Then
                            strings &= ","
                        End If
                    Next
                    cmd.Parameters.Add("RESPUESTA", MySqlDbType.VarChar).Value = strings
                Case GetType(Windows.Forms.CheckBox)
                    cmd.Parameters.Add("RESPUESTA", MySqlDbType.VarChar).Value = DirectCast(pyr.Respuesta, Windows.Forms.CheckBox).Checked.ToString()
                Case Else
                    cmd.Parameters.Add("RESPUESTA", MySqlDbType.VarChar).Value = pyr.Respuesta.Text
            End Select

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Cerrar(conexion)
                Return 2
            End Try

        Next
        Cerrar(conexion)
        Return 1
    End Function
    Public Function AltaSignosClinicos(form As E_Formulario)
        If Conectar(conexion) = -1 Then
            Return -1
        End If
        Dim leer As MySqlDataReader
        For Each signo As E_Enfermedad.SignoClinico In form.Enfermedad.SignosClinicos
            Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaSignoClinico", '*Alta a la tabla signo.
            .Connection = conexion
            }
            cmd.Parameters.Add("NOM", MySqlDbType.VarChar).Value = signo.Nombre

            Try
                leer = cmd.ExecuteReader()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Cerrar(conexion)
                Return 2
            End Try
            While leer.Read()
                signo.ID = leer.GetInt32("ID")
            End While
            leer.Close()

            Dim cmd2 As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaExamenFisico", '*Alta a la tabla examenfisico.
            .Connection = conexion
            }

            cmd2.Parameters.Add("ID_C", MySqlDbType.Int32).Value = form.Id_consulta
            cmd2.Parameters.Add("CI_P", MySqlDbType.Int32).Value = form.Paciente.Cedula
            cmd2.Parameters.Add("ID_S", MySqlDbType.Int32).Value = signo.ID

            Try
                cmd2.ExecuteNonQuery()
            Catch ex As Exception
                Cerrar(conexion)
                Console.WriteLine(ex.Message)
                Return 2
            End Try
        Next

        Cerrar(conexion)
        Return 1
    End Function
    Public Function AltaSintomas(form As E_Formulario)
        If Conectar(conexion) = -1 Then
            Return -1
        End If
        Dim leer As MySqlDataReader
        For Each sintoma As E_Enfermedad.Sintoma In form.Enfermedad.Sintomas
            Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaSintoma", '*Alta a la tabla sintoma.
            .Connection = conexion
            }
            cmd.Parameters.Add("NOM", MySqlDbType.VarChar).Value = sintoma.Nombre

            Try
                leer = cmd.ExecuteReader()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Cerrar(conexion)
                Return 2
            End Try
            While leer.Read()
                sintoma.ID = leer.GetInt32("ID")
            End While
            leer.Close()

            Dim cmd2 As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaRegistraSintoma", '*Alta a la tabla registra.
            .Connection = conexion
            }

            cmd2.Parameters.Add("ID_C", MySqlDbType.Int32).Value = form.Id_consulta
            cmd2.Parameters.Add("CI_P", MySqlDbType.Int32).Value = form.Paciente.Cedula
            cmd2.Parameters.Add("ID_S", MySqlDbType.Int32).Value = sintoma.ID

            Try
                cmd2.ExecuteNonQuery()
            Catch ex As Exception
                Cerrar(conexion)
                Console.WriteLine(ex.Message)
                Return 2
            End Try
        Next

        Cerrar(conexion)
        Return 1
    End Function

    Public Function AltaDeterminaEnfermedad(form As E_Formulario) As Integer 'primero alta a enfermedad y luego a determina.
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaEnfermedad", '*Alta a la tabla enfermedad.
            .Connection = conexion
        }
        cmd.Parameters.Add("NOM", MySqlDbType.VarChar).Value = form.Enfermedad.Nombre

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return 2
        End Try

        Dim cmd2 As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaDeterminaEnfermedad", '*Alta a la tabla enfermedad.
            .Connection = conexion
        }
        cmd2.Parameters.Add("ID_C", MySqlDbType.Int32).Value = form.Id_consulta
        cmd2.Parameters.Add("CI_P", MySqlDbType.Int32).Value = form.Paciente.Cedula
        cmd2.Parameters.Add("NOM_E", MySqlDbType.VarChar, 160).Value = form.Enfermedad.Nombre

        Try
            cmd2.ExecuteNonQuery()
            Console.WriteLine("agregando a determina enfermedad")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return 2
        End Try

        Cerrar(conexion)
        Return 1

    End Function

    Public Function AltaRequiereAnalisis(form As E_Formulario) As Integer 'esta funcion solo se va a poder ejecutar desde el toolstripbutton "asignar a paciente"
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaAnalisisRequerido", '*Alta a la tabla requiere.
            .Connection = conexion
        }
        cmd.Parameters.Add("ID_C", MySqlDbType.Int32).Value = form.Id_consulta
        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = form.Paciente.Cedula
        cmd.Parameters.Add("ID_A", MySqlDbType.Int32).Value = form.Analisis.ID

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return 2
        End Try
        Return 1
    End Function

    Public Function AltaSugiereTratamiento(form As E_Formulario) As Integer 'esta funcion solo se va a poder ejecutar desde el toolstripbutton "asignar a paciente"
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaTratamientoSugerido", '*Alta a la tabla requiere.
            .Connection = conexion
        }
        cmd.Parameters.Add("ID_C", MySqlDbType.Int32).Value = form.Id_consulta
        cmd.Parameters.Add("ID_T", MySqlDbType.Int32).Value = form.Tratamiento.ID
        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = form.Paciente.Cedula

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return 2
        End Try
        Return 1
    End Function

End Class
