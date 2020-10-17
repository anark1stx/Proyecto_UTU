Imports Utilidades
Imports Entidades
Imports MySql.Data.MySqlClient
Public Class D_UsuarioMYSQL
    Dim conexion As New MySqlConnection
    Public Function SeleccionarUsuario(usuario As String, contrasena As String) As E_UsuarioMYSQL
        Console.WriteLine("leyendo usuario")
        Dim u As New E_UsuarioMYSQL
        Dim leer As MySqlDataReader
        Sesion = New MySQLSesion(usuario, contrasena)
        Dim exitCode As Integer = Sesion.Conectar(conexion)

        If exitCode <> 1 Then
            Return New E_UsuarioMYSQL With {.ErrCode = exitCode}
        End If

        Dim cmd As New MySqlCommand With {
            .Connection = conexion,
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BuscarRolUsuarioMYSQL"
        }

        cmd.Parameters.Add("USUARIO", MySqlDbType.VarChar, 50).Value = usuario
        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception 'la unica excepcion que se deberia producir en este punto es que el usuario no tenga permisos de ejecucion sobre el procedimiento
            u.ErrCode = -2
            Return u
        End Try

        If leer.HasRows Then
            While leer.Read()
                u.Rol = leer.GetString("ROL")
            End While
        Else 'no tiene rol asignado en la tabla mysql.default_roles
            u.ErrCode = -2
            Return u
        End If

        leer.Close()

        If u.Rol = "administrador" Then
            Sesion.Cerrar(conexion)
            Return u
        End If

        Dim cmd2 As New MySqlCommand With { 'verificar si el usuario de SIBIM fue dado de baja
            .Connection = conexion,
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "ConsultarActivo"
        }

        cmd2.Parameters.Add("CI_U", MySqlDbType.Int32).Value = CInt(usuario.Replace("u", ""))
        Dim activo As Boolean = True 'por defecto todos los usuarios estan de alta = 1

        Try
            leer = cmd2.ExecuteReader()
            While leer.Read()
                activo = leer.GetBoolean("activo")
            End While
        Catch ex As Exception 'la unica excepcion que se deberia producir en este punto es que el usuario no tenga permisos de ejecucion sobre el procedimiento
            Console.WriteLine(ex.Message)
            u.ErrCode = -2
        End Try

        If activo = False Then
            u.Nombre = -3 'de baja
        End If

        Sesion.Cerrar(conexion)
        Return u
    End Function

    Public Function AltaUsuario(u As E_UsuarioMYSQL) As Integer

        If Sesion.Conectar(conexion) = -1 Then 'errores con la conexion
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaUsuarioMYSQL",
            .Connection = conexion
        }

        cmd.Parameters.Add("USUARIO", MySqlDbType.VarChar, 50).Value = u.Nombre
        cmd.Parameters.Add("CONTRASENA", MySqlDbType.VarChar, 30).Value = u.Contrasena
        cmd.Parameters.Add("ROL", MySqlDbType.VarChar, 30).Value = u.Rol

        Try
            cmd.ExecuteNonQuery()
            Return 1 'todo ok
        Catch ex As Exception
            Sesion.Cerrar(conexion)
            Return -2 'Error dando alta usuario mysql
        End Try
        Sesion.Cerrar(conexion)
    End Function

End Class
