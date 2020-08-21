Public Class formularioPlano
    Public ubicacion_mouse As Point
    Public ctrl_seleccionado As Control
    Public PreguntasYRespuestas As New List(Of PreguntaRespuesta)
    Public Sub _MouseDown(ByVal sender As System.Object, ByVal e As MouseEventArgs) 'Handles Control.MouseDown

        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            ubicacion_mouse = e.Location
        End If

    End Sub

    Public Sub _MouseMove(ByVal sender As System.Object, ByVal e As MouseEventArgs) 'Handles Control.Move
        If e.Button = System.Windows.Forms.MouseButtons.Left Then

            ctrl_seleccionado = sender
            sender.Left = e.X + sender.Left - ubicacion_mouse.X
            sender.Top = e.Y + sender.Top - ubicacion_mouse.Y
            evaluarSiEstoyenPanel(ctrl_seleccionado)
        End If
    End Sub

    Public Sub _MouseUp(ByVal sender As System.Object, ByVal e As MouseEventArgs)
        ctrl_seleccionado = DirectCast(sender, Control)
        If sender.Left < Me.Left Then
            Dim contenedor = DirectCast(sender, Control).Parent
            contenedor.Controls.Remove(DirectCast(sender, Control))
        End If

    End Sub

    Public Sub evaluarSiEstoyenPanel(ctrl As Control)

        If TypeOf ctrl.Parent Is TableLayoutPanel Or TypeOf ctrl.Parent Is Panel AndAlso ctrl.Parent IsNot Me.Controls(0) Then

            ctrl.Parent.Invalidate()

            ctrl.Dock = DockStyle.None
            ctrl.Anchor = AnchorStyles.None

            If ctrl.Parent.Parent IsNot Nothing Then
                ctrl.Parent = ctrl.Parent.Parent
            End If

        End If

    End Sub
End Class