Imports FormulariosPersonalizados
Imports Entidades
Public Class formularioPlano
    Public ubicacion_mouse As Point
    Public ctrl_seleccionado As Control
    Public PreguntasYRespuestas As New List(Of PreguntaRespuesta)
    Dim dragging As Boolean = False
    Dim settings As New MsgBoxControlSettings
    Dim txtBox As New MsgBoxTipoDeTextBox
    Public Sub _MouseDown(ByVal sender As System.Object, ByVal e As MouseEventArgs) 'Handles Control.MouseDown

        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            ubicacion_mouse = e.Location

            For Each p As PreguntaRespuesta In PreguntasYRespuestas

                If Not p.Respuesta Is Nothing Then
                    Console.WriteLine("pregunta: " & p.Pregunta.Text & " respuesta: " & p.Respuesta.Text)
                Else
                    Console.WriteLine("pregunta: " & p.Pregunta.Text & " sin respuesta")
                End If

            Next

        Else
            'Abrir settings para configurar el control
            If TypeOf sender Is TextBox Or TypeOf sender Is ComboBox Or TypeOf sender Is CheckBox Then
                txtBox.ShowDialog()
                Dim tipo = sender.GetType()
                Dim c = DirectCast(sender, Control)

                For Each p As PreguntaRespuesta In PreguntasYRespuestas
                    If p.Pregunta.Text = txtBox.valorSeleccionado Then
                        p.Respuesta = c
                    End If
                Next

            Else
                Dim c = DirectCast(sender, Control)
                settings.txtIngreseTexto.Text = c.Text
                settings.ShowDialog()
                c.Font = settings.fuente
                c.Text = settings.texto

            End If

        End If

    End Sub

    Public Sub _MouseMove(ByVal sender As System.Object, ByVal e As MouseEventArgs) 'Handles Control.Move
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            ctrl_seleccionado = sender
            sender.Left = e.X + sender.Left - ubicacion_mouse.X
            sender.Top = e.Y + sender.Top - ubicacion_mouse.Y
            dragging = True
            evaluarSiEstoyenPanel(ctrl_seleccionado)
            If dragging Then
                If sender.Left < Me.Left Then
                    Dim contenedor = DirectCast(sender, Control).Parent
                    contenedor.Controls.Remove(ctrl_seleccionado)
                    ctrl_seleccionado = Nothing
                End If
            End If
        Else
            dragging = False
            ctrl_seleccionado = Nothing
        End If
    End Sub

    Public Sub _MouseUp(ByVal sender As System.Object, ByVal e As MouseEventArgs)
        dragging = False
        ctrl_seleccionado = Nothing
    End Sub

    Public Sub evaluarSiEstoyenPanel(ctrl As Control)

        If TypeOf ctrl.Parent Is TableLayoutPanel Or TypeOf ctrl.Parent Is GroupBox Or TypeOf ctrl.Parent Is Panel AndAlso ctrl.Parent IsNot Me.Controls(0) Then

            If dragging Then

                ctrl.Parent.Controls.Remove(ctrl)
                ctrl.Dock = DockStyle.None
                ctrl.Anchor = AnchorStyles.None

                If TypeOf Me.Controls(0) Is Panel Then
                    ctrl.Parent = Me.Controls(0)
                Else
                    ctrl.Parent = Me
                End If

            End If

        End If

    End Sub
End Class