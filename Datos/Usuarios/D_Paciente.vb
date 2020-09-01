Imports Entidades
Imports ADODB
Imports ADODB.DataTypeEnum
Imports ADODB.CommandTypeEnum
Imports ADODB.ParameterDirectionEnum
Imports ADODB.CursorLocationEnum
Public Class D_Paciente
    Inherits D_Usuario
    Dim conexion As New Connection
    Public Function ListarPacientesCI(ci As Integer) As E_Paciente

        Dim result = MyBase.BuscarUsuariosCI(ci)

        If result.Cedula = 0 Then
            Return New E_Paciente With {
            .Cedula = 0
            }
        End If

        Dim leer As New Recordset
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "BuscarPACIENTExCI",
            .ActiveConnection = conexion
        }

        Dim u As New E_Paciente With {
        .Cedula = ci
        }

        cmd.Parameters.Append(cmd.CreateParameter("@cedula", adInteger, adParamInput, 8, ci))
        Try
            leer = cmd.Execute()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            conexion.Close()
            Return u
        End Try

        If leer.RecordCount <= 0 Then
            leer.Close()
            conexion.Close()
            u.Cedula = 0
            Return u
        End If

        Dim lista As New List(Of String)
        While Not leer.EOF
            u = New E_Paciente With {
                 .Cedula = ci,
                 .Nombre1 = result.Nombre1,
                 .Nombre2 = result.Nombre2,
                 .Apellido1 = result.Apellido1,
                 .Apellido2 = result.Apellido2,
                 .Direccion_Calle = result.Direccion_Calle,
                 .Direccion_Numero = result.Direccion_Numero,
                 .Foto = result.Foto,
                 .Correo = result.Correo,
                 .Estado_civil = leer("e_civil").Value,
                 .FechaNacimiento = leer("fecha_nac").Value,
                 .Ocupacion = leer("ocupacion").Value,
                 .Sexo = leer("sexo").Value,
                 .Etapa = leer("etapa").Value
            }

            lista.Add(leer("telefono").Value.ToString())
            leer.MoveNext()
        End While

        u.TelefonosLista = lista.Distinct().ToList()
        leer.Close()
        conexion.Close()

        Return u
    End Function

    Public Function BuscarPacienteApellido(ap As String) As List(Of E_Paciente)

        Dim results = MyBase.BuscarUsuariosApellido(ap)

        If results.Count > 0 Then

            Dim uList As New List(Of E_Paciente)

            For Each p As E_Usuario In results
                uList.Add(ListarPacientesCI(p.Cedula))
            Next

            Return uList
        Else
            Return New List(Of E_Paciente)
        End If

    End Function

    Public Function AltaPaciente(u As E_Paciente) As Integer
        Dim code = MyBase.AltaUsuarioSIBIM(u)

        Select Case code
            Case 1
                conexion.ConnectionString = retornarCString()
                conexion.CursorLocation = adUseClient
                conexion.Open()

                Dim cmd As New Command With {
                    .CommandType = adCmdStoredProc,
                    .CommandText = "AltaPaciente",
                    .ActiveConnection = conexion
                }
                cmd.Parameters.Append(cmd.CreateParameter("@CI", adInteger, adParamInput, u.Cedula.ToString().Length, u.Cedula))
                cmd.Parameters.Append(cmd.CreateParameter("@OCUPACION", adVarChar, adParamInput, 50, u.Ocupacion))
                cmd.Parameters.Append(cmd.CreateParameter("@E_CIVIL", adVarChar, adParamInput, 7, u.Estado_civil))
                cmd.Parameters.Append(cmd.CreateParameter("@FECHA_NAC", adDBDate, adParamInput, 50, u.FechaNacimiento))
                cmd.Parameters.Append(cmd.CreateParameter("@ETAPA", adChar, adParamInput, 1, u.Etapa.ToString()))
                cmd.Parameters.Append(cmd.CreateParameter("@SEXO", adChar, adParamInput, 1, u.Sexo.ToString()))

                Try
                    cmd.Execute() 'EJECUTO ALTA PACIENTESIBIM
                    conexion.Close()
                    Return 1
                Catch ex As Exception
                    conexion.Close()
                    Return 0 'No se pudo crear paciente
                End Try
            Case Else
                Return code
        End Select

    End Function

    Public Sub ModificarPaciente(u As E_Paciente)
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = adUseClient
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
        cmd.Parameters.Append(cmd.CreateParameter("@DIRECCION_C", adVarChar, adParamInput, 160, u.Direccion_Calle))
        cmd.Parameters.Append(cmd.CreateParameter("@DIRECCION_N", adInteger, adParamInput, 4, u.Direccion_Numero))
        cmd.Parameters.Append(cmd.CreateParameter("@ACTIVO", adInteger, adParamInput, 1, u.Activo))
        cmd.Parameters.Append(cmd.CreateParameter("@CORREO", adVarChar, adParamInput, 50, u.Correo))
        Dim ParametroFoto = cmd.CreateParameter("@FOTO", adLongVarBinary, adParamInput, u.Foto.Length)
        ParametroFoto.AppendChunk(u.Foto)
        cmd.Parameters.Append(ParametroFoto)

        cmd.Execute()
        conexion.Close()
    End Sub

End Class
