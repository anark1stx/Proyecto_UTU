Imports Utilidades
Imports Entidades
Imports FormulariosPersonalizados
Imports Negocio
Public Class frmTratamientoCrear
    Dim negocio As New N_Tratamiento
    Private Async Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not check_regex(txtNombreTratamiento.Text, RegexAlfaNumericoEspaciosPuntosComasTildes) Then
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

        Dim t = New E_Tratamiento(txtNombreTratamiento.Text, txtDescripcionTratamiento.Text)
        Dim result = Await Task.Run(Function() negocio.AltaTratamiento(t))
        Select Case result
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando procedimiento", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 1
                MessageBox.Show("Tratamiento ingresado con éxito", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub

    Private Sub frmTratamientoCrear_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Dock = DockStyle.Fill
    End Sub

End Class