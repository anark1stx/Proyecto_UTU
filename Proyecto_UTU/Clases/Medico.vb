Public Class Medico
    Inherits Usuario

    Protected _especialidades As String()

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
        _especialidades = {}
    End Sub

    Sub New(cedula As String, nombre1 As String, nombre2 As String, apellido1 As String, apellido2 As String, direccion As String(), telefonosLista As String(), correo As String, contrasena As String, especialidades As String())
        _nombre1 = nombre1
        _nombre2 = nombre2
        _apellido1 = apellido1
        _apellido2 = apellido2
        _correo = correo
        _contrasena = contrasena
        _telefonosLista = telefonosLista
        _cedula = cedula
        _direccion = direccion
        _especialidades = especialidades
    End Sub

    Property Especialidad() As String()
        Get
            Return (_especialidades)
        End Get
        Set(ByVal value As String())
            _especialidades = value
        End Set
    End Property

    Function checkDatosMed() As Boolean
        Dim esps_count As Integer = 0

        If _especialidades.Count = 1 Then
            If _especialidades(0) = "" Then
                MessageBox.Show("Especialidad: Ingrese al menos 1 especialidad", "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                optMsg = "Ingrese una especialidad"
                Return 0
            End If

        End If

        For Each especialidad As String In Me._especialidades
            If Not check_Largo(especialidad, 5, 30, True) Then
                Return 0
                MessageBox.Show(MensajeDeErrorEspecialidad(especialidad) & MensajeDeErrorLongitud(5, 30), "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                esps_count += 1
            End If
        Next
        Return 1
    End Function


End Class
