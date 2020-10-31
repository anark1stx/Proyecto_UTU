Imports FormulariosPersonalizados
Imports Entidades
Public Class formularioPlano
    Property _ubicacion_mouse As Point
    Property ubicacion_mouse As Point
        Get
            Return _ubicacion_mouse
        End Get
        Set(value As Point)
            _ubicacion_mouse = value
        End Set
    End Property
    Protected _ctrl_seleccionado As Control
    Property ctrl_seleccionado As Control
        Get
            Return _ctrl_seleccionado
        End Get
        Set(value As Control)
            _ctrl_seleccionado = value
        End Set
    End Property
    Protected _preguntasyrespuestas As New List(Of PreguntaRespuesta)
    Protected _soloLabels As New List(Of PreguntaRespuesta)
    Property PreguntasYRespuestas As List(Of PreguntaRespuesta)
        Get
            Return _preguntasyrespuestas
        End Get
        Set(value As List(Of PreguntaRespuesta))
            _preguntasyrespuestas = value
        End Set
    End Property
    Property SoloLabels As List(Of PreguntaRespuesta)
        Get
            Return _soloLabels
        End Get
        Set(value As List(Of PreguntaRespuesta))
            _soloLabels = value
        End Set
    End Property

    Protected _tagCount As Integer = 0
    Property tagCount As Integer
        Get
            Return _tagCount
        End Get
        Set(value As Integer)
            _tagCount = value
        End Set
    End Property
    Dim dragging As Boolean = False
    Dim settings As New MsgBoxControlSettings
    Dim txtBox As New SeleccionarPreguntaCrr
    Dim resizingRight As Boolean = False
    Dim resizingBottom As Boolean = False
    Public Sub _MouseDown(ByVal sender As System.Object, ByVal e As MouseEventArgs) 'Handles Control.MouseDown

        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            ubicacion_mouse = e.Location
            If (TypeOf (sender) Is TextBox) And e.Location.X >= sender.Width - 8 Then
                resizingBottom = False
                resizingRight = True
            ElseIf (TypeOf (sender) Is TextBox) And e.Location.Y >= sender.Height - 8 Then
                resizingRight = False
                resizingBottom = True
            Else
                resizingBottom = False
                resizingRight = False
            End If
        Else
            Select Case sender.GetType()
                Case GetType(CheckBox)
                    settings.pnlSettingsTXT.Visible = False
                    settings.chkSoyPregunta.Checked = True
                    settings.chkSoyPregunta.Visible = False
                    settings.txtIngreseTexto.Text = DirectCast(sender, CheckBox).Text
                    settings.ShowDialog()
                    If String.IsNullOrWhiteSpace(settings.texto) Then
                        PreguntasYRespuestas.Remove(PreguntasYRespuestas.Find(Function(p) p.Tag = DirectCast(sender, Control).Tag))
                        sender = Nothing
                        Exit Sub
                    Else
                        DirectCast(sender, CheckBox).Text = settings.texto
                        DirectCast(sender, CheckBox).Font = settings.fuente
                        DirectCast(sender, CheckBox).ForeColor = settings.color
                    End If
                Case GetType(TextBox), GetType(ComboBox)
                    Dim tipo = sender.GetType()
                    Dim c = DirectCast(sender, Control)
                    Dim tmpList As New List(Of Control)
                    For Each pyr As PreguntaRespuesta In SoloLabels
                        tmpList.Add(pyr.Pregunta)
                    Next
                    txtBox.cbPreguntas.DataSource = tmpList
                    txtBox.cbPreguntas.DisplayMember = "Text"
                    txtBox.cbPreguntas.ValueMember = "Tag"
                    If Not String.IsNullOrEmpty(c.Tag) Then
                        txtBox.cbPreguntas.SelectedValue = c.Tag
                    End If
                    txtBox.ShowDialog()
                    c.Tag = txtBox.cbPreguntas.SelectedValue
                    If c.Tag Is String.Empty Then
                        Exit Sub
                    Else
                        PreguntasYRespuestas.Find(Function(p) p.Pregunta.Tag = txtBox.cbPreguntas.SelectedValue).Respuesta = c
                    End If
                    Select Case c.GetType()
                        Case GetType(ComboBox)
                            Dim agregarItems As New frmAgregarItems
                            agregarItems.cbItems.Items.AddRange(DirectCast(c, ComboBox).Items.Cast(Of String).ToArray())
                            agregarItems.ShowDialog()
                            DirectCast(c, ComboBox).Items.Clear()
                            DirectCast(c, ComboBox).Items.AddRange(agregarItems.cbItems.Items.Cast(Of String).ToArray())
                    End Select
                Case Else
                    settings.pnlSettingsTXT.Visible = True
                    settings.chkSoyPregunta.Checked = False
                    settings.chkSoyPregunta.Visible = True
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
                        If String.IsNullOrWhiteSpace(settings.Text) Then
                            c = Nothing
                            Exit Sub
                        End If
                        c.Font = settings.fuente
                        c.Text = settings.texto
                        If settings.chkSoyPregunta.Checked Then
                            tagCount += 1
                            c.Tag = String.Format("p{0}", tagCount) 'setteo el tag
                            PreguntasYRespuestas.Add(New PreguntaRespuesta(c.Tag, c))
                        End If
                    End If
            End Select
        End If
    End Sub

    Public Sub _MouseMove(ByVal sender As System.Object, ByVal e As MouseEventArgs) 'Handles Control.Move
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            ctrl_seleccionado = sender
            If resizingBottom Then
                sender.Height += (e.Y - sender.Height)
            ElseIf resizingRight Then
                sender.Width += (e.X - sender.Width)
            ElseIf Not resizingRight AndAlso Not resizingBottom Then
                sender.Left = e.X + sender.Left - ubicacion_mouse.X
                sender.Top = e.Y + sender.Top - ubicacion_mouse.Y
                dragging = True
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
End Class