Imports Entidades
Imports MySql.Data.MySqlClient
Public Class D_Corresponde
    Dim conexion As New MySqlConnection
    Public Function AltaCorresponde(crr As E_Corresponde) As Integer
        If Sesion.Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaAux_c_Med",
            .Connection = conexion
        }

        cmd.Parameters.Add("CI_M", MySqlDbType.Int32).Value = crr.Medico.Cedula
        cmd.Parameters.Add("CI_A", MySqlDbType.Int32).Value = crr.Auxiliar.Cedula
        cmd.Parameters.Add("FEC", MySqlDbType.DateTime).Value = crr.Fecha

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Sesion.Cerrar(conexion)
            Return -2
        End Try
        Sesion.Cerrar(conexion)
        Return 1
    End Function
    Public Function BajaCorresponde(crr As E_Corresponde) As Integer
        If Sesion.Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BajaCorresponde",
            .Connection = conexion
        }

        cmd.Parameters.Add("CI_M", MySqlDbType.Int32).Value = crr.Medico.Cedula
        cmd.Parameters.Add("CI_A", MySqlDbType.Int32).Value = crr.Auxiliar.Cedula
        cmd.Parameters.Add("FEC", MySqlDbType.DateTime).Value = crr.Fecha

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Sesion.Cerrar(conexion)
            Return -2
        End Try
        Sesion.Cerrar(conexion)
        Return 1
    End Function

    Public Function BuscarAsignacionesM(m As E_Medico) As List(Of E_Corresponde)
        Dim crrList As New List(Of E_Corresponde)
        Dim leer As MySqlDataReader
        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .Connection = conexion,
            .CommandText = "BuscarCrrMedico"
        }

        cmd.Parameters.Add("CI_M", MySqlDbType.Int32).Value = m.Cedula

        If Sesion.Conectar(conexion) = -1 Then
            crrList.Add(New E_Corresponde With {.ErrCode = -1})
            Return crrList
        End If

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Sesion.Cerrar(conexion)
            Console.WriteLine(ex.Message)
            crrList.Add(New E_Corresponde With {.ErrCode = -2})
            Return crrList
        End Try
        If leer.HasRows Then
            While leer.Read()
                crrList.Add(New E_Corresponde With {
                    .Medico = New E_Medico With {.Cedula = leer.GetInt32("CI_medico")},
                    .Auxiliar = New E_Usuario With {.Cedula = leer.GetInt32("CI_auxiliar")},
                    .Fecha = leer.GetDateTime("fecha")
                })
            End While
        Else
            crrList.Add(New E_Corresponde With {.ErrCode = -8})
        End If
        Sesion.Cerrar(conexion)
        Return crrList
    End Function
    Public Function BuscarAsignacionesA(a As E_Usuario) As List(Of E_Corresponde)
        Dim crrList As New List(Of E_Corresponde)
        Dim leer As MySqlDataReader
        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .Connection = conexion,
            .CommandText = "BuscarCrrAuxiliar"
        }

        cmd.Parameters.Add("CI_A", MySqlDbType.Int32).Value = a.Cedula

        If Sesion.Conectar(conexion) = -1 Then
            crrList.Add(New E_Corresponde With {.ErrCode = -1})
            Return crrList
        End If

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Sesion.Cerrar(conexion)
            crrList.Add(New E_Corresponde With {.ErrCode = -2})
            Return crrList
        End Try
        If leer.HasRows Then
            While leer.Read()
                crrList.Add(New E_Corresponde With {
                    .Medico = New E_Medico With {.Cedula = leer.GetInt32("CI_medico")},
                    .Auxiliar = New E_Usuario With {.Cedula = leer.GetInt32("CI_auxiliar")},
                    .Fecha = leer.GetDateTime("fecha")
                })
            End While
        Else
            crrList.Add(New E_Corresponde With {.ErrCode = -8})
        End If
        Sesion.Cerrar(conexion)
        Return crrList
    End Function
End Class
