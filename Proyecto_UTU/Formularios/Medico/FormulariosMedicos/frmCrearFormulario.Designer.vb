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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrearFormulario))
        Me.pnlControles = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.txtSintoma0 = New System.Windows.Forms.TextBox()
        Me.pnlFormularioPersonalizado = New System.Windows.Forms.Panel()
        Me.pnlControles.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlControles
        '
        Me.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlControles.Controls.Add(Me.btnSalir)
        Me.pnlControles.Controls.Add(Me.Button1)
        Me.pnlControles.Controls.Add(Me.btnGuardar)
        Me.pnlControles.Controls.Add(Me.CheckBox1)
        Me.pnlControles.Controls.Add(Me.lblLabel)
        Me.pnlControles.Controls.Add(Me.txtSintoma0)
        Me.pnlControles.Location = New System.Drawing.Point(12, 12)
        Me.pnlControles.Name = "pnlControles"
        Me.pnlControles.Size = New System.Drawing.Size(160, 640)
        Me.pnlControles.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(3, 606)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(152, 29)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(85, 536)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 64)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.Location = New System.Drawing.Point(3, 536)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(70, 64)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.UseVisualStyleBackColor = True
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
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.Location = New System.Drawing.Point(49, 118)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(43, 17)
        Me.lblLabel.TabIndex = 0
        Me.lblLabel.Text = "Titulo"
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
    Friend WithEvents lblLabel As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSalir As Button
End Class
