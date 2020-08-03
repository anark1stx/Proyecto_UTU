Imports System.Drawing.Printing

Public Class frmGenericoTest
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


    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        hideShowItems(0)

        Print(pnlContenedor)

        hideShowItems(1)
        'pnlContenedor.Dock = DockStyle.None

        'Imprimir.DefaultPageSettings.Landscape = True
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
        Dim pagearea2 As Rectangle = e.PageBounds

        pagearea2.Width = (pagearea.Width / 2) - (Me.pnlContenedor.Width / 2)


        e.Graphics.DrawImage(memobmp, pagearea2.Width, Me.pnlContenedor.Location.Y)
    End Sub

    Public Sub Print(pnl As Panel)
        tmpPanel = pnl
        Imprimir.DefaultPageSettings.Landscape = True
        getPrintArea(pnl)

        PrintPreviewDialog1.Document = Imprimir

        PrintPreviewDialog1.ShowDialog()

    End Sub



    Private Sub frmGenericoTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
    End Sub
End Class