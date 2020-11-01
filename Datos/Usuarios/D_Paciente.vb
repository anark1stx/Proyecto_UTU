Imports Entidades
Imports MySql.Data.MySqlClient
Public Class D_Paciente
    Inherits D_Usuario
    Dim conexion As New MySqlConnection
    Public Function BuscarPacienteCI(ci As Integer) As E_Paciente
        Console.WriteLine("leyendo paciente por ci")
        If Sesion.Conectar(conexion) = -1 Then
            Return New E_Paciente With {.ErrCode = -1} '-1 exit code para conexion fallida
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
            Sesion.Cerrar(conexion)
            Return New E_Paciente With {.ErrCode = -2} 'error ejecutando
        End Try

        Dim listaTel As New List(Of String)

        If leer.HasRows Then
            While leer.Read
                Console.WriteLine(leer.GetString("nombre1"))
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
                listaTel.Add(leer.GetString("telefono"))
            End While
        Else
            Return New E_Paciente With {.ErrCode = -8} 'no encontre
        End If
        u.TelefonosLista = listaTel.Distinct.ToList()
        Sesion.Cerrar(conexion)
        Dim estadoResult = ConsultarUltimoEstado(u)
        If estadoResult <> 1 Then
            u.ErrCode = -7
        End If
        Return u
    End Function

    Public Function BuscarPacienteApellido(ap As String) As List(Of E_Paciente)
        Dim uList As New List(Of E_Paciente)
        Dim listaTel As New List(Of String)
        Dim ultima_ci As Integer = 0
        Dim lastU As New E_Paciente

        Dim leer As MySqlDataReader

        If Sesion.Conectar(conexion) = -1 Then
            lastU.ErrCode = -1
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
            Sesion.Cerrar(conexion)
            Console.WriteLine(ex.Message)
            lastU.ErrCode = -2
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
            uList.Add(New E_Paciente() With {.ErrCode = -8}) 'no encontre usuarios
        End If
        Sesion.Cerrar(conexion)

        For Each p As E_Paciente In uList
            Dim estadoResult = ConsultarUltimoEstado(p)
            If estadoResult <> 1 Then
                p.ErrCode = -7
            End If
        Next

        Return uList
    End Function

    Public Function AltaPaciente(u As E_Paciente) As Integer
        Dim code = MyBase.AltaUsuarioSIBIM(u)
        Select Case code
            Case <> 1
                Return code
        End Select

        Dim cmd As New MySqlCommand With {
        .CommandType = CommandType.StoredProcedure,
        .Connection = conexion,
        .CommandText = "AltaPaciente"
        }

        If Sesion.Conectar(conexion) = -1 Then
            Return -1
        End If

        cmd.Parameters.Add("cedula", MySqlDbType.Int32).Value = u.Cedula
        cmd.Parameters.Add("OCUP", MySqlDbType.VarChar, 50).Value = u.Ocupacion
        cmd.Parameters.Add("E_C", MySqlDbType.VarChar, 7).Value = u.Estado_civil
        cmd.Parameters.Add("F_NAC", MySqlDbType.DateTime, 50).Value = u.FechaNacimiento
        cmd.Parameters.Add("S", MySqlDbType.String).Value = u.Sexo
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Sesion.Cerrar(conexion)
            Console.WriteLine("mod paciente " & ex.Message)
            Return -5 'No se pudo crear/modificar paciente
        End Try
        Sesion.Cerrar(conexion)
        If AltaRegistroEstado(u) <> 1 Then
            Return -6
        End If
        Return 1
    End Function

    Public Function AltaRegistroEstado(p As E_Paciente) As Integer
        If Sesion.Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
        .Connection = conexion,
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "AltaEstado" 'primero doy de alta el estado por si no existe aun
        }

        cmd.Parameters.Add("NOM", MySqlDbType.VarChar, 90).Value = p.Estado.Nombre
        Console.WriteLine("estado:" & p.Estado.Nombre)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("err alta estado" & ex.Message)
            Sesion.Cerrar(conexion)
            Return -2
        End Try

        Dim cmd2 As New MySqlCommand With {
        .Connection = conexion,
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "AltaRegistro_es"
        }
        cmd2.Parameters.Add("CI_P", MySqlDbType.Int32).Value = p.Cedula
        cmd2.Parameters.Add("NOM_E", MySqlDbType.VarChar, 90).Value = p.Estado.Nombre
        Console.WriteLine("estado:" & p.Estado.Nombre & " paciente: " & p.Cedula)
        Try
            cmd2.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("err alta registra estado " & ex.Message)
            Sesion.Cerrar(conexion)
            Return -2
        End Try
        Sesion.Cerrar(conexion)
        Return 1
    End Function

    Public Function ConsultarHistorialEstadosPaciente(p As E_Paciente) As List(Of E_Estado)
        Dim eList As New List(Of E_Estado)
        If Sesion.Conectar(conexion) = -1 Then
            eList.Add(New E_Estado With {.ErrCode = -1})
            Return eList
        End If

        Dim cmd As New MySqlCommand With {
        .Connection = conexion,
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "ConsultarHistorialEstados"
        }
        Dim leer As MySqlDataReader
        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = p.Cedula
        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Sesion.Cerrar(conexion)
            eList.Add(New E_Estado With {.ErrCode = -1})
            Return eList
        End Try

        If leer.HasRows() Then
            While leer.Read()
                eList.Add(New E_Estado With {.Nombre = leer.GetString("nombre_e"), .Fecha = leer.GetString("fecha")})
            End While
            p.Estado = eList.Last()
        Else
            eList.Add(New E_Estado With {.ErrCode = -8})
        End If

        Sesion.Cerrar(conexion)
        Return eList
    End Function
    Public Function ConsultarUltimoEstado(p As E_Paciente) As Integer
        If Sesion.Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
        .Connection = conexion,
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "ConsultarUltimoEstado"
        }
        Dim leer As MySqlDataReader
        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = p.Cedula
        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Sesion.Cerrar(conexion)
            Return -2
        End Try
        While leer.Read()
            p.Estado = New E_Estado With {.Nombre = leer.GetString("nombre_e"), .Fecha = leer.GetString("fecha")}
        End While
        Sesion.Cerrar(conexion)
        Return 1
    End Function
End Class
