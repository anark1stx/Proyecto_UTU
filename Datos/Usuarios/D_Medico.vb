Imports Entidades
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class D_Medico
    Inherits D_Usuario
    Dim conexion As New MySqlConnection

    Public Function ListarMedicosCI(ci As Integer) As E_Medico
        Dim result = MyBase.BuscarUsuariosCI(ci)
        If result.Cedula = 0 Then
            Return New E_Medico With {
            .Cedula = 0
            }
        End If

        Dim leer As MySqlDataReader

        conexion.ConnectionString = retornarCStringBD()
        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BuscarPACIENTExCI",
            .Connection = conexion
        }

        Dim u As New E_Medico With {
        .Cedula = ci
        }

        Dim listaTel As New List(Of String)
        Dim listaEsp As New List(Of String)

        cmd.Parameters.Add("cedula", MySqlDbType.Int32).Value = ci

        Try
            cmd.Connection.Open()
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            u.Cedula = 0
            Return u
        End Try

        If leer.HasRows Then

            While leer.Read()
                u = New E_Medico With {
                 .Nombre1 = leer.GetString("nombre1"),
                 .Nombre2 = leer.GetString("nombre2"),
                 .Apellido1 = leer.GetString("apellido1"),
                 .Apellido2 = leer.GetString("apellido2"),
                 .Correo = leer.GetString("correo"),
                 .Direccion_Calle = leer.GetString("direccion_calle"),
                 .Direccion_Numero = leer.GetInt32("direccion_nroPuerta"),
                 .Foto = New Byte() {leer("foto")},
                 .Activo = leer.GetBoolean("activo")
                }
                listaTel.Add(leer.GetString("telefono"))
                listaEsp.Add(leer.GetString("especialidad"))
            End While
            u.Cedula = ci
            u.TelefonosLista = listaTel.Distinct().ToList()
            u.Especialidad = listaEsp.Distinct().ToList()
        End If

        cmd.Connection.Close()
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

        conexion.ConnectionString = retornarCStringBD()

        Dim leer As MySqlDataReader

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BuscarMEDICOxEspecialidad",
            .Connection = conexion
        }
        cmd.Parameters.Add("especialidad", MySqlDbType.VarChar, 50).Value = es

        Try
            cmd.Connection.Open()
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return New List(Of E_Medico)(New E_Medico() {New E_Medico With {.Cedula = 0}})
        End Try


        Dim lastU As New E_Medico

        While leer.Read()
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
        End While

        cmd.Connection.Close()

        If medList.Count < 1 Then
            Return New List(Of E_Medico)(New E_Medico() {New E_Medico With {.Cedula = 0}})
        End If

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
                conexion.ConnectionString = retornarCStringBD()
                Dim cmd As New MySqlCommand With {
                    .CommandType = CommandType.StoredProcedure,
                    .CommandText = "AltaMedico",
                    .Connection = conexion
                }
                cmd.Parameters.Add("cedula", MySqlDbType.Int32).Value = u.Cedula

                Try
                    cmd.Connection.Open()
                    cmd.ExecuteNonQuery() 'EJECUTO ALTA MEDICOSIBIM
                    cmd.Connection.Close()
                Catch ex As Exception

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

    End Function


    Public Function AltaMedicoEspecialidad(u As E_Medico) As Integer
        conexion.ConnectionString = retornarCStringBD()

        For Each es As String In u.Especialidad
            Dim cmd As New MySqlCommand With {
            .Connection = conexion,
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaMedicoEspecialidad"
            }
            cmd.Parameters.Add("CI", MySqlDbType.Int32).Value = u.Cedula
            cmd.Parameters.Add("ESPECIALIDAD", MySqlDbType.VarChar, 50).Value = u.Especialidad

            Try
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()
                cmd.Connection.Close()
            Catch ex As Exception

                u.ErrMsg = "Error ingresando la especialidad: " & es
                Return 0 ' no se pudo ingresar la especialidad
            End Try
        Next

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
        conexion.ConnectionString = retornarCStringBD()

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BorrarEspecialidades", 'las borra todas
            .Connection = conexion
            }
        cmd.Parameters.Add("cedula", MySqlDbType.Int32).Value = u.Cedula

        Try
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()
        Catch ex As Exception
            cmd.Connection.Close()
            u.ErrMsg = "Error borrando las especialidades"
            Console.WriteLine("Error borrando las especialidades")
            Return 0 ' no se pudo borrar especialidad
        End Try

        Return 1
    End Function

End Class
