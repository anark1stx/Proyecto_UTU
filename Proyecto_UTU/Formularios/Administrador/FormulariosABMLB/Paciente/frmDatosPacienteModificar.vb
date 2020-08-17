Public Class frmDatosPacienteModificar
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
        Dim edad As String = txtEdad.Text
        Dim sexo As String = cbSexo.SelectedItem
        Dim ocupacion As String = txtOcupacion.Text
        Dim e_civil As String = cb_e_civil.SelectedItem

        Dim direccion As String() = txtDireccion.Text.Split(",")
        For i = 0 To direccion.Count - 1

            direccion(i) = RemoverEspacios(direccion(i))

        Next
        '-> Salida esperada: Luis Alberto de Herrera Esq. Francisco Torres, 4682
        '-> Antes de enviarlos, hay que remover los espacios entre las comas
        Dim telefonos As String() = txtTelefono.Text.Split(",")

        For Each s As String In telefonos

            RemoverEspacios(telefonos(s))

        Next

        Dim paciente As New Paciente(cedula, nombre1, nombre2, apellido1, apellido2, direccion, telefonos, correo, contrasena, edad, sexo, ocupacion, e_civil)

        If paciente.checkDatos() Then

            If paciente.checkDatosPaciente() Then
                'Hacer alta o modificacion dependiendo de lo que haya seleccionado el administrador
            End If

        End If

    End Sub

    Private Sub frmDatosPacienteModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configurarControles()
        cbSexo.SelectedIndex = 0
        cb_e_civil.SelectedIndex = 0
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

    Private Sub pBoxFotoPaciente_Click(sender As Object, e As EventArgs) Handles pBoxFotoPaciente.Click
        Dim imgpath As String 'dónde está la imagen que se va a subir'
        Try
            Dim OFD As FileDialog = New OpenFileDialog() 'Esto es lo que nos abre el menú de windows para seleccionar archivos.'

            OFD.Filter = "Imagen (*.jpg;*.png)|*.jpg;*.png" 'Extensiones admitidas para que no te enchufen una reverse shell.'

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                pBoxFotoPaciente.ImageLocation = imgpath
            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
End Class