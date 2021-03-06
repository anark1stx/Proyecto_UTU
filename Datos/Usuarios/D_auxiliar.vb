﻿Imports Entidades
Imports MySql.Data.MySqlClient
Public Class D_auxiliar
    Inherits D_Usuario
    Dim conexion As New MySqlConnection
    Public Function BuscarAuxiliarCI(ci As Integer) As E_Usuario
        Dim leer As MySqlDataReader
        Dim u As New E_Usuario
        If Sesion.Conectar(conexion) = -1 Then
            u.ErrCode = -1
            Return u
        End If

        Dim cmd = New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "BuscarAUXILIARxCI",
                .Connection = conexion
        }

        Dim listaTel As New List(Of String)
        cmd.Parameters.Add("cedula", MySqlDbType.Int32).Value = ci

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Sesion.Cerrar(conexion)
            u.ErrCode = -2
            Return u
        End Try

        If leer.HasRows Then
            While leer.Read()
                u = New E_Usuario With {
                     .Cedula = leer.GetInt32("CI"),
                     .Nombre1 = leer.GetString("nombre1"),
                     .Nombre2 = leer.GetString("nombre2"),
                     .Apellido1 = leer.GetString("apellido1"),
                     .Apellido2 = leer.GetString("apellido2"),
                     .Correo = leer.GetString("correo"),
                     .Direccion_Calle = leer.GetString("direccion_calle"),
                     .Direccion_Numero = leer.GetInt32("direccion_nroPuerta"),
                     .Activo = leer.GetBoolean("activo"),
                     .TelefonosLista = New List(Of String)(New String() {})
                }
                listaTel.Add(leer.GetString("telefono"))
            End While
            u.TelefonosLista = listaTel.Distinct().ToList()
        Else
            u.ErrCode = -8 'no encontre usuario
        End If
        Sesion.Cerrar(conexion)
        Return u
    End Function
    Public Function BuscarAuxiliarApellido(ap As String) As List(Of E_Usuario)
        Dim uList As New List(Of E_Usuario)
        Dim ultima_ci As Integer = 0
        Dim lastU As New E_Usuario

        Dim leer As MySqlDataReader

        If Sesion.Conectar(conexion) = -1 Then
            lastU.ErrCode = -1
            uList.Add(lastU)
            Return uList
        End If

        Dim cmd = New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "BuscarAUXILIARxApellido",
                .Connection = conexion
        }
        cmd.Parameters.Add("APELLIDO1", MySqlDbType.VarChar, 30).Value = ap

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Sesion.Cerrar(conexion)
            lastU.ErrCode = -2
            uList.Add(lastU)
            Return uList
        End Try

        If leer.HasRows Then
            While leer.Read()
                If ultima_ci <> leer.GetInt32("CI") Then
                    lastU = New E_Usuario With {
                         .Cedula = leer.GetInt32("CI"),
                         .Nombre1 = leer.GetString("nombre1"),
                         .Nombre2 = leer.GetString("nombre2"),
                         .Apellido1 = leer.GetString("apellido1"),
                         .Apellido2 = leer.GetString("apellido2"),
                         .Correo = leer.GetString("correo"),
                         .Direccion_Calle = leer.GetString("direccion_calle"),
                         .Direccion_Numero = leer.GetInt32("direccion_nroPuerta"),
                         .Activo = leer.GetBoolean("activo"),
                         .TelefonosLista = New List(Of String)(New String() {})
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
            lastU.ErrCode = -8
            uList.Add(lastU) 'no encontre usuarios
        End If

        Sesion.Cerrar(conexion)
        Return uList
    End Function
    Public Function AltaAuxiliar(u As E_Usuario) As Integer
        Dim code = MyBase.AltaUsuarioSIBIM(u)
        Select Case code
            Case <> 1
                Return code
        End Select

        If Sesion.Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "AltaAuxiliar",
        .Connection = conexion
        }
        cmd.Parameters.Add("cedula", MySqlDbType.Int32).Value = u.Cedula
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Sesion.Cerrar(conexion)
            Return -4
        End Try
        Sesion.Cerrar(conexion)
        Return 1
    End Function
End Class
