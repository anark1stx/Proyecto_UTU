Imports Entidades
Imports FormulariosPersonalizados
Public Class formularioLimpio
    Dim AccionesFrm As New AccionesFormulario
    Dim Eventos As New EventosDeFormulario

    Private Sub frmLimpio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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