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

        cmd.Parameters.Add("NOMBRE", MySqlDbType.VarChar, 90).Value = tratamiento.Nombre
        cmd.Parameters.Add("DESCRIPCION", MySqlDbType.VarChar, 16000).Value = tratamiento.Descripcion
        Try
            cmd.ExecuteReader()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            Return 2
        End Try
        Cerrar(conexion)

        Return 1
    End Function

    Public Function ModificarTratamiento(tratamiento As E_Tratamiento) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "ModificarTratamiento",
            .Connection = conexion
        }

        cmd.Parameters.Add("NOMBRE", MySqlDbType.VarChar, 90).Value = tratamiento.Nombre
        cmd.Parameters.Add("DESCRIPCION", MySqlDbType.VarChar, 16000).Value = tratamiento.Descripcion
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            Return 2
        End Try
        Cerrar(conexion)
        Return 1
    End Function

    Public Function BajaTratamiento(tratamiento As E_Tratamiento) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BajaTratamiento",
            .Connection = conexion
        }

        Console.WriteLine("este tratamiento tiene id: " & tratamiento.ID)
        cmd.Parameters.Add("ID_F", MySqlDbType.Int32).Value = tratamiento.ID
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Cerrar(conexion)
            Return 2
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
                .CommandText = "ImportarTratamiento",
                .Connection = conexion
        }

        cmd.Parameters.Add("NOM", MySqlDbType.VarChar, 90).Value = buscar

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

End Class
