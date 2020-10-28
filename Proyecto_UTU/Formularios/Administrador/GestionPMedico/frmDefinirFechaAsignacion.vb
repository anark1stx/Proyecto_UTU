Public Class frmDefinirFechaAsignacion
    Property Cancelar As Boolean
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar = True
        Me.Hide()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Cancelar = False
        Me.Hide()
    End Sub
End Class