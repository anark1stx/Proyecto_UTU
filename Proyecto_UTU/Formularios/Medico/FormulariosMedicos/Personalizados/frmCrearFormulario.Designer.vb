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
        Me.cbCombobox = New System.Windows.Forms.ComboBox()
        Me.lbListBox = New System.Windows.Forms.ListBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbTabPage = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnBoton = New System.Windows.Forms.Button()
        Me.pBoxBorrar = New System.Windows.Forms.PictureBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.chkBox = New System.Windows.Forms.CheckBox()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.txtTextBox = New System.Windows.Forms.TextBox()
        Me.pnlFormularioPersonalizado = New System.Windows.Forms.Panel()
        Me.pnlControles.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.pBoxBorrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlControles
        '
        Me.pnlControles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlControles.Controls.Add(Me.cbCombobox)
        Me.pnlControles.Controls.Add(Me.lbListBox)
        Me.pnlControles.Controls.Add(Me.TabControl1)
        Me.pnlControles.Controls.Add(Me.btnBoton)
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
        Me.pnlControles.Size = New System.Drawing.Size(160, 835)
        Me.pnlControles.TabIndex = 0
        '
        'cbCombobox
        '
        Me.cbCombobox.FormattingEnabled = True
        Me.cbCombobox.Location = New System.Drawing.Point(13, 400)
        Me.cbCombobox.Name = "cbCombobox"
        Me.cbCombobox.Size = New System.Drawing.Size(128, 24)
        Me.cbCombobox.TabIndex = 0
        Me.cbCombobox.Text = "Combobox"
        '
        'lbListBox
        '
        Me.lbListBox.FormattingEnabled = True
        Me.lbListBox.ItemHeight = 16
        Me.lbListBox.Items.AddRange(New Object() {"Lista de items"})
        Me.lbListBox.Location = New System.Drawing.Point(13, 341)
        Me.lbListBox.Name = "lbListBox"
        Me.lbListBox.Size = New System.Drawing.Size(128, 36)
        Me.lbListBox.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbTabPage)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 217)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(128, 100)
        Me.TabControl1.TabIndex = 0
        '
        'tbTabPage
        '
        Me.tbTabPage.Location = New System.Drawing.Point(4, 25)
        Me.tbTabPage.Name = "tbTabPage"
        Me.tbTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTabPage.Size = New System.Drawing.Size(120, 71)
        Me.tbTabPage.TabIndex = 0
        Me.tbTabPage.Text = "TabPage"
        Me.tbTabPage.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(120, 71)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnBoton
        '
        Me.btnBoton.Location = New System.Drawing.Point(13, 145)
        Me.btnBoton.Name = "btnBoton"
        Me.btnBoton.Size = New System.Drawing.Size(128, 49)
        Me.btnBoton.TabIndex = 0
        Me.btnBoton.Text = "Botón"
        Me.btnBoton.UseVisualStyleBackColor = True
        '
        'pBoxBorrar
        '
        Me.pBoxBorrar.BackgroundImage = CType(resources.GetObject("pBoxBorrar.BackgroundImage"), System.Drawing.Image)
        Me.pBoxBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pBoxBorrar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pBoxBorrar.Location = New System.Drawing.Point(0, 538)
        Me.pBoxBorrar.Name = "pBoxBorrar"
        Me.pBoxBorrar.Size = New System.Drawing.Size(158, 109)
        Me.pBoxBorrar.TabIndex = 0
        Me.pBoxBorrar.TabStop = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLimpiar.Location = New System.Drawing.Point(0, 647)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(158, 29)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSalir.Location = New System.Drawing.Point(0, 676)
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
        Me.btnAbrir.Location = New System.Drawing.Point(0, 705)
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
        Me.btnGuardar.Location = New System.Drawing.Point(0, 769)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(158, 64)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'chkBox
        '
        Me.chkBox.AutoSize = True
        Me.chkBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBox.Location = New System.Drawing.Point(13, 97)
        Me.chkBox.Name = "chkBox"
        Me.chkBox.Size = New System.Drawing.Size(124, 28)
        Me.chkBox.TabIndex = 0
        Me.chkBox.Text = "Check Box"
        Me.chkBox.UseVisualStyleBackColor = True
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel.Location = New System.Drawing.Point(44, 57)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(56, 24)
        Me.lblLabel.TabIndex = 0
        Me.lblLabel.Text = "Titulo"
        '
        'txtTextBox
        '
        Me.txtTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTextBox.Location = New System.Drawing.Point(13, 14)
        Me.txtTextBox.Name = "txtTextBox"
        Me.txtTextBox.ReadOnly = True
        Me.txtTextBox.Size = New System.Drawing.Size(128, 28)
        Me.txtTextBox.TabIndex = 0
        Me.txtTextBox.Text = "Caja de texto"
        '
        'pnlFormularioPersonalizado
        '
        Me.pnlFormularioPersonalizado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlFormularioPersonalizado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFormularioPersonalizado.Location = New System.Drawing.Point(178, 12)
        Me.pnlFormularioPersonalizado.Name = "pnlFormularioPersonalizado"
        Me.pnlFormularioPersonalizado.Size = New System.Drawing.Size(966, 835)
        Me.pnlFormularioPersonalizado.TabIndex = 1
        '
        'frmCrearFormulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1156, 859)
        Me.Controls.Add(Me.pnlFormularioPersonalizado)
        Me.Controls.Add(Me.pnlControles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCrearFormulario"
        Me.Text = "Formulario Personalizado"
        Me.pnlControles.ResumeLayout(False)
        Me.pnlControles.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
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
    Friend WithEvents btnBoton As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbTabPage As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lbListBox As ListBox
    Friend WithEvents cbCombobox As ComboBox
End Class
