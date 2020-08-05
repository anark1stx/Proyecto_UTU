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
    Public Function guardarXML(listaControles As List(Of Object)) As String 'Retornar un string XML entero con todos los datos.

        For Each control In listaControles

            Select Case control.GetType().ToString().Replace("System.Windows.Forms.", "")
                Case "TextBox"
                    Dim txt As New TextBox
                    txt = control '<-- Es necesario cambiar su tipo de Object a TextBox, sino no podremos ver sus propiedades como TEXTBOX.
                    control_nombre = txt.Name
                    control_Pos = txt.Location
                    control_Fuente = txt.Font.Name
                    control_Fuente_tamano = txt.Font.Size
                    control_tamano = txt.Size
                    control_ColorR = txt.ForeColor.Name
                    string_control = String.Format("<TextBox><Name>{0}</Name><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><Font><FontName>{5}</FontName><FontSize>{6}</FontSize></Font><ColorName>{7}</ColorName></TextBox>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_Fuente, control_Fuente_tamano, control_ColorR)

                    string_armado += string_control

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
                    string_control = String.Format("<Label><Name>{0}</Name><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><Font><FontName>{5}</FontName><FontSize>{6}</FontSize></Font><ColorName>{7}</ColorName><Texto>{8}</Texto></Label>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_Fuente, control_Fuente_tamano, control_ColorR, control_texto)

                    string_armado += string_control

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
                    string_control = String.Format("<CheckBox><Name>{0}</Name><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><Font><FontName>{5}</FontName><FontSize>{6}</FontSize></Font><ColorName>{7}</ColorName><Texto>{8}</Texto></CheckBox>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_Fuente, control_Fuente_tamano, control_ColorR, control_texto)

                    string_armado += string_control

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
                    string_control = String.Format("<GroupBox><Name>{0}</Name><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><Font><FontName>{5}</FontName><FontSize>{6}</FontSize></Font><ColorName>{7}</ColorName><Texto>{8}</Texto></GroupBox>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_Fuente, control_Fuente_tamano, control_ColorR, control_texto)

                    string_armado += string_control
                Case "Panel"
                    Dim pnl As New Panel
                    pnl = control
                    control_nombre = pnl.Name
                    control_Pos = pnl.Location
                    control_tamano = pnl.Size
                    control_ColorR = pnl.BackColor.Name
                    string_control = String.Format("<Panel><Name>{0}</Name><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><ColorName>{5}</ColorName></Panel>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_ColorR)

                    string_armado += string_control

                Case "TableLayoutPanel"
                    Dim tbl As New TableLayoutPanel
                    tbl = control
                    control_nombre = tbl.Name
                    control_Pos = tbl.Location
                    control_tamano = tbl.Size
                    control_ColorR = tbl.BackColor.Name
                    string_control = String.Format("<TableLayoutPanel><Name>{0}</Name><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><ColorName>{5}</ColorName></TableLayoutPanel>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_ColorR)

                    string_armado += string_control

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

                        string_control = String.Format("<Button><Name>{0}</Name><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><ColorName>{5}</ColorName><Picture>{6}</Picture></Button>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_ColorR, b64)
                    Else
                        string_control = String.Format("<Button><Name>{0}</Name><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><ColorName>{5}</ColorName></Button>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_ColorR)

                    End If

                    string_armado += string_control
            End Select

        Next

        Return string_armado & "</Controles>" 'Por último, este documento XML será guardado en la BD, desde la cual el paciente seleccionará para visualizar su diagnóstico hecho con este formulario.

    End Function

    Public Function generarInstancias(doc As Xml.XmlDocument) As List(Of Object)

        Dim listaObj As New List(Of Object)

        For Each nodo As Xml.XmlNode In doc.GetElementsByTagName("TextBox")

            Dim Nombre As String = nodo.SelectSingleNode("Name").InnerText
            Dim X As String = nodo.SelectSingleNode("X").InnerText
            Dim Y As String = nodo.SelectSingleNode("Y").InnerText
            Dim Width As String = nodo.SelectSingleNode("SizeW").InnerText
            Dim Height As String = nodo.SelectSingleNode("SizeH").InnerText
            Dim NomFuente As String = nodo.SelectSingleNode("Font").ChildNodes(0).InnerText
            Dim tamanoFuente As String = nodo.SelectSingleNode("Font").ChildNodes(1).InnerText
            Dim nomColor As String = nodo.SelectSingleNode("ColorName").InnerText

            Dim propsList As New List(Of String)({Nombre, X, Y, Width, Height, NomFuente, tamanoFuente, nomColor})

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
            Dim propsList As New List(Of String)({Nombre, X, Y, Width, Height, NomFuente, tamanoFuente, nomColor, texto})

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
            Dim propsList As New List(Of String)({Nombre, X, Y, Width, Height, NomFuente, tamanoFuente, nomColor, texto})

            listaObj.Add(buildCheckBox(propsList))

        Next

        Return listaObj
    End Function

    Public Function buildTextBox(propiedades As List(Of String)) As TextBox

        Dim fntConverter As New FontConverter
        Dim tmpFont As Font = New Font(propiedades(5), Single.Parse(propiedades(6)), FontStyle.Regular)
        '{0} = Nombre, {1} = X, {2} = Y, {3} = Width, {4} = Height, {5} = NomFuente, {6} = tamanoFuente, {7} = nomColor
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
End Class
