Imports Entidades
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class D_Medico
    Inherits D_Usuario
    Dim conexion As New MySqlConnection()

    Public Function ListarMedicosCI(ci As Integer) As E_Medico

        Dim leer As MySqlDataReader

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BuscarMEDICOxCI",
            .Connection = conexion
        }

        If Conectar(conexion) = -1 Then
            Return New E_Medico With {.ErrMsg = -1}
        End If
        Dim u As New E_Medico
        Dim listaEsp As New List(Of String)
        Dim listaTel As New List(Of String)
        Dim yalei_foto As Boolean = False

        cmd.Parameters.Add("cedula", MySqlDbType.Int32).Value = ci

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            u.ErrMsg = 2
            Return u
        End Try

        If leer.HasRows Then
            While leer.Read()
                u = New E_Medico With {
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
                     .Especialidad = New List(Of String)(New String() {})
                }
                listaTel.Add(leer.GetString("telefono"))
                If Not yalei_foto Then
                    Dim foto = CType(leer("foto"), Byte())
                    Dim stream As New IO.MemoryStream(foto)
                    u.Foto = stream.ToArray()
                    stream.Close()
                    yalei_foto = True
                End If

            End While
            u.TelefonosLista = listaTel
        Else
            u.ErrMsg = 8 'no encontre usuario
        End If

        Return u
    End Function

    Public Function BuscarMedicoApellido(ap As String) As List(Of E_Medico)
        Dim uList As New List(Of E_Medico)
        Dim ultima_ci As Integer = 0
        Dim lastU As New E_Medico

        Dim leer As MySqlDataReader

        If Conectar(conexion) = -1 Then
            Return New List(Of E_Medico)(New E_Medico With {.ErrMsg = -1})
        End If

        Dim cmd = New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "BuscarMEDICOxAPELLIDO", 'este procedimiento filtra a aquellos usuarios que no estan en la tabla medico ni paciente, es decir solo a los que estan en la tabla usuario
                .Connection = conexion
        }
        cmd.Parameters.Add("apellido1", MySqlDbType.VarChar, 30).Value = ap

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            Return New List(Of E_Medico)(New E_Medico With {.ErrMsg = 2})
        End Try

        If leer.HasRows Then
            While leer.Read()
                If ultima_ci <> leer.GetInt32("CI") Then
                    lastU = New E_Medico With {
                 .Cedula = leer.GetInt32("CI"),
                 .Nombre1 = leer.GetString("nombre1"),
                 .Nombre2 = leer.GetString("nombre2"),
                 .Apellido1 = leer.GetString("apellido1"),
                 .Apellido2 = leer.GetString("apellido2"),
                 .Correo = leer.GetString("correo"),
                 .Direccion_Calle = leer.GetString("direccion_calle"),
                 .Direccion_Numero = leer.GetInt32("direccion_nroPuerta"),
                 .Activo = leer.GetBoolean("activo"),
                 .TelefonosLista = New List(Of String)(New String() {})
                 }
                    Dim foto = CType(leer("foto"), Byte())
                    Dim stream As New IO.MemoryStream(foto)
                    lastU.Foto = stream.ToArray()
                    stream.Close()
                    lastU.TelefonosLista.Add(leer.GetString("telefono"))
                    lastU.Especialidad.Add(leer.GetString("especialidad"))
                    ultima_ci = lastU.Cedula
                    uList.Add(lastU)
                Else
                    lastU.TelefonosLista.Add(leer.GetString("telefono"))
                    lastU.Especialidad.Add(leer.GetString("especialidad"))
                End If
            End While
        Else
            uList = New List(Of E_Medico)(New E_Medico With {.ErrMsg = 8}) 'no encontre usuarios
        End If

        Cerrar(conexion)
        Return uList

    End Function

    Public Function BuscarMedicoEspecialidad(es As String) As List(Of E_Medico)
        Dim uList As New List(Of E_Medico)
        Dim ultima_ci As Integer = 0
        Dim lastU As New E_Medico

        Dim leer As MySqlDataReader

        If Conectar(conexion) = -1 Then
            Return New List(Of E_Medico)(New E_Medico With {.ErrMsg = -1})
        End If

        Dim cmd = New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "BuscarMEDICOxESPECIALIDAD", 'este procedimiento filtra a aquellos usuarios que no estan en la tabla medico ni paciente, es decir solo a los que estan en la tabla usuario
                .Connection = conexion
        }
        cmd.Parameters.Add("especialidad", MySqlDbType.VarChar, 30).Value = es

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            Return New List(Of E_Medico)(New E_Medico With {.ErrMsg = 2})
        End Try

        If leer.HasRows Then
            While leer.Read()
                If ultima_ci <> leer.GetInt32("CI") Then
                    lastU = New E_Medico With {
                 .Cedula = leer.GetInt32("CI"),
                 .Nombre1 = leer.GetString("nombre1"),
                 .Nombre2 = leer.GetString("nombre2"),
                 .Apellido1 = leer.GetString("apellido1"),
                 .Apellido2 = leer.GetString("apellido2"),
                 .Correo = leer.GetString("correo"),
                 .Direccion_Calle = leer.GetString("direccion_calle"),
                 .Direccion_Numero = leer.GetInt32("direccion_nroPuerta"),
                 .Activo = leer.GetBoolean("activo"),
                 .TelefonosLista = New List(Of String)(New String() {})
                 }
                    Dim foto = CType(leer("foto"), Byte())
                    Dim stream As New IO.MemoryStream(foto)
                    lastU.Foto = stream.ToArray()
                    stream.Close()
                    lastU.TelefonosLista.Add(leer.GetString("telefono"))
                    lastU.Especialidad.Add(leer.GetString("especialidad"))
                    ultima_ci = lastU.Cedula
                    uList.Add(lastU)
                Else
                    lastU.TelefonosLista.Add(leer.GetString("telefono"))
                    lastU.Especialidad.Add(leer.GetString("especialidad"))
                End If
            End While
        Else
            uList = New List(Of E_Medico)(New E_Medico With {.ErrMsg = 8}) 'no encontre usuarios
        End If

        Cerrar(conexion)
        Return uList

    End Function

    Public Function AltaMedico(u As E_Medico)
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
                    .CommandText = "AltaMedico",
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

        Try
            cmd.ExecuteNonQuery()
            Cerrar(conexion)
        Catch ex As Exception
            Cerrar(conexion)
            Return 5 'No se pudo crear medico
        End Try

        If AltaMedicoEspecialidad(u) Then
            Return 1 'todo OK
        Else
            Return 3 'fallo ingreso especialidad
        End If

    End Function

    Public Function AltaMedicoEspecialidad(u As E_Medico) As Integer

        For Each es As String In u.Especialidad
            Dim cmd As New MySqlCommand With {
            .Connection = conexion,
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaMedicoEspecialidad"
            }
            cmd.Parameters.Add("CI", MySqlDbType.Int32).Value = u.Cedula
            cmd.Parameters.Add("ESPECIALIDAD", MySqlDbType.VarChar, 50).Value = es

            If Conectar(conexion) = -1 Then
                Return -1
            End If

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Cerrar(conexion)
                Return 2 ' no se pudo ingresar la especialidad
            End Try
        Next

        Return 1
    End Function
    Public Function ModificarUsuarioMedico(u As E_Medico) As Integer

        Dim exitcode = MyBase.ModificarUsuario(u)

        Select Case exitcode
            Case 1
                Dim exitCode2 = ModificarMedicoEspecialidad(u)
                Select Case exitCode2
                    Case 2
                        Return 5
                    Case Else
                        Return exitCode2
                End Select
            Case Else
                Return exitcode
        End Select

    End Function

    Public Function ModificarMedicoEspecialidad(u As E_Medico) As Integer
        If BorrarMedicoEspecialidad(u) = 1 Then
            Return AltaMedicoEspecialidad(u)
        Else
            Return 2
        End If
    End Function

    Public Function BorrarMedicoEspecialidad(u As E_Medico)

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BorrarEspecialidades", 'las borra todas
            .Connection = conexion
            }
        cmd.Parameters.Add("cedula", MySqlDbType.Int32).Value = u.Cedula

        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Try
            cmd.ExecuteNonQuery()
            Cerrar(conexion)
        Catch ex As Exception
            Cerrar(conexion)
            Return 2 ' no se pudo borrar especialidad
        End Try

        Return 1
    End Function

End Class
