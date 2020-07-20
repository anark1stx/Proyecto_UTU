Public Class Medico
    Inherits Usuario

    Protected _especialidad As String

    Sub New()
        _nombre1 = ""
        _nombre2 = ""
        _apellido1 = ""
        _apellido2 = ""
        _correo = ""
        _contrasena = ""
        _telefonosLista = {}
        _cedula = ""
        _direccion = {}
        _especialidad = ""
    End Sub

    Sub New(cedula As String, nombre1 As String, nombre2 As String, apellido1 As String, apellido2 As String, direccion As String(), telefonosLista As String(), correo As String, contrasena As String, especialidad As String)
        _nombre1 = nombre1
        _nombre2 = nombre2
        _apellido1 = apellido1
        _apellido2 = apellido2
        _correo = correo
        _contrasena = contrasena
        _telefonosLista = telefonosLista
        _cedula = cedula
        _direccion = direccion
        _especialidad = especialidad
    End Sub

    Property Especialidad() As String
        Get
            Return (_especialidad)
        End Get
        Set(ByVal value As String)
            _especialidad = value
        End Set
    End Property

End Class
