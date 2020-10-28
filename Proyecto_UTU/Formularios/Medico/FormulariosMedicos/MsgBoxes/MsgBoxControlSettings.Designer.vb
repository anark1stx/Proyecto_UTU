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
        Me.cbFuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFuente.FormattingEnabled = True
        Me.cbFuente.Location = New System.Drawing.Point(188, 116)
        Me.cbFuente.Name = "cbFuente"
        Me.cbFuente.Size = New System.Drawing.Size(246, 24)
        Me.cbFuente.TabIndex = 0
        Me.cbFuente.Tag = "noLimpiar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione Fuente"
        '
        'txtIngreseTexto
        '
        Me.txtIngreseTexto.Location = New System.Drawing.Point(12, 288)
        Me.txtIngreseTexto.Multiline = True
        Me.txtIngreseTexto.Name = "txtIngreseTexto"
        Me.txtIngreseTexto.Size = New System.Drawing.Size(697, 61)
        Me.txtIngreseTexto.TabIndex = 4
        '
        'lblEscribaTexto
        '
        Me.lblEscribaTexto.AutoSize = True
        Me.lblEscribaTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEscribaTexto.Location = New System.Drawing.Point(235, 251)
        Me.lblEscribaTexto.Name = "lblEscribaTexto"
        Me.lblEscribaTexto.Size = New System.Drawing.Size(209, 32)
        Me.lblEscribaTexto.TabIndex = 5
        Me.lblEscribaTexto.Text = "Escriba el texto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(122, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(369, 32)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Seleccione Tamaño de letra"
        '
        'cbTamanoLetra
        '
        Me.cbTamanoLetra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTamanoLetra.FormattingEnabled = True
        Me.cbTamanoLetra.Location = New System.Drawing.Point(188, 40)
        Me.cbTamanoLetra.Name = "cbTamanoLetra"
        Me.cbTamanoLetra.Size = New System.Drawing.Size(246, 24)
        Me.cbTamanoLetra.TabIndex = 6
        Me.cbTamanoLetra.Tag = "noLimpiar"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.GreenYellow
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAceptar.Location = New System.Drawing.Point(209, 444)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(246, 44)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(197, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(231, 32)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Seleccione Color"
        '
        'cbColores
        '
        Me.cbColores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbColores.FormattingEnabled = True
        Me.cbColores.Location = New System.Drawing.Point(188, 189)
        Me.cbColores.Name = "cbColores"
        Me.cbColores.Size = New System.Drawing.Size(246, 24)
        Me.cbColores.TabIndex = 10
        Me.cbColores.Tag = "noLimpiar"
        '
        'chkSoyPregunta
        '
        Me.chkSoyPregunta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkSoyPregunta.AutoSize = True
        Me.chkSoyPregunta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSoyPregunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSoyPregunta.Location = New System.Drawing.Point(34, 15)
        Me.chkSoyPregunta.Name = "chkSoyPregunta"
        Me.chkSoyPregunta.Size = New System.Drawing.Size(570, 29)
        Me.chkSoyPregunta.TabIndex = 12
        Me.chkSoyPregunta.Text = "Considerar esto como una pregunta de consulta médica"
        Me.chkSoyPregunta.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbTamanoLetra)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cbColores)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbFuente)
        Me.Panel1.Location = New System.Drawing.Point(25, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 231)
        Me.Panel1.TabIndex = 13
        '
        'pnlSettingsTXT
        '
        Me.pnlSettingsTXT.Controls.Add(Me.chkSoyPregunta)
        Me.pnlSettingsTXT.Location = New System.Drawing.Point(12, 355)
        Me.pnlSettingsTXT.Name = "pnlSettingsTXT"
        Me.pnlSettingsTXT.Size = New System.Drawing.Size(697, 83)
        Me.pnlSettingsTXT.TabIndex = 14
        '
        'MsgBoxControlSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(721, 502)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "MsgBoxControlSettings"
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
