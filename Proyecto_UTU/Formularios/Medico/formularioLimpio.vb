Imports Entidades
Imports FormulariosPersonalizados
Public Class formularioLimpio
    Dim AccionesFrm As New AccionesFormulario
    Dim Eventos As New EventosDeFormulario
    Protected _listapyr As New List(Of PreguntaRespuesta)

    Property MisPreguntas As List(Of PreguntaRespuesta)
        Get
            Return _listapyr
        End Get
        Set(value As List(Of PreguntaRespuesta))
            _listapyr = value
        End Set
    End Property

    Private Sub frmLimpio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Eventos.Modo = EventosDeFormulario.ModoEvento.DatosFormulario
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