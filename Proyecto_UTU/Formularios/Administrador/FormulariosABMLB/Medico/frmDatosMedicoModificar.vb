Public Class frmDatosMedicoModificar
    Public altaOmod As Integer = 0 '0 es para alta, 1 para modificacion
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        For Each txt As TextBox In Me.Controls.OfType(Of TextBox)
            txt.Text = String.Empty
        Next

    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim cedula As String = txtCedula.Text
        Dim nombre1 As String = txtNombre1.Text
        Dim nombre2 As String = txtNombre2.Text
        Dim apellido1 As String = txtApellido1.Text
        Dim apellido2 As String = txtApellido2.Text
        Dim correo As String = txtCorreo.Text
        Dim contrasena As String = txtContrasena.Text

        Dim direccion As String() = txtDireccion.Text.Split(",")
        '-> Salida esperada: Luis Alberto de Herrera Esq. Francisco Torres, 4682
        '-> Antes de enviarlos, hay que remover los espacios entre las comas
        direccion = RemoverEspacios(direccion)

        Dim telefonos As String() = txtTelefono.Text.Split(",")
        telefonos = RemoverEspacios(telefonos)

        Dim especialidades As String() = txtEspecialidad.Text.Split(",")

        especialidades = RemoverEspacios(especialidades)

        Dim medico As New Medico(cedula, nombre1, nombre2, apellido1, apellido2, direccion, telefonos, correo, contrasena, especialidades)

        If medico.checkDatos() Then 'Datos de clase base Usuario
            If medico.checkDatosMed() Then 'En el caso del medico, ademas de los datos de la clase base validamos especialidad
                'Hacer alta o modificacion dependiendo de lo que haya seleccionado el administrador
                If altaOmod = 1 Then
                    'Hacer modificacion
                Else
                    'Hacer alta
                End If
            End If
        Else
        End If

    End Sub

    Private Sub txtCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCedula.KeyPress 'No dejarlo poner espacios
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre1.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre2.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtApellido1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido1.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtApellido2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido2.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCorreo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorreo.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub pBoxFotoMedico_Click(sender As Object, e As EventArgs) Handles pBoxFotoMedico.Click
        Dim imgpath As String 'dónde está la imagen que se va a subir'
        Try
            Dim OFD As FileDialog = New OpenFileDialog() 'Esto es lo que nos abre el menú de windows para seleccionar archivos.'

            OFD.Filter = "Imagen (*.jpg;*.png)|*.jpg;*.png" 'Extensiones admitidas para que no te enchufen una reverse shell.'

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                pBoxFotoMedico.ImageLocation = imgpath
            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
End Class