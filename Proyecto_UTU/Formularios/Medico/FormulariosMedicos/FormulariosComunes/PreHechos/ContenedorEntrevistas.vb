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

    Private Sub chkEnfermo_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnfermo.CheckedChanged
        If chkEnfermo.Checked Then
            lblPresenta.Visible = True
            txtNomEnfermedad.Visible = True
        Else
            lblPresenta.Visible = False
            txtNomEnfermedad.Visible = False
        End If
    End Sub

    Private Sub chkAnalisis_CheckedChanged(sender As Object, e As EventArgs) Handles chkAnalisis.CheckedChanged
        If chkAnalisis.Checked Then
            lblAnalisisReq.Visible = True
            txtNomAnalisis.Visible = True
        Else
            lblAnalisisReq.Visible = False
            txtNomAnalisis.Visible = False
        End If
    End Sub
    Private Sub chkTratamiento_CheckedChanged(sender As Object, e As EventArgs) Handles chkTratamiento.CheckedChanged
        If chkTratamiento.Checked Then
            lblTratamientoS.Visible = True
            txtNomTratamiento.Visible = True
        Else
            lblTratamientoS.Visible = False
            txtNomTratamiento.Visible = False
        End If
    End Sub

    Private Sub ContenedorEntrevistas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
