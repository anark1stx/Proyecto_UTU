﻿Imports Entidades
Imports MySql.Data.MySqlClient
Public Class D_SignoClinico
    Dim conexion As New MySqlConnection
    Public Function AltaModSignoClinico(Signo As E_SignoClinico, altaomod As Boolean) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If
        Dim cmd As MySqlCommand
        If altaomod Then '1 = mod, 0 = alta
            cmd = New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaSignoClinicoDescripcion",
            .Connection = conexion
            }
        Else
            cmd = New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaSignoClinico", '*Alta a la tabla Signo.
            .Connection = conexion
            }
            cmd.Parameters.Add("ID_SC", MySqlDbType.Int32).Direction = ParameterDirection.Output
        End If
        cmd.Parameters.Add("NOM", MySqlDbType.VarChar, 160).Value = Signo.Nombre
        cmd.Parameters.Add("DESCR", MySqlDbType.VarChar, 160).Value = Signo.Descripcion
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
        Dim resultAltaSg = AltaModSignoClinico(Signo, 0)
        If resultAltaSg <> 1 Then 'tal vez el signo clinico no este indexado en la base de datos, si asi es el caso lo damos de alta
            Return resultAltaSg
        End If

        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaExamenFisico", '*Alta a la tabla examenfisico.
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
            signos.Add(New E_SignoClinico With {.ErrCode = -1})
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
            signos.Add(New E_SignoClinico With {.ErrCode = -2})
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

    Public Function ListarSignoCs(nombre As String) As List(Of E_SignoClinico) 'retorno una lista ya que voy a emplear LIKE para la busqueda, entonces puede ser que encuentre varias coincidencias
        Dim leer As MySqlDataReader
        Dim lSignoC As New List(Of E_SignoClinico)
        If Conectar(conexion) = -1 Then
            lSignoC.Add(New E_SignoClinico With {.ErrCode = -1})
            Return lSignoC
        End If

        Dim cmd As New MySqlCommand With {
        .Connection = conexion,
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "BuscarSignosCxNombre"
        }

        cmd.Parameters.Add("NOM", MySqlDbType.VarChar, 160).Value = nombre

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            lSignoC.Add(New E_SignoClinico With {.ErrCode = -2})
            Return lSignoC
        End Try

        If leer.HasRows Then
            While leer.Read()
                lSignoC.Add(New E_SignoClinico With {
                .ID = leer.GetInt32("ID"),
                .Nombre = leer.GetString("nombre")
                })
            End While
        End If
        Cerrar(conexion)
        Return lSignoC
    End Function

    Public Function ConsultarDescripcionSignoC(signoc As E_SignoClinico) As Integer
        Dim leer As MySqlDataReader
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
        .Connection = conexion,
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "ConsultarDescripcionSignoC"
        }

        cmd.Parameters.Add("ID_S", MySqlDbType.Int32).Value = signoc.ID

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            Return -2
        End Try

        If leer.HasRows Then
            While leer.Read()
                signoc.Descripcion = leer.GetString("descripcion")
            End While
        Else
            Return -8 'no hay descripcion disponible
        End If
        Cerrar(conexion)
        Return 1
    End Function

End Class
