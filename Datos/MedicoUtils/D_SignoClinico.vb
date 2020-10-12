Imports Entidades
Imports MySql.Data.MySqlClient
Public Class D_SignoClinico
    Dim conexion As New MySqlConnection
    Public Function AltaSignoClinico(Signo As E_SignoClinico) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaSignoClinico", '*Alta a la tabla Signo.
            .Connection = conexion
        }
        cmd.Parameters.Add("NOM", MySqlDbType.VarChar, 160).Value = Signo.Nombre
        cmd.Parameters.Add("DESCR", MySqlDbType.VarChar, 160).Value = Signo.Descripcion
        cmd.Parameters.Add("ID_SC", MySqlDbType.Int32).Direction = ParameterDirection.Output

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("error alta Signo" & ex.Message)
            Cerrar(conexion)
            Return -2
        End Try
        Cerrar(conexion)
        Signo.ID = cmd.Parameters("ID_SC").Value
        Return 1
    End Function
    Public Function AltaExamenFisico(Signo As E_SignoClinico, consulta As E_Atiende) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaExamenFisico", '*Alta a la tabla registra.
            .Connection = conexion
        }
        cmd.Parameters.Add("ID_C", MySqlDbType.Int32).Value = consulta.ID
        cmd.Parameters.Add("FEC_C", MySqlDbType.DateTime).Value = consulta.Fecha
        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = consulta.Paciente.Cedula
        cmd.Parameters.Add("CI_M", MySqlDbType.Int32).Value = consulta.Medico.Cedula
        cmd.Parameters.Add("ID_SC", MySqlDbType.Int32).Value = Signo.ID

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Cerrar(conexion)
            Console.WriteLine("error alta examen fisico" & ex.Message)
            Return -2
        End Try
        Cerrar(conexion)
        Return 1
    End Function

    Public Function BuscarExamenFisico(ID_C As Integer) As List(Of E_SignoClinico)
        Dim leer As MySqlDataReader
        Dim signos As New List(Of E_SignoClinico)

        If Conectar(conexion) = -1 Then
            signos.Add(New E_SignoClinico With {.ID = -1})
            Return signos
        End If

        Dim cmd2 As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "ConsultarExamenFisico",
            .Connection = conexion
        }

        cmd2.Parameters.Add("ID_C", MySqlDbType.Int32).Value = ID_C

        Try
            leer = cmd2.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            signos.Add(New E_SignoClinico With {.ID = -2})
            Return signos
        End Try

        If leer.HasRows Then
            While leer.Read()
                signos.Add(New E_SignoClinico With {
                .Nombre = leer.GetString("nombre")
                })
            End While
        End If
        Return signos
    End Function

End Class
