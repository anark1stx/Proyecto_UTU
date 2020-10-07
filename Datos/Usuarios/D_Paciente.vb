Imports Entidades
Imports MySql.Data.MySqlClient
Public Class D_Paciente
    Inherits D_Usuario
    Dim conexion As New MySqlConnection
    Public Function BuscarPacienteCI(ci As Integer) As E_Paciente

        If Conectar(conexion) = -1 Then
            Return New E_Paciente With {.Cedula = -1} '-1 exit code para conexion fallida
        End If

        Dim leer As MySqlDataReader
        Dim lista As New List(Of String)

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
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            Return New E_Paciente With {.Cedula = -2} 'error ejecutando
        End Try

        Dim listaTel As New List(Of String)

        If leer.HasRows Then
            While leer.Read
                u.Nombre1 = leer.GetString("nombre1")
                u.Nombre2 = leer.GetString("nombre2")
                u.Apellido1 = leer.GetString("apellido1")
                u.Apellido2 = leer.GetString("apellido2")
                u.Correo = leer.GetString("correo")
                u.Direccion_Calle = leer.GetString("direccion_calle")
                u.Direccion_Numero = leer.GetInt32("direccion_nroPuerta")
                u.Activo = leer.GetBoolean("activo")
                u.TelefonosLista = New List(Of String)(New String() {})
                u.Estado_civil = leer.GetString("e_civil")
                u.FechaNacimiento = leer.GetDateTime("fecha_nac").ToShortDateString() 'esto es para que no salga con el formato: 6/9/2020 00:00:00
                u.Ocupacion = leer.GetString("ocupacion")
                u.Sexo = leer.GetChar("sexo")
                u.Etapa = leer.GetChar("etapa")
                listaTel.Add(leer.GetString("telefono"))
            End While
        Else
            Return New E_Paciente With {.Cedula = -8} 'no encontre
        End If

        u.TelefonosLista = listaTel.Distinct.ToList()
        Cerrar(conexion)
        Return u
    End Function

    Public Function BuscarPacienteApellido(ap As String) As List(Of E_Paciente)
        Dim uList As New List(Of E_Paciente)
        Dim listaTel As New List(Of String)
        Dim ultima_ci As Integer = 0
        Dim lastU As New E_Paciente

        Dim leer As MySqlDataReader

        If Conectar(conexion) = -1 Then
            lastU.Cedula = -1
            uList.Add(lastU)
            Return uList
        End If

        Dim cmd = New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "BuscarPACIENTExAPELLIDO", 'este procedimiento filtra a aquellos usuarios que no estan en la tabla medico ni paciente, es decir solo a los que estan en la tabla usuario
                .Connection = conexion
        }
        cmd.Parameters.Add("apellido1", MySqlDbType.VarChar, 30).Value = ap

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            lastU.Cedula = -2
            uList.Add(lastU)
            Return uList
        End Try

        If leer.HasRows Then
            While leer.Read()
                If ultima_ci <> leer.GetInt32("CI") Then
                    lastU = New E_Paciente With {
                         .Cedula = leer.GetInt32("CI"),
                         .Nombre1 = leer.GetString("nombre1"),
                         .Nombre2 = leer.GetString("nombre2"),
                         .Apellido1 = leer.GetString("apellido1"),
                         .Apellido2 = leer.GetString("apellido2"),
                         .Correo = leer.GetString("correo"),
                         .Direccion_Calle = leer.GetString("direccion_calle"),
                         .Direccion_Numero = leer.GetInt32("direccion_nroPuerta"),
                         .Activo = leer.GetBoolean("activo"),
                         .TelefonosLista = New List(Of String)(New String() {}),
                         .Ocupacion = leer.GetString("ocupacion"),
                         .Estado_civil = leer.GetString("e_civil"),
                         .FechaNacimiento = leer.GetDateTime("fecha_nac").ToShortDateString(),
                         .Etapa = leer.GetChar("etapa"),
                         .Sexo = leer.GetChar("sexo")
                    }
                    lastU.TelefonosLista.Add(leer.GetString("telefono"))
                    ultima_ci = lastU.Cedula
                    uList.Add(lastU)
                Else
                    lastU.TelefonosLista.Add(leer.GetString("telefono"))
                    lastU.TelefonosLista = lastU.TelefonosLista.Distinct().ToList()
                End If
            End While
        Else
            uList.Add(New E_Paciente() With {.Cedula = -8}) 'no encontre usuarios
        End If

        Cerrar(conexion)
        Return uList

    End Function

    Public Function AltaModPaciente(u As E_Paciente, accion As Boolean) As Integer
        Dim code = MyBase.AltaModUsuarioSibim(u, accion)
        Select Case code
            Case <> 1
                Return code
        End Select

        Dim cmd As New MySqlCommand With {
        .CommandType = CommandType.StoredProcedure,
        .Connection = conexion
        }

        If Not accion Then
            cmd.CommandText = "AltaPaciente"
        Else
            cmd.CommandText = "ModificarPaciente"
        End If

        If Conectar(conexion) = -1 Then
            Return -1
        End If

        cmd.Parameters.Add("CI", MySqlDbType.Int32).Value = u.Cedula
        cmd.Parameters.Add("OCUPACION", MySqlDbType.VarChar, 50).Value = u.Ocupacion
        cmd.Parameters.Add("E_CIVIL", MySqlDbType.VarChar, 7).Value = u.Estado_civil
        cmd.Parameters.Add("FECHA_NAC", MySqlDbType.DateTime, 50).Value = u.FechaNacimiento
        cmd.Parameters.Add("ETAPA", MySqlDbType.String).Value = u.Etapa
        cmd.Parameters.Add("SEXO", MySqlDbType.String).Value = u.Sexo
        Try
            cmd.ExecuteNonQuery()
            Cerrar(conexion)
        Catch ex As Exception
            Cerrar(conexion)
            Return -5 'No se pudo crear/modificar paciente
        End Try

        Return 1
    End Function

    Public Function BuscarMisAnalisis(CI As Integer) As List(Of E_Analisis)
        Dim list As New List(Of E_Analisis)

        If Conectar(conexion) = -1 Then
            list.Add(New E_Analisis With {.ID = -1})
            Return list
        End If

        Dim leer As MySqlDataReader
        Dim cmd As New MySqlCommand With {
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "ListadoAnalisisPaciente",
        .Connection = conexion
        }

        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = CI

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            list.Add(New E_Analisis With {.ID = -2})
            Return list
        End Try

        If leer.HasRows Then
            While leer.Read()
                list.Add(New E_Analisis With {
                .ID = leer.GetInt32("ID"),
                .Nombre = leer.GetString("nombre"),
                .FechaReq = leer.GetDateTime("fecha").ToShortDateString()
                })
            End While
        Else
            list.Add(New E_Analisis With {.ID = -8})
        End If

        Cerrar(conexion)

        Return list
    End Function
    Public Function BuscarMisTratamientos(CI As Integer) As List(Of E_Tratamiento)

    End Function

End Class
