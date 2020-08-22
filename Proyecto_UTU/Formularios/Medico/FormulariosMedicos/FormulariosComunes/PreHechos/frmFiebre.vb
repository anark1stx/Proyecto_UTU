Public Class frmFiebre
    Dim memobmp As Bitmap
    Private Sub frmFiebre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
    End Sub

    Private Sub chkAnalisis_CheckedChanged(sender As Object, e As EventArgs) Handles chkAnalisis.CheckedChanged
        If chkAnalisis.Checked Then
            txtNomAnalisis.Enabled = True
        Else
            txtNomAnalisis.Enabled = False
        End If
    End Sub

    Private Sub chkSiD_Ap_Click(sender As Object, e As EventArgs) Handles chkSiD_Ap.Click
        chkNoD_Ap.Checked = False
    End Sub

    Private Sub chkNoD_Ap_Click(sender As Object, e As EventArgs) Handles chkNoD_Ap.Click
        chkSiD_Ap.Checked = False
    End Sub

    Private Sub chkD_Resp_Si_Click(sender As Object, e As EventArgs) Handles chkD_Resp_Si.Click
        chkD_Resp_No.Checked = False
    End Sub

    Private Sub chkD_Resp_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkD_Resp_No.Click
        chkD_Resp_Si.Checked = False
    End Sub

    Private Sub chkMeds_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkMeds_Si.Click
        chkMeds_No.Checked = False
    End Sub

    Private Sub chkMeds_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkMeds_No.Click
        chkMeds_Si.Checked = False
    End Sub

    Private Sub chkCalor_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkCalor_Si.Click
        chkCalor_No.Checked = False
    End Sub

    Private Sub chkCalor_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkCalor_No.Click
        chkCalor_Si.Checked = False
    End Sub

    Private Sub chkErups_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkErups_Si.Click
        chkErups_No.Checked = False
    End Sub

    Private Sub chkErups_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkErups_No.Click
        chkErups_Si.Checked = False
    End Sub

    Private Sub chkVacs_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkVacs_Si.Click
        chkVacs_No.Checked = False
    End Sub

    Private Sub chkVacs_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkVacs_No.Click
        chkVacs_Si.Checked = False
    End Sub

    Private Sub chkT_Digs_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkT_Digs_Si.Click
        chkT_Digs_No.Checked = False
    End Sub

    Private Sub chkT_Digs_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkT_Digs_No.Click
        chkT_Digs_Si.Checked = False
    End Sub

    Private Sub chkT_Hums_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkT_Hums_Si.Click
        chkT_Hums_No.Checked = False
    End Sub

    Private Sub chkT_Hums_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkT_Hums_No.Click
        chkT_Hums_Si.Checked = False
    End Sub

    Private Sub chkT_Sens_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkT_Sens_Si.Click
        chkT_Sens_No.Checked = False
    End Sub

    Private Sub chkT_Sens_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkT_Sens_No.Click
        chkT_Sens_Si.Checked = False
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarControles(Me)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim fbr As New FabricaDeControles

        Dim lista As New List(Of Control)(getCtrls(Me))
        GuardarFormulario(fbr.Serializar(lista))

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        hideShowItems(False, New List(Of Control)(New Control() {btnLimpiar, btnImprimir, btnGuardar}))
        pnlContenedor.AutoScroll = False
        memobmp = ImprimirFormulario(Imprimir, True, pnlContenedor, New Rectangle(0, 0, pnlContenedor.DisplayRectangle.Width, pnlContenedor.Height))
        'PrintPreviewDialog1.Document = Imprimir
        pnlContenedor.AutoScroll = True
        'PrintPreviewDialog1.ShowDialog()

        'Refrescar el autoScroll, a veces se bugea y queda una scrollbar horizontal glitcheada

        hideShowItems(True, New List(Of Control)(New Control() {btnLimpiar, btnImprimir, btnGuardar}))

    End Sub

    Private Sub Imprimir_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Imprimir.PrintPage

        e.Graphics.DrawImage(memobmp, 0, 0, e.PageBounds.Width, e.PageBounds.Height)
    End Sub
End Class