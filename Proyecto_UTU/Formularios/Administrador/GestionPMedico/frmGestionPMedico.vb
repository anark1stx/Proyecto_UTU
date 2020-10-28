Imports Utilidades
Imports Entidades
Imports Negocio
Public Class frmGestionPMedico
    Private elegirMedico As New frmGestion With {.Mode = frmGestion.Accion.GestionarPMedico, .Usuario = frmGestion.TipoUsuario.Medico, .TopLevel = False, .TopMost = True, .Dock = DockStyle.Top}
    Private elegirAuxiliar As New frmGestion With {.Mode = frmGestion.Accion.GestionarPMedico, .Usuario = frmGestion.TipoUsuario.Auxiliar, .TopLevel = False, .TopMost = True, .Dock = DockStyle.Top}
    Private listaMedico As New List(Of E_Corresponde)
    Private listaAuxiliar As New List(Of E_Corresponde)
    Private Sub frmGestionPMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblPMedico.Controls.Add(elegirMedico, 0, 0)
        tblPMedico.Controls.Add(elegirAuxiliar, 0, 1)
        elegirMedico.Visible = True
        elegirAuxiliar.Visible = True
    End Sub

    Private Sub btnAgregarAsignar_Click(sender As Object, e As EventArgs) Handles btnAgregarAsignar.Click
        If String.IsNullOrEmpty(elegirMedico.lblCedulaTXT.Text) Then
            MessageBox.Show("Seleccione un médico primero.", "Falta proporcionar información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If String.IsNullOrEmpty(elegirAuxiliar.lblCedulaTXT.Text) Then
            MessageBox.Show("Seleccione un auxiliar primero.", "Falta proporcionar información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim definirhorario As New frmDefinirFechaAsignacion
        definirhorario.ShowDialog()

        If Not definirhorario.Cancelar Then
            Dim fechaelegida = New Date(definirhorario.dtpFecha.Value.Year, definirhorario.dtpFecha.Value.Month, definirhorario.dtpFecha.Value.Day, definirhorario.dtpHora.Value.Hour, definirhorario.dtpHora.Value.Minute, 0)
            Dim corresponde As New E_Corresponde(elegirMedico.MedicoSelected, elegirAuxiliar.AuxiliarSelected, fechaelegida)
            Dim n_crr
        End If

    End Sub
End Class