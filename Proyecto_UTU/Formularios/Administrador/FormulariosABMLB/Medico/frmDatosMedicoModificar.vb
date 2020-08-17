Public Class frmDatosMedicoModificar
    Public altaOmod As Integer = 0 '0 es para alta, 1 para modificacion
    Dim ci_valida As Boolean = 0
    Dim ci As String
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarControles(Me)
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If altaOmod = 1 Then
            If txtCedula.Text = String.Empty Then
                MsgBox("Seleccione un usuario de la tabla primero.")
                Exit Sub
            End If
        End If

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
        'direccion = RemoverEspacios(direccion)

        Dim telefonos As String() = txtTelefono.Text.Split(",")
        'telefonos = RemoverEspacios(telefonos)

        Dim especialidades As String() = txtEspecialidad.Text.Split(",")

        'especialidades = RemoverEspacios(especialidades)

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
        Dim imgpath As String 'donde esta la imagen que se va a subir'
        Try
            Dim OFD As FileDialog = New OpenFileDialog() 'Esto es lo que nos abre el menú de windows para seleccionar archivos.'

            OFD.Filter = "Imagen (*.jpg;*.png)|*.jpg;*.png"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                pBoxFotoMedico.ImageLocation = imgpath
            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub frmDatosMedicoModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim controls = Me.Controls
        configurarControles()
    End Sub

    Public Sub configurarControles()
        Select Case altaOmod
            Case 0
                For Each c As Control In Controls

                    If Not ci_valida Then
                        If TypeOf c Is TextBox AndAlso c IsNot txtCedula Then
                            c.Enabled = False
                        End If
                    Else
                        If TypeOf c Is TextBox Then
                            c.Enabled = True
                        End If
                    End If

                Next
            Case 1
                txtCedula.Enabled = False
                For Each c As Control In Controls

                    If TypeOf c Is TextBox AndAlso c IsNot txtCedula Then
                        c.Enabled = True
                    End If

                Next
        End Select
    End Sub

    Private Sub txtCedula_TextChanged(sender As Object, e As EventArgs) Handles txtCedula.TextChanged
        ci = txtCedula.Text

        If ci.Length = 8 Then
            ci_valida = check_Cedula(ci)
            If ci_valida = False Then
                MessageBox.Show(MensajeDeErrorCedula(), "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            configurarControles()
        Else
            ci_valida = check_Cedula(ci)
            configurarControles()
        End If

    End Sub

End Class