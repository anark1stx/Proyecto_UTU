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
        Me.cbEtapa = New System.Windows.Forms.ComboBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.pnlBotonesTel = New System.Windows.Forms.Panel()
        Me.btnSacarTelefono = New System.Windows.Forms.Button()
        Me.btnAgregarTelefono = New System.Windows.Forms.Button()
        Me.cbEspecialidades = New System.Windows.Forms.ComboBox()
        Me.lblEspecialidades = New System.Windows.Forms.Label()
        Me.lblEtapa = New System.Windows.Forms.Label()
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
        Me.pnlDatosUsuario.Controls.Add(Me.pnlAcciones)
        Me.pnlDatosUsuario.Controls.Add(Me.pnlDspCedula)
        Me.pnlDatosUsuario.Controls.Add(Me.lblCedulaTXT)
        Me.pnlDatosUsuario.Controls.Add(Me.lblCedula)
        Me.pnlDatosUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDatosUsuario.Location = New System.Drawing.Point(0, 0)
        Me.pnlDatosUsuario.Name = "pnlDatosUsuario"
        Me.pnlDatosUsuario.Size = New System.Drawing.Size(1062, 314)
        Me.pnlDatosUsuario.TabIndex = 3
        '
        'pnlAcciones
        '
        Me.pnlAcciones.Controls.Add(Me.btnAltaLogica)
        Me.pnlAcciones.Controls.Add(Me.btnAccion2)
        Me.pnlAcciones.Controls.Add(Me.btnAccion1)
        Me.pnlAcciones.Location = New System.Drawing.Point(889, 6)
        Me.pnlAcciones.Name = "pnlAcciones"
        Me.pnlAcciones.Size = New System.Drawing.Size(170, 53)
        Me.pnlAcciones.TabIndex = 385
        '
        'btnAltaLogica
        '
        Me.btnAltaLogica.BackgroundImage = CType(resources.GetObject("btnAltaLogica.BackgroundImage"), System.Drawing.Image)
        Me.btnAltaLogica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAltaLogica.Location = New System.Drawing.Point(5, 7)
        Me.btnAltaLogica.Name = "btnAltaLogica"
        Me.btnAltaLogica.Size = New System.Drawing.Size(48, 40)
        Me.btnAltaLogica.TabIndex = 386
        Me.btnAltaLogica.UseVisualStyleBackColor = True
        Me.btnAltaLogica.Visible = False
        '
        'btnAccion2
        '
        Me.btnAccion2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAccion2.ImageList = Me.Accion2
        Me.btnAccion2.Location = New System.Drawing.Point(59, 7)
        Me.btnAccion2.Name = "btnAccion2"
        Me.btnAccion2.Size = New System.Drawing.Size(48, 40)
        Me.btnAccion2.TabIndex = 384
        Me.btnAccion2.UseVisualStyleBackColor = True
        '
        'btnAccion1
        '
        Me.btnAccion1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAccion1.ImageList = Me.Accion1
        Me.btnAccion1.Location = New System.Drawing.Point(113, 7)
        Me.btnAccion1.Name = "btnAccion1"
        Me.btnAccion1.Size = New System.Drawing.Size(48, 40)
        Me.btnAccion1.TabIndex = 383
        Me.btnAccion1.UseVisualStyleBackColor = True
        '
        'pnlDspCedula
        '
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
        Me.pnlDspCedula.Controls.Add(Me.cbEtapa)
        Me.pnlDspCedula.Controls.Add(Me.cbSexo)
        Me.pnlDspCedula.Controls.Add(Me.dtpFechaNacimiento)
        Me.pnlDspCedula.Controls.Add(Me.pnlBotonesTel)
        Me.pnlDspCedula.Controls.Add(Me.cbEspecialidades)
        Me.pnlDspCedula.Controls.Add(Me.lblEspecialidades)
        Me.pnlDspCedula.Controls.Add(Me.lblEtapa)
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
        Me.pnlDspCedula.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlDspCedula.Location = New System.Drawing.Point(0, 58)
        Me.pnlDspCedula.Name = "pnlDspCedula"
        Me.pnlDspCedula.Size = New System.Drawing.Size(1062, 256)
        Me.pnlDspCedula.TabIndex = 375
        '
        'lblEstadoTXT
        '
        Me.lblEstadoTXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblEstadoTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblEstadoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoTXT.Location = New System.Drawing.Point(830, 182)
        Me.lblEstadoTXT.Name = "lblEstadoTXT"
        Me.lblEstadoTXT.ReadOnly = True
        Me.lblEstadoTXT.Size = New System.Drawing.Size(220, 23)
        Me.lblEstadoTXT.TabIndex = 417
        Me.lblEstadoTXT.Text = "Estado"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(670, 187)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(73, 24)
        Me.lblEstado.TabIndex = 416
        Me.lblEstado.Text = "Estado:"
        '
        'lblComma
        '
        Me.lblComma.AutoSize = True
        Me.lblComma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComma.Location = New System.Drawing.Point(579, 147)
        Me.lblComma.Name = "lblComma"
        Me.lblComma.Size = New System.Drawing.Size(17, 25)
        Me.lblComma.TabIndex = 385
        Me.lblComma.Text = ","
        '
        'lblDireccionNumeroTXT
        '
        Me.lblDireccionNumeroTXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblDireccionNumeroTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDireccionNumeroTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionNumeroTXT.Location = New System.Drawing.Point(596, 145)
        Me.lblDireccionNumeroTXT.Mask = "9999"
        Me.lblDireccionNumeroTXT.Name = "lblDireccionNumeroTXT"
        Me.lblDireccionNumeroTXT.Size = New System.Drawing.Size(55, 23)
        Me.lblDireccionNumeroTXT.TabIndex = 385
        Me.lblDireccionNumeroTXT.ValidatingType = GetType(Integer)
        '
        'lblContrasenaTXT
        '
        Me.lblContrasenaTXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblContrasenaTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblContrasenaTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasenaTXT.Location = New System.Drawing.Point(830, 217)
        Me.lblContrasenaTXT.Name = "lblContrasenaTXT"
        Me.lblContrasenaTXT.ReadOnly = True
        Me.lblContrasenaTXT.Size = New System.Drawing.Size(220, 23)
        Me.lblContrasenaTXT.TabIndex = 415
        Me.lblContrasenaTXT.Text = "Contraseña"
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasena.Location = New System.Drawing.Point(670, 218)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(111, 24)
        Me.lblContrasena.TabIndex = 414
        Me.lblContrasena.Text = "Contraseña:"
        '
        'pnlEspecialidadesBtns
        '
        Me.pnlEspecialidadesBtns.Controls.Add(Me.btnBorrarEspecialidad)
        Me.pnlEspecialidadesBtns.Controls.Add(Me.btnAgregarEspecialidad)
        Me.pnlEspecialidadesBtns.Location = New System.Drawing.Point(987, 3)
        Me.pnlEspecialidadesBtns.Name = "pnlEspecialidadesBtns"
        Me.pnlEspecialidadesBtns.Size = New System.Drawing.Size(63, 32)
        Me.pnlEspecialidadesBtns.TabIndex = 404
        '
        'btnBorrarEspecialidad
        '
        Me.btnBorrarEspecialidad.BackgroundImage = CType(resources.GetObject("btnBorrarEspecialidad.BackgroundImage"), System.Drawing.Image)
        Me.btnBorrarEspecialidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBorrarEspecialidad.ImageIndex = 0
        Me.btnBorrarEspecialidad.Location = New System.Drawing.Point(31, 2)
        Me.btnBorrarEspecialidad.Name = "btnBorrarEspecialidad"
        Me.btnBorrarEspecialidad.Size = New System.Drawing.Size(32, 30)
        Me.btnBorrarEspecialidad.TabIndex = 369
        Me.btnBorrarEspecialidad.UseVisualStyleBackColor = True
        '
        'btnAgregarEspecialidad
        '
        Me.btnAgregarEspecialidad.BackgroundImage = CType(resources.GetObject("btnAgregarEspecialidad.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarEspecialidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarEspecialidad.ImageIndex = 0
        Me.btnAgregarEspecialidad.Location = New System.Drawing.Point(3, 2)
        Me.btnAgregarEspecialidad.Name = "btnAgregarEspecialidad"
        Me.btnAgregarEspecialidad.Size = New System.Drawing.Size(29, 30)
        Me.btnAgregarEspecialidad.TabIndex = 368
        Me.btnAgregarEspecialidad.UseVisualStyleBackColor = True
        '
        'lblOcupacionTXT
        '
        Me.lblOcupacionTXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblOcupacionTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblOcupacionTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacionTXT.Location = New System.Drawing.Point(830, 106)
        Me.lblOcupacionTXT.Name = "lblOcupacionTXT"
        Me.lblOcupacionTXT.ReadOnly = True
        Me.lblOcupacionTXT.Size = New System.Drawing.Size(221, 23)
        Me.lblOcupacionTXT.TabIndex = 413
        Me.lblOcupacionTXT.Text = "Ocupacion"
        '
        'lblCorreoTXT
        '
        Me.lblCorreoTXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblCorreoTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblCorreoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreoTXT.Location = New System.Drawing.Point(393, 223)
        Me.lblCorreoTXT.MaxLength = 50
        Me.lblCorreoTXT.Name = "lblCorreoTXT"
        Me.lblCorreoTXT.ReadOnly = True
        Me.lblCorreoTXT.Size = New System.Drawing.Size(258, 23)
        Me.lblCorreoTXT.TabIndex = 412
        Me.lblCorreoTXT.Text = "Correo"
        '
        'lblDireccionTXT
        '
        Me.lblDireccionTXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblDireccionTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDireccionTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionTXT.Location = New System.Drawing.Point(394, 145)
        Me.lblDireccionTXT.MaxLength = 160
        Me.lblDireccionTXT.Name = "lblDireccionTXT"
        Me.lblDireccionTXT.ReadOnly = True
        Me.lblDireccionTXT.Size = New System.Drawing.Size(184, 23)
        Me.lblDireccionTXT.TabIndex = 411
        Me.lblDireccionTXT.Text = "Direccion"
        '
        'lblApellido2TXT
        '
        Me.lblApellido2TXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblApellido2TXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblApellido2TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido2TXT.Location = New System.Drawing.Point(394, 111)
        Me.lblApellido2TXT.MaxLength = 30
        Me.lblApellido2TXT.Name = "lblApellido2TXT"
        Me.lblApellido2TXT.ReadOnly = True
        Me.lblApellido2TXT.Size = New System.Drawing.Size(257, 23)
        Me.lblApellido2TXT.TabIndex = 410
        Me.lblApellido2TXT.Text = "2° Apellido"
        '
        'lblApellido1TXT
        '
        Me.lblApellido1TXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblApellido1TXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblApellido1TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido1TXT.Location = New System.Drawing.Point(394, 76)
        Me.lblApellido1TXT.MaxLength = 30
        Me.lblApellido1TXT.Name = "lblApellido1TXT"
        Me.lblApellido1TXT.ReadOnly = True
        Me.lblApellido1TXT.Size = New System.Drawing.Size(257, 23)
        Me.lblApellido1TXT.TabIndex = 409
        Me.lblApellido1TXT.Text = "1° Apellido"
        '
        'lblNombre2TXT
        '
        Me.lblNombre2TXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblNombre2TXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblNombre2TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre2TXT.Location = New System.Drawing.Point(394, 42)
        Me.lblNombre2TXT.MaxLength = 30
        Me.lblNombre2TXT.Name = "lblNombre2TXT"
        Me.lblNombre2TXT.ReadOnly = True
        Me.lblNombre2TXT.Size = New System.Drawing.Size(257, 23)
        Me.lblNombre2TXT.TabIndex = 408
        Me.lblNombre2TXT.Text = "2° Nombre"
        '
        'lblNombre1TXT
        '
        Me.lblNombre1TXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblNombre1TXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblNombre1TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre1TXT.Location = New System.Drawing.Point(394, 8)
        Me.lblNombre1TXT.MaxLength = 30
        Me.lblNombre1TXT.Name = "lblNombre1TXT"
        Me.lblNombre1TXT.ReadOnly = True
        Me.lblNombre1TXT.Size = New System.Drawing.Size(257, 23)
        Me.lblNombre1TXT.TabIndex = 407
        Me.lblNombre1TXT.Text = "1° Nombre"
        '
        'cbEstadoCivil
        '
        Me.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstadoCivil.FormattingEnabled = True
        Me.cbEstadoCivil.Items.AddRange(New Object() {"Soltero", "Casado"})
        Me.cbEstadoCivil.Location = New System.Drawing.Point(830, 72)
        Me.cbEstadoCivil.Name = "cbEstadoCivil"
        Me.cbEstadoCivil.Size = New System.Drawing.Size(220, 28)
        Me.cbEstadoCivil.TabIndex = 406
        '
        'cbEtapa
        '
        Me.cbEtapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEtapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEtapa.FormattingEnabled = True
        Me.cbEtapa.Items.AddRange(New Object() {"a", "b", "c", "d", "e"})
        Me.cbEtapa.Location = New System.Drawing.Point(830, 142)
        Me.cbEtapa.Name = "cbEtapa"
        Me.cbEtapa.Size = New System.Drawing.Size(220, 28)
        Me.cbEtapa.TabIndex = 405
        '
        'cbSexo
        '
        Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cbSexo.Location = New System.Drawing.Point(830, 38)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(220, 28)
        Me.cbSexo.TabIndex = 403
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(830, 3)
        Me.dtpFechaNacimiento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(221, 28)
        Me.dtpFechaNacimiento.TabIndex = 402
        Me.dtpFechaNacimiento.Value = New Date(2020, 8, 19, 0, 0, 0, 0)
        '
        'pnlBotonesTel
        '
        Me.pnlBotonesTel.Controls.Add(Me.btnSacarTelefono)
        Me.pnlBotonesTel.Controls.Add(Me.btnAgregarTelefono)
        Me.pnlBotonesTel.Location = New System.Drawing.Point(584, 179)
        Me.pnlBotonesTel.Name = "pnlBotonesTel"
        Me.pnlBotonesTel.Size = New System.Drawing.Size(67, 32)
        Me.pnlBotonesTel.TabIndex = 401
        '
        'btnSacarTelefono
        '
        Me.btnSacarTelefono.BackgroundImage = CType(resources.GetObject("btnSacarTelefono.BackgroundImage"), System.Drawing.Image)
        Me.btnSacarTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSacarTelefono.ImageIndex = 0
        Me.btnSacarTelefono.Location = New System.Drawing.Point(35, 2)
        Me.btnSacarTelefono.Name = "btnSacarTelefono"
        Me.btnSacarTelefono.Size = New System.Drawing.Size(32, 30)
        Me.btnSacarTelefono.TabIndex = 369
        Me.btnSacarTelefono.UseVisualStyleBackColor = True
        '
        'btnAgregarTelefono
        '
        Me.btnAgregarTelefono.BackgroundImage = CType(resources.GetObject("btnAgregarTelefono.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarTelefono.ImageIndex = 0
        Me.btnAgregarTelefono.Location = New System.Drawing.Point(3, 2)
        Me.btnAgregarTelefono.Name = "btnAgregarTelefono"
        Me.btnAgregarTelefono.Size = New System.Drawing.Size(29, 30)
        Me.btnAgregarTelefono.TabIndex = 368
        Me.btnAgregarTelefono.UseVisualStyleBackColor = True
        '
        'cbEspecialidades
        '
        Me.cbEspecialidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEspecialidades.FormattingEnabled = True
        Me.cbEspecialidades.Location = New System.Drawing.Point(830, 3)
        Me.cbEspecialidades.Name = "cbEspecialidades"
        Me.cbEspecialidades.Size = New System.Drawing.Size(154, 28)
        Me.cbEspecialidades.TabIndex = 400
        Me.cbEspecialidades.Tag = "datos"
        '
        'lblEspecialidades
        '
        Me.lblEspecialidades.AutoSize = True
        Me.lblEspecialidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspecialidades.Location = New System.Drawing.Point(670, 9)
        Me.lblEspecialidades.Name = "lblEspecialidades"
        Me.lblEspecialidades.Size = New System.Drawing.Size(155, 24)
        Me.lblEspecialidades.TabIndex = 399
        Me.lblEspecialidades.Text = "Especialidad(es):"
        '
        'lblEtapa
        '
        Me.lblEtapa.AutoSize = True
        Me.lblEtapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtapa.Location = New System.Drawing.Point(669, 146)
        Me.lblEtapa.Name = "lblEtapa"
        Me.lblEtapa.Size = New System.Drawing.Size(63, 24)
        Me.lblEtapa.TabIndex = 398
        Me.lblEtapa.Text = "Etapa:"
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCivil.Location = New System.Drawing.Point(670, 76)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(109, 24)
        Me.lblEstadoCivil.TabIndex = 397
        Me.lblEstadoCivil.Text = "Estado civíl:"
        '
        'lblOcupacion
        '
        Me.lblOcupacion.AutoSize = True
        Me.lblOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacion.Location = New System.Drawing.Point(669, 111)
        Me.lblOcupacion.Name = "lblOcupacion"
        Me.lblOcupacion.Size = New System.Drawing.Size(108, 24)
        Me.lblOcupacion.TabIndex = 396
        Me.lblOcupacion.Text = "Ocupación:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(669, 42)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(59, 24)
        Me.lblSexo.TabIndex = 395
        Me.lblSexo.Text = "Sexo:"
        '
        'lblFnac
        '
        Me.lblFnac.AutoSize = True
        Me.lblFnac.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFnac.Location = New System.Drawing.Point(669, 5)
        Me.lblFnac.Name = "lblFnac"
        Me.lblFnac.Size = New System.Drawing.Size(108, 24)
        Me.lblFnac.TabIndex = 394
        Me.lblFnac.Text = "Fecha Nac."
        '
        'cbTelefonos
        '
        Me.cbTelefonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTelefonos.FormattingEnabled = True
        Me.cbTelefonos.Location = New System.Drawing.Point(394, 182)
        Me.cbTelefonos.MaxLength = 9
        Me.cbTelefonos.Name = "cbTelefonos"
        Me.cbTelefonos.Size = New System.Drawing.Size(184, 28)
        Me.cbTelefonos.TabIndex = 393
        Me.cbTelefonos.Tag = "datos"
        '
        'pBoxFotoUsuario
        '
        Me.pBoxFotoUsuario.BackgroundImage = CType(resources.GetObject("pBoxFotoUsuario.BackgroundImage"), System.Drawing.Image)
        Me.pBoxFotoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pBoxFotoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBoxFotoUsuario.Location = New System.Drawing.Point(12, 3)
        Me.pBoxFotoUsuario.Name = "pBoxFotoUsuario"
        Me.pBoxFotoUsuario.Size = New System.Drawing.Size(255, 247)
        Me.pBoxFotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxFotoUsuario.TabIndex = 385
        Me.pBoxFotoUsuario.TabStop = False
        '
        'lblNombre1
        '
        Me.lblNombre1.AutoSize = True
        Me.lblNombre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre1.Location = New System.Drawing.Point(274, 11)
        Me.lblNombre1.Name = "lblNombre1"
        Me.lblNombre1.Size = New System.Drawing.Size(105, 24)
        Me.lblNombre1.TabIndex = 386
        Me.lblNombre1.Text = "1° Nombre:"
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido1.Location = New System.Drawing.Point(274, 80)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(105, 24)
        Me.lblApellido1.TabIndex = 387
        Me.lblApellido1.Text = "1° Apellido:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(275, 184)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(111, 24)
        Me.lblTelefono.TabIndex = 388
        Me.lblTelefono.Text = "Teléfono(s):"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(275, 149)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(95, 24)
        Me.lblDireccion.TabIndex = 389
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(274, 223)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(73, 24)
        Me.lblCorreo.TabIndex = 392
        Me.lblCorreo.Text = "Correo:"
        '
        'lblNombre2
        '
        Me.lblNombre2.AutoSize = True
        Me.lblNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre2.Location = New System.Drawing.Point(275, 47)
        Me.lblNombre2.Name = "lblNombre2"
        Me.lblNombre2.Size = New System.Drawing.Size(105, 24)
        Me.lblNombre2.TabIndex = 390
        Me.lblNombre2.Text = "2° Nombre:"
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido2.Location = New System.Drawing.Point(275, 114)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(105, 24)
        Me.lblApellido2.TabIndex = 391
        Me.lblApellido2.Text = "2° Apellido:"
        '
        'lblCedulaTXT
        '
        Me.lblCedulaTXT.BackColor = System.Drawing.Color.LightBlue
        Me.lblCedulaTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblCedulaTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedulaTXT.Location = New System.Drawing.Point(394, 26)
        Me.lblCedulaTXT.MaxLength = 8
        Me.lblCedulaTXT.Name = "lblCedulaTXT"
        Me.lblCedulaTXT.ReadOnly = True
        Me.lblCedulaTXT.Size = New System.Drawing.Size(257, 23)
        Me.lblCedulaTXT.TabIndex = 374
        Me.lblCedulaTXT.Text = "Cédula"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(274, 29)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(75, 24)
        Me.lblCedula.TabIndex = 338
        Me.lblCedula.Text = "Cédula:"
        '
        'pnlContenedorBusqueda
        '
        Me.pnlContenedorBusqueda.Controls.Add(Me.pnlBusqueda)
        Me.pnlContenedorBusqueda.Controls.Add(Me.dgwUsuarios)
        Me.pnlContenedorBusqueda.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlContenedorBusqueda.Location = New System.Drawing.Point(0, 317)
        Me.pnlContenedorBusqueda.Name = "pnlContenedorBusqueda"
        Me.pnlContenedorBusqueda.Size = New System.Drawing.Size(1062, 210)
        Me.pnlContenedorBusqueda.TabIndex = 4
        '
        'pnlBusqueda
        '
        Me.pnlBusqueda.Controls.Add(Me.rBtnEspecialidad)
        Me.pnlBusqueda.Controls.Add(Me.rBtnApellido)
        Me.pnlBusqueda.Controls.Add(Me.rBtnCedula)
        Me.pnlBusqueda.Controls.Add(Me.btnBuscar)
        Me.pnlBusqueda.Controls.Add(Me.txtBusqueda)
        Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlBusqueda.Location = New System.Drawing.Point(381, 0)
        Me.pnlBusqueda.Name = "pnlBusqueda"
        Me.pnlBusqueda.Size = New System.Drawing.Size(681, 43)
        Me.pnlBusqueda.TabIndex = 7
        '
        'rBtnEspecialidad
        '
        Me.rBtnEspecialidad.AutoSize = True
        Me.rBtnEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBtnEspecialidad.Location = New System.Drawing.Point(38, 7)
        Me.rBtnEspecialidad.Name = "rBtnEspecialidad"
        Me.rBtnEspecialidad.Size = New System.Drawing.Size(144, 29)
        Me.rBtnEspecialidad.TabIndex = 359
        Me.rBtnEspecialidad.Tag = "Especialidad"
        Me.rBtnEspecialidad.Text = "Especialidad"
        Me.rBtnEspecialidad.UseVisualStyleBackColor = True
        '
        'rBtnApellido
        '
        Me.rBtnApellido.AutoSize = True
        Me.rBtnApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBtnApellido.Location = New System.Drawing.Point(201, 7)
        Me.rBtnApellido.Name = "rBtnApellido"
        Me.rBtnApellido.Size = New System.Drawing.Size(103, 29)
        Me.rBtnApellido.TabIndex = 358
        Me.rBtnApellido.Tag = "Apellido"
        Me.rBtnApellido.Text = "Apellido"
        Me.rBtnApellido.UseVisualStyleBackColor = True
        '
        'rBtnCedula
        '
        Me.rBtnCedula.AutoSize = True
        Me.rBtnCedula.Checked = True
        Me.rBtnCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBtnCedula.Location = New System.Drawing.Point(316, 7)
        Me.rBtnCedula.Name = "rBtnCedula"
        Me.rBtnCedula.Size = New System.Drawing.Size(96, 29)
        Me.rBtnCedula.TabIndex = 357
        Me.rBtnCedula.TabStop = True
        Me.rBtnCedula.Tag = "Cedula"
        Me.rBtnCedula.Text = "Cédula"
        Me.rBtnCedula.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.Location = New System.Drawing.Point(631, 3)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(45, 34)
        Me.btnBuscar.TabIndex = 356
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(418, 3)
        Me.txtBusqueda.MaxLength = 50
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(207, 34)
        Me.txtBusqueda.TabIndex = 0
        '
        'dgwUsuarios
        '
        Me.dgwUsuarios.AllowUserToAddRows = False
        Me.dgwUsuarios.AllowUserToDeleteRows = False
        Me.dgwUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwUsuarios.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgwUsuarios.Location = New System.Drawing.Point(0, 43)
        Me.dgwUsuarios.MultiSelect = False
        Me.dgwUsuarios.Name = "dgwUsuarios"
        Me.dgwUsuarios.ReadOnly = True
        Me.dgwUsuarios.RowHeadersWidth = 51
        Me.dgwUsuarios.RowTemplate.Height = 24
        Me.dgwUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwUsuarios.Size = New System.Drawing.Size(1062, 167)
        Me.dgwUsuarios.TabIndex = 6
        '
        'frmGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1062, 527)
        Me.Controls.Add(Me.pnlContenedorBusqueda)
        Me.Controls.Add(Me.pnlDatosUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form2"
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
    Friend WithEvents cbEtapa As ComboBox
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents pnlBotonesTel As Panel
    Friend WithEvents btnSacarTelefono As Button
    Friend WithEvents btnAgregarTelefono As Button
    Friend WithEvents cbEspecialidades As ComboBox
    Friend WithEvents lblEspecialidades As Label
    Friend WithEvents lblEtapa As Label
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
