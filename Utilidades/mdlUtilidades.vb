Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Public Module mdlUtilidades
    Sub setLabelText(lbl As Label, msg As String)
        lbl.Text = msg
        lbl.Visible = True
    End Sub
    Sub hidelbl(lbl As Label) 'Este método esconde los mensajes de error.
        lbl.Visible = False
    End Sub
    Sub cambiarElementosCBox(cbox As ComboBox, listaElementos As List(Of String))
        cbox.Items.Clear() 'Limpiamos todos los elementos que estaban
        For i As Integer = 0 To listaElementos.Count - 1
            cbox.Items.Add(listaElementos(i)) 'Añadir el elemento al combobox
        Next

    End Sub
    Function subirImagen() As String

        Dim OFD As FileDialog = New OpenFileDialog With {
                .Filter = "Imagen (*.jpg;*.png)|*.jpg;*.png",
                .Title = "Elegir imagen",
                .RestoreDirectory = True,
                .Multiselect = False
        }

        If OFD.ShowDialog() = DialogResult.OK Then
            Return OFD.FileName
        Else
            Return Nothing
        End If

    End Function


    Public Function RemoverEspacios(str As String) As String
        Return str.Trim()
    End Function

    Public Sub LimpiarControles(contenedor As Control)
        For Each control As Control In contenedor.Controls

            If Not control.Tag Is "noLimpiar" Then
                Select Case control.GetType().ToString().Replace("System.Windows.Forms.", "")

                    Case "TextBox"
                        Dim txt = DirectCast(control, TextBox)
                        txt.Text = String.Empty
                        txt.DataBindings.Clear()
                    Case "MaskedTextBox"
                        Dim txt = DirectCast(control, MaskedTextBox)
                        txt.Text = String.Empty
                        txt.DataBindings.Clear()
                    Case "ComboBox"
                        Dim cbox = DirectCast(control, ComboBox)

                        If cbox.Tag Is "datos" Then
                            cbox.DataSource = Nothing
                            If cbox.DropDownStyle = ComboBoxStyle.DropDown Then
                                cbox.ResetText()
                                cbox.Items.Clear()
                            End If
                            cbox.SelectedItem = Nothing
                        End If

                    Case "DataGridView"
                        Dim dgw = DirectCast(control, DataGridView)
                        dgw.DataSource = Nothing
                        dgw.Rows.Clear()
                        dgw.Refresh()
                    Case "CheckBox"
                        Dim chk = DirectCast(control, CheckBox)
                        chk.Checked = False

                    Case "PictureBox"
                        Dim pbox = DirectCast(control, PictureBox)
                        pbox.DataBindings.Clear()
                        pbox.Image = Nothing
                        pbox.ImageLocation = Nothing

                    Case "DateTimePicker"
                        Dim dtp = DirectCast(control, DateTimePicker)
                        dtp.Value = Today
                        dtp.DataBindings.Clear()
                    Case "ListBox"
                        Dim lb = DirectCast(control, ListBox)
                        lb.Items.Clear()

                    Case "Label"
                        Dim lbl = DirectCast(control, Label)

                        If lbl.Tag Is "datos" Then 'Esto es para limpiar solo las labels en las que le cambio su texto original por los datos que llegan de la BD.
                            lbl.ResetText()
                            lbl.DataBindings.Clear()
                        End If
                    Case "Button"
                        Dim btn = DirectCast(control, Button)

                        If btn.Tag Is "datos" Then
                            btn.BackColor = Nothing
                        End If

                    Case "Panel", "GroupBox", "TableLayoutPanel"
                        LimpiarControles(control) 'RECURSIVA
                End Select
            End If
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
        Console.WriteLine(ms.Length)
        Return Image.FromStream(ms)

    End Function

    Public Function Image2Bytes(ByVal img As Image) As Byte()
        If img Is Nothing Then
            Return {}
        End If
        Dim ms = New MemoryStream()
        img.Save(ms, Imaging.ImageFormat.Jpeg)
        Dim bytes = ms.ToArray()
        ms.Close()
        Return bytes

    End Function

End Module