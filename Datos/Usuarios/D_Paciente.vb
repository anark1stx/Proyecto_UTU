Imports Entidades
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class D_Paciente
    Inherits D_Usuario
    Dim conexion As New MySqlConnection
    Public Function ListarPacientesCI(ci As Integer) As E_Paciente

        Dim result = MyBase.BuscarUsuariosCI(ci)

        If result.Cedula = 0 Then
            Return New E_Paciente With {
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

        Dim u As New E_Paciente With {
        .Cedula = ci
        }

        cmd.Parameters.Add("cedula", MySqlDbType.Int32).Value = ci
        Try
            cmd.Connection.Open()
            leer = cmd.ExecuteReader()
            Dim lista As New List(Of String)

            If leer.HasRows Then
                While leer.Read
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
                         .Estado_civil = leer.GetString("e_civil"),
                         .FechaNacimiento = leer.GetDateTime("fecha_nac").ToShortDateString(), 'esto es para que no salga con el formato: 6/9/2020 00:00:00
                         .Ocupacion = leer.GetString("ocupacion"),
                         .Sexo = leer.GetChar("sexo"),
                         .Etapa = leer.GetChar("etapa")
                    }

                    lista.Add(leer.GetString("telefono"))
                End While
            End If
            cmd.Connection.Close()
            u.TelefonosLista = lista.Distinct().ToList()
        Catch ex As Exception
            cmd.Connection.Close()
            Console.WriteLine(ex.Message)
            Return u
        End Try

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
            Return New List(Of E_Paciente)(New E_Paciente() {New E_Paciente With {.Cedula = 0}})
        End If

    End Function

    Public Function AltaPaciente(u As E_Paciente) As Integer
        Dim code = MyBase.AltaUsuarioSIBIM(u)

        Select Case code
            Case 1
                conexion.ConnectionString = retornarCStringBD()

                Dim cmd As New MySqlCommand With {
                    .CommandType = CommandType.StoredProcedure,
                    .CommandText = "AltaPaciente",
                    .Connection = conexion
                }
                cmd.Parameters.Add("CI", MySqlDbType.Int32).Value = u.Cedula
                cmd.Parameters.Add("OCUPACION", MySqlDbType.VarChar, 50).Value = u.Ocupacion
                cmd.Parameters.Add("E_CIVIL", MySqlDbType.VarChar, 7).Value = u.Estado_civil
                cmd.Parameters.Add("FECHA_NAC", MySqlDbType.Date).Value = u.FechaNacimiento
                cmd.Parameters.Add("ETAPA", MySqlDbType.String).Value = u.Etapa
                cmd.Parameters.Add("SEXO", MySqlDbType.String).Value = u.Sexo

                Try
                    cmd.Connection.Open()
                    cmd.ExecuteNonQuery() 'EJECUTO ALTA PACIENTESIBIM
                    cmd.Connection.Close()
                    Return 1
                Catch ex As Exception
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
                conexion.ConnectionString = retornarCStringBD()

                Dim cmd As New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "ModificarPaciente",
                .Connection = conexion
                }
                cmd.Parameters.Add("CI", MySqlDbType.Int32).Value = u.Cedula
                cmd.Parameters.Add("OCUPACION", MySqlDbType.VarChar, 50).Value = u.Ocupacion
                cmd.Parameters.Add("E_CIVIL", MySqlDbType.VarChar, 7).Value = u.Estado_civil
                cmd.Parameters.Add("FECHA_NAC", MySqlDbType.Date).Value = u.FechaNacimiento
                cmd.Parameters.Add("ETAPA", MySqlDbType.String).Value = u.Etapa
                cmd.Parameters.Add("SEXO", MySqlDbType.String).Value = u.Sexo

                Try
                    cmd.Connection.Open()
                    cmd.ExecuteNonQuery()
                    cmd.Connection.Close()
                    Return 1
                Catch ex As Exception
                    cmd.Connection.Close()
                    Console.WriteLine(ex.Message)
                    Return 0
                End Try

            Case Else
                Return res
        End Select

    End Function

End Class
