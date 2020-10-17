<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngreso_Usuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngreso_Usuario))
        Me.txtIngresarCi = New System.Windows.Forms.TextBox()
        Me.lblIngreseCI = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIngresarContrasena = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.lblMensajeErrorCI = New System.Windows.Forms.Label()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lblNomHospital = New System.Windows.Forms.Label()
        Me.pnlLogo.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIngresarCi
        '
        Me.txtIngresarCi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIngresarCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngresarCi.Location = New System.Drawing.Point(388, 208)
        Me.txtIngresarCi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIngresarCi.Name = "txtIngresarCi"
        Me.txtIngresarCi.Size = New System.Drawing.Size(359, 45)
        Me.txtIngresarCi.TabIndex = 1
        '
        'lblIngreseCI
        '
        Me.lblIngreseCI.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIngreseCI.AutoSize = True
        Me.lblIngreseCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseCI.Location = New System.Drawing.Point(415, 166)
        Me.lblIngreseCI.Name = "lblIngreseCI"
        Me.lblIngreseCI.Size = New System.Drawing.Size(285, 38)
        Me.lblIngreseCI.TabIndex = 2
        Me.lblIngreseCI.Text = "Ingrese su usuario"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(407, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 36)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ingrese su contraseña"
        '
        'txtIngresarContrasena
        '
        Me.txtIngresarContrasena.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIngresarContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngresarContrasena.Location = New System.Drawing.Point(388, 327)
        Me.txtIngresarContrasena.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIngresarContrasena.Name = "txtIngresarContrasena"
        Me.txtIngresarContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtIngresarContrasena.Size = New System.Drawing.Size(359, 45)
        Me.txtIngresarContrasena.TabIndex = 3
        '
        'btnIngresar
        '
        Me.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(388, 400)
        Me.btnIngresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(357, 98)
        Me.btnIngresar.TabIndex = 5
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'lblMensajeErrorCI
        '
        Me.lblMensajeErrorCI.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMensajeErrorCI.AutoSize = True
        Me.lblMensajeErrorCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajeErrorCI.ForeColor = System.Drawing.Color.Red
        Me.lblMensajeErrorCI.Location = New System.Drawing.Point(384, 256)
        Me.lblMensajeErrorCI.Name = "lblMensajeErrorCI"
        Me.lblMensajeErrorCI.Size = New System.Drawing.Size(294, 24)
        Me.lblMensajeErrorCI.TabIndex = 7
        Me.lblMensajeErrorCI.Text = "Verifique su usuario y contraseña."
        Me.lblMensajeErrorCI.Visible = False
        '
        'pnlLogo
        '
        Me.pnlLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLogo.Controls.Add(Me.pbLogo)
        Me.pnlLogo.Controls.Add(Me.lblNomHospital)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(1131, 96)
        Me.pnlLogo.TabIndex = 8
        '
        'pbLogo
        '
        Me.pbLogo.BackgroundImage = CType(resources.GetObject("pbLogo.BackgroundImage"), System.Drawing.Image)
        Me.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbLogo.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbLogo.Location = New System.Drawing.Point(0, 0)
        Me.pbLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(105, 94)
        Me.pbLogo.TabIndex = 9
        Me.pbLogo.TabStop = False
        '
        'lblNomHospital
        '
        Me.lblNomHospital.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNomHospital.AutoSize = True
        Me.lblNomHospital.Font = New System.Drawing.Font("MS PGothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomHospital.Location = New System.Drawing.Point(293, 21)
        Me.lblNomHospital.Name = "lblNomHospital"
        Me.lblNomHospital.Size = New System.Drawing.Size(531, 60)
        Me.lblNomHospital.TabIndex = 1
        Me.lblNomHospital.Text = "Ingreso de usuarios"
        Me.lblNomHospital.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmIngreso_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1131, 748)
        Me.Controls.Add(Me.pnlLogo)
        Me.Controls.Add(Me.lblMensajeErrorCI)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIngresarContrasena)
        Me.Controls.Add(Me.lblIngreseCI)
        Me.Controls.Add(Me.txtIngresarCi)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1365, 798)
        Me.MinimumSize = New System.Drawing.Size(659, 378)
        Me.Name = "frmIngreso_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de usuarios"
        Me.pnlLogo.ResumeLayout(False)
        Me.pnlLogo.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIngresarCi As TextBox
    Friend WithEvents lblIngreseCI As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIngresarContrasena As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents lblMensajeErrorCI As Label
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents lblNomHospital As Label
End Class
