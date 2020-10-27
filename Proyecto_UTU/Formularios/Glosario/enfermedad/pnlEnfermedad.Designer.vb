<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlEnfermedad
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlEnfermedad))
        Me.lblNomE = New System.Windows.Forms.Label()
        Me.txtNomEnfermedad = New System.Windows.Forms.TextBox()
        Me.txtDescrEnfermedad = New System.Windows.Forms.TextBox()
        Me.lblFEtaria = New System.Windows.Forms.Label()
        Me.txtFEteriaMin = New System.Windows.Forms.TextBox()
        Me.lblguion = New System.Windows.Forms.Label()
        Me.txtFEteriaMax = New System.Windows.Forms.TextBox()
        Me.lblSintomasEnf = New System.Windows.Forms.Label()
        Me.lblSCcomunes = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbSignosC = New System.Windows.Forms.ListBox()
        Me.lbSintomas = New System.Windows.Forms.ListBox()
        Me.pnlAgregarS = New System.Windows.Forms.Panel()
        Me.btnAgregarSintoma = New System.Windows.Forms.Button()
        Me.btnSacarSintoma = New System.Windows.Forms.Button()
        Me.txtSintomas = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.pnlAgregarSC = New System.Windows.Forms.Panel()
        Me.btnAgregarSC = New System.Windows.Forms.Button()
        Me.btnSacarSignoC = New System.Windows.Forms.Button()
        Me.txtSignoC = New System.Windows.Forms.TextBox()
        Me.lblAnos = New System.Windows.Forms.Label()
        Me.btnCategorizarEnfermedad = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlAgregarS.SuspendLayout()
        Me.pnlAgregarSC.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNomE
        '
        Me.lblNomE.AutoSize = True
        Me.lblNomE.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomE.Location = New System.Drawing.Point(3, 13)
        Me.lblNomE.Name = "lblNomE"
        Me.lblNomE.Size = New System.Drawing.Size(516, 46)
        Me.lblNomE.TabIndex = 0
        Me.lblNomE.Text = "Nombre de la enfermedad:"
        '
        'txtNomEnfermedad
        '
        Me.txtNomEnfermedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomEnfermedad.Location = New System.Drawing.Point(524, 6)
        Me.txtNomEnfermedad.MaxLength = 160
        Me.txtNomEnfermedad.Name = "txtNomEnfermedad"
        Me.txtNomEnfermedad.Size = New System.Drawing.Size(922, 53)
        Me.txtNomEnfermedad.TabIndex = 1
        '
        'txtDescrEnfermedad
        '
        Me.txtDescrEnfermedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrEnfermedad.Location = New System.Drawing.Point(11, 74)
        Me.txtDescrEnfermedad.MaxLength = 16000
        Me.txtDescrEnfermedad.Multiline = True
        Me.txtDescrEnfermedad.Name = "txtDescrEnfermedad"
        Me.txtDescrEnfermedad.Size = New System.Drawing.Size(1435, 409)
        Me.txtDescrEnfermedad.TabIndex = 2
        '
        'lblFEtaria
        '
        Me.lblFEtaria.AutoSize = True
        Me.lblFEtaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFEtaria.Location = New System.Drawing.Point(3, 515)
        Me.lblFEtaria.Name = "lblFEtaria"
        Me.lblFEtaria.Size = New System.Drawing.Size(268, 46)
        Me.lblFEtaria.TabIndex = 3
        Me.lblFEtaria.Text = "Franja etaria:"
        '
        'txtFEteriaMin
        '
        Me.txtFEteriaMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFEteriaMin.Location = New System.Drawing.Point(277, 508)
        Me.txtFEteriaMin.Name = "txtFEteriaMin"
        Me.txtFEteriaMin.Size = New System.Drawing.Size(96, 53)
        Me.txtFEteriaMin.TabIndex = 4
        '
        'lblguion
        '
        Me.lblguion.AutoSize = True
        Me.lblguion.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblguion.Location = New System.Drawing.Point(379, 511)
        Me.lblguion.Name = "lblguion"
        Me.lblguion.Size = New System.Drawing.Size(34, 46)
        Me.lblguion.TabIndex = 5
        Me.lblguion.Text = "-"
        '
        'txtFEteriaMax
        '
        Me.txtFEteriaMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFEteriaMax.Location = New System.Drawing.Point(423, 508)
        Me.txtFEteriaMax.Name = "txtFEteriaMax"
        Me.txtFEteriaMax.Size = New System.Drawing.Size(96, 53)
        Me.txtFEteriaMax.TabIndex = 6
        '
        'lblSintomasEnf
        '
        Me.lblSintomasEnf.AutoSize = True
        Me.lblSintomasEnf.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSintomasEnf.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSintomasEnf.Location = New System.Drawing.Point(3, 0)
        Me.lblSintomasEnf.Name = "lblSintomasEnf"
        Me.lblSintomasEnf.Size = New System.Drawing.Size(711, 46)
        Me.lblSintomasEnf.TabIndex = 7
        Me.lblSintomasEnf.Text = "Sintomas comunes:"
        Me.lblSintomasEnf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSCcomunes
        '
        Me.lblSCcomunes.AutoSize = True
        Me.lblSCcomunes.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSCcomunes.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSCcomunes.Location = New System.Drawing.Point(720, 0)
        Me.lblSCcomunes.Name = "lblSCcomunes"
        Me.lblSCcomunes.Size = New System.Drawing.Size(712, 46)
        Me.lblSCcomunes.TabIndex = 8
        Me.lblSCcomunes.Text = "Signos clinicos comunes:"
        Me.lblSCcomunes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pnlAgregarSC, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbSignosC, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSintomasEnf, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSCcomunes, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbSintomas, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlAgregarS, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 583)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1435, 423)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'lbSignosC
        '
        Me.lbSignosC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbSignosC.FormattingEnabled = True
        Me.lbSignosC.ItemHeight = 16
        Me.lbSignosC.Location = New System.Drawing.Point(720, 57)
        Me.lbSignosC.Name = "lbSignosC"
        Me.lbSignosC.Size = New System.Drawing.Size(712, 300)
        Me.lbSignosC.TabIndex = 10
        '
        'lbSintomas
        '
        Me.lbSintomas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbSintomas.FormattingEnabled = True
        Me.lbSintomas.ItemHeight = 16
        Me.lbSintomas.Location = New System.Drawing.Point(3, 57)
        Me.lbSintomas.Name = "lbSintomas"
        Me.lbSintomas.Size = New System.Drawing.Size(711, 300)
        Me.lbSintomas.TabIndex = 9
        '
        'pnlAgregarS
        '
        Me.pnlAgregarS.Controls.Add(Me.btnAgregarSintoma)
        Me.pnlAgregarS.Controls.Add(Me.btnSacarSintoma)
        Me.pnlAgregarS.Controls.Add(Me.txtSintomas)
        Me.pnlAgregarS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAgregarS.Location = New System.Drawing.Point(3, 363)
        Me.pnlAgregarS.Name = "pnlAgregarS"
        Me.pnlAgregarS.Size = New System.Drawing.Size(711, 57)
        Me.pnlAgregarS.TabIndex = 11
        '
        'btnAgregarSintoma
        '
        Me.btnAgregarSintoma.BackgroundImage = CType(resources.GetObject("btnAgregarSintoma.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarSintoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarSintoma.Location = New System.Drawing.Point(638, 3)
        Me.btnAgregarSintoma.Name = "btnAgregarSintoma"
        Me.btnAgregarSintoma.Size = New System.Drawing.Size(70, 51)
        Me.btnAgregarSintoma.TabIndex = 2
        Me.btnAgregarSintoma.UseVisualStyleBackColor = True
        '
        'btnSacarSintoma
        '
        Me.btnSacarSintoma.BackgroundImage = CType(resources.GetObject("btnSacarSintoma.BackgroundImage"), System.Drawing.Image)
        Me.btnSacarSintoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSacarSintoma.Location = New System.Drawing.Point(566, 3)
        Me.btnSacarSintoma.Name = "btnSacarSintoma"
        Me.btnSacarSintoma.Size = New System.Drawing.Size(70, 51)
        Me.btnSacarSintoma.TabIndex = 1
        Me.btnSacarSintoma.UseVisualStyleBackColor = True
        '
        'txtSintomas
        '
        Me.txtSintomas.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtSintomas.Location = New System.Drawing.Point(0, 0)
        Me.txtSintomas.Multiline = True
        Me.txtSintomas.Name = "txtSintomas"
        Me.txtSintomas.Size = New System.Drawing.Size(565, 57)
        Me.txtSintomas.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(0, 1132)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(1450, 84)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'pnlAgregarSC
        '
        Me.pnlAgregarSC.Controls.Add(Me.btnAgregarSC)
        Me.pnlAgregarSC.Controls.Add(Me.btnSacarSignoC)
        Me.pnlAgregarSC.Controls.Add(Me.txtSignoC)
        Me.pnlAgregarSC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAgregarSC.Location = New System.Drawing.Point(720, 363)
        Me.pnlAgregarSC.Name = "pnlAgregarSC"
        Me.pnlAgregarSC.Size = New System.Drawing.Size(712, 57)
        Me.pnlAgregarSC.TabIndex = 12
        '
        'btnAgregarSC
        '
        Me.btnAgregarSC.BackgroundImage = CType(resources.GetObject("btnAgregarSC.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarSC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarSC.Location = New System.Drawing.Point(638, 3)
        Me.btnAgregarSC.Name = "btnAgregarSC"
        Me.btnAgregarSC.Size = New System.Drawing.Size(70, 51)
        Me.btnAgregarSC.TabIndex = 2
        Me.btnAgregarSC.UseVisualStyleBackColor = True
        '
        'btnSacarSignoC
        '
        Me.btnSacarSignoC.BackgroundImage = CType(resources.GetObject("btnSacarSignoC.BackgroundImage"), System.Drawing.Image)
        Me.btnSacarSignoC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSacarSignoC.Location = New System.Drawing.Point(566, 3)
        Me.btnSacarSignoC.Name = "btnSacarSignoC"
        Me.btnSacarSignoC.Size = New System.Drawing.Size(70, 51)
        Me.btnSacarSignoC.TabIndex = 1
        Me.btnSacarSignoC.UseVisualStyleBackColor = True
        '
        'txtSignoC
        '
        Me.txtSignoC.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtSignoC.Location = New System.Drawing.Point(0, 0)
        Me.txtSignoC.Multiline = True
        Me.txtSignoC.Name = "txtSignoC"
        Me.txtSignoC.Size = New System.Drawing.Size(565, 57)
        Me.txtSignoC.TabIndex = 0
        '
        'lblAnos
        '
        Me.lblAnos.AutoSize = True
        Me.lblAnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnos.Location = New System.Drawing.Point(525, 528)
        Me.lblAnos.Name = "lblAnos"
        Me.lblAnos.Size = New System.Drawing.Size(81, 32)
        Me.lblAnos.TabIndex = 11
        Me.lblAnos.Text = "años"
        '
        'btnCategorizarEnfermedad
        '
        Me.btnCategorizarEnfermedad.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCategorizarEnfermedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategorizarEnfermedad.Location = New System.Drawing.Point(0, 1048)
        Me.btnCategorizarEnfermedad.Name = "btnCategorizarEnfermedad"
        Me.btnCategorizarEnfermedad.Size = New System.Drawing.Size(1450, 84)
        Me.btnCategorizarEnfermedad.TabIndex = 12
        Me.btnCategorizarEnfermedad.Text = "CATEGORIZAR ENFERMEDAD"
        Me.btnCategorizarEnfermedad.UseVisualStyleBackColor = True
        '
        'pnlEnfermedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnCategorizarEnfermedad)
        Me.Controls.Add(Me.lblAnos)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.txtFEteriaMax)
        Me.Controls.Add(Me.lblguion)
        Me.Controls.Add(Me.txtFEteriaMin)
        Me.Controls.Add(Me.lblFEtaria)
        Me.Controls.Add(Me.txtDescrEnfermedad)
        Me.Controls.Add(Me.txtNomEnfermedad)
        Me.Controls.Add(Me.lblNomE)
        Me.Name = "pnlEnfermedad"
        Me.Size = New System.Drawing.Size(1450, 1216)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.pnlAgregarS.ResumeLayout(False)
        Me.pnlAgregarS.PerformLayout()
        Me.pnlAgregarSC.ResumeLayout(False)
        Me.pnlAgregarSC.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNomE As Label
    Friend WithEvents txtNomEnfermedad As TextBox
    Friend WithEvents txtDescrEnfermedad As TextBox
    Friend WithEvents lblFEtaria As Label
    Friend WithEvents txtFEteriaMin As TextBox
    Friend WithEvents lblguion As Label
    Friend WithEvents txtFEteriaMax As TextBox
    Friend WithEvents lblSintomasEnf As Label
    Friend WithEvents lblSCcomunes As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbSignosC As ListBox
    Friend WithEvents lbSintomas As ListBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents pnlAgregarS As Panel
    Friend WithEvents btnAgregarSintoma As Button
    Friend WithEvents btnSacarSintoma As Button
    Friend WithEvents txtSintomas As TextBox
    Friend WithEvents pnlAgregarSC As Panel
    Friend WithEvents btnAgregarSC As Button
    Friend WithEvents btnSacarSignoC As Button
    Friend WithEvents txtSignoC As TextBox
    Friend WithEvents lblAnos As Label
    Friend WithEvents btnCategorizarEnfermedad As Button
End Class
