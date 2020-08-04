Public Class frmDolor
    Dim memobmp As Bitmap
    Dim tmpPanel As Panel
    Private m_Rnd As New Random
    Public Sub AgregarItemALista(item As String, lista As ListBox, btn As Button)
        If Not lista.Items.Contains(item) Then
            lista.Items.Add(item)
            pintarFondo(btn, True)
        Else
            lista.Items.Remove(item)
            pintarFondo(btn, False)
        End If

    End Sub
    Private Sub btnCabezaDer_Click(sender As Object, e As EventArgs) Handles btnCabezaDer.Click
        AgregarItemALista("Cabeza Derecha", lbTorso, btnCabezaDer)

    End Sub
    Private Sub btnCabezaIzq_Click(sender As Object, e As EventArgs) Handles btnCabezaIzq.Click
        AgregarItemALista("Cabeza Izquierda", lbTorso, btnCabezaIzq)
    End Sub

    Private Sub btnHombroIzq_Click(sender As Object, e As EventArgs) Handles btnHombroIzq.Click
        AgregarItemALista("Hombro Izquierdo", lbTorso, btnHombroIzq)
    End Sub

    Private Sub btnBrazoIzq_Click(sender As Object, e As EventArgs) Handles btnBrazoIzq.Click
        AgregarItemALista("Brazo Izquierdo", lbTorso, btnBrazoIzq)
    End Sub

    Private Sub btnManoIzq_Click(sender As Object, e As EventArgs) Handles btnManoIzq.Click
        AgregarItemALista("Mano Izquierda", lbTorso, btnManoIzq)
    End Sub

    Private Sub btnPechoIzq_Click(sender As Object, e As EventArgs) Handles btnPechoIzq.Click
        AgregarItemALista("Pecho Izquierdo", lbTorso, btnPechoIzq)
    End Sub

    Private Sub btnAbdominalIzq_Click(sender As Object, e As EventArgs) Handles btnAbdominalIzq.Click
        AgregarItemALista("Zona Abdominal Izquierda", lbTorso, btnAbdominalIzq)
    End Sub

    Private Sub btnPiernaIzq_Click(sender As Object, e As EventArgs) Handles btnPiernaIzq.Click
        AgregarItemALista("Pierna Izquierda", lbTorso, btnPiernaIzq)
    End Sub

    Private Sub btnHombroDer_Click(sender As Object, e As EventArgs) Handles btnHombroDer.Click
        AgregarItemALista("Hombro Derecho", lbTorso, btnHombroDer)
    End Sub

    Private Sub btnBrazoDer_Click(sender As Object, e As EventArgs) Handles btnBrazoDer.Click
        AgregarItemALista("Brazo Derecho", lbTorso, btnBrazoDer)
    End Sub

    Private Sub btnManoDer_Click(sender As Object, e As EventArgs) Handles btnManoDer.Click
        AgregarItemALista("Mano Derecha", lbTorso, btnManoDer)
    End Sub

    Private Sub btnPechoDer_Click(sender As Object, e As EventArgs) Handles btnPechoDer.Click
        AgregarItemALista("Pecho Derecho", lbTorso, btnPechoDer)
    End Sub

    Private Sub btnAbdominalDer_Click(sender As Object, e As EventArgs) Handles btnAbdominalDer.Click
        AgregarItemALista("Zona Abdominal Derecha", lbTorso, btnAbdominalDer)
    End Sub

    Private Sub btnPiernaDer_Click(sender As Object, e As EventArgs) Handles btnPiernaDer.Click
        AgregarItemALista("Pierna Derecha", lbTorso, btnPiernaDer)
    End Sub

    Private Sub btnCuello_Click(sender As Object, e As EventArgs) Handles btnCuello.Click
        AgregarItemALista("Cuello", lbTorso, btnCuello)
    End Sub

    Private Sub btnCabezaIzqBack_Click(sender As Object, e As EventArgs) Handles btnCabezaIzqBack.Click
        AgregarItemALista("Cabeza Izquierda", lbDorso, btnCabezaIzqBack)
    End Sub

    Private Sub btnCabezaDerBack_Click(sender As Object, e As EventArgs) Handles btnCabezaDerBack.Click
        AgregarItemALista("Cabeza Derecha", lbDorso, btnCabezaDerBack)
    End Sub

    Private Sub btnCervicales_Click(sender As Object, e As EventArgs) Handles btnCervicales.Click
        AgregarItemALista("Cervicales", lbDorso, btnCervicales)
    End Sub

    Private Sub btnColDorsalIzq_Click(sender As Object, e As EventArgs) Handles btnColDorsalIzq.Click
        AgregarItemALista("Columna Dorsal Izquierda", lbDorso, btnColDorsalIzq)
    End Sub

    Private Sub btnColDorsalDer_Click(sender As Object, e As EventArgs) Handles btnColDorsalDer.Click
        AgregarItemALista("Columna Dorsal Derecha", lbDorso, btnColDorsalDer)
    End Sub

    Private Sub btnColLumbarIzq_Click(sender As Object, e As EventArgs) Handles btnColLumbarIzq.Click
        AgregarItemALista("Columna Lumbar Izquierda", lbDorso, btnColLumbarIzq)
    End Sub

    Private Sub btnColLumbarDer_Click(sender As Object, e As EventArgs) Handles btnColLumbarDer.Click
        AgregarItemALista("Columna Lumbar Derecha", lbDorso, btnColLumbarDer)
    End Sub

    Private Sub btnOmoplatoIzq_Click(sender As Object, e As EventArgs) Handles btnOmoplatoIzq.Click
        AgregarItemALista("Omoplato Izquierdo", lbDorso, btnOmoplatoIzq)
    End Sub

    Private Sub btnOmoplatoDer_Click(sender As Object, e As EventArgs) Handles btnOmoplatoDer.Click
        AgregarItemALista("Omoplato Derecho", lbDorso, btnOmoplatoDer)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        lbDorso.Items.Clear()
        lbTorso.Items.Clear()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If lbTorso.Items.Count < 1 AndAlso lbDorso.Items.Count < 1 Then
            MsgBox("Seleccione al menos una parte del cuerpo para guardar la información.", vbExclamation)
        Else
            If txtDescripcion.TextLength < 5 Then
                Dim ans = MessageBox.Show("¿Seguro que desea guardar sin haber proveido una descripción detallada?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If ans = vbYes Then
                    '->Guardar formulario + datos en la BD.
                    ans = MessageBox.Show("¿Desea volver al Inicio?", "Guardado con éxito.", MessageBoxButtons.YesNo, MessageBoxIcon.None)
                    If ans = vbYes Then
                        frmMedico.InstanciarFormulario("Inicio")
                    End If
                Else
                    '->Guardar formulario + datos en la BD.
                    ans = MessageBox.Show("¿Desea volver al Inicio?", "Guardado con éxito.", MessageBoxButtons.YesNo, MessageBoxIcon.None)
                    If ans = vbYes Then
                        frmMedico.InstanciarFormulario("Inicio")
                    End If
                End If
            End If
        End If
    End Sub


    Public Sub Print(pnl As Panel)
        tmpPanel = pnl
        Imprimir.DefaultPageSettings.Landscape = True
        getPrintArea(pnl)

        PrintPreviewDialog1.Document = Imprimir
        PrintPreviewDialog1.ShowDialog()
        'Imprimir.Print()

    End Sub

    Public Sub getPrintArea(pnl As Panel)
        memobmp = New Bitmap(pnl.Width, pnl.Height)
        pnl.DrawToBitmap(memobmp, New Rectangle(0, 0, pnl.Width, pnl.Height))
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        If memobmp IsNot Nothing Then
            e.Graphics.DrawImage(memobmp, 0, 0)
            MyBase.OnPaint(e)
        End If

    End Sub


    Private Sub Imprimir_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Imprimir.PrintPage

        Dim pagearea As Rectangle = e.PageBounds
        Dim _fixedpagearea2 As Rectangle = e.PageBounds 'Este rectangulo es para corregir el offset entre la ubicacion del panel y la del formulario en si

        _fixedpagearea2.Width = (pagearea.Width / 2) - (Me.pnlContenedor.Width / 2)


        e.Graphics.DrawImage(memobmp, _fixedpagearea2.Width, Me.pnlContenedor.Location.Y)
    End Sub

    Sub hideShowItems(_case As Boolean)

        For Each c As Control In pnlContenedor.Controls
            If TypeOf c Is Button Then
                c.Visible = _case
            End If

        Next
    End Sub

    Sub pintarFondo(ctrl As Control, selected As Boolean)

        If selected Then
            ctrl.BackColor = Color.FromArgb(m_Rnd.Next(0, 256), m_Rnd.Next(0, 256), m_Rnd.Next(0, 256))
        Else
            ctrl.BackColor = Color.LightBlue

        End If


        'If selected Then
        '    ctrl.BackColor = Color.DarkOrange
        'Else
        '    ctrl.BackColor = Color.LightBlue
        'End If

    End Sub


    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        hideShowItems(0)

        Print(pnlContenedor)

        hideShowItems(1)
    End Sub
End Class