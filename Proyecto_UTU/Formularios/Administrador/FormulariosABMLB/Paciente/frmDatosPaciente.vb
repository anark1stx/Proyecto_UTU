Public Class frmDatosPaciente
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        frmAdministrador.InstanciarFormulario("Gestion", "ModificarPaciente")
        'PENDIENTE: ->Cargar en el formulario de modificar paciente todos los valores se hayan cargado en las labels
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        frmAdministrador.SolicitarConfirmacion("Baja", "Paciente")
    End Sub
End Class