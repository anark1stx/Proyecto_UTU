Public Class frmInicio
    Private Sub btnGestion_Click(sender As Object, e As EventArgs) Handles btnGestion.Click
        frmMedico.InstanciarFormulario("Gestion")
    End Sub

    Private Sub btnAtenderPaciente_Click(sender As Object, e As EventArgs) Handles btnAtenderPaciente.Click
        frmMedico.InstanciarFormulario("Atender")
    End Sub

    Private Sub btnCrearFormulario_Click(sender As Object, e As EventArgs) Handles btnCrearFormulario.Click
        frmMedico.InstanciarFormulario("CrearFormulario")
    End Sub

    Private Sub btnEditarFormulario_Click(sender As Object, e As EventArgs) Handles btnEditarFormulario.Click
        frmMedico.InstanciarFormulario("EditarFormulario")

        'Activar evento de abrir formulario (el boton de la carpetita)
    End Sub

End Class