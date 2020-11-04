Public Class frmAgregarItems
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not cbItems.Items.IndexOf(cbItems.Text) = -1 Then
            MessageBox.Show("Ese item ya fue ingresado", "Información duplicada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            cbItems.Items.Add(cbItems.Text)
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If cbItems.Items.IndexOf(cbItems.Text) = -1 Then
            Exit Sub
        Else
            cbItems.Items.Remove(cbItems.Text)
        End If
    End Sub
End Class