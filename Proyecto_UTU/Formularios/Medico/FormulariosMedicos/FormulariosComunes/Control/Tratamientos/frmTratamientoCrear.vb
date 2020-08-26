Public Class frmTratamientoCrear
    Dim t As Tratamiento


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        t = New Tratamiento(txtNombreTratamiento.Text, txtDescripcionTratamiento.Text)
        't.Alta()
    End Sub

    Private Sub frmTratamientoCrear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 100
            cbDias.Items.Add(i).ToString()
        Next
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

    End Sub
End Class