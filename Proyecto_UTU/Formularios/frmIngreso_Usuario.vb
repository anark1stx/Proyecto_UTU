Public Class frmIngreso_Usuario
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        '1- ValidarDatos()

        '2- Abrir ventana que le corresponda segun su tipo de usuario

        '3- Cerrar esta ventana = Me.Close()



    End Sub

    Private Sub L_lblContrasenaOlvidada_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles L_lblContrasenaOlvidada.LinkClicked
        'Este boton abriría un nuevo formulario en el que el usuario pondría su usuario y daría click en aceptar.
        'Posteriormente el administrador recibiría una notificación y le enviaría su contraseña o una nueva por mail/telefono.
    End Sub
End Class