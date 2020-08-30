Public Class frmGestion
    Protected ctrlsPaciente As List(Of Control)
    Protected ctrlsUsuario As List(Of Control)
    Protected ctrlsMedico As List(Of Control)
    Protected _accion As Accion
    Protected _tipo As TipoUsuario
    Dim ci_valida As Boolean = False
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
            Return New List(Of Control)(New Control() {lblEspecialidades, cbEspecialidades, pnlEspecialidadesBtns})
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
        RRefresh()
        setup()
    End Sub

    Sub setup()
        LimpiarControles(Me)
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

        Console.WriteLine("Mode: " & Mode.ToString() & " readonly: " & _readonly)

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
    End Sub

    Private Sub btnAgregarTelefono_Click(sender As Object, e As EventArgs) Handles btnAgregarTelefono.Click

    End Sub

    Private Sub btnSacarTelefono_Click(sender As Object, e As EventArgs) Handles btnSacarTelefono.Click

    End Sub

    Private Sub btnAgregarEspecialidad_Click(sender As Object, e As EventArgs) Handles btnAgregarEspecialidad.Click

    End Sub

    Private Sub btnBorrarEspecialidad_Click(sender As Object, e As EventArgs) Handles btnBorrarEspecialidad.Click

    End Sub

    Private Sub lblCedulaTXT_TextChanged(sender As Object, e As EventArgs) Handles lblCedulaTXT.TextChanged
        If lblCedulaTXT.Text.Length = 8 Then
            'if check_CI() ...
            ci_valida = True
        Else
            ci_valida = False
        End If

        configurarControles()
    End Sub

    Public Sub configurarControles()

        Select Case Mode
            Case Accion.Alta

                If Not check_Cedula(lblCedulaTXT.Text) Then
                    ci_valida = False
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

End Class