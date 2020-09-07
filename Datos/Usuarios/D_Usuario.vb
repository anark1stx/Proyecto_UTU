Imports Entidades
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class D_Usuario
    Inherits D_UsuarioMYSQL
    Dim conexion As New MySqlConnection
    Public Function BuscarUsuariosCI(ci As String, Optional auxiliar As Boolean = False) As E_Usuario
        Dim leer As MySqlDataReader

        conexion.ConnectionString = retornarCStringBD()
        Dim cmd As MySqlCommand

        If Not auxiliar Then
            cmd = New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "BuscarUSUARIOxCI",
                .Connection = conexion
            }
        Else
            cmd = New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "BuscarAUXILIARxCI", 'este procedimiento filtra a aquellos usuarios que no estan en la tabla medico ni paciente, es decir solo a los que estan en la tabla usuario
                .Connection = conexion
            }
        End If

        Dim ultima_ci As Integer = 0
        Dim u As New E_Usuario
        Dim lista As New List(Of String)

        cmd.Parameters.Add("cedula", MySqlDbType.Int32).Value = ci
        Try
            cmd.Connection.Open()
            leer = cmd.ExecuteReader()
            If leer.HasRows Then
                While leer.Read()
                    If ultima_ci <> leer.GetInt32("CI") Then
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
                        Try
                            Dim foto = CType(leer("foto"), Byte())
                            Dim stream As New IO.MemoryStream(foto)
                            u.Foto = stream.ToArray()
                            stream.Close()
                        Catch ex As Exception
                            Console.WriteLine(ex.Message)
                        End Try

                        u.TelefonosLista.Add(leer.GetString("telefono"))
                        ultima_ci = u.Cedula
                    Else
                        u.TelefonosLista.Add(leer.GetString("telefono"))
                    End If
                End While
            Else
                Console.WriteLine("no encontre resultados")
                cmd.Connection.Close()
                Return New E_Usuario With {.Cedula = 0}
            End If
            cmd.Connection.Close()

        Catch ex As Exception
            cmd.Connection.Close()
            Console.WriteLine(ex.Message)
            Return New E_Usuario With {.Cedula = 0}
        End Try

        Return u
    End Function

    Public Overridable Function BuscarUsuariosApellido(ap As String, Optional auxiliar As Boolean = False) As List(Of E_Usuario) '(ap As String, tabla as String) <- tabla en la que debe buscar a los usuarios

        Dim uList As New List(Of E_Usuario)

        Dim listaTel As New List(Of String)

        Dim ultima_ci As Integer = 0

        Dim lastU As New E_Usuario

        conexion.ConnectionString = retornarCStringBD()
        Dim cmd As MySqlCommand

        If Not auxiliar Then
            cmd = New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "BuscarUSUARIOxApellido",
                .Connection = conexion
            }
        Else
            cmd = New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "BuscarUSUARIOxApellido",
                .Connection = conexion
            }
        End If
        cmd.Parameters.Add("apellido1", MySqlDbType.VarChar, 30).Value = ap

        Dim leer As MySqlDataReader
        Try

            cmd.Connection.Open()
            leer = cmd.ExecuteReader()
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
                        Try
                            Dim foto = CType(leer("foto"), Byte())
                            Dim stream As New IO.MemoryStream(foto)
                            lastU.Foto = stream.ToArray()
                            stream.Close()
                        Catch ex As Exception
                            Console.WriteLine(ex.Message)
                        End Try

                        lastU.TelefonosLista.Add(leer.GetString("telefono"))
                        ultima_ci = lastU.Cedula
                    Else
                        lastU.TelefonosLista.Add(leer.GetString("telefono"))
                    End If
                End While
            Else
                cmd.Connection.Close()
                Return New List(Of E_Usuario)(New E_Usuario With {.Cedula = 0})
            End If
            cmd.Connection.Close()

        Catch ex As Exception
            cmd.Connection.Close()
            Console.WriteLine(ex.Message)
            Return New List(Of E_Usuario)(New E_Usuario With {.Cedula = 0})
        End Try

        Return uList
    End Function

    Public Function UsuarioExiste(ci As Integer) As Integer

        conexion.ConnectionString = retornarCStringBD()

        Dim leer As MySqlDataReader

        Dim cmd = New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "USUARIOEXISTE",
                .Connection = conexion
        }
        Dim existe As Integer = 0

        cmd.Parameters.Add("cedula", MySqlDbType.Int32).Value = ci

        cmd.Parameters.Add("EXISTE", MySqlDbType.Int32)
        cmd.Parameters("EXISTE").Direction = ParameterDirection.Output

        Try
            cmd.Connection.Open()
            leer = cmd.ExecuteReader()
            While leer.Read()
                existe = leer("EXISTE")
            End While
            cmd.Connection.Close()
        Catch ex As Exception
            cmd.Connection.Close()
            Console.WriteLine(ex.Message)
            Return 3
        End Try

        Return existe
    End Function

    Public Overridable Function AltaUsuarioSIBIM(u As E_Usuario) As Integer

        Dim mysqlUser As New E_UsuarioMYSQL("u" & u.Cedula, u.Contrasena, u.Rol)
        If MyBase.AltaUsuario(mysqlUser) = 1 Then
            conexion.ConnectionString = retornarCStringBD()

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
                cmd.Connection.Open()
                cmd.ExecuteNonQuery() 'EJECUTO ALTA USUARIOMYSQL-USUARIOSIBIM
                cmd.Connection.Close()
            Catch ex As Exception
                cmd.Connection.Close()
                Return 0 'No se pudo crear usuario
            End Try

            If AltaUsuarioTelefono(u) Then
                Return 1 'todo ok
            Else
                Return 3 'Falla alta telefono
            End If

        Else
            Return 2 'no se pudo crear usuario mysql
        End If

    End Function

    Public Function AltaUsuarioTelefono(u As E_Usuario) As Integer

        conexion.ConnectionString = retornarCStringBD()

        For Each t As String In u.TelefonosLista
            Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaUsuarioTelefono",
            .Connection = conexion
            }

            cmd.Parameters.Add("CI", MySqlDbType.Int32).Value = u.Cedula
            cmd.Parameters.Add("TELEFONO", MySqlDbType.VarChar).Value = t

            Try
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()
                cmd.Connection.Close()
            Catch ex As Exception
                u.ErrMsg = "Error ingresando el teléfono: " & t
                cmd.Connection.Close()
                Return 0 ' no se pudo ingresar telefono
            End Try
        Next

        Return 1
    End Function

    Public Function ModificarUsuario(u As E_Usuario) As Integer
        conexion.ConnectionString = retornarCStringBD()

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
        cmd.Parameters.Add("CI", MySqlDbType.Bit).Value = u.Activo
        cmd.Parameters.Add("CORREO", MySqlDbType.VarChar, 50).Value = u.Correo
        cmd.Parameters.Add("FOTO", MySqlDbType.MediumBlob, u.Foto.Length).Value = u.Foto

        Try
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()
        Catch ex As Exception
            cmd.Connection.Close()
            Return 0 'No se pudo mod usuario
        End Try

        If ModificarUsuarioTelefono(u) Then
            Return 1 'todo ok
        Else
            Return 3 'Falla mod telefono
        End If

    End Function

    Public Function ModificarUsuarioTelefono(u As E_Usuario) As Integer

        If borrarTelefonos(u) = 1 Then

            If AltaUsuarioTelefono(u) = 1 Then
                Return 1
            Else
                Console.WriteLine("error alta telefono")
                Return 0
            End If

        Else
            Return 0
        End If

    End Function

    Public Function borrarTelefonos(u As E_Usuario) As Integer
        conexion.ConnectionString = retornarCStringBD()

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BorrarTelefonos", 'los borra todos
            .Connection = conexion
        }

        cmd.Parameters.Add("cedula", MySqlDbType.Int32).Value = u.Cedula
        Try
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()
        Catch ex As Exception
            conexion.Close()
            u.ErrMsg = "Error borrando los teléfonos"
            Console.WriteLine("Error borrando los teléfonos")
            Return 0 ' no se pudo borrar telefono
        End Try

        Return 1
    End Function

    Public Function BajaLogicaUsuario(u As E_Usuario) As Integer
        conexion.ConnectionString = retornarCStringBD()

        Dim cmd As New MySqlCommand With {
            .Connection = conexion,
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BajaLogicaUsuario"
        }

        cmd.Parameters.Add("CI", MySqlDbType.Int32).Value = u.Cedula
        Try
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()
            Return 1
        Catch ex As Exception
            cmd.Connection.Close()
            Return 0
        End Try
    End Function

    Public Function AltaLogicaUsuario(u As E_Usuario) As Integer
        conexion.ConnectionString = retornarCStringBD()

        Dim cmd As New MySqlCommand With {
            .Connection = conexion,
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaLogicaUsuario"
        }
        cmd.Parameters.Add("CI", MySqlDbType.Int32).Value = u.Cedula
        Try
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()
            Return 1
        Catch ex As Exception
            cmd.Connection.Close()
            Return 0
        End Try
    End Function

End Class
