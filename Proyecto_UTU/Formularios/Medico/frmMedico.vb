Public Class frmMedico
    Private Sub frmMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GestiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónToolStripMenuItem.Click
        'Cargar Formulario de gestión para el médico.
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        'Cargar formulario de consulta con el paciente.
        Dim frmConsulta As New frmConsultaConPaciente
        frmConsulta.TopLevel = False
        frmConsulta.TopMost = True
        Me.pnlContenedorFormularios.Controls.Add(frmConsulta)
        frmConsulta.Show()

    End Sub
End Class