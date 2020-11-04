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
        Me.btnIngles = New System.Windows.Forms.Button()
        Me.btnEspanol = New System.Windows.Forms.Button()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lblNomHospital = New System.Windows.Forms.Label()
        Me.pnlLogo.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIngresarCi
        '
        resources.ApplyResources(Me.txtIngresarCi, "txtIngresarCi")
        Me.txtIngresarCi.Name = "txtIngresarCi"
        '
        'lblIngreseCI
        '
        resources.ApplyResources(Me.lblIngreseCI, "lblIngreseCI")
        Me.lblIngreseCI.Name = "lblIngreseCI"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txtIngresarContrasena
        '
        resources.ApplyResources(Me.txtIngresarContrasena, "txtIngresarContrasena")
        Me.txtIngresarContrasena.Name = "txtIngresarContrasena"
        '
        'btnIngresar
        '
        resources.ApplyResources(Me.btnIngresar, "btnIngresar")
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'lblMensajeErrorCI
        '
        resources.ApplyResources(Me.lblMensajeErrorCI, "lblMensajeErrorCI")
        Me.lblMensajeErrorCI.ForeColor = System.Drawing.Color.Red
        Me.lblMensajeErrorCI.Name = "lblMensajeErrorCI"
        '
        'pnlLogo
        '
        resources.ApplyResources(Me.pnlLogo, "pnlLogo")
        Me.pnlLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLogo.Controls.Add(Me.btnIngles)
        Me.pnlLogo.Controls.Add(Me.btnEspanol)
        Me.pnlLogo.Controls.Add(Me.pbLogo)
        Me.pnlLogo.Controls.Add(Me.lblNomHospital)
        Me.pnlLogo.Name = "pnlLogo"
        '
        'btnIngles
        '
        resources.ApplyResources(Me.btnIngles, "btnIngles")
        Me.btnIngles.Name = "btnIngles"
        Me.btnIngles.UseVisualStyleBackColor = True
        '
        'btnEspanol
        '
        resources.ApplyResources(Me.btnEspanol, "btnEspanol")
        Me.btnEspanol.Name = "btnEspanol"
        Me.btnEspanol.UseVisualStyleBackColor = True
        '
        'pbLogo
        '
        resources.ApplyResources(Me.pbLogo, "pbLogo")
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.TabStop = False
        '
        'lblNomHospital
        '
        resources.ApplyResources(Me.lblNomHospital, "lblNomHospital")
        Me.lblNomHospital.Name = "lblNomHospital"
        '
        'frmIngreso_Usuario
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.pnlLogo)
        Me.Controls.Add(Me.lblMensajeErrorCI)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIngresarContrasena)
        Me.Controls.Add(Me.lblIngreseCI)
        Me.Controls.Add(Me.txtIngresarCi)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmIngreso_Usuario"
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
    Friend WithEvents btnEspanol As Button
    Friend WithEvents btnIngles As Button
End Class
