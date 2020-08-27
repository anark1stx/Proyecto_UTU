Imports System.IO

Module mdlUtilidades

    Public Function ImportarFormulario() As List(Of Control)

        Dim abrirFormulario As New OpenFileDialog With { 'Sustituir esto por un catalogo con los formularios que hay en la BD.
            .Filter = "XML|*.xml",
            .Title = "Abrir Formulario",
            .RestoreDirectory = True
        }

        If abrirFormulario.ShowDialog() = DialogResult.OK Then
            Dim path As String = System.IO.Path.GetFullPath(abrirFormulario.FileName.ToString())
            Dim contenido As String = File.ReadAllText(path)
            Dim gestor As New GestorXMLv2
            Dim fbr As New FabricaDeControles()
            Dim lista = gestor.Deserializar(Of ControlesGuardados.ListaControles)(contenido)

            Return fbr.Crear(lista)
        Else
            Return Nothing
        End If

    End Function

    Public Sub GuardarFormulario(lista_controles As ControlesGuardados.ListaControles)

        Dim archivo As New Xml.XmlDocument
        Dim gestor As New GestorXMLv2

        Dim xmlstring As String = gestor.Serializar(lista_controles)
        archivo.LoadXml(xmlstring)

        Dim guardarFormulario As New SaveFileDialog
        guardarFormulario.Filter = "XML|*.xml"
        guardarFormulario.Title = "Guardar Formulario"
        guardarFormulario.RestoreDirectory = True

        If guardarFormulario.ShowDialog() = DialogResult.OK Then
            Dim path As String = System.IO.Path.GetFullPath(guardarFormulario.FileName.ToString())
            archivo.Save(path)
        End If

    End Sub

    Public Function RemoverEspacios(str As String) As String
        Return str.Trim()
    End Function

    Public Sub LimpiarControles(contenedor As Control)
        For Each control As Control In contenedor.Controls

            If control.Tag Is "noLimpiar" Then
                Exit Sub
            End If

            Select Case control.GetType().ToString().Replace("System.Windows.Forms.", "")

                Case "TextBox"
                    Dim txt = DirectCast(control, TextBox)
                    txt.Text = String.Empty

                Case "ComboBox"
                    Dim cbox = DirectCast(control, ComboBox)

                    If cbox.DropDownStyle = ComboBoxStyle.DropDown Then
                        control.ResetText()
                    End If
                    cbox.SelectedItem = Nothing

                Case "CheckBox"
                    Dim chk = DirectCast(control, CheckBox)
                    If chk.Checked Then
                        Console.WriteLine("checked")
                        chk.Checked = False
                    Else
                        Console.WriteLine("not checked")
                    End If

                Case "PictureBox"
                    Dim pbox = DirectCast(control, PictureBox)
                    pbox.Image = Nothing

                Case "DateTimePicker"
                    Dim dtp = DirectCast(control, DateTimePicker)
                    dtp.Value = Today

                Case "ListBox"
                    Dim lb = DirectCast(control, ListBox)
                    lb.Items.Clear()

                Case "Label"
                    Dim lbl = DirectCast(control, Label)

                    If lbl.Tag Is "datos" Then 'Esto es para limpiar solo las labels en las que le cambio su texto original por los datos que llegan de la BD.
                        lbl.ResetText()
                    End If

                Case "Button"
                    Dim btn = DirectCast(control, Button)

                    If btn.Tag Is "datos" Then
                        btn.BackColor = Nothing
                    End If

                Case "Panel", "GroupBox", "TableLayoutPanel"
                    LimpiarControles(control) 'RECURSIVA
            End Select
        Next
    End Sub

    Public Function ImprimirFormulario(pd As Printing.PrintDocument, landscape As Boolean, contenedor As Control, rect As Rectangle) As Bitmap

        pd.DefaultPageSettings.Landscape = landscape

        Dim memobmp = New Bitmap(contenedor.Width, contenedor.Height)

        contenedor.DrawToBitmap(memobmp, rect)

        Return memobmp
    End Function

    Public Sub pintarFondo(ctrl As Control, selected As Boolean)

        If selected Then
            ctrl.BackColor = pickRandomColor()
        Else
            ctrl.BackColor = Color.LightBlue

        End If

    End Sub

    Public Function pickRandomColor() As Color
        Dim m_Rnd As New Random
        Return Color.FromArgb(m_Rnd.Next(0, 256), m_Rnd.Next(0, 256), m_Rnd.Next(0, 256))
    End Function

    Public Sub AgregarItemALista(item As String, lista As ListBox, Optional btn As Button = Nothing) 'btn es porque en el frmDolor (unico formulario el cual usa esta funcion por ahora), pinta el fondo de los botones cuando estos son seleccionados.

        If Not lista.Items.Contains(item) Then
            lista.Items.Add(item)
            If btn IsNot Nothing Then
                pintarFondo(btn, True)
            End If

        Else
            lista.Items.Remove(item)

            If btn IsNot Nothing Then
                pintarFondo(btn, False)
            End If

        End If

    End Sub

    Public Function getCtrls(pnl As Control) As List(Of Control)

        Dim list As New List(Of Control)

        For Each c As Control In pnl.Controls
            list.Add(c)
            If TypeOf c Is Panel Or TypeOf c Is TableLayoutPanel Or TypeOf c Is GroupBox Then
                getCtrls(c)
            End If
        Next
        Return list
    End Function

    Sub DibujarBorde(control As Control, gr As Graphics, Optional pairColor As Color = Nothing)
        Dim r As New Rectangle(control.Location.X, control.Location.Y, control.Width, control.Height)

        r.Inflate(4, 4)
        gr.DrawRectangle(New Pen(pickRandomColor()), r)
    End Sub

    Sub hideShowItems(_case As Boolean, ctrls As List(Of Control))

        For Each c As Control In ctrls
            c.Visible = _case
        Next

    End Sub

    Public Function Bytes2Image(ByVal bytes() As Byte) As Image

        Dim ms As New MemoryStream(bytes)
        Return Image.FromStream(ms)

    End Function

    Function ColorTOHTML(col As Color) As String 'XMLSerializer no puede guardar System.Drawing.Color

        Return ColorTranslator.ToHtml(col)

    End Function

    Function HTMLTOColor(col As String) As Color
        Return ColorTranslator.FromHtml(col)
    End Function


End Module