﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblNomHospital = New System.Windows.Forms.Label()
        Me.txtIngresarCi = New System.Windows.Forms.TextBox()
        Me.lblIngreseCI = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIngresarContrasena = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.L_lblContrasenaOlvidada = New System.Windows.Forms.LinkLabel()
        Me.lblMensajeErrorCI = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNomHospital
        '
        Me.lblNomHospital.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNomHospital.AutoSize = True
        Me.lblNomHospital.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomHospital.Location = New System.Drawing.Point(293, 9)
        Me.lblNomHospital.Name = "lblNomHospital"
        Me.lblNomHospital.Size = New System.Drawing.Size(284, 36)
        Me.lblNomHospital.TabIndex = 0
        Me.lblNomHospital.Text = "Nombre del Hospital"
        Me.lblNomHospital.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIngresarCi
        '
        Me.txtIngresarCi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtIngresarCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngresarCi.Location = New System.Drawing.Point(278, 136)
        Me.txtIngresarCi.Name = "txtIngresarCi"
        Me.txtIngresarCi.Size = New System.Drawing.Size(332, 30)
        Me.txtIngresarCi.TabIndex = 1
        '
        'lblIngreseCI
        '
        Me.lblIngreseCI.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblIngreseCI.AutoSize = True
        Me.lblIngreseCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseCI.Location = New System.Drawing.Point(294, 108)
        Me.lblIngreseCI.Name = "lblIngreseCI"
        Me.lblIngreseCI.Size = New System.Drawing.Size(277, 25)
        Me.lblIngreseCI.TabIndex = 2
        Me.lblIngreseCI.Text = "Ingrese su cédula de identidad"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(327, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ingrese su contraseña"
        '
        'txtIngresarContrasena
        '
        Me.txtIngresarContrasena.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtIngresarContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngresarContrasena.Location = New System.Drawing.Point(278, 217)
        Me.txtIngresarContrasena.Name = "txtIngresarContrasena"
        Me.txtIngresarContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtIngresarContrasena.Size = New System.Drawing.Size(332, 30)
        Me.txtIngresarContrasena.TabIndex = 3
        '
        'btnIngresar
        '
        Me.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(349, 296)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(166, 48)
        Me.btnIngresar.TabIndex = 5
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'L_lblContrasenaOlvidada
        '
        Me.L_lblContrasenaOlvidada.AutoSize = True
        Me.L_lblContrasenaOlvidada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_lblContrasenaOlvidada.Location = New System.Drawing.Point(459, 250)
        Me.L_lblContrasenaOlvidada.Name = "L_lblContrasenaOlvidada"
        Me.L_lblContrasenaOlvidada.Size = New System.Drawing.Size(151, 18)
        Me.L_lblContrasenaOlvidada.TabIndex = 6
        Me.L_lblContrasenaOlvidada.TabStop = True
        Me.L_lblContrasenaOlvidada.Text = "Olvidé mi contraseña."
        '
        'lblMensajeErrorCI
        '
        Me.lblMensajeErrorCI.AutoSize = True
        Me.lblMensajeErrorCI.ForeColor = System.Drawing.Color.Red
        Me.lblMensajeErrorCI.Location = New System.Drawing.Point(277, 169)
        Me.lblMensajeErrorCI.Name = "lblMensajeErrorCI"
        Me.lblMensajeErrorCI.Size = New System.Drawing.Size(69, 17)
        Me.lblMensajeErrorCI.TabIndex = 7
        Me.lblMensajeErrorCI.Text = "Msg error"
        Me.lblMensajeErrorCI.Visible = False
        '
        'frmIngreso_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 583)
        Me.Controls.Add(Me.lblMensajeErrorCI)
        Me.Controls.Add(Me.L_lblContrasenaOlvidada)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIngresarContrasena)
        Me.Controls.Add(Me.lblIngreseCI)
        Me.Controls.Add(Me.txtIngresarCi)
        Me.Controls.Add(Me.lblNomHospital)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1366, 800)
        Me.MinimumSize = New System.Drawing.Size(660, 380)
        Me.Name = "frmIngreso_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNomHospital As Label
    Friend WithEvents txtIngresarCi As TextBox
    Friend WithEvents lblIngreseCI As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIngresarContrasena As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents L_lblContrasenaOlvidada As LinkLabel
    Friend WithEvents lblMensajeErrorCI As Label
End Class