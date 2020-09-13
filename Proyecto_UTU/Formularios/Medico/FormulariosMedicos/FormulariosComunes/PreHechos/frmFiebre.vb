Imports Entidades
Imports FormulariosPersonalizados
Imports Utilidades
Imports Negocio
Public Class frmFiebre
    Dim AccionesFrm As New AccionesFormulario
    Dim Eventos As New EventosDeFormulario
    Protected _paciente As E_Paciente
    Protected _medico As E_Medico
    Protected _preguntasYrespuestas As New List(Of PreguntaRespuesta)
    Protected _preguntas As New List(Of Control)
    Protected _respuestas As New List(Of Control)


    Property Preguntas As List(Of Control)
        Get
            Return _preguntas
        End Get
        Set(value As List(Of Control))
            _preguntas = value
        End Set
    End Property

    Property Respuestas As List(Of Control)
        Get
            Return _respuestas
        End Get
        Set(value As List(Of Control))
            _respuestas = value
        End Set
    End Property

    Property ListaPreguntasYRespuestas As List(Of PreguntaRespuesta)
        Get
            Return _preguntasYrespuestas
        End Get
        Set(value As List(Of PreguntaRespuesta))
            _preguntasYrespuestas = value
        End Set
    End Property
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