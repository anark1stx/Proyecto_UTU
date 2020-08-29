﻿Imports Entidades
Imports ADODB
Imports ADODB.DataTypeEnum
Imports ADODB.CommandTypeEnum
Imports ADODB.ParameterDirectionEnum
Public Class D_Medico
    Dim conexion As New Connection

    Public Function ListarMedicosCI(ci As String) As E_Medico
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = CursorLocationEnum.adUseClient
        conexion.Open()

        Dim leer As New Recordset

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "BuscarMEDICOxCI",
            .ActiveConnection = conexion
        }

        cmd.Parameters.Append(cmd.CreateParameter("@cedula", adInteger, adParamInput, ci))

        leer = cmd.Execute()

        Dim u As New E_Medico

        While Not leer.EOF
            u = New E_Medico With {
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
            u.Especialidad.Add(leer("especialidad").Value)

        End While

        leer.Close()
        conexion.Close()

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
        cmd.Parameters.Append(cmd.CreateParameter("@EXISTE", adInteger, adParamOutput))

        leer = cmd.Execute()

        Dim existe = leer("@EXISTE").Value

        leer.Close()
        conexion.Close()

        Return existe
    End Function

    Public Sub AltaMedico(u As E_Medico)
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = CursorLocationEnum.adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "AltaMedicoSIBIM",
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

    Public Sub AltaMedicoTelefono(u As E_Usuario)
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = CursorLocationEnum.adUseClient
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

    Public Sub AltaMedicoEspecialidad(u As E_Medico)
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = CursorLocationEnum.adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "AltaMedicoEspecialidad",
            .ActiveConnection = conexion
        }

        For Each e As String In u.Especialidad
            cmd.Parameters.Append(cmd.CreateParameter("@CI", u.Cedula))
            cmd.Parameters.Append(cmd.CreateParameter("@ESPECIALIDAD", e))
            cmd.Execute()
        Next

        conexion.Close()
    End Sub

    Public Sub ModificarUsuarioMedico(u As E_Medico)
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = CursorLocationEnum.adUseClient
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

    Public Sub AltaLogicaUsuario(u As E_Medico)
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