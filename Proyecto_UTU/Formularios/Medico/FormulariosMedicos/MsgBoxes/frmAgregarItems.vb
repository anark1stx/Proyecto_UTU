Public Class frmAgregarItems
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not cbItems.Items.IndexOf(cbItems.Text) = -1 Then
            MessageBox.Show("Ese item ya fue ingresado", "Información duplicada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            cbItems.Items.Add(cbItems.Text)
        End If
    End Sub
End Class