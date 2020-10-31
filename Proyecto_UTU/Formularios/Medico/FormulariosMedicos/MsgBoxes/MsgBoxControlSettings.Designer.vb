<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MsgBoxControlSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MsgBoxControlSettings))
        Me.cbFuente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIngreseTexto = New System.Windows.Forms.TextBox()
        Me.lblEscribaTexto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTamanoLetra = New System.Windows.Forms.ComboBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbColores = New System.Windows.Forms.ComboBox()
        Me.chkSoyPregunta = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlSettingsTXT = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.pnlSettingsTXT.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbFuente
        '
        resources.ApplyResources(Me.cbFuente, "cbFuente")
        Me.cbFuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFuente.FormattingEnabled = True
        Me.cbFuente.Name = "cbFuente"
        Me.cbFuente.Tag = "noLimpiar"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txtIngreseTexto
        '
        resources.ApplyResources(Me.txtIngreseTexto, "txtIngreseTexto")
        Me.txtIngreseTexto.Name = "txtIngreseTexto"
        '
        'lblEscribaTexto
        '
        resources.ApplyResources(Me.lblEscribaTexto, "lblEscribaTexto")
        Me.lblEscribaTexto.Name = "lblEscribaTexto"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'cbTamanoLetra
        '
        resources.ApplyResources(Me.cbTamanoLetra, "cbTamanoLetra")
        Me.cbTamanoLetra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTamanoLetra.FormattingEnabled = True
        Me.cbTamanoLetra.Name = "cbTamanoLetra"
        Me.cbTamanoLetra.Tag = "noLimpiar"
        '
        'btnAceptar
        '
        resources.ApplyResources(Me.btnAceptar, "btnAceptar")
        Me.btnAceptar.BackColor = System.Drawing.Color.GreenYellow
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'cbColores
        '
        resources.ApplyResources(Me.cbColores, "cbColores")
        Me.cbColores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbColores.FormattingEnabled = True
        Me.cbColores.Name = "cbColores"
        Me.cbColores.Tag = "noLimpiar"
        '
        'chkSoyPregunta
        '
        resources.ApplyResources(Me.chkSoyPregunta, "chkSoyPregunta")
        Me.chkSoyPregunta.Name = "chkSoyPregunta"
        Me.chkSoyPregunta.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbTamanoLetra)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cbColores)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbFuente)
        Me.Panel1.Name = "Panel1"
        '
        'pnlSettingsTXT
        '
        resources.ApplyResources(Me.pnlSettingsTXT, "pnlSettingsTXT")
        Me.pnlSettingsTXT.Controls.Add(Me.chkSoyPregunta)
        Me.pnlSettingsTXT.Name = "pnlSettingsTXT"
        '
        'MsgBoxControlSettings
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlSettingsTXT)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblEscribaTexto)
        Me.Controls.Add(Me.txtIngreseTexto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MsgBoxControlSettings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlSettingsTXT.ResumeLayout(False)
        Me.pnlSettingsTXT.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbFuente As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIngreseTexto As TextBox
    Friend WithEvents lblEscribaTexto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbTamanoLetra As ComboBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cbColores As ComboBox
    Friend WithEvents chkSoyPregunta As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlSettingsTXT As Panel
End Class
