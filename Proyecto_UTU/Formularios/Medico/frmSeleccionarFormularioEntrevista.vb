Public Class frmSeleccionarFormularioEntrevista
    Private Sub btnFrmGenerico_Click(sender As Object, e As EventArgs) Handles btnFrmGenerico.Click
        frmMedico.InstanciarFormulario("Generico")
    End Sub

    Private Sub btnFrmDolor_Click(sender As Object, e As EventArgs) Handles btnFrmDolor.Click
        frmMedico.InstanciarFormulario("Dolor")
    End Sub

    Private Sub btnFrmFiebre_Click(sender As Object, e As EventArgs) Handles btnFrmFiebre.Click
        frmMedico.InstanciarFormulario("Fiebre")
    End Sub

    Private Sub btnFrmMalestar_Click(sender As Object, e As EventArgs) Handles btnFrmMalestar.Click
        frmMedico.InstanciarFormulario("Malestar")
    End Sub

    Private Sub btnFrmOtro_Click(sender As Object, e As EventArgs) Handles btnFrmOtro.Click
        frmMedico.InstanciarFormulario("Otro")
    End Sub
End Class