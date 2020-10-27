Imports Negocio
Imports Entidades
Imports Utilidades
Public Class frmIngreso_Usuario
    Dim n_u_mysql As New N_UsuarioMYSQL
    Private Async Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        If Not check_Largo(txtIngresarCi.Text, 3, 30, True) Or Not check_regex(txtIngresarCi.Text, RegexAlfaNumerico) Or Not check_Largo(txtIngresarContrasena.Text, 8, 30, True) Then '8 las cedulas, 30 el maximo de largo que admitimos en la BD, para la contrasena el minimo de caracteres es 8.
            MessageBox.Show("Sus credenciales de ingreso no son válidas.", "Verifique su usuario y contraseña.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblMensajeErrorCI.Visible = True
        Else

            Dim usu = Await Task.Run(Function() n_u_mysql.SeleccionarUsuario(txtIngresarCi.Text, txtIngresarContrasena.Text))
            Select Case usu.ErrCode
                Case -1
                    MessageBox.Show(MensajeDeErrorConexion(), "Error en la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case -2
                    MessageBox.Show(MensajeDeErrorRolDesconocido(), "Rol desconocido para SIBIM.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Case -3
                    MessageBox.Show("Su usuario fue dado de baja en el sistema. Si cree que esto se trata de un error comuníquese con administración.", "Usuario dado de baja", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Case -5
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
                    frmMed.Show()
                Case "auxiliar"
                    Dim frmMed As New frmMedico
                    Me.Hide()
                    frmMed.AuxiliarActual = New E_Usuario With {.Cedula = CInt(txtIngresarCi.Text.Replace("u", ""))}
                    frmMed.MiModo = frmMedico.Modo.SoyAuxiliar
                    frmMed.Show()
                    frmMed.resetMode()
                Case "paciente"
                    Console.WriteLine("rol paciente")
                    Dim frmPac As New frmPaciente
                    Me.Hide()
                    frmPac.Show()
                    frmPac.PacienteActual = New E_Paciente With {.Cedula = CInt(txtIngresarCi.Text.Replace("u", ""))}
            End Select
            lblMensajeErrorCI.Visible = False
        End If
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

    Private Sub btnEspanol_Click(sender As Object, e As EventArgs) Handles btnEspanol.Click
        'capaz que es mejor solamente recargar la aplicación en vez de cambiar el idioma a espana, puede dar problemas
        If Idioma Is Globalization.CultureInfo.GetCultureInfo("es-ES") Then
            Exit Sub
        Else
            Controls.Clear()
            UpdateLang("es-ES")
            InitializeComponent()
        End If

    End Sub

    Private Sub btnIngles_Click(sender As Object, e As EventArgs) Handles btnIngles.Click
        If Idioma Is Globalization.CultureInfo.GetCultureInfo("en-US") Then
            Exit Sub
        Else
            Controls.Clear()
            UpdateLang("en-US")
            InitializeComponent()
        End If
    End Sub
End Class