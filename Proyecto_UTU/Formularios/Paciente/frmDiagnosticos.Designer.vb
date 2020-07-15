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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbDiagnostico = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(345, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DIAGNOSTICO"
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
        'frmDiagnosticos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 551)
        Me.Controls.Add(Me.cbDiagnostico)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDiagnosticos"
        Me.Text = "frmDiagnosticos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbDiagnostico As ComboBox
End Class
