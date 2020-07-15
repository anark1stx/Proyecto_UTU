Public Class frmInicioAdministrador
    Private Sub btnAltaMedico_Click(sender As Object, e As EventArgs) Handles btnAltaMedico.Click
        frmAdministrador.InstanciarFormulario("Gestion", "AltaMedico")
    End Sub

    Private Sub btnBajaMedico_Click(sender As Object, e As EventArgs) Handles btnBajaMedico.Click
        frmAdministrador.InstanciarFormulario("Gestion", "BajaMedico")
    End Sub

    Private Sub btnModificacionMedico_Click(sender As Object, e As EventArgs) Handles btnModificacionMedico.Click
        frmAdministrador.InstanciarFormulario("Gestion", "ModificarMedico")
    End Sub

    Private Sub btnBusquedaMedico_Click(sender As Object, e As EventArgs) Handles btnBusquedaMedico.Click
        frmAdministrador.InstanciarFormulario("Gestion", "DatosMedico")
    End Sub

    Private Sub btnAltaPaciente_Click(sender As Object, e As EventArgs) Handles btnAltaPaciente.Click
        frmAdministrador.InstanciarFormulario("Gestion", "AltaPaciente")
    End Sub

    Private Sub btnBajaPaciente_Click(sender As Object, e As EventArgs) Handles btnBajaPaciente.Click
        frmAdministrador.InstanciarFormulario("Gestion", "BajaPaciente")
    End Sub

    Private Sub btnModificarPaciente_Click(sender As Object, e As EventArgs) Handles btnModificarPaciente.Click
        frmAdministrador.InstanciarFormulario("Gestion", "ModificarPaciente")
    End Sub

    Private Sub btnBusquedaPaciente_Click(sender As Object, e As EventArgs) Handles btnBusquedaPaciente.Click
        frmAdministrador.InstanciarFormulario("Gestion", "DatosPaciente")
    End Sub
End Class