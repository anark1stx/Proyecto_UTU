Public Class frmDatosMedico
    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        frmAdministrador.solicitarConfirmacion("Baja", "Medico")
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        frmAdministrador.InstanciarFormulario("Gestion", "ModificarMedico")
    End Sub
End Class