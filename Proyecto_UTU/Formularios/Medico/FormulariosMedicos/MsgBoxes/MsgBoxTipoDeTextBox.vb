Public Class MsgBoxTipoDeTextBox
    Dim cb_base As New ComboBox
    Public valorSeleccionado As String = ""
    Private Sub cbTipoDeDato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoDeDato.SelectedIndexChanged

        valorSeleccionado = cbTipoDeDato.Items(cbTipoDeDato.SelectedIndex).ToString()

        Me.Hide()
    End Sub

    Private Sub MsgBoxTipoDeTextBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_base = cbTipoDeDato
    End Sub

End Class