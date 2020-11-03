<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicioPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicioPaciente))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblGestion = New System.Windows.Forms.Label()
        Me.btnGestion = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblDiagnosticos = New System.Windows.Forms.Label()
        Me.btnDiagnosticos = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblAnalisis = New System.Windows.Forms.Label()
        Me.btnAnalisis = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTratamientos = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Controls.Add(Me.lblGestion)
        Me.Panel1.Controls.Add(Me.btnGestion)
        Me.Panel1.Name = "Panel1"
        '
        'lblGestion
        '
        resources.ApplyResources(Me.lblGestion, "lblGestion")
        Me.lblGestion.Name = "lblGestion"
        '
        'btnGestion
        '
        resources.ApplyResources(Me.btnGestion, "btnGestion")
        Me.btnGestion.Name = "btnGestion"
        Me.btnGestion.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Controls.Add(Me.lblDiagnosticos)
        Me.Panel2.Controls.Add(Me.btnDiagnosticos)
        Me.Panel2.Name = "Panel2"
        '
        'lblDiagnosticos
        '
        resources.ApplyResources(Me.lblDiagnosticos, "lblDiagnosticos")
        Me.lblDiagnosticos.Name = "lblDiagnosticos"
        '
        'btnDiagnosticos
        '
        resources.ApplyResources(Me.btnDiagnosticos, "btnDiagnosticos")
        Me.btnDiagnosticos.Name = "btnDiagnosticos"
        Me.btnDiagnosticos.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Controls.Add(Me.lblAnalisis)
        Me.Panel3.Controls.Add(Me.btnAnalisis)
        Me.Panel3.Name = "Panel3"
        '
        'lblAnalisis
        '
        resources.ApplyResources(Me.lblAnalisis, "lblAnalisis")
        Me.lblAnalisis.Name = "lblAnalisis"
        '
        'btnAnalisis
        '
        resources.ApplyResources(Me.btnAnalisis, "btnAnalisis")
        Me.btnAnalisis.Name = "btnAnalisis"
        Me.btnAnalisis.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.btnTratamientos)
        Me.Panel4.Name = "Panel4"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'btnTratamientos
        '
        resources.ApplyResources(Me.btnTratamientos, "btnTratamientos")
        Me.btnTratamientos.Name = "btnTratamientos"
        Me.btnTratamientos.UseVisualStyleBackColor = True
        '
        'frmInicioPaciente
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInicioPaciente"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGestion As Button
    Friend WithEvents lblGestion As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblDiagnosticos As Label
    Friend WithEvents btnDiagnosticos As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAnalisis As Button
    Friend WithEvents lblAnalisis As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTratamientos As Button
End Class
