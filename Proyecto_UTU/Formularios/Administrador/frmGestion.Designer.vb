<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestion))
        Me.Accion1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Accion2 = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlDatosUsuario = New System.Windows.Forms.Panel()
        Me.pnlAcciones = New System.Windows.Forms.Panel()
        Me.btnAltaLogica = New System.Windows.Forms.Button()
        Me.btnAccion2 = New System.Windows.Forms.Button()
        Me.btnAccion1 = New System.Windows.Forms.Button()
        Me.pnlDspCedula = New System.Windows.Forms.Panel()
        Me.lblEstadoTXT = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblComma = New System.Windows.Forms.Label()
        Me.lblDireccionNumeroTXT = New System.Windows.Forms.MaskedTextBox()
        Me.lblContrasenaTXT = New System.Windows.Forms.TextBox()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.pnlEspecialidadesBtns = New System.Windows.Forms.Panel()
        Me.btnBorrarEspecialidad = New System.Windows.Forms.Button()
        Me.btnAgregarEspecialidad = New System.Windows.Forms.Button()
        Me.lblOcupacionTXT = New System.Windows.Forms.TextBox()
        Me.lblCorreoTXT = New System.Windows.Forms.TextBox()
        Me.lblDireccionTXT = New System.Windows.Forms.TextBox()
        Me.lblApellido2TXT = New System.Windows.Forms.TextBox()
        Me.lblApellido1TXT = New System.Windows.Forms.TextBox()
        Me.lblNombre2TXT = New System.Windows.Forms.TextBox()
        Me.lblNombre1TXT = New System.Windows.Forms.TextBox()
        Me.cbEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.pnlBotonesTel = New System.Windows.Forms.Panel()
        Me.btnSacarTelefono = New System.Windows.Forms.Button()
        Me.btnAgregarTelefono = New System.Windows.Forms.Button()
        Me.cbEspecialidades = New System.Windows.Forms.ComboBox()
        Me.lblEspecialidades = New System.Windows.Forms.Label()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.lblOcupacion = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblFnac = New System.Windows.Forms.Label()
        Me.cbTelefonos = New System.Windows.Forms.ComboBox()
        Me.pBoxFotoUsuario = New System.Windows.Forms.PictureBox()
        Me.lblNombre1 = New System.Windows.Forms.Label()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblNombre2 = New System.Windows.Forms.Label()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.lblCedulaTXT = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.pnlContenedorBusqueda = New System.Windows.Forms.Panel()
        Me.pnlBusqueda = New System.Windows.Forms.Panel()
        Me.rBtnEspecialidad = New System.Windows.Forms.RadioButton()
        Me.rBtnApellido = New System.Windows.Forms.RadioButton()
        Me.rBtnCedula = New System.Windows.Forms.RadioButton()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.dgwUsuarios = New System.Windows.Forms.DataGridView()
        Me.pnlDatosUsuario.SuspendLayout()
        Me.pnlAcciones.SuspendLayout()
        Me.pnlDspCedula.SuspendLayout()
        Me.pnlEspecialidadesBtns.SuspendLayout()
        Me.pnlBotonesTel.SuspendLayout()
        CType(Me.pBoxFotoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenedorBusqueda.SuspendLayout()
        Me.pnlBusqueda.SuspendLayout()
        CType(Me.dgwUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Accion1
        '
        Me.Accion1.ImageStream = CType(resources.GetObject("Accion1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Accion1.TransparentColor = System.Drawing.Color.Transparent
        Me.Accion1.Images.SetKeyName(0, "minus.png")
        Me.Accion1.Images.SetKeyName(1, "plus.png")
        Me.Accion1.Images.SetKeyName(2, "accept.png")
        '
        'Accion2
        '
        Me.Accion2.ImageStream = CType(resources.GetObject("Accion2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Accion2.TransparentColor = System.Drawing.Color.Transparent
        Me.Accion2.Images.SetKeyName(0, "register.png")
        Me.Accion2.Images.SetKeyName(1, "limpiar.png")
        '
        'pnlDatosUsuario
        '
        resources.ApplyResources(Me.pnlDatosUsuario, "pnlDatosUsuario")
        Me.pnlDatosUsuario.Controls.Add(Me.pnlAcciones)
        Me.pnlDatosUsuario.Controls.Add(Me.pnlDspCedula)
        Me.pnlDatosUsuario.Controls.Add(Me.lblCedulaTXT)
        Me.pnlDatosUsuario.Controls.Add(Me.lblCedula)
        Me.pnlDatosUsuario.Name = "pnlDatosUsuario"
        '
        'pnlAcciones
        '
        resources.ApplyResources(Me.pnlAcciones, "pnlAcciones")
        Me.pnlAcciones.Controls.Add(Me.btnAltaLogica)
        Me.pnlAcciones.Controls.Add(Me.btnAccion2)
        Me.pnlAcciones.Controls.Add(Me.btnAccion1)
        Me.pnlAcciones.Name = "pnlAcciones"
        '
        'btnAltaLogica
        '
        resources.ApplyResources(Me.btnAltaLogica, "btnAltaLogica")
        Me.btnAltaLogica.Name = "btnAltaLogica"
        Me.btnAltaLogica.UseVisualStyleBackColor = True
        '
        'btnAccion2
        '
        resources.ApplyResources(Me.btnAccion2, "btnAccion2")
        Me.btnAccion2.ImageList = Me.Accion2
        Me.btnAccion2.Name = "btnAccion2"
        Me.btnAccion2.UseVisualStyleBackColor = True
        '
        'btnAccion1
        '
        resources.ApplyResources(Me.btnAccion1, "btnAccion1")
        Me.btnAccion1.ImageList = Me.Accion1
        Me.btnAccion1.Name = "btnAccion1"
        Me.btnAccion1.UseVisualStyleBackColor = True
        '
        'pnlDspCedula
        '
        resources.ApplyResources(Me.pnlDspCedula, "pnlDspCedula")
        Me.pnlDspCedula.Controls.Add(Me.lblEstadoTXT)
        Me.pnlDspCedula.Controls.Add(Me.lblEstado)
        Me.pnlDspCedula.Controls.Add(Me.lblComma)
        Me.pnlDspCedula.Controls.Add(Me.lblDireccionNumeroTXT)
        Me.pnlDspCedula.Controls.Add(Me.lblContrasenaTXT)
        Me.pnlDspCedula.Controls.Add(Me.lblContrasena)
        Me.pnlDspCedula.Controls.Add(Me.pnlEspecialidadesBtns)
        Me.pnlDspCedula.Controls.Add(Me.lblOcupacionTXT)
        Me.pnlDspCedula.Controls.Add(Me.lblCorreoTXT)
        Me.pnlDspCedula.Controls.Add(Me.lblDireccionTXT)
        Me.pnlDspCedula.Controls.Add(Me.lblApellido2TXT)
        Me.pnlDspCedula.Controls.Add(Me.lblApellido1TXT)
        Me.pnlDspCedula.Controls.Add(Me.lblNombre2TXT)
        Me.pnlDspCedula.Controls.Add(Me.lblNombre1TXT)
        Me.pnlDspCedula.Controls.Add(Me.cbEstadoCivil)
        Me.pnlDspCedula.Controls.Add(Me.cbSexo)
        Me.pnlDspCedula.Controls.Add(Me.dtpFechaNacimiento)
        Me.pnlDspCedula.Controls.Add(Me.pnlBotonesTel)
        Me.pnlDspCedula.Controls.Add(Me.cbEspecialidades)
        Me.pnlDspCedula.Controls.Add(Me.lblEspecialidades)
        Me.pnlDspCedula.Controls.Add(Me.lblEstadoCivil)
        Me.pnlDspCedula.Controls.Add(Me.lblOcupacion)
        Me.pnlDspCedula.Controls.Add(Me.lblSexo)
        Me.pnlDspCedula.Controls.Add(Me.lblFnac)
        Me.pnlDspCedula.Controls.Add(Me.cbTelefonos)
        Me.pnlDspCedula.Controls.Add(Me.pBoxFotoUsuario)
        Me.pnlDspCedula.Controls.Add(Me.lblNombre1)
        Me.pnlDspCedula.Controls.Add(Me.lblApellido1)
        Me.pnlDspCedula.Controls.Add(Me.lblTelefono)
        Me.pnlDspCedula.Controls.Add(Me.lblDireccion)
        Me.pnlDspCedula.Controls.Add(Me.lblCorreo)
        Me.pnlDspCedula.Controls.Add(Me.lblNombre2)
        Me.pnlDspCedula.Controls.Add(Me.lblApellido2)
        Me.pnlDspCedula.Name = "pnlDspCedula"
        '
        'lblEstadoTXT
        '
        resources.ApplyResources(Me.lblEstadoTXT, "lblEstadoTXT")
        Me.lblEstadoTXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblEstadoTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblEstadoTXT.Name = "lblEstadoTXT"
        Me.lblEstadoTXT.ReadOnly = True
        '
        'lblEstado
        '
        resources.ApplyResources(Me.lblEstado, "lblEstado")
        Me.lblEstado.Name = "lblEstado"
        '
        'lblComma
        '
        resources.ApplyResources(Me.lblComma, "lblComma")
        Me.lblComma.Name = "lblComma"
        '
        'lblDireccionNumeroTXT
        '
        resources.ApplyResources(Me.lblDireccionNumeroTXT, "lblDireccionNumeroTXT")
        Me.lblDireccionNumeroTXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblDireccionNumeroTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDireccionNumeroTXT.Name = "lblDireccionNumeroTXT"
        Me.lblDireccionNumeroTXT.ValidatingType = GetType(Integer)
        '
        'lblContrasenaTXT
        '
        resources.ApplyResources(Me.lblContrasenaTXT, "lblContrasenaTXT")
        Me.lblContrasenaTXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblContrasenaTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblContrasenaTXT.Name = "lblContrasenaTXT"
        Me.lblContrasenaTXT.ReadOnly = True
        '
        'lblContrasena
        '
        resources.ApplyResources(Me.lblContrasena, "lblContrasena")
        Me.lblContrasena.Name = "lblContrasena"
        '
        'pnlEspecialidadesBtns
        '
        resources.ApplyResources(Me.pnlEspecialidadesBtns, "pnlEspecialidadesBtns")
        Me.pnlEspecialidadesBtns.Controls.Add(Me.btnBorrarEspecialidad)
        Me.pnlEspecialidadesBtns.Controls.Add(Me.btnAgregarEspecialidad)
        Me.pnlEspecialidadesBtns.Name = "pnlEspecialidadesBtns"
        '
        'btnBorrarEspecialidad
        '
        resources.ApplyResources(Me.btnBorrarEspecialidad, "btnBorrarEspecialidad")
        Me.btnBorrarEspecialidad.Name = "btnBorrarEspecialidad"
        Me.btnBorrarEspecialidad.UseVisualStyleBackColor = True
        '
        'btnAgregarEspecialidad
        '
        resources.ApplyResources(Me.btnAgregarEspecialidad, "btnAgregarEspecialidad")
        Me.btnAgregarEspecialidad.Name = "btnAgregarEspecialidad"
        Me.btnAgregarEspecialidad.UseVisualStyleBackColor = True
        '
        'lblOcupacionTXT
        '
        resources.ApplyResources(Me.lblOcupacionTXT, "lblOcupacionTXT")
        Me.lblOcupacionTXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblOcupacionTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblOcupacionTXT.Name = "lblOcupacionTXT"
        Me.lblOcupacionTXT.ReadOnly = True
        '
        'lblCorreoTXT
        '
        resources.ApplyResources(Me.lblCorreoTXT, "lblCorreoTXT")
        Me.lblCorreoTXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblCorreoTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblCorreoTXT.Name = "lblCorreoTXT"
        Me.lblCorreoTXT.ReadOnly = True
        '
        'lblDireccionTXT
        '
        resources.ApplyResources(Me.lblDireccionTXT, "lblDireccionTXT")
        Me.lblDireccionTXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblDireccionTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDireccionTXT.Name = "lblDireccionTXT"
        Me.lblDireccionTXT.ReadOnly = True
        '
        'lblApellido2TXT
        '
        resources.ApplyResources(Me.lblApellido2TXT, "lblApellido2TXT")
        Me.lblApellido2TXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblApellido2TXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblApellido2TXT.Name = "lblApellido2TXT"
        Me.lblApellido2TXT.ReadOnly = True
        '
        'lblApellido1TXT
        '
        resources.ApplyResources(Me.lblApellido1TXT, "lblApellido1TXT")
        Me.lblApellido1TXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblApellido1TXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblApellido1TXT.Name = "lblApellido1TXT"
        Me.lblApellido1TXT.ReadOnly = True
        '
        'lblNombre2TXT
        '
        resources.ApplyResources(Me.lblNombre2TXT, "lblNombre2TXT")
        Me.lblNombre2TXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblNombre2TXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblNombre2TXT.Name = "lblNombre2TXT"
        Me.lblNombre2TXT.ReadOnly = True
        '
        'lblNombre1TXT
        '
        resources.ApplyResources(Me.lblNombre1TXT, "lblNombre1TXT")
        Me.lblNombre1TXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblNombre1TXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblNombre1TXT.Name = "lblNombre1TXT"
        Me.lblNombre1TXT.ReadOnly = True
        '
        'cbEstadoCivil
        '
        resources.ApplyResources(Me.cbEstadoCivil, "cbEstadoCivil")
        Me.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoCivil.FormattingEnabled = True
        Me.cbEstadoCivil.Items.AddRange(New Object() {resources.GetString("cbEstadoCivil.Items"), resources.GetString("cbEstadoCivil.Items1")})
        Me.cbEstadoCivil.Name = "cbEstadoCivil"
        '
        'cbSexo
        '
        resources.ApplyResources(Me.cbSexo, "cbSexo")
        Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {resources.GetString("cbSexo.Items"), resources.GetString("cbSexo.Items1")})
        Me.cbSexo.Name = "cbSexo"
        '
        'dtpFechaNacimiento
        '
        resources.ApplyResources(Me.dtpFechaNacimiento, "dtpFechaNacimiento")
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Value = New Date(2020, 8, 19, 0, 0, 0, 0)
        '
        'pnlBotonesTel
        '
        resources.ApplyResources(Me.pnlBotonesTel, "pnlBotonesTel")
        Me.pnlBotonesTel.Controls.Add(Me.btnSacarTelefono)
        Me.pnlBotonesTel.Controls.Add(Me.btnAgregarTelefono)
        Me.pnlBotonesTel.Name = "pnlBotonesTel"
        '
        'btnSacarTelefono
        '
        resources.ApplyResources(Me.btnSacarTelefono, "btnSacarTelefono")
        Me.btnSacarTelefono.Name = "btnSacarTelefono"
        Me.btnSacarTelefono.UseVisualStyleBackColor = True
        '
        'btnAgregarTelefono
        '
        resources.ApplyResources(Me.btnAgregarTelefono, "btnAgregarTelefono")
        Me.btnAgregarTelefono.Name = "btnAgregarTelefono"
        Me.btnAgregarTelefono.UseVisualStyleBackColor = True
        '
        'cbEspecialidades
        '
        resources.ApplyResources(Me.cbEspecialidades, "cbEspecialidades")
        Me.cbEspecialidades.FormattingEnabled = True
        Me.cbEspecialidades.Name = "cbEspecialidades"
        Me.cbEspecialidades.Tag = "datos"
        '
        'lblEspecialidades
        '
        resources.ApplyResources(Me.lblEspecialidades, "lblEspecialidades")
        Me.lblEspecialidades.Name = "lblEspecialidades"
        '
        'lblEstadoCivil
        '
        resources.ApplyResources(Me.lblEstadoCivil, "lblEstadoCivil")
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        '
        'lblOcupacion
        '
        resources.ApplyResources(Me.lblOcupacion, "lblOcupacion")
        Me.lblOcupacion.Name = "lblOcupacion"
        '
        'lblSexo
        '
        resources.ApplyResources(Me.lblSexo, "lblSexo")
        Me.lblSexo.Name = "lblSexo"
        '
        'lblFnac
        '
        resources.ApplyResources(Me.lblFnac, "lblFnac")
        Me.lblFnac.Name = "lblFnac"
        '
        'cbTelefonos
        '
        resources.ApplyResources(Me.cbTelefonos, "cbTelefonos")
        Me.cbTelefonos.FormattingEnabled = True
        Me.cbTelefonos.Name = "cbTelefonos"
        Me.cbTelefonos.Tag = "datos"
        '
        'pBoxFotoUsuario
        '
        resources.ApplyResources(Me.pBoxFotoUsuario, "pBoxFotoUsuario")
        Me.pBoxFotoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBoxFotoUsuario.Name = "pBoxFotoUsuario"
        Me.pBoxFotoUsuario.TabStop = False
        '
        'lblNombre1
        '
        resources.ApplyResources(Me.lblNombre1, "lblNombre1")
        Me.lblNombre1.Name = "lblNombre1"
        '
        'lblApellido1
        '
        resources.ApplyResources(Me.lblApellido1, "lblApellido1")
        Me.lblApellido1.Name = "lblApellido1"
        '
        'lblTelefono
        '
        resources.ApplyResources(Me.lblTelefono, "lblTelefono")
        Me.lblTelefono.Name = "lblTelefono"
        '
        'lblDireccion
        '
        resources.ApplyResources(Me.lblDireccion, "lblDireccion")
        Me.lblDireccion.Name = "lblDireccion"
        '
        'lblCorreo
        '
        resources.ApplyResources(Me.lblCorreo, "lblCorreo")
        Me.lblCorreo.Name = "lblCorreo"
        '
        'lblNombre2
        '
        resources.ApplyResources(Me.lblNombre2, "lblNombre2")
        Me.lblNombre2.Name = "lblNombre2"
        '
        'lblApellido2
        '
        resources.ApplyResources(Me.lblApellido2, "lblApellido2")
        Me.lblApellido2.Name = "lblApellido2"
        '
        'lblCedulaTXT
        '
        resources.ApplyResources(Me.lblCedulaTXT, "lblCedulaTXT")
        Me.lblCedulaTXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblCedulaTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblCedulaTXT.Name = "lblCedulaTXT"
        Me.lblCedulaTXT.ReadOnly = True
        '
        'lblCedula
        '
        resources.ApplyResources(Me.lblCedula, "lblCedula")
        Me.lblCedula.Name = "lblCedula"
        '
        'pnlContenedorBusqueda
        '
        resources.ApplyResources(Me.pnlContenedorBusqueda, "pnlContenedorBusqueda")
        Me.pnlContenedorBusqueda.Controls.Add(Me.pnlBusqueda)
        Me.pnlContenedorBusqueda.Controls.Add(Me.dgwUsuarios)
        Me.pnlContenedorBusqueda.Name = "pnlContenedorBusqueda"
        '
        'pnlBusqueda
        '
        resources.ApplyResources(Me.pnlBusqueda, "pnlBusqueda")
        Me.pnlBusqueda.Controls.Add(Me.rBtnEspecialidad)
        Me.pnlBusqueda.Controls.Add(Me.rBtnApellido)
        Me.pnlBusqueda.Controls.Add(Me.rBtnCedula)
        Me.pnlBusqueda.Controls.Add(Me.btnBuscar)
        Me.pnlBusqueda.Controls.Add(Me.txtBusqueda)
        Me.pnlBusqueda.Name = "pnlBusqueda"
        '
        'rBtnEspecialidad
        '
        resources.ApplyResources(Me.rBtnEspecialidad, "rBtnEspecialidad")
        Me.rBtnEspecialidad.Name = "rBtnEspecialidad"
        Me.rBtnEspecialidad.Tag = "Especialidad"
        Me.rBtnEspecialidad.UseVisualStyleBackColor = True
        '
        'rBtnApellido
        '
        resources.ApplyResources(Me.rBtnApellido, "rBtnApellido")
        Me.rBtnApellido.Name = "rBtnApellido"
        Me.rBtnApellido.Tag = "Apellido"
        Me.rBtnApellido.UseVisualStyleBackColor = True
        '
        'rBtnCedula
        '
        resources.ApplyResources(Me.rBtnCedula, "rBtnCedula")
        Me.rBtnCedula.Checked = True
        Me.rBtnCedula.Name = "rBtnCedula"
        Me.rBtnCedula.TabStop = True
        Me.rBtnCedula.Tag = "Cedula"
        Me.rBtnCedula.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        resources.ApplyResources(Me.btnBuscar, "btnBuscar")
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        resources.ApplyResources(Me.txtBusqueda, "txtBusqueda")
        Me.txtBusqueda.Name = "txtBusqueda"
        '
        'dgwUsuarios
        '
        resources.ApplyResources(Me.dgwUsuarios, "dgwUsuarios")
        Me.dgwUsuarios.AllowUserToAddRows = False
        Me.dgwUsuarios.AllowUserToDeleteRows = False
        Me.dgwUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwUsuarios.MultiSelect = False
        Me.dgwUsuarios.Name = "dgwUsuarios"
        Me.dgwUsuarios.ReadOnly = True
        Me.dgwUsuarios.RowTemplate.Height = 24
        Me.dgwUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'frmGestion
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.pnlContenedorBusqueda)
        Me.Controls.Add(Me.pnlDatosUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGestion"
        Me.pnlDatosUsuario.ResumeLayout(False)
        Me.pnlDatosUsuario.PerformLayout()
        Me.pnlAcciones.ResumeLayout(False)
        Me.pnlDspCedula.ResumeLayout(False)
        Me.pnlDspCedula.PerformLayout()
        Me.pnlEspecialidadesBtns.ResumeLayout(False)
        Me.pnlBotonesTel.ResumeLayout(False)
        CType(Me.pBoxFotoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenedorBusqueda.ResumeLayout(False)
        Me.pnlBusqueda.ResumeLayout(False)
        Me.pnlBusqueda.PerformLayout()
        CType(Me.dgwUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlDatosUsuario As Panel
    Friend WithEvents Accion1 As ImageList
    Friend WithEvents Accion2 As ImageList
    Friend WithEvents pnlContenedorBusqueda As Panel
    Friend WithEvents pnlBusqueda As Panel
    Friend WithEvents rBtnApellido As RadioButton
    Friend WithEvents rBtnCedula As RadioButton
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents dgwUsuarios As DataGridView
    Friend WithEvents pnlDspCedula As Panel
    Friend WithEvents pnlEspecialidadesBtns As Panel
    Friend WithEvents btnBorrarEspecialidad As Button
    Friend WithEvents btnAgregarEspecialidad As Button
    Friend WithEvents lblOcupacionTXT As TextBox
    Friend WithEvents lblCorreoTXT As TextBox
    Friend WithEvents lblDireccionTXT As TextBox
    Friend WithEvents lblApellido2TXT As TextBox
    Friend WithEvents lblApellido1TXT As TextBox
    Friend WithEvents lblNombre2TXT As TextBox
    Friend WithEvents lblNombre1TXT As TextBox
    Friend WithEvents cbEstadoCivil As ComboBox
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents pnlBotonesTel As Panel
    Friend WithEvents btnSacarTelefono As Button
    Friend WithEvents btnAgregarTelefono As Button
    Friend WithEvents cbEspecialidades As ComboBox
    Friend WithEvents lblEspecialidades As Label
    Friend WithEvents lblEstadoCivil As Label
    Friend WithEvents lblOcupacion As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblFnac As Label
    Friend WithEvents cbTelefonos As ComboBox
    Friend WithEvents pBoxFotoUsuario As PictureBox
    Friend WithEvents btnAccion1 As Button
    Friend WithEvents btnAccion2 As Button
    Friend WithEvents lblNombre1 As Label
    Friend WithEvents lblApellido1 As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblNombre2 As Label
    Friend WithEvents lblApellido2 As Label
    Friend WithEvents lblCedulaTXT As TextBox
    Friend WithEvents lblCedula As Label
    Friend WithEvents rBtnEspecialidad As RadioButton
    Friend WithEvents lblContrasenaTXT As TextBox
    Friend WithEvents lblContrasena As Label
    Friend WithEvents lblDireccionNumeroTXT As MaskedTextBox
    Friend WithEvents lblComma As Label
    Friend WithEvents pnlAcciones As Panel
    Friend WithEvents btnAltaLogica As Button
    Friend WithEvents lblEstadoTXT As TextBox
    Friend WithEvents lblEstado As Label
End Class
