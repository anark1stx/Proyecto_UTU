Imports Entidades
Imports ADODB
Imports ADODB.DataTypeEnum
Imports ADODB.CommandTypeEnum
Imports ADODB.ParameterDirectionEnum
Public Class D_Paciente
    Dim conexion As New Connection
    Public Function ListarPacientesCI(ci As String) As E_Paciente
        Dim leer As New Recordset
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = CursorLocationEnum.adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "BuscarUSUARIOxCI",
            .ActiveConnection = conexion
        }

        cmd.Parameters.Append(cmd.CreateParameter("@cedula", adInteger, adParamInput, ci))

        leer = cmd.Execute()

        Dim u As New E_Paciente

        While Not leer.EOF
            u = New E_Paciente With {
             .Cedula = leer("CI").Value,
             .Nombre1 = leer("nombre1").Value,
             .Nombre2 = leer("nombre2").Value,
             .Apellido1 = leer("apellido1").Value,
             .Apellido2 = leer("apellido2").Value,
             .Correo = leer("correo").Value,
             .Direccion = New List(Of String)(New String() {leer("direccion_calle").Value, leer("direccion_nroPuerta").Value}),
             .Foto = leer("foto").Value,
             .Estado_civil = leer("e_civil").Value,
             .FechaNacimiento = leer("fecha_nac").Value,
             .Ocupacion = leer("ocupacion").Value,
             .Sexo = leer("sexo").Value
            }
            u.TelefonosLista.Add(leer("telefono").Value)
        End While

        conexion.Close()
        leer.Close()

        Return u
    End Function

    Public Function UsuarioExiste(ci As String)
        Dim leer As New Recordset
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = CursorLocationEnum.adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "USUARIOEXISTE",
            .ActiveConnection = conexion
        }

        cmd.Parameters.Append(cmd.CreateParameter("@cedula", adInteger, adParamInput, ci))
        cmd.Parameters.Append(cmd.CreateParameter("EXISTE", adInteger, adParamOutput))

        leer = cmd.Execute()

        Dim existe = leer("EXISTE").Value

        leer.Close()
        conexion.Close()

        Return existe
    End Function

    Public Sub AltaPaciente(u As E_Paciente)
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = CursorLocationEnum.adUseClient
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
        cmd.Parameters.Append(cmd.CreateParameter("@ETAPA", adChar, adParamInput, 1, u.Activo))


        cmd.Execute()
        conexion.Close()
    End Sub

    Public Sub ModificarPaciente(u As E_Paciente)
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = CursorLocationEnum.adUseClient
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

    Public Sub BajaLogicaUsuario(u As E_Usuario)
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = CursorLocationEnum.adUseClient
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

    Public Sub AltaLogicaUsuario(u As E_Usuario)
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = CursorLocationEnum.adUseClient
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
