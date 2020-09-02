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

    Public Function ModificarPaciente(u As E_Paciente) As Integer
        Dim res As Integer = MyBase.ModificarUsuario(u)

        Select Case res
            Case 1
                conexion.ConnectionString = retornarCString()
                conexion.CursorLocation = adUseClient
                conexion.Open()

                Dim cmd As New Command With {
                .CommandType = adCmdStoredProc,
                .CommandText = "ModificarPaciente",
                .ActiveConnection = conexion
                }
                cmd.Parameters.Append(cmd.CreateParameter("@CI", adInteger, adParamInput, u.Cedula.ToString().Length, u.Cedula))
                cmd.Parameters.Append(cmd.CreateParameter("@OCUPACION", adVarChar, adParamInput, 50, u.Ocupacion))
                cmd.Parameters.Append(cmd.CreateParameter("@E_CIVIL", adVarChar, adParamInput, 7, u.Estado_civil))
                cmd.Parameters.Append(cmd.CreateParameter("@FECHA_NAC", adDBDate, adParamInput, 50, u.FechaNacimiento))
                cmd.Parameters.Append(cmd.CreateParameter("@ETAPA", adChar, adParamInput, 1, u.Etapa.ToString()))
                cmd.Parameters.Append(cmd.CreateParameter("@SEXO", adChar, adParamInput, 1, u.Sexo.ToString()))

                Try
                    cmd.Execute()
                    Return 1
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    Return 0
                End Try

            Case Else
                Return res
        End Select

    End Function

End Class
