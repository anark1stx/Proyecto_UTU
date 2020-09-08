Imports Utilidades
Imports Entidades
Imports MySql.Data.MySqlClient
Public Class D_Usuario
    Inherits D_UsuarioMYSQL
    Dim conexion As New MySqlConnection

    'este metodo vendria llamado desde otro, ejemplo BuscarPacientesCI
    Public Function BuscarUsuariosCI(ci As Integer) As E_Usuario 'verifico si usuario.CI = [TIPOUSUARIO].CI
        Dim leer As MySqlDataReader
        If Conectar(conexion) = -1 Then
            Return New E_Usuario With {.ErrMsg = -1} '-1 exit code para conexion fallida
        End If

        Dim cmd = New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "BuscarAUXILIARxCI", 'este procedimiento filtra a aquellos usuarios que no estan en la tabla medico ni paciente, es decir solo a los que estan en la tabla usuario
                .Connection = conexion
        }

        Dim u As New E_Usuario
        Dim listaTel As New List(Of String)
        Dim yalei_foto As Boolean = False
        cmd.Parameters.Add("cedula", MySqlDbType.Int32).Value = ci

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            Return New E_Usuario With {.ErrMsg = 2}
        End Try

        If leer.HasRows Then
            While leer.Read()
                u = New E_Usuario With {
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

        Cerrar(conexion)

        Return u
    End Function

    Public Function BuscarUsuariosApellido(ap As String) As List(Of E_Usuario)
        Dim uList As New List(Of E_Usuario)
        Dim ultima_ci As Integer = 0
        Dim lastU As New E_Usuario

        Dim leer As MySqlDataReader

        If Conectar(conexion) = -1 Then
            Return New List(Of E_Usuario)(New E_Usuario With {.ErrMsg = -1})
        End If

        Dim cmd = New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "BuscarAUXILIARxAPELLIDO", 'este procedimiento filtra a aquellos usuarios que no estan en la tabla medico ni paciente, es decir solo a los que estan en la tabla usuario
                .Connection = conexion
        }
        cmd.Parameters.Add("apellido1", MySqlDbType.VarChar, 30).Value = ap

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            Return New List(Of E_Usuario)(New E_Usuario With {.ErrMsg = 2})
        End Try

        If leer.HasRows Then
            While leer.Read()
                If ultima_ci <> leer.GetInt32("CI") Then
                    lastU = New E_Usuario With {
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
                    ultima_ci = lastU.Cedula
                    uList.Add(lastU)
                Else
                    lastU.TelefonosLista.Add(leer.GetString("telefono"))
                End If
            End While
        Else
            uList = New List(Of E_Usuario)(New E_Usuario With {.ErrMsg = 8}) 'no encontre usuarios
        End If

        Cerrar(conexion)
        Return uList
    End Function

    Public Function UsuarioExiste(ci As Integer) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd = New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "USUARIOEXISTE",
                .Connection = conexion
        }

        cmd.Parameters.Add("cedula", MySqlDbType.Int32).Value = ci
        cmd.Parameters.Add("EXISTE", MySqlDbType.Bit, 1).Direction = ParameterDirection.Output

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            Return 2 'error al ejecutar cmd
        End Try

        Cerrar(conexion)
        Dim existe As Integer = cmd.Parameters("EXISTE").Value
        Return existe
    End Function

    Public Function AltaUsuarioSIBIM(u As E_Usuario) As Integer
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
            .CommandText = "AltaUsuario",
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
        Catch ex As Exception
            Return 4 'No se pudo crear usuario sibim
        End Try

        If AltaUsuarioTelefono(u) Then
            Return 1 'todo ok
        Else
            Return 3 'Falla alta telefono
        End If

    End Function

    Public Function AltaUsuarioTelefono(u As E_Usuario) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        For Each t As String In u.TelefonosLista
            Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaUsuarioTelefono",
            .Connection = conexion
            }

            cmd.Parameters.Add("CI", MySqlDbType.Int32).Value = u.Cedula
            cmd.Parameters.Add("TELEFONO", MySqlDbType.VarChar).Value = t

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                u.ErrMsg = "Error ingresando el teléfono: " & t
                Return 3 ' no se pudo ingresar telefono
            End Try
        Next

        Return 1
    End Function

    Public Function ModificarUsuario(u As E_Usuario) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "ModificarUsuario",
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
        Catch ex As Exception
            Cerrar(conexion)
            Return 2 'Falla mod usuario sibim
        End Try

        If ModificarUsuarioTelefono(u) Then
            Cerrar(conexion)
            Return 1 'todo ok
        Else
            Cerrar(conexion)
            Return 3 'Falla mod telefono
        End If

    End Function

    Public Function ModificarUsuarioTelefono(u As E_Usuario) As Integer

        If borrarTelefonos(u.Cedula) = 1 Then

            If AltaUsuarioTelefono(u) = 1 Then
                Return 1 'todo ok
            Else
                Return 2 'error dando de alta telefonos
            End If
        Else
            Return 5 'error borrando telefonos
        End If

    End Function

    Public Function borrarTelefonos(CI As Integer) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If
        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BorrarTelefonos", 'los borra todos
            .Connection = conexion
        }

        cmd.Parameters.Add("cedula", MySqlDbType.Int32).Value = CI
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Cerrar(conexion)
            Return 2 ' no se pudo borrar telefono
        End Try

        Cerrar(conexion)
        Return 1
    End Function

    Public Function BajaLogicaUsuario(CI As Integer) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If
        Dim cmd As New MySqlCommand With {
            .Connection = conexion,
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BajaLogicaUsuario"
        }

        cmd.Parameters.Add("CI", MySqlDbType.Int32).Value = CI
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Cerrar(conexion)
            Return 2 'fallo comando exec
        End Try
        Cerrar(conexion)
        Return 1
    End Function

    Public Function AltaLogicaUsuario(CI As Integer) As Integer
        If Conectar(conexion) Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .Connection = conexion,
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaLogicaUsuario"
        }
        cmd.Parameters.Add("CI", MySqlDbType.Int32).Value = CI
        Try
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Cerrar(conexion)
            Return 2
        End Try
        Cerrar(conexion)
        Return 1
    End Function

End Class
