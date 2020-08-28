Imports Entidades
Imports ADODB
Imports ADODB.DataTypeEnum
Imports ADODB.CommandTypeEnum
Imports ADODB.ParameterDirectionEnum
Public Class D_UsuarioMYSQL
    Dim conexion As New Connection

    Public Function SeleccionarUsuario(usuario As String, contrasena As String) As E_UsuarioMYSQL
        Dim leer As New Recordset With {
            .CursorType = CursorTypeEnum.adOpenDynamic,
            .LockType = LockTypeEnum.adLockOptimistic
        }

        construirCnString(usuario, contrasena)

        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = CursorLocationEnum.adUseClient
        Try
            conexion.Open()
        Catch ex As Exception
            Console.WriteLine("Credenciales Incorrectas, conexion cerrada.")
        End Try

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "BuscarRolUsuarioMYSQL",
            .ActiveConnection = conexion
        }

        cmd.Parameters.Append(cmd.CreateParameter("@USUARIO", adVarChar, adParamInput, 50, usuario))

        leer = cmd.Execute()
        Console.WriteLine(leer.RecordCount)
        Dim u As New E_UsuarioMYSQL

        If leer.RecordCount <> -1 Then
            u = New E_UsuarioMYSQL With {
             .Rol = leer("ROL").Value
            }
        Else
            u = New E_UsuarioMYSQL With {
             .Rol = "Desconocido"
            }

        End If

        leer.Close()
        conexion.Close()

        Return u
    End Function

    Public Sub AltaUsuario(u As E_UsuarioMYSQL)

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "AltaUsuarioMYSQL"
        }
        conexion.Open()
        cmd.Parameters.Append(cmd.CreateParameter("@USUARIO", adVarChar, adParamInput, 50, u.Nombre))
        cmd.Parameters.Append(cmd.CreateParameter("@CONTRASENA", adVarChar, adParamInput, 30, u.Contrasena))
        cmd.Parameters.Append(cmd.CreateParameter("@ROL", adVarChar, adParamInput, 30, u.Rol))

        Try
            cmd.Execute()
            Console.WriteLine("Alta usuario mysql exitosa")
        Catch ex As Exception
            Console.WriteLine("Alta usuario mysql fallo")
        End Try


        conexion.Close()
    End Sub

End Class
