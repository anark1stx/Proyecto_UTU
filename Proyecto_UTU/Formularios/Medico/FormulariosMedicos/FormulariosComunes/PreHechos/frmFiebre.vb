Public Class frmFiebre
    Dim memobmp As Bitmap
    Dim tmpPanel As Panel
    Sub hideShowItems(_case As Boolean)


        For Each c As Control In pnlContenedor.Controls
            If TypeOf c Is Button Then
                c.Visible = _case
            End If

        Next
    End Sub
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

        For Each c As Control In Me.Controls

            If TypeOf c Is GroupBox Then

                For Each c2 As Control In c.Controls

                    If TypeOf c2 Is TableLayoutPanel Then

                        For Each c3 As Control In c2.Controls

                            If TypeOf c3 Is CheckBox Then

                                DirectCast(c3, CheckBox).CheckState = CheckState.Unchecked

                            End If

                            If TypeOf c3 Is TextBox Then

                                DirectCast(c3, TextBox).Text = String.Empty

                            End If

                            If TypeOf c3 Is ComboBox Then

                                DirectCast(c3, ComboBox).Text = String.Empty

                            End If

                        Next

                    End If

                Next


            End If

        Next
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

        pp.Document = Imprimir
        pp.ShowDialog()
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

    End Sub

End Class