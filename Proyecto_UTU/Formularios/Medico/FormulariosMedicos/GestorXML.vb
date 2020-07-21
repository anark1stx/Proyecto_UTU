Public Class GestorXML
    Public encabezado As String = "<?xml version='1.0' encoding='UTF-8' standalone='yes' ?><Controles>"
    Public Function guardarXML(listaControles As List(Of Object)) As String 'Retornar un string XML entero con todos los datos.
        Dim string_armado As String = encabezado
        Dim string_control As String = ""

        Dim control_nombre As String = ""
        Dim control_texto As String = ""
        Dim control_Pos As Point = New Point(0, 0)
        Dim control_Fuente As String = SystemFonts.DefaultFont.Name
        Dim control_Fuente_tamano As String = SystemFonts.DefaultFont.SizeInPoints
        Dim control_tamano As Size = New Size(0, 0)
        Dim control_ColorR As Integer = 0
        Dim control_ColorG As Integer = 0
        Dim control_ColorB As Integer = 0
        For Each control In listaControles

            Select Case control.GetType().ToString()
                Case "System.Windows.Forms.TextBox"
                    Dim txt As New TextBox
                    txt = control '<-- Es necesario cambiar su tipo de Object a TextBox, sino no podremos ver sus propiedades como TEXTBOX.
                    control_nombre = txt.Name
                    control_Pos = txt.Location
                    control_Fuente = txt.Font.Name
                    control_Fuente_tamano = txt.Font.SizeInPoints
                    control_tamano = txt.Size
                    control_ColorR = txt.ForeColor.R
                    control_ColorR = txt.ForeColor.G
                    control_ColorR = txt.ForeColor.B
                    string_control = String.Format("<TextBox><Name>{0}</Name><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><Font><FontName>{5}</FontName><FontSize>{6}</FontSize></Font><Color><Red>{7}</Red><Green>{8}</Green><Blue>{9}</Blue></Color></TextBox>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_Fuente, control_Fuente_tamano, control_ColorR, control_ColorG, control_ColorB)

                    string_armado += string_control

                Case "System.Windows.Forms.Label"
                    Dim lbl As New Label
                    lbl = control '<-- Es necesario cambiar su tipo de Object a Label, sino no podremos ver sus propiedades como TEXTBOX.
                    control_nombre = lbl.Name
                    control_Pos = lbl.Location
                    control_Fuente = lbl.Font.Name
                    control_Fuente_tamano = lbl.Font.SizeInPoints
                    control_tamano = lbl.Size
                    control_ColorR = lbl.ForeColor.R
                    control_ColorR = lbl.ForeColor.G
                    control_ColorR = lbl.ForeColor.B
                    control_texto = lbl.Text
                    string_control = String.Format("<Label><Name>{0}</Name><X>{1}</X><Y>{2}</Y><SizeW>{3}</SizeW><SizeH>{4}</SizeH><Font><FontName>{5}</FontName><FontSize>{6}</FontSize></Font><Color><Red>{7}</Red><Green>{8}</Green><Blue>{9}</Blue></Color><Texto>{10}</Texto></Label>", control_nombre, control_Pos.X, control_Pos.Y, control_tamano.Width, control_tamano.Height, control_Fuente, control_Fuente_tamano, control_ColorR, control_ColorG, control_ColorB, control_texto)

                    string_armado += string_control
            End Select

        Next


        Return string_armado & "</Controles>"

    End Function


End Class
