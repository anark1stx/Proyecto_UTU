Public Class frmGestion
    Public tipo_usuario As String = ""
    Public filtro As String = "Cedula"
    Public medico As New Medico
    Public paciente As New Paciente
    Public aux As New Usuario
    Public source As New BindingSource

    Private Sub frmGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarControles(Me)
    End Sub
End Class