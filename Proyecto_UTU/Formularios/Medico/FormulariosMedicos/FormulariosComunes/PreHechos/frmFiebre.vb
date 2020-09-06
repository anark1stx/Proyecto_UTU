Imports Entidades
Imports FormulariosPersonalizados
Imports Negocio
Public Class frmFiebre
    Dim memobmp As Bitmap
    Dim Acciones As New AccionesFormulario
    Protected _paciente As E_Paciente
    Protected _medico As E_Medico
    Protected _preguntasYrespuestas As New List(Of PreguntaRespuesta)
    Protected _preguntas As New List(Of Control)
    Protected _respuestas As New List(Of Control)
    Dim calls As Integer = 0


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
        Acciones.TopLevel = False
        Acciones.TopMost = True
        tabEntrevista.Controls.Add(Acciones)
        Acciones.Location = New Point(tabEntrevista.Width / 2, tabEntrevista.Height + Acciones.Height * 6)
        Acciones.Visible = True
        agregarH_accionesFormulario()
    End Sub

    Sub agregarH_accionesFormulario()
        AddHandler Acciones.btnImprimir.Click, AddressOf btnImprimir_Click
        AddHandler Acciones.btnLimpiar.Click, AddressOf btnLimpiar_Click
        AddHandler Acciones.btnGuardar.Click, AddressOf btnGuardar_Click

    End Sub

    Private Sub chkAnalisis_CheckedChanged(sender As Object, e As EventArgs)
        If chkAnalisis.Checked Then
            txtNomAnalisis.Enabled = True
        Else
            txtNomAnalisis.Enabled = False
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs)
        LimpiarControles(Me)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)
        Dim lista As New List(Of Control)

        For Each c As Control In Me.Controls
            lista.Add(c)
        Next


        Dim fbr As New FabricaDeControles()
        GuardarFormulario(fbr.Serializar(lista))
        'BuscarPreguntasYRespuestas(Me, ListaPreguntasYRespuestas, Preguntas, Respuestas)
        'UnirPreguntasYRespuestas(Preguntas, Respuestas, ListaPreguntasYRespuestas)

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs)
        hideShowItems(False, New List(Of Control)(New Control() {Acciones}))
        pnlContenedor.AutoScroll = False
        memobmp = ImprimirFormulario(Imprimir, True, pnlContenedor, New Rectangle(0, 0, pnlContenedor.DisplayRectangle.Width, pnlContenedor.Height))
        'PrintPreviewDialog1.Document = Imprimir
        pnlContenedor.AutoScroll = True
        'PrintPreviewDialog1.ShowDialog()

        hideShowItems(True, New List(Of Control)(New Control() {Acciones}))

    End Sub

    Private Sub Imprimir_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)

        e.Graphics.DrawImage(memobmp, 0, 0, e.PageBounds.Width, e.PageBounds.Height)
    End Sub

End Class