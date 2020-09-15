Imports FormulariosPersonalizados
Imports Entidades
Imports Negocio
Imports Utilidades
Public Class frmCrearFormulario

    Dim negocio As New N_Formulario

    Dim _cursor As Cursor = Cursors.Hand
    Dim frmPlano As New formularioPlano

    Dim ubicacion_mouse As Point

    Dim _instancia As New Control
    Dim controlesInstanciados As New List(Of Control)
    Dim control_count As Integer = 0

    Dim TipoDeTxt As New MsgBoxTipoDeTextBox
    Dim settings As New MsgBoxControlSettings
    Dim catalogo As New frmCatalogoFormulariosBD
    Dim agregarItems As New frmAgregarItems

    Dim PedirNombre As New frmPedirNombreForm
    Protected _formDisenado As New E_Formulario

    Property FormDisenado As E_Formulario
        Get
            Return _formDisenado
        End Get
        Set(value As E_Formulario)
            _formDisenado = value
        End Set
    End Property

    Private Sub frmCrearFormulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
        Me.WindowState = FormWindowState.Maximized
        frmPlano.TopLevel = False
        frmPlano.TopMost = True
        frmPlano.Dock = DockStyle.Fill
        pnlFormularioPersonalizado.Controls.Add(frmPlano)

        frmPlano.Show()

    End Sub
#Region "Eventos para el TextBox"

    Private Sub txtControl_MouseDown(sender As Object, e As MouseEventArgs) Handles txtTextBox.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            MostrarManito()
            Dim _txt As New TextBox

            agregarHandlersBasicos(_txt)
            _txt.Size = New Size(122, 55)
            _txt.Name = "txt"
            _txt.Multiline = True
            _instancia = _txt

            Me.Controls.Add(_instancia)
            _instancia.BringToFront()
            ubicacion_mouse = e.Location
        End If
    End Sub

    Private Sub txtControl_MouseMove(sender As Object, e As MouseEventArgs) Handles txtTextBox.MouseMove

        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            MostrarManito()
            _instancia.Left = e.X + txtTextBox.Left - ubicacion_mouse.X
            _instancia.Top = e.Y + txtTextBox.Top - ubicacion_mouse.Y
        End If
    End Sub

    Public Sub txtTextBox_MouseUp(sender As Object, e As MouseEventArgs) Handles txtTextBox.MouseUp
        If e.Location.X > pnlFormularioPersonalizado.Left Then
            LimpiarControles(TipoDeTxt)
            Dim listaP As New List(Of Control)
            For Each pyr As PreguntaRespuesta In frmPlano.PreguntasYRespuestas
                listaP.Add(pyr.Pregunta)
            Next
            TipoDeTxt.cbTipoDeDato.DataSource = listaP
            TipoDeTxt.cbTipoDeDato.DisplayMember = "Text"
            TipoDeTxt.cbTipoDeDato.ValueMember = "Tag"
            TipoDeTxt.ShowDialog()
            If TipoDeTxt.cbTipoDeDato.SelectedIndex <> -1 Then
                _instancia.Tag = TipoDeTxt.cbTipoDeDato.SelectedValue
                frmPlano.PreguntasYRespuestas.Find(Function(p) p.Pregunta.Tag = TipoDeTxt.cbTipoDeDato.SelectedValue).Respuesta = _instancia
            End If
            setType()
        Else
            Me.Controls.Remove(_instancia)
        End If
    End Sub
#End Region

#Region "eventos para la Label"
    Private Sub lblLabel_MouseDown(sender As Object, e As MouseEventArgs) Handles lblLabel.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            MostrarManito()
            Dim _lbl As New Label
            agregarHandlersBasicos(_lbl)
            _lbl.Size = New Size(50, 25)
            _lbl.Name = "lbl"
            _lbl.Text = "Texto"
            _lbl.AutoSize = True
            _instancia = _lbl
            Me.Controls.Add(_instancia)
            _instancia.BringToFront()
            ubicacion_mouse = e.Location
        End If
    End Sub

    Private Sub lblLabel_MouseMove(sender As Object, e As MouseEventArgs) Handles lblLabel.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            MostrarManito()
            _instancia.Left = e.X + lblLabel.Left - ubicacion_mouse.X
            _instancia.Top = e.Y + lblLabel.Top - ubicacion_mouse.Y
        End If
    End Sub

    Private Sub lblLabel_MouseUp(sender As Object, e As MouseEventArgs) Handles lblLabel.MouseUp
        LimpiarControles(settings)
        SettingsTXTvisibles(True)
        MostrarChk(True)
        settings.ShowDialog()
        setType()
        If settings.chkSoyPregunta.Checked Then
            frmPlano.tagCount += 1
            _instancia.Tag = String.Format("p{0}", frmPlano.tagCount) 'setteo el tag
            frmPlano.PreguntasYRespuestas.Add(New PreguntaRespuesta(_instancia.Tag, _instancia))
        End If
        settings.Hide()
    End Sub

#End Region

#Region "eventos para el CheckBox"
    Private Sub chkBox_MouseDown(sender As Object, e As MouseEventArgs) Handles chkBox.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            MostrarManito()
            Dim _chk As New CheckBox
            agregarHandlersBasicos(_chk)
            _chk.Size = New Size(50, 25)
            _chk.Name = "chk"
            _chk.Text = "Texto"
            _chk.AutoSize = True
            _instancia = _chk
            Me.Controls.Add(_instancia)
            _instancia.BringToFront()
            ubicacion_mouse = e.Location
        End If
    End Sub

    Private Sub chkBox_MouseMove(sender As Object, e As MouseEventArgs) Handles chkBox.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            MostrarManito()
            _instancia.Left = e.X + chkBox.Left - ubicacion_mouse.X
            _instancia.Top = e.Y + chkBox.Top - ubicacion_mouse.Y
        End If
    End Sub

    Private Sub chkBox_MouseUp(sender As Object, e As MouseEventArgs) Handles chkBox.MouseUp
        LimpiarControles(settings)
        SettingsTXTvisibles(True)
        MostrarChk(False)
        settings.chkSoyPregunta.Checked = True
        settings.ShowDialog()
        setType()
        frmPlano.tagCount += 1
        _instancia.Tag = String.Format("p{0}", frmPlano.tagCount) 'setteo el tag
        frmPlano.PreguntasYRespuestas.Add(New PreguntaRespuesta(_instancia.Tag, _instancia, _instancia))
    End Sub
#End Region
#Region "eventos para el Button"
    Private Sub btnButton_MouseDown(sender As Object, e As MouseEventArgs) Handles btnBoton.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            MostrarManito()
            Dim _btn As New Button
            agregarHandlersBasicos(_btn)
            _btn.Size = New Size(50, 25)
            _btn.AutoSize = True
            _btn.Name = "btn"
            _btn.Text = "Boton"
            _instancia = _btn
            Me.Controls.Add(_instancia)
            _instancia.BringToFront()
            ubicacion_mouse = e.Location
        End If
    End Sub

    Private Sub btnButton_MouseMove(sender As Object, e As MouseEventArgs) Handles btnBoton.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            MostrarManito()
            _instancia.Left = e.X + btnBoton.Left - ubicacion_mouse.X
            _instancia.Top = e.Y + btnBoton.Top - ubicacion_mouse.Y
        End If
    End Sub

    'PENDIENTE: Serializar los eventos del boton
    Private Sub btnBoton_MouseUp(sender As Object, e As MouseEventArgs) Handles btnBoton.MouseUp
        LimpiarControles(settings)
        MostrarChk(False)
        SettingsTXTvisibles(False)
        settings.ShowDialog()

        setType()
    End Sub
#End Region
#Region "eventos para la ListBox"
    Private Sub lbListbox_MouseDown(sender As Object, e As MouseEventArgs) Handles lbListBox.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            MostrarManito()
            Dim _lb As New ListBox
            agregarHandlersBasicos(_lb)
            _lb.Size = New Size(100, 25)
            _lb.AutoSize = True
            _lb.Name = "lb"
            _lb.Text = "Lista de items"
            _instancia = _lb
            Me.Controls.Add(_instancia)
            _instancia.BringToFront()
            ubicacion_mouse = e.Location
        End If
    End Sub

    Private Sub lbListbox_MouseMove(sender As Object, e As MouseEventArgs) Handles lbListBox.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            MostrarManito()
            _instancia.Left = e.X + lbListBox.Left - ubicacion_mouse.X
            _instancia.Top = e.Y + lbListBox.Top - ubicacion_mouse.Y
        End If
    End Sub

    'PENDIENTE: Serializar los eventos del boton
    Private Sub lbListbox_MouseUp(sender As Object, e As MouseEventArgs) Handles lbListBox.MouseUp
        LimpiarControles(settings)
        SettingsTXTvisibles(False)
        MostrarChk(False)
        settings.ShowDialog()

        setType()
    End Sub
#End Region
#Region "eventos para el Combobox"
    Private Sub cbCombobox_MouseDown(sender As Object, e As MouseEventArgs) Handles cbCombobox.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            MostrarManito()
            Dim _cb As New ComboBox
            agregarHandlersBasicos(_cb)
            _cb.Size = New Size(100, 25)
            _cb.AutoSize = True
            _cb.Name = "cb"
            _cb.Text = "Combobox"
            _instancia = _cb
            Me.Controls.Add(_instancia)
            _instancia.BringToFront()
            ubicacion_mouse = e.Location
        End If
    End Sub

    Private Sub cbCombobox_MouseMove(sender As Object, e As MouseEventArgs) Handles cbCombobox.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            MostrarManito()
            _instancia.Left = e.X + cbCombobox.Left - ubicacion_mouse.X
            _instancia.Top = e.Y + cbCombobox.Top - ubicacion_mouse.Y
        End If
    End Sub

    Private Sub cbCombobox_MouseUp(sender As Object, e As MouseEventArgs) Handles cbCombobox.MouseUp
        LimpiarControles(agregarItems)
        agregarItems.ShowDialog()
        DirectCast(_instancia, ComboBox).Items.AddRange(agregarItems.cbItems.Items.Cast(Of String).ToArray())
        setType()
    End Sub
#End Region
    Private Sub SettingsTXTvisibles(_case As Boolean)
        settings.pnlSettingsTXT.Visible = _case
    End Sub

    Private Sub MostrarChk(_case As Boolean)
        settings.chkSoyPregunta.Visible = _case 'los checkbox siempre van a ser pregunta
    End Sub
    Public Sub setType()
        _instancia.Name = setControlName()
        If TypeOf (_instancia) IsNot TextBox Or TypeOf (_instancia) IsNot ComboBox Then
            _instancia.Text = settings.texto
            _instancia.Font = settings.fuente
            _instancia.ForeColor = settings.color
        End If
        frmPlano.Controls.Add(_instancia)
        Dim marginX As Double = pnlControles.Size.Width + (pnlFormularioPersonalizado.Left - pnlControles.Width) 'Esto es porque hay un pequeño espacio entre el panel de los controles y el panel del personalizado
        Dim marginY As Double = _instancia.Size.Height / 2 'esto es sencillamente pq no se el size que traen por defecto los controles, los estoy instanciando todos con tamaños aleatorios y tienen desfasaje cuando se instancian.

        _instancia.Location -= New Point(marginX, marginY)
    End Sub
    Public Function setControlName() As String
        control_count += 1
        Return _instancia.GetType().ToString().Replace("System.Windows.Forms.", "") & control_count.ToString()
    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Select Case frmPlano.Controls.Count
            Case < 2
                MessageBox.Show("Agregue más controles al formulario personalizado.", "Falta ingresar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Case > 50
                MessageBox.Show("El sistema no soporta más de 50 controles en un formulario, disminuya la cantidad.", "Falta ingresar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
        End Select

        'verificar que todas las preguntas tengan respuesta.
        Dim sinrespuesta = frmPlano.PreguntasYRespuestas.Find(Function(p) p.Respuesta Is Nothing).Pregunta

        If sinrespuesta IsNot Nothing Then
            MessageBox.Show(sinrespuesta.Text, "Falta asignar un campo de respuesta para la pregunta.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        PedirNombre.ShowDialog()
        FormDisenado.Nombre = PedirNombre.Nombre

        For Each i As Control In frmPlano.Controls
            controlesInstanciados.Add(i)
        Next

        Dim fbr As New FabricaDeControles()
        GuardarFormulario(fbr.Serializar(controlesInstanciados))

    End Sub

    Public Sub GuardarFormulario(lista_controles As ControlesGuardados.ListaControles)

        Dim gestor As New GestorXMLv2
        Dim resultado As Integer = 0
        FormDisenado.XML = gestor.Serializar(lista_controles)
        Dim capturaDePantalla = ImprimirFormulario(pnlFormularioPersonalizado, New Rectangle(0, 0, 720, 480))
        FormDisenado.VistaPrevia = Image2Bytes(capturaDePantalla)
        FormDisenado.PreguntasYRespuestas = frmPlano.PreguntasYRespuestas
        If FormDisenado.ID = 0 Then 'si es 0 es porque no lo estamos editando, es un form nuevo
            resultado = negocio.AltaFormulario(FormDisenado)
        Else
            resultado = negocio.ModificarFormulario(FormDisenado) 'hacer alta y baja con las preguntas aca!
        End If
        Select Case resultado
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando procedimiento", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 1
                MessageBox.Show("Formulario guardado con éxito.", "Alta/Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim ev As New EventArgs
                Dim sender As New Object
                btnLimpiar_Click(sender, ev)
                FormDisenado = Nothing
        End Select

    End Sub

    Sub BajaFormulario()
        Dim resultado = negocio.BajaFormulario(FormDisenado)

        Select Case resultado
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando procedimiento", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 1
                MessageBox.Show("Formulario dado de baja con éxito.", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim ev As New EventArgs
                Dim sender As New Object
                btnLimpiar_Click(sender, ev)
        End Select
    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        btnLimpiar_Click(sender, e)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        controlesInstanciados.Clear()
        frmPlano.Controls.Clear()
    End Sub

    Public Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        btnLimpiar_Click(sender, e)
        catalogo.tblFormularios.Controls.Clear()
        catalogo.ShowDialog()

        If catalogo.FormSeleccionado Is Nothing Then
            Console.WriteLine("no fue seleccionado un form")
            Exit Sub
        End If

        FormDisenado = catalogo.FormSeleccionado

        Dim controles = ConvertirFormulario(catalogo.FormSeleccionado)
        If Not controles Is Nothing Then
            For Each c As Control In controles
                If c.Controls.Count > 0 Then
                    For Each c2 As Control In c.Controls
                        c2.Location = New Point(c2.Location.X, c2.Location.Y + 100)
                        agregarHandlersBasicos(c2)
                    Next
                Else
                    agregarHandlersBasicos(c) 'esto es para evitar agregarle handlers a un panel contenedor, solo vamos a agregarlo a c en caso de que c no sea un contenedor de otros controles.
                End If
                frmPlano.Controls.Add(c)
            Next
        End If
        BuscarPreguntas(frmPlano, frmPlano.PreguntasYRespuestas)
        UnirPreguntasConRespuestas(frmPlano, frmPlano.PreguntasYRespuestas)
    End Sub

    Public Sub agregarHandlersBasicos(_ctrl As Control)
        AddHandler _ctrl.MouseDown, AddressOf frmPlano._MouseDown
        AddHandler _ctrl.MouseMove, AddressOf frmPlano._MouseMove
        AddHandler _ctrl.MouseUp, AddressOf frmPlano._MouseUp

        If _ctrl.Controls.Count > 0 Then
            For Each c As Control In _ctrl.Controls
                agregarHandlersBasicos(c)
            Next
        End If
    End Sub

    Private Sub frmCrearFormulario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Dim ev As New EventArgs
            btnSalir_Click(sender, ev)
        End If
    End Sub

    Private Sub MostrarManito()
        System.Windows.Forms.Cursor.Current = _cursor
    End Sub

    Private Sub pBoxBorrar_MouseEnter(sender As Object, e As EventArgs) Handles pBoxBorrar.MouseEnter
        frmPlano.Controls.Remove(frmPlano.ctrl_seleccionado)
    End Sub

    Private Sub pBoxBorrar_Click(sender As Object, e As EventArgs) Handles pBoxBorrar.Click
        If FormDisenado.ID = 0 Then
            Exit Sub
        Else
            Dim eleccion = MessageBox.Show("¿Seguro que desea dar de baja este formulario? Se perderán los datos de las consultas médicas que se hayan realizado con este.", "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If eleccion = vbYes Then
                BajaFormulario()
            Else
                Exit Sub
            End If
        End If
    End Sub
End Class