Public Class frmDatosAuxiliarModificar
    Dim ci_valida As Boolean = 0
    Dim ci As String
    Public altaOmod As Integer = 0 '1 es para alta, 0 para modificacion

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
        '-> Salida esperada: Luis Alberto de Herrera, 4682
        '-> Antes de enviarlos, hay que remover los espacios entre las comas

        Dim direccion As String() = txtDireccion.Text.Split(",")
        For i = 0 To direccion.Count - 1

            direccion(i) = RemoverEspacios(direccion(i))

        Next

        Dim telefonos As String() = txtTelefono.Text.Split(",")

        For i = 0 To telefonos.Count - 1

            telefonos(i) = RemoverEspacios(telefonos(i))

        Next
        Dim aux As New Usuario(cedula, nombre1, nombre2, apellido1, apellido2, direccion, telefonos, correo, contrasena)

        If aux.checkDatos() Then
            'Hacer alta o modificacion dependiendo de lo que haya seleccionado el administrador

            If altaOmod = 1 Then
                'Hacer modificacion
            Else
                'Hacer alta
            End If

        End If

    End Sub

    Private Sub pBoxFotoAux_Click(sender As Object, e As EventArgs) Handles pBoxFotoAux.Click
        Dim imgpath As String 'dónde está la imagen que se va a subir'
        Try
            Dim OFD As FileDialog = New OpenFileDialog() 'Esto es lo que nos abre el menú de windows para seleccionar archivos.'

            OFD.Filter = "Imagen (*.jpg;*.png)|*.jpg;*.png" 'Extensiones admitidas para que no te enchufen una reverse shell.'

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                pBoxFotoAux.ImageLocation = imgpath
            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
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
    Private Sub frmDatosAuxiliarModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configurarControles()
    End Sub
End Class