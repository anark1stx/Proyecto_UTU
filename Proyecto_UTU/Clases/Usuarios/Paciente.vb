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

            _imagen = rs("foto").Value

            'Dim stream As New ADODB.Stream
            'stream.Open()
            'stream.Type = ADODB.StreamTypeEnum.adTypeBinary
            'stream.Write(rs("foto").Value)
            'stream.Position = 0

            Return 1
        End If
        rs.Close()

    End Function


End Class
