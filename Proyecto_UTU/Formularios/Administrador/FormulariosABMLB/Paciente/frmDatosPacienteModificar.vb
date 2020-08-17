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

        Dim telefonos As String() = txtTelefono.Text.Split(",")

        For i = 0 To telefonos.Count - 1

            telefonos(i) = RemoverEspacios(telefonos(i))

        Next

        Dim paciente As New Paciente(cedula, nombre1, nombre2, apellido1, apellido2, direccion, telefonos, correo, contrasena, edad, sexo, ocupacion, e_civil)

        If paciente.checkDatos() Then

            If paciente.checkDatosPaciente() Then
                'Hacer alta o modificacion dependiendo de lo que haya seleccionado el administrador

                Conectar()

                Dim sqlmysqlUser = String.Format("CREATE USER '{0}'@'localhost' IDENTIFIED BY '{1}' DEFAULT ROLE '{2}'@'localhost'", "u" & paciente.Cedula, paciente.Contrasena, "paciente")

                Try
                    conn.Execute(sqlmysqlUser)
                Catch ex As Exception
                    MsgBox("No se pudo ingresar el USER " & ex.Message)
                End Try

                Dim sqlGrantRoleUser = String.Format("GRANT 'paciente'@'localhost' TO '{0}'@'localhost';", "u" & paciente.Cedula)

                Try
                    conn.Execute(sqlGrantRoleUser)
                Catch ex As Exception
                    MsgBox("No se pudo dar GRANT")
                End Try

                Dim sqlUSUARIO = String.Format("INSERT INTO usuario (CI,nombre1,nombre2,apellido1,apellido2,direccion_calle,direccion_nroPuerta, correo) VALUES ({0},{1},{2},{3},{5},{6},{7})", paciente.Cedula, paciente.Nombre1, paciente.Nombre2, paciente.Apellido1, paciente.Apellido2, paciente.direccion(0), paciente.direccion(1), paciente.Correo)
                Try
                    conn.Execute(sqlUSUARIO)
                Catch ex As Exception
                    MsgBox("No se pudo ingresar el USUARIO")
                End Try

                For Each t As String In paciente.telefonosLista
                    Dim sqlTelefonos = String.Format("INSERT INTO usuario_tel (CI,telefono) VALUES ({0},{1})", paciente.Cedula, t)

                    Try
                        conn.Execute(sqlTelefonos)
                    Catch ex As Exception
                        MsgBox("No se pudo ingresar el telefono:" & t)
                    End Try
                Next

                Dim sqlPACIENTE = String.Format("INSERT INTO paciente (CI,edad,etapa,e_civil,ocupacion,sexo) VALUES ({0},{1},{2},{3},{5})", paciente.Cedula, paciente.Edad, String.Empty, paciente.Estado_civil, paciente.Ocupacion, paciente.Sexo)

                Try
                    conn.Execute(sqlPACIENTE)
                Catch ex As Exception
                    MsgBox("No se pudo ingresar el PACIENTE")
                End Try

                Cerrar()

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