Public Class frmIngreso_Usuario

    Dim frmAdm As New frmAdministrador
    Dim frmMed As New frmMedico
    Dim frmPac As New frmPaciente



    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        If verificar_usr(CONNECTION_STRING(txtIngresarCi.Text, txtIngresarContrasena.Text)) = 0 Then
            lblMensajeErrorCI.Visible = True
        Else
            lblMensajeErrorCI.Visible = False
            determinarUsr()
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
            Me.Dispose()
            Application.Exit() 'Salir completamente del programa y cerrar todas las ventanas que estaban Hide
        End If
    End Sub
End Class