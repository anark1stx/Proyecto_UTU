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
            .CommandText = "AltaCorresponde",
            .Connection = conexion
        }

        cmd.Parameters.Add("CI_M", MySqlDbType.Int32).Value = crr.Medico.Cedula
        cmd.Parameters.Add("CI_A", MySqlDbType.Int32).Value = crr.Auxiliar.Cedula

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

    Public Function BuscarAsignaciones_PMedico(u As E_Usuario, auxomedico As Boolean) As List(Of E_Corresponde)
        Dim crrList As New List(Of E_Corresponde)
        Dim leer As MySqlDataReader
        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .Connection = conexion
        }

        If auxomedico Then
            cmd.CommandText = "BuscarAsignacionesMedico"
            cmd.Parameters.Add("CI_M", MySqlDbType.Int32).Value = u.Cedula
        Else
            cmd.CommandText = "BuscarAsignacionesAuxiliar"
            cmd.Parameters.Add("CI_A", MySqlDbType.Int32).Value = u.Cedula
        End If

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
