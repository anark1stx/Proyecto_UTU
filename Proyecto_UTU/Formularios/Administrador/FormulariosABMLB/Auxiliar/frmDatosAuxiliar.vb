Public Class frmDatosAuxiliar
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        frmAdministrador.InstanciarFormulario("Gestion", "ModificarAuxiliar")
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        frmAdministrador.solicitarConfirmacion("Baja", "Auxiliar")
    End Sub

End Class