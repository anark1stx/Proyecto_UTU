<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Identificacion_Paciente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Identificacion_Paciente))
        Me.tblDatosPaciente = New System.Windows.Forms.TableLayoutPanel()
        Me.pBoxFotoPaciente = New System.Windows.Forms.PictureBox()
        Me.tabDatos = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblNombresTXT = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblApellidosTXT = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblDireccionTXT = New System.Windows.Forms.Label()
        Me.lblTelefonoTXT = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.lblFechaNacTXT = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblSexoTXT = New System.Windows.Forms.Label()
        Me.lblOcupacion = New System.Windows.Forms.Label()
        Me.lblOcupacionTXT = New System.Windows.Forms.Label()
        Me.lblE_Civil = New System.Windows.Forms.Label()
        Me.lblE_CivilTXT = New System.Windows.Forms.Label()
        Me.lblEtapa = New System.Windows.Forms.Label()
        Me.lblEtapaTXT = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtCedulaPaciente = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnConsultasPrevias = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEntrevistar = New System.Windows.Forms.Button()
        Me.tblDatosPaciente.SuspendLayout()
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDatos.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblDatosPaciente
        '
        Me.tblDatosPaciente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblDatosPaciente.AutoSize = True
        Me.tblDatosPaciente.ColumnCount = 2
        Me.tblDatosPaciente.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.91892!))
        Me.tblDatosPaciente.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.08108!))
        Me.tblDatosPaciente.Controls.Add(Me.pBoxFotoPaciente, 0, 0)
        Me.tblDatosPaciente.Controls.Add(Me.tabDatos, 1, 0)
        Me.tblDatosPaciente.Location = New System.Drawing.Point(8, 8)
        Me.tblDatosPaciente.Name = "tblDatosPaciente"
        Me.tblDatosPaciente.RowCount = 1
        Me.tblDatosPaciente.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDatosPaciente.Size = New System.Drawing.Size(1110, 370)
        Me.tblDatosPaciente.TabIndex = 103
        '
        'pBoxFotoPaciente
        '
        Me.pBoxFotoPaciente.BackgroundImage = CType(resources.GetObject("pBoxFotoPaciente.BackgroundImage"), System.Drawing.Image)
        Me.pBoxFotoPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pBoxFotoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBoxFotoPaciente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBoxFotoPaciente.Location = New System.Drawing.Point(3, 3)
        Me.pBoxFotoPaciente.Name = "pBoxFotoPaciente"
        Me.pBoxFotoPaciente.Size = New System.Drawing.Size(425, 364)
        Me.pBoxFotoPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxFotoPaciente.TabIndex = 101
        Me.pBoxFotoPaciente.TabStop = False
        '
        'tabDatos
        '
        Me.tabDatos.ColumnCount = 2
        Me.tabDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.71552!))
        Me.tabDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.28448!))
        Me.tabDatos.Controls.Add(Me.lblTelefono, 0, 5)
        Me.tabDatos.Controls.Add(Me.lblCedula, 0, 0)
        Me.tabDatos.Controls.Add(Me.lblNombres, 0, 1)
        Me.tabDatos.Controls.Add(Me.lblNombresTXT, 1, 1)
        Me.tabDatos.Controls.Add(Me.lblApellido, 0, 2)
        Me.tabDatos.Controls.Add(Me.lblApellidosTXT, 1, 2)
        Me.tabDatos.Controls.Add(Me.lblDireccion, 0, 3)
        Me.tabDatos.Controls.Add(Me.lblDireccionTXT, 1, 3)
        Me.tabDatos.Controls.Add(Me.lblTelefonoTXT, 0, 5)
        Me.tabDatos.Controls.Add(Me.lblFechaNac, 0, 4)
        Me.tabDatos.Controls.Add(Me.lblFechaNacTXT, 1, 4)
        Me.tabDatos.Controls.Add(Me.lblSexo, 0, 6)
        Me.tabDatos.Controls.Add(Me.lblSexoTXT, 1, 6)
        Me.tabDatos.Controls.Add(Me.lblOcupacion, 0, 7)
        Me.tabDatos.Controls.Add(Me.lblOcupacionTXT, 1, 7)
        Me.tabDatos.Controls.Add(Me.lblE_Civil, 0, 8)
        Me.tabDatos.Controls.Add(Me.lblE_CivilTXT, 1, 8)
        Me.tabDatos.Controls.Add(Me.lblEtapa, 0, 9)
        Me.tabDatos.Controls.Add(Me.lblEtapaTXT, 1, 9)
        Me.tabDatos.Controls.Add(Me.TableLayoutPanel1, 1, 0)
        Me.tabDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDatos.Location = New System.Drawing.Point(434, 3)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.RowCount = 10
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.Size = New System.Drawing.Size(673, 364)
        Me.tabDatos.TabIndex = 103
        '
        'lblTelefono
        '
        Me.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(67, 185)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(119, 25)
        Me.lblTelefono.TabIndex = 100
        Me.lblTelefono.Text = "Teléfono(s):"
        '
        'lblCedula
        '
        Me.lblCedula.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(86, 5)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(81, 25)
        Me.lblCedula.TabIndex = 82
        Me.lblCedula.Text = "Cédula:"
        '
        'lblNombres
        '
        Me.lblNombres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.Location = New System.Drawing.Point(83, 41)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(87, 25)
        Me.lblNombres.TabIndex = 80
        Me.lblNombres.Text = "Nombre:"
        '
        'lblNombresTXT
        '
        Me.lblNombresTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNombresTXT.AutoSize = True
        Me.lblNombresTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombresTXT.Location = New System.Drawing.Point(352, 41)
        Me.lblNombresTXT.Name = "lblNombresTXT"
        Me.lblNombresTXT.Size = New System.Drawing.Size(221, 25)
        Me.lblNombresTXT.TabIndex = 78
        Me.lblNombresTXT.Tag = "datos"
        Me.lblNombresTXT.Text = "NOMBRE 1 NOMBRE 2"
        '
        'lblApellido
        '
        Me.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(82, 77)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(88, 25)
        Me.lblApellido.TabIndex = 81
        Me.lblApellido.Text = "Apellido:"
        '
        'lblApellidosTXT
        '
        Me.lblApellidosTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblApellidosTXT.AutoSize = True
        Me.lblApellidosTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosTXT.Location = New System.Drawing.Point(341, 77)
        Me.lblApellidosTXT.Name = "lblApellidosTXT"
        Me.lblApellidosTXT.Size = New System.Drawing.Size(243, 25)
        Me.lblApellidosTXT.TabIndex = 79
        Me.lblApellidosTXT.Tag = "datos"
        Me.lblApellidosTXT.Text = "APELLIDO 1 APELLIDO 2"
        '
        'lblDireccion
        '
        Me.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(77, 113)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(99, 25)
        Me.lblDireccion.TabIndex = 98
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblDireccionTXT
        '
        Me.lblDireccionTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDireccionTXT.AutoSize = True
        Me.lblDireccionTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionTXT.Location = New System.Drawing.Point(416, 113)
        Me.lblDireccionTXT.Name = "lblDireccionTXT"
        Me.lblDireccionTXT.Size = New System.Drawing.Size(93, 25)
        Me.lblDireccionTXT.TabIndex = 97
        Me.lblDireccionTXT.Tag = "datos"
        Me.lblDireccionTXT.Text = "Dirección"
        '
        'lblTelefonoTXT
        '
        Me.lblTelefonoTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTelefonoTXT.AutoSize = True
        Me.lblTelefonoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoTXT.Location = New System.Drawing.Point(403, 185)
        Me.lblTelefonoTXT.Name = "lblTelefonoTXT"
        Me.lblTelefonoTXT.Size = New System.Drawing.Size(119, 25)
        Me.lblTelefonoTXT.TabIndex = 84
        Me.lblTelefonoTXT.Tag = "datos"
        Me.lblTelefonoTXT.Text = "Teléfono(s):"
        '
        'lblFechaNac
        '
        Me.lblFechaNac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNac.Location = New System.Drawing.Point(39, 149)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(175, 25)
        Me.lblFechaNac.TabIndex = 101
        Me.lblFechaNac.Text = "Fecha Nacimiento:"
        '
        'lblFechaNacTXT
        '
        Me.lblFechaNacTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFechaNacTXT.AutoSize = True
        Me.lblFechaNacTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacTXT.Location = New System.Drawing.Point(381, 149)
        Me.lblFechaNacTXT.Name = "lblFechaNacTXT"
        Me.lblFechaNacTXT.Size = New System.Drawing.Size(164, 25)
        Me.lblFechaNacTXT.TabIndex = 102
        Me.lblFechaNacTXT.Tag = "datos"
        Me.lblFechaNacTXT.Text = "FechaNacimiento"
        '
        'lblSexo
        '
        Me.lblSexo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(94, 221)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(64, 25)
        Me.lblSexo.TabIndex = 103
        Me.lblSexo.Text = "Sexo:"
        '
        'lblSexoTXT
        '
        Me.lblSexoTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSexoTXT.AutoSize = True
        Me.lblSexoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexoTXT.Location = New System.Drawing.Point(434, 221)
        Me.lblSexoTXT.Name = "lblSexoTXT"
        Me.lblSexoTXT.Size = New System.Drawing.Size(58, 25)
        Me.lblSexoTXT.TabIndex = 104
        Me.lblSexoTXT.Tag = "datos"
        Me.lblSexoTXT.Text = "Sexo"
        '
        'lblOcupacion
        '
        Me.lblOcupacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOcupacion.AutoSize = True
        Me.lblOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacion.Location = New System.Drawing.Point(70, 257)
        Me.lblOcupacion.Name = "lblOcupacion"
        Me.lblOcupacion.Size = New System.Drawing.Size(113, 25)
        Me.lblOcupacion.TabIndex = 105
        Me.lblOcupacion.Text = "Ocupación:"
        '
        'lblOcupacionTXT
        '
        Me.lblOcupacionTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOcupacionTXT.AutoSize = True
        Me.lblOcupacionTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacionTXT.Location = New System.Drawing.Point(409, 257)
        Me.lblOcupacionTXT.Name = "lblOcupacionTXT"
        Me.lblOcupacionTXT.Size = New System.Drawing.Size(107, 25)
        Me.lblOcupacionTXT.TabIndex = 106
        Me.lblOcupacionTXT.Tag = "datos"
        Me.lblOcupacionTXT.Text = "Ocupacion"
        '
        'lblE_Civil
        '
        Me.lblE_Civil.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblE_Civil.AutoSize = True
        Me.lblE_Civil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE_Civil.Location = New System.Drawing.Point(66, 293)
        Me.lblE_Civil.Name = "lblE_Civil"
        Me.lblE_Civil.Size = New System.Drawing.Size(121, 25)
        Me.lblE_Civil.TabIndex = 107
        Me.lblE_Civil.Text = "Estado Civil:"
        '
        'lblE_CivilTXT
        '
        Me.lblE_CivilTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblE_CivilTXT.AutoSize = True
        Me.lblE_CivilTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE_CivilTXT.Location = New System.Drawing.Point(408, 293)
        Me.lblE_CivilTXT.Name = "lblE_CivilTXT"
        Me.lblE_CivilTXT.Size = New System.Drawing.Size(110, 25)
        Me.lblE_CivilTXT.TabIndex = 108
        Me.lblE_CivilTXT.Tag = "datos"
        Me.lblE_CivilTXT.Text = "EstadoCivil"
        '
        'lblEtapa
        '
        Me.lblEtapa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEtapa.AutoSize = True
        Me.lblEtapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtapa.Location = New System.Drawing.Point(92, 331)
        Me.lblEtapa.Name = "lblEtapa"
        Me.lblEtapa.Size = New System.Drawing.Size(69, 25)
        Me.lblEtapa.TabIndex = 109
        Me.lblEtapa.Text = "Etapa:"
        '
        'lblEtapaTXT
        '
        Me.lblEtapaTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEtapaTXT.AutoSize = True
        Me.lblEtapaTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtapaTXT.Location = New System.Drawing.Point(431, 331)
        Me.lblEtapaTXT.Name = "lblEtapaTXT"
        Me.lblEtapaTXT.Size = New System.Drawing.Size(63, 25)
        Me.lblEtapaTXT.TabIndex = 110
        Me.lblEtapaTXT.Tag = "datos"
        Me.lblEtapaTXT.Text = "Etapa"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.64735!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.35266!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtCedulaPaciente, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBuscar, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(256, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(414, 30)
        Me.TableLayoutPanel1.TabIndex = 111
        '
        'txtCedulaPaciente
        '
        Me.txtCedulaPaciente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCedulaPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedulaPaciente.Location = New System.Drawing.Point(3, 3)
        Me.txtCedulaPaciente.MaxLength = 8
        Me.txtCedulaPaciente.Name = "txtCedulaPaciente"
        Me.txtCedulaPaciente.Size = New System.Drawing.Size(360, 27)
        Me.txtCedulaPaciente.TabIndex = 112
        Me.txtCedulaPaciente.Tag = "noLimpiar"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBuscar.Location = New System.Drawing.Point(369, 3)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(42, 24)
        Me.btnBuscar.TabIndex = 113
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnConsultasPrevias
        '
        Me.btnConsultasPrevias.BackColor = System.Drawing.Color.LightGreen
        Me.btnConsultasPrevias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConsultasPrevias.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultasPrevias.Image = CType(resources.GetObject("btnConsultasPrevias.Image"), System.Drawing.Image)
        Me.btnConsultasPrevias.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsultasPrevias.Location = New System.Drawing.Point(3, 171)
        Me.btnConsultasPrevias.Name = "btnConsultasPrevias"
        Me.btnConsultasPrevias.Size = New System.Drawing.Size(1124, 162)
        Me.btnConsultasPrevias.TabIndex = 104
        Me.btnConsultasPrevias.Text = "      Ver consultas previas"
        Me.btnConsultasPrevias.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsultasPrevias.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnConsultasPrevias.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnEntrevistar, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnConsultasPrevias, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 384)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1130, 336)
        Me.TableLayoutPanel2.TabIndex = 104
        '
        'btnEntrevistar
        '
        Me.btnEntrevistar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEntrevistar.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnEntrevistar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrevistar.Image = CType(resources.GetObject("btnEntrevistar.Image"), System.Drawing.Image)
        Me.btnEntrevistar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEntrevistar.Location = New System.Drawing.Point(3, 3)
        Me.btnEntrevistar.Name = "btnEntrevistar"
        Me.btnEntrevistar.Size = New System.Drawing.Size(1124, 162)
        Me.btnEntrevistar.TabIndex = 105
        Me.btnEntrevistar.Text = "    Entrevistar"
        Me.btnEntrevistar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEntrevistar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnEntrevistar.UseVisualStyleBackColor = False
        '
        'Identificacion_Paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1130, 720)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.tblDatosPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Identificacion_Paciente"
        Me.Text = "frmConsultaConPaciente"
        Me.tblDatosPaciente.ResumeLayout(False)
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDatos.ResumeLayout(False)
        Me.tabDatos.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tblDatosPaciente As TableLayoutPanel
    Friend WithEvents pBoxFotoPaciente As PictureBox
    Friend WithEvents tabDatos As TableLayoutPanel
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblNombresTXT As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblApellidosTXT As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblDireccionTXT As Label
    Friend WithEvents lblTelefonoTXT As Label
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents lblFechaNacTXT As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblSexoTXT As Label
    Friend WithEvents lblOcupacion As Label
    Friend WithEvents lblOcupacionTXT As Label
    Friend WithEvents lblE_Civil As Label
    Friend WithEvents lblE_CivilTXT As Label
    Friend WithEvents lblEtapa As Label
    Friend WithEvents lblEtapaTXT As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtCedulaPaciente As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnConsultasPrevias As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnEntrevistar As Button
End Class
