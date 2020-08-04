Public Class frmMalestar
    Dim memobmp As Bitmap
    Dim tmpPanel As Panel
    Sub hideShowItems(_case As Boolean)

        btnPredictivo.Visible = _case
        For Each c As Control In pnlContenedor.Controls
            If TypeOf c Is Button Then
                c.Visible = _case
            End If

        Next
    End Sub
    Private Sub chkAnalisis_CheckedChanged(sender As Object, e As EventArgs) Handles chkAnalisis.CheckedChanged
        If chkAnalisis.Checked Then
            txtNomAnalisis.Enabled = True
        Else
            txtNomAnalisis.Enabled = False
        End If
    End Sub

    Private Sub chkSemanas_CheckedChanged(sender As Object, e As EventArgs) Handles chkSemanas.Click
        chkMeses.Checked = False
    End Sub

    Private Sub chkMeses_CheckedChanged(sender As Object, e As EventArgs) Handles chkMeses.Click
        chkSemanas.Checked = False
    End Sub

    Private Sub chkConstante_CheckedChanged(sender As Object, e As EventArgs) Handles chkConstante.Click
        chkEpisodico.Checked = False
    End Sub
    Private Sub chkEpisodico_CheckedChanged(sender As Object, e As EventArgs) Handles chkEpisodico.Click
        chkConstante.Checked = False
    End Sub

    Private Sub chkADiarias_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkADiarias_Si.Click
        chkADiarias_No.Checked = False
    End Sub

    Private Sub chkADiarias_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkADiarias_No.Click
        chkADiarias_Si.Checked = False
    End Sub

    Private Sub chkViaje_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkViaje_Si.Click
        chkViaje_No.Checked = False
    End Sub

    Private Sub chkViaje_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkViaje_No.Click
        chkViaje_Si.Checked = False
    End Sub

    Private Sub chkDrugs_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkDrugs_Si.Click
        chkDrugs_No.Checked = False
    End Sub

    Private Sub chkDrugs_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkDrugs_No.Click
        chkDrugs_Si.Checked = False
    End Sub

    Private Sub chkCambioDieta_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkCambioDieta_Si.Click
        chkCambioDieta_No.Checked = False
    End Sub

    Private Sub chkCambioDieta_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkCambioDieta_No.Click
        chkCambioDieta_Si.Checked = False
    End Sub

    Private Sub chkT_Sens_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkT_Sens_Si.Click
        chkT_Sens_No.Checked = False
    End Sub

    Private Sub chkT_Sens_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkT_Sens_No.Click
        chkT_Sens_Si.Checked = False
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        For Each ctrls In pnlContenedor.Controls
            If TypeOf ctrls Is GroupBox Then
                For Each c2 As Control In ctrls.Controls

                    If TypeOf c2 Is TableLayoutPanel Then
                        LimpiarControles(c2)
                    End If

                Next
            End If
        Next

        LimpiarControles(gbResolucion)
        LimpiarControles(gbTratamiento)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        '->GuardarEnBD()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        hideShowItems(0)

        Print(pnlContenedor)

        hideShowItems(1)
    End Sub

    Public Sub Print(pnl As Panel)
        tmpPanel = pnl
        Imprimir.DefaultPageSettings.Landscape = True
        getPrintArea(pnl)
        Imprimir.Print()

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
End Class