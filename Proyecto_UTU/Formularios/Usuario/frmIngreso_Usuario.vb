Imports Negocio
Imports Entidades
Public Class frmIngreso_Usuario
    Dim frmAdm As New frmAdministrador
    Dim frmMed As New frmMedico
    Dim frmAux As New frmAuxiliar
    Dim frmPac As New frmPaciente
    Dim _frmOlvideMiContrasena As New frmOlvideMiContrasena
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        If Not check_Largo(txtIngresarCi.Text, 3, 30, True) Or Not check_Largo(txtIngresarContrasena.Text, 8, 30, True) Then '8 las cedulas, 30 el maximo de largo que admitimos en la BD, para la contrasena el minimo de caracteres es 8.
            MessageBox.Show("Sus credenciales de ingreso no son válidas.", "Verifique su usuario y contraseña.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblMensajeErrorCI.Visible = True
        Else
            Dim umysql As New N_UsuarioMYSQL()
            Dim usu = umysql.SeleccionarUsuario(txtIngresarCi.Text, txtIngresarContrasena.Text)

            If Not usu.Valido Then
                MessageBox.Show("Sus credenciales de ingreso no son válidas.", "Verifique su usuario y contraseña.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lblMensajeErrorCI.Visible = True
                Exit Sub
            End If

            Select Case usu.Rol
                Case "administrador" 'ADMIN
                    Me.Hide()
                    frmAdm.Show()
                Case "medico" 'MEDICO
                    Me.Hide()
                    frmMed.Show()
                    frmMed.MedicoActual = New E_Medico With {.Cedula = CInt(txtIngresarCi.Text.Replace("u", ""))}
                Case "auxiliar" 'AUXILIAR
                    Me.Hide()
                    frmAux.Show()
                Case "paciente" 'PACIENTE
                    Me.Hide()
                    frmPac.Show()
                    frmPac.PacienteActual = New E_Paciente With {.Cedula = CInt(txtIngresarCi.Text.Replace("u", ""))}
                Case Else
                    MessageBox.Show("Rol desconocido en el sistema.", "No se encontro su rol.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
            lblMensajeErrorCI.Visible = False
        End If

    End Sub

    Private Sub L_lblContrasenaOlvidada_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles L_lblContrasenaOlvidada.LinkClicked
        'Este boton abriría un nuevo formulario en el que el usuario pondría su CI y daría click en aceptar.
        'Posteriormente el administrador recibiría una notificación y le enviaría su contraseña o una nueva por mail/telefono.

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