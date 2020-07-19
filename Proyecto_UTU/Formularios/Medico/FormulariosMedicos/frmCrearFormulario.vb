Public Class frmCrearFormulario
    Dim ubicacion_mouse As Point
    Dim instancia As New Control 'Para guardar instancias temporales
    Dim _instancia As New Control 'Para limpiar la variable de arriba
    Dim controlesInstanciados As New List(Of Control)
    Dim txtSintomas_ingresados As Integer = 0
    Dim control_count As Integer = 0
    Dim temp_control_type As String
    Private Sub frmCrearFormulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtControl_MouseDown(sender As Object, e As MouseEventArgs) Handles txtSintoma0.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Dim _txt As New TextBox
            temp_control_type = "textBox"
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

    Private Sub txtSintoma0_MouseUp(sender As Object, e As MouseEventArgs) Handles txtSintoma0.MouseUp

        Dim esSintoma As String = MsgBox("¿Este campo va a almacenar un síntoma?", vbYesNo + vbQuestion)
        If esSintoma = vbYes Then
            _instancia.Name = "txtSintoma"
            _instancia.Name = setControlName()
        Else
            _instancia.Name = setControlName()
        End If

        Console.WriteLine(_instancia.Name)
        controlesInstanciados.Add(_instancia)
        _instancia = instancia
    End Sub

    Public Function setControlName() As String
        If _instancia.Name = "txtSintoma" Then
            txtSintomas_ingresados += 1
            Return "txtSintoma" & txtSintomas_ingresados.ToString()
        Else
            control_count += 1
            Return temp_control_type & control_count.ToString()
        End If
    End Function


End Class