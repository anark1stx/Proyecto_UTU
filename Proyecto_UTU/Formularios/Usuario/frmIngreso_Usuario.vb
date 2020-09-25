Imports Negocio
Imports Entidades
Imports Utilidades
Public Class frmIngreso_Usuario
    Private Async Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        If Not check_Largo(txtIngresarCi.Text, 3, 30, True) Or Not check_regex(txtIngresarCi.Text, RegexAlfaNumerico) Or Not check_Largo(txtIngresarContrasena.Text, 8, 30, True) Then '8 las cedulas, 30 el maximo de largo que admitimos en la BD, para la contrasena el minimo de caracteres es 8.
            MessageBox.Show("Sus credenciales de ingreso no son válidas.", "Verifique su usuario y contraseña.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblMensajeErrorCI.Visible = True
        Else
            Dim umysql As New N_UsuarioMYSQL()

            Dim usu = Await Task.Run(Function() umysql.SeleccionarUsuario(txtIngresarCi.Text, txtIngresarContrasena.Text))

            Select Case usu.ErrMsg
                Case -1
                    MessageBox.Show(MensajeDeErrorConexion(), "Error en la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case -2
                    MessageBox.Show(MensajeDeErrorRolDesconocido(), "Rol desconocido para SIBIM.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case -3
                    MessageBox.Show("Su usuario fue dado de baja en el sistema. Si cree que esto se trata de un error comuníquese con administración.", "Usuario dado de baja", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Case 2
                    MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "No tiene permisos para consultar su rol.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case 5
                    MessageBox.Show(MensajeDeErrorCredsInvalidas(), "Credenciales incorrectas.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    lblMensajeErrorCI.Visible = True
                    Exit Sub
            End Select

            Select Case usu.Rol
                Case "administrador"
                    Me.Hide()
                    Dim frmAdm As New frmAdministrador
                    frmAdm.Show()
                Case "medico"
                    Dim frmMed As New frmMedico
                    Me.Hide()
                    frmMed.MedicoActual = New E_Medico With {.Cedula = CInt(txtIngresarCi.Text.Replace("u", ""))}
                    frmMed.MiModo = frmMedico.Modo.SoyMedico
                    frmMed.resetMode()
                    frmMed.Show()
                Case "auxiliar"
                    Dim frmMed As New frmMedico
                    Me.Hide()
                    frmMed.MedicoActual = New E_Medico With {.Cedula = 0}
                    frmMed.AuxiliarActual = New E_Usuario With {.Cedula = CInt(txtIngresarCi.Text.Replace("u", ""))}
                    frmMed.MiModo = frmMedico.Modo.SoyAuxiliar
                    frmMed.Show()
                    frmMed.resetMode()
                Case "paciente"
                    Dim frmPac As New frmPaciente
                    Me.Hide()
                    frmPac.Show()
                    frmPac.PacienteActual = New E_Paciente With {.Cedula = CInt(txtIngresarCi.Text.Replace("u", ""))}
            End Select
            lblMensajeErrorCI.Visible = False
        End If
    End Sub

    Private Sub L_lblContrasenaOlvidada_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles L_lblContrasenaOlvidada.LinkClicked
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

    Private Sub txtIngresarCi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIngresarCi.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub
End Class