Imports System.Globalization

Public Class frmGenerico
    Dim culture As New CultureInfo("es-ES")
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

        For Each c As Control In Me.Controls

            If TypeOf c Is GroupBox Then
                For Each c2 As Control In c.Controls
                    If TypeOf c2 Is TextBox AndAlso c2.Enabled Then

                        If c2.Text.Length < 1 Then
                            Dim ans = MessageBox.Show("El Campo: " & c2.Name & " está vacío, seguro que aún así desea guardar el formulario?", "Falta llenar información.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                            If ans = vbYes Then
                                Exit For
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
        For Each c As Control In Me.Controls

            If TypeOf c Is GroupBox Then
                For Each c2 As Control In c.Controls
                    If TypeOf c2 Is TextBox Or TypeOf c2 Is ComboBox Then
                        c2.ResetText()
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub txtMotivoConsulta_TextChanged(sender As Object, e As EventArgs) Handles txtMotivoConsulta.TextChanged

        If culture.CompareInfo.IndexOf(txtMotivoConsulta.Text, "fiebre", CompareOptions.IgnoreCase) = 0 Then
            'Sugerir frmFiebre
            Dim eleccion = MessageBox.Show("¿Desea usar el formulario orientado a la fiebre?", "Usted ingresó fiebre como motivo de consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            If eleccion = vbOK Then
                frmMedico.InstanciarFormulario("Fiebre")
            End If

        End If

        If culture.CompareInfo.IndexOf(txtMotivoConsulta.Text, "dolor", CompareOptions.IgnoreCase) = 0 Then
            'Sugerir frmDolor
            Dim eleccion = MessageBox.Show("¿Desea usar el formulario orientado a la dolor?", "Usted ingresó fiebre como motivo de consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            If eleccion = vbOK Then
                frmMedico.InstanciarFormulario("Dolor")
            End If

        End If

        If culture.CompareInfo.IndexOf(txtMotivoConsulta.Text, "malestar", CompareOptions.IgnoreCase) = 0 Then
            'Sugerir frmDolor
            Dim eleccion = MessageBox.Show("¿Desea usar el formulario orientado a la malestar?", "Usted ingresó fiebre como motivo de consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            If eleccion = vbOK Then
                frmMedico.InstanciarFormulario("Malestar")
            End If

        End If

    End Sub
End Class