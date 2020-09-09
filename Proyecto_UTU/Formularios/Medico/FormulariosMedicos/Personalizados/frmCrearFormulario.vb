Imports FormulariosPersonalizados
Imports Entidades
Imports Utilidades
Public Class frmCrearFormulario

    Dim _cursor As Cursor = Cursors.Hand
    Dim frmPlano As New formularioPlano

    Dim ubicacion_mouse As Point

    Dim _instancia As New Control
    Dim controlesInstanciados As New List(Of Control)
    Dim control_count As Integer = 0

    Dim TipoDeTxt As New MsgBoxTipoDeTextBox
    Dim settings As New MsgBoxControlSettings

    Dim PedirNombre As New frmPedirNombreForm
    Protected _nombreForm As String

    Property NombreForm As String
        Get
            Return _nombreForm
        End Get
        Set(value As String)
            _nombreForm = value
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

            If frmPlano.PreguntasYRespuestas.Count > 0 Then
                TipoDeTxt.cbTipoDeDato.Items.Clear()
                For Each p As PreguntaRespuesta In frmPlano.PreguntasYRespuestas
                    TipoDeTxt.cbTipoDeDato.Items.Add(p.Pregunta.Text)
                Next
            Else
                setType()
                Exit Sub
            End If

            SettingsTXTvisibles(True)
            TipoDeTxt.ShowDialog()

            If TipoDeTxt.cbTipoDeDato.SelectedIndex <> -1 Then

                For Each p In frmPlano.PreguntasYRespuestas
                    Console.WriteLine("pregunta: " & p.Pregunta.Text & " valorS: " & TipoDeTxt.cbTipoDeDato.SelectedItem)
                    If p.Pregunta.Text = TipoDeTxt.valorSeleccionado Then
                        Console.WriteLine("iguales!!")
                        p.Respuesta = _instancia
                    End If
                Next

            End If
            DirectCast(_instancia, TextBox).Multiline = True
            setType()

            TipoDeTxt.Hide()
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
        settings.ShowDialog()
        setType()
        If settings.chkSoyPregunta.Checked Then
            Dim pyr As New PreguntaRespuesta()
            pyr.Pregunta = _instancia
            frmPlano.PreguntasYRespuestas.Add(pyr)
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
        settings.ShowDialog()
        _instancia.Text = TipoDeTxt.valorSeleccionado
        If settings.chkSoyPregunta.Checked Then
            Dim pyr As New PreguntaRespuesta With {
                .Pregunta = _instancia, 'El paciente .....
                .Respuesta = _instancia 'Si/No checked/unchecked
                }
            frmPlano.PreguntasYRespuestas.Add(pyr)
        End If
        setType()
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
        settings.ShowDialog()

        setType()
    End Sub
#End Region
#Region "eventos para el combobox"
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

    'PENDIENTE: Serializar los eventos del boton
    Private Sub cbCombobox_MouseUp(sender As Object, e As MouseEventArgs) Handles cbCombobox.MouseUp
        LimpiarControles(settings)
        SettingsTXTvisibles(False)
        settings.ShowDialog()

        setType()
    End Sub
#End Region
    Private Sub SettingsTXTvisibles(_case As Boolean)
        settings.pnlSettingsTXT.Visible = _case
    End Sub
    Public Sub setType()
        _instancia.Name = setControlName()

        _instancia.Text = settings.texto
        _instancia.Font = settings.fuente
        _instancia.ForeColor = settings.color
        frmPlano.Controls.Add(_instancia)
        Dim marginX As Double = pnlControles.Size.Width + (pnlFormularioPersonalizado.Left - pnlControles.Width) 'Esto es porque hay un pequeño espacio entre el panel de los controles y el panel del personalizado
        Dim marginY As Double = _instancia.Size.Height / 2 'esto es sencillamente pq no se el size que traen por defecto los controles, los estoy instanciando todos con tamaños aleatorios y tienen desfasaje cuando se instancian.

        _instancia.Location -= New Point(marginX, marginY)
    End Sub

    Public Function setControlName() As String
        control_count += 1
        Return _instancia.GetType().ToString() & control_count.ToString()
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Select Case frmPlano.Controls.Count
            Case < 10
                MsgBox("Agregue más controles al formulario personalizado.")
                Exit Sub
            Case > 50
                MsgBox("El sistema no soporta más de 50 controles en un formulario, disminuya la cantidad.")
                Exit Sub
        End Select

        PedirNombre.ShowDialog()
        NombreForm = PedirNombre.Nombre

        For Each i As Control In frmPlano.Controls
            controlesInstanciados.Add(i)
        Next

        Dim fbr As New FabricaDeControles()
        GuardarFormulario(fbr.Serializar(controlesInstanciados))

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        Me.frmPlano.Controls.Clear()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        frmPlano.Controls.Clear()
    End Sub

    Public Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        Dim controles = ImportarFormulario()
        If Not controles Is Nothing Then
            For Each c As Control In controles
                If c.Controls.Count > 0 Then
                    For Each c2 As Control In c.Controls
                        c2.Location = New Point(c2.Location.X, c2.Location.Y + 100)
                        agregarHandlersBasicos(c2)
                    Next
                Else
                    agregarHandlersBasicos(c) 'Esto es para evitar agregarle handlers a un panel contenedor, solo vamos a agregarlo a c en caso de que c no sea un contenedor de otros controles.
                End If
                frmPlano.Controls.Add(c)
            Next
        End If

    End Sub
    Public Sub agregarHandlersBasicos(_ctrl As Control)
        AddHandler _ctrl.MouseDown, AddressOf frmPlano._MouseDown
        AddHandler _ctrl.MouseMove, AddressOf frmPlano._MouseMove
        AddHandler _ctrl.MouseUp, AddressOf frmPlano._MouseUp
        'If _ctrl.Tag IsNot String.Empty Then
        '    frmPlano.PreguntasYRespuestas.Add(New PreguntaRespuesta())
        'End If

        If _ctrl.Controls.Count > 0 Then
            For Each c As Control In _ctrl.Controls
                agregarHandlersBasicos(c)
            Next
        End If
    End Sub

    Private Sub frmCrearFormulario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            frmPlano.Controls.Clear()
            Me.Hide()
        End If
    End Sub

    Private Sub MostrarManito()
        System.Windows.Forms.Cursor.Current = _cursor
    End Sub

    Private Sub pBoxBorrar_MouseEnter(sender As Object, e As EventArgs) Handles pBoxBorrar.MouseEnter
        frmPlano.Controls.Remove(frmPlano.ctrl_seleccionado)
    End Sub

End Class