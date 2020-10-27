Imports Entidades
Imports MySql.Data.MySqlClient
Public Class D_Categoria
    Dim conexion As New MySqlConnection
    Public Function AltaModcategoria(categoria As E_Categoria, altaomod As Boolean) As Integer
        If Sesion.Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As MySqlCommand

        If altaomod Then '1 = mod, 0 = alta
            cmd = New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaCategoriaDescripcion", '*Actualizar la descripcion de la categoria
            .Connection = conexion
            }
        Else
            cmd = New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaCategoria", '*Alta a la tabla categoria.
            .Connection = conexion
            }
        End If

        cmd.Parameters.Add("NOM", MySqlDbType.VarChar, 160).Value = categoria.Nombre
        cmd.Parameters.Add("DESCR", MySqlDbType.VarChar, 16000).Value = categoria.Descripcion

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("err alta categoria" & ex.Message)
            Sesion.Cerrar(conexion)
            Return -2
        End Try
        Sesion.Cerrar(conexion)
        Return 1
    End Function

    Public Function BuscarCategoria(nombre As String) As List(Of E_Categoria)
        Dim list As New List(Of E_Categoria)
        If Sesion.Conectar(conexion) <> -1 Then
            list.Add(New E_Categoria With {.ErrCode = -1})
            Return List
        End If
        Dim cmd As MySqlCommand
        Dim leer As MySqlDataReader

        cmd = New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BuscarCategoriaXNombre",
            .Connection = conexion
        }

        cmd.Parameters.Add("NOM", MySqlDbType.VarChar, 160).Value = nombre

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Console.WriteLine("err alta clasificacion" & ex.Message)
            Sesion.Cerrar(conexion)
            list.Add(New E_Categoria With {.ErrCode = -2})
            Return list
        End Try

        If leer.HasRows Then
            While leer.Read()
                list.Add(New E_Categoria With {
                .Nombre = leer.GetString("nombre"),
                .Descripcion = leer.GetString("descripcion")
                })
            End While
        Else
            list.Add(New E_Categoria With {.ErrCode = -8})
        End If

        Sesion.Cerrar(conexion)
        Return list
    End Function

    Public Function AltaClasificacion(enfermedad As E_Enfermedad, categoria As E_Categoria)
        Dim de As New D_Enfermedad
        Dim r_enf = de.AltaModEnfermedad(enfermedad, 0)

        If r_enf <> 1 Then
            Return r_enf
        End If

        Dim r_alta = AltaModcategoria(categoria, 0)

        If r_alta <> 1 Then
            Return r_alta
        End If

        If Sesion.Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As MySqlCommand

        cmd = New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaClasificacion", '*Alta a la tabla clasificacion.
            .Connection = conexion
        }

        cmd.Parameters.Add("NOM_E", MySqlDbType.VarChar, 160).Value = enfermedad.Nombre
        cmd.Parameters.Add("NOM_C", MySqlDbType.VarChar, 160).Value = categoria.Nombre

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("err alta clasificacion" & ex.Message)
            Sesion.Cerrar(conexion)
            Return -2
        End Try
        Sesion.Cerrar(conexion)
        Return 1

    End Function

End Class
