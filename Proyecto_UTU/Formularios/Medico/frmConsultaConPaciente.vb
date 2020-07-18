Public Class frmConsultaConPaciente
    Private Sub txtCIPacienteTextChanged(sender As Object, e As EventArgs)
        If txtCIPaciente.TextLength = 8 Then
            'CargarDatosPaciente() <-- Metodo para buscar y cargar todos los datos del paciente
        End If
    End Sub

End Class