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
        _telefonosLista = {}
        _direccion = {}
        _cedula = ""
        _edad = ""
        _sexo = ""
        _ocupacion = ""
        _estado_civil = ""
    End Sub

    Sub New(cedula As String, nombre1 As String, nombre2 As String, apellido1 As String, apellido2 As String, direccion As String(), telefonosLista As String(), correo As String, contrasena As String, edad As String, sexo As String, ocupacion As String, estado_civil As String)
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

    Function checkDatosPaciente() As Boolean

        If Not IsNumeric(Me._edad) Then
            MessageBox.Show("Edad: " & MensajeDeErrorSoloNumeros(), "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        If Not check_Largo(Me._ocupacion, 5, 30, True) Then
            MessageBox.Show("Ocupación: " & MensajeDeErrorLongitud(5, 30), "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        Return 1

    End Function

    Function buscarPorCI() As Integer
        Conectar()

        Dim sql As String = "SELECT * FROM paciente WHERE CI=" & _cedula

        Try
            rs.Open(sql, conn)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If rs.RecordCount = 1 Then

            If rs("activo").Value = 0 Then
                Return 5 'El usuario fue dado de baja
            End If

            _cedula = rs("CI").Value.ToString()
            _nombre1 = rs("nombre1").Value
            _nombre2 = rs("nombre2").Value
            _apellido1 = rs("apellido1").Value
            _apellido2 = rs("apellido2").Value
            _direccion = rs("direccion_calle").Value & rs("direccion_nroPuerta").Value
            _edad = rs("edad").Value
            _estado_civil = rs("e_civil").Value
            _ocupacion = rs("ocupacion").Value
            _sexo = rs("sexo").Value

        End If

    End Function


End Class
