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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.chkBox = New System.Windows.Forms.CheckBox()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.txtTextBox = New System.Windows.Forms.TextBox()
        Me.pnlFormularioPersonalizado = New System.Windows.Forms.Panel()
        Me.pBoxBorrar = New System.Windows.Forms.PictureBox()
        Me.pnlControles.SuspendLayout()
        CType(Me.pBoxBorrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlControles
        '
        Me.pnlControles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlControles.Controls.Add(Me.pBoxBorrar)
        Me.pnlControles.Controls.Add(Me.btnLimpiar)
        Me.pnlControles.Controls.Add(Me.btnSalir)
        Me.pnlControles.Controls.Add(Me.btnAbrir)
        Me.pnlControles.Controls.Add(Me.btnGuardar)
        Me.pnlControles.Controls.Add(Me.chkBox)
        Me.pnlControles.Controls.Add(Me.lblLabel)
        Me.pnlControles.Controls.Add(Me.txtTextBox)
        Me.pnlControles.Location = New System.Drawing.Point(12, 12)
        Me.pnlControles.Name = "pnlControles"
        Me.pnlControles.Size = New System.Drawing.Size(160, 640)
        Me.pnlControles.TabIndex = 0
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLimpiar.Location = New System.Drawing.Point(0, 452)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(158, 29)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSalir.Location = New System.Drawing.Point(0, 481)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(158, 29)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAbrir
        '
        Me.btnAbrir.BackgroundImage = CType(resources.GetObject("btnAbrir.BackgroundImage"), System.Drawing.Image)
        Me.btnAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAbrir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnAbrir.Location = New System.Drawing.Point(0, 510)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(158, 64)
        Me.btnAbrir.TabIndex = 1
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnGuardar.Location = New System.Drawing.Point(0, 574)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(158, 64)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'chkBox
        '
        Me.chkBox.AutoSize = True
        Me.chkBox.Location = New System.Drawing.Point(27, 172)
        Me.chkBox.Name = "chkBox"
        Me.chkBox.Size = New System.Drawing.Size(96, 21)
        Me.chkBox.TabIndex = 0
        Me.chkBox.Text = "Check Box"
        Me.chkBox.UseVisualStyleBackColor = True
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
        'txtTextBox
        '
        Me.txtTextBox.Location = New System.Drawing.Point(27, 58)
        Me.txtTextBox.Name = "txtTextBox"
        Me.txtTextBox.ReadOnly = True
        Me.txtTextBox.Size = New System.Drawing.Size(100, 22)
        Me.txtTextBox.TabIndex = 0
        '
        'pnlFormularioPersonalizado
        '
        Me.pnlFormularioPersonalizado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlFormularioPersonalizado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFormularioPersonalizado.Location = New System.Drawing.Point(178, 12)
        Me.pnlFormularioPersonalizado.Name = "pnlFormularioPersonalizado"
        Me.pnlFormularioPersonalizado.Size = New System.Drawing.Size(753, 640)
        Me.pnlFormularioPersonalizado.TabIndex = 1
        '
        'pBoxBorrar
        '
        Me.pBoxBorrar.BackgroundImage = CType(resources.GetObject("pBoxBorrar.BackgroundImage"), System.Drawing.Image)
        Me.pBoxBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pBoxBorrar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pBoxBorrar.Location = New System.Drawing.Point(0, 343)
        Me.pBoxBorrar.Name = "pBoxBorrar"
        Me.pBoxBorrar.Size = New System.Drawing.Size(158, 109)
        Me.pBoxBorrar.TabIndex = 0
        Me.pBoxBorrar.TabStop = False
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
        CType(Me.pBoxBorrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlControles As Panel
    Friend WithEvents pnlFormularioPersonalizado As Panel
    Friend WithEvents txtTextBox As TextBox
    Friend WithEvents chkBox As CheckBox
    Friend WithEvents lblLabel As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnAbrir As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents pBoxBorrar As PictureBox
End Class
