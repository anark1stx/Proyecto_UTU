Public Class Paciente
    Inherits Usuario
    Protected _fechaNacimiento As String
    Protected _sexo As String
    Protected _ocupacion As String
    Protected _estado_civil As String

    Sub New()
        _nombre1 = ""
        _nombre2 = ""
        _apellido1 = ""
        _apellido2 = ""
        _correo = ""
        _contrasena = ""
        _telefonosLista = New List(Of String)
        _direccion = New List(Of String)
        _cedula = ""
        _fechaNacimiento = ""
        _sexo = ""
        _ocupacion = ""
        _estado_civil = ""
        _imagen = {}
    End Sub

    Sub New(cedula As String, nombre1 As String, nombre2 As String, apellido1 As String, apellido2 As String, direccion As List(Of String), telefonosLista As List(Of String), correo As String, contrasena As String, fechaNacimiento As String, sexo As String, ocupacion As String, estado_civil As String, imagen As Byte())
        _nombre1 = nombre1
        _nombre2 = nombre2
        _apellido1 = apellido1
        _apellido2 = apellido2
        _correo = correo
        _contrasena = contrasena
        _telefonosLista = telefonosLista
        _direccion = direccion
        _cedula = cedula
        _fechaNacimiento = fechaNacimiento
        _sexo = sexo
        _ocupacion = ocupacion
        _estado_civil = estado_civil
        _imagen = imagen
    End Sub

    Property FechaNacimiento() As String
        Get
            Return (_fechaNacimiento)
        End Get
        Set(ByVal value As String)
            _fechaNacimiento = value
        End Set
    End Property

    Property Sexo() As String
        Get
            Return (_sexo)
        End Get
        Set(ByVal value As String)
            _sexo = value
        End Set
    End Property

    Property Ocupacion() As String
        Get
            Return (_ocupacion)
        End Get
        Set(ByVal value As String)
            _ocupacion = value
        End Set
    End Property

    Property Estado_civil() As String
        Get
            Return (_estado_civil)
        End Get
        Set(ByVal value As String)
            _estado_civil = value
        End Set
    End Property

    Function checkDatosPaciente() As Boolean

        If Not check_Largo(Me._ocupacion, 5, 30, True) Then
            MessageBox.Show("Ocupación: " & MensajeDeErrorLongitud(5, 30), "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        Return 1

    End Function

    Overrides Function buscarPorCI() As Integer
        Conectar()

        Dim sql As String = String.Format("SELECT * FROM usuario,usuario_tel,paciente where usuario.CI='{0}' AND paciente.CI='{0}'", _cedula)
        Console.WriteLine(sql)
        Try
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox(ex.Message)
            Console.WriteLine(ex.Message)
            Console.WriteLine(sql)
            Return 0
        End Try

        If rs.RecordCount > 0 Then
            _cedula = rs("CI").Value.ToString()
            _nombre1 = rs("nombre1").Value
            _nombre2 = rs("nombre2").Value
            _apellido1 = rs("apellido1").Value
            _apellido2 = rs("apellido2").Value

            _telefonosLista.Clear()
            _telefonosLista.Add(rs("telefono").Value)

            _direccion.Clear()
            _direccion.Add(rs("direccion_calle").Value)
            _direccion.Add(rs("direccion_nroPuerta").Value)

            _fechaNacimiento = rs("fecha_nac").Value
            _estado_civil = rs("e_civil").Value
            _ocupacion = rs("ocupacion").Value
            _sexo = rs("sexo").Value
            _correo = rs("correo").Value
            _imagen = rs("foto").Value

        Else
            Return 0
        End If

        Return 1
        rs.Close()

    End Function

    Public Function buscarAnalisis(id_analisis As Integer, id_consulta As Integer) As Analisis
        '1- Sacar primero Información del analisis base
        '2- Sacar luego los resultados del análisis

        Dim a As New Analisis
        a.ID = id_analisis

        Dim sqlAnalisis As String = String.Format("SELECT analisis.ID AS ID_A, analisis.nombre AS Analisis, parametro.nombre as nombre, parametro.unidad as unidad, parametro.referencia_min as minimo, parametro.referencia_max as maximo FROM analisis,parametro,tiene,analisis_indicacion WHERE analisis.ID='{0}' AND tiene.ID_analisis='{0}' AND analisis_indicacion.ID_analisis='{0}'", id_analisis)
        Dim sqlAnalisisR As String = String.Format("SELECT datos.ID_parametro, datos.valor, datos.fecha FROM datos WHERE datos.ID_analisis='{0}' AND datos.ID_consulta='{1}'", id_analisis, id_consulta)

        Conectar()

        Try
            rs.Open(sqlAnalisis, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            rs.Open(sqlAnalisisR, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If rs.RecordCount > 0 Then
            a.ID = rs("ID_A").Value
            a.Nombre = rs("Analisis").Value
            Do While Not rs.State = ConnectionState.Closed

                a.Parametros.Add(New Analisis.Parametro(rs("nombre").Value, rs("unidad").Value, rs("minimo").Value, rs("maximo").Value, rs("valor").Value))
                a.Indicaciones.Add(New Analisis.Indicacion(rs("nombre_i").Value, rs("indicacion").Value))
                rs = rs.NextRecordset()
            Loop

        End If

        rs.Close()

        Return a
    End Function


End Class
