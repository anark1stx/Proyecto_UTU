Imports Entidades
Imports MySql.Data.MySqlClient

Public Class D_Formulario
    Dim conexion As New MySqlConnection

    Public Function AltaModFormulario(form As E_Formulario, altaomod As Boolean) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .Connection = conexion
        }

        If altaomod Then '1=mod
            cmd.CommandText = "ModificarFormulario"
            cmd.Parameters.Add("ID_F", MySqlDbType.Int32).Value = form.ID
        Else
            cmd.CommandText = "AltaFormulario"
            cmd.Parameters.Add("ID_F", MySqlDbType.Int32).Direction = ParameterDirection.Output
        End If

        cmd.Parameters.Add("NOMBRE", MySqlDbType.VarChar, 90).Value = form.Nombre
        cmd.Parameters.Add("XML", MySqlDbType.MediumText).Value = form.XML
        cmd.Parameters.Add("V_PREVIA", MySqlDbType.MediumBlob).Value = form.VistaPrevia

        Try
            cmd.ExecuteReader()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            Return -2
        End Try
        Cerrar(conexion)

        If altaomod Then 'si es una modificacion tiro todos los records de la tabla "de" (ID_F,ID_P)
            Dim res = BorrarPreguntasDeFormulario(form)
            Select Case res
                Case <> 1
                    Return res
            End Select
        End If
        Return AltaPreguntas(form)
    End Function
    Public Function BajaFormulario(form As E_Formulario) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BajaFormulario", 'como todas las tablas tienen ON DELETE CASCADE, si borro el formulario no hace falta tirar un delete a la tabla "de", se borran solas
            .Connection = conexion
        }

        Console.WriteLine("este form tiene id: " & form.ID)
        cmd.Parameters.Add("ID_F", MySqlDbType.Int32).Value = form.ID
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            Return -2
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
                Cerrar(conexion)
                Return -2
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
            Return -2
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
                    Cerrar(conexion)
                Catch ex As Exception
                    Cerrar(conexion)
                    Console.WriteLine(ex.Message)
                    Return -2
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
                Return 0
            End Try
        Next
        Cerrar(conexion)
        Return 1
    End Function

    Public Function AltaFormularioDatos(form As E_Formulario) As Integer
        Dim resultresponde = AltaResponde(form)
        If resultresponde = 1 Then
            Dim resultDetermina = AltaDeterminaEnfermedad(form)
            If resultDetermina = 1 Then
                If form.Enfermedad.SignosClinicos.Count > 0 Then
                    Dim d_sg As New D_SignoClinico
                    For i = 0 To form.Enfermedad.SignosClinicos.Count - 1
                        Dim resultExamenF = d_sg.AltaExamenFisico(form.Enfermedad.SignosClinicos(i), form.Atiende)
                        If resultExamenF <> 1 Then
                            Return resultExamenF
                        End If
                    Next
                End If
                If form.Enfermedad.Sintomas.Count > 0 Then
                    Dim d_sin As New D_Sintoma
                    For i = 0 To form.Enfermedad.Sintomas.Count - 1
                        Dim resultRegistraS = d_sin.AltaRegistraSintoma(form.Enfermedad.Sintomas(i), form.Atiende)
                        If resultRegistraS <> 1 Then
                            Return resultRegistraS
                        End If
                    Next
                End If

                If form.Tratamiento.ID > 0 Then 'si la id del tratamiento es 0 es porque no se cargo ningun tratamiento directamente
                    Dim d_trat As New D_Tratamiento
                    Dim resultTratamiento = AltaSugiereTratamiento(form)
                    If resultTratamiento <> 1 Then
                        Return resultTratamiento
                    End If
                End If

                If form.Analisis.ID > 0 Then
                    Dim resultAnalisis = AsignarAnalisis(form)
                    If resultAnalisis <> 1 Then
                        Return resultAnalisis
                    End If
                End If
                Return FinalizarConsulta(form.Atiende)
            Else
                Return resultDetermina
            End If
        Else
            Return resultresponde
        End If
        Return 1
    End Function

    Public Function FinalizarConsulta(consulta As E_Atiende) As Integer

        If Conectar(conexion) = -1 Then
            Return -1
        End If
        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "FinalizarConsulta",
            .Connection = conexion
        }

        cmd.Parameters.Add("ID_C", MySqlDbType.Int32).Value = consulta.ID
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Cerrar(conexion)
            Console.WriteLine(ex.Message)
            Return -2
        End Try
        Cerrar(conexion)
        Return 1
    End Function

    Public Function AsignarAnalisis(form As E_Formulario) As Integer

        If Conectar(conexion) = -1 Then
            Return -1
        End If
        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaAnalisisRequerido",
            .Connection = conexion
        }

        cmd.Parameters.Add("ID_C", MySqlDbType.Int32).Value = form.Atiende.ID
        cmd.Parameters.Add("FEC_C", MySqlDbType.DateTime).Value = form.Atiende.Fecha
        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = form.Atiende.Paciente.Cedula
        cmd.Parameters.Add("CI_M", MySqlDbType.Int32).Value = form.Atiende.Medico.Cedula
        cmd.Parameters.Add("ID_F", MySqlDbType.Int32).Value = form.ID
        cmd.Parameters.Add("ID_A", MySqlDbType.Int32).Value = form.Analisis.ID
        cmd.Parameters.Add("ID_P", MySqlDbType.Int32)
        For Each p As PreguntaRespuesta In form.PreguntasYRespuestas
            cmd.Parameters("ID_P").Value = p.ID_Pregunta
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Cerrar(conexion)
                Console.WriteLine(ex.Message)
                Return -2
            End Try
        Next
        Cerrar(conexion)
        Return 1
    End Function
    Public Function AltaSugiereTratamiento(form As E_Formulario) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaTratamientoSugerido", '*Alta a la tabla requiere.
            .Connection = conexion
        }
        cmd.Parameters.Add("ID_C", MySqlDbType.Int32).Value = form.Atiende.ID
        cmd.Parameters.Add("FEC_C", MySqlDbType.DateTime).Value = form.Atiende.Fecha
        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = form.Atiende.Paciente.Cedula
        cmd.Parameters.Add("CI_M", MySqlDbType.Int32).Value = form.Atiende.Medico.Cedula
        cmd.Parameters.Add("ID_F", MySqlDbType.Int32).Value = form.ID
        cmd.Parameters.Add("ID_P", MySqlDbType.Int32)
        cmd.Parameters.Add("ID_T", MySqlDbType.Int32).Value = form.Tratamiento.ID

        For Each p As PreguntaRespuesta In form.PreguntasYRespuestas
            cmd.Parameters("ID_P").Value = p.ID_Pregunta
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Cerrar(conexion)
                Console.WriteLine(ex.Message)
                Return -2
            End Try
        Next
        Cerrar(conexion)
        Return 1
    End Function
    Public Function AltaResponde(form As E_Formulario)
        If Conectar(conexion) = -1 Then
            Return -1
        End If
        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaResponde",
            .Connection = conexion
        }
        cmd.Parameters.Add("ID_C", MySqlDbType.Int32).Value = form.Atiende.ID
        cmd.Parameters.Add("FEC_C", MySqlDbType.DateTime).Value = form.Atiende.Fecha
        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = form.Atiende.Paciente.Cedula
        cmd.Parameters.Add("CI_M", MySqlDbType.Int32).Value = form.Atiende.Medico.Cedula
        cmd.Parameters.Add("ID_F", MySqlDbType.Int32).Value = form.ID
        cmd.Parameters.Add("ID_PREG", MySqlDbType.Int32)
        cmd.Parameters.Add("RESPUESTA", MySqlDbType.VarChar)
        For Each pyr As PreguntaRespuesta In form.PreguntasYRespuestas

            cmd.Parameters("ID_PREG").Value = pyr.ID_Pregunta
            Dim r As String = ""
            Select Case pyr.Respuesta.GetType
                Case GetType(Windows.Forms.ListBox)
                    Dim lb = DirectCast(pyr.Respuesta, Windows.Forms.ListBox) 'casteo la respuesta como un string separado por comas
                    For i = 0 To lb.Items.Count - 1
                        r &= lb.Items(i)
                        If i <> lb.Items.Count - 1 Then
                            r &= ","
                        End If
                    Next
                Case GetType(Windows.Forms.CheckBox)
                    r = DirectCast(pyr.Respuesta, Windows.Forms.CheckBox).Checked.ToString()
                Case Else
                    r = pyr.Respuesta.Text
            End Select

            cmd.Parameters("RESPUESTA").Value = r

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Cerrar(conexion)
                Return -2
            End Try

        Next
        Cerrar(conexion)
        Return 1
    End Function
    'mover esto a otra clase de la capa datos
    Public Function AltaDeterminaEnfermedad(form As E_Formulario) As Integer 'este metodo esta aca porque usa mas parametros del formulario y de la consulta que de la enfermedad en si
        If String.IsNullOrWhiteSpace(form.Enfermedad.Nombre) Then
            Return 1
        End If

        Dim df As New D_Enfermedad
        If df.AltaModEnfermedad(form.Enfermedad, 0) <> 1 Then
            Return -2
        End If

        Dim cmd2 As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaDeterminaEnfermedad", '*Alta a la tabla enfermedad.
            .Connection = conexion
        }
        cmd2.Parameters.Add("ID_C", MySqlDbType.Int32).Value = form.Atiende.ID
        cmd2.Parameters.Add("FEC", MySqlDbType.DateTime).Value = form.Atiende.Fecha
        cmd2.Parameters.Add("CI_P", MySqlDbType.Int32).Value = form.Atiende.Paciente.Cedula
        cmd2.Parameters.Add("CI_M", MySqlDbType.Int32).Value = form.Atiende.Medico.Cedula
        cmd2.Parameters.Add("ID_F", MySqlDbType.Int32).Value = form.ID
        cmd2.Parameters.Add("ID_P", MySqlDbType.Int32)
        cmd2.Parameters.Add("NOM_E", MySqlDbType.VarChar, 160).Value = form.Enfermedad.Nombre

        For Each p As PreguntaRespuesta In form.PreguntasYRespuestas
            cmd2.Parameters("ID_P").Value = p.ID_Pregunta
            Try
                cmd2.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine("error alta determina enfermedad" & ex.Message)
                Return -2
            End Try
        Next

        Cerrar(conexion)
        Return 1

    End Function
    Public Function BuscarDiagnostico(ID_C As Integer) As E_Formulario
        Dim form As New E_Formulario
        Dim pyr As New List(Of PreguntaRespuesta)
        If Conectar(conexion) = -1 Then
            form.ID = -1
            Return form
        End If
        Dim cmd As New MySqlCommand With {
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "CargarFormularioUsado",
        .Connection = conexion
        }

        cmd.Parameters.Add("ID_C", MySqlDbType.Int32).Value = ID_C

        Dim leer As MySqlDataReader
        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Console.WriteLine("err cargando formulario usado" & ex.Message)
            Cerrar(conexion)
            form.ID = -2
            Return form
        End Try

        While leer.Read()
            form = New E_Formulario With {
                .XML = leer.GetString("XML")
            }
        End While

        Cerrar(conexion)

        Dim r = BuscarRespuestas(ID_C)
        Select Case r(0).Tag
            Case <> -1
                form.ID = r(0).Tag
                Return form
            Case Else
                form.PreguntasYRespuestas = r
        End Select

        Dim d_enf As New D_Enfermedad
        Dim r2 = d_enf.BuscarEnfermedadConsulta(ID_C)

        Select Case r2.Nombre
            Case <> 1
                form.ID = r2.Nombre
                Return form
        End Select
        form.Enfermedad = r2

        Dim d_an As New D_Analisis
        Dim r3 = d_an.ConsultarAnalisisRequerido(ID_C)
        If r3.ID <> 1 Then
            form.ID = r3.ID
            Return form
        End If
        Dim d_tr As New D_Tratamiento
        Dim r4 = d_tr.ConsultarTratamientoRequerido(ID_C)
        If r4.ID <> 1 Then
            form.ID = r4.ID
            Return form
        End If
        Return form
    End Function

    Public Function BuscarRespuestas(ID_C As Integer) As List(Of PreguntaRespuesta)
        Dim pyr As New List(Of PreguntaRespuesta)
        If Conectar(conexion) = -1 Then
            pyr.Add(New PreguntaRespuesta With {.Tag = -1})
            Return pyr
        End If
        Dim cmd As New MySqlCommand With {
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "BuscarRespuestas",
        .Connection = conexion
        }

        cmd.Parameters.Add("ID_C", MySqlDbType.Int32).Value = ID_C
        Dim leer As MySqlDataReader
        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            Console.WriteLine("err buscando respuestas" & ex.Message)
            pyr.Add(New PreguntaRespuesta With {.Tag = -2})
            Return pyr
        End Try

        While leer.Read()
            pyr.Add(New PreguntaRespuesta With {.Respuesta = New Windows.Forms.Control With {
                        .Name = leer.GetString("nombre_control_respuesta"),
                        .Text = leer.GetString("respuesta")
            }})
        End While
        Cerrar(conexion)
        Return pyr
    End Function
End Class
