Public Class E_Paciente
    Inherits E_Usuario
    Protected _fechaNacimiento As String
    Protected _sexo As Char
    Protected _ocupacion As String
    Protected _estado_civil As String
    Protected _etapa As Char

    Sub New()

    End Sub

    Sub New(cedula As String, nombre1 As String, nombre2 As String, apellido1 As String, apellido2 As String, direccion_calle As String, direccion_numero As Integer, telefonosLista As List(Of String), correo As String, contrasena As String, fechaNacimiento As String, sexo As Char, ocupacion As String, estado_civil As String, foto As String, etapa As Char, rol As String)
        _nombre1 = nombre1
        _nombre2 = nombre2
        _apellido1 = apellido1
        _apellido2 = apellido2
        _correo = correo
        _contrasena = contrasena
        _telefonosLista = telefonosLista
        _direccion_calle = direccion_calle
        _direccion_numero = direccion_numero
        _cedula = cedula
        _fechaNacimiento = fechaNacimiento
        _sexo = sexo
        _ocupacion = ocupacion
        _estado_civil = estado_civil
        _foto = foto
        _etapa = etapa
        _rol = rol
    End Sub

    Property FechaNacimiento() As String
        Get
            Return (_fechaNacimiento)
        End Get
        Set(ByVal value As String)
            _fechaNacimiento = value
        End Set
    End Property

    Property Sexo() As Char
        Get
            Return (_sexo)
        End Get
        Set(ByVal value As Char)
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

    Property Etapa As Char
        Get
            Return _etapa
        End Get
        Set(value As Char)
            _etapa = value
        End Set
    End Property

    Public Overrides Function ValidarMisDatos() As Boolean

        If Not MyBase.ValidarMisDatos() Then
            _errMsg = MyBase.ErrMsg
            Return 0
        Else
            If Not check_Largo(Me._ocupacion, 5, 30, True) Then
                _errMsg = "Ocupación: " & MensajeDeErrorLongitud(5, 30)
                Return 0
            End If

            Return 1
        End If

    End Function


End Class
