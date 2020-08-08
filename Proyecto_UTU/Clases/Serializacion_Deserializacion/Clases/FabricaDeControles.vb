Public Class FabricaDeControles
    'Serializar recibe controles de windows forms, y los transforma a Controles de la clase ControlesGuardados.
    Function Serializar(controles As List(Of Control)) As ControlesGuardados.ListaControles 'Guardar como los types que cree en ControlesGuardados

        Dim _lista As New List(Of ControlesGuardados.SControl)
        For Each c As Control In controles

            Select Case c.GetType()
                Case GetType(Panel)
                    If c.Controls.Count > 0 Then
                        Dim tmp_list As New List(Of Control)

                        For Each c2 As Control In c.Controls
                            tmp_list.Add(c2)
                        Next

                        Dim childs = getChilds(tmp_list)
                        Console.WriteLine(childs.Count)
                        Dim pnl As New ControlesGuardados.Panel(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), DirectCast(c, Panel).AutoScroll, childs)
                        _lista.Add(pnl) 'Necesario castearlo como panel para sacar esa propiedad

                    End If
                Case GetType(GroupBox)
                    If c.Controls.Count > 0 Then
                        Dim tmp_list As New List(Of Control)
                        tmp_list.AddRange(c.Controls)
                        _lista.Add(New ControlesGuardados.GroupBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, getChilds(tmp_list))) 'Necesario castearlo como panel para sacar esa propiedad

                    End If
                Case GetType(Label)
                    _lista.Add(New ControlesGuardados.Label(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text))

                Case GetType(TextBox)
                    _lista.Add(New ControlesGuardados.Textbox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text))
                Case GetType(Button)
                    _lista.Add(New ControlesGuardados.Button(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.BackgroundImage))
                Case GetType(ListBox)
                    _lista.Add(New ControlesGuardados.ListBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), convertirItemsLBOX(DirectCast(c, ListBox).Items)))

            End Select

        Next
        Dim lista As New ControlesGuardados.ListaControles(_lista)
        Return lista
    End Function

    Function getChilds(controles As List(Of Control)) As List(Of ControlesGuardados.SControl)
        Dim lista As New List(Of ControlesGuardados.SControl)
        For Each c As Control In controles

            Select Case c.GetType()
                Case GetType(Panel)
                    If c.Controls.Count > 0 Then
                        Dim tmp_list As New List(Of Control)

                        For Each c2 As Control In c.Controls
                            tmp_list.Add(c2)
                        Next

                        lista.Add(New ControlesGuardados.Panel(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), DirectCast(c, Panel).AutoScroll, getChilds(tmp_list))) 'Necesario castearlo como panel para sacar esa propiedad

                    End If
                Case GetType(GroupBox)
                    If c.Controls.Count > 0 Then
                        Dim tmp_list As New List(Of Control)
                        tmp_list.AddRange(c.Controls)
                        lista.Add(New ControlesGuardados.GroupBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, getChilds(tmp_list))) 'Necesario castearlo como panel para sacar esa propiedad

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



    Function Crear(controles As ControlesGuardados.ListaControles) As List(Of Control) 'Control de windows forms
        Dim lista As New List(Of Control)

        For Each c As ControlesGuardados.SControl In controles.Controles

            lista.Add(ConstruirControl(c))

        Next

        Return lista
    End Function

    Function ConstruirControl(Control As ControlesGuardados.SControl) As Control

        Select Case Control.GetType()
            Case GetType(ControlesGuardados.Panel)
                Return buildPanel(Control)
            Case GetType(ControlesGuardados.Button)
                Return buildButton(Control)
            Case GetType(ControlesGuardados.Textbox)
                Return buildTextBox(Control)
            Case GetType(ControlesGuardados.Label)
                Return buildLabel(Control)
            Case Else
                Console.WriteLine(Control.GetType().ToString())
        End Select

    End Function

    Function buildPanel(control As ControlesGuardados.Panel) As Panel
        Return New Panel With {
            .Name = control.Nombre,
            .Location = control.Posicion,
            .Size = control.Tamano,
            .Dock = control.Dock,
            .Anchor = control.Anchor,
            .BackColor = HTMLTOColor(control.BackColor),
            .ForeColor = HTMLTOColor(control.ForeColor)
        }
    End Function

    Function buildButton(control As ControlesGuardados.Button) As Button
        Return New Button With {
            .Name = control.Nombre,
            .Location = control.Posicion,
            .Size = control.Tamano,
            .Dock = control.Dock,
            .Anchor = control.Anchor,
            .BackColor = HTMLTOColor(control.BackColor),
            .ForeColor = HTMLTOColor(control.ForeColor),
            .BackgroundImage = control.B64strToBmp()
        }
    End Function
    Function buildTextBox(control As ControlesGuardados.Textbox) As TextBox
        Return New TextBox With {
            .Name = control.Nombre,
            .Location = control.Posicion,
            .Size = control.Tamano,
            .Dock = control.Dock,
            .Anchor = control.Anchor,
            .ForeColor = HTMLTOColor(control.ForeColor),
            .Text = control.text
        }
    End Function

    Function buildLabel(control As ControlesGuardados.Label) As Label
        Return New Label With {
            .Name = control.Nombre,
            .Location = control.Posicion,
            .Size = control.Tamano,
            .Dock = control.Dock,
            .Anchor = control.Anchor,
            .ForeColor = HTMLTOColor(control.ForeColor),
            .Text = control.text
        }
    End Function
    Function convertirItemsLBOX(lista As ListBox.ObjectCollection) As String()
        Dim _lista As String() = {}

        For Each item In lista

            _lista.Append(item.ToString())

        Next

        Return _lista
    End Function

    Function ColorTOHTML(col As Color) As String 'XMLSerializer no puede guardar System.Drawing.Color

        Dim htmlColor As String = ColorTranslator.ToHtml(col)

        Select Case htmlColor
            Case "buttontext" 'Por alguna razon el color ControlText se guarda como buttontext (??XD
                Return "ControlText"
            Case Else
                Return htmlColor
        End Select

    End Function

    Function HTMLTOColor(col As String) As Color
        Return ColorTranslator.FromHtml(col)
    End Function


End Class
