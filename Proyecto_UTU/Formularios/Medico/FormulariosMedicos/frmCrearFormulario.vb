Public Class frmCrearFormulario
    Dim ubicacion_mouse As Point

    Dim instancia As New Control 'Para guardar instancias temporales
    Dim _instancia As New Control 'Para limpiar la variable de arriba
    Dim controlesInstanciados As New List(Of Control)
    Dim control_count As Integer = 0
    Dim temp_control_type As String


    Dim txtSintomas_ingresados As Integer = 0

    Dim TipoDeTxt As New MsgBoxTipoDeTextBox
    Private Sub frmCrearFormulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

            If _instancia.Location.X > pnlControles.Width Then
                pnlFormularioPersonalizado.Controls.Add(_instancia)
            End If

        End If
    End Sub

    Public Sub txtSintoma0_MouseUp(sender As Object, e As MouseEventArgs) Handles txtSintoma0.MouseUp

        TipoDeTxt.Show()

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
                pnlFormularioPersonalizado.Controls.Add(_instancia)
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

        Console.WriteLine(_instancia.Name)
        controlesInstanciados.Add(_instancia)
        _instancia = instancia
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


End Class