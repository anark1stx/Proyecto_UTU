﻿Public Class frmIngreso_Usuario
    Dim frmAdm As New frmAdministrador
    Dim frmMed As New frmMedico
    Dim frmAux As New frmAuxiliar
    Dim frmPac As New frmPaciente
    Dim _frmOlvideMiContrasena As New frmOlvideMiContrasena
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        _usr = txtIngresarCi.Text
        _pwd = txtIngresarContrasena.Text

        If Not check_Largo(_usr, 3, 30, True) Or Not check_Largo(_pwd, 8, 30, True) Then '8 las cedulas, 30 el maximo de largo que admitimos en la BD, para la contrasena el minimo de caracteres es 8.
            MessageBox.Show("Sus credenciales de ingreso no son válidas.", "Verifique su usuario y contraseña.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblMensajeErrorCI.Visible = True
        Else
            Conectar()
            If conn.State = ConnectionState.Closed Then
                lblMensajeErrorCI.Visible = True
            Else
                Dim rol = SQL_SELECT_ROL(CMDSELECTMYSQLUSERROLE(txtIngresarCi.Text))

                Select Case rol
                    Case 0 'ADMIN
                        Me.Hide()
                        frmAdm.Show()
                    Case 1 'MEDICO
                        Me.Hide()
                        frmMed.Show()
                    Case 2 'AUXILIAR
                        Me.Hide()
                        frmAux.Show()
                    Case 3 'PACIENTE
                        Me.Hide()
                        frmPac.Show()
                    Case Else
                        MessageBox.Show("Rol desconocido en la base de datos.", "No se encontro su rol.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select
                lblMensajeErrorCI.Visible = False
            End If
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