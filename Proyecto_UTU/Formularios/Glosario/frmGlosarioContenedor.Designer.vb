<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGlosarioContenedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGlosarioContenedor))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.rbtnSintoma = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbtnSignoC = New System.Windows.Forms.RadioButton()
        Me.rbtnEnfermedad = New System.Windows.Forms.RadioButton()
        Me.pnlDatos = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.rbtnCategorias = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.btnBuscar, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBuscar, 0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'txtBuscar
        '
        resources.ApplyResources(Me.txtBuscar, "txtBuscar")
        Me.txtBuscar.Name = "txtBuscar"
        '
        'rbtnSintoma
        '
        resources.ApplyResources(Me.rbtnSintoma, "rbtnSintoma")
        Me.rbtnSintoma.Name = "rbtnSintoma"
        Me.rbtnSintoma.TabStop = True
        Me.rbtnSintoma.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbtnCategorias)
        Me.Panel2.Controls.Add(Me.rbtnEnfermedad)
        Me.Panel2.Controls.Add(Me.rbtnSignoC)
        Me.Panel2.Controls.Add(Me.rbtnSintoma)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'rbtnSignoC
        '
        resources.ApplyResources(Me.rbtnSignoC, "rbtnSignoC")
        Me.rbtnSignoC.Name = "rbtnSignoC"
        Me.rbtnSignoC.TabStop = True
        Me.rbtnSignoC.UseVisualStyleBackColor = True
        '
        'rbtnEnfermedad
        '
        resources.ApplyResources(Me.rbtnEnfermedad, "rbtnEnfermedad")
        Me.rbtnEnfermedad.Name = "rbtnEnfermedad"
        Me.rbtnEnfermedad.TabStop = True
        Me.rbtnEnfermedad.UseVisualStyleBackColor = True
        '
        'pnlDatos
        '
        resources.ApplyResources(Me.pnlDatos, "pnlDatos")
        Me.pnlDatos.Name = "pnlDatos"
        '
        'btnBuscar
        '
        resources.ApplyResources(Me.btnBuscar, "btnBuscar")
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'rbtnCategorias
        '
        resources.ApplyResources(Me.rbtnCategorias, "rbtnCategorias")
        Me.rbtnCategorias.Name = "rbtnCategorias"
        Me.rbtnCategorias.TabStop = True
        Me.rbtnCategorias.UseVisualStyleBackColor = True
        '
        'frmGlosarioContenedor
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.pnlDatos)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmGlosarioContenedor"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rbtnEnfermedad As RadioButton
    Friend WithEvents rbtnSignoC As RadioButton
    Friend WithEvents rbtnSintoma As RadioButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents rbtnCategorias As RadioButton
End Class
