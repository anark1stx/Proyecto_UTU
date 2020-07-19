Public Class Paciente
    Inherits Usuario

    Protected _edad As String
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
        _cedula = ""
        _edad = ""
        _sexo = ""
        _ocupacion = ""
        _estado_civil = ""
    End Sub

    Sub New(cedula As String, nombre1 As String, nombre2 As String, apellido1 As String, apellido2 As String, direccion As String, telefonosLista As List(Of String), correo As String, contrasena As String, edad As String, sexo As String, ocupacion As String, estado_civil As String)
        _nombre1 = nombre1
        _nombre2 = nombre2
        _apellido1 = apellido1
        _apellido2 = apellido2
        _correo = correo
        _contrasena = contrasena
        _telefonosLista = telefonosLista
        _direccion = direccion
        _cedula = cedula
        _edad = edad
        _sexo = sexo
        _ocupacion = ocupacion
        _estado_civil = estado_civil
    End Sub

    Property Edad() As String
        Get
            Return (_edad)
        End Get
        Set(ByVal value As String)
            _edad = value
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



End Class
