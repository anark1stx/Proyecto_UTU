Public Class formularioPlano
    Public ubicacion_mouse As Point
    Public ctrl_seleccionado As Control
    Public dragging As Boolean = False

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
        End If

    End Sub

    Public Sub _MouseUp(ByVal sender As System.Object, ByVal e As MouseEventArgs)
        If sender.Left < Me.Left Then

            Dim contenedor = DirectCast(sender, Control).Parent
            contenedor.Controls.Remove(DirectCast(sender, Control))
        Else
            ctrl_seleccionado = Nothing
        End If

    End Sub

End Class