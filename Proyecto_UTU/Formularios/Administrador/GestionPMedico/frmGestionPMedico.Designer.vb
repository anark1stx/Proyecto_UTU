<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionPMedico
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionPMedico))
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.tblPMedico = New System.Windows.Forms.TableLayoutPanel()
        Me.tblMedicoAsignaciones = New System.Windows.Forms.TableLayoutPanel()
        Me.lbMedicoAsignaciones = New System.Windows.Forms.ListBox()
        Me.tblAuxiliares = New System.Windows.Forms.TableLayoutPanel()
        Me.lbAuxiliarAsignaciones = New System.Windows.Forms.ListBox()
        Me.btnAgregarAsignar = New System.Windows.Forms.Button()
        Me.btnSacarAsignar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlContenedor.SuspendLayout()
        Me.tblPMedico.SuspendLayout()
        Me.tblMedicoAsignaciones.SuspendLayout()
        Me.tblAuxiliares.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.btnAgregarAsignar)
        Me.pnlContenedor.Controls.Add(Me.tblPMedico)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1446, 1055)
        Me.pnlContenedor.TabIndex = 0
        '
        'tblPMedico
        '
        Me.tblPMedico.ColumnCount = 2
        Me.tblPMedico.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1065.0!))
        Me.tblPMedico.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271.0!))
        Me.tblPMedico.Controls.Add(Me.tblMedicoAsignaciones, 1, 0)
        Me.tblPMedico.Controls.Add(Me.tblAuxiliares, 1, 1)
        Me.tblPMedico.Dock = System.Windows.Forms.DockStyle.Left
        Me.tblPMedico.Location = New System.Drawing.Point(0, 0)
        Me.tblPMedico.Name = "tblPMedico"
        Me.tblPMedico.RowCount = 2
        Me.tblPMedico.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPMedico.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPMedico.Size = New System.Drawing.Size(1336, 1055)
        Me.tblPMedico.TabIndex = 0
        '
        'tblMedicoAsignaciones
        '
        Me.tblMedicoAsignaciones.ColumnCount = 1
        Me.tblMedicoAsignaciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblMedicoAsignaciones.Controls.Add(Me.lbMedicoAsignaciones, 0, 0)
        Me.tblMedicoAsignaciones.Controls.Add(Me.btnSacarAsignar, 0, 1)
        Me.tblMedicoAsignaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblMedicoAsignaciones.Location = New System.Drawing.Point(1068, 3)
        Me.tblMedicoAsignaciones.Name = "tblMedicoAsignaciones"
        Me.tblMedicoAsignaciones.RowCount = 2
        Me.tblMedicoAsignaciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.74181!))
        Me.tblMedicoAsignaciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.25819!))
        Me.tblMedicoAsignaciones.Size = New System.Drawing.Size(265, 521)
        Me.tblMedicoAsignaciones.TabIndex = 0
        '
        'lbMedicoAsignaciones
        '
        Me.lbMedicoAsignaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbMedicoAsignaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMedicoAsignaciones.FormattingEnabled = True
        Me.lbMedicoAsignaciones.ItemHeight = 25
        Me.lbMedicoAsignaciones.Location = New System.Drawing.Point(3, 3)
        Me.lbMedicoAsignaciones.Name = "lbMedicoAsignaciones"
        Me.lbMedicoAsignaciones.Size = New System.Drawing.Size(259, 440)
        Me.lbMedicoAsignaciones.TabIndex = 1
        '
        'tblAuxiliares
        '
        Me.tblAuxiliares.ColumnCount = 1
        Me.tblAuxiliares.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblAuxiliares.Controls.Add(Me.Button1, 0, 1)
        Me.tblAuxiliares.Controls.Add(Me.lbAuxiliarAsignaciones, 0, 0)
        Me.tblAuxiliares.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblAuxiliares.Location = New System.Drawing.Point(1068, 530)
        Me.tblAuxiliares.Name = "tblAuxiliares"
        Me.tblAuxiliares.RowCount = 2
        Me.tblAuxiliares.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.77706!))
        Me.tblAuxiliares.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.22294!))
        Me.tblAuxiliares.Size = New System.Drawing.Size(265, 522)
        Me.tblAuxiliares.TabIndex = 1
        '
        'lbAuxiliarAsignaciones
        '
        Me.lbAuxiliarAsignaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbAuxiliarAsignaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAuxiliarAsignaciones.FormattingEnabled = True
        Me.lbAuxiliarAsignaciones.ItemHeight = 29
        Me.lbAuxiliarAsignaciones.Location = New System.Drawing.Point(3, 3)
        Me.lbAuxiliarAsignaciones.Name = "lbAuxiliarAsignaciones"
        Me.lbAuxiliarAsignaciones.Size = New System.Drawing.Size(259, 431)
        Me.lbAuxiliarAsignaciones.TabIndex = 2
        '
        'btnAgregarAsignar
        '
        Me.btnAgregarAsignar.BackColor = System.Drawing.Color.PaleGreen
        Me.btnAgregarAsignar.BackgroundImage = CType(resources.GetObject("btnAgregarAsignar.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarAsignar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarAsignar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAgregarAsignar.Location = New System.Drawing.Point(1336, 0)
        Me.btnAgregarAsignar.Name = "btnAgregarAsignar"
        Me.btnAgregarAsignar.Size = New System.Drawing.Size(110, 1055)
        Me.btnAgregarAsignar.TabIndex = 1
        Me.btnAgregarAsignar.UseVisualStyleBackColor = False
        '
        'btnSacarAsignar
        '
        Me.btnSacarAsignar.BackgroundImage = CType(resources.GetObject("btnSacarAsignar.BackgroundImage"), System.Drawing.Image)
        Me.btnSacarAsignar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSacarAsignar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSacarAsignar.Location = New System.Drawing.Point(3, 449)
        Me.btnSacarAsignar.Name = "btnSacarAsignar"
        Me.btnSacarAsignar.Size = New System.Drawing.Size(259, 69)
        Me.btnSacarAsignar.TabIndex = 2
        Me.btnSacarAsignar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(3, 440)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(259, 79)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmGestionPMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1446, 1055)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Name = "frmGestionPMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGestionPMedico"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlContenedor.ResumeLayout(False)
        Me.tblPMedico.ResumeLayout(False)
        Me.tblMedicoAsignaciones.ResumeLayout(False)
        Me.tblAuxiliares.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents tblPMedico As TableLayoutPanel
    Friend WithEvents btnAgregarAsignar As Button
    Friend WithEvents tblMedicoAsignaciones As TableLayoutPanel
    Friend WithEvents lbMedicoAsignaciones As ListBox
    Friend WithEvents btnSacarAsignar As Button
    Friend WithEvents tblAuxiliares As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents lbAuxiliarAsignaciones As ListBox
End Class
