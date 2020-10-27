<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarCategorias
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarCategorias))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomCat = New System.Windows.Forms.TextBox()
        Me.lbCategorias = New System.Windows.Forms.ListBox()
        Me.btnAgregarCategoria = New System.Windows.Forms.Button()
        Me.btnSacarCategoria = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de la categoria:"
        '
        'txtNomCat
        '
        Me.txtNomCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomCat.Location = New System.Drawing.Point(358, 12)
        Me.txtNomCat.Name = "txtNomCat"
        Me.txtNomCat.Size = New System.Drawing.Size(324, 34)
        Me.txtNomCat.TabIndex = 1
        '
        'lbCategorias
        '
        Me.lbCategorias.FormattingEnabled = True
        Me.lbCategorias.ItemHeight = 16
        Me.lbCategorias.Location = New System.Drawing.Point(18, 76)
        Me.lbCategorias.Name = "lbCategorias"
        Me.lbCategorias.Size = New System.Drawing.Size(770, 308)
        Me.lbCategorias.TabIndex = 2
        '
        'btnAgregarCategoria
        '
        Me.btnAgregarCategoria.BackgroundImage = CType(resources.GetObject("btnAgregarCategoria.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarCategoria.Location = New System.Drawing.Point(688, 12)
        Me.btnAgregarCategoria.Name = "btnAgregarCategoria"
        Me.btnAgregarCategoria.Size = New System.Drawing.Size(47, 34)
        Me.btnAgregarCategoria.TabIndex = 3
        Me.btnAgregarCategoria.UseVisualStyleBackColor = True
        '
        'btnSacarCategoria
        '
        Me.btnSacarCategoria.BackgroundImage = CType(resources.GetObject("btnSacarCategoria.BackgroundImage"), System.Drawing.Image)
        Me.btnSacarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSacarCategoria.Location = New System.Drawing.Point(741, 12)
        Me.btnSacarCategoria.Name = "btnSacarCategoria"
        Me.btnSacarCategoria.Size = New System.Drawing.Size(47, 34)
        Me.btnSacarCategoria.TabIndex = 4
        Me.btnSacarCategoria.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(18, 390)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(770, 48)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "GUARDAR"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'frmAgregarCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 442)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnSacarCategoria)
        Me.Controls.Add(Me.btnAgregarCategoria)
        Me.Controls.Add(Me.lbCategorias)
        Me.Controls.Add(Me.txtNomCat)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAgregarCategorias"
        Me.Text = "Definir categorias de enfermedad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNomCat As TextBox
    Friend WithEvents lbCategorias As ListBox
    Friend WithEvents btnAgregarCategoria As Button
    Friend WithEvents btnSacarCategoria As Button
    Friend WithEvents btnAceptar As Button
End Class
