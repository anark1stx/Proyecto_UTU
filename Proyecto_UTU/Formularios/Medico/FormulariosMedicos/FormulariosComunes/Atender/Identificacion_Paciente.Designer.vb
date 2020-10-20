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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Identificacion_Paciente))
        Me.tblDatosPaciente = New System.Windows.Forms.TableLayoutPanel()
        Me.pBoxFotoPaciente = New System.Windows.Forms.PictureBox()
        Me.tabDatos = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTelefonoTXT = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblNombresTXT = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblApellidosTXT = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblDireccionTXT = New System.Windows.Forms.Label()
        Me.lblTelefonoa = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.lblFechaNacTXT = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblSexoTXT = New System.Windows.Forms.Label()
        Me.lblOcupacion = New System.Windows.Forms.Label()
        Me.lblOcupacionTXT = New System.Windows.Forms.Label()
        Me.lblE_Civil = New System.Windows.Forms.Label()
        Me.lblE_CivilTXT = New System.Windows.Forms.Label()
        Me.lblEtapa = New System.Windows.Forms.Label()
        Me.tblCedulaBuscar = New System.Windows.Forms.TableLayoutPanel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtCedulaPaciente = New System.Windows.Forms.TextBox()
        Me.tblAcciones = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgregarLista = New System.Windows.Forms.Button()
        Me.imgsBtnEntrevistar = New System.Windows.Forms.ImageList(Me.components)
        Me.btnAtenderAhora = New System.Windows.Forms.Button()
        Me.pnlConsultasPrevias = New System.Windows.Forms.Panel()
        Me.btnReferenciaConsulta = New System.Windows.Forms.Button()
        Me.btnVerConsulta = New System.Windows.Forms.Button()
        Me.cbConsultasPrevias = New System.Windows.Forms.ComboBox()
        Me.lblConsultasPrevias = New System.Windows.Forms.Label()
        Me.txtMotivoC = New System.Windows.Forms.TextBox()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.pnlEstado = New System.Windows.Forms.Panel()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.btnActualizarEstado = New System.Windows.Forms.Button()
        Me.tblDatosPaciente.SuspendLayout()
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDatos.SuspendLayout()
        Me.tblCedulaBuscar.SuspendLayout()
        Me.tblAcciones.SuspendLayout()
        Me.pnlConsultasPrevias.SuspendLayout()
        Me.pnlEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblDatosPaciente
        '
        Me.tblDatosPaciente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblDatosPaciente.AutoSize = True
        Me.tblDatosPaciente.ColumnCount = 2
        Me.tblDatosPaciente.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.74336!))
        Me.tblDatosPaciente.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.25664!))
        Me.tblDatosPaciente.Controls.Add(Me.pBoxFotoPaciente, 0, 0)
        Me.tblDatosPaciente.Controls.Add(Me.tabDatos, 1, 0)
        Me.tblDatosPaciente.Location = New System.Drawing.Point(0, 0)
        Me.tblDatosPaciente.Name = "tblDatosPaciente"
        Me.tblDatosPaciente.RowCount = 1
        Me.tblDatosPaciente.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDatosPaciente.Size = New System.Drawing.Size(1167, 299)
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
        Me.pBoxFotoPaciente.Size = New System.Drawing.Size(376, 293)
        Me.pBoxFotoPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxFotoPaciente.TabIndex = 101
        Me.pBoxFotoPaciente.TabStop = False
        '
        'tabDatos
        '
        Me.tabDatos.ColumnCount = 2
        Me.tabDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.71552!))
        Me.tabDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.28448!))
        Me.tabDatos.Controls.Add(Me.lblTelefonoTXT, 0, 5)
        Me.tabDatos.Controls.Add(Me.lblCedula, 0, 0)
        Me.tabDatos.Controls.Add(Me.lblNombres, 0, 1)
        Me.tabDatos.Controls.Add(Me.lblNombresTXT, 1, 1)
        Me.tabDatos.Controls.Add(Me.lblApellido, 0, 2)
        Me.tabDatos.Controls.Add(Me.lblApellidosTXT, 1, 2)
        Me.tabDatos.Controls.Add(Me.lblDireccion, 0, 3)
        Me.tabDatos.Controls.Add(Me.lblDireccionTXT, 1, 3)
        Me.tabDatos.Controls.Add(Me.lblTelefonoa, 0, 5)
        Me.tabDatos.Controls.Add(Me.lblFechaNac, 0, 4)
        Me.tabDatos.Controls.Add(Me.lblFechaNacTXT, 1, 4)
        Me.tabDatos.Controls.Add(Me.lblSexo, 0, 6)
        Me.tabDatos.Controls.Add(Me.lblSexoTXT, 1, 6)
        Me.tabDatos.Controls.Add(Me.lblOcupacion, 0, 7)
        Me.tabDatos.Controls.Add(Me.lblOcupacionTXT, 1, 7)
        Me.tabDatos.Controls.Add(Me.lblE_Civil, 0, 8)
        Me.tabDatos.Controls.Add(Me.lblE_CivilTXT, 1, 8)
        Me.tabDatos.Controls.Add(Me.lblEtapa, 0, 9)
        Me.tabDatos.Controls.Add(Me.tblCedulaBuscar, 1, 0)
        Me.tabDatos.Controls.Add(Me.pnlEstado, 1, 9)
        Me.tabDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDatos.Location = New System.Drawing.Point(385, 3)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.RowCount = 10
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.41141!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.408408!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.Size = New System.Drawing.Size(779, 293)
        Me.tabDatos.TabIndex = 103
        '
        'lblTelefonoTXT
        '
        Me.lblTelefonoTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTelefonoTXT.AutoSize = True
        Me.lblTelefonoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoTXT.Location = New System.Drawing.Point(464, 144)
        Me.lblTelefonoTXT.Name = "lblTelefonoTXT"
        Me.lblTelefonoTXT.Size = New System.Drawing.Size(144, 29)
        Me.lblTelefonoTXT.TabIndex = 100
        Me.lblTelefonoTXT.Text = "Teléfono(s):"
        '
        'lblCedula
        '
        Me.lblCedula.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(98, 2)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(96, 29)
        Me.lblCedula.TabIndex = 82
        Me.lblCedula.Text = "Cédula:"
        '
        'lblNombres
        '
        Me.lblNombres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.Location = New System.Drawing.Point(93, 33)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(107, 24)
        Me.lblNombres.TabIndex = 80
        Me.lblNombres.Text = "Nombre:"
        '
        'lblNombresTXT
        '
        Me.lblNombresTXT.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblNombresTXT.AutoSize = True
        Me.lblNombresTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombresTXT.Location = New System.Drawing.Point(296, 33)
        Me.lblNombresTXT.Name = "lblNombresTXT"
        Me.lblNombresTXT.Size = New System.Drawing.Size(269, 24)
        Me.lblNombresTXT.TabIndex = 78
        Me.lblNombresTXT.Tag = "datos"
        Me.lblNombresTXT.Text = "NOMBRE 1 NOMBRE 2"
        '
        'lblApellido
        '
        Me.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(92, 57)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(108, 29)
        Me.lblApellido.TabIndex = 81
        Me.lblApellido.Text = "Apellido:"
        '
        'lblApellidosTXT
        '
        Me.lblApellidosTXT.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblApellidosTXT.AutoSize = True
        Me.lblApellidosTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosTXT.Location = New System.Drawing.Point(296, 57)
        Me.lblApellidosTXT.Name = "lblApellidosTXT"
        Me.lblApellidosTXT.Size = New System.Drawing.Size(287, 29)
        Me.lblApellidosTXT.TabIndex = 79
        Me.lblApellidosTXT.Tag = "datos"
        Me.lblApellidosTXT.Text = "APELLIDO 1 APELLIDO 2"
        '
        'lblDireccion
        '
        Me.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(86, 86)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(121, 29)
        Me.lblDireccion.TabIndex = 98
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblDireccionTXT
        '
        Me.lblDireccionTXT.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDireccionTXT.AutoSize = True
        Me.lblDireccionTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionTXT.Location = New System.Drawing.Point(296, 86)
        Me.lblDireccionTXT.Name = "lblDireccionTXT"
        Me.lblDireccionTXT.Size = New System.Drawing.Size(115, 29)
        Me.lblDireccionTXT.TabIndex = 97
        Me.lblDireccionTXT.Tag = "datos"
        Me.lblDireccionTXT.Text = "Dirección"
        '
        'lblTelefonoa
        '
        Me.lblTelefonoa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTelefonoa.AutoSize = True
        Me.lblTelefonoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoa.Location = New System.Drawing.Point(74, 144)
        Me.lblTelefonoa.Name = "lblTelefonoa"
        Me.lblTelefonoa.Size = New System.Drawing.Size(144, 29)
        Me.lblTelefonoa.TabIndex = 84
        Me.lblTelefonoa.Tag = "datos"
        Me.lblTelefonoa.Text = "Teléfono(s):"
        '
        'lblFechaNac
        '
        Me.lblFechaNac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNac.Location = New System.Drawing.Point(39, 115)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(214, 29)
        Me.lblFechaNac.TabIndex = 101
        Me.lblFechaNac.Text = "Fecha Nacimiento:"
        '
        'lblFechaNacTXT
        '
        Me.lblFechaNacTXT.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFechaNacTXT.AutoSize = True
        Me.lblFechaNacTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacTXT.Location = New System.Drawing.Point(296, 115)
        Me.lblFechaNacTXT.Name = "lblFechaNacTXT"
        Me.lblFechaNacTXT.Size = New System.Drawing.Size(202, 29)
        Me.lblFechaNacTXT.TabIndex = 102
        Me.lblFechaNacTXT.Tag = "datos"
        Me.lblFechaNacTXT.Text = "FechaNacimiento"
        '
        'lblSexo
        '
        Me.lblSexo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(109, 173)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(74, 29)
        Me.lblSexo.TabIndex = 103
        Me.lblSexo.Text = "Sexo:"
        '
        'lblSexoTXT
        '
        Me.lblSexoTXT.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblSexoTXT.AutoSize = True
        Me.lblSexoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexoTXT.Location = New System.Drawing.Point(296, 173)
        Me.lblSexoTXT.Name = "lblSexoTXT"
        Me.lblSexoTXT.Size = New System.Drawing.Size(68, 29)
        Me.lblSexoTXT.TabIndex = 104
        Me.lblSexoTXT.Tag = "datos"
        Me.lblSexoTXT.Text = "Sexo"
        '
        'lblOcupacion
        '
        Me.lblOcupacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOcupacion.AutoSize = True
        Me.lblOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacion.Location = New System.Drawing.Point(79, 202)
        Me.lblOcupacion.Name = "lblOcupacion"
        Me.lblOcupacion.Size = New System.Drawing.Size(135, 29)
        Me.lblOcupacion.TabIndex = 105
        Me.lblOcupacion.Text = "Ocupación:"
        '
        'lblOcupacionTXT
        '
        Me.lblOcupacionTXT.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblOcupacionTXT.AutoSize = True
        Me.lblOcupacionTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacionTXT.Location = New System.Drawing.Point(296, 202)
        Me.lblOcupacionTXT.Name = "lblOcupacionTXT"
        Me.lblOcupacionTXT.Size = New System.Drawing.Size(129, 29)
        Me.lblOcupacionTXT.TabIndex = 106
        Me.lblOcupacionTXT.Tag = "datos"
        Me.lblOcupacionTXT.Text = "Ocupacion"
        '
        'lblE_Civil
        '
        Me.lblE_Civil.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblE_Civil.AutoSize = True
        Me.lblE_Civil.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE_Civil.Location = New System.Drawing.Point(73, 231)
        Me.lblE_Civil.Name = "lblE_Civil"
        Me.lblE_Civil.Size = New System.Drawing.Size(146, 29)
        Me.lblE_Civil.TabIndex = 107
        Me.lblE_Civil.Text = "Estado Civil:"
        '
        'lblE_CivilTXT
        '
        Me.lblE_CivilTXT.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblE_CivilTXT.AutoSize = True
        Me.lblE_CivilTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE_CivilTXT.Location = New System.Drawing.Point(296, 231)
        Me.lblE_CivilTXT.Name = "lblE_CivilTXT"
        Me.lblE_CivilTXT.Size = New System.Drawing.Size(134, 29)
        Me.lblE_CivilTXT.TabIndex = 108
        Me.lblE_CivilTXT.Tag = "datos"
        Me.lblE_CivilTXT.Text = "EstadoCivil"
        '
        'lblEtapa
        '
        Me.lblEtapa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEtapa.AutoSize = True
        Me.lblEtapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtapa.Location = New System.Drawing.Point(99, 262)
        Me.lblEtapa.Name = "lblEtapa"
        Me.lblEtapa.Size = New System.Drawing.Size(94, 29)
        Me.lblEtapa.TabIndex = 109
        Me.lblEtapa.Text = "Estado:"
        '
        'tblCedulaBuscar
        '
        Me.tblCedulaBuscar.ColumnCount = 2
        Me.tblCedulaBuscar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.54166!))
        Me.tblCedulaBuscar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.45833!))
        Me.tblCedulaBuscar.Controls.Add(Me.btnBuscar, 1, 0)
        Me.tblCedulaBuscar.Controls.Add(Me.txtCedulaPaciente, 0, 0)
        Me.tblCedulaBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblCedulaBuscar.Location = New System.Drawing.Point(296, 3)
        Me.tblCedulaBuscar.Name = "tblCedulaBuscar"
        Me.tblCedulaBuscar.RowCount = 1
        Me.tblCedulaBuscar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblCedulaBuscar.Size = New System.Drawing.Size(480, 27)
        Me.tblCedulaBuscar.TabIndex = 111
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(428, 3)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(49, 21)
        Me.btnBuscar.TabIndex = 113
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtCedulaPaciente
        '
        Me.txtCedulaPaciente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCedulaPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedulaPaciente.Location = New System.Drawing.Point(3, 3)
        Me.txtCedulaPaciente.MaxLength = 8
        Me.txtCedulaPaciente.Name = "txtCedulaPaciente"
        Me.txtCedulaPaciente.Size = New System.Drawing.Size(419, 34)
        Me.txtCedulaPaciente.TabIndex = 112
        Me.txtCedulaPaciente.Tag = "noLimpiar"
        '
        'tblAcciones
        '
        Me.tblAcciones.ColumnCount = 1
        Me.tblAcciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblAcciones.Controls.Add(Me.btnAgregarLista, 0, 4)
        Me.tblAcciones.Controls.Add(Me.btnAtenderAhora, 0, 3)
        Me.tblAcciones.Controls.Add(Me.pnlConsultasPrevias, 0, 2)
        Me.tblAcciones.Controls.Add(Me.txtMotivoC, 0, 1)
        Me.tblAcciones.Controls.Add(Me.lblMotivo, 0, 0)
        Me.tblAcciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tblAcciones.Location = New System.Drawing.Point(0, 305)
        Me.tblAcciones.Name = "tblAcciones"
        Me.tblAcciones.RowCount = 5
        Me.tblAcciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.04425!))
        Me.tblAcciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.95575!))
        Me.tblAcciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tblAcciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
        Me.tblAcciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.tblAcciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblAcciones.Size = New System.Drawing.Size(1166, 491)
        Me.tblAcciones.TabIndex = 104
        '
        'btnAgregarLista
        '
        Me.btnAgregarLista.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnAgregarLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAgregarLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarLista.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregarLista.ImageIndex = 1
        Me.btnAgregarLista.ImageList = Me.imgsBtnEntrevistar
        Me.btnAgregarLista.Location = New System.Drawing.Point(3, 382)
        Me.btnAgregarLista.Name = "btnAgregarLista"
        Me.btnAgregarLista.Size = New System.Drawing.Size(1160, 106)
        Me.btnAgregarLista.TabIndex = 105
        Me.btnAgregarLista.Text = "Agregar a Listado"
        Me.btnAgregarLista.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregarLista.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnAgregarLista.UseVisualStyleBackColor = False
        '
        'imgsBtnEntrevistar
        '
        Me.imgsBtnEntrevistar.ImageStream = CType(resources.GetObject("imgsBtnEntrevistar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgsBtnEntrevistar.TransparentColor = System.Drawing.Color.Transparent
        Me.imgsBtnEntrevistar.Images.SetKeyName(0, "icons8-health-checkup-80.png")
        Me.imgsBtnEntrevistar.Images.SetKeyName(1, "subir.png")
        Me.imgsBtnEntrevistar.Images.SetKeyName(2, "MedicoAtiendePaciente.png")
        '
        'btnAtenderAhora
        '
        Me.btnAtenderAhora.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnAtenderAhora.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAtenderAhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtenderAhora.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAtenderAhora.ImageIndex = 2
        Me.btnAtenderAhora.ImageList = Me.imgsBtnEntrevistar
        Me.btnAtenderAhora.Location = New System.Drawing.Point(3, 263)
        Me.btnAtenderAhora.Name = "btnAtenderAhora"
        Me.btnAtenderAhora.Size = New System.Drawing.Size(1160, 113)
        Me.btnAtenderAhora.TabIndex = 106
        Me.btnAtenderAhora.Text = "Atender Ahora"
        Me.btnAtenderAhora.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAtenderAhora.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnAtenderAhora.UseVisualStyleBackColor = False
        '
        'pnlConsultasPrevias
        '
        Me.pnlConsultasPrevias.Controls.Add(Me.btnReferenciaConsulta)
        Me.pnlConsultasPrevias.Controls.Add(Me.btnVerConsulta)
        Me.pnlConsultasPrevias.Controls.Add(Me.cbConsultasPrevias)
        Me.pnlConsultasPrevias.Controls.Add(Me.lblConsultasPrevias)
        Me.pnlConsultasPrevias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlConsultasPrevias.Location = New System.Drawing.Point(3, 204)
        Me.pnlConsultasPrevias.Name = "pnlConsultasPrevias"
        Me.pnlConsultasPrevias.Size = New System.Drawing.Size(1160, 53)
        Me.pnlConsultasPrevias.TabIndex = 108
        '
        'btnReferenciaConsulta
        '
        Me.btnReferenciaConsulta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReferenciaConsulta.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnReferenciaConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReferenciaConsulta.Enabled = False
        Me.btnReferenciaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReferenciaConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReferenciaConsulta.Location = New System.Drawing.Point(864, 5)
        Me.btnReferenciaConsulta.Name = "btnReferenciaConsulta"
        Me.btnReferenciaConsulta.Size = New System.Drawing.Size(249, 37)
        Me.btnReferenciaConsulta.TabIndex = 3
        Me.btnReferenciaConsulta.Text = "Referir"
        Me.btnReferenciaConsulta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReferenciaConsulta.UseVisualStyleBackColor = False
        '
        'btnVerConsulta
        '
        Me.btnVerConsulta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnVerConsulta.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnVerConsulta.BackgroundImage = CType(resources.GetObject("btnVerConsulta.BackgroundImage"), System.Drawing.Image)
        Me.btnVerConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVerConsulta.Enabled = False
        Me.btnVerConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerConsulta.Location = New System.Drawing.Point(1119, 5)
        Me.btnVerConsulta.Name = "btnVerConsulta"
        Me.btnVerConsulta.Size = New System.Drawing.Size(38, 37)
        Me.btnVerConsulta.TabIndex = 2
        Me.btnVerConsulta.UseVisualStyleBackColor = False
        '
        'cbConsultasPrevias
        '
        Me.cbConsultasPrevias.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbConsultasPrevias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConsultasPrevias.Enabled = False
        Me.cbConsultasPrevias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbConsultasPrevias.FormattingEnabled = True
        Me.cbConsultasPrevias.Location = New System.Drawing.Point(243, 8)
        Me.cbConsultasPrevias.Name = "cbConsultasPrevias"
        Me.cbConsultasPrevias.Size = New System.Drawing.Size(615, 33)
        Me.cbConsultasPrevias.TabIndex = 1
        '
        'lblConsultasPrevias
        '
        Me.lblConsultasPrevias.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblConsultasPrevias.AutoSize = True
        Me.lblConsultasPrevias.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultasPrevias.Location = New System.Drawing.Point(8, 11)
        Me.lblConsultasPrevias.Name = "lblConsultasPrevias"
        Me.lblConsultasPrevias.Size = New System.Drawing.Size(229, 29)
        Me.lblConsultasPrevias.TabIndex = 0
        Me.lblConsultasPrevias.Text = "Consultas Previas:"
        '
        'txtMotivoC
        '
        Me.txtMotivoC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMotivoC.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivoC.Location = New System.Drawing.Point(3, 33)
        Me.txtMotivoC.Multiline = True
        Me.txtMotivoC.Name = "txtMotivoC"
        Me.txtMotivoC.Size = New System.Drawing.Size(1160, 165)
        Me.txtMotivoC.TabIndex = 109
        '
        'lblMotivo
        '
        Me.lblMotivo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivo.Location = New System.Drawing.Point(467, 1)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(231, 29)
        Me.lblMotivo.TabIndex = 110
        Me.lblMotivo.Text = "Motivo de consulta"
        '
        'pnlEstado
        '
        Me.pnlEstado.Controls.Add(Me.btnActualizarEstado)
        Me.pnlEstado.Controls.Add(Me.txtEstado)
        Me.pnlEstado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEstado.Location = New System.Drawing.Point(296, 263)
        Me.pnlEstado.Name = "pnlEstado"
        Me.pnlEstado.Size = New System.Drawing.Size(480, 27)
        Me.pnlEstado.TabIndex = 112
        '
        'txtEstado
        '
        Me.txtEstado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(0, 0)
        Me.txtEstado.MaxLength = 90
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(480, 30)
        Me.txtEstado.TabIndex = 0
        '
        'btnActualizarEstado
        '
        Me.btnActualizarEstado.BackgroundImage = CType(resources.GetObject("btnActualizarEstado.BackgroundImage"), System.Drawing.Image)
        Me.btnActualizarEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualizarEstado.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnActualizarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarEstado.Location = New System.Drawing.Point(441, 0)
        Me.btnActualizarEstado.Name = "btnActualizarEstado"
        Me.btnActualizarEstado.Size = New System.Drawing.Size(39, 27)
        Me.btnActualizarEstado.TabIndex = 1
        Me.btnActualizarEstado.UseVisualStyleBackColor = True
        '
        'Identificacion_Paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1166, 796)
        Me.Controls.Add(Me.tblAcciones)
        Me.Controls.Add(Me.tblDatosPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Identificacion_Paciente"
        Me.Text = "frmConsultaConPaciente"
        Me.tblDatosPaciente.ResumeLayout(False)
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDatos.ResumeLayout(False)
        Me.tabDatos.PerformLayout()
        Me.tblCedulaBuscar.ResumeLayout(False)
        Me.tblCedulaBuscar.PerformLayout()
        Me.tblAcciones.ResumeLayout(False)
        Me.tblAcciones.PerformLayout()
        Me.pnlConsultasPrevias.ResumeLayout(False)
        Me.pnlConsultasPrevias.PerformLayout()
        Me.pnlEstado.ResumeLayout(False)
        Me.pnlEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tblDatosPaciente As TableLayoutPanel
    Friend WithEvents pBoxFotoPaciente As PictureBox
    Friend WithEvents tabDatos As TableLayoutPanel
    Friend WithEvents lblTelefonoTXT As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblNombresTXT As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblApellidosTXT As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblDireccionTXT As Label
    Friend WithEvents lblTelefonoa As Label
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents lblFechaNacTXT As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblSexoTXT As Label
    Friend WithEvents lblOcupacion As Label
    Friend WithEvents lblOcupacionTXT As Label
    Friend WithEvents lblE_Civil As Label
    Friend WithEvents lblE_CivilTXT As Label
    Friend WithEvents lblEtapa As Label
    Friend WithEvents txtCedulaPaciente As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents tblAcciones As TableLayoutPanel
    Friend WithEvents imgsBtnEntrevistar As ImageList
    Friend WithEvents pnlConsultasPrevias As Panel
    Friend WithEvents lblConsultasPrevias As Label
    Friend WithEvents btnVerConsulta As Button
    Friend WithEvents cbConsultasPrevias As ComboBox
    Friend WithEvents btnReferenciaConsulta As Button
    Friend WithEvents txtMotivoC As TextBox
    Friend WithEvents btnAtenderAhora As Button
    Friend WithEvents btnAgregarLista As Button
    Friend WithEvents tblCedulaBuscar As TableLayoutPanel
    Friend WithEvents lblMotivo As Label
    Friend WithEvents pnlEstado As Panel
    Friend WithEvents btnActualizarEstado As Button
    Friend WithEvents txtEstado As TextBox
End Class
