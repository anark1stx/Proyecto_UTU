Public Class FabricaDeControles
    'Serializar recibe controles de windows forms, y los transforma a Controles de la clase ControlesGuardados.
    Function Serializar(controles As List(Of Control)) As List(Of ControlesGuardados.SControl) 'Guardar como los types que cree en ControlesGuardados
        Dim lista As New List(Of ControlesGuardados.SControl)

        For Each c As Control In controles

            Select Case c.GetType()
                Case GetType(Panel)
                    If c.Controls.Count > 0 Then
                        Dim tmp_list As New List(Of Control)

                        For Each c2 As Control In c.Controls
                            tmp_list.Add(c2)
                        Next

                        lista.Add(New ControlesGuardados.Panel(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), DirectCast(c, Panel).AutoScroll, Serializar(tmp_list))) 'Necesario castearlo como panel para sacar esa propiedad

                    End If
                Case GetType(GroupBox)
                    If c.Controls.Count > 0 Then
                        Dim tmp_list As New List(Of Control)
                        tmp_list.AddRange(c.Controls)
                        lista.Add(New ControlesGuardados.GroupBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, Serializar(tmp_list))) 'Necesario castearlo como panel para sacar esa propiedad

                    End If
                Case GetType(Label)
                    lista.Add(New ControlesGuardados.Label(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text))

                Case GetType(TextBox)
                    lista.Add(New ControlesGuardados.Textbox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text))
                Case GetType(Button)
                    lista.Add(New ControlesGuardados.Button(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.BackgroundImage))
                Case GetType(ListBox)
                    lista.Add(New ControlesGuardados.ListBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), convertirItemsLBOX(DirectCast(c, ListBox).Items)))

            End Select

        Next

        Return lista
    End Function

    Function Crear(controles As List(Of ControlesGuardados.SControl)) As List(Of Control) 'Control de windows forms
        Dim lista As New List(Of Control)

        Return lista
    End Function

    Function convertirItemsLBOX(lista As ListBox.ObjectCollection) As String()
        Dim _lista As String() = {}

        For Each item In lista

            _lista.Append(item.ToString())

        Next

        Return _lista
    End Function

    Function ColorTOHTML(col As Color) As String 'XMLSerializer no puede guardar System.Drawing.Color
        Dim htmlColor As String = ""

        htmlColor = ColorTranslator.ToHtml(col)

        Select Case htmlColor
            Case "buttontext" 'Por alguna razon el color ControlText se guarda como button text (??XD
                Return "ControlText"
            Case Else
                Return htmlColor
        End Select

    End Function



End Class
