Imports Entidades
Imports Utilidades
Imports FormulariosPersonalizados
Public Class frmGenerico
    Dim AccionesFrm As New AccionesFormulario
    Dim Eventos As New EventosDeTBP
    Dim memobmp As Bitmap
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

    Private Sub chkPacienteEnfermo_CheckedChanged(sender As Object, e As EventArgs) Handles chkPacienteEnfermo.CheckedChanged
        If chkPacienteEnfermo.Checked Then
            txtEnfermedad.Enabled = True
        Else
            txtEnfermedad.Enabled = False
        End If
    End Sub

    Private Sub chkAnalisis_CheckedChanged(sender As Object, e As EventArgs) Handles chkAnalisis.CheckedChanged
        If chkAnalisis.Checked Then
            txtNomAnalisis.Enabled = True
        Else
            txtNomAnalisis.Enabled = False
        End If
    End Sub

    Private Sub chkTratamiento_CheckedChanged(sender As Object, e As EventArgs) Handles chkTratamiento.CheckedChanged
        If chkTratamiento.Checked Then
            txtTratamiento.Enabled = True
        Else
            txtTratamiento.Enabled = False
        End If
    End Sub

    Private Sub frmGenericoTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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