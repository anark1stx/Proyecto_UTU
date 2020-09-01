Public Class E_Medico
    Inherits E_Usuario

    Protected _especialidad As List(Of String)

    Property Especialidad() As List(Of String)
        Get
            Return (_especialidad)
        End Get
        Set(ByVal value As List(Of String))
            _especialidad = value
        End Set
    End Property
    Sub New()

    End Sub

    Sub New(cedula As Integer, nombre1 As String, nombre2 As String, apellido1 As String, apellido2 As String, direccion_calle As String, direccion_numero As Integer, telefonosLista As List(Of String), correo As String, contrasena As String, especialidades As List(Of String), foto As String, rol As String)
        _cedula = cedula
        _nombre1 = nombre1
        _nombre2 = nombre2
        _apellido1 = apellido1
        _apellido2 = apellido2
        _correo = correo
        _contrasena = contrasena
        _telefonosLista = telefonosLista
        _direccion_calle = direccion_calle
        _direccion_numero = direccion_numero
        _especialidad = especialidades
        _foto = foto
        _rol = rol
    End Sub

    Public Overrides Function ValidarMisDatos() As Boolean
        If Not MyBase.ValidarMisDatos() Then
            Return 0
        End If

        For Each es As String In Especialidad
            If Not check_Largo(es, 3, 50, True) Then
                _errMsg = "Especialidad " & es & " " & MensajeDeErrorLongitud(3, 50)
                Return 0
            End If
        Next

        Return 1
    End Function


End Class
