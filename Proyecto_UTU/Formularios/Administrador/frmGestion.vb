Imports Entidades
Imports Negocio
Imports Utilidades
Public Class frmGestion
    Protected ctrlsPaciente As List(Of Control)
    Protected ctrlsUsuario As List(Of Control)
    Protected ctrlsMedico As List(Of Control)
    Protected _accion As Accion
    Protected _tipo As TipoUsuario
    Protected _filtro As Filtro
    Private ci_valida As Boolean = False
    Dim p As New E_Paciente
    Dim pList As New List(Of E_Paciente)
    Dim m As New E_Medico
    Dim mList As New List(Of E_Medico)
    Dim a As New E_Usuario
    Dim aList As New List(Of E_Usuario)
    Dim bs As New BindingSource
    Public Enum Accion
        Alta
        Baja
        Modificacion
    End Enum

    Public Enum TipoUsuario
        Paciente
        Medico
        Auxiliar
    End Enum

    Public Enum Filtro
        Cedula
        Apellido
        Especialidad
    End Enum

    Property Mode As Accion
        Get
            Return _accion
        End Get
        Set(value As Accion)
            _accion = value
        End Set
    End Property

    Property Usuario As TipoUsuario
        Get
            Return _tipo
        End Get
        Set(value As TipoUsuario)
            _tipo = value
        End Set
    End Property

    Property Filter As Filtro
        Get
            Return _filtro
        End Get
        Set(value As Filtro)
            _filtro = value
        End Set
    End Property

    ReadOnly Property BASEcontrolesU As List(Of Control)
        Get
            Return New List(Of Control)(New Control() {lblCedulaTXT, lblNombre1TXT, lblNombre2TXT, lblApellido1TXT, lblApellido2TXT, lblDireccionTXT, lblDireccionNumeroTXT, lblCorreoTXT, cbTelefonos, lblContrasenaTXT})
        End Get
    End Property

    ReadOnly Property BASEcontrolesP As List(Of Control)
        Get
            Return New List(Of Control)(New Control() {lblFnac, dtpFechaNacimiento, lblEtapa, cbEtapa, lblEstadoCivil, cbEstadoCivil, lblSexo, cbSexo, lblOcupacion, lblOcupacionTXT})
        End Get
    End Property

    ReadOnly Property BASEcontrolesM As List(Of Control)
        Get
            Return New List(Of Control)(New Control() {lblEspecialidades, cbEspecialidades, pnlEspecialidadesBtns, rBtnEspecialidad})
        End Get
    End Property

    Property ControlesUsuario As List(Of Control)
        Get
            Return ctrlsUsuario
        End Get
        Set(value As List(Of Control))
            ctrlsUsuario = value
        End Set
    End Property

    Property ControlesPaciente As List(Of Control)
        Get
            Return ctrlsPaciente
        End Get
        Set(value As List(Of Control))
            ctrlsPaciente = value
        End Set
    End Property

    Property ControlesMedico As List(Of Control)
        Get
            Return ctrlsMedico
        End Get
        Set(value As List(Of Control))
            ctrlsMedico = value
        End Set
    End Property

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RRefresh()
        setup()
    End Sub

    Sub setup()
        cambiarVisibilidad()
        resetMode()
        ConvertirProps()
        configurarControles()
        cbEtapa.SelectedIndex = 0
        cbEstadoCivil.SelectedIndex = 0
        cbSexo.SelectedIndex = 0
    End Sub

    Sub resetMode()
        Select Case Mode
            Case Accion.Alta
                btnAccion1.ImageIndex = 1 '1 = Alta
                btnAccion2.ImageIndex = 1 '1 = limpiar
                pnlContenedorBusqueda.Visible = False
                pnlBotonesTel.Visible = True
            Case Accion.Modificacion
                btnAccion1.ImageIndex = 2 '2 = Mod Tick
                btnAccion2.ImageIndex = 1 '1 = limpiar
                pnlContenedorBusqueda.Visible = True
                pnlBotonesTel.Visible = True
            Case Accion.Baja
                btnAccion1.ImageIndex = 0 '0 = Baja
                btnAccion2.ImageIndex = 0 '1 = Modificar
                pnlContenedorBusqueda.Visible = True
                pnlBotonesTel.Visible = False

        End Select
    End Sub

    Sub cambiarVisibilidad()

        Select Case Usuario
            Case TipoUsuario.Auxiliar
                For Each c As Control In ControlesMedico
                    c.Visible = False
                Next

                For Each c As Control In ControlesPaciente
                    c.Visible = False
                Next
            Case TipoUsuario.Medico
                For Each c As Control In ControlesMedico
                    c.Visible = True
                Next

                For Each c As Control In ControlesPaciente
                    c.Visible = False
                Next
            Case TipoUsuario.Paciente
                For Each c As Control In ControlesMedico
                    c.Visible = False
                Next

                For Each c As Control In ControlesPaciente
                    c.Visible = True
                Next
        End Select
    End Sub

    Public Sub ConvertirProps()

        Dim news As New List(Of Control)
        Dim _readonly As Boolean = True

        Select Case Mode
            Case Accion.Alta, Accion.Modificacion 'Todo en textboxes con fondo blanco
                _readonly = False
            Case Accion.Baja
                _readonly = True 'Todo en textboxes pero con fondo celeste, como si fuera label.
        End Select

        Dim l As New List(Of Control)
        For Each c As Control In ControlesUsuario
            l.Add(convertirC(c, _readonly))
        Next
        ControlesUsuario = l

        Select Case Usuario
            Case TipoUsuario.Paciente
                Dim l2 As New List(Of Control)
                For Each c As Control In ControlesPaciente
                    l2.Add(convertirC(c, _readonly))
                Next
                ControlesPaciente = l2
            Case TipoUsuario.Medico
                Dim l2 As New List(Of Control)
                For Each c As Control In ControlesMedico
                    l2.Add(convertirC(c, _readonly))
                Next
                ControlesMedico = l2
        End Select

    End Sub

    Public Function convertirC(c As Control, _readonly As Boolean) As Control
        Select Case c.GetType()
            Case GetType(ComboBox)
                c = DirectCast(c, ComboBox)
                If DirectCast(c, ComboBox).DropDownStyle = ComboBoxStyle.DropDown Then
                    c.Enabled = True
                    Return c
                End If

                c.Enabled = Not _readonly

                Return c

            Case GetType(DateTimePicker)
                c.Enabled = Not _readonly
                Return c
            Case GetType(TextBox)

                DirectCast(c, TextBox).ReadOnly = _readonly

                If _readonly Then
                    c.BackColor = Color.LightBlue
                    DirectCast(c, TextBox).BorderStyle = BorderStyle.None
                Else
                    c.BackColor = Color.White
                    DirectCast(c, TextBox).BorderStyle = BorderStyle.Fixed3D
                End If
                Return c

            Case GetType(MaskedTextBox)
                DirectCast(c, MaskedTextBox).ReadOnly = _readonly

                If _readonly Then
                    c.BackColor = Color.LightBlue
                    DirectCast(c, MaskedTextBox).BorderStyle = BorderStyle.None
                Else
                    c.BackColor = Color.White
                    DirectCast(c, MaskedTextBox).BorderStyle = BorderStyle.Fixed3D
                End If
                Return c
            Case Else
                Return c
        End Select
    End Function

    Public Sub RRefresh()
        ControlesMedico = BASEcontrolesM
        ControlesPaciente = BASEcontrolesP
        ControlesUsuario = BASEcontrolesU
    End Sub

    Private Sub btnAgregarTelefono_Click(sender As Object, e As EventArgs) Handles btnAgregarTelefono.Click

        If Not check_Telefonos(New List(Of String)(New String() {cbTelefonos.Text})) Then
            MessageBox.Show("Teléfono inválido. " & optMsg, "Información errónea", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

        If cbTelefonos.DataSource IsNot Nothing Then
            cbTelefonos.DataSource = Nothing
        End If

        cbTelefonos.Items.Remove(cbTelefonos.Text)
    End Sub

    Private Sub btnAgregarEspecialidad_Click(sender As Object, e As EventArgs) Handles btnAgregarEspecialidad.Click

        If Not check_Largo(cbEspecialidades.Text, 3, 50, True) Then
            MessageBox.Show("Especialidad inválida.", "Información errónea", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            If cbEspecialidades.Items.IndexOf(cbEspecialidades.Text) < 0 Then
                cbEspecialidades.Items.Add(cbEspecialidades.Text)
            Else
                MessageBox.Show("Esa especialidad ya fue ingresado en la lista.", "Información duplicada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnBorrarEspecialidad_Click(sender As Object, e As EventArgs) Handles btnBorrarEspecialidad.Click
        If cbEspecialidades.Text Is String.Empty Then
            MessageBox.Show("Seleccione la especialidad que desea remover.", "Falta seleccionar elemento", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        cbEspecialidades.Items.Remove(cbEspecialidades.Text)
    End Sub

    Private Sub lblCedulaTXT_TextChanged(sender As Object, e As EventArgs) Handles lblCedulaTXT.TextChanged
        configurarControles()
    End Sub

    Public Sub configurarControles()

        Select Case Mode
            Case Accion.Alta
                lblCedulaTXT.Enabled = True

                If lblCedulaTXT.Text.Length = lblCedulaTXT.MaxLength Then
                    If Not check_Cedula(lblCedulaTXT.Text) Then
                        MessageBox.Show(MensajeDeErrorCedula(), "Información no válida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ci_valida = False
                    Else
                        ci_valida = True
                    End If
                    If Mode = Accion.Alta AndAlso ci_valida Then
                        Dim nu As New N_Usuario

                        If nu.UsuarioExiste(Val(lblCedulaTXT.Text)) Then
                            MessageBox.Show("Ya existe un usuario registrado con esa cédula en la base de datos.", "Usuario ya registrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            ci_valida = False
                        Else
                            Console.WriteLine("el usuario no existe")
                            ci_valida = True
                        End If
                    End If
                Else
                    ci_valida = False
                End If

                If Not ci_valida Then
                    pnlDspCedula.Enabled = False
                Else
                    pnlDspCedula.Enabled = True
                End If
                cbEtapa.Enabled = False

            Case Accion.Modificacion
                lblCedulaTXT.Enabled = False
                cbEtapa.Enabled = True
                If lblCedulaTXT.Text Is String.Empty Then
                    pnlDspCedula.Enabled = False
                Else
                    pnlDspCedula.Enabled = True
                End If
            Case Accion.Baja
                lblCedulaTXT.Enabled = False
        End Select
    End Sub

    Private Sub btnAccion1_Click(sender As Object, e As EventArgs) Handles btnAccion1.Click
        Select Case Mode
            Case Accion.Alta
                AltaU()
            Case Accion.Baja
                BajaU()
            Case Accion.Modificacion
                ModificarU()
        End Select
    End Sub

    Private Sub btnAccion2_Click(sender As Object, e As EventArgs) Handles btnAccion2.Click
        Select Case Mode
            Case Accion.Alta, Accion.Modificacion 'limpiar
                LimpiarControles(Me)
            Case Accion.Baja 'editar
                Mode = Accion.Modificacion
                setup()
        End Select
    End Sub

    Sub AltaU()
        If cbTelefonos.Items.Count < 1 Then
            MessageBox.Show("Ingrese al menos un telefono de contacto.", "Falta ingresar información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim fi As New IO.FileInfo(pBoxFotoUsuario.ImageLocation)
        Dim nombreFoto = fi.Name

        Select Case Usuario
            Case TipoUsuario.Paciente
                Dim u = Base_props_user()
                If u.Cedula = 0 Then
                    Exit Sub
                End If
                Dim p = Base_props_paciente(u)

                If Not p.ValidarMisDatos() Then
                    MessageBox.Show(p.ErrMsg, "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else

                    Dim np As New N_Paciente
                    Dim res = np.AltaPaciente(p)
                    Select Case res
                        Case 0
                            MessageBox.Show("El paciente no pudo ser ingresado.", "Alta fallo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Case 1
                            MessageBox.Show("Paciente ingresado con éxito", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LimpiarControles(Me)
                        Case 2
                            MessageBox.Show("No se pudo crear el usuario de mysql", "Alta fallo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Case 3
                            MessageBox.Show("No se pudo ingresar el telefono " & p.ErrMsg, "Alta fallo", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End Select
                End If

            Case TipoUsuario.Medico
                Dim u = Base_props_user()

                If u.Cedula = 0 Then
                    Exit Sub
                End If

                Dim m = Base_Props_Medico(u)
                If Not m.ValidarMisDatos() Then
                    MessageBox.Show(m.ErrMsg, "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    Dim nm As New N_Medico
                    Dim res = nm.AltaMedico(m)
                    Select Case res
                        Case 0
                            MessageBox.Show("El médico no pudo ser ingresado.", "Alta fallo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Case 1
                            MessageBox.Show("Médico ingresado con éxito", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LimpiarControles(Me)
                        Case 2
                            MessageBox.Show("No se pudo crear el usuario de mysql", "Alta fallo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Case 3
                            MessageBox.Show("No se pudo ingresar el telefono " & m.ErrMsg, "Alta fallo", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End Select
                End If
            Case TipoUsuario.Auxiliar

                Dim u = Base_props_user()
                If u.Cedula = 0 Then
                    Exit Sub
                End If

                If Not u.ValidarMisDatos() Then
                    MessageBox.Show(u.ErrMsg, "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim nu As New N_Usuario
                Dim res = nu.AltaUsuarioSIBIM(u)
                Select Case res
                    Case 0
                        MessageBox.Show("El auxiliar no pudo ser ingresado.", "Alta fallo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case 1
                        MessageBox.Show("Auxiliar ingresado con éxito", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LimpiarControles(Me)
                    Case 2
                        MessageBox.Show("No se pudo crear el usuario de mysql", "Alta fallo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case 3
                        MessageBox.Show("No se pudo ingresar el telefono " & u.ErrMsg, "Alta fallo", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End Select
        End Select

    End Sub

    Function Base_Props_Medico(u As E_Usuario) As E_Medico

        Dim u_default As New E_Usuario
        If cbEspecialidades.Items.Count < 1 Then
            MessageBox.Show("Ingrese al menos una especialidad.", "Falta ingresar información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return New E_Medico With {
                .Cedula = 0
            }
        End If

        Dim especialidades As New List(Of String)
        For Each es As String In cbEspecialidades.Items
            especialidades.Add(es)
        Next

        Return New E_Medico With {
                    .Nombre = u.Nombre,
                    .Contrasena = u.Contrasena,
                    .Rol = "medico",
                    .Cedula = u.Cedula,
                    .Nombre1 = u.Nombre1,
                    .Nombre2 = u.Nombre2,
                    .Apellido1 = u.Apellido1,
                    .Apellido2 = u.Apellido2,
                    .Direccion_Calle = u.Direccion_Calle,
                    .Direccion_Numero = u.Direccion_Numero,
                    .Foto = u.Foto,
                    .Activo = u.Activo,
                    .Correo = u.Correo,
                    .TelefonosLista = u.TelefonosLista,
                    .Especialidad = especialidades
        }

    End Function

    Function Base_props_paciente(u As E_Usuario) As E_Paciente
        Dim u_default As New E_Usuario
        Return New E_Paciente With {
            .Nombre = u.Nombre,
            .Contrasena = u.Contrasena,
            .Rol = "paciente",
            .Cedula = u.Cedula,
            .Nombre1 = u.Nombre1,
            .Nombre2 = u.Nombre2,
            .Apellido1 = u.Apellido1,
            .Apellido2 = u.Apellido2,
            .Direccion_Calle = u.Direccion_Calle,
            .Direccion_Numero = u.Direccion_Numero,
            .Foto = u.Foto,
            .Activo = u.Activo,
            .Correo = u.Correo,
            .TelefonosLista = u.TelefonosLista,
            .Etapa = cbEtapa.SelectedItem.ToString(),
            .Estado_civil = cbEstadoCivil.SelectedItem().ToString(),
            .FechaNacimiento = dtpFechaNacimiento.Value,
            .Ocupacion = lblOcupacionTXT.Text,
            .Sexo = cbSexo.SelectedItem.ToString()
        }
    End Function

    Function Base_props_user() As E_Usuario
        Dim u_default As New E_Usuario
        Dim direccion As New List(Of String)({lblDireccionTXT.Text, lblDireccionNumeroTXT.Text})

        For i = 0 To direccion.Count - 1
            direccion(i) = RemoverEspacios(direccion(i))
        Next

        If Not check_direccion(direccion) Then
            MessageBox.Show(MensajeDeErrorDireccion(), "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            u_default.Cedula = 0
            Return u_default
        End If

        Dim telefonos As New List(Of String)
        For Each t As String In cbTelefonos.Items
            telefonos.Add(t)
        Next

        If pBoxFotoUsuario.Image Is Nothing Then
            If MessageBox.Show("¿Seguro que desea ingresar al usuario sin imagen?", "Falta ingresar información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
                u_default.Cedula = 0
                Return u_default
            End If
        End If

        Return New E_Usuario With {
                    .Nombre = "u" & lblCedulaTXT.Text,
                    .Contrasena = lblContrasenaTXT.Text,
                    .Rol = "auxiliar", 'rol default
                    .Cedula = Val(lblCedulaTXT.Text),
                    .Nombre1 = lblNombre1TXT.Text,
                    .Nombre2 = lblNombre2TXT.Text,
                    .Apellido1 = lblApellido1TXT.Text,
                    .Apellido2 = lblApellido2TXT.Text,
                    .Direccion_Calle = direccion(0),
                    .Direccion_Numero = direccion(1),
                    .Foto = Image2Bytes(pBoxFotoUsuario.Image),
                    .Activo = 1,
                    .Correo = lblCorreoTXT.Text,
                    .TelefonosLista = telefonos
        }
    End Function

    Sub BajaU()
        Dim u As New E_Usuario
        Try
            u.Cedula = lblCedulaTXT.Text
        Catch ex As Exception
            MessageBox.Show("Seleccione el usuario que desea eliminar primero.")
            Exit Sub
        End Try

        If MessageBox.Show("Seguro que desea dar de baja al usuario " & u.Nombre1 & " " & u.Apellido1 & "?", "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
            Exit Sub
        End If

        Dim nu As New N_Usuario

        Dim res = nu.BajaLogicaUsuario(u)

        Select Case res
            Case 0
                MessageBox.Show("No se pudo dar de baja al usuario", "Baja fallo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 1
                MessageBox.Show("El usuario fue dado de baja.", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Sub AltaULogica()
        Dim u As New E_Usuario With {
            .Cedula = lblCedulaTXT.Text
        }

        Dim nu As New N_Usuario

        Dim res = nu.AltaLogicaUsuario(u)

        Select Case res
            Case 0
                MessageBox.Show("No se pudo dar de baja al usuario", "Baja fallo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 1
                MessageBox.Show("El usuario fue dado de baja.", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub

    Sub BuscarU()
        '()->Buscar[Usuario]x[PARAMETRO]
    End Sub

    Sub ModificarU()
        Dim u = Base_props_user()
        Dim code As Integer = 0
        Select Case Usuario
            Case TipoUsuario.Auxiliar
                Dim nu As New N_Usuario
                code = nu.ModificacionUsuario(u)
            Case TipoUsuario.Paciente
                Dim np As New N_Paciente
                u = Base_props_paciente(u)
                code = np.ModificacionPaciente(u)
            Case TipoUsuario.Medico
                Dim nm As New N_Medico
                u = Base_Props_Medico(u)
                code = nm.ModificacionMedico(u)
        End Select

        Select Case code
            Case 0
                MessageBox.Show("El usuario no pudo ser modificado", "Error modificando", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 1
                MessageBox.Show("El usuario fue modificado con éxito", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select

    End Sub

    Private Sub SinEspacios(sender As Object, e As KeyPressEventArgs) Handles lblCedulaTXT.KeyPress, lblCorreoTXT.KeyPress, cbTelefonos.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub pBoxFotoUsuario_Click(sender As Object, e As EventArgs) Handles pBoxFotoUsuario.Click
        Dim img = subirImagen()
        If Not img Is Nothing Then
            pBoxFotoUsuario.ImageLocation = img
        End If
    End Sub

    Private Async Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Select Case Usuario
            Case TipoUsuario.Paciente
                Dim np As New N_Paciente
                Select Case Filter
                    Case Filtro.Cedula

                        If Not check_Cedula(txtBusqueda.Text) Then
                            MessageBox.Show(MensajeDeErrorCedula(), "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If

                        p = Await Task.Run(Function() np.ListarPacienteCI(txtBusqueda.Text))
                        If p.Cedula = 0 Then
                            MessageBox.Show("No fue encontrado un paciente con esa cédula.", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If

                        bs.DataSource = p
                        basicBindings(p)
                        dgwSetup(dgwUsuarios, bs)
                        PacienteBindings(p)
                        pList.Add(p)
                    Case Filtro.Apellido
                        pList = Await Task.Run(Function() np.BuscarPacienteApellido(txtBusqueda.Text))

                        If pList(0).Cedula = 0 Then
                            MessageBox.Show("No se encontraron PACIENTES con ese apellido", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If

                        p = pList(0)

                        bs.DataSource = pList
                        basicBindings(p)
                        dgwSetup(dgwUsuarios, bs)
                        PacienteBindings(p)
                        pList.Add(p)
                End Select

            Case TipoUsuario.Medico
                Dim nm As New N_Medico
                Select Case Filter
                    Case Filtro.Cedula
                        If Not check_Cedula(txtBusqueda.Text) Then
                            MessageBox.Show(MensajeDeErrorCedula(), "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                        m = Await Task.Run(Function() nm.ListarMedicoCI(txtBusqueda.Text))
                        If m.Cedula = 0 Then
                            MessageBox.Show("No fue encontrado un médico con esa cédula.", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If

                        bs.DataSource = m
                        basicBindings(m)
                        MedicoBindings(m)
                        dgwSetup(dgwUsuarios, bs)
                        mList.Add(m)
                    Case Filtro.Apellido
                        mList = Await Task.Run(Function() nm.BuscarMedicoApellido(txtBusqueda.Text))

                        If mList(0).Cedula = 0 Then
                            MessageBox.Show("No se encontraron MÉDICOS con ese apellido", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If

                        m = mList(0)

                        bs.DataSource = mList
                        basicBindings(m)
                        dgwSetup(dgwUsuarios, bs)
                        MedicoBindings(m)
                        mList.Add(m)
                    Case Filtro.Especialidad
                        mList = Await Task.Run(Function() nm.BuscarMedicoEspecialidad(txtBusqueda.Text))
                        If mList(0).Cedula = 0 Then
                            MessageBox.Show("No se encontraron MÉDICOS con esa especialidad", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If

                        m = mList(0)

                        bs.DataSource = mList
                        basicBindings(m)
                        dgwSetup(dgwUsuarios, bs)
                        MedicoBindings(m)
                        mList.Add(m)
                End Select

            Case TipoUsuario.Auxiliar
                Dim naux As New N_Usuario
                Select Case Filter
                    Case Filtro.Cedula
                        If Not check_Cedula(txtBusqueda.Text) Then
                            MessageBox.Show(MensajeDeErrorCedula(), "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                        a = Await Task.Run(Function() naux.ListarUsuariosCI(txtBusqueda.Text, True))
                        If a.Cedula = 0 Then
                            MessageBox.Show("No fue encontrado un auxiliar con esa cédula.", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If

                        bs.DataSource = a
                        basicBindings(a)
                        dgwSetup(dgwUsuarios, bs)
                        aList.Add(a)
                    Case Filtro.Apellido
                        aList = Await Task.Run(Function() naux.BuscarUsuariosApellido(txtBusqueda.Text, True))
                        If aList(0).Cedula = 0 Then
                            MessageBox.Show("No se encontraron AUXILIARES con ese apellido", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If

                        a = aList(0)
                        bs.DataSource = aList
                        basicBindings(a)
                        dgwSetup(dgwUsuarios, bs)
                        aList.Add(a)
                End Select
        End Select
    End Sub

    Private Sub basicBindings(obj As E_Usuario)
        Console.WriteLine("Binding")
        Try
            lblCedulaTXT.DataBindings.Add("Text", obj, "Cedula", False, DataSourceUpdateMode.Never)
            lblNombre1TXT.DataBindings.Add("Text", obj, "Nombre1", False, DataSourceUpdateMode.Never)
            lblNombre2TXT.DataBindings.Add("Text", obj, "Nombre2", False, DataSourceUpdateMode.Never)
            lblApellido1TXT.DataBindings.Add("Text", obj, "Apellido1", False, DataSourceUpdateMode.Never)
            lblApellido2TXT.DataBindings.Add("Text", obj, "Apellido2", False, DataSourceUpdateMode.Never)
            lblCorreoTXT.DataBindings.Add("Text", obj, "Correo", False, DataSourceUpdateMode.Never)
            lblDireccionTXT.DataBindings.Add("Text", obj, "Direccion_Calle", False, DataSourceUpdateMode.Never)
            lblDireccionNumeroTXT.DataBindings.Add("Text", obj, "Direccion_Numero", False, DataSourceUpdateMode.Never)

            cbTelefonos.Items.AddRange(obj.TelefonosLista.ToArray)
            cbTelefonos.SelectedIndex = 0
            pBoxFotoUsuario.Image = Bytes2Image(obj.Foto)
        Catch ex As Exception
            Console.WriteLine("already binded")
        End Try
    End Sub

    Private Sub MedicoBindings(obj As E_Medico)
        cbEspecialidades.Items.AddRange(obj.Especialidad.ToArray)
        cbEspecialidades.SelectedIndex = 0
    End Sub

    Private Sub PacienteBindings(obj As E_Paciente)
        Try
            lblOcupacionTXT.DataBindings.Add("Text", obj, "Ocupacion", False, DataSourceUpdateMode.Never)
            dtpFechaNacimiento.DataBindings.Add("Value", obj, "FechaNacimiento", True, DataSourceUpdateMode.Never)
            cbEstadoCivil.SelectedItem = obj.Estado_civil
            cbEtapa.SelectedItem = obj.Etapa
            Select Case obj.Sexo
                Case "M"
                    cbSexo.SelectedItem = "Masculino"
                Case "F"
                    cbSexo.SelectedItem = "Femenino"
            End Select

        Catch ex As Exception
            Console.WriteLine("already binded")
        End Try
    End Sub

    Private Sub dgwSetup(dgw As DataGridView, b As BindingSource)
        dgw.DataSource = b
        dgw.Columns("Nombre").Visible = False
        dgw.Columns("Rol").Visible = False
        dgw.Columns("Contrasena").Visible = False
        dgw.Columns("Foto").Visible = False
        dgw.Columns("Valido").Visible = False
        dgw.Columns("ErrMsg").Visible = False
    End Sub

    Private Sub dgwUsuarios_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgwUsuarios.CellMouseClick
        LimpiarControles(pnlDatosUsuario)
        Select Case Usuario
            Case TipoUsuario.Paciente
                p = pList(dgwUsuarios.CurrentCell.RowIndex)
                basicBindings(p)
                PacienteBindings(p)
            Case TipoUsuario.Medico
                m = mList(dgwUsuarios.CurrentCell.RowIndex)
                basicBindings(m)
                MedicoBindings(m)
            Case TipoUsuario.Auxiliar
                a = aList(dgwUsuarios.CurrentCell.RowIndex)
                basicBindings(a)
                MedicoBindings(a)
        End Select

    End Sub

    Private Sub FiltroCambia(sender As Object, e As EventArgs) Handles rBtnCedula.Click, rBtnApellido.Click, rBtnEspecialidad.Click
        Filter = [Enum].Parse(GetType(Filtro), DirectCast(sender, Control).Tag)
    End Sub
End Class