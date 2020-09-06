Imports System.Windows.Forms
Imports System.Drawing
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
                        _lista.Add(pnl)

                    End If
                Case GetType(GroupBox)
                    If c.Controls.Count > 0 Then
                        Dim tmp_list As New List(Of Control)

                        For Each c2 As Control In c.Controls
                            tmp_list.Add(c2)
                        Next

                        Dim childs = getChilds(tmp_list)
                        Dim gb As New ControlesGuardados.GroupBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, childs, c.Font)
                        _lista.Add(gb)
                    End If
                Case GetType(TableLayoutPanel)
                    If c.Controls.Count > 0 Then
                        Dim cTBL = DirectCast(c, TableLayoutPanel)

                        Dim tb As New ControlesGuardados.TableLayoutPanel(cTBL.Location, cTBL.Size, cTBL.Name, cTBL.Dock, cTBL.Anchor, ColorTOHTML(cTBL.ForeColor), ColorTOHTML(cTBL.BackColor), returnChildsTBL(cTBL), cTBL.ColumnCount, cTBL.RowCount)
                        _lista.Add(tb)
                    End If
                Case GetType(TabControl)
                    If c.Controls.Count > 0 Then
                        Dim tbC = DirectCast(c, TabControl)
                        Dim tb As New ControlesGuardados.TabControl(tbC.Location, tbC.Size, tbC.Name, tbC.Dock, ColorTOHTML(tbC.BackColor), returnPages(tbC))
                        _lista.Add(tb)
                    End If
                Case GetType(ComboBox)
                    _lista.Add(New ControlesGuardados.ComboBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), convertirItemsString(c), c.Font, c.Tag))
                Case GetType(Label)
                    _lista.Add(New ControlesGuardados.Label(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, c.Font, c.Tag))
                Case GetType(CheckBox)
                    _lista.Add(New ControlesGuardados.CheckBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, c.Font, c.Tag))
                Case GetType(TextBox)
                    _lista.Add(New ControlesGuardados.Textbox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, c.Font, DirectCast(c, TextBox).Multiline, c.Tag))
                Case GetType(Button)
                    _lista.Add(New ControlesGuardados.Button(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.BackgroundImage, c.BackgroundImageLayout, c.Tag))
                Case GetType(ListBox)
                    _lista.Add(New ControlesGuardados.ListBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), convertirItemsString(c), c.Font))

            End Select

        Next
        Dim lista As New ControlesGuardados.ListaControles(_lista)
        Return lista
    End Function

    Function returnChildsTBL(tbl As TableLayoutPanel) As List(Of ControlesGuardados.TBLControl)

        Dim tblControlList As New List(Of ControlesGuardados.TBLControl)

        Dim misCtrls = New List(Of Control)

        For Each c As Control In tbl.Controls
            misCtrls.Add(c)
        Next

        Dim SmisSCtrl = New List(Of ControlesGuardados.SControl)(getChilds(misCtrls))

        For i = 0 To tbl.Controls.Count - 1
            Dim col = tbl.GetColumn(tbl.Controls(i))
            Dim row = tbl.GetRow(tbl.Controls(i))

            tblControlList.Add(New ControlesGuardados.TBLControl(SmisSCtrl(i), col, row))
        Next

        Return tblControlList
    End Function

    Function returnPages(tbc As TabControl) As List(Of ControlesGuardados.TabPage)
        Dim pages As New List(Of TabPage)
        Dim misTabs = New List(Of ControlesGuardados.TabPage)

        For Each page As TabPage In tbc.TabPages
            pages.Add(page)
        Next

        For Each page As TabPage In pages
            Dim SmisSCtrl = New List(Of ControlesGuardados.SControl)(getChildsTABPAGE(page))

            misTabs.Add(New ControlesGuardados.TabPage(page.Location, page.Size, page.Name, ColorTOHTML(page.BackColor), SmisSCtrl, page.AutoScroll, page.Text))
        Next

        Return misTabs
    End Function

    Function getChildsTABPAGE(tab As TabPage) As List(Of ControlesGuardados.SControl)
        Dim lista As New List(Of ControlesGuardados.SControl)
        For Each c As Control In tab.Controls

            Select Case c.GetType()
                Case GetType(Panel)

                    Dim tmp_list As New List(Of Control)
                    If c.Controls.Count > 0 Then

                        For Each c2 As Control In c.Controls
                            tmp_list.Add(c2)
                        Next

                    End If
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
                    lista.Add(New ControlesGuardados.Label(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, c.Font, c.Tag))
                Case GetType(ComboBox)
                    lista.Add(New ControlesGuardados.ComboBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), convertirItemsString(c), c.Font, c.Tag))
                Case GetType(TextBox)
                    lista.Add(New ControlesGuardados.Textbox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, c.Font, DirectCast(c, TextBox).Multiline, c.Tag))
                Case GetType(Button)
                    lista.Add(New ControlesGuardados.Button(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.BackgroundImage, c.BackgroundImageLayout, c.Tag))
                Case GetType(ListBox)
                    lista.Add(New ControlesGuardados.ListBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), convertirItemsString(c), c.Font))
                Case GetType(CheckBox)
                    lista.Add(New ControlesGuardados.CheckBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, c.Font, c.Tag))
                Case GetType(TableLayoutPanel)

                    Dim cTBL = DirectCast(c, TableLayoutPanel)

                    Dim tb As New ControlesGuardados.TableLayoutPanel(cTBL.Location, cTBL.Size, cTBL.Name, cTBL.Dock, cTBL.Anchor, ColorTOHTML(cTBL.ForeColor), ColorTOHTML(cTBL.BackColor), returnChildsTBL(cTBL), cTBL.ColumnCount, cTBL.RowCount) 'Necesario castearlo como panel para sacar esa propiedad
                    lista.Add(tb)
                Case GetType(TabPage)
                    Dim cTB = DirectCast(c, TabPage)
                    Dim tmp_list As New List(Of Control)
                    If c.Controls.Count > 0 Then

                        For Each c2 As Control In c.Controls
                            tmp_list.Add(c2)
                        Next
                    End If
                    Dim tb As New ControlesGuardados.TabPage(cTB.Location, cTB.Size, cTB.Name, ColorTOHTML(cTB.BackColor), getChilds(tmp_list), cTB.AutoScroll, cTB.Text)
            End Select

        Next

        Return lista

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
                    lista.Add(New ControlesGuardados.Label(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, c.Font, c.Tag))
                Case GetType(ComboBox)
                    lista.Add(New ControlesGuardados.ComboBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), convertirItemsString(c), c.Font, c.Tag))
                Case GetType(TextBox)
                    lista.Add(New ControlesGuardados.Textbox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, c.Font, DirectCast(c, TextBox).Multiline, c.Tag))
                Case GetType(Button)
                    lista.Add(New ControlesGuardados.Button(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.BackgroundImage, c.BackgroundImageLayout, c.Tag))
                Case GetType(ListBox)
                    lista.Add(New ControlesGuardados.ListBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), convertirItemsString(c), c.Font))
                Case GetType(CheckBox)
                    lista.Add(New ControlesGuardados.CheckBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, c.Font, c.Tag))
                Case GetType(TableLayoutPanel)

                    Dim cTBL = DirectCast(c, TableLayoutPanel)

                    Dim tb As New ControlesGuardados.TableLayoutPanel(cTBL.Location, cTBL.Size, cTBL.Name, cTBL.Dock, cTBL.Anchor, ColorTOHTML(cTBL.ForeColor), ColorTOHTML(cTBL.BackColor), returnChildsTBL(cTBL), cTBL.ColumnCount, cTBL.RowCount) 'Necesario castearlo como panel para sacar esa propiedad
                    lista.Add(tb)
                Case GetType(TabControl)
                    If c.Controls.Count > 0 Then
                        Dim tbC = DirectCast(c, TabControl)

                        Dim tb As New ControlesGuardados.TabControl(tbC.Location, tbC.Size, tbC.Name, tbC.Dock, ColorTOHTML(tbC.BackColor), returnPages(tbC))
                        lista.Add(tb)
                    End If
                Case GetType(TabPage)
                    Console.WriteLine("creando tabpage")
                    Dim cTB = DirectCast(c, TabPage)
                    Dim tmp_list As New List(Of Control)
                    If c.Controls.Count > 0 Then

                        For Each c2 As Control In c.Controls
                            tmp_list.Add(c2)
                        Next
                    End If
                    Dim tb As New ControlesGuardados.TabPage(cTB.Location, cTB.Size, cTB.Name, ColorTOHTML(cTB.BackColor), getChilds(tmp_list), cTB.AutoScroll, cTB.Text)

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
            Case GetType(ControlesGuardados.TabControl)
                Return buildTabControl(Control)
            Case GetType(ControlesGuardados.TabPage)
                Return buildTabPage(Control)
            Case Else
                Console.WriteLine(Control.GetType().ToString())
                Return Nothing
        End Select

    End Function

    Function buildTabControl(control As ControlesGuardados.TabControl) As TabControl
        Dim tabC As New TabControl With {
            .Name = control.Nombre,
            .Location = control.Posicion,
            .Size = control.Tamano,
            .Dock = DockStyle.Fill,
            .BackColor = HTMLTOColor(control.BackColor)
        }

        For Each c As ControlesGuardados.TabPage In control.Pages
            tabC.Controls.Add(ConstruirControl(c))
        Next

        Return tabC
    End Function

    Function buildTabPage(control As ControlesGuardados.TabPage) As TabPage
        Dim tabp As New TabPage With {
            .Name = control.Nombre,
            .Location = control.Posicion,
            .Size = control.Tamano,
            .Dock = control.Dock,
            .Anchor = control.Anchor,
            .BackColor = HTMLTOColor(control.BackColor),
            .Text = control.Texto,
            .AutoScroll = control.AutoScroll
        }
        Console.WriteLine("tengo autoscroll? " & tabp.AutoScroll)
        For Each c As ControlesGuardados.SControl In control.Childs
            tabp.Controls.Add(ConstruirControl(c))
        Next

        Return tabp
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


        For Each c As ControlesGuardados.TBLControl In control.ChildsTuple
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
            .Text = control.Text,
            .Font = control.StrToFont()
        }
        For Each s As String In control.items
            lb.Items.Add(s)
        Next

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
            .Text = control.Text,
            .Font = control.StrToFont(),
            .Tag = control.Tag
        }
        For Each s As String In control.items
            cb.Items.Add(s)
        Next
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
            .Text = control.Text,
            .Font = control.StrToFont(),
            .Tag = control.Tag
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
            .Text = control.Text,
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
            .ForeColor = HTMLTOColor(control.ForeColor),
            .Tag = control.Tag
        } 'AGREGAR Text, FONT

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
            .Text = control.Text,
            .Font = control.StrToFont(),
            .Multiline = control.Multiline,
            .Tag = control.Tag
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
            .Text = control.Text,
            .Font = control.StrToFont(),
            .Tag = control.Tag
        }
    End Function

    Function convertirItemsString(control As Control) As List(Of String)
        Dim l As New List(Of String)

        Select Case control.GetType()
            Case GetType(ListBox)
                For Each i In DirectCast(control, ListBox).Items
                    l.Add(i.ToString())
                Next

            Case GetType(ComboBox)
                For Each i In DirectCast(control, ComboBox).Items
                    l.Add(i.ToString())
                Next

        End Select

        Return l
    End Function

End Class
