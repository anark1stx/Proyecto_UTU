Imports Entidades
Public Class frmMalestar
    Dim memobmp As Bitmap
    Dim Acciones As New AccionesFormulario
    Protected _paciente As E_Paciente
    Protected _medico As E_Medico

    Property Paciente As E_Paciente
        Get
            Return _paciente
        End Get
        Set(value As E_Paciente)
            _paciente = value
        End Set
    End Property

    Property Medico As E_Medico
        Get
            Return _medico
        End Get
        Set(value As E_Medico)
            _medico = value
        End Set
    End Property
    Sub agregarH_accionesFormulario()
        AddHandler Acciones.btnImprimir.Click, AddressOf btnImprimir_Click
        AddHandler Acciones.btnLimpiar.Click, AddressOf btnLimpiar_Click
        AddHandler Acciones.btnGuardar.Click, AddressOf btnGuardar_Click
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

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs)
        LimpiarControles(Me)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs)
        hideShowItems(False, New List(Of Control)(New Control() {Acciones}))

        pnlContenedor.AutoScroll = False
        memobmp = ImprimirFormulario(Imprimir, True, pnlContenedor, New Rectangle(0, 0, pnlContenedor.DisplayRectangle.Width, pnlContenedor.Height))
        PrintPreviewDialog1.Document = Imprimir
        pnlContenedor.AutoScroll = True
        PrintPreviewDialog1.ShowDialog()

        hideShowItems(True, New List(Of Control)(New Control() {Acciones}))

    End Sub

    Private Sub Imprimir_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Imprimir.PrintPage
        e.Graphics.DrawImage(memobmp, 0, 0, e.PageBounds.Width, e.PageBounds.Height)
    End Sub

    Private Sub mLoad() Handles MyBase.Load
        Acciones.TopLevel = False
        Acciones.TopMost = True
        pnlContenedor.Controls.Add(Acciones)
        Acciones.Location = New Point(pnlContenedor.Width / 2, pnlContenedor.Height + Acciones.Height * 2.5)
        Acciones.Visible = True
        agregarH_accionesFormulario()
    End Sub

End Class