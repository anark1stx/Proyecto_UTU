Imports System.Reflection
'TODO LO REFERIDO A LOS COLORES EN ESTE SCRIPT FUE EXTRAIDO DE: https://www.daniweb.com/programming/software-development/code/495380/color-combobox-in-vb
Public Class MsgBoxControlSettings
    Public fuente As Font = SystemFonts.DefaultFont
    Public multilinea As Boolean = False
    Public texto As String = ""
    Public color As Color = New Color
    Dim tamano As Double = 14
    Private Sub MsgBoxControlSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CargarColoresCBWeb()
        Me.CargarColoresCBSistema()

        If cbFuente.Items.Count = 0 Then
            For Each fuente As FontFamily In FontFamily.Families
                cbFuente.Items.Add(fuente.Name.ToString())
            Next
        End If

        If cbTamanoLetra.Items.Count = 0 Then
            For i As Integer = 10 To 24
                cbTamanoLetra.Items.Add(i.ToString())
            Next
        End If

        cbFuente.SelectedIndex = 0 'DEFAULT: Arial
        cbTamanoLetra.SelectedIndex = 4 'DEFAULT: 12
        cbColores.SelectedIndex = 8 'DEFAULT: Black

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        texto = txtIngreseTexto.Text
        Me.txtIngreseTexto.Text = ""
        Me.Hide()
    End Sub

    Private Sub cbColores_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cbColores.DrawItem 'Este evento se activa cada vez que se ingresa un color al combobox.

        If e.Index = -1 Then
            Exit Sub
        End If

        Dim colBrush As Brush = New SolidBrush(Color.FromName(DirectCast(cbColores.Items(e.Index), String)))

        e.Graphics.DrawString(DirectCast(cbColores.Items(e.Index), String), cbColores.Font, Brushes.Black, 35, e.Bounds.Top + 2)

        e.Graphics.DrawRectangle(New Pen(Brushes.Black), e.Bounds.Left + 2, e.Bounds.Top + 2, 30, e.Bounds.Height - 5)
        e.Graphics.FillRectangle(colBrush, e.Bounds.Left + 3, e.Bounds.Top + 3, 29, e.Bounds.Height - 6)

    End Sub

    Public Sub CargarColoresCBWeb()

        cbColores.DrawMode = DrawMode.OwnerDrawFixed

        Dim colType As Type = GetType(System.Drawing.Color)
        For Each prop As PropertyInfo In colType.GetProperties()
            If prop.PropertyType Is GetType(System.Drawing.Color) Then
                cbColores.Items.Add(prop.Name)
            End If
        Next

    End Sub

    Private Sub CargarColoresCBSistema()

        cbColores.DrawMode = DrawMode.OwnerDrawFixed

        Dim sysType As Type = GetType(System.Drawing.SystemColors)
        For Each prop As PropertyInfo In sysType.GetProperties()
            If prop.PropertyType Is GetType(System.Drawing.Color) Then
                cbColores.Items.Add(prop.Name)
            End If
        Next

    End Sub

    Private Sub cbFuente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFuente.SelectedIndexChanged

        fuente = New Font(cbFuente.Text, tamano)
        txtIngreseTexto.Font = fuente
    End Sub

    Private Sub cbTamanoLetra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTamanoLetra.SelectedIndexChanged
        tamano = Val(cbTamanoLetra.SelectedItem.ToString())
        fuente = New Font(cbFuente.Text, tamano)
        txtIngreseTexto.Font = fuente
    End Sub

    Private Sub cbColores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbColores.SelectedIndexChanged
        color = Color.FromName(cbColores.SelectedItem.ToString())
        txtIngreseTexto.ForeColor = color
    End Sub

    Private Sub chkMultilinea_CheckedChanged(sender As Object, e As EventArgs) Handles chkMultilinea.CheckedChanged
        multilinea = chkMultilinea.Checked
    End Sub

    Private Sub chkSoyPregunta_CheckedChanged(sender As Object, e As EventArgs) Handles chkSoyPregunta.CheckedChanged
        If chkSoyPregunta.CheckState = CheckState.Checked Then
            MessageBox.Show("Una vez finalizada la edición de ésta pregunta, recuerde vincularla con el campo que contendrá su respuesta.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class


