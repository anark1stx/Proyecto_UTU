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

        Dim direccion As New List(Of String)(txtDireccion.Text.Split(","))
        For i = 0 To direccion.Count - 1

            direccion(i) = RemoverEspacios(direccion(i))

        Next

        Dim telefonos As New List(Of String)(txtTelefono.Text.Split(","))

        For i = 0 To telefonos.Count - 1

            telefonos(i) = RemoverEspacios(telefonos(i))

        Next

        Dim especialidades As New List(Of String)(txtEspecialidad.Text.Split(","))

        For i = 0 To especialidades.Count - 1

            especialidades(i) = RemoverEspacios(especialidades(i))

        Next

        Dim arrImg() As Byte = {}

        If pBoxFotoMedico.Image Is Nothing Then
            If MessageBox.Show("¿Desea ingresar al usuario sin una imagen de identificación?", "Falta ingresar información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
                Exit Sub
            End If
        Else
            Dim mStream As New IO.MemoryStream
            Dim tamanoFoto As UInteger = mStream.Length
            pBoxFotoMedico.Image.Save(mStream, Imaging.ImageFormat.Png)
            arrImg = mStream.GetBuffer()
            mStream.Close()

        End If

        Dim medico As New Medico(cedula, nombre1, nombre2, apellido1, apellido2, direccion, telefonos, correo, contrasena, especialidades, arrImg)

        If medico.checkDatos() Then 'Datos de clase base Usuario
            If medico.checkDatosMed() Then 'En el caso del medico, ademas de los datos de la clase base validamos especialidad
                'Hacer alta o modificacion dependiendo de lo que haya seleccionado el administrador

                If altaOmod = 0 Then 'Hacer alta
                    Conectar()

                    Try
                        conn.Execute(CREATEUSER("u" & medico.Cedula, medico.Contrasena, "medico"))
                    Catch ex As Exception
                        MsgBox("No se pudo ingresar el USER de MYSQL " & ex.Message)
                        Exit Sub
                    End Try

                    Try
                        conn.Execute(GRANTROLE("medico", "u" & medico.Cedula))
                    Catch ex As Exception
                        MsgBox("No se pudo dar ROL ")
                        Exit Sub
                    End Try

                    Try
                        conn.Execute(INSERTUSUARIO(medico.Cedula, medico.Nombre1, medico.Nombre2, medico.Apellido1, medico.Apellido2, medico.direccion(0), medico.direccion(1), correo, arrImg))
                    Catch ex As Exception
                        MsgBox("No se pudo ingresar el USUARIO de SIBIM" & " " & ex.Message)
                        Exit Sub
                    End Try

                    For Each t As String In medico.telefonosLista
                        Try
                            conn.Execute(INSERTTELEFONO(medico.Cedula, t))
                        Catch ex As Exception
                            MsgBox("No se pudo ingresar el telefono:" & t & " " & ex.Message)
                            Exit Sub
                        End Try
                    Next

                    Try
                        conn.Execute(INSERTMEDICO(medico.Cedula))
                    Catch ex As Exception
                        MsgBox("No se pudo ingresar el medico " & " " & ex.Message)
                        Exit Sub
                    End Try

                    For Each esp As String In medico.Especialidad

                        Try
                            conn.Execute(INSERTMEDICO_especialidad(medico.Cedula, esp))
                        Catch ex As Exception
                            MsgBox("No se pudo ingresar la especialidad " & esp & " " & ex.Message)
                            Exit Sub
                        End Try

                    Next

                Else 'Hacer modificacion

                End If
            End If
        Else
        End If

    End Sub

    Private Sub txtCedula_KeyPress(sender As Object, e As KeyPressEventArgs)  'No dejarlo poner espacios
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre2_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtApellido1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtApellido2_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCorreo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub pBoxFotoMedico_Click(sender As Object, e As EventArgs)
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
        LimpiarControles(Me)
        configurarControles()
    End Sub

    Public Sub configurarControles()

        Select Case altaOmod
            Case 0
                For Each c As Control In Me.Controls

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

    Private Sub txtCedula_TextChanged(sender As Object, e As EventArgs)
        ci = txtCedula.Text

        If ci.Length = 8 Then
            ci_valida = check_Cedula(ci)
            If ci_valida = False Then
                MessageBox.Show(MensajeDeErrorCedula(), "Verifique la información ingresada.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If check_UsuarioExiste("u" & ci) Then
                    ci_valida = False
                    MessageBox.Show(ElUsuarioYaExiste(), "Usuario ya registrado.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    ci_valida = True
                End If
            End If
        Else
            ci_valida = check_Cedula(ci)
        End If

        configurarControles()

    End Sub

End Class