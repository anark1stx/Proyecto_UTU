Imports Entidades
Imports MySql.Data.MySqlClient
Public Class D_Tratamiento
    Dim conexion As New MySqlConnection
    Public Function AltaTratamiento(tratamiento As E_Tratamiento) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaTratamiento",
            .Connection = conexion
        }

        cmd.Parameters.Add("NOM_T", MySqlDbType.VarChar, 160).Value = tratamiento.Nombre
        cmd.Parameters.Add("DESCR", MySqlDbType.VarChar, 16000).Value = tratamiento.Descripcion
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            Return -2
        End Try
        Cerrar(conexion)

        Return 1
    End Function
    Function BuscarTratamientos(buscar As String) As List(Of E_Tratamiento)
        Dim leer As MySqlDataReader
        Dim tratamientoList As New List(Of E_Tratamiento)
        If Conectar(conexion) = -1 Then
            tratamientoList.Add(New E_Tratamiento With {.ID = -1})
            Return tratamientoList '-1 exit code para conexion fallida
        End If

        Dim cmd = New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "BuscarTratamientosXNombre",
                .Connection = conexion
        }

        cmd.Parameters.Add("NOM_T", MySqlDbType.VarChar, 90).Value = buscar

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            tratamientoList.Add(New E_Tratamiento With {.ID = -2})
            Return tratamientoList
        End Try

        If leer.HasRows Then
            While leer.Read()
                Dim f = New E_Tratamiento With {
                     .ID = leer.GetInt32("ID"),
                     .Nombre = leer.GetString("nombre"),
                     .Descripcion = leer.GetString("descripcion")
                }
                tratamientoList.Add(f)
            End While
        Else
            tratamientoList.Add(New E_Tratamiento With {.ID = -8})
        End If

        Cerrar(conexion)

        Return tratamientoList
    End Function

    Function AltaPacienteSigueTratamiento(CI_P As Integer, t As E_Tratamiento) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaPacienteSigueTratamiento",
            .Connection = conexion
        }
        cmd.Parameters.Add("ID_T", MySqlDbType.Int32).Value = t.ID
        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = CI_P
        cmd.Parameters.Add("F_INI", MySqlDbType.Date).Value = t.FechaInicio
        cmd.Parameters.Add("F_FIN", MySqlDbType.Date).Value = t.FechaFin

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            Return -2
        End Try
        Cerrar(conexion)

        Return 1
    End Function

    Function AltaSeguimientoDiario(t As E_Tratamiento, seguimiento As E_Seguimiento, CI_P As Integer) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaPacienteSeguimientoDiario",
            .Connection = conexion
        }
        cmd.Parameters.Add("ID_T", MySqlDbType.Int32).Value = t.ID
        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = CI_P
        cmd.Parameters.Add("F_INI", MySqlDbType.Date).Value = t.FechaInicio
        cmd.Parameters.Add("F_SEG", MySqlDbType.Date).Value = seguimiento.Fecha
        cmd.Parameters.Add("DESCR", MySqlDbType.VarChar, 600).Value = seguimiento.Descripcion

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            Return -2
        End Try
        Cerrar(conexion)
        Return 1
    End Function
    Function AltaResultadoTratamiento(t As E_Tratamiento, CI_P As Integer) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaResultadoTratamiento",
            .Connection = conexion
        }
        cmd.Parameters.Add("ID_T", MySqlDbType.Int32).Value = t.ID
        cmd.Parameters.Add("F_INI", MySqlDbType.Date).Value = t.FechaInicio
        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = CI_P
        cmd.Parameters.Add("RES", MySqlDbType.VarChar, 90).Value = t.Resultado

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            Return -2
        End Try
        Cerrar(conexion)

        Return 1
    End Function
    Function ConsultarHistorialTratamientos(CI_P As Integer) As List(Of E_Tratamiento)
        Dim leer As MySqlDataReader
        Dim lTratamientos As New List(Of E_Tratamiento)
        If Conectar(conexion) = -1 Then
            lTratamientos.Add(New E_Tratamiento With {.ID = -1})
            Return lTratamientos
        End If

        Dim cmd As New MySqlCommand With {
          .Connection = conexion,
          .CommandType = CommandType.StoredProcedure,
          .CommandText = "ConsultarHistorialTratamientos"
        }
        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = CI_P
        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            lTratamientos.Add(New E_Tratamiento With {.ID = -2})
            Return lTratamientos
        End Try

        If leer.HasRows Then
            While leer.Read()
                lTratamientos.Add(New E_Tratamiento With {
                .ID = leer.GetString("ID_tratamiento"),
                .FechaInicio = leer.GetString("fecha_inicio"),
                .FechaFin = leer.GetString("fecha_fin"),
                .Resultado = leer.GetString("resultado")
                })
            End While
        Else
            lTratamientos.Add(New E_Tratamiento With {.ID = -8})
        End If
        Cerrar(conexion)
        Return lTratamientos
    End Function

    Function ConsultarSeguimientoDiario(t As E_Tratamiento, CI_P As Integer, fecha As Date) As E_Seguimiento
        Dim leer As MySqlDataReader
        Dim seguimientoReturn As New E_Seguimiento
        If Conectar(conexion) = -1 Then
            seguimientoReturn.ID_Seguimiento = -1
            Return seguimientoReturn
        End If

        Dim cmd As New MySqlCommand With {
          .Connection = conexion,
          .CommandType = CommandType.StoredProcedure,
          .CommandText = "ConsultarSegDiario"
        }
        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = CI_P
        cmd.Parameters.Add("ID_T", MySqlDbType.Int32).Value = t.ID
        cmd.Parameters.Add("FEC_SEG", MySqlDbType.Date).Value = fecha

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            seguimientoReturn.ID_Seguimiento = -2
            Return seguimientoReturn
        End Try

        If leer.HasRows Then
            While leer.Read()
                seguimientoReturn.ID_Seguimiento = leer.GetInt32("ID")
                seguimientoReturn.Descripcion = leer.GetString("descripcion")
                seguimientoReturn.Fecha = fecha
            End While
            t.ListaSeguimientos.Add(seguimientoReturn)
        Else
            seguimientoReturn.ID_Seguimiento = -8
        End If
        Cerrar(conexion)
        Return seguimientoReturn
    End Function

    Public Function ConsultarTratamientoRequerido(ID_C As Integer) As E_Tratamiento

    End Function

    Public Function SugerirTratamientoSegunPyR(pyrList As List(Of PreguntaRespuesta)) As E_Tratamiento

    End Function

    Public Function SugerirTratamientoSegunSintomas(sList As List(Of E_Sintoma)) As E_Tratamiento

    End Function
    Public Function SugerirTratamientoSegunSignosC(scList As List(Of E_SignoClinico)) As E_Tratamiento

    End Function


End Class
