<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalisis
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
        Me.tabPanelDiagnostico = New System.Windows.Forms.TabControl()
        Me.tabDetalles = New System.Windows.Forms.TabPage()
        Me.tabPageResultado = New System.Windows.Forms.TabPage()
        Me.cbAnalisis = New System.Windows.Forms.ComboBox()
        Me.tabPanelDiagnostico.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabPanelDiagnostico
        '
        Me.tabPanelDiagnostico.Controls.Add(Me.tabPageResultado)
        Me.tabPanelDiagnostico.Controls.Add(Me.tabDetalles)
        Me.tabPanelDiagnostico.Location = New System.Drawing.Point(12, 43)
        Me.tabPanelDiagnostico.Name = "tabPanelDiagnostico"
        Me.tabPanelDiagnostico.SelectedIndex = 0
        Me.tabPanelDiagnostico.Size = New System.Drawing.Size(872, 496)
        Me.tabPanelDiagnostico.TabIndex = 4
        '
        'tabDetalles
        '
        Me.tabDetalles.Location = New System.Drawing.Point(4, 25)
        Me.tabDetalles.Name = "tabDetalles"
        Me.tabDetalles.Size = New System.Drawing.Size(864, 467)
        Me.tabDetalles.TabIndex = 2
        Me.tabDetalles.Text = "Detalles"
        Me.tabDetalles.UseVisualStyleBackColor = True
        '
        'tabPageResultado
        '
        Me.tabPageResultado.Location = New System.Drawing.Point(4, 25)
        Me.tabPageResultado.Name = "tabPageResultado"
        Me.tabPageResultado.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageResultado.Size = New System.Drawing.Size(864, 467)
        Me.tabPageResultado.TabIndex = 0
        Me.tabPageResultado.Text = "Resultado"
        Me.tabPageResultado.UseVisualStyleBackColor = True
        '
        'cbAnalisis
        '
        Me.cbAnalisis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAnalisis.FormattingEnabled = True
        Me.cbAnalisis.Location = New System.Drawing.Point(693, 12)
        Me.cbAnalisis.Name = "cbAnalisis"
        Me.cbAnalisis.Size = New System.Drawing.Size(191, 24)
        Me.cbAnalisis.TabIndex = 3
        '
        'frmAnalisis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 551)
        Me.Controls.Add(Me.tabPanelDiagnostico)
        Me.Controls.Add(Me.cbAnalisis)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAnalisis"
        Me.Text = "Analisis"
        Me.tabPanelDiagnostico.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabPanelDiagnostico As TabControl
    Friend WithEvents tabPageResultado As TabPage
    Friend WithEvents tabDetalles As TabPage
    Friend WithEvents cbAnalisis As ComboBox
End Class
