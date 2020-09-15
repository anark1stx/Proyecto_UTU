Imports FormulariosPersonalizados
Imports Entidades
Public Class formularioPlano
    Public ubicacion_mouse As Point
    Public ctrl_seleccionado As Control
    Public PreguntasYRespuestas As New List(Of PreguntaRespuesta)
    Public tagCount = 0
    Dim dragging As Boolean = False
    Dim settings As New MsgBoxControlSettings
    Dim txtBox As New MsgBoxTipoDeTextBox
    Dim resizingRight As Boolean = False
    Dim resizingBottom As Boolean = False
    Public Sub _MouseDown(ByVal sender As System.Object, ByVal e As MouseEventArgs) 'Handles Control.MouseDown

        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            ubicacion_mouse = e.Location
            If TypeOf (sender) Is TextBox And e.Location.X >= sender.Width - 8 Then
                resizingBottom = False
                resizingRight = True
                Console.WriteLine("cerca del borde")
            ElseIf TypeOf (sender) Is TextBox And e.Location.Y >= sender.Height - 8 Then
                resizingRight = False
                resizingBottom = True
            Else
                resizingBottom = False
                resizingRight = False
            End If
        Else
                'Abrir settings para configurar el control
                If TypeOf sender Is TextBox Or TypeOf sender Is ComboBox Then
                Dim tipo = sender.GetType()
                Dim c = DirectCast(sender, Control)
                Dim listaP As New List(Of Control)
                For Each pyr As PreguntaRespuesta In PreguntasYRespuestas
                    listaP.Add(pyr.Pregunta)
                Next
                txtBox.cbTipoDeDato.DataSource = listaP
                txtBox.cbTipoDeDato.DisplayMember = "Text"
                txtBox.cbTipoDeDato.ValueMember = "Tag"
                txtBox.ShowDialog()
                c.Tag = txtBox.cbTipoDeDato.SelectedValue
                PreguntasYRespuestas.Find(Function(p) p.Pregunta.Tag = txtBox.cbTipoDeDato.SelectedValue).Respuesta = c

            Else
                Dim c = DirectCast(sender, Control)
                If PreguntasYRespuestas.Find(Function(p) p.Pregunta Is c) IsNot Nothing Then
                    Console.WriteLine("este control es una pregunta")
                    settings.chkSoyPregunta.Checked = True
                    settings.txtIngreseTexto.Text = c.Text
                    settings.ShowDialog()
                    c.Font = settings.fuente
                    c.Text = settings.texto
                    If Not settings.chkSoyPregunta.Checked Then
                        Console.WriteLine("ya no soy pregunta")
                        PreguntasYRespuestas.Remove(PreguntasYRespuestas.Find(Function(p) p.Tag = c.Tag))
                        c.Tag = ""
                    End If
                Else
                    Console.WriteLine("este control no es una pregunta")
                    settings.chkSoyPregunta.Checked = False
                    settings.txtIngreseTexto.Text = c.Text
                    settings.ShowDialog()
                    c.Font = settings.fuente
                    c.Text = settings.texto
                    If settings.chkSoyPregunta.Checked Then
                        tagCount += 1
                        c.Tag = String.Format("p{0}", tagCount) 'setteo el tag
                        PreguntasYRespuestas.Add(New PreguntaRespuesta(c.Tag, c))
                    End If
                End If

            End If

        End If

    End Sub

    Public Sub _MouseMove(ByVal sender As System.Object, ByVal e As MouseEventArgs) 'Handles Control.Move
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            ctrl_seleccionado = sender
            If resizingBottom Then
                sender.Height = (sender.Top + e.Y) / 1.1
            ElseIf resizingRight Then
                sender.Width = (sender.Left + e.X) / 1.1
            ElseIf Not resizingRight AndAlso Not resizingBottom Then
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