Public Class frmGestionPMedico
    Private elegirMedico As New frmGestion With {.Mode = frmGestion.Accion.GestionarPMedico, .Usuario = frmGestion.TipoUsuario.Medico, .TopLevel = False, .TopMost = True, .Dock = DockStyle.Top}
    Private elegirAuxiliar As New frmGestion With {.Mode = frmGestion.Accion.GestionarPMedico, .Usuario = frmGestion.TipoUsuario.Auxiliar, .TopLevel = False, .TopMost = True, .Dock = DockStyle.Top}

    Private Sub frmGestionPMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblPMedico.Controls.Add(elegirMedico, 0, 0)
        tblPMedico.Controls.Add(elegirAuxiliar, 0, 1)
        elegirMedico.Visible = True
        elegirAuxiliar.Visible = True
    End Sub
End Class