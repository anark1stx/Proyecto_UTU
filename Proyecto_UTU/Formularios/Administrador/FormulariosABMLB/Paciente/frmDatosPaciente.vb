Public Class frmDatosPaciente
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        frmAdministrador.InstanciarFormulario("Gestion", "ModificarPaciente")
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        frmAdministrador.SolicitarConfirmacion("Baja", "Paciente")
    End Sub
End Class