Public Class Identificacion_Paciente
    Private Sub txtCIPaciente_TextChanged(sender As Object, e As EventArgs) Handles txtCIPaciente.TextChanged

        txtCIPaciente_Leave(sender, e)

    End Sub

    Private Sub txtCIPaciente_Leave(sender As Object, e As EventArgs)
        'CI stands for ID of a person in my country, the required length is 8 chars.
        If txtCIPaciente.TextLength = 8 Then

            If check_Cedula(txtCIPaciente.Text) Then
                'Verificar que exista en la BD
                'CargarDatosPaciente() <-- Metodo para buscar y cargar todos los datos del paciente
                'CheckCedulaBD() -> en caso que no exista, frmMedico.ciChecked(1)
                frmMedico.Ci = txtCIPaciente.Text
                frmMedico.ciChecked(2)
            Else
                frmMedico.Ci = txtCIPaciente.Text
                frmMedico.ciChecked(0)
            End If

        End If
    End Sub

    Public Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        txtCIPaciente_Leave(sender, e)
        If txtCIPaciente.TextLength < 8 Then
            frmMedico.Ci = txtCIPaciente.Text
            frmMedico.ciChecked(0)
        End If
    End Sub
End Class