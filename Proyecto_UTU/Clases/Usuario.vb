Public Class Usuario
    'Pasamos todos los datos como Strings por conveniencia general, a la hora de validar comprobaremos que sean del tipo que tienen que ser (cedula = Int).
    Protected _nombre1 As String
    Protected _nombre2 As String
    Protected _apellido1 As String
    Protected _apellido2 As String
    Protected _correo As String
    Protected _usuario As String
    Protected _contrasena As String
    Protected _telefonosLista As List(Of String)
    Protected _cedula As String

    'CONSTRUCTOR VACIO
    Sub New()
        _nombre1 = ""
        _nombre2 = ""
        _apellido1 = ""
        _apellido2 = ""
        _correo = ""
        _usuario = ""
        _contrasena = ""
        _telefonosLista = New List(Of String)
        _cedula = ""
    End Sub

    Sub New(usuario As String, contrasena As String) 'CONSTRUCTOR PARA LOGIN
        _nombre1 = ""
        _nombre2 = ""
        _apellido1 = ""
        _apellido2 = ""
        _correo = ""
        _usuario = usuario
        _contrasena = contrasena
        _telefonosLista = New List(Of String)
        _cedula = ""
    End Sub

    'CONSTRUCTOR COMPLETO
    Sub New(nombre1 As String, nombre2 As String, apellido1 As String, apellido2 As String, correo As String, usuario As String, contrasena As String, telefonosLista As List(Of String), cedula As String)
        _nombre1 = nombre1
        _nombre2 = nombre2
        _apellido1 = apellido1
        _apellido2 = apellido2
        _correo = correo
        _usuario = usuario
        _contrasena = contrasena
        _telefonosLista = telefonosLista
        _cedula = cedula
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

    Property Usuario() As String
        Get
            Return (_usuario)
        End Get
        Set(ByVal value As String)
            _usuario = value
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

    Property telefonosLista() As List(Of String)
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

End Class