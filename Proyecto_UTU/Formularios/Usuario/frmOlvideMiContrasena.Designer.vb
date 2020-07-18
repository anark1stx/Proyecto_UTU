<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOlvideMiContrasena
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
        Me.btnReestablecerPWD = New System.Windows.Forms.Button()
        Me.lblIngreseCI = New System.Windows.Forms.Label()
        Me.txtIngresarCi = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReestablecerPWD
        '
        Me.btnReestablecerPWD.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnReestablecerPWD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReestablecerPWD.Location = New System.Drawing.Point(26, 118)
        Me.btnReestablecerPWD.Name = "btnReestablecerPWD"
        Me.btnReestablecerPWD.Size = New System.Drawing.Size(142, 55)
        Me.btnReestablecerPWD.TabIndex = 8
        Me.btnReestablecerPWD.Text = "Reestablecer Contraseña"
        Me.btnReestablecerPWD.UseVisualStyleBackColor = True
        '
        'lblIngreseCI
        '
        Me.lblIngreseCI.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblIngreseCI.AutoSize = True
        Me.lblIngreseCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseCI.Location = New System.Drawing.Point(50, 44)
        Me.lblIngreseCI.Name = "lblIngreseCI"
        Me.lblIngreseCI.Size = New System.Drawing.Size(277, 25)
        Me.lblIngreseCI.TabIndex = 7
        Me.lblIngreseCI.Text = "Ingrese su cédula de identidad"
        '
        'txtIngresarCi
        '
        Me.txtIngresarCi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtIngresarCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngresarCi.Location = New System.Drawing.Point(26, 72)
        Me.txtIngresarCi.Name = "txtIngresarCi"
        Me.txtIngresarCi.Size = New System.Drawing.Size(332, 30)
        Me.txtIngresarCi.TabIndex = 6
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(216, 118)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(142, 55)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmOlvideMiContrasena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 244)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnReestablecerPWD)
        Me.Controls.Add(Me.lblIngreseCI)
        Me.Controls.Add(Me.txtIngresarCi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmOlvideMiContrasena"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReestablecerPWD As Button
    Friend WithEvents lblIngreseCI As Label
    Friend WithEvents txtIngresarCi As TextBox
    Friend WithEvents btnSalir As Button
End Class
