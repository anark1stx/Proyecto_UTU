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
                MsgBox("Provea una descripcion")
            Else
                '->Guardar formulario + datos en la BD.
                Dim controlesInstanciados = getCtrls(pnlContenedor)
                Console.WriteLine(controlesInstanciados.Count)
                GuardarFormulario(controlesInstanciados)
            End If
        End If
    End Sub

    Public Function getCtrls(pnl As Control) As List(Of Object)

        Dim contenedora As New List(Of List(Of Object))

        Dim list As New List(Of Object)

        For Each c As Control In pnl.Controls
            list.Add(c)
            If TypeOf c Is Panel Or TypeOf c Is TableLayoutPanel Or TypeOf c Is GroupBox Then

                getCtrls(c)
            End If
        Next
        Return list
    End Function

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        hideShowItems(0)
        Imprimir.PrinterSettings.DefaultPageSettings.Margins = New Printing.Margins(0, 0, 0, 0)
        Imprimir.DefaultPageSettings.Margins = New Printing.Margins(0, 0, 0, 0)

        Print(pnlContenedor)

        hideShowItems(1)
        pnlContenedor.AutoScroll = False 'Refrescar el autoScroll, a veces se bugea y queda una scrollbar horizontal glitcheada
        pnlContenedor.AutoScroll = True
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
        pnl.DrawToBitmap(memobmp, New Rectangle(0, 0, pnl.DisplayRectangle.Width, pnl.DisplayRectangle.Height))
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        If memobmp IsNot Nothing Then
            e.Graphics.DrawImage(memobmp, 0, 0)
            MyBase.OnPaint(e)
        End If

    End Sub

    Private Sub Imprimir_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Imprimir.PrintPage

        e.Graphics.DrawImage(memobmp, 0, 0, e.PageBounds.Width, e.PageBounds.Height)
    End Sub
    Sub hideShowItems(_case As Boolean)

        btnImprimir.Visible = _case
        btnGuardar.Visible = _case
        btnLimpiar.Visible = _case
    End Sub

    Sub pintarFondo(ctrl As Control, selected As Boolean)

        If selected Then
            ctrl.BackColor = Color.FromArgb(m_Rnd.Next(0, 256), m_Rnd.Next(0, 256), m_Rnd.Next(0, 256))
        Else
            ctrl.BackColor = Color.LightBlue

        End If

    End Sub

    Sub mLoad() Handles Me.Load
        tbDescripcion.Anchor += AnchorStyles.Right
        tbTorso_Dorso.Anchor += AnchorStyles.Right
    End Sub

End Class