Public Class frmIngreso_Usuario
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        '1- ValidarDatos()

        If Not check_Cedula(txtIngresarCi.Text) Or Not check_Largo(txtIngresarContrasena.Text, 8, 30, True) Then 'Deberiamos definir una politica de contraseñas en vez de simplemente checkear la longitud.
            setLabelText(lblMensajeErrorCI, "Verifique sus datos e intente de nuevo.")
            'La razon para no dar un error descriptivo tanto en cédula como en contraseña por separado
            'es para evitar que alguien que está probando cedulas y contraseñas al azar no pueda ver si le pegó a alguno de los datos.
            Exit Sub
        Else
            '2- Abrir ventana que le corresponda segun su tipo de usuario

            '3- Esconder esta ventana = Me.Hide() <-- Razon: Cuando un usuario haga click en cerrar, salir o cerrar sesión, volverá a esta primera ventana de Ingreso, dejando el programa disponible para los demás usuarios.
            Me.Hide()
        End If

    End Sub

    Private Sub L_lblContrasenaOlvidada_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles L_lblContrasenaOlvidada.LinkClicked
        'Este boton abriría un nuevo formulario en el que el usuario pondría su CI y daría click en aceptar.
        'Posteriormente el administrador recibiría una notificación y le enviaría su contraseña o una nueva por mail/telefono.
        Dim _frmOlvideMiContrasena As New frmOlvideMiContrasena

        If check_Cedula(txtIngresarCi.Text) Then
            _frmOlvideMiContrasena.txtIngresarCi.Text = txtIngresarCi.Text
        End If

        _frmOlvideMiContrasena.Show()

    End Sub

    Private Sub frmIngresoUsuario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = False
            Me.Dispose()
            Application.Exit() 'Salir completamente del programa y cerrar todas las ventanas que estaban Hide
        End If
    End Sub

End Class