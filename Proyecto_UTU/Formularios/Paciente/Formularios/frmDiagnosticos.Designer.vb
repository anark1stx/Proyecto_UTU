<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiagnosticos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbDiagnostico = New System.Windows.Forms.ComboBox()
        Me.tabPanelDiagnostico = New System.Windows.Forms.TabControl()
        Me.tabPageSintomas = New System.Windows.Forms.TabPage()
        Me.tabPageConstantesVitales = New System.Windows.Forms.TabPage()
        Me.tabPageDiagnostico = New System.Windows.Forms.TabPage()
        Me.tabPageTratamiento = New System.Windows.Forms.TabPage()
        Me.tabPanelDiagnostico.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbDiagnostico
        '
        Me.cbDiagnostico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDiagnostico.FormattingEnabled = True
        Me.cbDiagnostico.Location = New System.Drawing.Point(693, 12)
        Me.cbDiagnostico.Name = "cbDiagnostico"
        Me.cbDiagnostico.Size = New System.Drawing.Size(191, 24)
        Me.cbDiagnostico.TabIndex = 1
        '
        'tabPanelDiagnostico
        '
        Me.tabPanelDiagnostico.Controls.Add(Me.tabPageDiagnostico)
        Me.tabPanelDiagnostico.Controls.Add(Me.tabPageSintomas)
        Me.tabPanelDiagnostico.Controls.Add(Me.tabPageConstantesVitales)
        Me.tabPanelDiagnostico.Controls.Add(Me.tabPageTratamiento)
        Me.tabPanelDiagnostico.Location = New System.Drawing.Point(12, 43)
        Me.tabPanelDiagnostico.Name = "tabPanelDiagnostico"
        Me.tabPanelDiagnostico.SelectedIndex = 0
        Me.tabPanelDiagnostico.Size = New System.Drawing.Size(872, 496)
        Me.tabPanelDiagnostico.TabIndex = 2
        '
        'tabPageSintomas
        '
        Me.tabPageSintomas.Location = New System.Drawing.Point(4, 25)
        Me.tabPageSintomas.Name = "tabPageSintomas"
        Me.tabPageSintomas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageSintomas.Size = New System.Drawing.Size(864, 467)
        Me.tabPageSintomas.TabIndex = 0
        Me.tabPageSintomas.Text = "Síntomas"
        Me.tabPageSintomas.UseVisualStyleBackColor = True
        '
        'tabPageConstantesVitales
        '
        Me.tabPageConstantesVitales.Location = New System.Drawing.Point(4, 25)
        Me.tabPageConstantesVitales.Name = "tabPageConstantesVitales"
        Me.tabPageConstantesVitales.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageConstantesVitales.Size = New System.Drawing.Size(864, 467)
        Me.tabPageConstantesVitales.TabIndex = 1
        Me.tabPageConstantesVitales.Text = "Constantes Vitales"
        Me.tabPageConstantesVitales.UseVisualStyleBackColor = True
        '
        'tabPageDiagnostico
        '
        Me.tabPageDiagnostico.Location = New System.Drawing.Point(4, 25)
        Me.tabPageDiagnostico.Name = "tabPageDiagnostico"
        Me.tabPageDiagnostico.Size = New System.Drawing.Size(864, 467)
        Me.tabPageDiagnostico.TabIndex = 2
        Me.tabPageDiagnostico.Text = "Diagnóstico"
        Me.tabPageDiagnostico.UseVisualStyleBackColor = True
        '
        'tabPageTratamiento
        '
        Me.tabPageTratamiento.Location = New System.Drawing.Point(4, 25)
        Me.tabPageTratamiento.Name = "tabPageTratamiento"
        Me.tabPageTratamiento.Size = New System.Drawing.Size(864, 467)
        Me.tabPageTratamiento.TabIndex = 3
        Me.tabPageTratamiento.Text = "Plan de tratamiento"
        Me.tabPageTratamiento.UseVisualStyleBackColor = True
        '
        'frmDiagnosticos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 551)
        Me.Controls.Add(Me.tabPanelDiagnostico)
        Me.Controls.Add(Me.cbDiagnostico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDiagnosticos"
        Me.Text = "frmDiagnosticos"
        Me.tabPanelDiagnostico.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbDiagnostico As ComboBox
    Friend WithEvents tabPanelDiagnostico As TabControl
    Friend WithEvents tabPageDiagnostico As TabPage
    Friend WithEvents tabPageSintomas As TabPage
    Friend WithEvents tabPageConstantesVitales As TabPage
    Friend WithEvents tabPageTratamiento As TabPage
End Class
