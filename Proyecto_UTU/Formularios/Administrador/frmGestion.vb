Imports Negocio
Imports Entidades
Public Class frmGestion
    Public tipo_usuario As String = ""
    Public filtro As String = "Cedula"
    Public source As New BindingSource
    Dim dt As New DataTable
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
                Dim res = objPaciente.ListarUsuariosCI(busqueda)
                If res.Cedula = 0 Then
                    MessageBox.Show("No existe un usuario con esa cédula de identidad", "Datos no encontrados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                source.DataSource = res
                dgwUsuarios.DataSource = source

                dgwUsuarios.Columns("ErrMsg").Visible = False
                dgwUsuarios.Columns("Nombre").Visible = False
                dgwUsuarios.Columns("Rol").Visible = False
                dgwUsuarios.Columns("Contrasena").Visible = False

            Case "medico"

            Case "auxiliar"
        End Select

    End Sub

End Class