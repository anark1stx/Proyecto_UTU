Public Class frmCrearFormulario
    Public tempname As String = ""
    Dim frmPlano As New formularioPlano

    Public ubicacion_mouse As Point
    Dim drop As Point


    Dim instancia As New Control 'Para limpiar instancias en caso que fuera necesario
    Dim _instancia As New Control
    Dim controlesInstanciados As New List(Of Object)
    Dim control_count As Integer = 0
    Dim temp_control_type As String

    Dim txtSintomas_ingresados As Integer = 0 'Esto va a servir para cuando tengamos el DER del predictivo definitivo, solo vamos a tomar x sintomas.
    Dim TipoDeTxt As New MsgBoxTipoDeTextBox
    Dim settings As New MsgBoxControlSettings
    Private Sub frmCrearFormulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmPlano.TopLevel = False
        frmPlano.TopMost = True
        pnlFormularioPersonalizado.Controls.Add(frmPlano)
        frmPlano.Show()
    End Sub
#Region "Eventos para el TextBox"
    Private Sub txtControl_MouseDown(sender As Object, e As MouseEventArgs) Handles txtSintoma0.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Dim _txt As New TextBox
            temp_control_type = "TextBox"
            _txt.Size = New Size(122, 55)
            _txt.Name = "txt"
            _instancia = _txt
            Me.Controls.Add(_instancia)
            _instancia.BringToFront()
            ubicacion_mouse = e.Location
        End If
    End Sub

    Private Sub txtControl_MouseMove(sender As Object, e As MouseEventArgs) Handles txtSintoma0.MouseMove

        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            _instancia.Left = e.X + txtSintoma0.Left - ubicacion_mouse.X
            _instancia.Top = e.Y + txtSintoma0.Top - ubicacion_mouse.Y

        End If
    End Sub

    Public Sub txtSintoma0_MouseUp(sender As Object, e As MouseEventArgs) Handles txtSintoma0.MouseUp
        If _instancia.Location.X > pnlControles.Width Then
            drop = e.Location
            Dim tipo = TipoDeTxt.ShowDialog()

            setType(TipoDeTxt.valorSeleccionado)

        End If

    End Sub
#End Region

#Region "eventos para la Label"
    Private Sub lblLabel_MouseDown(sender As Object, e As MouseEventArgs) Handles lblLabel.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Dim _lbl As New Label
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
            _instancia.Left = e.X + txtSintoma0.Left - ubicacion_mouse.X
            _instancia.Top = e.Y + txtSintoma0.Top - ubicacion_mouse.Y
        End If
    End Sub

    Private Sub lblLabel_MouseUp(sender As Object, e As MouseEventArgs) Handles lblLabel.MouseUp
        drop = e.Location
        settings.ShowDialog()

        setType("lbl")
        'Abrir dialogo para Fuente y texto
    End Sub

#End Region

    Public Sub setType(nombre As String)
        _instancia.Name = nombre
        _instancia.Name = setControlName()
        tempname = _instancia.Name

        _instancia.Text = settings.texto
        _instancia.Font = settings.fuente
        _instancia.ForeColor = settings.color

        frmPlano.Controls.Add(_instancia)

        Dim marginX As Double = pnlControles.Size.Width + (pnlFormularioPersonalizado.Left - pnlControles.Width) 'Esto es porque hay un pequeño espacio entre el panel de los controles y el panel del personalizado
        Dim marginY As Double = _instancia.Size.Height / 2

        _instancia.Location -= New Point(marginX, marginY)
        TipoDeTxt.Hide()
        settings.texto = ""
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

        Dim archivo As New Xml.XmlDocument

        For Each i As Control In frmPlano.Controls
            controlesInstanciados.Add(i)
        Next

        Dim gestor As New GestorXML

        Dim xmlstring As String = gestor.guardarXML(controlesInstanciados)
        archivo.LoadXml(xmlstring)

        Dim guardarFormulario As New SaveFileDialog
        guardarFormulario.Filter = "XML|*.xml"
        guardarFormulario.Title = "Guardar Formulario"
        guardarFormulario.RestoreDirectory = True

        If guardarFormulario.ShowDialog() = DialogResult.OK Then
            Dim path As String = System.IO.Path.GetFullPath(guardarFormulario.FileName.ToString())
            archivo.Save(path)
        End If

    End Sub
End Class