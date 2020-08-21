Public Class frmCrearFormulario

    Dim _cursor As Cursor = Cursors.Hand
    Dim frmPlano As New formularioPlano

    Public ubicacion_mouse As Point

    Dim _instancia As New Control
    Dim controlesInstanciados As New List(Of Control)
    Dim control_count As Integer = 0
    Dim temp_control_type As String

    Dim txtSintomas_ingresados As Integer = 0 'Esto va a servir para cuando tengamos el DER del predictivo definitivo, solo vamos a tomar x sintomas.
    Dim TipoDeTxt As New MsgBoxTipoDeTextBox
    Dim settings As New MsgBoxControlSettings
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
            temp_control_type = "TextBox"
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
            TipoDeTxt.cbTipoDeDato.Items.Clear()
            For Each p As PreguntaRespuesta In frmPlano.PreguntasYRespuestas
                TipoDeTxt.cbTipoDeDato.Items.Add(p.Pregunta.Text)
            Next

            TipoDeTxt.cbTipoDeDato.Items.Add("Otro")

            TipoDeTxt.ShowDialog()

            setType(TipoDeTxt.valorSeleccionado)

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
            temp_control_type = "Label"
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
        settings.ShowDialog()
        setType("lbl")
        'Abrir dialogo para Fuente y texto
    End Sub

#End Region

#Region "eventos para el CheckBox"
    Private Sub chkBox_MouseDown(sender As Object, e As MouseEventArgs) Handles chkBox.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            MostrarManito()
            Dim _chk As New CheckBox
            agregarHandlersBasicos(_chk)
            temp_control_type = "CheckBox"
            _chk.Size = New Size(50, 25)
            _chk.Name = "lbl"
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
        settings.ShowDialog()
        setType("chk")
        'Abrir dialogo para Fuente y texto
    End Sub
#End Region

    Public Sub setType(nombre As String)

        _instancia.Name = nombre
        _instancia.Name = setControlName()

        _instancia.Text = settings.texto
        _instancia.Font = settings.fuente
        _instancia.ForeColor = settings.color

        If settings.chkSoyPregunta.Checked Then
            Dim pyr As New PreguntaRespuesta()
            pyr.Pregunta = _instancia
            _instancia.Tag = _instancia.Text
            frmPlano.PreguntasYRespuestas.Add(pyr)
        End If

        If TipoDeTxt.valorSeleccionado IsNot "Otro" Then

            For Each pyr As PreguntaRespuesta In frmPlano.PreguntasYRespuestas

                If pyr.Pregunta.Text = TipoDeTxt.valorSeleccionado Then
                    pyr.Respuesta = _instancia
                    _instancia.Tag = pyr.Pregunta.Text
                End If
            Next
        End If

        frmPlano.Controls.Add(_instancia)
        frmPlano.ctrl_seleccionado = _instancia
        Dim marginX As Double = pnlControles.Size.Width + (pnlFormularioPersonalizado.Left - pnlControles.Width) 'Esto es porque hay un pequeño espacio entre el panel de los controles y el panel del personalizado
        Dim marginY As Double = _instancia.Size.Height / 2 'esto es sencillamente pq no se el size que traen por defecto los controles, los estoy instanciando todos con tamaños aleatorios y tienen desfasaje cuando se instancian.

        _instancia.Location -= New Point(marginX, marginY)
        settings.texto = "" 'Limpiar las settings
        settings.fuente = SystemFonts.DefaultFont
        settings.color = New Color

    End Sub

    Public Function setControlName() As String

        Select Case _instancia.Name
            Case "Síntoma"
                txtSintomas_ingresados += 1
                Return "txtSintoma" & txtSintomas_ingresados.ToString()

            Case "frecuencia_cardiaca"
                Return "txtFrecCard"

            Case "frecuencia_respiratoria"
                Return "txtFrecResp"

            Case "Temperatura"
                Return "txtTemperatura"

            Case "Pulso"
                Return "txtPulso"

            Case "grado_nutricion"
                Return "txtGradoNutr"

            Case "grado_hidratacion"
                Return "txtGradoHidr"

            Case Else
                control_count += 1
                Return temp_control_type & control_count.ToString()
        End Select

    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If frmPlano.Controls.Count < 5 Then
            MsgBox("Agregue más controles al formulario personalizado.")
            Exit Sub
        End If
        Dim listaControles As New ControlesGuardados.ListaControles()
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