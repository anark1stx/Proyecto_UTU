<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCrearFormulario
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
        Me.pnlControles = New System.Windows.Forms.Panel()
        Me.txtSintoma0 = New System.Windows.Forms.TextBox()
        Me.pnlFormularioPersonalizado = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.pnlControles.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlControles
        '
        Me.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlControles.Controls.Add(Me.CheckBox1)
        Me.pnlControles.Controls.Add(Me.Label1)
        Me.pnlControles.Controls.Add(Me.txtSintoma0)
        Me.pnlControles.Location = New System.Drawing.Point(12, 12)
        Me.pnlControles.Name = "pnlControles"
        Me.pnlControles.Size = New System.Drawing.Size(160, 640)
        Me.pnlControles.TabIndex = 0
        '
        'txtSintoma0
        '
        Me.txtSintoma0.Location = New System.Drawing.Point(27, 58)
        Me.txtSintoma0.Name = "txtSintoma0"
        Me.txtSintoma0.Size = New System.Drawing.Size(100, 22)
        Me.txtSintoma0.TabIndex = 0
        '
        'pnlFormularioPersonalizado
        '
        Me.pnlFormularioPersonalizado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFormularioPersonalizado.Location = New System.Drawing.Point(178, 12)
        Me.pnlFormularioPersonalizado.Name = "pnlFormularioPersonalizado"
        Me.pnlFormularioPersonalizado.Size = New System.Drawing.Size(753, 640)
        Me.pnlFormularioPersonalizado.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Titulo"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(27, 172)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 21)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Check Box"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmCrearFormulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(943, 664)
        Me.Controls.Add(Me.pnlFormularioPersonalizado)
        Me.Controls.Add(Me.pnlControles)
        Me.Name = "frmCrearFormulario"
        Me.Text = "Formulario Personalizado"
        Me.pnlControles.ResumeLayout(False)
        Me.pnlControles.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlControles As Panel
    Friend WithEvents pnlFormularioPersonalizado As Panel
    Friend WithEvents txtSintoma0 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
End Class
