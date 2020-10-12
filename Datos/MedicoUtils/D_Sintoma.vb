Imports Entidades
Imports MySql.Data.MySqlClient

Public Class D_Sintoma
    Dim conexion As New MySqlConnection
    Public Function AltaSintoma(Sintoma As E_Sintoma) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaSintoma", '*Alta a la tabla sintoma.
            .Connection = conexion
        }
        cmd.Parameters.Add("NOM", MySqlDbType.VarChar, 160).Value = Sintoma.Nombre
        cmd.Parameters.Add("DESCR", MySqlDbType.VarChar, 160).Value = Sintoma.Descripcion
        cmd.Parameters.Add("ID_S", MySqlDbType.Int32).Direction = ParameterDirection.Output

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("error alta sintoma" & ex.Message)
            Cerrar(conexion)
            Return -2
        End Try
        Cerrar(conexion)
        Sintoma.ID = cmd.Parameters("ID_S").Value
        Return 1
    End Function
    Public Function AltaRegistraSintoma(Sintoma As E_Sintoma, consulta As E_Atiende) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaRegistraSintoma", '*Alta a la tabla registra.
            .Connection = conexion
        }
        cmd.Parameters.Add("ID_C", MySqlDbType.Int32).Value = consulta.ID
        cmd.Parameters.Add("FEC_C", MySqlDbType.DateTime).Value = consulta.Fecha
        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = consulta.Paciente.Cedula
        cmd.Parameters.Add("CI_M", MySqlDbType.Int32).Value = consulta.Medico.Cedula
        cmd.Parameters.Add("ID_S", MySqlDbType.Int32).Value = Sintoma.ID

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Cerrar(conexion)
            Console.WriteLine("error alta registra sintoma" & ex.Message)
            Return -2
        End Try
        Cerrar(conexion)
        Return 1
    End Function

    Public Function BuscarSintomasRegistrados(ID_C As Integer) As List(Of E_Sintoma)
        Dim leer As MySqlDataReader
        Dim sintomas As New List(Of E_Sintoma)

        If Conectar(conexion) = -1 Then
            sintomas.Add(New E_Sintoma With {.ID = -1})
            Return sintomas
        End If

        Dim cmd2 As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "ConsultarSintomasR",
            .Connection = conexion
        }

        cmd2.Parameters.Add("ID_C", MySqlDbType.Int32).Value = ID_C

        Try
            leer = cmd2.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            sintomas.Add(New E_Sintoma With {.ID = -2})
            Return sintomas
        End Try

        If leer.HasRows Then
            While leer.Read()
                sintomas.Add(New E_Sintoma With {
                .Nombre = leer.GetString("nombre")
                })
            End While
        End If
        Return sintomas
    End Function

End Class
