Imports Entidades
Imports ADODB
Imports ADODB.DataTypeEnum
Imports ADODB.CommandTypeEnum
Imports ADODB.ParameterDirectionEnum
Public Class D_Usuario
    Dim conexion As New Connection
    Public Overridable Function ListarUsuariosCI(ci As String) As E_Usuario
        conexion.ConnectionString = retornarCString()
        Dim leer As New Recordset

        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "BuscarUSUARIOxCI",
            .ActiveConnection = conexion
        }

        cmd.Parameters.Append(cmd.CreateParameter("@cedula", adInteger, adParamInput, ci))

        leer = cmd.Execute()

        Dim u As New E_Usuario

        While leer.EOF
            u = New E_Usuario With {
             .Cedula = leer("CI").Value,
             .Nombre1 = leer("nombre1").Value,
             .Nombre2 = leer("nombre2").Value,
             .Apellido1 = leer("apellido1").Value,
             .Apellido2 = leer("apellido2").Value,
             .Correo = leer("correo").Value,
             .Direccion = New List(Of String)(New String() {leer("direccion_calle").Value, leer("direccion_nroPuerta").Value}),
             .Foto = leer("foto").Value
            }

            u.TelefonosLista.Add(leer("telefono").Value)
        End While

        conexion.Close()
        leer.Close()

        Return u
    End Function

    Public Overridable Sub AltaUsuario(u As E_Usuario)

        conexion.ConnectionString = retornarCString()

        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "AltaUsuarioSIBIM",
            .ActiveConnection = conexion
        }

        cmd.Parameters.Append(cmd.CreateParameter("@CI", adInteger, adParamInput, u.Cedula))
        cmd.Parameters.Append(cmd.CreateParameter("@NOMBRE1", adVarChar, adParamInput, 30, u.Nombre1))
        cmd.Parameters.Append(cmd.CreateParameter("@NOMBRE2", adVarChar, adParamInput, 30, u.Nombre2))
        cmd.Parameters.Append(cmd.CreateParameter("@APELLIDO1", adVarChar, adParamInput, 30, u.Apellido1))
        cmd.Parameters.Append(cmd.CreateParameter("@APELLIDO2", adVarChar, adParamInput, 30, u.Apellido2))
        cmd.Parameters.Append(cmd.CreateParameter("@DIRECCION_C", adVarChar, adParamInput, 160, u.Direccion(0)))
        cmd.Parameters.Append(cmd.CreateParameter("@DIRECCION_N", adInteger, adParamInput, 4, CInt(u.Direccion(1))))
        cmd.Parameters.Append(cmd.CreateParameter("@ACTIVO", adInteger, adParamInput, 1, u.Activo))
        cmd.Parameters.Append(cmd.CreateParameter("@CORREO", adVarChar, adParamInput, 50, u.Correo))
        Dim ParametroFoto = cmd.CreateParameter("@FOTO", adLongVarBinary, adParamInput, u.Foto.Length)
        ParametroFoto.AppendChunk(u.Foto)
        cmd.Parameters.Append(ParametroFoto)

        cmd.Execute()
        conexion.Close()

    End Sub

    Public Overridable Sub AltaUsuarioTelefono(u As E_Usuario)

        conexion.ConnectionString = retornarCString()

        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "AltaUsuarioTelefono",
            .ActiveConnection = conexion
        }

        For Each t As String In u.TelefonosLista
            cmd.Parameters.Append(cmd.CreateParameter("@CI", u.Cedula))
            cmd.Parameters.Append(cmd.CreateParameter("@TELEFONO", CInt(t)))
            cmd.Execute()
        Next

        conexion.Close()
    End Sub

    Public Overridable Sub ModificarUsuario(u As E_Usuario)
        conexion.ConnectionString = retornarCString()

        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "ModificarUsuario",
            .ActiveConnection = conexion
        }

        cmd.Parameters.Append(cmd.CreateParameter("@CI", adInteger, adParamInput, u.Cedula))
        cmd.Parameters.Append(cmd.CreateParameter("@NOMBRE1", adVarChar, adParamInput, 30, u.Nombre1))
        cmd.Parameters.Append(cmd.CreateParameter("@NOMBRE2", adVarChar, adParamInput, 30, u.Nombre2))
        cmd.Parameters.Append(cmd.CreateParameter("@APELLIDO1", adVarChar, adParamInput, 30, u.Apellido1))
        cmd.Parameters.Append(cmd.CreateParameter("@APELLIDO2", adVarChar, adParamInput, 30, u.Apellido2))
        cmd.Parameters.Append(cmd.CreateParameter("@DIRECCION_C", adVarChar, adParamInput, 160, u.Direccion(0)))
        cmd.Parameters.Append(cmd.CreateParameter("@DIRECCION_N", adInteger, adParamInput, CInt(u.Direccion(1))))
        cmd.Parameters.Append(cmd.CreateParameter("@ACTIVO", adInteger, adParamInput, u.Activo))
        cmd.Parameters.Append(cmd.CreateParameter("@CORREO", adVarChar, adParamInput, 50, u.Correo))
        cmd.Parameters.Append(cmd.CreateParameter("@FOTO", adBinary, adParamInput, 160, u.Foto))

        cmd.Execute()
        conexion.Close()
    End Sub

    Public Overridable Sub BajaLogicaUsuario(u As E_Usuario)
        conexion.ConnectionString = retornarCString()

        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "BajaLogicaUsuario",
            .ActiveConnection = conexion
        }

        cmd.Parameters.Append(cmd.CreateParameter("@CI", u.Cedula))
        cmd.Execute()
        conexion.Close()
    End Sub

    Public Overridable Sub AltaLogicaUsuario(u As E_Usuario)
        conexion.ConnectionString = retornarCString()

        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "AltaLogicaUsuario",
            .ActiveConnection = conexion
        }

        cmd.Parameters.Append(cmd.CreateParameter("@CI", u.Cedula))
        cmd.Execute()
        conexion.Close()
    End Sub

End Class
