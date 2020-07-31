Public Class frmDatosPacienteModificar
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        For Each txt As TextBox In Me.Controls.OfType(Of TextBox)
            txt.Text = ""
        Next

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        'Hacer alta o modificacion dependiendo de lo que haya seleccionado el administrador
    End Sub
End Class