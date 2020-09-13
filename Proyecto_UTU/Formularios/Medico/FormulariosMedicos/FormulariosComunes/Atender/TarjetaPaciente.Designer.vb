<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TarjetaPaciente
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.lblNomAp = New System.Windows.Forms.Label()
        Me.lblCIPaciente = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.pboxFotoPaciente = New System.Windows.Forms.PictureBox()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        CType(Me.pboxFotoPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNomAp
        '
        Me.lblNomAp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomAp.Location = New System.Drawing.Point(247, 3)
        Me.lblNomAp.Name = "lblNomAp"
        Me.lblNomAp.Size = New System.Drawing.Size(880, 29)
        Me.lblNomAp.TabIndex = 1
        Me.lblNomAp.Text = "NOMBRES Y APELLIDOS"
        '
        'lblCIPaciente
        '
        Me.lblCIPaciente.AutoSize = True
        Me.lblCIPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCIPaciente.Location = New System.Drawing.Point(247, 32)
        Me.lblCIPaciente.Name = "lblCIPaciente"
        Me.lblCIPaciente.Size = New System.Drawing.Size(300, 29)
        Me.lblCIPaciente.TabIndex = 2
        Me.lblCIPaciente.Text = "CÉDULA DE IDENTIDAD"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(247, 61)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(85, 29)
        Me.lblSexo.TabIndex = 3
        Me.lblSexo.Text = "SEXO"
        '
        'pboxFotoPaciente
        '
        Me.pboxFotoPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pboxFotoPaciente.Location = New System.Drawing.Point(3, 3)
        Me.pboxFotoPaciente.Name = "pboxFotoPaciente"
        Me.pboxFotoPaciente.Size = New System.Drawing.Size(238, 232)
        Me.pboxFotoPaciente.TabIndex = 0
        Me.pboxFotoPaciente.TabStop = False
        '
        'txtMotivo
        '
        Me.txtMotivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMotivo.Location = New System.Drawing.Point(252, 93)
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(875, 142)
        Me.txtMotivo.TabIndex = 5
        '
        'TarjetaPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblCIPaciente)
        Me.Controls.Add(Me.lblNomAp)
        Me.Controls.Add(Me.pboxFotoPaciente)
        Me.Name = "TarjetaPaciente"
        Me.Size = New System.Drawing.Size(1130, 238)
        CType(Me.pboxFotoPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pboxFotoPaciente As PictureBox
    Friend WithEvents lblNomAp As Label
    Friend WithEvents lblCIPaciente As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents txtMotivo As TextBox
End Class
