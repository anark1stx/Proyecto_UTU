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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tblPMedico = New System.Windows.Forms.TableLayoutPanel()
        Me.tblMedicoAsignaciones = New System.Windows.Forms.TableLayoutPanel()
        Me.lbMedicoAsignaciones = New System.Windows.Forms.ListBox()
        Me.btnSacarAsignarM = New System.Windows.Forms.Button()
        Me.tblAuxiliares = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSacarAsginarA = New System.Windows.Forms.Button()
        Me.lbAuxiliarAsignaciones = New System.Windows.Forms.ListBox()
        Me.btnAgregarAsignar = New System.Windows.Forms.Button()
        Me.pnlContenedor.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tblPMedico.SuspendLayout()
        Me.tblMedicoAsignaciones.SuspendLayout()
        Me.tblAuxiliares.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.Panel1)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1446, 1055)
        Me.pnlContenedor.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1446, 1055)
        Me.Panel1.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.83955!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.160442!))
        Me.TableLayoutPanel1.Controls.Add(Me.tblPMedico, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAgregarAsignar, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1446, 1055)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'tblPMedico
        '
        Me.tblPMedico.ColumnCount = 2
        Me.tblPMedico.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1065.0!))
        Me.tblPMedico.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271.0!))
        Me.tblPMedico.Controls.Add(Me.tblMedicoAsignaciones, 1, 0)
        Me.tblPMedico.Controls.Add(Me.tblAuxiliares, 1, 1)
        Me.tblPMedico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblPMedico.Location = New System.Drawing.Point(3, 3)
        Me.tblPMedico.Name = "tblPMedico"
        Me.tblPMedico.RowCount = 2
        Me.tblPMedico.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPMedico.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPMedico.Size = New System.Drawing.Size(1321, 1049)
        Me.tblPMedico.TabIndex = 2
        '
        'tblMedicoAsignaciones
        '
        Me.tblMedicoAsignaciones.ColumnCount = 1
        Me.tblMedicoAsignaciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblMedicoAsignaciones.Controls.Add(Me.lbMedicoAsignaciones, 0, 0)
        Me.tblMedicoAsignaciones.Controls.Add(Me.btnSacarAsignarM, 0, 1)
        Me.tblMedicoAsignaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblMedicoAsignaciones.Location = New System.Drawing.Point(1068, 3)
        Me.tblMedicoAsignaciones.Name = "tblMedicoAsignaciones"
        Me.tblMedicoAsignaciones.RowCount = 2
        Me.tblMedicoAsignaciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.74181!))
        Me.tblMedicoAsignaciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.25819!))
        Me.tblMedicoAsignaciones.Size = New System.Drawing.Size(265, 518)
        Me.tblMedicoAsignaciones.TabIndex = 0
        '
        'lbMedicoAsignaciones
        '
        Me.lbMedicoAsignaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbMedicoAsignaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMedicoAsignaciones.FormattingEnabled = True
        Me.lbMedicoAsignaciones.HorizontalScrollbar = True
        Me.lbMedicoAsignaciones.ItemHeight = 25
        Me.lbMedicoAsignaciones.Location = New System.Drawing.Point(3, 3)
        Me.lbMedicoAsignaciones.Name = "lbMedicoAsignaciones"
        Me.lbMedicoAsignaciones.Size = New System.Drawing.Size(259, 438)
        Me.lbMedicoAsignaciones.TabIndex = 1
        '
        'btnSacarAsignarM
        '
        Me.btnSacarAsignarM.BackgroundImage = CType(resources.GetObject("btnSacarAsignarM.BackgroundImage"), System.Drawing.Image)
        Me.btnSacarAsignarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSacarAsignarM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSacarAsignarM.Location = New System.Drawing.Point(3, 447)
        Me.btnSacarAsignarM.Name = "btnSacarAsignarM"
        Me.btnSacarAsignarM.Size = New System.Drawing.Size(259, 68)
        Me.btnSacarAsignarM.TabIndex = 2
        Me.btnSacarAsignarM.UseVisualStyleBackColor = True
        '
        'tblAuxiliares
        '
        Me.tblAuxiliares.ColumnCount = 1
        Me.tblAuxiliares.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblAuxiliares.Controls.Add(Me.btnSacarAsginarA, 0, 1)
        Me.tblAuxiliares.Controls.Add(Me.lbAuxiliarAsignaciones, 0, 0)
        Me.tblAuxiliares.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblAuxiliares.Location = New System.Drawing.Point(1068, 527)
        Me.tblAuxiliares.Name = "tblAuxiliares"
        Me.tblAuxiliares.RowCount = 2
        Me.tblAuxiliares.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.77706!))
        Me.tblAuxiliares.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.22294!))
        Me.tblAuxiliares.Size = New System.Drawing.Size(265, 519)
        Me.tblAuxiliares.TabIndex = 1
        '
        'btnSacarAsginarA
        '
        Me.btnSacarAsginarA.BackgroundImage = CType(resources.GetObject("btnSacarAsginarA.BackgroundImage"), System.Drawing.Image)
        Me.btnSacarAsginarA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSacarAsginarA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSacarAsginarA.Location = New System.Drawing.Point(3, 437)
        Me.btnSacarAsginarA.Name = "btnSacarAsginarA"
        Me.btnSacarAsginarA.Size = New System.Drawing.Size(259, 79)
        Me.btnSacarAsginarA.TabIndex = 3
        Me.btnSacarAsginarA.UseVisualStyleBackColor = True
        '
        'lbAuxiliarAsignaciones
        '
        Me.lbAuxiliarAsignaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbAuxiliarAsignaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAuxiliarAsignaciones.FormattingEnabled = True
        Me.lbAuxiliarAsignaciones.HorizontalScrollbar = True
        Me.lbAuxiliarAsignaciones.ItemHeight = 29
        Me.lbAuxiliarAsignaciones.Location = New System.Drawing.Point(3, 3)
        Me.lbAuxiliarAsignaciones.Name = "lbAuxiliarAsignaciones"
        Me.lbAuxiliarAsignaciones.Size = New System.Drawing.Size(259, 428)
        Me.lbAuxiliarAsignaciones.TabIndex = 2
        '
        'btnAgregarAsignar
        '
        Me.btnAgregarAsignar.BackColor = System.Drawing.Color.PaleGreen
        Me.btnAgregarAsignar.BackgroundImage = CType(resources.GetObject("btnAgregarAsignar.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarAsignar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarAsignar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAgregarAsignar.Location = New System.Drawing.Point(1333, 3)
        Me.btnAgregarAsignar.Name = "btnAgregarAsignar"
        Me.btnAgregarAsignar.Size = New System.Drawing.Size(110, 1049)
        Me.btnAgregarAsignar.TabIndex = 1
        Me.btnAgregarAsignar.UseVisualStyleBackColor = False
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
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tblPMedico.ResumeLayout(False)
        Me.tblMedicoAsignaciones.ResumeLayout(False)
        Me.tblAuxiliares.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents btnAgregarAsignar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tblPMedico As TableLayoutPanel
    Friend WithEvents tblMedicoAsignaciones As TableLayoutPanel
    Friend WithEvents lbMedicoAsignaciones As ListBox
    Friend WithEvents btnSacarAsignarM As Button
    Friend WithEvents tblAuxiliares As TableLayoutPanel
    Friend WithEvents btnSacarAsginarA As Button
    Friend WithEvents lbAuxiliarAsignaciones As ListBox
End Class
