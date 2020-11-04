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
        resources.ApplyResources(Me.pnlContenedor, "pnlContenedor")
        Me.pnlContenedor.Controls.Add(Me.Panel1)
        Me.pnlContenedor.Name = "pnlContenedor"
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Name = "Panel1"
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.tblPMedico, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAgregarAsignar, 1, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'tblPMedico
        '
        resources.ApplyResources(Me.tblPMedico, "tblPMedico")
        Me.tblPMedico.Controls.Add(Me.tblMedicoAsignaciones, 1, 0)
        Me.tblPMedico.Controls.Add(Me.tblAuxiliares, 1, 1)
        Me.tblPMedico.Name = "tblPMedico"
        '
        'tblMedicoAsignaciones
        '
        resources.ApplyResources(Me.tblMedicoAsignaciones, "tblMedicoAsignaciones")
        Me.tblMedicoAsignaciones.Controls.Add(Me.lbMedicoAsignaciones, 0, 0)
        Me.tblMedicoAsignaciones.Controls.Add(Me.btnSacarAsignarM, 0, 1)
        Me.tblMedicoAsignaciones.Name = "tblMedicoAsignaciones"
        '
        'lbMedicoAsignaciones
        '
        resources.ApplyResources(Me.lbMedicoAsignaciones, "lbMedicoAsignaciones")
        Me.lbMedicoAsignaciones.FormattingEnabled = True
        Me.lbMedicoAsignaciones.Name = "lbMedicoAsignaciones"
        '
        'btnSacarAsignarM
        '
        resources.ApplyResources(Me.btnSacarAsignarM, "btnSacarAsignarM")
        Me.btnSacarAsignarM.Name = "btnSacarAsignarM"
        Me.btnSacarAsignarM.UseVisualStyleBackColor = True
        '
        'tblAuxiliares
        '
        resources.ApplyResources(Me.tblAuxiliares, "tblAuxiliares")
        Me.tblAuxiliares.Controls.Add(Me.btnSacarAsginarA, 0, 1)
        Me.tblAuxiliares.Controls.Add(Me.lbAuxiliarAsignaciones, 0, 0)
        Me.tblAuxiliares.Name = "tblAuxiliares"
        '
        'btnSacarAsginarA
        '
        resources.ApplyResources(Me.btnSacarAsginarA, "btnSacarAsginarA")
        Me.btnSacarAsginarA.Name = "btnSacarAsginarA"
        Me.btnSacarAsginarA.UseVisualStyleBackColor = True
        '
        'lbAuxiliarAsignaciones
        '
        resources.ApplyResources(Me.lbAuxiliarAsignaciones, "lbAuxiliarAsignaciones")
        Me.lbAuxiliarAsignaciones.FormattingEnabled = True
        Me.lbAuxiliarAsignaciones.Name = "lbAuxiliarAsignaciones"
        '
        'btnAgregarAsignar
        '
        resources.ApplyResources(Me.btnAgregarAsignar, "btnAgregarAsignar")
        Me.btnAgregarAsignar.BackColor = System.Drawing.Color.PaleGreen
        Me.btnAgregarAsignar.Name = "btnAgregarAsignar"
        Me.btnAgregarAsignar.UseVisualStyleBackColor = False
        '
        'frmGestionPMedico
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.pnlContenedor)
        Me.Name = "frmGestionPMedico"
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
