Public Class formularioPlano
    Public ubicacion_mouse As Point
    Public ctrl_seleccionado As Control
    Public lista_Tags As New List(Of String)
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
            'evaluarSiEstoyenTBL(ctrl_seleccionado)
        End If
    End Sub

    Public Sub _MouseUp(ByVal sender As System.Object, ByVal e As MouseEventArgs)
        ctrl_seleccionado = DirectCast(sender, Control)
        If sender.Left < Me.Left Then
            Dim contenedor = DirectCast(sender, Control).Parent
            contenedor.Controls.Remove(DirectCast(sender, Control))
        End If

    End Sub

    'Public Sub evaluarSiEstoyenTBL(ctrl As Control)

    '    If Not ctrl.Parent Is Me Or Not ctrl.Parent Is Me.Controls(0) Then '
    '        Dim contenedor = ctrl.Parent.Parent
    '        ctrl.Dock = DockStyle.None
    '        ctrl.Anchor = AnchorStyles.None
    '        contenedor.Controls.Add(ctrl)
    '        evaluarSiEstoyenTBL(ctrl)
    '    End If

    'End Sub



End Class