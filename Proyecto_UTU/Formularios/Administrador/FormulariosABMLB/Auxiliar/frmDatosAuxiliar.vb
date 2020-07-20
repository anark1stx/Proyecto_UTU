Public Class frmDatosAuxiliar
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        frmAdministrador.InstanciarFormulario("Gestion", "ModificarAuxiliar")
        'PENDIENTE: ->Cargar en el formulario de modificar paciente todos los valores se hayan cargado en las labels
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        frmAdministrador.solicitarConfirmacion("Baja", "Auxiliar")
    End Sub

End Class