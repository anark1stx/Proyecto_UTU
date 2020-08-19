<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDatosMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosMedico))
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.lblEspecialidades = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.lblNombre2 = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.lblNombre1 = New System.Windows.Forms.Label()
        Me.pBoxFotoMedico = New System.Windows.Forms.PictureBox()
        Me.lblContrasenaTXT = New System.Windows.Forms.Label()
        Me.lblTelefonoTXT = New System.Windows.Forms.Label()
        Me.lblDireccionTXT = New System.Windows.Forms.Label()
        Me.lblCorreoTXT = New System.Windows.Forms.Label()
        Me.lblApellido2TXT = New System.Windows.Forms.Label()
        Me.lblApellido1TXT = New System.Windows.Forms.Label()
        Me.lblNombre2TXT = New System.Windows.Forms.Label()
        Me.lblNombre1TXT = New System.Windows.Forms.Label()
        Me.lblCedulaTXT = New System.Windows.Forms.Label()
        Me.lblEspecialidadesTXT = New System.Windows.Forms.Label()
        CType(Me.pBoxFotoMedico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = CType(resources.GetObject("btnEditar.BackgroundImage"), System.Drawing.Image)
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditar.Location = New System.Drawing.Point(924, 193)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(48, 40)
        Me.btnEditar.TabIndex = 246
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.BackgroundImage = CType(resources.GetObject("btnBaja.BackgroundImage"), System.Drawing.Image)
        Me.btnBaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBaja.Location = New System.Drawing.Point(978, 193)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(48, 40)
        Me.btnBaja.TabIndex = 245
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'lblEspecialidades
        '
        Me.lblEspecialidades.AutoSize = True
        Me.lblEspecialidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspecialidades.Location = New System.Drawing.Point(627, 76)
        Me.lblEspecialidades.Name = "lblEspecialidades"
        Me.lblEspecialidades.Size = New System.Drawing.Size(155, 24)
        Me.lblEspecialidades.TabIndex = 294
        Me.lblEspecialidades.Text = "Especialidad(es):"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(627, 13)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(73, 24)
        Me.lblCorreo.TabIndex = 293
        Me.lblCorreo.Text = "Correo:"
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasena.Location = New System.Drawing.Point(627, 139)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(111, 24)
        Me.lblContrasena.TabIndex = 292
        Me.lblContrasena.Text = "Contraseña:"
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido2.Location = New System.Drawing.Point(241, 141)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(105, 24)
        Me.lblApellido2.TabIndex = 291
        Me.lblApellido2.Text = "2° Apellido:"
        '
        'lblNombre2
        '
        Me.lblNombre2.AutoSize = True
        Me.lblNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre2.Location = New System.Drawing.Point(241, 75)
        Me.lblNombre2.Name = "lblNombre2"
        Me.lblNombre2.Size = New System.Drawing.Size(105, 24)
        Me.lblNombre2.TabIndex = 290
        Me.lblNombre2.Text = "2° Nombre:"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(242, 11)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(75, 24)
        Me.lblCedula.TabIndex = 287
        Me.lblCedula.Text = "Cédula:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(627, 43)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(95, 24)
        Me.lblDireccion.TabIndex = 289
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(627, 108)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(90, 24)
        Me.lblTelefono.TabIndex = 288
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido1.Location = New System.Drawing.Point(241, 108)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(105, 24)
        Me.lblApellido1.TabIndex = 286
        Me.lblApellido1.Text = "1° Apellido:"
        '
        'lblNombre1
        '
        Me.lblNombre1.AutoSize = True
        Me.lblNombre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre1.Location = New System.Drawing.Point(241, 43)
        Me.lblNombre1.Name = "lblNombre1"
        Me.lblNombre1.Size = New System.Drawing.Size(105, 24)
        Me.lblNombre1.TabIndex = 285
        Me.lblNombre1.Text = "1° Nombre:"
        '
        'pBoxFotoMedico
        '
        Me.pBoxFotoMedico.BackgroundImage = CType(resources.GetObject("pBoxFotoMedico.BackgroundImage"), System.Drawing.Image)
        Me.pBoxFotoMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pBoxFotoMedico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBoxFotoMedico.Location = New System.Drawing.Point(3, 3)
        Me.pBoxFotoMedico.Name = "pBoxFotoMedico"
        Me.pBoxFotoMedico.Size = New System.Drawing.Size(223, 230)
        Me.pBoxFotoMedico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxFotoMedico.TabIndex = 284
        Me.pBoxFotoMedico.TabStop = False
        '
        'lblContrasenaTXT
        '
        Me.lblContrasenaTXT.AutoSize = True
        Me.lblContrasenaTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasenaTXT.Location = New System.Drawing.Point(786, 140)
        Me.lblContrasenaTXT.Name = "lblContrasenaTXT"
        Me.lblContrasenaTXT.Size = New System.Drawing.Size(106, 24)
        Me.lblContrasenaTXT.TabIndex = 329
        Me.lblContrasenaTXT.Text = "Contraseña"
        '
        'lblTelefonoTXT
        '
        Me.lblTelefonoTXT.AutoSize = True
        Me.lblTelefonoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoTXT.Location = New System.Drawing.Point(786, 108)
        Me.lblTelefonoTXT.Name = "lblTelefonoTXT"
        Me.lblTelefonoTXT.Size = New System.Drawing.Size(106, 24)
        Me.lblTelefonoTXT.TabIndex = 328
        Me.lblTelefonoTXT.Text = "Teléfono(s)"
        '
        'lblDireccionTXT
        '
        Me.lblDireccionTXT.AutoSize = True
        Me.lblDireccionTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionTXT.Location = New System.Drawing.Point(786, 43)
        Me.lblDireccionTXT.Name = "lblDireccionTXT"
        Me.lblDireccionTXT.Size = New System.Drawing.Size(90, 24)
        Me.lblDireccionTXT.TabIndex = 327
        Me.lblDireccionTXT.Text = "Dirección"
        '
        'lblCorreoTXT
        '
        Me.lblCorreoTXT.AutoSize = True
        Me.lblCorreoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreoTXT.Location = New System.Drawing.Point(786, 13)
        Me.lblCorreoTXT.Name = "lblCorreoTXT"
        Me.lblCorreoTXT.Size = New System.Drawing.Size(68, 24)
        Me.lblCorreoTXT.TabIndex = 326
        Me.lblCorreoTXT.Text = "Correo"
        '
        'lblApellido2TXT
        '
        Me.lblApellido2TXT.AutoSize = True
        Me.lblApellido2TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido2TXT.Location = New System.Drawing.Point(368, 143)
        Me.lblApellido2TXT.Name = "lblApellido2TXT"
        Me.lblApellido2TXT.Size = New System.Drawing.Size(100, 24)
        Me.lblApellido2TXT.TabIndex = 325
        Me.lblApellido2TXT.Text = "2° Apellido"
        '
        'lblApellido1TXT
        '
        Me.lblApellido1TXT.AutoSize = True
        Me.lblApellido1TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido1TXT.Location = New System.Drawing.Point(368, 111)
        Me.lblApellido1TXT.Name = "lblApellido1TXT"
        Me.lblApellido1TXT.Size = New System.Drawing.Size(100, 24)
        Me.lblApellido1TXT.TabIndex = 324
        Me.lblApellido1TXT.Text = "1° Apellido"
        '
        'lblNombre2TXT
        '
        Me.lblNombre2TXT.AutoSize = True
        Me.lblNombre2TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre2TXT.Location = New System.Drawing.Point(368, 77)
        Me.lblNombre2TXT.Name = "lblNombre2TXT"
        Me.lblNombre2TXT.Size = New System.Drawing.Size(100, 24)
        Me.lblNombre2TXT.TabIndex = 323
        Me.lblNombre2TXT.Text = "2° Nombre"
        '
        'lblNombre1TXT
        '
        Me.lblNombre1TXT.AutoSize = True
        Me.lblNombre1TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre1TXT.Location = New System.Drawing.Point(368, 45)
        Me.lblNombre1TXT.Name = "lblNombre1TXT"
        Me.lblNombre1TXT.Size = New System.Drawing.Size(100, 24)
        Me.lblNombre1TXT.TabIndex = 322
        Me.lblNombre1TXT.Text = "1° Nombre"
        '
        'lblCedulaTXT
        '
        Me.lblCedulaTXT.AutoSize = True
        Me.lblCedulaTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedulaTXT.Location = New System.Drawing.Point(368, 13)
        Me.lblCedulaTXT.Name = "lblCedulaTXT"
        Me.lblCedulaTXT.Size = New System.Drawing.Size(70, 24)
        Me.lblCedulaTXT.TabIndex = 321
        Me.lblCedulaTXT.Text = "Cedula"
        '
        'lblEspecialidadesTXT
        '
        Me.lblEspecialidadesTXT.AutoSize = True
        Me.lblEspecialidadesTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspecialidadesTXT.Location = New System.Drawing.Point(788, 75)
        Me.lblEspecialidadesTXT.Name = "lblEspecialidadesTXT"
        Me.lblEspecialidadesTXT.Size = New System.Drawing.Size(138, 24)
        Me.lblEspecialidadesTXT.TabIndex = 330
        Me.lblEspecialidadesTXT.Text = "Especialidades"
        '
        'frmDatosMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1038, 238)
        Me.Controls.Add(Me.lblEspecialidadesTXT)
        Me.Controls.Add(Me.lblContrasenaTXT)
        Me.Controls.Add(Me.lblTelefonoTXT)
        Me.Controls.Add(Me.lblDireccionTXT)
        Me.Controls.Add(Me.lblCorreoTXT)
        Me.Controls.Add(Me.lblApellido2TXT)
        Me.Controls.Add(Me.lblApellido1TXT)
        Me.Controls.Add(Me.lblNombre2TXT)
        Me.Controls.Add(Me.lblNombre1TXT)
        Me.Controls.Add(Me.lblCedulaTXT)
        Me.Controls.Add(Me.lblEspecialidades)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblContrasena)
        Me.Controls.Add(Me.lblApellido2)
        Me.Controls.Add(Me.lblNombre2)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblApellido1)
        Me.Controls.Add(Me.lblNombre1)
        Me.Controls.Add(Me.pBoxFotoMedico)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnBaja)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDatosMedico"
        Me.Text = "frmDatosMedicos"
        CType(Me.pBoxFotoMedico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBaja As Button
    Friend WithEvents lblEspecialidades As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblContrasena As Label
    Friend WithEvents lblApellido2 As Label
    Friend WithEvents lblNombre2 As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblApellido1 As Label
    Friend WithEvents lblNombre1 As Label
    Friend WithEvents pBoxFotoMedico As PictureBox
    Friend WithEvents lblContrasenaTXT As Label
    Friend WithEvents lblTelefonoTXT As Label
    Friend WithEvents lblDireccionTXT As Label
    Friend WithEvents lblCorreoTXT As Label
    Friend WithEvents lblApellido2TXT As Label
    Friend WithEvents lblApellido1TXT As Label
    Friend WithEvents lblNombre2TXT As Label
    Friend WithEvents lblNombre1TXT As Label
    Friend WithEvents lblCedulaTXT As Label
    Friend WithEvents lblEspecialidadesTXT As Label
End Class
