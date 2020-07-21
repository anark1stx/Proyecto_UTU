Public Class GestorXML
    Public encabezado As String = "<?xml version='1.0' encoding='UTF-8' standalone='yes' ?><Controles>"
    Public Function guardarXML(listaControles As List(Of Object)) As String 'Retornar un string XML entero con todos los datos.
        Dim string_armado As String = encabezado
        Dim string_control As String = ""

        Dim control_nombre As String = ""
        Dim control_texto As String = ""
        Dim control_Pos As Point = New Point(0, 0)
        Dim control_Fuente As Font = SystemFonts.DefaultFont
        Dim control_tamano As Size = New Size(0, 0)

        For Each control In listaControles

            Select Case control.GetType().ToString()
                Case "System.Windows.Forms.TextBox"
                    Dim txt As New TextBox
                    txt = control '<-- Es necesario cambiar su tipo de Object a TextBox, sino no podremos ver sus propiedades como TEXTBOX.
                    control_nombre = txt.Name
                    control_texto = txt.Text
                    control_Pos = txt.Location
                    control_Fuente = txt.Font
                    control_tamano = txt.Size()

                    Console.WriteLine("IM A TEXTBOX ")

                    string_control = String.Format("<TextBox><x>{0}</x><y>{1}</y><Name>{2}</Name></TextBox>", control_Pos.X, control_Pos.Y, control_nombre)

                    string_armado += string_control

                Case "System.Windows.Forms.Label"
                    Console.WriteLine("IM A Label")
            End Select

        Next


        Return string_armado & "</Controles>"

    End Function


End Class
