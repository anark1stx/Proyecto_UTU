Public Class frmInicioPaciente
    Private Sub frmLoad() Handles MyBase.Load
        Me.Dock = DockStyle.Fill
    End Sub

    Private Sub btnGestion_Click(sender As Object, e As EventArgs) Handles btnGestion.Click
        frmPaciente.InstanciarFormulario("Gestion")
    End Sub

    Private Sub btnDiagnosticos_Click(sender As Object, e As EventArgs) Handles btnDiagnosticos.Click
        frmPaciente.InstanciarFormulario("Diagnostico")
    End Sub

    Private Sub btnAnalisis_Click(sender As Object, e As EventArgs) Handles btnAnalisis.Click
        frmPaciente.InstanciarFormulario("Analisis")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        frmPaciente.SalirToolStripMenuItem_Click(sender, e)
    End Sub
End Class