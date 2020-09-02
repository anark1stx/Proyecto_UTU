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

        Dim intCI As Integer = Val(ci)

        Dim u As New E_Medico With {
        .Cedula = intCI
        }

        cmd.Parameters.Append(cmd.CreateParameter("@cedula", adInteger, adParamInput, 8, intCI))
        Try
            leer = cmd.Execute()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            u.Cedula = 0
            conexion.Close()
            Return u
        End Try

        If leer.RecordCount <= 0 Then
            leer.Close()
            conexion.Close()
            u.Cedula = 0
            Return u
        End If

        Dim listaTel As New List(Of String)
        Dim listaEsp As New List(Of String)
        While Not leer.EOF
            u = New E_Medico With {
             .Nombre1 = leer("nombre1").Value,
             .Nombre2 = leer("nombre2").Value,
             .Apellido1 = leer("apellido1").Value,
             .Apellido2 = leer("apellido2").Value,
             .Correo = leer("correo").Value,
             .Direccion_Calle = leer("direccion_calle").Value,
             .Direccion_Numero = leer("direccion_nroPuerta").Value,
             .Foto = leer("foto").Value,
             .Activo = leer("activo").Value
            }
            listaTel.Add(leer("telefono").Value)
            listaEsp.Add(leer("especialidad").Value)
            leer.MoveNext()
        End While
        u.Cedula = intCI
        u.TelefonosLista = listaTel.Distinct().ToList()
        u.Especialidad = listaEsp.Distinct().ToList()

        leer.Close()
        conexion.Close()

        Return u
    End Function

    Public Function BuscarMedicoApellido(ap As String) As List(Of E_Medico)

        Dim results = MyBase.BuscarUsuariosApellido(ap)

        If results.Count > 0 Then

            Dim uList As New List(Of E_Medico)

            For Each eu As E_Usuario In results
                uList.Add(ListarMedicosCI(eu.Cedula))
            Next

            Return uList
        Else
            Return New List(Of E_Medico)(New E_Medico() With {.Cedula = 0})
        End If

    End Function

    Public Function BuscarMedicoEspecialidad(es As String) As List(Of E_Medico)

        Dim ultima_ci As Integer = 0
        Dim medList As New List(Of E_Medico)

        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = adUseClient
        conexion.Open()

        Dim leer As New Recordset

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "BuscarMEDICOxEspecialidad",
            .ActiveConnection = conexion
        }

        cmd.Parameters.Append(cmd.CreateParameter("@especialidad", adVarChar, adParamInput, es.Length, es))

        Try
            leer = cmd.Execute()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return New List(Of E_Medico)(New E_Medico() {New E_Medico With {.Cedula = 0}})
        End Try

        If leer.RecordCount <= 0 Then
            leer.Close()
            conexion.Close()
            Return New List(Of E_Medico)(New E_Medico() {New E_Medico With {.Cedula = 0}})
        End If

        Dim lastU As New E_Medico

        While Not leer.EOF
            If ultima_ci <> leer("CI").Value Then
                lastU = New E_Medico With {
                .Cedula = leer("CI").Value,
                .Especialidad = New List(Of String)(New String() {})
                }
                lastU.Especialidad.Add(leer("especialidad").Value)
                ultima_ci = lastU.Cedula
                medList.Add(lastU)
            Else
                medList.ElementAt(medList.IndexOf(lastU)).Especialidad.Add("especialidad")
            End If
            leer.MoveNext()
        End While

        leer.Close()
        conexion.Close()

        Dim finalList As New List(Of E_Medico)

        For Each medico As E_Medico In medList
            finalList.Add(ListarMedicosCI(medico.Cedula))
        Next

        Return finalList
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
    Public Function ModificarUsuarioMedico(u As E_Medico) As Integer

        If MyBase.ModificarUsuario(u) Then
            If ModificarMedicoEspecialidad(u) = 1 Then
                Return 1
            Else
                Console.WriteLine("Error modificando especialidades")
                Return 0
            End If
        Else
            Console.WriteLine("Error modificando usuario")
            Return 0
        End If

    End Function

    Public Function ModificarMedicoEspecialidad(u As E_Medico) As Integer

        If BorrarMedicoEspecialidad(u) = 1 Then
            If AltaMedicoEspecialidad(u) = 1 Then
                Return 1
            Else
                Console.WriteLine("Error alta especialidades")
                Return 0
            End If
        Else
            Console.WriteLine("Error borrando especialidades")
            Return 0
        End If
    End Function

    Public Function BorrarMedicoEspecialidad(u As E_Medico)
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "BorrarEspecialidades", 'las borra todas
            .ActiveConnection = conexion
            }
        cmd.Parameters.Append(cmd.CreateParameter("@cedula", adInteger, adParamInput, u.Cedula.ToString().Length, u.Cedula))

        Try
            cmd.Execute()
        Catch ex As Exception
            conexion.Close()
            u.ErrMsg = "Error borrando las especialidades"
            Console.WriteLine("Error borrando las especialidades")
            Return 0 ' no se pudo borrar especialidad
        End Try

        conexion.Close()
        Return 1
    End Function

End Class
