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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkEnfermo = New System.Windows.Forms.CheckBox()
        Me.lblPresenta = New System.Windows.Forms.Label()
        Me.txtNomEnfermedad = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomAnalisis = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomTratamiento = New System.Windows.Forms.TextBox()
        Me.TabControlFormulario.SuspendLayout()
        Me.tbpSintomasYsg.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlSigno.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlFormulario
        '
        Me.TabControlFormulario.Controls.Add(Me.tbpEntrevista)
        Me.TabControlFormulario.Controls.Add(Me.tbpSintomasYsg)
        Me.TabControlFormulario.Controls.Add(Me.TabPage1)
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
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightBlue
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1318, 757)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Resolución"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtNomAnalisis, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.chkEnfermo, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblPresenta, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNomEnfermedad, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CheckBox1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.CheckBox2, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNomTratamiento, 2, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1318, 757)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'chkEnfermo
        '
        Me.chkEnfermo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.chkEnfermo.AutoSize = True
        Me.chkEnfermo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEnfermo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEnfermo.Location = New System.Drawing.Point(57, 3)
        Me.chkEnfermo.Name = "chkEnfermo"
        Me.chkEnfermo.Size = New System.Drawing.Size(325, 246)
        Me.chkEnfermo.TabIndex = 1
        Me.chkEnfermo.Text = "¿El paciente está enfermo?"
        Me.chkEnfermo.UseVisualStyleBackColor = True
        '
        'lblPresenta
        '
        Me.lblPresenta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPresenta.AutoSize = True
        Me.lblPresenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresenta.Location = New System.Drawing.Point(561, 113)
        Me.lblPresenta.Name = "lblPresenta"
        Me.lblPresenta.Size = New System.Drawing.Size(195, 25)
        Me.lblPresenta.TabIndex = 2
        Me.lblPresenta.Text = "El paciente presenta:"
        '
        'txtNomEnfermedad
        '
        Me.txtNomEnfermedad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNomEnfermedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomEnfermedad.Location = New System.Drawing.Point(908, 109)
        Me.txtNomEnfermedad.Name = "txtNomEnfermedad"
        Me.txtNomEnfermedad.Size = New System.Drawing.Size(379, 34)
        Me.txtNomEnfermedad.TabIndex = 3
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(22, 255)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(395, 246)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "¿El paciente requiere un análisis?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(572, 365)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Análisis requerido:"
        '
        'txtNomAnalisis
        '
        Me.txtNomAnalisis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNomAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomAnalisis.Location = New System.Drawing.Point(908, 361)
        Me.txtNomAnalisis.Name = "txtNomAnalisis"
        Me.txtNomAnalisis.Size = New System.Drawing.Size(379, 34)
        Me.txtNomAnalisis.TabIndex = 6
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(53, 507)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(333, 247)
        Me.CheckBox2.TabIndex = 7
        Me.CheckBox2.Text = "¿Se sugiere un tratamiento?"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(557, 618)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tratamiento sugerido:"
        '
        'txtNomTratamiento
        '
        Me.txtNomTratamiento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNomTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomTratamiento.Location = New System.Drawing.Point(908, 613)
        Me.txtNomTratamiento.Name = "txtNomTratamiento"
        Me.txtNomTratamiento.Size = New System.Drawing.Size(379, 34)
        Me.txtNomTratamiento.TabIndex = 9
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
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
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
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents chkEnfermo As CheckBox
    Friend WithEvents lblPresenta As Label
    Friend WithEvents txtNomEnfermedad As TextBox
    Friend WithEvents txtNomAnalisis As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNomTratamiento As TextBox
End Class
