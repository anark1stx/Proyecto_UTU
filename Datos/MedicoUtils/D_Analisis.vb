Imports Entidades
Imports MySql.Data.MySqlClient
Public Class D_Analisis
    Dim conexion As New MySqlConnection

    Public Function AltaAnalisis(a As E_Analisis) As Integer

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaAnalisis",
            .Connection = conexion
        }
        Dim leer As MySqlDataReader

        cmd.Parameters.Add("NOM", MySqlDbType.VarChar, 90).Value = a.Nombre
        cmd.Parameters.Add("ID_AN", MySqlDbType.Int32).Direction = ParameterDirection.Output

        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Try
            leer = cmd.ExecuteReader() 'porque preciso el ID del analisis, sino seria NonQuery.
        Catch ex As Exception
            Cerrar(conexion)
            Return -2 'no se pudo ingresar analisis
        End Try

        a.ID = cmd.Parameters("ID_AN").Value
        Cerrar(conexion)

        Dim exitCodeParametro = AltaParametros(a)
        Select Case exitCodeParametro
            Case <> 1
                Return exitCodeParametro
        End Select

        Return AltaIndicacion(a)
    End Function

    Public Function AltaParametros(a As E_Analisis) As Integer 'hacer algo para verificar existencia del parametro antes
        If Conectar(conexion) = -1 Then
            Return -1
        End If
        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaAnalisisParametro",
            .Connection = conexion
        }
        cmd.Parameters.Add("NOM", MySqlDbType.VarChar, 90)
        cmd.Parameters.Add("UNI", MySqlDbType.VarChar, 20)
        cmd.Parameters.Add("REF_MIN", MySqlDbType.Double, 8)
        cmd.Parameters.Add("REF_MAX", MySqlDbType.Double, 8)
        cmd.Parameters.Add("ID_P", MySqlDbType.Int32)
        cmd.Parameters("ID_P").Direction = ParameterDirection.Output

        Dim cmd2 As New MySqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = "AltaAnalisisTieneParametro",
                .Connection = conexion
            }

        cmd2.Parameters.Add("ID_AN", MySqlDbType.Int32)
        cmd2.Parameters.Add("ID_P", MySqlDbType.Int32)

        For Each p As E_Analisis.Parametro In a.Parametros

            If p.ID = 0 Then
                cmd.Parameters("NOM").Value = p.Nombre
                cmd.Parameters("UNI").Value = p.Unidad
                cmd.Parameters("REF_MIN").Value = p.ValorMinimo
                cmd.Parameters("REF_MAX").Value = p.ValorMaximo
                Try
                    cmd.ExecuteNonQuery()
                    p.ID = cmd.Parameters("ID_P").Value
                Catch ex As Exception
                    Cerrar(conexion)
                    Console.WriteLine("ERR" & ex.Message)
                    Return -5 'no se pudo ingresar parametro
                End Try
            Else
                Console.WriteLine("El parametro ya esta registrado en la BD")
            End If

            cmd2.Parameters("ID_AN").Value = a.ID
            cmd2.Parameters("ID_P").Value = p.ID
            Try
                cmd2.ExecuteNonQuery()
            Catch ex As Exception
                Cerrar(conexion)
                Console.WriteLine("ERR2" & ex.Message)
                Return -3
            End Try
        Next
        Cerrar(conexion)
        Return 1
    End Function

    Public Function AltaIndicacion(a As E_Analisis) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If
        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaAnalisisIndicacion",
            .Connection = conexion
        }
        cmd.Parameters.Add("NOM", MySqlDbType.VarChar, 90)


        Dim cmd2 As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaEspecificacion",
            .Connection = conexion
        }

        cmd2.Parameters.Add("ID_AN", MySqlDbType.Int32).Value = a.ID
        cmd2.Parameters.Add("NOM_I", MySqlDbType.VarChar, 90)
        cmd2.Parameters.Add("DESCR", MySqlDbType.VarChar, 500)

        For Each i As E_Analisis.Indicacion In a.Indicaciones
            cmd.Parameters("NOM").Value = i.Nombre
            Try
                cmd.ExecuteNonQuery()
                Cerrar(conexion)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Cerrar(conexion)
                Return -6 'no se pudo ingresar indicacion
            End Try
            cmd2.Parameters.Add("NOM_I", MySqlDbType.VarChar, 90).Value = i.Nombre
            cmd2.Parameters.Add("DESCR", MySqlDbType.VarChar, 500).Value = i.Descripcion

        Next
        Cerrar(conexion)
        Return 1
    End Function

    Public Function RetornarParametros() As List(Of E_Analisis.Parametro)

        Dim pList As New List(Of E_Analisis.Parametro)

        Dim leer As MySqlDataReader
        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BuscarParametros",
            .Connection = conexion
        }

        If Conectar(conexion) = -1 Then
            pList.Add(New E_Analisis.Parametro With {.ErrCode = -1})
            Return pList
        End If

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            pList.Add(New E_Analisis.Parametro With {.ErrCode = -2})
            Return pList
        End Try
        If leer.HasRows Then
            While leer.Read()
                pList.Add(New E_Analisis.Parametro With {
                .ID = leer.GetInt32("ID"),
                .Nombre = leer.GetString("nombre"),
                .Unidad = leer.GetString("unidad"),
                .ValorMinimo = leer.GetDouble("referencia_min"),
                .ValorMaximo = leer.GetDouble("referencia_max")
                })
            End While
        Else
            pList.Add(New E_Analisis.Parametro With {.ErrCode = -8})
        End If
        Cerrar(conexion)
        Return pList
    End Function

    Public Function AnalisisExiste(nombreanalisis As String) As Integer 'si el analisis ya existe avisar y pedir que cambie el nombre
        If Conectar(conexion) = -1 Then
            Return -1
        End If
        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AnalisisExiste",
            .Connection = conexion
        }
        Dim leer As MySqlDataReader

        cmd.Parameters.Add("NOM", MySqlDbType.VarChar, 90).Value = nombreanalisis
        cmd.Parameters.Add("EXISTE", MySqlDbType.Bit).Direction = ParameterDirection.Output

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            Console.WriteLine("err analisis existe" & ex.Message)
            Return -2
        End Try

        Dim existe As Integer = cmd.Parameters("EXISTE").Value
        Cerrar(conexion)
        Return existe
    End Function
    Public Function ConsultarResultadosAnalisis(a As E_Analisis) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If
        Dim leer As MySqlDataReader
        Dim cmd As New MySqlCommand With {
        .Connection = conexion,
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "ConsultaAnalisisResultados"
        }
        cmd.Parameters.Add("ID_C", MySqlDbType.Int32).Value = a.ConsultaReq.ID
        cmd.Parameters.Add("ID_AN", MySqlDbType.Int32).Value = a.ID

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            Console.WriteLine(ex.Message)
            Return -2
        End Try

        If leer.HasRows Then
            While leer.Read()
                a.Parametros.Add(New E_Analisis.Parametro With {
                .Nombre = leer.GetString("nombre"),
                .ID = leer.GetString("ID"),
                .Unidad = leer.GetString("unidad"),
                .ValorMinimo = leer.GetDecimal("referencia_min"),
                .ValorMaximo = leer.GetDecimal("referencia_max"),
                .Valor = leer.GetDecimal("valor")
                })
            End While
        Else
            Return -8
        End If
        Cerrar(conexion)
        Return 1
    End Function

    Public Function BuscarAnalisisXNombre(nom As String) As List(Of E_Analisis)

        Dim aList As New List(Of E_Analisis)
        If Conectar(conexion) = -1 Then
            Cerrar(conexion)
            aList.Add(New E_Analisis With {.ErrCode = -1})
            Return aList
        End If

        Dim leer As MySqlDataReader

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "BuscarAnalisisXNombre",
            .Connection = conexion
        }
        cmd.Parameters.Add("NOM_A", MySqlDbType.VarChar, 160).Value = nom

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            aList.Add(New E_Analisis With {.ErrCode = -2})
            Return aList
        End Try

        If leer.HasRows Then
            While leer.Read()
                aList.Add(New E_Analisis With {
                .ID = leer.GetInt32("ID"),
                .Nombre = leer.GetString("nombre")
                })
            End While
        Else
            aList.Add(New E_Analisis With {.ErrCode = -8})
        End If
        Cerrar(conexion)
        Return aList
    End Function
    Public Function ListarAnalisisDePaciente(CI_P As Integer) As List(Of E_Analisis)
        Dim aList As New List(Of E_Analisis)
        Dim leer As MySqlDataReader
        If Conectar(conexion) = -1 Then
            aList.Add(New E_Analisis With {.ErrCode = -1})
            Return aList
        End If

        Dim cmd As New MySqlCommand With {
        .Connection = conexion,
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "ListadoAnalisisPaciente"
        }
        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = CI_P

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            Console.WriteLine(ex.Message)
            aList.Add(New E_Analisis With {.ErrCode = -2})
            Return aList
        End Try

        If leer.HasRows Then
            aList.Add(New E_Analisis With {
                .ID = leer.GetInt32("ID_analisis"),
                .Nombre = leer.GetString("nombre"),
                .ConsultaReq = New E_Atiende With {
                .ID = leer.GetString("ID_Consulta"),
                .Fecha = leer.GetString("fecha_c")
                }
            })
        Else
            aList.Add(New E_Analisis With {.ErrCode = -8})
        End If
        Cerrar(conexion)
        Return aList
    End Function
    Public Function AltaAnalisisResultados(a As E_Analisis) As Integer
        If Conectar(conexion) = -1 Then
            Return -1
        End If

        Dim cmd As New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "AltaAnalisisResultados",
            .Connection = conexion
        }

        cmd.Parameters.Add("ID_C", MySqlDbType.Int32).Value = a.ConsultaReq.ID
        cmd.Parameters.Add("FEC_C", MySqlDbType.DateTime).Value = a.ConsultaReq.Fecha
        cmd.Parameters.Add("CI_P", MySqlDbType.Int32).Value = a.ConsultaReq.Paciente.Cedula
        cmd.Parameters.Add("CI_M", MySqlDbType.Int32).Value = a.ConsultaReq.Medico.Cedula
        cmd.Parameters.Add("ID_AN", MySqlDbType.Int32).Value = a.ID
        cmd.Parameters.Add("ID_P", MySqlDbType.Int32)
        cmd.Parameters.Add("VAL", MySqlDbType.Decimal)

        For Each p As E_Analisis.Parametro In a.Parametros
            cmd.Parameters("ID_P").Value = p.ID
            cmd.Parameters("VAL").Value = p.Valor
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Cerrar(conexion)
                Console.WriteLine(ex.Message)
                Return -2
            End Try
        Next
        Cerrar(conexion)
        Return 1
    End Function

    Public Function ConsultarAnalisisRequerido(consulta As E_Atiende) As E_Analisis
        Dim a As New E_Analisis With {
        .ConsultaReq = consulta
        }
        If Conectar(conexion) = -1 Then
            a.ErrCode = -1
            Return a
        End If
        Dim leer As MySqlDataReader
        Dim cmd As New MySqlCommand With {
        .Connection = conexion,
        .CommandType = CommandType.StoredProcedure,
        .CommandText = "ConsultarAnalisisRequerido"
        }
        cmd.Parameters.Add("ID_C", MySqlDbType.Int32).Value = a.ConsultaReq.ID

        Try
            leer = cmd.ExecuteReader()
        Catch ex As Exception
            Cerrar(conexion)
            Console.WriteLine(ex.Message)
            a.ErrCode = -2
            Return a
        End Try

        If leer.HasRows Then
            While leer.Read()
                a.ID = leer.GetInt32("ID")
                a.Nombre = leer.GetString("nombre")
            End While
        Else
            a.ErrCode = -8
        End If
        Cerrar(conexion)
        Return a
    End Function

    Public Function SugerirAnalisisSegunPyR(pyrList As List(Of PreguntaRespuesta)) As E_Analisis

    End Function

    Public Function SugerirAnalisisSegunSintomas(sList As List(Of E_Sintoma)) As E_Analisis

    End Function
    Public Function SugerirAnalisisSegunSignosC(scList As List(Of E_SignoClinico)) As E_Analisis

    End Function

    Public Function SugerirAnalisisSegunEnfermedad(enf As E_Enfermedad) As E_Analisis

    End Function

End Class
