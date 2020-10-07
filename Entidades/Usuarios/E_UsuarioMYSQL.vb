Public Class E_UsuarioMYSQL
    Protected _nombre As String
    Protected _contrasena As String
    Protected _rol As String
    Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Property Contrasena As String
        Get
            Return _contrasena
        End Get
        Set(value As String)
            _contrasena = value
        End Set
    End Property

    Property Rol As String
        Get
            Return _rol
        End Get
        Set(value As String)
            _rol = value
        End Set
    End Property
    Public Sub New(nombre As String, contrasena As String, rol As String)
        _nombre = nombre
        _contrasena = contrasena
        _rol = rol
    End Sub

    Sub New()

    End Sub

End Class
