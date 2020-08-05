Public Class GestorXML
    Private encabezado As String = "<?xml version='1.0' encoding='UTF-8' standalone='yes' ?><Controles>"
    Private string_armado As String = encabezado
    Private string_control As String = ""
    Private control_nombre As String = ""
    Private control_texto As String = ""
    Private control_Pos As Point = New Point(0, 0)
    Private control_Fuente As String = SystemFonts.DefaultFont.Name
    Private control_Fuente_tamano As String = SystemFonts.DefaultFont.Size
    Private control_tamano As Size = New Size(0, 0)
    Private control_ColorR As String
    Private control_parent As Control 'El que contiene a determinado control
    Public Function guardarXML(listaControles As List(Of Object)) As String 'Retornar un string XML entero con todos los datos.

        For Each control In listaControles 'TODO -> Encontrar parent de cada control.

            Select Case control.GetType().ToString().Replace("System.Windows.Forms.", "")
                Case "GroupBox"
                    Dim gb As New GroupBox
                    gb = control
                    control_nombre = gb.Name
                    control_Pos = gb.Location
                    control_Fuente = gb.Font.Name
                    control_Fuente_tamano = gb.Font.Size
                    control_tamano = gb.Size
                    control_ColorR = gb.BackColor.Name
                    control_texto = gb.Text
                    control_parent = gb.Parent

                    Dim child As String = getChildData(gb.Controls)
                    string_control = String.Format("<GroupBox><Name>{0}</Name><Parent>{9}</Parent><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><Font><FontName>{5}</FontName><FontSize>{6}</FontSize></Font><ColorName>{7}</ColorName><Texto>{8}</Texto><_Controles>{10}</_Controles></GroupBox>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_Fuente, control_Fuente_tamano, control_ColorR, control_texto, control_parent, child)

                    string_armado += string_control
                Case "Panel"
                    Dim pnl As New Panel
                    pnl = control
                    control_nombre = pnl.Name
                    control_Pos = pnl.Location
                    control_tamano = pnl.Size
                    control_ColorR = pnl.BackColor.Name
                    control_parent = pnl.Parent
                    Dim child As String = getChildData(pnl.Controls)
                    string_control = String.Format("<Panel><Name>{0}</Name><Parent>{6}</Parent><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><ColorName>{5}</ColorName><_Controles>{7}</_Controles></Panel>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_ColorR, control_parent, child)

                    string_armado += string_control

                Case "TableLayoutPanel"
                    Dim tbl As New TableLayoutPanel
                    tbl = control
                    control_nombre = tbl.Name
                    control_Pos = tbl.Location
                    control_tamano = tbl.Size
                    control_ColorR = tbl.BackColor.Name
                    Dim cols = tbl.ColumnCount
                    Dim rows = tbl.RowCount
                    Dim child As String = getChildData(tbl.Controls)
                    string_control = String.Format("<TableLayoutPanel><Name>{0}</Name><Parent>{6}</Parent><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><ColorName>{5}</ColorName><Cols>{7}</Cols><Rows>{8}</Rows><_Controles>{9}</_Controles></TableLayoutPanel>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_ColorR, control_parent, cols, rows, child)

                    string_armado += string_control

            End Select

        Next

        Return string_armado & "</Controles>" 'Por último, este documento XML será guardado en la BD, desde la cual el paciente seleccionará para visualizar su diagnóstico hecho con este formulario.

    End Function

    Public Function getChildData(listacontroles As Control.ControlCollection) As String
        Dim xml_hijos As String = ""
        For Each control As Control In listacontroles
            Select Case control.GetType.ToString.Replace("System.Windows.Forms.", "")
                Case "GroupBox"
                    Dim gb As New GroupBox
                    gb = control
                    control_nombre = gb.Name
                    control_Pos = gb.Location
                    control_Fuente = gb.Font.Name
                    control_Fuente_tamano = gb.Font.Size
                    control_tamano = gb.Size
                    control_ColorR = gb.BackColor.Name
                    control_texto = gb.Text
                    control_parent = gb.Parent

                    Dim child As String = getChildData(gb.Controls)
                    string_control = String.Format("<GroupBox><Name>{0}</Name><Parent>{9}</Parent><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><Font><FontName>{5}</FontName><FontSize>{6}</FontSize></Font><ColorName>{7}</ColorName><Texto>{8}</Texto><_Controles>{10}</_Controles></GroupBox>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_Fuente, control_Fuente_tamano, control_ColorR, control_texto, control_parent, child)

                    string_armado += string_control
                Case "Panel"
                    Dim pnl As New Panel
                    pnl = control
                    control_nombre = pnl.Name
                    control_Pos = pnl.Location
                    control_tamano = pnl.Size
                    control_ColorR = pnl.BackColor.Name
                    control_parent = pnl.Parent
                    Dim child As String = getChildData(pnl.Controls)
                    string_control = String.Format("<Panel><Name>{0}</Name><Parent>{6}</Parent><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><ColorName>{5}</ColorName><_Controles>{7}</_Controles></Panel>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_ColorR, control_parent, child)

                    string_armado += string_control

                Case "TableLayoutPanel"
                    Dim tbl As New TableLayoutPanel
                    tbl = control
                    control_nombre = tbl.Name
                    control_Pos = tbl.Location
                    control_tamano = tbl.Size
                    control_ColorR = tbl.BackColor.Name
                    Dim cols = tbl.ColumnCount
                    Dim rows = tbl.RowCount
                    Dim child As String = getChildData(tbl.Controls)
                    string_control = String.Format("<TableLayoutPanel><Name>{0}</Name><Parent>{6}</Parent><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><ColorName>{5}</ColorName><Cols>{7}</Cols><Rows>{8}</Rows><_Controles>{9}</_Controles></TableLayoutPanel>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_ColorR, control_parent, cols, rows, child)

                    string_armado += string_control
                Case "TextBox"
                    Dim txt As New TextBox
                    txt = control '<-- Es necesario cambiar su tipo de Object a TextBox, sino no podremos ver sus propiedades como TEXTBOX.
                    control_nombre = txt.Name
                    control_Pos = txt.Location
                    control_Fuente = txt.Font.Name
                    control_Fuente_tamano = txt.Font.Size
                    control_tamano = txt.Size
                    control_ColorR = txt.ForeColor.Name
                    string_control = String.Format("<TextBox><Name>{0}</Name><Parent>{8}</Parent><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><Font><FontName>{5}</FontName><FontSize>{6}</FontSize></Font><ColorName>{7}</ColorName></TextBox>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_Fuente, control_Fuente_tamano, control_ColorR, control_parent)

                    xml_hijos += string_control
                Case "ListBox"
                    Dim lbox As New ListBox
                    lbox = control '<-- Es necesario cambiar su tipo de Object a ListBox, sino no podremos ver sus propiedades como TEXTBOX.
                    control_nombre = lbox.Name
                    control_Pos = lbox.Location
                    control_Fuente = lbox.Font.Name
                    control_Fuente_tamano = lbox.Font.Size
                    control_tamano = lbox.Size
                    control_ColorR = lbox.ForeColor.Name
                    'AGREGAR ITEMS DE LA LISTBOX ->
                    Dim itemsStr As String = ""

                    For Each item As Object In lbox.Items
                        Dim _item As System.Xml.Linq.XElement = <item><%= item %></item>
                        itemsStr += _item.ToString()
                    Next
                    string_control = String.Format("<ListBox><Name>{0}</Name><Parent>{8}</Parent><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><Font><FontName>{5}</FontName><FontSize>{6}</FontSize></Font><ColorName>{7}</ColorName><Items>{9}</Items></ListBox>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_Fuente, control_Fuente_tamano, control_ColorR, control_parent, itemsStr)

                    xml_hijos += string_control
                Case "Label"
                    Dim lbl As New Label
                    lbl = control '<-- Es necesario cambiar su tipo de Object a Label, sino no podremos ver sus propiedades como LABEL.
                    control_nombre = lbl.Name
                    control_Pos = lbl.Location
                    control_Fuente = lbl.Font.Name
                    control_Fuente_tamano = lbl.Font.Size
                    control_tamano = lbl.Size
                    control_ColorR = lbl.ForeColor.Name
                    control_texto = lbl.Text
                    string_control = String.Format("<Label><Name>{0}</Name><Parent>{9}</Parent><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><Font><FontName>{5}</FontName><FontSize>{6}</FontSize></Font><ColorName>{7}</ColorName><Texto>{8}</Texto></Label>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_Fuente, control_Fuente_tamano, control_ColorR, control_texto, control_parent)

                    xml_hijos += string_control

                Case "CheckBox"
                    Dim chk As New CheckBox
                    chk = control '<-- Es necesario cambiar su tipo de Object a CheckBox, sino no podremos ver sus propiedades como CheckBox.
                    control_nombre = chk.Name
                    control_Pos = chk.Location
                    control_Fuente = chk.Font.Name
                    control_Fuente_tamano = chk.Font.Size
                    control_tamano = chk.Size
                    control_ColorR = chk.ForeColor.Name
                    control_texto = chk.Text
                    string_control = String.Format("<CheckBox><Name>{0}</Name><Parent>{9}</Parent><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><Font><FontName>{5}</FontName><FontSize>{6}</FontSize></Font><ColorName>{7}</ColorName><Texto>{8}</Texto></CheckBox>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_Fuente, control_Fuente_tamano, control_ColorR, control_texto, control_parent)

                    xml_hijos += string_control

                Case "Button"
                    Dim btn As New Button
                    btn = control
                    control_nombre = btn.Name
                    control_Pos = btn.Location
                    control_tamano = btn.Size
                    control_ColorR = btn.BackColor.Name

                    If Not btn.BackgroundImage Is Nothing Then 'Para guardar las imagenes de los botones
                        Dim picture = btn.BackgroundImage

                        Dim ms As New System.IO.MemoryStream()
                        picture.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

                        Dim byteImg As Byte() = ms.ToArray()
                        Dim b64 = Convert.ToBase64String(byteImg)

                        string_control = String.Format("<Button><Name>{0}</Name><Parent>{7}</Parent><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><ColorName>{5}</ColorName><Picture>{6}</Picture></Button>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_ColorR, b64, control_parent)
                    Else
                        string_control = String.Format("<Button><Name>{0}</Name><Parent>{6}</Parent><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><ColorName>{5}</ColorName></Button>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_ColorR, control_parent)

                    End If

                    xml_hijos += string_control
            End Select

        Next
        Return xml_hijos
    End Function

    Public Function generarInstancias(doc As Xml.XmlDocument) As List(Of Object)

        Dim listaObj As New List(Of Object)

        For Each nodo As Xml.XmlNode In doc.GetElementsByTagName("Panel")

            Dim Nombre As String = nodo.SelectSingleNode("Name").InnerText
            Dim X As String = nodo.SelectSingleNode("X").InnerText
            Dim Y As String = nodo.SelectSingleNode("Y").InnerText
            Dim Width As String = nodo.SelectSingleNode("SizeW").InnerText
            Dim Height As String = nodo.SelectSingleNode("SizeH").InnerText
            Dim nomColor As String = nodo.SelectSingleNode("ColorName").InnerText
            Dim parent As String = nodo.SelectSingleNode("Parent").InnerText
            Dim propsList As New List(Of String)({Nombre, X, Y, Width, Height, nomColor, parent})

            listaObj.Add(buildPanel(propsList))

        Next

        For Each nodo As Xml.XmlNode In doc.GetElementsByTagName("TableLayoutPanel")

            Dim Nombre As String = nodo.SelectSingleNode("Name").InnerText
            Dim X As String = nodo.SelectSingleNode("X").InnerText
            Dim Y As String = nodo.SelectSingleNode("Y").InnerText
            Dim Width As String = nodo.SelectSingleNode("SizeW").InnerText
            Dim Height As String = nodo.SelectSingleNode("SizeH").InnerText
            Dim nomColor As String = nodo.SelectSingleNode("ColorName").InnerText
            Dim parent As String = nodo.SelectSingleNode("Parent").InnerText
            Dim cols As String = nodo.SelectSingleNode("Cols").InnerText
            Dim rows As String = nodo.SelectSingleNode("Rows").InnerText
            Dim propsList As New List(Of String)({Nombre, X, Y, Width, Height, nomColor, parent, cols, rows})

            listaObj.Add(buildTableLayoutPanel(propsList))

        Next

        For Each nodo As Xml.XmlNode In doc.GetElementsByTagName("GroupBox")

            Dim Nombre As String = nodo.SelectSingleNode("Name").InnerText
            Dim X As String = nodo.SelectSingleNode("X").InnerText
            Dim Y As String = nodo.SelectSingleNode("Y").InnerText
            Dim Width As String = nodo.SelectSingleNode("SizeW").InnerText
            Dim Height As String = nodo.SelectSingleNode("SizeH").InnerText
            Dim NomFuente As String = nodo.SelectSingleNode("Font").ChildNodes(0).InnerText
            Dim tamanoFuente As String = nodo.SelectSingleNode("Font").ChildNodes(1).InnerText
            Dim nomColor As String = nodo.SelectSingleNode("ColorName").InnerText
            Dim texto As String = nodo.SelectSingleNode("Texto").InnerText
            Dim parent As String = nodo.SelectSingleNode("Parent").InnerText
            Dim propsList As New List(Of String)({Nombre, X, Y, Width, Height, NomFuente, tamanoFuente, nomColor, texto, parent})

            listaObj.Add(buildGroupBox(propsList))

        Next

        For Each nodo As Xml.XmlNode In doc.GetElementsByTagName("TextBox")

            Dim Nombre As String = nodo.SelectSingleNode("Name").InnerText
            Dim X As String = nodo.SelectSingleNode("X").InnerText
            Dim Y As String = nodo.SelectSingleNode("Y").InnerText
            Dim Width As String = nodo.SelectSingleNode("SizeW").InnerText
            Dim Height As String = nodo.SelectSingleNode("SizeH").InnerText
            Dim NomFuente As String = nodo.SelectSingleNode("Font").ChildNodes(0).InnerText
            Dim tamanoFuente As String = nodo.SelectSingleNode("Font").ChildNodes(1).InnerText
            Dim nomColor As String = nodo.SelectSingleNode("ColorName").InnerText
            Dim parent As String = nodo.SelectSingleNode("Parent").InnerText
            Dim propsList As New List(Of String)({Nombre, X, Y, Width, Height, NomFuente, tamanoFuente, nomColor, parent})

            listaObj.Add(buildTextBox(propsList))

        Next

        For Each nodo As Xml.XmlNode In doc.GetElementsByTagName("Label")

            Dim Nombre As String = nodo.SelectSingleNode("Name").InnerText
            Dim X As String = nodo.SelectSingleNode("X").InnerText
            Dim Y As String = nodo.SelectSingleNode("Y").InnerText
            Dim Width As String = nodo.SelectSingleNode("SizeW").InnerText
            Dim Height As String = nodo.SelectSingleNode("SizeH").InnerText
            Dim NomFuente As String = nodo.SelectSingleNode("Font").ChildNodes(0).InnerText
            Dim tamanoFuente As String = nodo.SelectSingleNode("Font").ChildNodes(1).InnerText
            Dim nomColor As String = nodo.SelectSingleNode("ColorName").InnerText
            Dim texto As String = nodo.SelectSingleNode("Texto").InnerText
            Dim parent As String = nodo.SelectSingleNode("Parent").InnerText
            Dim propsList As New List(Of String)({Nombre, X, Y, Width, Height, NomFuente, tamanoFuente, nomColor, texto, parent})

            listaObj.Add(buildLabel(propsList))

        Next

        For Each nodo As Xml.XmlNode In doc.GetElementsByTagName("CheckBox")

            Dim Nombre As String = nodo.SelectSingleNode("Name").InnerText
            Dim X As String = nodo.SelectSingleNode("X").InnerText
            Dim Y As String = nodo.SelectSingleNode("Y").InnerText
            Dim Width As String = nodo.SelectSingleNode("SizeW").InnerText
            Dim Height As String = nodo.SelectSingleNode("SizeH").InnerText
            Dim NomFuente As String = nodo.SelectSingleNode("Font").ChildNodes(0).InnerText
            Dim tamanoFuente As String = nodo.SelectSingleNode("Font").ChildNodes(1).InnerText
            Dim nomColor As String = nodo.SelectSingleNode("ColorName").InnerText
            Dim texto As String = nodo.SelectSingleNode("Texto").InnerText
            Dim parent As String = nodo.SelectSingleNode("Parent").InnerText
            Dim propsList As New List(Of String)({Nombre, X, Y, Width, Height, NomFuente, tamanoFuente, nomColor, texto, parent})

            listaObj.Add(buildCheckBox(propsList))

        Next
        Return listaObj
    End Function

    Public Function buildTextBox(propiedades As List(Of String)) As TextBox

        Dim fntConverter As New FontConverter
        Dim tmpFont As Font = New Font(propiedades(5), Single.Parse(propiedades(6)), FontStyle.Regular)
        '{0} = Nombre, {1} = X, {2} = Y, {3} = Width, {4} = Height, {5} = NomFuente, {6} = tamanoFuente, {7} = nomColor, {8} = parent
        Dim txtBuild As New TextBox With {
            .Name = propiedades(0),
            .Location = New Point(Val(propiedades(1)), Val(propiedades(2))),
            .Size = New Size(Val(propiedades(3)), Val(propiedades(4))),
            .Font = tmpFont,
            .ForeColor = Color.FromName(propiedades(7))
        }

        Return txtBuild
    End Function

    Public Function buildLabel(propiedades As List(Of String)) As Label
        Dim tmpFont As Font = New Font(propiedades(5), Single.Parse(propiedades(6)), FontStyle.Regular)
        '{0} = Nombre, {1} = X, {2} = Y, {3} = Width, {4} = Height, {5} = NomFuente, {6} = tamanoFuente, {7} = nomColor, {8} = Texto
        Dim lblBuild As New Label With {
            .Name = propiedades(0),
            .Location = New Point(Val(propiedades(1)), Val(propiedades(2))),
            .Size = New Size(Val(propiedades(3)), Val(propiedades(4))),
            .Font = tmpFont,
            .ForeColor = Color.FromName(propiedades(7)),
            .Text = propiedades(8)
        }

        Return lblBuild
    End Function

    Public Function buildCheckBox(propiedades As List(Of String)) As CheckBox
        Dim tmpFont As Font = New Font(propiedades(5), Single.Parse(propiedades(6)), FontStyle.Regular)
        '{0} = Nombre, {1} = X, {2} = Y, {3} = Width, {4} = Height, {5} = NomFuente, {6} = tamanoFuente, {7} = nomColor, {8} = Texto
        Dim chkBuild As New CheckBox With {
            .Name = propiedades(0),
            .Location = New Point(Val(propiedades(1)), Val(propiedades(2))),
            .Size = New Size(Val(propiedades(3)), Val(propiedades(4))),
            .Font = tmpFont,
            .ForeColor = Color.FromName(propiedades(7)),
            .Text = propiedades(8)
        }

        Return chkBuild
    End Function

    Public Function buildButton(propiedades As List(Of String)) As Button

    End Function

    Public Function buildPanel(propiedades As List(Of String)) As Panel

    End Function

    Public Function buildTableLayoutPanel(propiedades As List(Of String)) As TableLayoutPanel

    End Function

    Public Function buildGroupBox(propiedades As List(Of String)) As GroupBox

    End Function



End Class
