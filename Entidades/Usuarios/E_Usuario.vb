Public Class E_Usuario
    Inherits E_UsuarioMYSQL
    Protected _errMsg As String
    Protected _cedula As Integer
    Protected _nombre1 As String
    Protected _nombre2 As String
    Protected _apellido1 As String
    Protected _apellido2 As String
    Protected _correo As String
    Protected _telefonosLista As List(Of String) '-> {099523212, 23363539}
    Protected _direccion As List(Of String) ' -> Para pasarle directamente {calle, nroPuerta}
    Protected _foto As Byte()
    Protected _activo As Integer
    Sub New()

    End Sub

    Sub New(cedula As Integer, contrasena As String, rol As String) 'CONSTRUCTOR PARA LOGIN
        _cedula = cedula
        _contrasena = contrasena
        _rol = rol
    End Sub

    'CONSTRUCTOR COMPLETO
    Sub New(cedula As Integer, nombre1 As String, nombre2 As String, apellido1 As String, apellido2 As String, direccion As List(Of String), telefonosLista As List(Of String), correo As String, contrasena As String, imagen As Byte(), rol As String)
        _nombre1 = nombre1
        _nombre2 = nombre2
        _apellido1 = apellido1
        _apellido2 = apellido2
        _correo = correo
        _contrasena = contrasena
        _telefonosLista = telefonosLista
        _direccion = direccion
        _cedula = cedula
        _foto = imagen
        _rol = rol
    End Sub

    'PROPIEDADES GET & SET
    Property Nombre1() As String
        Get
            Return (_nombre1)
        End Get
        Set(ByVal value As String)
            _nombre1 = value
        End Set
    End Property

    Property Nombre2() As String
        Get
            Return (_nombre2)
        End Get
        Set(ByVal value As String)
            _nombre2 = value
        End Set
    End Property

    Property Apellido1() As String
        Get
            Return (_apellido1)
        End Get
        Set(ByVal value As String)
            _apellido1 = value
        End Set
    End Property

    Property Apellido2() As String
        Get
            Return (_apellido2)
        End Get
        Set(ByVal value As String)
            _apellido2 = value
        End Set
    End Property

    Property Correo() As String
        Get
            Return (_correo)
        End Get
        Set(ByVal value As String)
            _correo = value
        End Set
    End Property

    Property TelefonosLista() As List(Of String)
        Get
            Return (_telefonosLista)
        End Get
        Set(ByVal value As List(Of String))
            _telefonosLista = value
        End Set
    End Property

    Property Cedula() As Integer
        Get
            Return (_cedula)
        End Get
        Set(ByVal value As Integer)
            _cedula = value
        End Set
    End Property

    Property Direccion() As List(Of String)
        Get
            Return (_direccion)
        End Get
        Set(ByVal value As List(Of String))
            _direccion = value
        End Set
    End Property

    Property Foto As Byte()
        Get
            Return _foto
        End Get
        Set(value As Byte())
            _foto = value
        End Set
    End Property

    Property Activo As Integer
        Get
            Return _activo
        End Get
        Set(value As Integer)
            _activo = value
        End Set
    End Property

    Property ErrMsg As String
        Get
            Return _errMsg
        End Get
        Set(value As String)
            _errMsg = value
        End Set
    End Property

    Public Overridable Function ValidarMisDatos() As Boolean
        If Not check_Cedula(Me.Cedula) Then
            _errMsg = MensajeDeErrorCedula()
            Return 0
        End If

        If Not check_Largo(Me.Nombre1, 3, 30, True) Then
            _errMsg = "1° Nombre: " & MensajeDeErrorLongitud(3, 30)
            Return 0
        Else
            If check_contieneNumeros(Me.Nombre1) Then
                _errMsg = "1° Nombre: " & MensajeDeErrorsoloLetras()
                Return 0
            End If
        End If

        If Not check_Largo(Me.Nombre2, 3, 30, False) Then
            _errMsg = "2° Nombre: " & MensajeDeErrorLongitud(3, 30)
            Return 0
        Else
            If check_contieneNumeros(Me.Nombre2) Then
                _errMsg = "2° Nombre: " & MensajeDeErrorsoloLetras()
                Return 0
            End If
        End If

        If Not check_Largo(Me.Apellido1, 3, 30, True) Then
            _errMsg = "1° Apellido: " & MensajeDeErrorLongitud(3, 30)
            Return 0
        Else
            If check_contieneNumeros(Me.Apellido1) Then
                _errMsg = "1° Apellido: " & MensajeDeErrorsoloLetras()
                Return 0
            End If
        End If

        If Not check_Largo(Me.Apellido2, 3, 30, False) Then
            _errMsg = "2° Apellido: " & MensajeDeErrorLongitud(3, 30)
            Return 0
        Else
            If check_contieneNumeros(Me.Apellido2) Then
                _errMsg = "2° Apellido: " & MensajeDeErrorsoloLetras()
                Return 0
            End If
        End If

        If Not check_Correo(Me.Correo) Then
            _errMsg = "Correo: " & MensajeDeErrorCorreo()
            Return 0
        End If

        If Not check_Telefonos(Me.TelefonosLista()) Then
            _errMsg = "Teléfonos: " & MensajeDeErrorTelefonos()
            Return 0
        End If

        If Not check_direccion(Me.Direccion) Then
            _errMsg = "Dirección: " & MensajeDeErrorDireccion()
            Return 0
        End If

        If Not check_Largo(Me.Contrasena, 8, 30, True) Then
            _errMsg = "Contraseña: " & MensajeDeErrorLongitud(8, 30)
            Return 0
        End If

        Return 1

    End Function

End Class
