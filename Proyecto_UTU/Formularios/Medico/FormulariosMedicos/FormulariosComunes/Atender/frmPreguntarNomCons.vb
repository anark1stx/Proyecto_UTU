Imports Utilidades
Public Class frmPreguntarNomCons
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
        If Not check_Largo(txtNomConsulta.Text, 5, 120, True) Then
            MessageBox.Show("Ingrese un nombre de referencia para esta consulta.", "Falta llenar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            Me.Nombre = txtNomConsulta.Text
        End If
        Me.Hide()
    End Sub
End Class