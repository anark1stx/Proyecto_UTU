Imports Entidades
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class D_Paciente
    Inherits D_Usuario
    Dim conexion As New MySqlConnection
    Public Function BuscarPacienteCI(ci As Integer) As E_Paciente

        If Conectar(conexion) = -1 Then
            Return New E_Paciente With {.ErrMsg = -1} '-1 exit code para conexion fallida
        End If

        Dim leer As MySqlDataReader
        Dim lista As New List(Of String)

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BuscarPACIENTExCI",
            .Connection = conexion
        }

        Dim u As New E_Paciente With {
        .Cedula = ci
        }

        cmd.Parameters.Add("cedula", MySqlDbType.Int32).Value = ci
        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            Return New E_Paciente With {.ErrMsg = 2} 'error ejecutando
        End Try

        Dim listaTel As New List(Of String)

        If leer.HasRows Then
            While leer.Read
                u.Cedula = leer.GetInt32("CI")
                u.Nombre1 = leer.GetString("nombre1")
                u.Nombre2 = leer.GetString("nombre2")
                u.Apellido1 = leer.GetString("apellido1")
                u.Apellido2 = leer.GetString("apellido2")
                u.Correo = leer.GetString("correo")
                u.Direccion_Calle = leer.GetString("direccion_calle")
                u.Direccion_Numero = leer.GetInt32("direccion_nroPuerta")
                u.Activo = leer.GetBoolean("activo")
                u.TelefonosLista = New List(Of String)(New String() {})
                u.Estado_civil = leer.GetString("e_civil")
                u.FechaNacimiento = leer.GetDateTime("fecha_nac").ToShortDateString() 'esto es para que no salga con el formato: 6/9/2020 00:00:00
                u.Ocupacion = leer.GetString("ocupacion")
                u.Sexo = leer.GetChar("sexo")
                u.Etapa = leer.GetChar("etapa")
                listaTel.Add(leer.GetString("telefono"))

            End While
        Else
            Return New E_Paciente With {.ErrMsg = 8} 'no encontre
        End If

        u.TelefonosLista = listaTel.Distinct.ToList()
        Cerrar(conexion)
        Return u
    End Function

    Public Function BuscarPacienteApellido(ap As String) As List(Of E_Paciente)
        Dim uList As New List(Of E_Paciente)
        Dim listaTel As New List(Of String)
        Dim ultima_ci As Integer = 0
        Dim lastU As New E_Paciente

        Dim leer As MySqlDataReader

        If Conectar(conexion) = -1 Then
            lastU.ErrMsg = -1
            uList.Add(lastU)
            Return uList
        End If

        Dim cmd = New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "BuscarPACIENTExAPELLIDO", 'este procedimiento filtra a aquellos usuarios que no estan en la tabla medico ni paciente, es decir solo a los que estan en la tabla usuario
                .Connection = conexion
        }
        cmd.Parameters.Add("apellido1", MySqlDbType.VarChar, 30).Value = ap

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            lastU.ErrMsg = 2
            uList.Add(lastU)
            Return uList
        End Try

        If leer.HasRows Then
            While leer.Read()
                If ultima_ci <> leer.GetInt32("CI") Then
                    lastU = New E_Paciente With {
                 .Cedula = leer.GetInt32("CI"),
                 .Nombre1 = leer.GetString("nombre1"),
                 .Nombre2 = leer.GetString("nombre2"),
                 .Apellido1 = leer.GetString("apellido1"),
                 .Apellido2 = leer.GetString("apellido2"),
                 .Correo = leer.GetString("correo"),
                 .Direccion_Calle = leer.GetString("direccion_calle"),
                 .Direccion_Numero = leer.GetInt32("direccion_nroPuerta"),
                 .Activo = leer.GetBoolean("activo"),
                 .TelefonosLista = New List(Of String)(New String() {}),
                 .Ocupacion = leer.GetString("ocupacion"),
                 .Estado_civil = leer.GetString("e_civil"),
                 .FechaNacimiento = leer.GetDateTime("fecha_nac").ToShortDateString(),
                 .Etapa = leer.GetChar("etapa"),
                 .Sexo = leer.GetChar("sexo")
                    }
                    lastU.TelefonosLista.Add(leer.GetString("telefono"))
                    ultima_ci = lastU.Cedula
                    uList.Add(lastU)
                Else
                    lastU.TelefonosLista.Add(leer.GetString("telefono"))
                    lastU.TelefonosLista = lastU.TelefonosLista.Distinct().ToList()
                End If
            End While
        Else
            uList.Add(New E_Paciente() With {.ErrMsg = 8}) 'no encontre usuarios
        End If

        Cerrar(conexion)
        Return uList

    End Function

    Public Function AltaPaciente(u As E_Paciente) As Integer

        Dim mysqlUser As New E_UsuarioMYSQL("u" & u.Cedula, u.Contrasena, u.Rol)
        Dim code = MyBase.AltaUsuario(mysqlUser)

        Select Case code
            Case -1, 2
                Return code
        End Select

        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
                    .CommandType = CommandType.StoredProcedure,
                    .CommandText = "AltaPaciente",
                    .Connection = conexion
        }

        cmd.Parameters.Add("CI", MySqlDbType.Int32).Value = u.Cedula
        cmd.Parameters.Add("NOMBRE1", MySqlDbType.VarChar, 30).Value = u.Nombre1
        cmd.Parameters.Add("NOMBRE2", MySqlDbType.VarChar, 30).Value = u.Nombre2
        cmd.Parameters.Add("APELLIDO1", MySqlDbType.VarChar, 30).Value = u.Apellido1
        cmd.Parameters.Add("APELLIDO2", MySqlDbType.VarChar, 30).Value = u.Apellido2
        cmd.Parameters.Add("DIRECCION_C", MySqlDbType.VarChar, 160).Value = u.Direccion_Calle
        cmd.Parameters.Add("DIRECCION_N", MySqlDbType.Int32).Value = u.Direccion_Numero
        cmd.Parameters.Add("ACTIVO", MySqlDbType.Bit).Value = u.Activo
        cmd.Parameters.Add("CORREO", MySqlDbType.VarChar, 50).Value = u.Correo
        cmd.Parameters.Add("FOTO", MySqlDbType.MediumBlob, u.Foto.Length).Value = u.Foto
        cmd.Parameters.Add("OCUPACION", MySqlDbType.VarChar, 50).Value = u.Ocupacion
        cmd.Parameters.Add("E_CIVIL", MySqlDbType.VarChar, 7).Value = u.Estado_civil
        cmd.Parameters.Add("FECHA_NAC", MySqlDbType.DateTime, 50).Value = u.FechaNacimiento
        cmd.Parameters.Add("ETAPA", MySqlDbType.String).Value = u.Etapa
        cmd.Parameters.Add("SEXO", MySqlDbType.String).Value = u.Sexo
        Try
            cmd.ExecuteNonQuery() 'EJECUTO ALTA PACIENTESIBIM
            Cerrar(conexion)
        Catch ex As Exception
            Cerrar(conexion)
            Return 5 'No se pudo crear paciente
        End Try

        If MyBase.AltaUsuarioTelefono(u) Then
            Return 1
        Else
            Return 3
        End If

    End Function

    Public Function ModificarPaciente(u As E_Paciente) As Integer

        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "ModificarPaciente",
        .Connection = conexion
        }
        cmd.Parameters.Add("cedula", MySqlDbType.Int32).Value = u.Cedula
        cmd.Parameters.Add("NOMBRE1", MySqlDbType.VarChar, 30).Value = u.Nombre1
        cmd.Parameters.Add("NOMBRE2", MySqlDbType.VarChar, 30).Value = u.Nombre2
        cmd.Parameters.Add("APELLIDO1", MySqlDbType.VarChar, 30).Value = u.Apellido1
        cmd.Parameters.Add("APELLIDO2", MySqlDbType.VarChar, 30).Value = u.Apellido2
        cmd.Parameters.Add("DIRECCION_C", MySqlDbType.VarChar, 160).Value = u.Direccion_Calle
        cmd.Parameters.Add("DIRECCION_N", MySqlDbType.Int32).Value = u.Direccion_Numero
        cmd.Parameters.Add("ACTIVO", MySqlDbType.Bit).Value = u.Activo
        cmd.Parameters.Add("CORREO", MySqlDbType.VarChar, 50).Value = u.Correo
        cmd.Parameters.Add("FOTO", MySqlDbType.MediumBlob, u.Foto.Length).Value = u.Foto
        cmd.Parameters.Add("OCUPACION", MySqlDbType.VarChar, 50).Value = u.Ocupacion
        cmd.Parameters.Add("E_CIVIL", MySqlDbType.VarChar, 7).Value = u.Estado_civil
        cmd.Parameters.Add("FECHA_NAC", MySqlDbType.DateTime, 50).Value = u.FechaNacimiento
        cmd.Parameters.Add("ETAPA", MySqlDbType.String).Value = u.Etapa
        cmd.Parameters.Add("SEXO", MySqlDbType.String).Value = u.Sexo

        Try
            cmd.ExecuteNonQuery()
            Console.WriteLine("modifique bien")
            Cerrar(conexion)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            Return 2
        End Try

        Dim code = MyBase.ModificarUsuarioTelefono(u)

        Return code

    End Function

    Public Function BuscarMisAnalisis(CI As Integer) As List(Of E_Analisis)
        Dim list As New List(Of E_Analisis)
        Console.WriteLine("cedula a buscar = " & CI)

        If Conectar(conexion) = -1 Then
            list.Add(New E_Analisis With {.ID = -1})
            Return list
        End If

        Dim leer As MySqlDataReader
        Dim cmd As New MySqlCommand With {
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "ListadoAnalisisPaciente",
        .Connection = conexion
        }

        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = CI

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            list.Add(New E_Analisis With {.ID = -2})
            Return list
        End Try

        If leer.HasRows Then
            While leer.Read()
                list.Add(New E_Analisis With {
                .ID = leer.GetInt32("ID"),
                .Nombre = leer.GetString("nombre"),
                .FechaReq = leer.GetDateTime("fecha").ToShortDateString()
                })
            End While
        Else
            list.Add(New E_Analisis With {.ID = -8})
        End If

        Cerrar(conexion)

        Return list
    End Function
    Public Function BuscarMisTratamientos(CI As Integer) As List(Of E_Tratamiento)

    End Function

    Public Function BuscarMisConsultas(CI As Integer) As List(Of E_Atiende)
        Dim list As New List(Of E_Atiende)

        If Conectar(conexion) = -1 Then
            list.Add(New E_Atiende With {.ID = -1})
            Return list
        End If

        Dim leer As MySqlDataReader
        Dim cmd As New MySqlCommand With {
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "BuscarAtiende",
        .Connection = conexion
        }

        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = CI

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            list.Add(New E_Atiende With {.ID = -2})
            Return list
        End Try

        If leer.HasRows Then
            While leer.Read()
                list.Add(New E_Atiende With {
                .ID = leer.GetInt32("ID_consulta"),
                .NombreConsulta = leer.GetString("nombre_ref"),
                .Fecha = leer.GetDateTime("fecha").ToShortDateString()
                })
            End While
        Else
            list.Add(New E_Atiende With {.ID = -8})
        End If

        Cerrar(conexion)

        Return list
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
            Console.WriteLine(ex.Message)
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
            Case -1, -2, -8
                form.ID = r(0).Tag
                Return form
            Case Else
                form.PreguntasYRespuestas = r
        End Select

        Dim r2 = BuscarEnfermedadConsulta(ID_C)

        Select Case r2.Nombre
            Case -1, -2
                form.ID = r2.Nombre
                Return form
        End Select

        form.Enfermedad = r2

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


    Public Function BuscarEnfermedadConsulta(ID_C As Integer) As E_Enfermedad
        Dim enf As New E_Enfermedad
        If Conectar(conexion) = -1 Then
            enf.Nombre = -1
            Return enf
        End If

        Dim leer As MySqlDataReader
        Dim cmd As New MySqlCommand With {
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "ConsultarEnfermedadDeterminada",
        .Connection = conexion
        }

        cmd.Parameters.Add("ID_C", MySqlDbType.Int32).Value = ID_C

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            enf.Nombre = -2
            Return enf
        End Try

        If leer.HasRows Then
            While leer.Read()
                enf = New E_Enfermedad With {
                .Nombre = leer.GetString("nombre_enfermedad")
                }
            End While
        Else
            enf.Nombre = -8
        End If

        Cerrar(conexion)
        If Conectar(conexion) = -1 Then
            enf.Nombre = -1
            Return enf
        End If

        Dim cmd2 As New MySqlCommand With {
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "ConsultarSintomasR",
        .Connection = conexion
        }

        cmd2.Parameters.Add("ID_C", MySqlDbType.Int32).Value = ID_C

        Try
            leer = cmd2.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            enf.Nombre = -2
            Return enf
        End Try

        If leer.HasRows Then
            While leer.Read()
                enf.Sintomas.Add(New E_Enfermedad.Sintoma With {
                .Nombre = leer.GetString("nombre")
                })
            End While
        End If

        Cerrar(conexion)

        If Conectar(conexion) = -1 Then
            enf.Nombre = -1
            Return enf
        End If

        Dim cmd3 As New MySqlCommand With {
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "ConsultarExamenFisico",
        .Connection = conexion
        }

        cmd3.Parameters.Add("ID_C", MySqlDbType.Int32).Value = ID_C

        Try
            leer = cmd3.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            enf.Nombre = -2
            Return enf
        End Try

        If leer.HasRows Then
            While leer.Read()
                enf.SignosClinicos.Add(New E_Enfermedad.SignoClinico With {
                .Nombre = leer.GetString("nombre")
                })
            End While
        End If

        Cerrar(conexion)
        Return enf
    End Function

End Class
