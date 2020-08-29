﻿Imports Entidades
Imports Negocio
Public Class frmDatosPacienteModificar
    Public Npaciente As New N_Paciente
    Public altaOmod As Integer = 0 '0 es para alta, 1 para modificacion
    Dim ci_valida As Boolean = 0
    Dim ci As String
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarControles(Me)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If Not ci_valida Then
            MessageBox.Show("Ingrese los datos del usuario para efectuar la acción.", "Falta guardar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Dim cedula As Integer = Val(txtCedula.Text)
        Dim nombre1 As String = txtNombre1.Text
        Dim nombre2 As String = txtNombre2.Text
        Dim apellido1 As String = txtApellido1.Text
        Dim apellido2 As String = txtApellido2.Text
        Dim correo As String = txtCorreo.Text
        Dim contrasena As String = txtContrasena.Text
        Dim fechaNacimiento As String = dateFechaNacimiento.Value.ToString("yyyy-MM-dd")

        Dim sexo As Char
        Select Case cbSexo.SelectedItem.ToString()
            Case "Masculino"
                sexo = "M"c
            Case Else
                sexo = "F"c
        End Select

        Dim ocupacion As String = txtOcupacion.Text
        Dim e_civil As String = cb_e_civil.SelectedItem

        Dim direccion As New List(Of String)(txtDireccion.Text.Split(","))
        For i = 0 To direccion.Count - 1
            direccion(i) = RemoverEspacios(direccion(i))
        Next

        If cbTelefonos.Items.Count < 1 Then
            MessageBox.Show("Ingrese al menos un telefono de contacto.", "Falta ingresar información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim telefonos As New List(Of String)
        For Each t As String In cbTelefonos.Items
            telefonos.Add(t)
        Next


        For i = 0 To telefonos.Count - 1
            telefonos(i) = RemoverEspacios(telefonos(i))
        Next

        Dim arrImg() As Byte = {}

        If pBoxFotoPaciente.Image Is Nothing Then
            If MessageBox.Show("¿Desea ingresar al usuario sin una imagen de identificación?", "Falta guardar información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
                Exit Sub
            End If
        Else
            Dim mStream As New IO.MemoryStream
            pBoxFotoPaciente.Image.Save(mStream, Imaging.ImageFormat.Png)
            arrImg = mStream.GetBuffer()

            mStream.Close()

        End If

        Dim paciente = New E_Paciente(cedula, nombre1, nombre2, apellido1, apellido2, direccion, telefonos, correo, contrasena, fechaNacimiento, sexo, ocupacion, e_civil, arrImg, "a"c, "paciente")

        If paciente.ValidarMisDatos() Then
            If altaOmod = 0 Then '0 = alta
                Dim resultadoCMD = Npaciente.AltaPaciente(paciente)

                Select Case resultadoCMD
                    Case 0
                        MessageBox.Show("El paciente no pudo ser ingresado.", "Alta fallo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case 1
                        MessageBox.Show("Paciente ingresado con éxito", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LimpiarControles(Me)
                    Case 2
                        MessageBox.Show("No se pudo crear el usuario de mysql", "Alta fallo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case 3
                        MessageBox.Show("No se pudo ingresar el telefono " & paciente.ErrMsg, "Alta fallo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End Select

            Else '1 = Mod

            End If
        Else
            MessageBox.Show(paciente.ErrMsg, "Ingreso de información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If



        '    If paciente.checkDatos() Then

        '        If paciente.checkDatosPaciente() Then

        '            'Hacer alta o modificacion dependiendo de lo que haya seleccionado el administrador
        '            If altaOmod = 0 Then '0 = alta

        '                Conectar()

        '                'mandar estos dos try a un método que lo haga 
        '                Try
        '                    conn.Execute(CREATEUSER("u" & paciente.Cedula, paciente.Contrasena, "paciente"))
        '                Catch ex As Exception
        '                    MsgBox("No se pudo ingresar el USER de MYSQL " & ex.Message)
        '                    Exit Sub
        '                End Try

        '                Try
        '                    conn.Execute(GRANTROLE("paciente", "u" & paciente.Cedula))
        '                Catch ex As Exception
        '                    MsgBox("No se pudo dar ROL ")
        '                    Exit Sub
        '                End Try

        '                'AGREGAR LA IMAGEN AL ALTA DEL USUARIO
        '                Try
        '                    Dim sql = INSERTUSUARIO(paciente.Cedula, paciente.Nombre1, paciente.Nombre2, paciente.Apellido1, paciente.Apellido2, paciente.direccion(0), paciente.direccion(1), correo)
        '                    Console.WriteLine(sql)
        '                    conn.Execute(sql)
        '                Catch ex As Exception
        '                    MsgBox("No se pudo ingresar el USUARIO de SIBIM" & " " & ex.Message)
        '                    Exit Sub
        '                End Try

        '                If Not pBoxFotoPaciente.Image Is Nothing Then
        '                    Try
        '                        rs.Open(SELECTSIBIMUSUARIO(paciente.Cedula), conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        '                        rs("foto").AppendChunk(paciente.imagen)
        '                        rs.Update()
        '                    Catch ex As Exception
        '                        MsgBox(ex.Message)
        '                        Exit Sub
        '                    End Try
        '                End If

        '                For Each t As String In paciente.telefonosLista
        '                    Try
        '                        conn.Execute(INSERTTELEFONO(paciente.Cedula, t))
        '                    Catch ex As Exception
        '                        MsgBox("No se pudo ingresar el telefono:" & t & " " & ex.Message)
        '                        Exit Sub
        '                    End Try
        '                Next

        '                Try
        '                    conn.Execute(INSERTPACIENTE(paciente.Cedula, paciente.FechaNacimiento, paciente.Estado_civil, paciente.Ocupacion, paciente.Sexo.Substring(0, 1)))
        '                Catch ex As Exception
        '                    MsgBox("No se pudo ingresar el PACIENTE " & " " & ex.Message)
        '                    Exit Sub
        '                End Try

        '                MessageBox.Show("El usuario fue ingresado con éxito.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '            Else ' hacer modificacion

        '            End If

        '        End If

        '    End If

    End Sub

    Private Sub frmDatosPacienteModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarControles(Me)
        cbSexo.SelectedIndex = 0
        cb_e_civil.SelectedIndex = 0
        configurarControles()
    End Sub

    Public Sub configurarControles()

        Select Case altaOmod
            Case 0
                For Each c As Control In Me.Controls

                    If Not ci_valida Then
                        If TypeOf c Is ComboBox Or TypeOf c Is DateTimePicker Or TypeOf c Is TextBox AndAlso c IsNot txtCedula Then
                            c.Enabled = False
                        End If
                    Else
                        If TypeOf c Is TextBox Or TypeOf c Is DateTimePicker Or TypeOf c Is ComboBox Then
                            c.Enabled = True
                        End If
                    End If

                Next
            Case 1
                txtCedula.Enabled = False
                For Each c As Control In Controls

                    If TypeOf c Is ComboBox Or TypeOf c Is DateTimePicker Or TypeOf c Is TextBox AndAlso c IsNot txtCedula Then
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
                If Npaciente.UsuarioExiste(ci) Then
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

            OFD.Filter = "Imagen (*.jpg;*.png)|*.jpg;*.png"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                pBoxFotoPaciente.ImageLocation = imgpath
            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnAgregarTelefono_Click(sender As Object, e As EventArgs) Handles btnAgregarTelefono.Click

        If cbTelefonos.Text Is String.Empty Then
            MessageBox.Show("Escriba el teléfono que desea ingresar.", "Falta ingresar información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not check_Telefonos(New List(Of String)(New String() {cbTelefonos.Text})) Then
            MessageBox.Show("Teléfono inválido.", "Información errónea", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            If cbTelefonos.Items.IndexOf(cbTelefonos.Text) < 0 Then
                cbTelefonos.Items.Add(cbTelefonos.Text)
            Else
                MessageBox.Show("Ese teléfono ya fue ingresado en la lista.", "Información duplicada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub

    Private Sub btnSacarTelefono_Click(sender As Object, e As EventArgs) Handles btnSacarTelefono.Click
        If cbTelefonos.Text Is String.Empty Then
            MessageBox.Show("Seleccione el teléfono que desea remover.", "Falta seleccionar elemento", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        cbTelefonos.Items.Remove(cbTelefonos.Text)

    End Sub
End Class