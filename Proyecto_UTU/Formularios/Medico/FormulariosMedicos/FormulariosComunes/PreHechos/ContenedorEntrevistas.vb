Public Class ContenedorEntrevistas
    Private Sub btnAgregarSClinico_Click(sender As Object, e As EventArgs) Handles btnAgregarSClinico.Click
        If Not lbSignosClinicos.Items.Contains(txtSgClinico.Text) Then
            lbSignosClinicos.Items.Add(txtSgClinico.Text)
        Else
            MessageBox.Show("Ese signo clínico ya fue ingresado")
        End If

    End Sub

    Private Sub btnAgregarSintoma_Click(sender As Object, e As EventArgs) Handles btnAgregarSintoma.Click
        If Not lbSignosClinicos.Items.Contains(txtSintoma.Text) Then
            lbSintomas.Items.Add(txtSintoma.Text)
        Else
            MessageBox.Show("Ese síntoma ya fue ingresado")
        End If
    End Sub

    Private Sub btnBorrarSintoma_Click(sender As Object, e As EventArgs) Handles btnBorrarSintoma.Click
        If lbSintomas.SelectedItem IsNot String.Empty Then
            lbSintomas.Items.Remove(lbSintomas.SelectedItem)
        End If
    End Sub

    Private Sub btnBorrarSigno_Click(sender As Object, e As EventArgs) Handles btnBorrarSigno.Click
        If lbSignosClinicos.SelectedItem IsNot String.Empty Then
            lbSignosClinicos.Items.Remove(lbSignosClinicos.SelectedItem)
        End If
    End Sub
End Class
