Imports System.Drawing.Printing

Public Class frmGenerico
    Dim memobmp As Bitmap
    Dim tmpPanel As Panel

    Sub hideShowItems(_case As Boolean)

        btnPredictivo.Visible = _case
        For Each c As Control In pnlContenedor.Controls
            If TypeOf c Is Button Then
                c.Visible = _case
            End If

        Next
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        hideShowItems(0)

        Print(pnlContenedor)

        hideShowItems(1)
    End Sub

    Public Sub Print(pnl As Panel)
        tmpPanel = pnl
        Imprimir.DefaultPageSettings.Landscape = True
        getPrintArea(pnl)

        Imprimir.Print()

    End Sub

    Public Sub getPrintArea(pnl As Panel)
        memobmp = New Bitmap(pnl.Width, pnl.Height)
        pnl.DrawToBitmap(memobmp, New Rectangle(0, 0, pnl.Width, pnl.Height))
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        If memobmp IsNot Nothing Then
            e.Graphics.DrawImage(memobmp, 0, 0)
            MyBase.OnPaint(e)
        End If

    End Sub

    Private Sub Imprimir_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Imprimir.PrintPage

        Dim pagearea As Rectangle = e.PageBounds
        Dim _fixedpagearea2 As Rectangle = e.PageBounds 'Este rectangulo es para corregir el offset entre la ubicacion del panel y la del formulario en si

        _fixedpagearea2.Width = (pagearea.Width / 2) - (Me.pnlContenedor.Width / 2)


        e.Graphics.DrawImage(memobmp, _fixedpagearea2.Width, Me.pnlContenedor.Location.Y)
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

        For Each c As Control In pnlContenedor.Controls
            If TypeOf c Is GroupBox Or TypeOf c Is Panel Then
                LimpiarControles(c)
            End If
        Next
        LimpiarControles(gbTratamiento)
    End Sub

    Private Sub frmGenericoTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
    End Sub

End Class