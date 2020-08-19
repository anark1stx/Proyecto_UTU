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

        Dim direccion As New List(Of String)(txtDireccion.Text.Split(","))
        For i = 0 To direccion.Count - 1

            direccion(i) = RemoverEspacios(direccion(i))

        Next

        Dim telefonos As New List(Of String)(txtTelefono.Text.Split(","))

        For i = 0 To telefonos.Count - 1

            telefonos(i) = RemoverEspacios(telefonos(i))

        Next

        Dim paciente As New Paciente(cedula, nombre1, nombre2, apellido1, apellido2, direccion, telefonos, correo, contrasena, edad, sexo, ocupacion, e_civil)

        If paciente.checkDatos() Then

            If paciente.checkDatosPaciente() Then
                'Hacer alta o modificacion dependiendo de lo que haya seleccionado el administrador
                If altaOmod = 0 Then '0 = alta
                    Conectar()

                    'mandar estos dos try a un método que lo haga 
                    Try
                        conn.Execute(CREATEUSER("u" & paciente.Cedula, paciente.Contrasena, "paciente"))
                    Catch ex As Exception
                        MsgBox("No se pudo ingresar el USER de MYSQL " & ex.Message)
                        Exit Sub
                    End Try

                    Try
                        conn.Execute(GRANTROLE("paciente", "u" & paciente.Cedula))
                    Catch ex As Exception
                        MsgBox("No se pudo dar ROL ")
                        Exit Sub
                    End Try

                    'mandar estos dos a otro metodo tambien
                    Try
                        conn.Execute(INSERTUSUARIO(paciente.Cedula, paciente.Nombre1, paciente.Nombre2, paciente.Apellido1, paciente.Apellido2, paciente.direccion(0), paciente.direccion(1), correo))
                    Catch ex As Exception
                        MsgBox("No se pudo ingresar el USUARIO de SIBIM" & " " & ex.Message)
                        Exit Sub
                    End Try

                    For Each t As String In paciente.telefonosLista
                        Try
                            conn.Execute(INSERTTELEFONO(paciente.Cedula, t))
                        Catch ex As Exception
                            MsgBox("No se pudo ingresar el telefono:" & t & " " & ex.Message)
                            Exit Sub
                        End Try
                    Next

                    Try
                        conn.Execute(INSERTPACIENTE(paciente.Cedula, paciente.Edad, String.Empty, paciente.Estado_civil, paciente.Ocupacion, paciente.Sexo.Substring(0, 1)))
                    Catch ex As Exception
                        MsgBox("No se pudo ingresar el PACIENTE " & " " & ex.Message)
                        Exit Sub
                    End Try

                Else ' hacer modificacion

                End If

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

    Private Sub txtCedula_TextChanged(sender As Object, e As EventArgs) Handles txtCedula.TextChanged
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