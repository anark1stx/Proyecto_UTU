Imports FormulariosPersonalizados
Imports Entidades
Imports Negocio
Imports Utilidades
Public Class frmCrearFormulario

    Dim _cursor As Cursor = Cursors.Hand
    Dim frmPlano As New formularioPlano

    Dim ubicacion_mouse As Point

    Dim _instancia As New Control
    Dim controlesInstanciados As New List(Of Control)
    Dim control_count As Integer = 0

    Dim TipoDeTxt As New SeleccionarPreguntaCrr
    Dim settings As New MsgBoxControlSettings
    Dim catalogo As New frmCatalogoFormulariosBD

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
            _txt.Size = New Size(128, 28)
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
            TipoDeTxt.cbPreguntas.DataSource = listaP
            TipoDeTxt.cbPreguntas.DisplayMember = "Text"
            TipoDeTxt.cbPreguntas.ValueMember = "Tag"
            TipoDeTxt.ShowDialog()
            If TipoDeTxt.cbPreguntas.SelectedIndex <> -1 Then
                _instancia.Tag = TipoDeTxt.cbPreguntas.SelectedValue
                frmPlano.PreguntasYRespuestas.Find(Function(p) p.Pregunta.Tag = TipoDeTxt.cbPreguntas.SelectedValue).Respuesta = _instancia
            Else
                MessageBox.Show("Para agregar un campo de respuesta debe asignarle una pregunta", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                _instancia = Nothing
                Exit Sub
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
            frmPlano.SoloLabels.Add(New PreguntaRespuesta(_instancia.Tag, _instancia))
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

        If String.IsNullOrWhiteSpace(settings.texto) Then
            _instancia = Nothing
            Exit Sub
        Else
            setType()
            frmPlano.tagCount += 1
            _instancia.Tag = String.Format("p{0}", frmPlano.tagCount) 'setteo el tag
            frmPlano.PreguntasYRespuestas.Add(New PreguntaRespuesta(_instancia.Tag, _instancia))
        End If
    End Sub
#End Region
#Region "eventos para el Combobox"
    Private Sub cbCombobox_MouseDown(sender As Object, e As MouseEventArgs) Handles cbCombobox.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            MostrarManito()
            Dim _cb As New ComboBox
            agregarHandlersBasicos(_cb)
            _cb.Size = New Size(122, 30)
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
        Dim agregarItems As New frmAgregarItems
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
        Select Case _instancia.GetType()
            Case GetType(Label), GetType(CheckBox)
                _instancia.Text = settings.texto
                _instancia.Font = settings.fuente
                _instancia.ForeColor = settings.color
            Case Else
                _instancia.Font = New Font("Arial", 14, FontStyle.Regular)
                _instancia.ForeColor = Color.Black
        End Select
        frmPlano.pnlContenedor.Controls.Add(_instancia)
        Dim marginX As Double = pnlControles.Size.Width + (pnlFormularioPersonalizado.Left - pnlControles.Width)
        Dim marginY As Double = _instancia.Size.Height / 2

        _instancia.Location -= New Point(marginX, marginY)
    End Sub
    Public Function setControlName() As String
        control_count += 1
        Return _instancia.GetType().ToString().Replace("System.Windows.Forms.", "") & control_count.ToString()
    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Select Case frmPlano.pnlContenedor.Controls.Count
            Case < 3
                MessageBox.Show("Agregue más controles al formulario personalizado. Mínimo aceptado: 8", "Falta ingresar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Case > 50
                MessageBox.Show("El sistema no soporta más de 50 controles en un formulario, disminuya la cantidad.", "Falta ingresar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
        End Select

        'verificar que todas las preguntas tengan respuesta.
        Dim sinrespuesta As New PreguntaRespuesta
        Try
            sinrespuesta = frmPlano.PreguntasYRespuestas.Find(Function(p) p.Respuesta Is Nothing)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        If sinrespuesta IsNot Nothing Then
            MessageBox.Show(sinrespuesta.Pregunta.Text, ": Falta asignar un campo de respuesta para la pregunta.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        PedirNombre.ShowDialog()
        FormDisenado.Nombre = PedirNombre.Nombre
        If FormDisenado.ID > 0 Then
            If MessageBox.Show("¿Desea sobreescribir el formulario original? Si lo hace se pueden perder datos del historial médico de los pacientes. Presione No para guardarlo como un formulario nuevo.", "Modificar existente o guardar como nuevo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
                FormDisenado.ID = 0
            End If
        End If
        For Each i As Control In frmPlano.pnlContenedor.Controls
            controlesInstanciados.Add(i)
        Next
        Dim fbr As New FabricaDeControles
        GuardarFormulario(FormDisenado, fbr.Serializar(controlesInstanciados), frmPlano.pnlContenedor)
        frmPlano.pnlContenedor.Controls.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        btnLimpiar_Click(sender, e)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        controlesInstanciados.Clear()
        frmPlano.pnlContenedor.Controls.Clear()
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
                    agregarHandlersBasicos(c)
                End If
                frmPlano.pnlContenedor.Controls.Add(c)
            Next
        End If
        BuscarPreguntas(frmPlano, frmPlano.PreguntasYRespuestas)
        UnirPreguntasConRespuestas(frmPlano, frmPlano.PreguntasYRespuestas)
        For Each pyr As PreguntaRespuesta In frmPlano.PreguntasYRespuestas
            If pyr.Pregunta.GetType() = GetType(Label) Then
                frmPlano.SoloLabels.Add(pyr)
            End If
        Next
        frmPlano.PreguntasYRespuestas.Sort(Function(p1, p2) p1.Tag.CompareTo(p2.Tag))
        frmPlano.SoloLabels.Sort(Function(p1, p2) p1.Tag.CompareTo(p2.Tag))
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
        frmPlano.pnlContenedor.Controls.Remove(frmPlano.ctrl_seleccionado)
    End Sub

    Private Sub pBoxBorrar_Click(sender As Object, e As EventArgs) Handles pBoxBorrar.Click
        If FormDisenado.ID = 0 Then
            Exit Sub
        Else
            Dim eleccion = MessageBox.Show("¿Seguro que desea dar de baja este formulario? Se perderán los datos de las consultas médicas que se hayan realizado con este.", "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If eleccion = vbYes Then
                BajaFormulario(FormDisenado)
                FormDisenado = Nothing
                frmPlano.pnlContenedor.Controls.Clear()
            Else
                Exit Sub
            End If
        End If
    End Sub
End Class