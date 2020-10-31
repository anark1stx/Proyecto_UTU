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
        CType(Me.pBoxBorrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlControles
        '
        resources.ApplyResources(Me.pnlControles, "pnlControles")
        Me.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlControles.Controls.Add(Me.cbCombobox)
        Me.pnlControles.Controls.Add(Me.pBoxBorrar)
        Me.pnlControles.Controls.Add(Me.btnLimpiar)
        Me.pnlControles.Controls.Add(Me.btnSalir)
        Me.pnlControles.Controls.Add(Me.btnAbrir)
        Me.pnlControles.Controls.Add(Me.btnGuardar)
        Me.pnlControles.Controls.Add(Me.chkBox)
        Me.pnlControles.Controls.Add(Me.lblLabel)
        Me.pnlControles.Controls.Add(Me.txtTextBox)
        Me.pnlControles.Name = "pnlControles"
        '
        'cbCombobox
        '
        resources.ApplyResources(Me.cbCombobox, "cbCombobox")
        Me.cbCombobox.FormattingEnabled = True
        Me.cbCombobox.Name = "cbCombobox"
        '
        'pBoxBorrar
        '
        resources.ApplyResources(Me.pBoxBorrar, "pBoxBorrar")
        Me.pBoxBorrar.Name = "pBoxBorrar"
        Me.pBoxBorrar.TabStop = False
        '
        'btnLimpiar
        '
        resources.ApplyResources(Me.btnLimpiar, "btnLimpiar")
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        resources.ApplyResources(Me.btnSalir, "btnSalir")
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAbrir
        '
        resources.ApplyResources(Me.btnAbrir, "btnAbrir")
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        resources.ApplyResources(Me.btnGuardar, "btnGuardar")
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'chkBox
        '
        resources.ApplyResources(Me.chkBox, "chkBox")
        Me.chkBox.Name = "chkBox"
        Me.chkBox.UseVisualStyleBackColor = True
        '
        'lblLabel
        '
        resources.ApplyResources(Me.lblLabel, "lblLabel")
        Me.lblLabel.Name = "lblLabel"
        '
        'txtTextBox
        '
        resources.ApplyResources(Me.txtTextBox, "txtTextBox")
        Me.txtTextBox.Name = "txtTextBox"
        Me.txtTextBox.ReadOnly = True
        '
        'pnlFormularioPersonalizado
        '
        resources.ApplyResources(Me.pnlFormularioPersonalizado, "pnlFormularioPersonalizado")
        Me.pnlFormularioPersonalizado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFormularioPersonalizado.Name = "pnlFormularioPersonalizado"
        '
        'frmCrearFormulario
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.pnlFormularioPersonalizado)
        Me.Controls.Add(Me.pnlControles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCrearFormulario"
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
    Friend WithEvents cbCombobox As ComboBox
End Class
