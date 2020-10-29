Imports Entidades
Imports MySql.Data.MySqlClient
Public Class D_Enfermedad
    Dim conexion As New MySqlConnection
    Public Function AltaEnfermedad(enfermedad As E_Enfermedad) As Integer
        If String.IsNullOrWhiteSpace(enfermedad.Nombre) Then
            Return 1
        End If

        If Sesion.Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaEnfermedad", '*Alta a la tabla enfermedad.
            .Connection = conexion
        }
        cmd.Parameters.Add("NOM", MySqlDbType.VarChar).Value = enfermedad.Nombre

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("err alta enfermedad" & ex.Message)
            Sesion.Cerrar(conexion)
            Return -2
        End Try
        Sesion.Cerrar(conexion)
        Return 1
    End Function

    Public Function BuscarEnfermedadConsulta(ID_C As Integer) As E_Enfermedad 'ademas de buscar la enfermedad aprovecho para buscar sintomas y signos clinicos desde esta misma funcion
        Dim enf As New E_Enfermedad
        If Sesion.Conectar(conexion) = -1 Then
            enf.ErrCode = -1
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
            Sesion.Cerrar(conexion)
            enf.ErrCode = -2
            Return enf
        End Try

        If leer.HasRows Then
            While leer.Read()
                enf = New E_Enfermedad With {
                .Nombre = leer.GetString("nombre_enfermedad")}
            End While
        Else
            enf.ErrCode = -8
        End If
        Sesion.Cerrar(conexion)
        Dim d_sin As New D_Sintoma
        Dim d_sign As New D_SignoClinico
        enf.Sintomas = d_sin.BuscarSintomasRegistrados(ID_C)

        If enf.Sintomas(0).ErrCode <> 0 Then
            Return enf
        End If

        enf.SignosClinicos = d_sign.BuscarExamenFisico(ID_C)
        Return enf
    End Function
    Public Function SugerirEnfermedadSegunPyR(pyr As PreguntaRespuesta)

    End Function

    Public Function SugerirEnfermedadSegunSintomas(sintoma As E_Sintoma)

    End Function
    Public Function SugerirEnfermedadSegunSignosC(signoc As E_SignoClinico)

    End Function

End Class
