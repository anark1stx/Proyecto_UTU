Public Class E_Usuario
    Protected _cedula As String
    Protected _contrasena As String
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

    Sub New(cedula As String, contrasena As String) 'CONSTRUCTOR PARA LOGIN
        _cedula = cedula
        _contrasena = contrasena
    End Sub

    'CONSTRUCTOR COMPLETO
    Sub New(cedula As String, nombre1 As String, nombre2 As String, apellido1 As String, apellido2 As String, direccion As List(Of String), telefonosLista As List(Of String), correo As String, contrasena As String, imagen As Byte())
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

    Property Contrasena() As String
        Get
            Return (_contrasena)
        End Get
        Set(ByVal value As String)
            _contrasena = value
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

    Property Cedula() As String
        Get
            Return (_cedula)
        End Get
        Set(ByVal value As String)
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
End Class
