Public Class MsgBoxTipoDeTextBox
    Dim cb_base As New ComboBox
    Private Sub cbTipoDeDato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoDeDato.SelectedIndexChanged

        Dim valorSeleccionado = cbTipoDeDato.Items(cbTipoDeDato.SelectedIndex).ToString()

        If Not valorSeleccionado = "Síntoma" AndAlso Not valorSeleccionado = "Otro" Then
            cbTipoDeDato.Items.RemoveAt(cbTipoDeDato.SelectedIndex) 'Sacamos el item de la combobox para evitar tener 2 pulsos, 2 frecuencias cardíacas, etc.
        End If

        If valorSeleccionado.Equals("Frecuencia cardíaca") Then
            valorSeleccionado = "frecuencia_cardiaca"
        ElseIf valorSeleccionado.Equals("Frecuencia respiratoria") Then
            valorSeleccionado = "frecuencia_respiratoria"

        End If

        frmCrearFormulario.setType(valorSeleccionado)
        Me.Hide()
    End Sub

    Private Sub MsgBoxTipoDeTextBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_base = cbTipoDeDato
    End Sub
End Class