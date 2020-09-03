Imports Entidades
Imports ADODB
Imports ADODB.DataTypeEnum
Imports ADODB.CommandTypeEnum
Imports ADODB.ParameterDirectionEnum
Public Class D_UsuarioMYSQL
    Dim conexion As New Connection

    Public Function SeleccionarUsuario(usuario As String, contrasena As String) As E_UsuarioMYSQL

        Dim u As New E_UsuarioMYSQL
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
            u.Valido = False
            Return u
        End Try

        Dim cmd As New Command With {
            .ActiveConnection = conexion,
            .CommandType = adCmdStoredProc,
            .CommandText = "BuscarRolUsuarioMYSQL"
        }

        cmd.Parameters.Append(cmd.CreateParameter("@USUARIO", adVarChar, adParamInput, 50, usuario))

        Try
            leer = cmd.Execute()
        Catch ex As Exception
            Console.WriteLine("no se pudo ejecutar query") '<-REEMPLAZAR ESTO POR ALGO MAS COMUNICATIVO
        End Try

        If leer.RecordCount <> -1 Then
            u = New E_UsuarioMYSQL With {
             .Rol = leer("ROL").Value,
             .Valido = True
            }
        Else
            u = New E_UsuarioMYSQL With {
             .Rol = "Desconocido",
             .Valido = False
            }

        End If

        leer.Close()
        conexion.Close()

        Return u
    End Function

    Public Overridable Function AltaUsuario(u As E_UsuarioMYSQL) As Integer

        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = CursorLocationEnum.adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "AltaUsuarioMYSQL",
            .ActiveConnection = conexion
        }


        cmd.Parameters.Append(cmd.CreateParameter("@USUARIO", adVarChar, adParamInput, 50, u.Nombre))
        cmd.Parameters.Append(cmd.CreateParameter("@CONTRASENA", adVarChar, adParamInput, 30, u.Contrasena))
        cmd.Parameters.Append(cmd.CreateParameter("@ROL", adVarChar, adParamInput, 30, u.Rol))

        Try
            cmd.Execute()
            conexion.Close()
            Return 1
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            conexion.Close()
            Return 0
        End Try

    End Function

End Class
