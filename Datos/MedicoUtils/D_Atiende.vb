Imports Entidades
Imports MySql.Data.MySqlClient
Public Class D_Atiende
    Dim conexion As New MySqlConnection

    Public Function AltaAtiende(consulta As E_Atiende) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .Connection = conexion,
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaAtiende"
        }

        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = consulta.Paciente.Cedula
        cmd.Parameters.Add("CI_M", MySqlDbType.Int32).Value = consulta.Medico.Cedula
        cmd.Parameters.Add("NOM_CONSULTA", MySqlDbType.VarChar, 120).Value = consulta.NombreConsulta
        cmd.Parameters.Add("MOT", MySqlDbType.VarChar).Value = consulta.Motivo

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception 'lo mas seguro es que la excepcion que se produzca aca sea que ya existe una tupla con la misma clave primaria {CI_M,CI_P,CI_A} (duplicate entry)
            Cerrar(conexion)
            Console.WriteLine(ex.Message)
            Return -2
        End Try

        Cerrar(conexion)
        Return 1
    End Function
    Public Function ConsultarConsultasPendientes(CI_m As Integer) As List(Of E_Atiende)
        Dim leer As MySqlDataReader
        Dim Clist As New List(Of E_Atiende)

        If Conectar(conexion) = -1 Then
            Clist.Add(New E_Atiende With {.ID = -1})
            Return Clist
        End If

        Dim cmd As New MySqlCommand With {
            .Connection = conexion,
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BuscarConsultasPendientes"
        }

        cmd.Parameters.Add("CI_M", MySqlDbType.Int32).Value = CI_m

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            Console.WriteLine(ex.Message)
            Clist.Add(New E_Atiende With {.ID = -2})
            Return Clist ' no se pudo ingresar entrevista inicial
        End Try

        If leer.HasRows Then
            Dim dp As New D_Paciente
            While leer.Read()
                Dim consulta = New E_Atiende With {
                    .ID = leer.GetInt32("ID_consulta"),
                    .Fecha = leer.GetDateTime("fecha"),
                    .Paciente = dp.BuscarPacienteCI(leer.GetInt32("CI_paciente")),
                    .Medico = New E_Medico With {.Cedula = leer.GetInt32("CI_medico")},
                    .Motivo = leer.GetString("motivo"),
                    .NombreConsulta = leer.GetString("nombre_ref")
                    }
                Clist.Add(consulta)
            End While
        Else
            Clist.Add(New E_Atiende With {.ID = -8})
        End If
        Cerrar(conexion)
        Return Clist

    End Function

    Public Function AtiendeExiste(atiende As E_Atiende) As Integer

    End Function

    Public Function BuscarMisConsultas(CI As Integer) As List(Of E_Atiende)
        Dim list As New List(Of E_Atiende)

        If Conectar(conexion) = -1 Then
            list.Add(New E_Atiende With {.ID = -1})
            Return list
        End If

        Dim leer As MySqlDataReader
        Dim cmd As New MySqlCommand With {
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "BuscarConsultasPrevias",
        .Connection = conexion
        }

        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = CI

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            list.Add(New E_Atiende With {.ID = -2})
            Return list
        End Try

        If leer.HasRows Then
            While leer.Read()
                list.Add(New E_Atiende With {
                .ID = leer.GetInt32("ID_consulta"),
                .Fecha = leer.GetDateTime("fecha").ToShortDateString(),
                .Paciente = New E_Paciente With {.Cedula = leer.GetInt32("CI_paciente")},
                .Medico = New E_Medico With {.Cedula = leer.GetInt32("CI_medico")},
                .Motivo = leer.GetString("motivo"),
                .NombreConsulta = leer.GetString("nombre_ref")
                })
            End While
        Else
            list.Add(New E_Atiende With {.ID = -8})
        End If

        Cerrar(conexion)

        Return list
    End Function

End Class
