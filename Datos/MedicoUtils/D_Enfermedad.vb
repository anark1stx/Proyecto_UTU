Imports Entidades
Imports MySql.Data.MySqlClient
Public Class D_Enfermedad
    Dim conexion As New MySqlConnection
    Public Function AltaModEnfermedad(enfermedad As E_Enfermedad, altaomod As Boolean) As Integer
        If String.IsNullOrWhiteSpace(enfermedad.Nombre) Then
            Return 1
        End If

        If Sesion.Conectar(conexion) = -1 Then
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
        cmd.Parameters.Add("F_E_MIN", MySqlDbType.Int32).Value = enfermedad.FranjaEtariaMin
        cmd.Parameters.Add("F_E_MAX", MySqlDbType.Int32).Value = enfermedad.FranjaEtariaMax

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

    Public Function ListarEnfermedades(nombre As String) As List(Of E_Enfermedad)
        Dim leer As MySqlDataReader
        Dim lEnfermedades As New List(Of E_Enfermedad)
        If Sesion.Conectar(conexion) = -1 Then
            lEnfermedades.Add(New E_Enfermedad With {.ErrCode = -1})
            Return lEnfermedades
        End If

        Dim cmd As New MySqlCommand With {
        .Connection = conexion,
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "BuscarEnfermedadesxNombre"
        }

        cmd.Parameters.Add("NOM", MySqlDbType.VarChar, 160).Value = nombre

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Sesion.Cerrar(conexion)
            lEnfermedades.Add(New E_Enfermedad With {.ErrCode = -2})
            Return lEnfermedades
        End Try

        If leer.HasRows Then
            While leer.Read()
                lEnfermedades.Add(New E_Enfermedad With {
                .Nombre = leer.GetString("nombre")
                })
            End While
        Else
            lEnfermedades.Add(New E_Enfermedad With {.ErrCode = -8})
        End If
        Sesion.Cerrar(conexion)
        Return lEnfermedades
    End Function

    Public Function ConsultarDescripcionEnfermedad(enfermedad As E_Enfermedad) As Integer
        Dim leer As MySqlDataReader
        If Sesion.Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
        .Connection = conexion,
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "ConsultarDescripcionEnfermedad"
        }

        cmd.Parameters.Add("NOM", MySqlDbType.VarChar, 160).Value = enfermedad.Nombre

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Sesion.Cerrar(conexion)
            Return -2
        End Try

        If leer.HasRows Then
            While leer.Read()
                enfermedad.Descripcion = leer.GetString("descripcion")
            End While
        Else
            Return -8 'no hay descripcion disponible
        End If
        Sesion.Cerrar(conexion)
        Return 1
    End Function

    Public Function SugerirEnfermedadSegunPyR(pyrList As List(Of PreguntaRespuesta)) As E_Enfermedad

    End Function

    Public Function SugerirEnfermedadSegunSintomas(sList As List(Of E_Sintoma)) As E_Enfermedad

    End Function
    Public Function SugerirEnfermedadSegunSignosC(scList As List(Of E_SignoClinico)) As E_Enfermedad

    End Function

    Public Function BuscarClasificacion(enf As E_Enfermedad) As Integer
        Dim list As New List(Of E_Categoria)
        Dim leer As MySqlDataReader
        If Sesion.Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
        .Connection = conexion,
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "BuscarClasificacion"
        }

        cmd.Parameters.Add("NOM", MySqlDbType.VarChar, 160).Value = enf.Nombre

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Sesion.Cerrar(conexion)
            Return -2
        End Try

        If leer.HasRows Then
            While leer.Read()
                list.Add(New E_Categoria With {
                .Nombre = leer.GetString("nombre_categoria")
                })
            End While
            enf.Categorias = list
        Else
            Sesion.Cerrar(conexion)
            Return -8
        End If
        Sesion.Cerrar(conexion)
        Return 1
    End Function

    Public Function BuscarSintomasEnfermedad(enf As E_Enfermedad) As Integer
        Dim list As New List(Of E_Sintoma)
        Dim leer As MySqlDataReader
        If Sesion.Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
        .Connection = conexion,
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "BuscarSintomasEnfermedad"
        }

        cmd.Parameters.Add("ENF", MySqlDbType.VarChar, 160).Value = enf.Nombre

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Sesion.Cerrar(conexion)
            Return -2
        End Try

        If leer.HasRows Then
            While leer.Read()
                list.Add(New E_Sintoma With {
                .Nombre = leer.GetString("nombre")
                })
            End While
            enf.Sintomas = list
        Else
            Sesion.Cerrar(conexion)
            Return -8
        End If
        Sesion.Cerrar(conexion)
        Return 1
    End Function

    Public Function BuscarSignocCEnfermedad(enf As E_Enfermedad) As Integer
        Dim list As New List(Of E_SignoClinico)
        Dim leer As MySqlDataReader
        If Sesion.Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
        .Connection = conexion,
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "BuscarSignosCEnfermedad"
        }

        cmd.Parameters.Add("ENF", MySqlDbType.VarChar, 160).Value = enf.Nombre

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Sesion.Cerrar(conexion)
            Return -2
        End Try

        If leer.HasRows Then
            While leer.Read()
                list.Add(New E_SignoClinico With {
                .Nombre = leer.GetString("nombre")
                })
            End While
            enf.SignosClinicos = list
        Else
            Sesion.Cerrar(conexion)
            Return -8
        End If
        Sesion.Cerrar(conexion)
        Return 1
    End Function

End Class
