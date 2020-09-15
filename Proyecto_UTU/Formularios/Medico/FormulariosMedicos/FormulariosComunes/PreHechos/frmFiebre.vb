Imports Entidades
Imports FormulariosPersonalizados
Imports Utilidades
Imports Negocio
Public Class frmFiebre
    Dim AccionesFrm As New AccionesFormulario
    Dim Eventos As New EventosDeFormulario
    Protected _paciente As E_Paciente
    Protected _medico As E_Medico



    Property Medico As E_Medico
        Get
            Return _medico
        End Get
        Set(value As E_Medico)
            _medico = value
        End Set
    End Property

    Private Sub frmFiebre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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