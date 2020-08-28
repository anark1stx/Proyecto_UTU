Imports Negocio
Imports Entidades
Public Class frmGestion
    Public tipo_usuario As String = ""
    Public filtro As String = "Cedula"
    Public source As New BindingSource

    Private Sub frmGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarControles(Me)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        mostrarBuscarTabla(txtBuscar.Text)
    End Sub

    Public Sub mostrarBuscarTabla(busqueda As String)

        Select Case tipo_usuario
            Case "paciente"
                Dim objPaciente As New N_Paciente
                dgwUsuarios.DataSource = objPaciente.ListarUsuariosCI(busqueda)
            Case "medico"

            Case "auxiliar"
        End Select

    End Sub

End Class