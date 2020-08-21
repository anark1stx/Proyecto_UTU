Public Class MsgBoxTipoDeTextBox
    Dim cb_base As New ComboBox
    Public valorSeleccionado As String = ""
    Private Sub cbTipoDeDato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoDeDato.SelectedIndexChanged

        If cbTipoDeDato.SelectedIndex <> -1 Then
            valorSeleccionado = cbTipoDeDato.Items(cbTipoDeDato.SelectedIndex).ToString()
        End If

        Me.Hide()
    End Sub

End Class