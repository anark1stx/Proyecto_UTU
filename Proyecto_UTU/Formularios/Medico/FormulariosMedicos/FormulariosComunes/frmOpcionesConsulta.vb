Public Class frmOpcionesConsulta
    Private Sub btnIdentificacion_Click(sender As Object, e As EventArgs) Handles btnIdentificacion.Click
        frmMedico.InstanciarFormulario("Identificacion")
    End Sub

    Private Sub btnEntrevistaPaciente_Click(sender As Object, e As EventArgs) Handles btnEntrevistaPaciente.Click

        frmMedico.InstanciarFormulario("Entrevista")
    End Sub
End Class