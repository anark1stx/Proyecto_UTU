Imports Entidades
Imports MySql.Data.MySqlClient
Public Class D_Enfermedad
    Dim conexion As New MySqlConnection
    Public Function AltaModEnfermedad(enfermedad As E_Enfermedad, altaomod As Boolean) As Integer
        If String.IsNullOrWhiteSpace(enfermedad.Nombre) Then
            Return 1
        End If

        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As MySqlCommand

        If altaomod Then '1 = mod, 0 = alta
            cmd = New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaEnfermedadDescripcion", '*Actualizar la descripcion de la enfermedad
            .Connection = conexion
            }
        Else
            cmd = New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaEnfermedad", '*Alta a la tabla enfermedad.
            .Connection = conexion
            }
        End If

        cmd.Parameters.Add("NOM", MySqlDbType.VarChar).Value = enfermedad.Nombre
        cmd.Parameters.Add("DESCR", MySqlDbType.VarChar, 160).Value = enfermedad.Descripcion
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("err alta enfermedad" & ex.Message)
            Return -2
        End Try
        Cerrar(conexion)
        Return 1
    End Function

    Public Function BuscarEnfermedadConsulta(ID_C As Integer) As E_Enfermedad 'ademas de buscar la enfermedad aprovecho para buscar sintomas y signos clinicos desde esta misma funcion
        Dim enf As New E_Enfermedad
        If Conectar(conexion) = -1 Then
            enf.Nombre = -1
            Return enf
        End If

        Dim leer As MySqlDataReader
        Dim cmd As New MySqlCommand With {
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "ConsultarEnfermedadDeterminada",
        .Connection = conexion
        }

        cmd.Parameters.Add("ID_C", MySqlDbType.Int32).Value = ID_C

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            enf.Nombre = -2
            Return enf
        End Try

        If leer.HasRows Then
            While leer.Read()
                enf = New E_Enfermedad With {
                .Nombre = leer.GetString("nombre_enfermedad")
                }
            End While
        Else
            enf.Nombre = -8
        End If

        Dim d_sin As New D_Sintoma
        Dim d_sign As New D_SignoClinico
        enf.Sintomas = d_sin.BuscarSintomasRegistrados(ID_C)

        If enf.Sintomas(0).ID <> 0 Then 'adentro de la ID del primer elemento se guardan mensajes de error como -1,-2
            Return enf
        End If

        enf.SignosClinicos = d_sign.BuscarExamenFisico(ID_C)
        Return enf
        Cerrar(conexion)
    End Function
End Class
