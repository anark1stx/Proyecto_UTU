Public Class frmParametrosTemporalesT
    Private Sub frmParametrosTemporalesT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        fixFechaFin()
    End Sub

    Private Sub btnAgregarDia_Click(sender As Object, e As EventArgs) Handles btnAgregarDia.Click
        If lbDiasSelect.Items.Contains(cbDiasSemana.SelectedItem.ToString()) Then
            MessageBox.Show(cbDiasSemana.SelectedItem.ToString() & " ya fue agregado a la lista", "Día ya registrado.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            lbDiasSelect.Items.Add(cbDiasSemana.SelectedItem)
        End If
    End Sub

    Private Sub btnSacarDia_Click(sender As Object, e As EventArgs) Handles btnSacarDia.Click
        If lbDiasSelect.Items.Contains(cbDiasSemana.SelectedItem) Then
            lbDiasSelect.Items.Remove(cbDiasSemana.SelectedItem)
        End If
    End Sub

    Private Sub dtpFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicio.ValueChanged
        fixFechaFin()
    End Sub
    Sub fixFechaFin()
        If dtpFechaFin.Value <= dtpFechaInicio.Value Then
            dtpFechaFin.MinDate = New Date(dtpFechaInicio.Value.Year, dtpFechaInicio.Value.Month, dtpFechaInicio.Value.Day + 1)
        End If
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If lbDiasSelect.Items.Count < 1 Then
            MessageBox.Show("Seleccione los dias en los que se va a seguir este tratamiento", "Falta especificar información.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.Hide()
    End Sub

    Private Sub dtpFechaFin_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaFin.ValueChanged
        FixAvailableDays()
    End Sub

    Sub FixAvailableDays()
        cbDiasSemana.Items.Clear()
        lbDiasSelect.Items.Clear()
        For i = dtpFechaInicio.Value.DayOfWeek To dtpFechaFin.Value.DayOfWeek
            cbDiasSemana.Items.Add(i)
        Next
    End Sub

End Class