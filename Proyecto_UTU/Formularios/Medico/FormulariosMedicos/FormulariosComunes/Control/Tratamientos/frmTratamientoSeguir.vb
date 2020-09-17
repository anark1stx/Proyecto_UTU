Imports FormulariosPersonalizados
Imports Entidades
Imports Negocio
Public Class frmTratamientoSeguir
    Dim AccionesFrm As New AccionesFormulario
    Dim Eventos As New EventosDeTBP
    Dim t As E_Tratamiento
    Private Sub frmTratamientoSeguir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Dock = DockStyle.Fill

        Eventos.Acciones = AccionesFrm
        Eventos.PanelDestino = pnlContenedor
        Eventos.PrintDoc = New Printing.PrintDocument

        Eventos.Acciones.TopLevel = False
        Eventos.Acciones.TopMost = True
        pnlContenedor.Controls.Add(Eventos.Acciones)
        Eventos.Acciones.Dock = DockStyle.Bottom
        Eventos.Acciones.Visible = True
        Eventos.Modo = EventosDeTBP.ModoEvento.DatosTratamiento
        Eventos.AgregarHandlers()
        Eventos.Acciones.Enabled = False
        MsgBox("Aun no implementado.")
    End Sub
End Class