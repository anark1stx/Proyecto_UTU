Imports System.Drawing.Printing

Public Class frmGenerico
    Dim memobmp As Bitmap

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        hideShowItems(False, New List(Of Control)(New Control() {btnLimpiar, btnImprimir, btnGuardar}))

        pnlContenedor.AutoScroll = False
        memobmp = ImprimirFormulario(Imprimir, True, pnlContenedor, New Rectangle(0, 0, pnlContenedor.DisplayRectangle.Width, pnlContenedor.Height))

        pnlContenedor.AutoScroll = True

        'Refrescar el autoScroll, a veces se bugea y queda una scrollbar horizontal glitcheada

        hideShowItems(True, New List(Of Control)(New Control() {btnLimpiar, btnImprimir, btnGuardar}))

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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim ctrlsLlenos = 0

        For Each c As Control In pnlContenedor.Controls

            If TypeOf c Is GroupBox Then
                For Each c2 As Control In c.Controls
                    If TypeOf c2 Is TextBox Or TypeOf c2 Is ComboBox AndAlso c2.Enabled Then

                        If c2.Text.Length < 1 Then
                            Dim ans = MessageBox.Show("El Campo: " & c2.Name & " está vacío, seguro que aún así desea guardar el formulario?", "Falta llenar información.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                            If ans = vbNo Then
                                Exit Sub
                            End If
                        Else
                            ctrlsLlenos += 1
                        End If

                    End If
                Next
            End If
        Next

        If ctrlsLlenos < 3 Then
            MsgBox("Por favor llene al menos 3 campos.")
        Else
            '->Guardar en BD
            MsgBox("Guardado con éxito.")
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        LimpiarControles(Me)
    End Sub

    Private Sub frmGenericoTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
    End Sub

End Class