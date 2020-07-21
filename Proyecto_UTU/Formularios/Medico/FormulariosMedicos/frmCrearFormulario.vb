Public Class frmCrearFormulario
    Public tempname As String = ""
    Dim frmPlano As New formularioPlano

    Dim ubicacion_mouse As Point

    Dim instancia As New Control 'Para guardar instancias temporales
    Dim _instancia As New Control 'Para limpiar la variable de arriba
    Dim controlesInstanciados As New List(Of Object)
    Dim control_count As Integer = 0
    Dim temp_control_type As String

    Dim txtSintomas_ingresados As Integer = 0
    Dim TipoDeTxt As New MsgBoxTipoDeTextBox

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
            _lbl.Size = New Size(122, 55)
            _lbl.Name = "lbl"
            _lbl.Text = "Texto"
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

            If _instancia.Location.X > pnlControles.Width Then
                frmPlano.Controls.Add(_instancia)
            End If

        End If
    End Sub

    Private Sub lblLabel_MouseUp(sender As Object, e As MouseEventArgs) Handles lblLabel.MouseUp
        setType("lbl")
    End Sub

#End Region

    Public Sub setType(nombre As String)
        _instancia.Name = nombre
        _instancia.Name = setControlName()
        tempname = _instancia.Name
        instancia = _instancia
        frmPlano.Controls.Add(_instancia)
        TipoDeTxt.Hide()
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

            Case "Grado de Nutrición"
                Return "txtGradoNutr"

            Case "Grado de Hidratación"
                Return "txtGradoHidr"

            Case Else
                control_count += 1
                Return temp_control_type & control_count.ToString()
        End Select

    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim archivo As New Xml.XmlDocument

        'Dim _xml As String = String.Format("<?xml version='1.0' encoding='utf-8'?><button><x>{0}</x><y>{1}</y><name>{2}</name></button>", x, y, Name)

        For Each i As Control In frmPlano.Controls
            controlesInstanciados.Add(i)
            Console.WriteLine(i.Name)
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