Imports Utilidades
Imports Entidades
Imports MySql.Data.MySqlClient
Public Class D_Usuario
    Inherits D_UsuarioMYSQL
    Dim conexion As New MySqlConnection

    Public Function LeerFotoUsuario(CI As Integer) As Byte()
        Dim foto As Byte() = {}
        Dim leer As MySqlDataReader
        If Sesion.Conectar(conexion) = -1 Then
            Return {}
        End If

        Dim cmd = New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "LeerFotoUsuario", 'este procedimiento filtra a aquellos usuarios que no estan en la tabla medico ni paciente, es decir solo a los que estan en la tabla usuario
                .Connection = conexion
        }

        cmd.Parameters.Add("cedula", MySqlDbType.Int32).Value = CI

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Sesion.Cerrar(conexion)
            Console.WriteLine("error ejecutando")
            Return {}
        End Try

        If leer.HasRows Then
            While leer.Read()
                foto = CType(leer("foto"), Byte())
            End While
        End If
        Sesion.Cerrar(conexion)
        Return foto
    End Function

    Public Function UsuarioExiste(ci As Integer) As Integer
        If Sesion.Conectar(conexion) = -1 Then
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
            Sesion.Cerrar(conexion)
            Return -2 'error al ejecutar cmd
        End Try

        Sesion.Cerrar(conexion)
        Dim existe As Integer = cmd.Parameters("EXISTE").Value
        Return existe
    End Function

    Public Function AltaModUsuarioSibim(u As E_Usuario, accion As Boolean) As Integer '0=alta, 1=modificacion
        Dim cmd = New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .Connection = conexion
        }
        If Not accion Then 'alta
            Dim mysqlUser As New E_UsuarioMYSQL("u" & u.Cedula, u.Contrasena, u.Rol)
            Dim code = MyBase.AltaUsuario(mysqlUser) 'usuario de mysql
            Select Case code
                Case <> 1
                    Return code
            End Select
            cmd.CommandText = "AltaUsuario"
        Else
            cmd.CommandText = "ModificarUsuario"
        End If

        If Sesion.Conectar(conexion) = -1 Then
            Return -1
        End If

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
            Return -4 'No se pudo crear usuario sibim
        End Try

        Sesion.Cerrar(conexion)
        If AltaUsuarioTelefono(u) Then
            Return 1 'todo ok
        Else
            Return -3 'Falla alta telefono
        End If

    End Function

    Public Function ModificarUsuarioTelefono(u As E_Usuario) As Integer

        If BorrarTelefonos(u.Cedula) = 1 Then

            If AltaUsuarioTelefono(u) = 1 Then
                Return 1 'todo ok
            Else
                Return -2 'error dando de alta telefonos
            End If
        Else
            Return -5 'error borrando telefonos
        End If

    End Function
    Public Function AltaUsuarioTelefono(u As E_Usuario) As Integer
        If Sesion.Conectar(conexion) = -1 Then
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
                Sesion.Cerrar(conexion)
                Return -3
            End Try
        Next

        Sesion.Cerrar(conexion)
        Return 1
    End Function

    Public Function BorrarTelefonos(CI As Integer) As Integer
        If Sesion.Conectar(conexion) = -1 Then
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
            Sesion.Cerrar(conexion)
            Return -2 ' no se pudo borrar telefono
        End Try

        Sesion.Cerrar(conexion)
        Return 1
    End Function

    Public Function A_BLogicaUsuario(CI As Integer, A_B As Boolean) As Integer '0 = baja logica ; 1= alta logica
        If Sesion.Conectar(conexion) = -1 Then
            Return -1
        End If
        Dim cmd As New MySqlCommand With {
            .Connection = conexion,
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "A_BLogicaUsuario"
        }

        cmd.Parameters.Add("cedula", MySqlDbType.Int32).Value = CI
        cmd.Parameters.Add("CAMBIO", MySqlDbType.Bit).Value = A_B
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Sesion.Cerrar(conexion)
            Return -2 'fallo comando exec
        End Try
        Sesion.Cerrar(conexion)
        Return 1
    End Function

End Class
