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
    Public Function SugerirEnfermedadSegunPyR(pyr As PreguntaRespuesta) As E_Enfermedad
        Dim enf As New E_Enfermedad
        If Sesion.Conectar(conexion) = -1 Then
            enf.ErrCode = -1
            Return enf
        End If

        Dim leer As MySqlDataReader
        Dim cmd As New MySqlCommand With {
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "SugerirEnfermedadSegunPyR",
        .Connection = conexion
        }

        cmd.Parameters.Add("ID_P", MySqlDbType.Int32).Value = pyr.ID_Pregunta

        Select Case pyr.Respuesta.GetType()
            Case GetType(System.Windows.Forms.CheckBox)
                Dim respuesta As String = ""
                Select Case DirectCast(pyr.Respuesta, System.Windows.Forms.CheckBox).Checked
                    Case True
                        respuesta = "True"
                    Case False
                        respuesta = "False"
                End Select

                cmd.Parameters.Add("RES", MySqlDbType.VarChar, 7200).Value = respuesta
            Case Else
                cmd.Parameters.Add("RES", MySqlDbType.VarChar, 7200).Value = pyr.Respuesta.Text
        End Select


        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Sesion.Cerrar(conexion)
            enf.ErrCode = -2
            Return enf
        End Try

        If leer.HasRows Then
            While leer.Read()
                If Not leer.IsDBNull(0) Then
                    enf = New E_Enfermedad With {
                    .Nombre = leer.GetString("nombre_enfermedad")}
                Else
                    enf.ErrCode = -8
                End If
            End While
        Else
            enf.ErrCode = -8
        End If
        Sesion.Cerrar(conexion)
        Return enf
    End Function

    Public Function SugerirEnfermedadSegunSintomas(sintoma As E_Sintoma) As E_Enfermedad
        Dim enf As New E_Enfermedad
        If Sesion.Conectar(conexion) = -1 Then
            enf.ErrCode = -1
            Return enf
        End If

        Dim leer As MySqlDataReader
        Dim cmd As New MySqlCommand With {
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "SugerirEnfermedadSegunS",
        .Connection = conexion
        }

        cmd.Parameters.Add("SIN", MySqlDbType.VarChar).Value = sintoma.Nombre

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Sesion.Cerrar(conexion)
            enf.ErrCode = -2
            Return enf
        End Try

        If leer.HasRows Then
            While leer.Read()
                If Not leer.IsDBNull(0) Then
                    enf = New E_Enfermedad With {
                    .Nombre = leer.GetString("nombre_enfermedad")}
                Else
                    enf.ErrCode = -8
                End If
            End While
        Else
            enf.ErrCode = -8
        End If
        Sesion.Cerrar(conexion)
        Return enf
    End Function
    Public Function SugerirEnfermedadSegunSignosC(signoc As E_SignoClinico) As E_Enfermedad
        Dim enf As New E_Enfermedad
        If Sesion.Conectar(conexion) = -1 Then
            enf.ErrCode = -1
            Return enf
        End If

        Dim leer As MySqlDataReader
        Dim cmd As New MySqlCommand With {
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "SugerirEnfermedadSegunSC",
        .Connection = conexion
        }

        cmd.Parameters.Add("SIGNOC", MySqlDbType.VarChar).Value = signoc.Nombre

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Sesion.Cerrar(conexion)
            enf.ErrCode = -2
            Return enf
        End Try

        If leer.HasRows Then
            While leer.Read()
                If Not leer.IsDBNull(0) Then
                    enf = New E_Enfermedad With {
                    .Nombre = leer.GetString("nombre_enfermedad")}
                Else
                    enf.ErrCode = -8
                End If
            End While
        Else
            enf.ErrCode = -8
        End If
        Sesion.Cerrar(conexion)
        Return enf
    End Function

End Class
