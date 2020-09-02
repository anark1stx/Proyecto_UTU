<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDiagnosticos
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
        Me.cbDiagnostico = New System.Windows.Forms.ComboBox()
        Me.pnlContenedorFormularios = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'cbDiagnostico
        '
        Me.cbDiagnostico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbDiagnostico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDiagnostico.FormattingEnabled = True
        Me.cbDiagnostico.Items.AddRange(New Object() {"Seleccione un diagnóstico"})
        Me.cbDiagnostico.Location = New System.Drawing.Point(693, 12)
        Me.cbDiagnostico.Name = "cbDiagnostico"
        Me.cbDiagnostico.Size = New System.Drawing.Size(191, 24)
        Me.cbDiagnostico.TabIndex = 1
        '
        'pnlContenedorFormularios
        '
        Me.pnlContenedorFormularios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContenedorFormularios.AutoScroll = True
        Me.pnlContenedorFormularios.Location = New System.Drawing.Point(12, 42)
        Me.pnlContenedorFormularios.Name = "pnlContenedorFormularios"
        Me.pnlContenedorFormularios.Size = New System.Drawing.Size(872, 497)
        Me.pnlContenedorFormularios.TabIndex = 5
        '
        'frmDiagnosticos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 551)
        Me.Controls.Add(Me.pnlContenedorFormularios)
        Me.Controls.Add(Me.cbDiagnostico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDiagnosticos"
        Me.Text = "frmDiagnosticos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbDiagnostico As ComboBox
    Friend WithEvents pnlContenedorFormularios As Panel
End Class
