Public Class frmGestion
    Protected ctrlsPaciente As List(Of Control)
    Protected ctrlsUsuario As List(Of Control)
    Protected ctrlsMedico As List(Of Control)
    Protected _accion As Accion
    Protected _tipo As TipoUsuario
    Private ci_valida As Boolean = False
    Public Enum Accion
        Alta
        Baja
        Modificacion
    End Enum

    Public Enum TipoUsuario
        Paciente
        Medico
        Auxiliar
    End Enum

    Property Mode As Accion
        Get
            Return _accion
        End Get
        Set(value As Accion)
            _accion = value
        End Set
    End Property

    Property Usuario As TipoUsuario
        Get
            Return _tipo
        End Get
        Set(value As TipoUsuario)
            _tipo = value
        End Set
    End Property

    ReadOnly Property BASEcontrolesU As List(Of Control)
        Get
            Return New List(Of Control)(New Control() {lblCedulaTXT, lblNombre1TXT, lblNombre2TXT, lblApellido1TXT, lblApellido2TXT, lblDireccionTXT, lblCorreoTXT, cbTelefonos})
        End Get
    End Property

    ReadOnly Property BASEcontrolesP As List(Of Control)
        Get
            Return New List(Of Control)(New Control() {lblFnac, dateFechaNacimiento, lblEtapa, cbEtapa, lblEstadoCivil, cbEstadoCivil, lblSexo, cbSexo, lblOcupacion, lblOcupacionTXT})
        End Get
    End Property

    ReadOnly Property BASEcontrolesM As List(Of Control)
        Get
            Return New List(Of Control)(New Control() {lblEspecialidades, cbEspecialidades, pnlEspecialidadesBtns, rBtnEspecialidad})
        End Get
    End Property

    Property ControlesUsuario As List(Of Control)
        Get
            Return ctrlsUsuario
        End Get
        Set(value As List(Of Control))
            ctrlsUsuario = value
        End Set
    End Property

    Property ControlesPaciente As List(Of Control)
        Get
            Return ctrlsPaciente
        End Get
        Set(value As List(Of Control))
            ctrlsPaciente = value
        End Set
    End Property

    Property ControlesMedico As List(Of Control)
        Get
            Return ctrlsMedico
        End Get
        Set(value As List(Of Control))
            ctrlsMedico = value
        End Set
    End Property

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setup()
    End Sub

    Sub setup()
        RRefresh()
        cambiarVisibilidad()
        resetMode()
        ConvertirProps()
        configurarControles()
    End Sub

    Sub resetMode()
        Select Case Mode
            Case Accion.Alta
                btnAccion1.ImageIndex = 1 '1 = Alta
                btnAccion2.ImageIndex = 1 '1 = limpiar
                pnlContenedorBusqueda.Visible = False
                pnlBotonesTel.Visible = True
            Case Accion.Modificacion
                btnAccion1.ImageIndex = 2 '2 = Mod Tick
                btnAccion2.ImageIndex = 1 '1 = limpiar
                pnlContenedorBusqueda.Visible = True
                pnlBotonesTel.Visible = True
            Case Accion.Baja
                btnAccion1.ImageIndex = 0 '0 = Baja
                btnAccion2.ImageIndex = 0 '1 = Modificar
                pnlContenedorBusqueda.Visible = True
                pnlBotonesTel.Visible = False

        End Select
    End Sub

    Sub cambiarVisibilidad()

        Select Case Usuario
            Case TipoUsuario.Auxiliar
                For Each c As Control In ControlesMedico
                    c.Visible = False
                Next

                For Each c As Control In ControlesPaciente
                    c.Visible = False
                Next
            Case TipoUsuario.Medico
                For Each c As Control In ControlesMedico
                    c.Visible = True
                Next

                For Each c As Control In ControlesPaciente
                    c.Visible = False
                Next
            Case TipoUsuario.Paciente
                For Each c As Control In ControlesMedico
                    c.Visible = False
                Next

                For Each c As Control In ControlesPaciente
                    c.Visible = True
                Next
        End Select
    End Sub

    Public Sub ConvertirProps()

        Dim news As New List(Of Control)
        Dim _readonly As Boolean = True

        Select Case Mode
            Case Accion.Alta, Accion.Modificacion 'Todo en textboxes con fondo blanco
                _readonly = False
            Case Accion.Baja
                _readonly = True 'Todo en textboxes pero con fondo celeste, como si fuera label.
        End Select

        Dim l As New List(Of Control)
        For Each c As Control In ControlesUsuario
            l.Add(convertirC(c, _readonly))
        Next
        ControlesUsuario = l

        Select Case Usuario
            Case TipoUsuario.Paciente
                Dim l2 As New List(Of Control)
                For Each c As Control In ControlesPaciente
                    l2.Add(convertirC(c, _readonly))
                Next
                ControlesPaciente = l2
            Case TipoUsuario.Medico
                Dim l2 As New List(Of Control)
                For Each c As Control In ControlesMedico
                    l2.Add(convertirC(c, _readonly))
                Next
                ControlesMedico = l2
        End Select

    End Sub

    Public Function convertirC(c As Control, _readonly As Boolean) As Control
        Select Case c.GetType()
            Case GetType(ComboBox)
                c = DirectCast(c, ComboBox)
                If DirectCast(c, ComboBox).DropDownStyle = ComboBoxStyle.DropDown Then
                    c.Enabled = True
                    Return c
                End If

                c.Enabled = Not _readonly

                Return c

            Case GetType(DateTimePicker)
                c.Enabled = Not _readonly
                Return c
            Case GetType(TextBox)
                Console.WriteLine("entro en textbox " & c.Name)
                c.ResetText()
                DirectCast(c, TextBox).ReadOnly = _readonly

                If _readonly Then
                    c.BackColor = Color.LightBlue
                    DirectCast(c, TextBox).BorderStyle = BorderStyle.None
                    Console.WriteLine("solo lectura")
                Else
                    c.BackColor = Color.White
                    DirectCast(c, TextBox).BorderStyle = BorderStyle.Fixed3D
                    Console.WriteLine("insert")
                End If
                Return c
            Case Else
                Return c
        End Select
    End Function

    Public Sub RRefresh()
        ControlesMedico = BASEcontrolesM
        ControlesPaciente = BASEcontrolesP
        ControlesUsuario = BASEcontrolesU
        LimpiarControles(Me)
    End Sub

    Private Sub btnAgregarTelefono_Click(sender As Object, e As EventArgs) Handles btnAgregarTelefono.Click

        If Not check_Telefonos(New List(Of String)(New String() {cbTelefonos.Text})) Then
            MessageBox.Show("Teléfono inválido. " & optMsg, "Información errónea", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            If cbTelefonos.Items.IndexOf(cbTelefonos.Text) < 0 Then
                cbTelefonos.Items.Add(cbTelefonos.Text)
            Else
                MessageBox.Show("Ese teléfono ya fue ingresado en la lista.", "Información duplicada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnSacarTelefono_Click(sender As Object, e As EventArgs) Handles btnSacarTelefono.Click
        If cbTelefonos.Text Is String.Empty Then
            MessageBox.Show("Seleccione el teléfono que desea remover.", "Falta seleccionar elemento", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        cbTelefonos.Items.Remove(cbTelefonos.Text)
    End Sub

    Private Sub btnAgregarEspecialidad_Click(sender As Object, e As EventArgs) Handles btnAgregarEspecialidad.Click

        If Not check_Largo(cbEspecialidades.Text, 3, 50, True) Then
            MessageBox.Show("Especialidad inválida.", "Información errónea", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            If cbEspecialidades.Items.IndexOf(cbEspecialidades.Text) < 0 Then
                cbEspecialidades.Items.Add(cbEspecialidades.Text)
            Else
                MessageBox.Show("Esa especialidad ya fue ingresado en la lista.", "Información duplicada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnBorrarEspecialidad_Click(sender As Object, e As EventArgs) Handles btnBorrarEspecialidad.Click
        If cbEspecialidades.Text Is String.Empty Then
            MessageBox.Show("Seleccione la especialidad que desea remover.", "Falta seleccionar elemento", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        cbEspecialidades.Items.Remove(cbEspecialidades.Text)
    End Sub

    Private Sub lblCedulaTXT_TextChanged(sender As Object, e As EventArgs) Handles lblCedulaTXT.TextChanged
        configurarControles()
        If lblCedulaTXT.Text.Length = lblCedulaTXT.MaxLength Then
            If Not ci_valida Then
                MessageBox.Show(MensajeDeErrorCedula(), "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Mode = Accion.Alta Then
                    '()-> verificar existencia en BD
                    'if existe ()-> ci_valida = false, ()->MsgBox ya existe un usuario registrado con esa cedula
                    '
                End If
            End If
        End If
    End Sub

    Public Sub configurarControles()

        Select Case Mode
            Case Accion.Alta
                lblCedulaTXT.Enabled = True
                If Not check_Cedula(lblCedulaTXT.Text) Then
                    ci_valida = False
                Else
                    ci_valida = True
                End If

                If Not ci_valida Then
                    pnlDspCedula.Enabled = False
                Else
                    pnlDspCedula.Enabled = True
                End If
            Case Accion.Modificacion
                lblCedulaTXT.Enabled = False
                If lblCedulaTXT.Text Is String.Empty Then
                    pnlDspCedula.Enabled = False
                Else
                    pnlDspCedula.Enabled = True
                End If
            Case Accion.Baja
                lblCedulaTXT.Enabled = False
        End Select
    End Sub

    Private Sub btnAccion1_Click(sender As Object, e As EventArgs) Handles btnAccion1.Click
        Select Case Mode
            Case Accion.Alta
                AltaU()
            Case Accion.Baja
                BajaU()
            Case Accion.Modificacion
                ModificarU()
        End Select
    End Sub

    Private Sub btnAccion2_Click(sender As Object, e As EventArgs) Handles btnAccion2.Click
        Select Case Mode
            Case Accion.Alta, Accion.Modificacion 'limpiar
                LimpiarControles(Me)
            Case Accion.Baja 'editar
                Mode = Accion.Modificacion
                setup()
        End Select
    End Sub

    Sub AltaU()
        If cbTelefonos.Items.Count < 1 Then
            MessageBox.Show("Ingrese al menos un telefono de contacto.", "Falta ingresar información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim direccion As New List(Of String)(lblDireccionTXT.Text.Split(","))

        For i = 0 To direccion.Count - 1
            direccion(i) = RemoverEspacios(direccion(i))
        Next

        If Not check_direccion(direccion) Then
            MessageBox.Show(MensajeDeErrorDireccion(), "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim telefonos As New List(Of String)
        For Each t As String In cbTelefonos.Items
            telefonos.Add(t)
        Next

        Dim ci As Integer = Val(lblCedulaTXT.Text)
        Dim nombre1 As String = lblNombre1TXT.Text
        Dim nombre2 As String = lblNombre2TXT.Text
        Dim apellido1 As String = lblApellido1TXT.Text
        Dim apellido2 As String = lblApellido2TXT.Text
        Dim direccion_calle As String = direccion(0)
        Dim direccion_nroPuerta As Integer = Val(direccion(1))

        Select Case Usuario
            Case TipoUsuario.Paciente
                'do stuff
            Case TipoUsuario.Medico
                'do stuff
                If cbTelefonos.Items.Count < 1 Then
                    MessageBox.Show("Ingrese al menos una especialidad.", "Falta ingresar información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim especialidades As New List(Of String)
                For Each es As String In cbEspecialidades.Items
                    especialidades.Add(es)
                Next
            Case TipoUsuario.Auxiliar
                'do stuff
        End Select

    End Sub

    Sub BajaU()
        '()->BajaLogica
    End Sub

    Sub BuscarU()
        '()->Buscar[Usuario]x[PARAMETRO]
    End Sub

    Sub ModificarU()
        '()->Modificar[USUARIO]
    End Sub

    Private Sub SinEspacios(sender As Object, e As KeyPressEventArgs) Handles lblCedulaTXT.KeyPress, lblCorreoTXT.KeyPress, cbTelefonos.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub
End Class