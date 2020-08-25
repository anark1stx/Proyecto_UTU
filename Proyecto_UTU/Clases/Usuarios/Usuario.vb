Public Class Usuario
    'Pasamos todos los datos como Strings por conveniencia general, a la hora de validar comprobaremos que sean del tipo que tienen que ser (cedula = Int).
    Protected _cedula As String
    Protected _contrasena As String
    Protected _nombre1 As String
    Protected _nombre2 As String
    Protected _apellido1 As String
    Protected _apellido2 As String
    Protected _correo As String
    Protected _telefonosLista As List(Of String) '-> {099523212, 23363539}
    Protected _direccion As List(Of String) ' -> Para pasarle directamente {calle, nroPuerta}
    Protected _imagen As Byte()
    'CONSTRUCTOR VACIO
    Sub New()
        _nombre1 = ""
        _nombre2 = ""
        _apellido1 = ""
        _apellido2 = ""
        _correo = ""
        _contrasena = ""
        _telefonosLista = New List(Of String)
        _cedula = ""
        _imagen = {}
    End Sub

    Sub New(cedula As String, contrasena As String) 'CONSTRUCTOR PARA LOGIN
        _cedula = cedula
        _nombre1 = ""
        _nombre2 = ""
        _apellido1 = ""
        _apellido2 = ""
        _correo = ""
        _imagen = {}
        _contrasena = contrasena
        _telefonosLista = New List(Of String)
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
        _imagen = imagen
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

    Property direccion() As List(Of String)
        Get
            Return (_direccion)
        End Get
        Set(ByVal value As List(Of String))
            _direccion = value
        End Set
    End Property

    Property imagen As Byte()
        Get
            Return _imagen
        End Get
        Set(value As Byte())
            _imagen = value
        End Set
    End Property

    Function checkDatos() As Boolean

        If Not check_Cedula(Me.Cedula) Then
            MessageBox.Show(MensajeDeErrorCedula(), "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        If Not check_Largo(Me.Nombre1, 3, 15, True) Then
            MessageBox.Show("1° Nombre: " & MensajeDeErrorLongitud(3, 15), "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        Else
            If check_contieneNumeros(Me.Nombre1) Then
                MessageBox.Show("1° Nombre: " & MensajeDeErrorsoloLetras(), "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return 0
            End If
        End If

        If Not check_Largo(Me.Nombre2, 3, 15, False) Then
            MessageBox.Show("2° Nombre: " & MensajeDeErrorLongitud(3, 15), "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        Else
            If check_contieneNumeros(Me.Nombre2) Then
                MessageBox.Show("2° Nombre: " & MensajeDeErrorsoloLetras(), "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return 0
            End If
        End If

        If Not check_Largo(Me.Apellido1, 3, 15, True) Then
            MessageBox.Show("1° Apellido: " & MensajeDeErrorLongitud(3, 15), "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        Else
            If check_contieneNumeros(Me.Apellido1) Then
                MessageBox.Show("1° Apellido: " & MensajeDeErrorsoloLetras(), "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return 0
            End If
        End If

        If Not check_Largo(Me.Apellido2, 3, 15, False) Then
            MessageBox.Show("2° Apellido: " & MensajeDeErrorLongitud(3, 15), "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        Else
            If check_contieneNumeros(Me.Apellido2) Then
                MessageBox.Show("2° Apellido: " & MensajeDeErrorsoloLetras(), "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return 0
            End If
        End If

        If Not check_Correo(Me.Correo) Then
            MessageBox.Show("Correo: " & MensajeDeErrorCorreo(), "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        If Not check_Telefonos(Me.telefonosLista()) Then
            MessageBox.Show("Teléfonos: " & MensajeDeErrorTelefonos(), "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        If Not check_direccion(Me.direccion) Then
            MessageBox.Show("Dirección: " & MensajeDeErrorDireccion(), "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        If Not check_Largo(Me.Contrasena, 8, 15, True) Then
            MessageBox.Show("Contraseña: " & MensajeDeErrorLongitud(8, 15), "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        Return 1

    End Function

    Overridable Function buscarPorCI() As Integer
        Conectar()

        Dim sql As String = String.Format("SELECT * FROM usuario,usuario_tel where usuario.CI={0}", _cedula)

        Try
            rs.Open(sql, conn)
        Catch ex As Exception
            rs.Close()
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

            _telefonosLista.Clear()
            _telefonosLista.Add(rs("telefono").Value)

            _direccion.Clear()
            _direccion.Add(rs("direccion_calle").Value)
            _direccion.Add(rs("direccion_nroPuerta").Value)

            _imagen = rs("foto").Value
        End If

        rs.Close()

    End Function

End Class