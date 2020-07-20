Public Class frmDatosMedicoModificar
    Public altaOmod As Integer = 0 '1 es para alta, 0 para modificacion
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        For Each txt As TextBox In Me.Controls.OfType(Of TextBox)
            txt.Text = ""
        Next

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim cedula As String = txtCedula.Text
        Dim nombre1 As String = txtNombre1.Text
        Dim nombre2 As String = txtNombre2.Text
        Dim apellido1 As String = txtApellido1.Text
        Dim apellido2 As String = txtApellido2.Text
        Dim direccion As String() = txtDireccion.Text.Split(",")
        Dim correo As String = txtCorreo.Text
        Dim contrasena As String = txtContrasena.Text
        Dim especialidad As String = txtEspecialidad.Text
        '-> Salida esperada: Luis Alberto de Herrera, 4682
        '-> Antes de enviarlos, hay que remover los espacios entre las comas
        direccion = RemoverEspacios(direccion)

        Dim telefonos As String() = txtTelefono.Text.Split(",")
        telefonos = RemoverEspacios(telefonos)

        Dim medico_base As New Usuario(cedula, nombre1, nombre2, apellido1, apellido2, direccion, telefonos, correo, contrasena)
        Dim medico As New Medico(cedula, nombre1, nombre2, apellido1, apellido2, direccion, telefonos, correo, contrasena, especialidad)

        If check_Usuario(medico_base, medico) Then
            'Hacer alta o modificacion dependiendo de lo que haya seleccionado el administrador

            If altaOmod = 1 Then
                'Hacer modificacion
            Else
                'Hacer alta
            End If

        End If

    End Sub
End Class