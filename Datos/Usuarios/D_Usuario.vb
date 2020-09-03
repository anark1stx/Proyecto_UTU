Imports Entidades
Imports ADODB
Imports ADODB.DataTypeEnum
Imports ADODB.CommandTypeEnum
Imports ADODB.ParameterDirectionEnum
Imports ADODB.CursorLocationEnum
Public Class D_Usuario
    Inherits D_UsuarioMYSQL
    Dim conexion As New Connection
    Public Function BuscarUsuariosCI(ci As String, Optional auxiliar As Boolean = False) As E_Usuario
        Dim leer As New Recordset
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = adUseClient
        conexion.Open()
        Dim cmd As New Command

        If Not auxiliar Then
            cmd = New Command With {
                .CommandType = adCmdStoredProc,
                .CommandText = "BuscarUSUARIOxCI",
                .ActiveConnection = conexion
            }
        Else
            cmd = New Command With {
                .CommandType = adCmdStoredProc,
                .CommandText = "BuscarAUXILIARxCI",
                .ActiveConnection = conexion
            }
        End If

        cmd.Parameters.Append(cmd.CreateParameter("@cedula", adInteger, adParamInput, 8, ci))

        leer = cmd.Execute()

        Dim u As New E_Usuario

        Dim lista As New List(Of String)
        While Not leer.EOF
            u = New E_Usuario With {
             .Cedula = ci,
             .Nombre1 = leer("nombre1").Value,
             .Nombre2 = leer("nombre2").Value,
             .Apellido1 = leer("apellido1").Value,
             .Apellido2 = leer("apellido2").Value,
             .Correo = leer("correo").Value,
             .Direccion_Calle = leer("direccion_calle").Value,
             .Direccion_Numero = leer("direccion_nroPuerta").Value,
             .Activo = leer("activo").Value,
             .Foto = leer("foto").Value
            }

            lista.Add(leer("telefono").Value.ToString())
            leer.MoveNext()
        End While
        Console.WriteLine("cedula: " & u.Cedula)
        leer.Close()
        conexion.Close()
        Return u
    End Function

    Public Overridable Function BuscarUsuariosApellido(ap As String, Optional auxiliar As Boolean = False) As List(Of E_Usuario) '(ap As String, tabla as String) <- tabla en la que debe buscar a los usuarios
        Dim leer As New Recordset
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = adUseClient
        conexion.Open()
        Dim cmd As New Command

        If Not auxiliar Then
            cmd = New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "BuscarUSUARIOxApellido",
            .ActiveConnection = conexion
            }

        Else
            cmd = New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "BuscarAUXILIARxApellido",
            .ActiveConnection = conexion
            }

        End If

        cmd.Parameters.Append(cmd.CreateParameter("@apellido1", adVarChar, adParamInput, ap.Length, ap))

        leer = cmd.Execute()

        Dim uList As New List(Of E_Usuario)
        If leer.RecordCount < 1 Then
            uList.Add(New E_Usuario With {.Cedula = 0})
            Return uList
        End If

        Dim listaTel As New List(Of String)

        Dim ultima_ci As Integer = 0

        Dim lastU As New E_Usuario

        While Not leer.EOF

            If ultima_ci <> leer("CI").Value Then
                lastU = New E_Usuario With {
                 .Cedula = leer("CI").Value,
                 .Nombre1 = leer("nombre1").Value,
                 .Nombre2 = leer("nombre2").Value,
                 .Apellido1 = leer("apellido1").Value,
                 .Apellido2 = leer("apellido2").Value,
                 .Correo = leer("correo").Value,
                 .Direccion_Calle = leer("direccion_calle").Value,
                 .Direccion_Numero = leer("direccion_nroPuerta").Value,
                 .Activo = leer("activo").Value,
                 .Foto = leer("foto").Value,
                 .TelefonosLista = New List(Of String)(New String() {})
                }

                lastU.TelefonosLista.Add(leer("telefono").Value)
                ultima_ci = lastU.Cedula
                uList.Add(lastU)
            Else
                uList.ElementAt(uList.IndexOf(lastU)).TelefonosLista.Add(leer("telefono").Value)
            End If

            leer.MoveNext()
        End While

        leer.Close()
        conexion.Close()
        Return uList
    End Function

    Public Function UsuarioExiste(ci As Integer) As Integer
        Dim leer As New Recordset
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "USUARIOEXISTE",
            .ActiveConnection = conexion
        }
        Dim existe As Integer = 0

        cmd.Parameters.Append(cmd.CreateParameter("@cedula", adInteger, adParamInput, 8, ci))
        cmd.Parameters.Append(cmd.CreateParameter("EXISTE", adInteger, adParamOutput, existe))

        Try
            leer = cmd.Execute()
        Catch ex As Exception
            conexion.Close()
            Return 0
        End Try

        leer.Close()
        conexion.Close()

        Return existe
    End Function

    Public Overridable Function AltaUsuarioSIBIM(u As E_Usuario) As Integer

        Dim mysqlUser As New E_UsuarioMYSQL("u" & u.Cedula, u.Contrasena, u.Rol)
        If MyBase.AltaUsuario(mysqlUser) = 1 Then
            conexion.ConnectionString = retornarCString()
            conexion.CursorLocation = adUseClient
            conexion.Open()

            Dim cmd As New Command With {
                .CommandType = adCmdStoredProc,
                .CommandText = "AltaUsuario",
                .ActiveConnection = conexion
            }
            cmd.Parameters.Append(cmd.CreateParameter("@CI", adInteger, adParamInput, u.Cedula.ToString().Length, u.Cedula))
            cmd.Parameters.Append(cmd.CreateParameter("@NOMBRE1", adVarChar, adParamInput, 30, u.Nombre1))
            cmd.Parameters.Append(cmd.CreateParameter("@NOMBRE2", adVarChar, adParamInput, 30, u.Nombre2))
            cmd.Parameters.Append(cmd.CreateParameter("@APELLIDO1", adVarChar, adParamInput, 30, u.Apellido1))
            cmd.Parameters.Append(cmd.CreateParameter("@APELLIDO2", adVarChar, adParamInput, 30, u.Apellido2))
            cmd.Parameters.Append(cmd.CreateParameter("@DIRECCION_C", adVarChar, adParamInput, 160, u.Direccion_Calle))
            cmd.Parameters.Append(cmd.CreateParameter("@DIRECCION_N", adInteger, adParamInput, 4, u.Direccion_Numero))
            cmd.Parameters.Append(cmd.CreateParameter("@ACTIVO", adBoolean, adParamInput, 1, u.Activo))
            cmd.Parameters.Append(cmd.CreateParameter("@CORREO", adVarChar, adParamInput, 50, u.Correo))
            cmd.Parameters.Append(cmd.CreateParameter("@FOTO", adVarChar, adParamInput, u.Foto.Length, u.Foto))

            Try
                cmd.Execute() 'EJECUTO ALTA USUARIOMYSQL-USUARIOSIBIM
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
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

        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = adUseClient
        conexion.Open()

        For Each t As String In u.TelefonosLista
            Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "AltaUsuarioTelefono",
            .ActiveConnection = conexion
            }
            cmd.Parameters.Append(cmd.CreateParameter("@CI", adInteger, adParamInput, u.Cedula.ToString().Length, u.Cedula))
            cmd.Parameters.Append(cmd.CreateParameter("@TELEFONO", adVarChar, adParamInput, t.Length, t))
            Try
                cmd.Execute()
                Console.WriteLine("exec")
            Catch ex As Exception
                conexion.Close()
                u.ErrMsg = "Error ingresando el teléfono: " & t
                Return 0 ' no se pudo ingresar telefono
            End Try
        Next

        conexion.Close()
        Return 1
    End Function

    Public Function ModificarUsuario(u As E_Usuario) As Integer
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = adUseClient
        conexion.Open()

        Dim cmd As New Command With {
                .CommandType = adCmdStoredProc,
                .CommandText = "ModificarUsuario",
                .ActiveConnection = conexion
        }
        cmd.Parameters.Append(cmd.CreateParameter("@CI", adInteger, adParamInput, u.Cedula.ToString().Length, u.Cedula))
        cmd.Parameters.Append(cmd.CreateParameter("@NOMBRE1", adVarChar, adParamInput, 30, u.Nombre1))
        cmd.Parameters.Append(cmd.CreateParameter("@NOMBRE2", adVarChar, adParamInput, 30, u.Nombre2))
        cmd.Parameters.Append(cmd.CreateParameter("@APELLIDO1", adVarChar, adParamInput, 30, u.Apellido1))
        cmd.Parameters.Append(cmd.CreateParameter("@APELLIDO2", adVarChar, adParamInput, 30, u.Apellido2))
        cmd.Parameters.Append(cmd.CreateParameter("@DIRECCION_C", adVarChar, adParamInput, 160, u.Direccion_Calle))
        cmd.Parameters.Append(cmd.CreateParameter("@DIRECCION_N", adInteger, adParamInput, 4, u.Direccion_Numero))
        cmd.Parameters.Append(cmd.CreateParameter("@ACTIVO", adBoolean, adParamInput, 1, u.Activo))
        cmd.Parameters.Append(cmd.CreateParameter("@CORREO", adVarChar, adParamInput, 50, u.Correo))
        cmd.Parameters.Append(cmd.CreateParameter("@FOTO", adVarChar, adParamInput, u.Foto.Length, u.Foto))

        Try
            cmd.Execute()
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
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
        Console.WriteLine("borrando telefonos")
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "BorrarTelefonos", 'los borra todos
            .ActiveConnection = conexion
            }
        cmd.Parameters.Append(cmd.CreateParameter("@cedula", adInteger, adParamInput, u.Cedula.ToString().Length, u.Cedula))
        Try
            cmd.Execute()
        Catch ex As Exception
            conexion.Close()
            u.ErrMsg = "Error borrando los teléfonos"
            Console.WriteLine("Error borrando los teléfonos")
            Return 0 ' no se pudo borrar telefono
        End Try

        conexion.Close()
        Return 1

    End Function

    Public Function BajaLogicaUsuario(u As E_Usuario) As Integer
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .ActiveConnection = conexion,
            .CommandType = adCmdStoredProc,
            .CommandText = "BajaLogicaUsuario"
        }
        cmd.Parameters.Append(cmd.CreateParameter("@CI", adInteger, adParamInput, u.Cedula.ToString().Length, u.Cedula))
        Try
            cmd.Execute()
            conexion.Close()
            Return 1
        Catch ex As Exception
            conexion.Close()
            Return 0
        End Try
    End Function

    Public Function AltaLogicaUsuario(u As E_Usuario) As Integer
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .ActiveConnection = conexion,
            .CommandType = adCmdStoredProc,
            .CommandText = "AltaLogicaUsuario"
        }
        cmd.Parameters.Append(cmd.CreateParameter("@CI", u.Cedula))
        Try
            cmd.Execute()
            conexion.Close()
            Return 1
        Catch ex As Exception
            conexion.Close()
            Return 0
        End Try
    End Function

End Class
