<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCategoriaEnf
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtDescrEnfermedad = New System.Windows.Forms.TextBox()
        Me.txtNomCategoria = New System.Windows.Forms.TextBox()
        Me.lblNomE = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(0, 587)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(1450, 84)
        Me.btnGuardar.TabIndex = 21
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtDescrEnfermedad
        '
        Me.txtDescrEnfermedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrEnfermedad.Location = New System.Drawing.Point(11, 71)
        Me.txtDescrEnfermedad.MaxLength = 16000
        Me.txtDescrEnfermedad.Multiline = True
        Me.txtDescrEnfermedad.Name = "txtDescrEnfermedad"
        Me.txtDescrEnfermedad.Size = New System.Drawing.Size(1435, 409)
        Me.txtDescrEnfermedad.TabIndex = 15
        '
        'txtNomCategoria
        '
        Me.txtNomCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomCategoria.Location = New System.Drawing.Point(524, 3)
        Me.txtNomCategoria.MaxLength = 160
        Me.txtNomCategoria.Name = "txtNomCategoria"
        Me.txtNomCategoria.Size = New System.Drawing.Size(922, 53)
        Me.txtNomCategoria.TabIndex = 14
        '
        'lblNomE
        '
        Me.lblNomE.AutoSize = True
        Me.lblNomE.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomE.Location = New System.Drawing.Point(3, 10)
        Me.lblNomE.Name = "lblNomE"
        Me.lblNomE.Size = New System.Drawing.Size(469, 46)
        Me.lblNomE.TabIndex = 13
        Me.lblNomE.Text = "Nombre de la categoria:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(413, 498)
        Me.TextBox1.MaxLength = 160
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1033, 53)
        Me.TextBox1.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 505)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(406, 46)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Es sub-categoria de:"
        '
        'frmCategoriaEnf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtDescrEnfermedad)
        Me.Controls.Add(Me.txtNomCategoria)
        Me.Controls.Add(Me.lblNomE)
        Me.Name = "frmCategoriaEnf"
        Me.Size = New System.Drawing.Size(1450, 671)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtDescrEnfermedad As TextBox
    Friend WithEvents txtNomCategoria As TextBox
    Friend WithEvents lblNomE As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
