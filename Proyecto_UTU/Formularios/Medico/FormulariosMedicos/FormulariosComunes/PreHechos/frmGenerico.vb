Public Class frmGenerico
    Dim Acciones As New AccionesFormulario
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
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs)
        hideShowItems(False, New List(Of Control)(New Control() {Acciones}))

        pnlContenedor.AutoScroll = False
        memobmp = ImprimirFormulario(Imprimir, True, pnlContenedor, New Rectangle(0, 0, pnlContenedor.DisplayRectangle.Width, pnlContenedor.Height))

        pnlContenedor.AutoScroll = True

        'Refrescar el autoScroll, a veces se bugea y queda una scrollbar horizontal glitcheada

        hideShowItems(True, New List(Of Control)(New Control() {Acciones}))

    End Sub

    Private Sub Imprimir_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Imprimir.PrintPage

        e.Graphics.DrawImage(memobmp, 0, 0, e.PageBounds.Width, e.PageBounds.Height)
    End Sub

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

    Private Sub btnPredictivo_Click(sender As Object, e As EventArgs) Handles btnPredictivo.Click

        If txtSintoma1.TextLength < 3 Or txtSintoma2.TextLength < 3 Or txtSintoma3.TextLength < 3 Then
            MessageBox.Show("Indique los síntomas que manifiesta el paciente primero. Cuantos más datos pueda llenar más acertado será el diagnóstico.", "Se requiere llenar información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        'Hacer diagnostico predictivo basado en los datos ingresados
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs)

        LimpiarControles(Me)
    End Sub

    Private Sub frmGenericoTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Acciones.TopLevel = False
        Acciones.TopMost = True
        pnlContenedor.Controls.Add(Acciones)
        Acciones.Location = New Point(pnlContenedor.Width / 2, pnlContenedor.Height + Acciones.Height * 2.5)
        Acciones.Visible = True
        agregarH_accionesFormulario()
    End Sub

    Sub agregarH_accionesFormulario()
        AddHandler Acciones.btnImprimir.Click, AddressOf btnImprimir_Click
        AddHandler Acciones.btnLimpiar.Click, AddressOf btnLimpiar_Click

        AddHandler Acciones.btnGuardar.Click, AddressOf btnGuardar_Click
    End Sub

End Class