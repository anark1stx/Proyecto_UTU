<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAnalisis
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
        Me.cbAnalisis = New System.Windows.Forms.ComboBox()
        Me.pnlContenedorAnalisis = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'cbAnalisis
        '
        Me.cbAnalisis.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAnalisis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAnalisis.FormattingEnabled = True
        Me.cbAnalisis.Items.AddRange(New Object() {"Seleccione un análisis"})
        Me.cbAnalisis.Location = New System.Drawing.Point(12, 12)
        Me.cbAnalisis.Name = "cbAnalisis"
        Me.cbAnalisis.Size = New System.Drawing.Size(872, 24)
        Me.cbAnalisis.TabIndex = 3
        '
        'pnlContenedorAnalisis
        '
        Me.pnlContenedorAnalisis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContenedorAnalisis.AutoScroll = True
        Me.pnlContenedorAnalisis.Location = New System.Drawing.Point(12, 42)
        Me.pnlContenedorAnalisis.Name = "pnlContenedorAnalisis"
        Me.pnlContenedorAnalisis.Size = New System.Drawing.Size(872, 497)
        Me.pnlContenedorAnalisis.TabIndex = 4
        '
        'frmAnalisis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 551)
        Me.Controls.Add(Me.pnlContenedorAnalisis)
        Me.Controls.Add(Me.cbAnalisis)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAnalisis"
        Me.Text = "Analisis"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbAnalisis As ComboBox
    Friend WithEvents pnlContenedorAnalisis As Panel
End Class
