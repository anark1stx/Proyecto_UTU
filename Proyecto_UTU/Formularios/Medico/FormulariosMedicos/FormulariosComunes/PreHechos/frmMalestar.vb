Public Class frmMalestar
    Private Sub chkAnalisis_CheckedChanged(sender As Object, e As EventArgs) Handles chkAnalisis.CheckedChanged
        If chkAnalisis.Checked Then
            txtNomAnalisis.Enabled = True
        Else
            txtNomAnalisis.Enabled = False
        End If
    End Sub

    Private Sub chkSemanas_CheckedChanged(sender As Object, e As EventArgs) Handles chkSemanas.Click
        chkMeses.Checked = False
    End Sub

    Private Sub chkMeses_CheckedChanged(sender As Object, e As EventArgs) Handles chkMeses.Click
        chkSemanas.Checked = False
    End Sub

    Private Sub chkConstante_CheckedChanged(sender As Object, e As EventArgs) Handles chkConstante.Click
        chkEpisodico.Checked = False
    End Sub

    Private Sub chkADiarias_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkADiarias_Si.Click
        chkADiarias_No.Checked = False
    End Sub

    Private Sub chkADiarias_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkADiarias_No.Click
        chkADiarias_Si.Checked = False
    End Sub

    Private Sub chkViaje_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkViaje_Si.Click
        chkViaje_No.Checked = False
    End Sub

    Private Sub chkViaje_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkViaje_No.Click
        chkViaje_Si.Checked = False
    End Sub

    Private Sub chkDrugs_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkDrugs_Si.Click
        chkDrugs_No.Checked = False
    End Sub

    Private Sub chkDrugs_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkDrugs_No.Click
        chkDrugs_Si.Checked = False
    End Sub

    Private Sub chkCambioDieta_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkCambioDieta_Si.Click
        chkCambioDieta_No.Checked = False
    End Sub

    Private Sub chkCambioDieta_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkCambioDieta_No.Click
        chkCambioDieta_Si.Checked = False
    End Sub

    Private Sub chkT_Sens_Si_CheckedChanged(sender As Object, e As EventArgs) Handles chkT_Sens_Si.Click
        chkT_Sens_No.Checked = False
    End Sub

    Private Sub chkT_Sens_No_CheckedChanged(sender As Object, e As EventArgs) Handles chkT_Sens_No.CheckedChanged
        chkT_Sens_Si.Checked = False
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        For Each c As Control In Me.Controls

            If TypeOf c Is GroupBox Then

                For Each c2 As Control In c.Controls

                    If TypeOf c2 Is TableLayoutPanel Then

                        For Each c3 As Control In c2.Controls

                            If TypeOf c3 Is CheckBox Then

                                DirectCast(c3, CheckBox).CheckState = CheckState.Unchecked

                            End If

                            If TypeOf c3 Is TextBox Then

                                DirectCast(c3, TextBox).Text = String.Empty

                            End If

                            If TypeOf c3 Is ComboBox Then

                                DirectCast(c3, ComboBox).Text = String.Empty

                            End If

                        Next

                    End If

                Next


            End If

        Next


    End Sub
End Class