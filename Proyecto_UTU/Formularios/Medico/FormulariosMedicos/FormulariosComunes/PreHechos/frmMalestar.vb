Imports Entidades
Imports FormulariosPersonalizados
Imports Utilidades
Public Class frmMalestar
    Dim AccionesFrm As New AccionesFormulario
    Dim Eventos As New EventosDeTBP
    Protected _paciente As E_Paciente
    Protected _medico As E_Medico

    Property Paciente As E_Paciente
        Get
            Return _paciente
        End Get
        Set(value As E_Paciente)
            _paciente = value
        End Set
    End Property

    Property Medico As E_Medico
        Get
            Return _medico
        End Get
        Set(value As E_Medico)
            _medico = value
        End Set
    End Property
    Private Sub chkAnalisis_CheckedChanged(sender As Object, e As EventArgs) Handles chkAnalisis.CheckedChanged
        If chkAnalisis.Checked Then
            txtNomAnalisis.Enabled = True
        Else
            txtNomAnalisis.Enabled = False
        End If
    End Sub


    Private Sub chkADiarias_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkADiarias_Si.Click
        chkADiarias_No.Checked = False
    End Sub

    Private Sub chkADiarias_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkADiarias_No.Click
        chkADiarias_Si.Checked = False
    End Sub

    Private Sub chkViaje_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkViaje_Si.Click
        chkViaje_No.Checked = False
    End Sub

    Private Sub chkViaje_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkViaje_No.Click
        chkViaje_Si.Checked = False
    End Sub

    Private Sub chkDrugs_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkDrugs_Si.Click
        chkDrugs_No.Checked = False
    End Sub

    Private Sub chkDrugs_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkDrugs_No.Click
        chkDrugs_Si.Checked = False
    End Sub

    Private Sub chkCambioDieta_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkCambioDieta_Si.Click
        chkCambioDieta_No.Checked = False
    End Sub

    Private Sub chkCambioDieta_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkCambioDieta_No.Click
        chkCambioDieta_Si.Checked = False
    End Sub

    Private Sub chkT_Sens_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkT_Sens_Si.Click
        chkT_Sens_No.Checked = False
    End Sub

    Private Sub chkT_Sens_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkT_Sens_No.Click
        chkT_Sens_Si.Checked = False
    End Sub

    Private Sub mLoad() Handles MyBase.Load
        Me.Dock = DockStyle.Fill

        Eventos.Acciones = AccionesFrm
        Eventos.PanelDestino = pnlContenedor
        Eventos.PrintDoc = New Printing.PrintDocument

        Eventos.Acciones.TopLevel = False
        Eventos.Acciones.TopMost = True
        pnlContenedor.Controls.Add(Eventos.Acciones)
        Eventos.Acciones.Dock = DockStyle.Bottom
        Eventos.Acciones.Visible = True
        Eventos.AgregarHandlers()
    End Sub

End Class