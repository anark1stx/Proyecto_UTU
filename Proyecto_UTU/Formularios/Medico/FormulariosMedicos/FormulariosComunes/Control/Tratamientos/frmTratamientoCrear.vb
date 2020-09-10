Imports Utilidades
Imports Entidades
Imports Negocio
Public Class frmTratamientoCrear
    Dim acciones As New AccionesFormulario
    Dim t As E_Tratamiento

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)
        If Not check_regex(txtNombreTratamiento.Text, RegexLiteralAcentos) Then
            MessageBox.Show("Nombre de tratamiento inválido. " & MensajeDeErrorCaracteres(), "Caracteres inválidos detectados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not check_Largo(txtNombreTratamiento.Text, 10, 160, True) Then
            MessageBox.Show("Nombre: " & MensajeDeErrorLongitud(10, 160), "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not check_Largo(txtDescripcionTratamiento.Text, 10, 16000, True) Then
            MessageBox.Show("Descripción: " & MensajeDeErrorLongitud(10, 16000), "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        t = New E_Tratamiento(txtNombreTratamiento.Text, txtDescripcionTratamiento.Text)
        't.Alta()
    End Sub

    Private Sub frmTratamientoCrear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 100
            cbDias.Items.Add(i).ToString()
        Next

        acciones.TopLevel = False
        acciones.TopMost = True
        acciones.Dock = DockStyle.Bottom
        'acciones.Location = New Point(txtDescripcionTratamiento.Width / 2, txtDescripcionTratamiento.Height + 10)
        acciones.Show()
        acciones.Visible = True
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs)
        LimpiarControles(Me)
    End Sub
End Class