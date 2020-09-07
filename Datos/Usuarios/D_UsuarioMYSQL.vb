Imports Entidades
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class D_UsuarioMYSQL
    Dim conexion As New MySqlConnection()

    Public Function SeleccionarUsuario(usuario As String, contrasena As String) As E_UsuarioMYSQL

        Dim u As New E_UsuarioMYSQL
        Dim leer As MySqlDataReader

        construirCnString(usuario, contrasena)

        conexion.ConnectionString = retornarCStringBD()
        Console.WriteLine(conexion.ConnectionString)
        Try
            conexion.Open()
        Catch ex As Exception
            conexion.Close()
            Console.WriteLine(ex.Message)
            u.Valido = False
            Return u
        End Try

        Dim cmd As New MySqlCommand With {
            .Connection = conexion,
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BuscarRolUsuarioMYSQL"
        }

        cmd.Parameters.Add("USUARIO", MySqlDbType.VarChar, 50).Value = usuario
        Try
            leer = cmd.ExecuteReader()
            If leer.HasRows Then
                While leer.Read()
                    u = New E_UsuarioMYSQL With {
                     .Rol = leer.GetString("ROL"),
                     .Valido = True
                    }
                End While
            Else
                u = New E_UsuarioMYSQL With {
                     .Rol = "Desconocido",
                     .Valido = False
                    }
            End If
            cmd.Connection.Close()
        Catch ex As Exception '<-REEMPLAZAR ESTO POR ALGO MAS COMUNICATIVO
            Console.WriteLine(ex.Message)
        End Try

        Return u
    End Function

    Public Overridable Function AltaUsuario(u As E_UsuarioMYSQL) As Integer

        conexion.ConnectionString = retornarCStringBD()

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaUsuarioMYSQL",
            .Connection = conexion
        }

        cmd.Parameters.Add("USUARIO", MySqlDbType.VarChar, 50).Value = u.Nombre
        cmd.Parameters.Add("CONTRASENA", MySqlDbType.VarChar, 30).Value = u.Contrasena
        cmd.Parameters.Add("ROL", MySqlDbType.VarChar, 30).Value = u.Rol

        Try
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()
            Return 1
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return 0
        End Try

    End Function

End Class
