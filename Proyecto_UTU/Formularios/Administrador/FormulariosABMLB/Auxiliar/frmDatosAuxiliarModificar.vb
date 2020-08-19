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

        Dim direccion As New List(Of String)(txtDireccion.Text.Split(","))
        For i = 0 To direccion.Count - 1

            direccion(i) = RemoverEspacios(direccion(i))

        Next

        Dim telefonos As New List(Of String)(txtTelefono.Text.Split(","))

        For i = 0 To telefonos.Count - 1

            telefonos(i) = RemoverEspacios(telefonos(i))

        Next

        Dim arrImg() As Byte = {}
        If pBoxFotoAux.Image Is Nothing Then
            If MessageBox.Show("¿Desea ingresar al usuario sin una imagen de identificación?", "Falta guardar información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
                Exit Sub
            End If
        Else
            Dim mStream As New IO.MemoryStream
            Dim tamanoFoto As UInteger = mStream.Length
            pBoxFotoAux.Image.Save(mStream, Imaging.ImageFormat.Png)
            arrImg = mStream.GetBuffer()
            mStream.Close()
        End If

        Dim aux As New Usuario(cedula, nombre1, nombre2, apellido1, apellido2, direccion, telefonos, correo, contrasena, arrImg)

        If aux.checkDatos() Then
            'Hacer alta o modificacion dependiendo de lo que haya seleccionado el administrador
            If altaOmod = 0 Then 'Hacer alta
                Conectar()

                Try
                    conn.Execute(CREATEUSER("u" & aux.Cedula, aux.Contrasena, "aux"))
                Catch ex As Exception
                    MsgBox("No se pudo ingresar el USER de MYSQL " & ex.Message)
                    Exit Sub
                End Try

                Try
                    conn.Execute(GRANTROLE("aux", "u" & aux.Cedula))
                Catch ex As Exception
                    MsgBox("No se pudo dar ROL ")
                    Exit Sub
                End Try

                Try
                    conn.Execute(INSERTUSUARIO(aux.Cedula, aux.Nombre1, aux.Nombre2, aux.Apellido1, aux.Apellido2, aux.direccion(0), aux.direccion(1), correo, arrImg))
                Catch ex As Exception
                    MsgBox("No se pudo ingresar el USUARIO de SIBIM" & " " & ex.Message)
                    Exit Sub
                End Try

                For Each t As String In aux.telefonosLista
                    Try
                        conn.Execute(INSERTTELEFONO(aux.Cedula, t))
                    Catch ex As Exception
                        MsgBox("No se pudo ingresar el telefono:" & t & " " & ex.Message)
                        Exit Sub
                    End Try
                Next

            Else 'Hacer modificacion

            End If

        End If

    End Sub

    Private Sub pBoxFotoAux_Click(sender As Object, e As EventArgs)
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

    Private Sub txtCedula_TextChanged(sender As Object, e As EventArgs)
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
                        If TypeOf c Is ComboBox Or TypeOf c Is TextBox AndAlso c IsNot txtCedula Then
                            c.Enabled = False
                        End If
                    Else
                        If TypeOf c Is TextBox Or TypeOf c Is ComboBox Then
                            c.Enabled = True
                        End If
                    End If

                Next
            Case 1
                txtCedula.Enabled = False
                For Each c As Control In Controls

                    If TypeOf c Is ComboBox Or TypeOf c Is TextBox AndAlso c IsNot txtCedula Then
                        c.Enabled = True
                    End If

                Next
        End Select
    End Sub
    Private Sub frmDatosAuxiliarModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configurarControles()
    End Sub
End Class