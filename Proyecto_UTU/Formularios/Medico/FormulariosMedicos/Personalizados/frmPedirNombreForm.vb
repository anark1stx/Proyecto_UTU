Imports Utilidades
Public Class frmPedirNombreForm
    Protected _nombre As String
    Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Not check_Largo(txtNombreForm.Text, 5, 90, True) Then
            MessageBox.Show("Ingrese un nombre para guardar el formulario", "Falta llenar información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Me.Nombre = txtNombreForm.Text
            Me.Hide()
        End If
    End Sub
End Class