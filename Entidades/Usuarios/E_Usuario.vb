Imports Utilidades
Public Class E_Usuario
    Inherits E_UsuarioMYSQL
    Protected _cedula As Integer
    Protected _nombre1 As String
    Protected _nombre2 As String
    Protected _apellido1 As String
    Protected _apellido2 As String
    Protected _correo As String
    Protected _telefonosLista As List(Of String) '-> {099523212, 23363539}
    Protected _direccion_calle As String
    Protected _direccion_numero As Integer
    Protected _foto As Byte()
    Protected _activo As Boolean
    Sub New()

    End Sub

    Sub New(cedula As Integer, contrasena As String, rol As String) 'CONSTRUCTOR PARA LOGIN
        _cedula = cedula
        _contrasena = contrasena
        _rol = rol
    End Sub

    'CONSTRUCTOR COMPLETO
    Sub New(cedula As Integer, nombre1 As String, nombre2 As String, apellido1 As String, apellido2 As String, direccion_calle As String, direccion_numero As Integer, telefonosLista As List(Of String), correo As String, contrasena As String, imagen As Byte(), rol As String, activo As Boolean)
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
        _foto = imagen
        _rol = rol
        _activo = activo
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

    Property Direccion_Calle() As String
        Get
            Return (_direccion_calle)
        End Get
        Set(ByVal value As String)
            _direccion_calle = value
        End Set
    End Property
    Property Direccion_Numero() As Integer
        Get
            Return (_direccion_numero)
        End Get
        Set(ByVal value As Integer)
            _direccion_numero = value
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

    Property Activo As Boolean
        Get
            Return _activo
        End Get
        Set(value As Boolean)
            _activo = value
        End Set
    End Property

    Public Overridable Function ValidarMisDatos() As Boolean
        If Not check_Cedula(Me.Cedula) Then
            Me.Nombre = MensajeDeErrorCedula()
            Return 0
        End If

        If Not check_Largo(Me.Nombre1, 3, 30, True) Then
            Me.Nombre = "1° Nombre: " & MensajeDeErrorLongitud(3, 30)
            Return 0
        Else
            If Not check_regex(Me.Nombre1, RegexLiteralAcentos) Then
                Me.Nombre = "1° Nombre: " & MensajeDeErrorsoloLetras()
                Return 0
            End If
        End If

        If Not check_Largo(Me.Nombre2, 3, 30, False) Then
            Me.Nombre = "2° Nombre: " & MensajeDeErrorLongitud(3, 30)
            Return 0
        Else
            If Not check_regex(Me.Nombre2, RegexLiteralAcentos) Then
                Me.Nombre = "2° Nombre: " & MensajeDeErrorsoloLetras()
                Return 0
            End If
        End If

        If Not check_Largo(Me.Apellido1, 3, 30, True) Then
            Me.Nombre = "1° Apellido: " & MensajeDeErrorLongitud(3, 30)
            Return 0
        Else
            If Not check_regex(Me.Apellido1, RegexLiteralAcentos) Then
                Me.Nombre = "1° Apellido: " & MensajeDeErrorsoloLetras()
                Return 0
            End If
        End If

        If Not check_Largo(Me.Apellido2, 3, 30, False) Then
            Me.Nombre = "2° Apellido: " & MensajeDeErrorLongitud(3, 30)
            Return 0
        Else
            If Not check_regex(Me.Apellido2, RegexLiteralAcentos) Then
                Me.Nombre = "2° Apellido: " & MensajeDeErrorsoloLetras()
                Return 0
            End If
        End If

        If Not check_Correo(Me.Correo) Then
            Me.Nombre = "Correo: " & MensajeDeErrorCorreo()
            Return 0
        End If

        If Not check_Telefonos(Me.TelefonosLista()) Then
            Me.Nombre = "Teléfonos: " & MensajeDeErrorTelefonos()
            Return 0
        End If

        If Not check_direccion(New List(Of String)(New String() {Direccion_Calle, Direccion_Numero.ToString()})) Then
            Me.Nombre = "Dirección: " & MensajeDeErrorDireccion()
            Return 0
        End If

        If Not check_Largo(Me.Contrasena, 8, 30, True) Then
            Me.Nombre = "Contraseña: " & MensajeDeErrorLongitud(8, 30)
            Return 0
        End If

        Return 1

    End Function

End Class
