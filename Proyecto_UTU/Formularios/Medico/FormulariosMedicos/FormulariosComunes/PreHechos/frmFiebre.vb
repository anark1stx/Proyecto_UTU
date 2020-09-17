Imports Entidades
Imports FormulariosPersonalizados
Imports Utilidades
Imports Negocio
Public Class frmFiebre
    Dim AccionesFrm As New AccionesFormulario
    Dim Eventos As New EventosDeTBP
    Protected _paciente As New E_Paciente
    Protected _medico As New E_Medico
    Protected _mi_form As New E_Formulario
    Property Medico As E_Medico
        Get
            Return _medico
        End Get
        Set(value As E_Medico)
            _medico = value
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

    Property MiFormulario As E_Formulario
        Get
            Return _mi_form
        End Get
        Set(value As E_Formulario)
            _mi_form = value
        End Set
    End Property

    Private Sub frmFiebre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill

        Eventos.Modo = EventosDeTBP.ModoEvento.DatosFormulario
        Eventos.FormDatos = MiFormulario

        Eventos.Acciones = AccionesFrm
        Eventos.PanelDestino = Me.pnlContenedor
        Eventos.PrintDoc = New Printing.PrintDocument
        Eventos.Acciones.TopLevel = False
        Eventos.Acciones.TopMost = True
        Me.pnlContenedor.Controls.Add(Eventos.Acciones)
        Eventos.Acciones.Dock = DockStyle.Bottom
        Eventos.Acciones.Visible = True
        Eventos.AgregarHandlers()
    End Sub
End Class