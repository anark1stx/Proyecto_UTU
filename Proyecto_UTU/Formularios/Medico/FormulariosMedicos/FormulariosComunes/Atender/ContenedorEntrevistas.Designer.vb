<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContenedorEntrevistas
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContenedorEntrevistas))
        Me.TabControlFormulario = New System.Windows.Forms.TabControl()
        Me.tbpEntrevista = New System.Windows.Forms.TabPage()
        Me.tbpSintomasYsg = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBorrarSintoma = New System.Windows.Forms.Button()
        Me.btnAgregarSintoma = New System.Windows.Forms.Button()
        Me.lblIngreseSintoma = New System.Windows.Forms.Label()
        Me.txtSintoma = New System.Windows.Forms.TextBox()
        Me.lbSintomas = New System.Windows.Forms.ListBox()
        Me.pnlSigno = New System.Windows.Forms.Panel()
        Me.btnBorrarSigno = New System.Windows.Forms.Button()
        Me.btnAgregarSClinico = New System.Windows.Forms.Button()
        Me.lblIngreseSignoClinico = New System.Windows.Forms.Label()
        Me.txtSgClinico = New System.Windows.Forms.TextBox()
        Me.lbSignosClinicos = New System.Windows.Forms.ListBox()
        Me.tpResolucion = New System.Windows.Forms.TabPage()
        Me.tblResolucion = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSugereirTratamiento = New System.Windows.Forms.Button()
        Me.btnSugerirAnalisis = New System.Windows.Forms.Button()
        Me.txtNomAnalisis = New System.Windows.Forms.TextBox()
        Me.lblAnalisisReq = New System.Windows.Forms.Label()
        Me.chkEnfermo = New System.Windows.Forms.CheckBox()
        Me.lblPresenta = New System.Windows.Forms.Label()
        Me.txtNomEnfermedad = New System.Windows.Forms.TextBox()
        Me.chkAnalisis = New System.Windows.Forms.CheckBox()
        Me.chkTratamiento = New System.Windows.Forms.CheckBox()
        Me.lblTratamientoS = New System.Windows.Forms.Label()
        Me.txtNomTratamiento = New System.Windows.Forms.TextBox()
        Me.btnSugerirDiagnostico = New System.Windows.Forms.Button()
        Me.TabControlFormulario.SuspendLayout()
        Me.tbpSintomasYsg.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlSigno.SuspendLayout()
        Me.tpResolucion.SuspendLayout()
        Me.tblResolucion.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlFormulario
        '
        Me.TabControlFormulario.Controls.Add(Me.tbpEntrevista)
        Me.TabControlFormulario.Controls.Add(Me.tbpSintomasYsg)
        Me.TabControlFormulario.Controls.Add(Me.tpResolucion)
        Me.TabControlFormulario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlFormulario.Location = New System.Drawing.Point(0, 0)
        Me.TabControlFormulario.Name = "TabControlFormulario"
        Me.TabControlFormulario.SelectedIndex = 0
        Me.TabControlFormulario.Size = New System.Drawing.Size(1326, 786)
        Me.TabControlFormulario.TabIndex = 0
        '
        'tbpEntrevista
        '
        Me.tbpEntrevista.BackColor = System.Drawing.Color.LightBlue
        Me.tbpEntrevista.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbpEntrevista.Location = New System.Drawing.Point(4, 25)
        Me.tbpEntrevista.Name = "tbpEntrevista"
        Me.tbpEntrevista.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpEntrevista.Size = New System.Drawing.Size(1318, 757)
        Me.tbpEntrevista.TabIndex = 0
        Me.tbpEntrevista.Text = "Entrevista"
        '
        'tbpSintomasYsg
        '
        Me.tbpSintomasYsg.BackColor = System.Drawing.Color.LightBlue
        Me.tbpSintomasYsg.Controls.Add(Me.TableLayoutPanel1)
        Me.tbpSintomasYsg.Location = New System.Drawing.Point(4, 25)
        Me.tbpSintomasYsg.Name = "tbpSintomasYsg"
        Me.tbpSintomasYsg.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpSintomasYsg.Size = New System.Drawing.Size(1318, 757)
        Me.tbpSintomasYsg.TabIndex = 1
        Me.tbpSintomasYsg.Text = "Signos clínicos y síntomas"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlSigno, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1312, 751)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnBorrarSintoma)
        Me.Panel1.Controls.Add(Me.btnAgregarSintoma)
        Me.Panel1.Controls.Add(Me.lblIngreseSintoma)
        Me.Panel1.Controls.Add(Me.txtSintoma)
        Me.Panel1.Controls.Add(Me.lbSintomas)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(659, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(650, 745)
        Me.Panel1.TabIndex = 1
        '
        'btnBorrarSintoma
        '
        Me.btnBorrarSintoma.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrarSintoma.BackgroundImage = CType(resources.GetObject("btnBorrarSintoma.BackgroundImage"), System.Drawing.Image)
        Me.btnBorrarSintoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBorrarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarSintoma.Location = New System.Drawing.Point(584, 8)
        Me.btnBorrarSintoma.Name = "btnBorrarSintoma"
        Me.btnBorrarSintoma.Size = New System.Drawing.Size(40, 30)
        Me.btnBorrarSintoma.TabIndex = 41
        Me.btnBorrarSintoma.UseVisualStyleBackColor = True
        '
        'btnAgregarSintoma
        '
        Me.btnAgregarSintoma.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarSintoma.BackgroundImage = CType(resources.GetObject("btnAgregarSintoma.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarSintoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarSintoma.Location = New System.Drawing.Point(538, 8)
        Me.btnAgregarSintoma.Name = "btnAgregarSintoma"
        Me.btnAgregarSintoma.Size = New System.Drawing.Size(40, 30)
        Me.btnAgregarSintoma.TabIndex = 40
        Me.btnAgregarSintoma.UseVisualStyleBackColor = True
        '
        'lblIngreseSintoma
        '
        Me.lblIngreseSintoma.AutoSize = True
        Me.lblIngreseSintoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseSintoma.Location = New System.Drawing.Point(26, 9)
        Me.lblIngreseSintoma.Name = "lblIngreseSintoma"
        Me.lblIngreseSintoma.Size = New System.Drawing.Size(190, 29)
        Me.lblIngreseSintoma.TabIndex = 39
        Me.lblIngreseSintoma.Text = "Ingrese sintoma:"
        '
        'txtSintoma
        '
        Me.txtSintoma.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSintoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSintoma.Location = New System.Drawing.Point(242, 8)
        Me.txtSintoma.Name = "txtSintoma"
        Me.txtSintoma.Size = New System.Drawing.Size(290, 30)
        Me.txtSintoma.TabIndex = 38
        '
        'lbSintomas
        '
        Me.lbSintomas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSintomas.FormattingEnabled = True
        Me.lbSintomas.ItemHeight = 25
        Me.lbSintomas.Location = New System.Drawing.Point(31, 60)
        Me.lbSintomas.Name = "lbSintomas"
        Me.lbSintomas.Size = New System.Drawing.Size(593, 654)
        Me.lbSintomas.TabIndex = 37
        '
        'pnlSigno
        '
        Me.pnlSigno.Controls.Add(Me.btnBorrarSigno)
        Me.pnlSigno.Controls.Add(Me.btnAgregarSClinico)
        Me.pnlSigno.Controls.Add(Me.lblIngreseSignoClinico)
        Me.pnlSigno.Controls.Add(Me.txtSgClinico)
        Me.pnlSigno.Controls.Add(Me.lbSignosClinicos)
        Me.pnlSigno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSigno.Location = New System.Drawing.Point(3, 3)
        Me.pnlSigno.Name = "pnlSigno"
        Me.pnlSigno.Size = New System.Drawing.Size(650, 745)
        Me.pnlSigno.TabIndex = 0
        '
        'btnBorrarSigno
        '
        Me.btnBorrarSigno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrarSigno.BackgroundImage = CType(resources.GetObject("btnBorrarSigno.BackgroundImage"), System.Drawing.Image)
        Me.btnBorrarSigno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBorrarSigno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarSigno.Location = New System.Drawing.Point(584, 8)
        Me.btnBorrarSigno.Name = "btnBorrarSigno"
        Me.btnBorrarSigno.Size = New System.Drawing.Size(40, 30)
        Me.btnBorrarSigno.TabIndex = 41
        Me.btnBorrarSigno.UseVisualStyleBackColor = True
        '
        'btnAgregarSClinico
        '
        Me.btnAgregarSClinico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarSClinico.BackgroundImage = CType(resources.GetObject("btnAgregarSClinico.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarSClinico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarSClinico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarSClinico.Location = New System.Drawing.Point(538, 8)
        Me.btnAgregarSClinico.Name = "btnAgregarSClinico"
        Me.btnAgregarSClinico.Size = New System.Drawing.Size(40, 30)
        Me.btnAgregarSClinico.TabIndex = 40
        Me.btnAgregarSClinico.UseVisualStyleBackColor = True
        '
        'lblIngreseSignoClinico
        '
        Me.lblIngreseSignoClinico.AutoSize = True
        Me.lblIngreseSignoClinico.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseSignoClinico.Location = New System.Drawing.Point(26, 9)
        Me.lblIngreseSignoClinico.Name = "lblIngreseSignoClinico"
        Me.lblIngreseSignoClinico.Size = New System.Drawing.Size(240, 29)
        Me.lblIngreseSignoClinico.TabIndex = 39
        Me.lblIngreseSignoClinico.Text = "Ingrese signo clínico:"
        '
        'txtSgClinico
        '
        Me.txtSgClinico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSgClinico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSgClinico.Location = New System.Drawing.Point(289, 8)
        Me.txtSgClinico.Name = "txtSgClinico"
        Me.txtSgClinico.Size = New System.Drawing.Size(243, 30)
        Me.txtSgClinico.TabIndex = 38
        '
        'lbSignosClinicos
        '
        Me.lbSignosClinicos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbSignosClinicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSignosClinicos.FormattingEnabled = True
        Me.lbSignosClinicos.ItemHeight = 25
        Me.lbSignosClinicos.Location = New System.Drawing.Point(31, 60)
        Me.lbSignosClinicos.Name = "lbSignosClinicos"
        Me.lbSignosClinicos.Size = New System.Drawing.Size(593, 654)
        Me.lbSignosClinicos.TabIndex = 37
        '
        'tpResolucion
        '
        Me.tpResolucion.BackColor = System.Drawing.Color.LightBlue
        Me.tpResolucion.Controls.Add(Me.tblResolucion)
        Me.tpResolucion.Location = New System.Drawing.Point(4, 25)
        Me.tpResolucion.Name = "tpResolucion"
        Me.tpResolucion.Size = New System.Drawing.Size(1318, 757)
        Me.tpResolucion.TabIndex = 2
        Me.tpResolucion.Text = "Resolución"
        '
        'tblResolucion
        '
        Me.tblResolucion.ColumnCount = 3
        Me.tblResolucion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblResolucion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblResolucion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblResolucion.Controls.Add(Me.btnSugereirTratamiento, 0, 3)
        Me.tblResolucion.Controls.Add(Me.btnSugerirAnalisis, 0, 3)
        Me.tblResolucion.Controls.Add(Me.txtNomAnalisis, 2, 1)
        Me.tblResolucion.Controls.Add(Me.lblAnalisisReq, 1, 1)
        Me.tblResolucion.Controls.Add(Me.chkEnfermo, 0, 0)
        Me.tblResolucion.Controls.Add(Me.lblPresenta, 1, 0)
        Me.tblResolucion.Controls.Add(Me.txtNomEnfermedad, 2, 0)
        Me.tblResolucion.Controls.Add(Me.chkAnalisis, 0, 1)
        Me.tblResolucion.Controls.Add(Me.chkTratamiento, 0, 2)
        Me.tblResolucion.Controls.Add(Me.lblTratamientoS, 1, 2)
        Me.tblResolucion.Controls.Add(Me.txtNomTratamiento, 2, 2)
        Me.tblResolucion.Controls.Add(Me.btnSugerirDiagnostico, 1, 3)
        Me.tblResolucion.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblResolucion.Location = New System.Drawing.Point(0, 0)
        Me.tblResolucion.Name = "tblResolucion"
        Me.tblResolucion.RowCount = 4
        Me.tblResolucion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblResolucion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblResolucion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblResolucion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblResolucion.Size = New System.Drawing.Size(1318, 697)
        Me.tblResolucion.TabIndex = 0
        '
        'btnSugereirTratamiento
        '
        Me.btnSugereirTratamiento.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSugereirTratamiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSugereirTratamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSugereirTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSugereirTratamiento.Location = New System.Drawing.Point(442, 525)
        Me.btnSugereirTratamiento.Name = "btnSugereirTratamiento"
        Me.btnSugereirTratamiento.Size = New System.Drawing.Size(433, 169)
        Me.btnSugereirTratamiento.TabIndex = 12
        Me.btnSugereirTratamiento.Text = "Solicitar sugerencia de tratamiento"
        Me.btnSugereirTratamiento.UseVisualStyleBackColor = False
        '
        'btnSugerirAnalisis
        '
        Me.btnSugerirAnalisis.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSugerirAnalisis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSugerirAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSugerirAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSugerirAnalisis.Location = New System.Drawing.Point(3, 525)
        Me.btnSugerirAnalisis.Name = "btnSugerirAnalisis"
        Me.btnSugerirAnalisis.Size = New System.Drawing.Size(433, 169)
        Me.btnSugerirAnalisis.TabIndex = 11
        Me.btnSugerirAnalisis.Text = "Solicitar sugerencia de análisis"
        Me.btnSugerirAnalisis.UseVisualStyleBackColor = False
        '
        'txtNomAnalisis
        '
        Me.txtNomAnalisis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNomAnalisis.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtNomAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomAnalisis.Location = New System.Drawing.Point(908, 244)
        Me.txtNomAnalisis.Name = "txtNomAnalisis"
        Me.txtNomAnalisis.ReadOnly = True
        Me.txtNomAnalisis.Size = New System.Drawing.Size(379, 34)
        Me.txtNomAnalisis.TabIndex = 6
        Me.txtNomAnalisis.Visible = False
        '
        'lblAnalisisReq
        '
        Me.lblAnalisisReq.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAnalisisReq.AutoSize = True
        Me.lblAnalisisReq.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnalisisReq.Location = New System.Drawing.Point(572, 248)
        Me.lblAnalisisReq.Name = "lblAnalisisReq"
        Me.lblAnalisisReq.Size = New System.Drawing.Size(173, 25)
        Me.lblAnalisisReq.TabIndex = 5
        Me.lblAnalisisReq.Text = "Análisis requerido:"
        Me.lblAnalisisReq.Visible = False
        '
        'chkEnfermo
        '
        Me.chkEnfermo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.chkEnfermo.AutoSize = True
        Me.chkEnfermo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEnfermo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEnfermo.Location = New System.Drawing.Point(57, 3)
        Me.chkEnfermo.Name = "chkEnfermo"
        Me.chkEnfermo.Size = New System.Drawing.Size(325, 168)
        Me.chkEnfermo.TabIndex = 1
        Me.chkEnfermo.Text = "¿El paciente está enfermo?"
        Me.chkEnfermo.UseVisualStyleBackColor = True
        '
        'lblPresenta
        '
        Me.lblPresenta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPresenta.AutoSize = True
        Me.lblPresenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresenta.Location = New System.Drawing.Point(561, 74)
        Me.lblPresenta.Name = "lblPresenta"
        Me.lblPresenta.Size = New System.Drawing.Size(195, 25)
        Me.lblPresenta.TabIndex = 2
        Me.lblPresenta.Text = "El paciente presenta:"
        Me.lblPresenta.Visible = False
        '
        'txtNomEnfermedad
        '
        Me.txtNomEnfermedad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNomEnfermedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomEnfermedad.Location = New System.Drawing.Point(908, 70)
        Me.txtNomEnfermedad.Name = "txtNomEnfermedad"
        Me.txtNomEnfermedad.Size = New System.Drawing.Size(379, 34)
        Me.txtNomEnfermedad.TabIndex = 3
        Me.txtNomEnfermedad.Visible = False
        '
        'chkAnalisis
        '
        Me.chkAnalisis.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.chkAnalisis.AutoSize = True
        Me.chkAnalisis.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnalisis.Location = New System.Drawing.Point(22, 177)
        Me.chkAnalisis.Name = "chkAnalisis"
        Me.chkAnalisis.Size = New System.Drawing.Size(395, 168)
        Me.chkAnalisis.TabIndex = 4
        Me.chkAnalisis.Text = "¿El paciente requiere un análisis?"
        Me.chkAnalisis.UseVisualStyleBackColor = True
        '
        'chkTratamiento
        '
        Me.chkTratamiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.chkTratamiento.AutoSize = True
        Me.chkTratamiento.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTratamiento.Location = New System.Drawing.Point(53, 351)
        Me.chkTratamiento.Name = "chkTratamiento"
        Me.chkTratamiento.Size = New System.Drawing.Size(333, 168)
        Me.chkTratamiento.TabIndex = 7
        Me.chkTratamiento.Text = "¿Se sugiere un tratamiento?"
        Me.chkTratamiento.UseVisualStyleBackColor = True
        '
        'lblTratamientoS
        '
        Me.lblTratamientoS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTratamientoS.AutoSize = True
        Me.lblTratamientoS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTratamientoS.Location = New System.Drawing.Point(557, 422)
        Me.lblTratamientoS.Name = "lblTratamientoS"
        Me.lblTratamientoS.Size = New System.Drawing.Size(202, 25)
        Me.lblTratamientoS.TabIndex = 8
        Me.lblTratamientoS.Text = "Tratamiento sugerido:"
        Me.lblTratamientoS.Visible = False
        '
        'txtNomTratamiento
        '
        Me.txtNomTratamiento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNomTratamiento.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtNomTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomTratamiento.Location = New System.Drawing.Point(908, 418)
        Me.txtNomTratamiento.Name = "txtNomTratamiento"
        Me.txtNomTratamiento.ReadOnly = True
        Me.txtNomTratamiento.Size = New System.Drawing.Size(379, 34)
        Me.txtNomTratamiento.TabIndex = 9
        Me.txtNomTratamiento.Visible = False
        '
        'btnSugerirDiagnostico
        '
        Me.btnSugerirDiagnostico.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSugerirDiagnostico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSugerirDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSugerirDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSugerirDiagnostico.Location = New System.Drawing.Point(881, 525)
        Me.btnSugerirDiagnostico.Name = "btnSugerirDiagnostico"
        Me.btnSugerirDiagnostico.Size = New System.Drawing.Size(434, 169)
        Me.btnSugerirDiagnostico.TabIndex = 10
        Me.btnSugerirDiagnostico.Text = "Solicitar sugerencia de diagnóstico"
        Me.btnSugerirDiagnostico.UseVisualStyleBackColor = False
        '
        'ContenedorEntrevistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.TabControlFormulario)
        Me.Name = "ContenedorEntrevistas"
        Me.Size = New System.Drawing.Size(1326, 786)
        Me.TabControlFormulario.ResumeLayout(False)
        Me.tbpSintomasYsg.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlSigno.ResumeLayout(False)
        Me.pnlSigno.PerformLayout()
        Me.tpResolucion.ResumeLayout(False)
        Me.tblResolucion.ResumeLayout(False)
        Me.tblResolucion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlFormulario As TabControl
    Friend WithEvents tbpEntrevista As TabPage
    Friend WithEvents tbpSintomasYsg As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents pnlSigno As Panel
    Friend WithEvents btnBorrarSigno As Button
    Friend WithEvents btnAgregarSClinico As Button
    Friend WithEvents lblIngreseSignoClinico As Label
    Friend WithEvents txtSgClinico As TextBox
    Friend WithEvents lbSignosClinicos As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBorrarSintoma As Button
    Friend WithEvents btnAgregarSintoma As Button
    Friend WithEvents lblIngreseSintoma As Label
    Friend WithEvents txtSintoma As TextBox
    Friend WithEvents lbSintomas As ListBox
    Friend WithEvents tpResolucion As TabPage
    Friend WithEvents tblResolucion As TableLayoutPanel
    Friend WithEvents chkEnfermo As CheckBox
    Friend WithEvents lblPresenta As Label
    Friend WithEvents txtNomEnfermedad As TextBox
    Friend WithEvents txtNomAnalisis As TextBox
    Friend WithEvents lblAnalisisReq As Label
    Friend WithEvents chkTratamiento As CheckBox
    Friend WithEvents lblTratamientoS As Label
    Friend WithEvents txtNomTratamiento As TextBox
    Friend WithEvents btnSugerirDiagnostico As Button
    Friend WithEvents chkAnalisis As CheckBox
    Friend WithEvents btnSugereirTratamiento As Button
    Friend WithEvents btnSugerirAnalisis As Button
End Class
