Imports Entidades
Imports ADODB
Imports ADODB.DataTypeEnum
Imports ADODB.CommandTypeEnum
Imports ADODB.ParameterDirectionEnum
Imports ADODB.CursorLocationEnum
Public Class D_Medico
    Inherits D_Usuario
    Dim conexion As New Connection

    Public Function ListarMedicosCI(ci As String) As E_Medico
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = adUseClient
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

    Public Function AltaMedico(u As E_Medico)
        Dim code = MyBase.AltaUsuarioSIBIM(u)
        Select Case code
            Case 1
                conexion.ConnectionString = retornarCString()
                conexion.CursorLocation = adUseClient
                conexion.Open()

                Dim cmd As New Command With {
                    .CommandType = adCmdStoredProc,
                    .CommandText = "AltaMedico",
                    .ActiveConnection = conexion
                }
                cmd.Parameters.Append(cmd.CreateParameter("@CI", adInteger, adParamInput, u.Cedula.ToString().Length, u.Cedula))
                Try
                    cmd.Execute() 'EJECUTO ALTA MEDICOSIBIM
                    conexion.Close()
                Catch ex As Exception
                    conexion.Close()
                    Return 0 'No se pudo crear medico
                End Try

                If AltaMedicoEspecialidad(u) Then
                    Return 1 'todo OK
                Else
                    Return 3 'fallo ingreso especialidad
                End If
            Case Else
                Return code
        End Select
        conexion.Close()
    End Function


    Public Function AltaMedicoEspecialidad(u As E_Medico) As Integer
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = adUseClient
        conexion.Open()

        For Each es As String In u.Especialidad
            Dim cmd As New Command With {
            .ActiveConnection = conexion,
            .CommandType = adCmdStoredProc,
            .CommandText = "AltaMedicoEspecialidad"
            }
            cmd.Parameters.Append(cmd.CreateParameter("@CI", adInteger, adParamInput, u.Cedula.ToString().Length, u.Cedula))
            cmd.Parameters.Append(cmd.CreateParameter("@ESPECIALIDAD", adVarChar, adParamInput, es.Length, es))
            Try
                cmd.Execute()
            Catch ex As Exception
                conexion.Close()
                u.ErrMsg = "Error ingresando la especialidad: " & es
                Return 0 ' no se pudo ingresar la especialidad
            End Try
        Next

        conexion.Close()
        Return 1
    End Function
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

End Class
