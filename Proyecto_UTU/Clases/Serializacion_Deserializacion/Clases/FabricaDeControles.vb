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
                        Dim pnl As New ControlesGuardados.Panel(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), DirectCast(c, Panel).AutoScroll, childs) 'Necesario castearlo como panel para sacar esa propiedad
                        Console.WriteLine(c.Location)
                        _lista.Add(pnl)

                    End If
                Case GetType(GroupBox)
                    If c.Controls.Count > 0 Then
                        Dim tmp_list As New List(Of Control)

                        For Each c2 As Control In c.Controls
                            tmp_list.Add(c2)
                        Next

                        Dim childs = getChilds(tmp_list)
                        Dim gb As New ControlesGuardados.GroupBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, childs, c.Font) 'Necesario castearlo como panel para sacar esa propiedad
                        _lista.Add(gb)
                    End If
                Case GetType(TableLayoutPanel)
                    If c.Controls.Count > 0 Then
                        Dim cTBL = DirectCast(c, TableLayoutPanel)

                        Dim tb As New ControlesGuardados.TableLayoutPanel(cTBL.Location, cTBL.Size, cTBL.Name, cTBL.Dock, cTBL.Anchor, ColorTOHTML(cTBL.ForeColor), ColorTOHTML(cTBL.BackColor), returnChildsTBL(cTBL), cTBL.ColumnCount, cTBL.RowCount) 'Necesario castearlo como panel para sacar esa propiedad
                        _lista.Add(tb)
                    End If
                Case GetType(Label)
                    _lista.Add(New ControlesGuardados.Label(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, c.Font))

                Case GetType(TextBox)
                    _lista.Add(New ControlesGuardados.Textbox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, c.Font))
                Case GetType(Button)
                    _lista.Add(New ControlesGuardados.Button(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.BackgroundImage, c.BackgroundImageLayout))
                Case GetType(ListBox)
                    _lista.Add(New ControlesGuardados.ListBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), convertirItemsLBOX(DirectCast(c, ListBox).Items), c.Font))

            End Select

        Next
        Dim lista As New ControlesGuardados.ListaControles(_lista)
        Return lista
    End Function

    Function returnChildsTBL(tbl As TableLayoutPanel) As List(Of ControlesGuardados.TBLControl)

        Dim tblControlList As New List(Of ControlesGuardados.TBLControl)

        Dim childs As New List(Of Control)

        For Each c As Control In tbl.Controls
            childs.Add(c)
        Next

        Dim scontrol_childs = getChilds(childs)
        For Each c As Control In childs

            Console.WriteLine(c.Name)
            For Each c2 As ControlesGuardados.SControl In scontrol_childs

                Dim cell = tbl.GetPositionFromControl(c)
                Dim col = cell.Column
                Dim row = cell.Row
                Console.WriteLine(col.ToString() & " " & row.ToString())
                tblControlList.Add(New ControlesGuardados.TBLControl(c2, col, row))
            Next

        Next

        Return tblControlList
    End Function

    Function getChilds(controles As List(Of Control)) As List(Of ControlesGuardados.SControl)
        Dim lista As New List(Of ControlesGuardados.SControl)
        For Each c As Control In controles

            Select Case c.GetType()
                Case GetType(Panel)

                    Dim tmp_list As New List(Of Control)
                    If c.Controls.Count > 0 Then

                        For Each c2 As Control In c.Controls
                            tmp_list.Add(c2)
                        Next

                    End If
                    Console.WriteLine(c.Location)
                    lista.Add(New ControlesGuardados.Panel(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), DirectCast(c, Panel).AutoScroll, getChilds(tmp_list))) 'Necesario castearlo como panel para sacar esa propiedad

                Case GetType(GroupBox)
                    Dim tmp_list As New List(Of Control)
                    If c.Controls.Count > 0 Then

                        For Each c2 As Control In c.Controls
                            tmp_list.Add(c2)
                        Next
                    End If
                    lista.Add(New ControlesGuardados.GroupBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, getChilds(tmp_list), c.Font)) 'Necesario castearlo como panel para sacar esa propiedad

                Case GetType(Label)
                    lista.Add(New ControlesGuardados.Label(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, c.Font))

                Case GetType(TextBox)
                    lista.Add(New ControlesGuardados.Textbox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, c.Font))
                Case GetType(Button)
                    lista.Add(New ControlesGuardados.Button(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.BackgroundImage, c.BackgroundImageLayout))
                Case GetType(ListBox)
                    lista.Add(New ControlesGuardados.ListBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), convertirItemsLBOX(DirectCast(c, ListBox).Items), c.Font))
                Case GetType(TableLayoutPanel)

                    Dim cTBL = DirectCast(c, TableLayoutPanel)

                    Dim tb As New ControlesGuardados.TableLayoutPanel(cTBL.Location, cTBL.Size, cTBL.Name, cTBL.Dock, cTBL.Anchor, ColorTOHTML(cTBL.ForeColor), ColorTOHTML(cTBL.BackColor), returnChildsTBL(cTBL), cTBL.ColumnCount, cTBL.RowCount) 'Necesario castearlo como panel para sacar esa propiedad
                    lista.Add(tb)
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
            Case GetType(ControlesGuardados.GroupBox)
                Return buildGroupBox(Control)
            Case GetType(ControlesGuardados.CheckBox)
                Return buildCheckBox(Control)
            Case GetType(ControlesGuardados.ComboBox)
                Return buildComboBox(Control)
            Case GetType(ControlesGuardados.ListBox)
                Return buildListBox(Control)
            Case GetType(ControlesGuardados.TableLayoutPanel)
                Return buildTableLayoutPanel(Control)
            Case Else
                Console.WriteLine(Control.GetType().ToString())
        End Select

    End Function

    Private Function buildTableLayoutPanel(control As ControlesGuardados.TableLayoutPanel) As TableLayoutPanel
        Dim tb As New TableLayoutPanel With {
            .Name = control.Nombre,
            .Location = control.Posicion,
            .Size = control.Tamano,
            .Dock = control.Dock,
            .Anchor = control.Anchor,
            .BackColor = HTMLTOColor(control.BackColor),
            .ForeColor = HTMLTOColor(control.ForeColor),
            .ColumnCount = control.Cols,
            .RowCount = control.Rows
        }
        'SERIALIZAR ROWSTYLESCOLLECTION Y COLSTYLESCOLLECTION

        'For i = 0 To control.Cols
        '    If i = 0 Then
        '        Exit For
        '    End If
        '    tb.ColumnCount = i
        '    tb.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))

        'Next i

        'For j = 0 To control.Rows
        '    If j = 0 Then
        '        Exit For
        '    End If
        '    tb.RowCount = j
        '    tb.RowStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))

        'Next j

        For Each c As ControlesGuardados.TBLControl In control.ChildsTuple

            'Dim ctrl = ConstruirControl(c.Control)
            tb.Controls.Add(ConstruirControl(c.Control), c.ColIndex, c.RowIndex)
        Next

        Return tb
    End Function

    Private Function buildListBox(control As ControlesGuardados.ListBox) As ListBox
        Dim lb As New ListBox With {
            .Name = control.Nombre,
            .Location = control.Posicion,
            .Size = control.Tamano,
            .Dock = control.Dock,
            .Anchor = control.Anchor,
            .BackColor = HTMLTOColor(control.BackColor),
            .ForeColor = HTMLTOColor(control.ForeColor),
            .Text = control.text,
            .Font = control.StrToFont()
        }
        lb.Items.AddRange(control.items)
        Return lb
    End Function

    Private Function buildComboBox(control As ControlesGuardados.ComboBox) As ComboBox
        Dim cb As New ComboBox With {
            .Name = control.Nombre,
            .Location = control.Posicion,
            .Size = control.Tamano,
            .Dock = control.Dock,
            .Anchor = control.Anchor,
            .BackColor = HTMLTOColor(control.BackColor),
            .ForeColor = HTMLTOColor(control.ForeColor),
            .Text = control.text,
            .Font = control.StrToFont()
        }
        cb.Items.AddRange(control.items)
        Return cb
    End Function

    Private Function buildCheckBox(control As ControlesGuardados.CheckBox) As CheckBox
        Return New CheckBox With {
            .Name = control.Nombre,
            .Location = control.Posicion,
            .Size = control.Tamano,
            .Dock = control.Dock,
            .Anchor = control.Anchor,
            .BackColor = HTMLTOColor(control.BackColor),
            .ForeColor = HTMLTOColor(control.ForeColor),
            .Text = control.text,
            .Font = control.StrToFont()
        }
    End Function

    Function buildPanel(control As ControlesGuardados.Panel) As Panel
        Dim pnl As New Panel With {
            .Name = control.Nombre,
            .Location = control.Posicion,
            .Size = control.Tamano,
            .Dock = control.Dock,
            .Anchor = control.Anchor,
            .BackColor = HTMLTOColor(control.BackColor),
            .ForeColor = HTMLTOColor(control.ForeColor),
            .AutoScroll = control.AutoScroll
        }

        For Each c As ControlesGuardados.SControl In control.Childs
            pnl.Controls.Add(ConstruirControl(c))
        Next

        Return pnl
    End Function

    Function buildGroupBox(control As ControlesGuardados.GroupBox) As GroupBox
        Dim gb As New GroupBox With {
            .Name = control.Nombre,
            .Location = control.Posicion,
            .Size = control.Tamano,
            .Dock = control.Dock,
            .Anchor = control.Anchor,
            .BackColor = HTMLTOColor(control.BackColor),
            .ForeColor = HTMLTOColor(control.ForeColor),
            .Text = control.text,
            .Font = control.StrToFont()
        }

        For Each c As ControlesGuardados.SControl In control.Childs
            gb.Controls.Add(ConstruirControl(c))
        Next

        Return gb
    End Function

    Function buildButton(control As ControlesGuardados.Button) As Button
        Dim btn As New Button With {
            .Name = control.Nombre,
            .Location = control.Posicion,
            .Size = control.Tamano,
            .Dock = control.Dock,
            .Anchor = control.Anchor,
            .BackColor = HTMLTOColor(control.BackColor),
            .ForeColor = HTMLTOColor(control.ForeColor)
        } 'AGREGAR TEXT, FONT

        If Not control.bgImage = String.Empty Then
            Try
                btn.BackgroundImage = control.B64strToBmp()
                btn.BackgroundImageLayout = control.bgLayout
            Catch ex As Exception
                Console.WriteLine("String no valido")
            End Try

        End If

        Return btn
    End Function
    Function buildTextBox(control As ControlesGuardados.Textbox) As TextBox
        Return New TextBox With {
            .Name = control.Nombre,
            .Location = control.Posicion,
            .Size = control.Tamano,
            .Dock = control.Dock,
            .Anchor = control.Anchor,
            .ForeColor = HTMLTOColor(control.ForeColor),
            .Text = control.text,
            .Font = control.StrToFont()
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
            .Text = control.text,
            .Font = control.StrToFont()
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
