<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosAuxiliar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosAuxiliar))
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.pBoxFotoAux = New System.Windows.Forms.PictureBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.lblNombre2 = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.lblNombre1 = New System.Windows.Forms.Label()
        Me.lblCedulaTXT = New System.Windows.Forms.Label()
        Me.lblNombre1TXT = New System.Windows.Forms.Label()
        Me.lblNombre2TXT = New System.Windows.Forms.Label()
        Me.lblApellido1TXT = New System.Windows.Forms.Label()
        Me.lblApellido2TXT = New System.Windows.Forms.Label()
        Me.lblCorreoTXT = New System.Windows.Forms.Label()
        Me.lblDireccionTXT = New System.Windows.Forms.Label()
        Me.lblTelefonoTXT = New System.Windows.Forms.Label()
        Me.lblContrasenaTXT = New System.Windows.Forms.Label()
        CType(Me.pBoxFotoAux, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = CType(resources.GetObject("btnEditar.BackgroundImage"), System.Drawing.Image)
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditar.Location = New System.Drawing.Point(924, 193)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(48, 40)
        Me.btnEditar.TabIndex = 231
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.BackgroundImage = CType(resources.GetObject("btnBaja.BackgroundImage"), System.Drawing.Image)
        Me.btnBaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBaja.Location = New System.Drawing.Point(978, 193)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(48, 40)
        Me.btnBaja.TabIndex = 230
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'pBoxFotoAux
        '
        Me.pBoxFotoAux.BackgroundImage = CType(resources.GetObject("pBoxFotoAux.BackgroundImage"), System.Drawing.Image)
        Me.pBoxFotoAux.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pBoxFotoAux.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBoxFotoAux.Location = New System.Drawing.Point(3, 3)
        Me.pBoxFotoAux.Name = "pBoxFotoAux"
        Me.pBoxFotoAux.Size = New System.Drawing.Size(223, 230)
        Me.pBoxFotoAux.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxFotoAux.TabIndex = 286
        Me.pBoxFotoAux.TabStop = False
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(629, 12)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(73, 24)
        Me.lblCorreo.TabIndex = 311
        Me.lblCorreo.Text = "Correo:"
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasena.Location = New System.Drawing.Point(629, 108)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(111, 24)
        Me.lblContrasena.TabIndex = 310
        Me.lblContrasena.Text = "Contraseña:"
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido2.Location = New System.Drawing.Point(243, 140)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(105, 24)
        Me.lblApellido2.TabIndex = 309
        Me.lblApellido2.Text = "2° Apellido:"
        '
        'lblNombre2
        '
        Me.lblNombre2.AutoSize = True
        Me.lblNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre2.Location = New System.Drawing.Point(243, 74)
        Me.lblNombre2.Name = "lblNombre2"
        Me.lblNombre2.Size = New System.Drawing.Size(105, 24)
        Me.lblNombre2.TabIndex = 308
        Me.lblNombre2.Text = "2° Nombre:"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(244, 10)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(75, 24)
        Me.lblCedula.TabIndex = 305
        Me.lblCedula.Text = "Cédula:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(629, 42)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(95, 24)
        Me.lblDireccion.TabIndex = 307
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(629, 75)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(111, 24)
        Me.lblTelefono.TabIndex = 306
        Me.lblTelefono.Text = "Teléfono(s):"
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido1.Location = New System.Drawing.Point(243, 107)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(105, 24)
        Me.lblApellido1.TabIndex = 304
        Me.lblApellido1.Text = "1° Apellido:"
        '
        'lblNombre1
        '
        Me.lblNombre1.AutoSize = True
        Me.lblNombre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre1.Location = New System.Drawing.Point(243, 42)
        Me.lblNombre1.Name = "lblNombre1"
        Me.lblNombre1.Size = New System.Drawing.Size(105, 24)
        Me.lblNombre1.TabIndex = 303
        Me.lblNombre1.Text = "1° Nombre:"
        '
        'lblCedulaTXT
        '
        Me.lblCedulaTXT.AutoSize = True
        Me.lblCedulaTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedulaTXT.Location = New System.Drawing.Point(377, 10)
        Me.lblCedulaTXT.Name = "lblCedulaTXT"
        Me.lblCedulaTXT.Size = New System.Drawing.Size(70, 24)
        Me.lblCedulaTXT.TabIndex = 312
        Me.lblCedulaTXT.Tag = "datos"
        Me.lblCedulaTXT.Text = "Cedula"
        '
        'lblNombre1TXT
        '
        Me.lblNombre1TXT.AutoSize = True
        Me.lblNombre1TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre1TXT.Location = New System.Drawing.Point(377, 42)
        Me.lblNombre1TXT.Name = "lblNombre1TXT"
        Me.lblNombre1TXT.Size = New System.Drawing.Size(100, 24)
        Me.lblNombre1TXT.TabIndex = 313
        Me.lblNombre1TXT.Tag = "datos"
        Me.lblNombre1TXT.Text = "1° Nombre"
        '
        'lblNombre2TXT
        '
        Me.lblNombre2TXT.AutoSize = True
        Me.lblNombre2TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre2TXT.Location = New System.Drawing.Point(377, 74)
        Me.lblNombre2TXT.Name = "lblNombre2TXT"
        Me.lblNombre2TXT.Size = New System.Drawing.Size(100, 24)
        Me.lblNombre2TXT.TabIndex = 314
        Me.lblNombre2TXT.Tag = "datos"
        Me.lblNombre2TXT.Text = "2° Nombre"
        '
        'lblApellido1TXT
        '
        Me.lblApellido1TXT.AutoSize = True
        Me.lblApellido1TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido1TXT.Location = New System.Drawing.Point(377, 108)
        Me.lblApellido1TXT.Name = "lblApellido1TXT"
        Me.lblApellido1TXT.Size = New System.Drawing.Size(100, 24)
        Me.lblApellido1TXT.TabIndex = 315
        Me.lblApellido1TXT.Tag = "datos"
        Me.lblApellido1TXT.Text = "1° Apellido"
        '
        'lblApellido2TXT
        '
        Me.lblApellido2TXT.AutoSize = True
        Me.lblApellido2TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido2TXT.Location = New System.Drawing.Point(377, 140)
        Me.lblApellido2TXT.Name = "lblApellido2TXT"
        Me.lblApellido2TXT.Size = New System.Drawing.Size(100, 24)
        Me.lblApellido2TXT.TabIndex = 316
        Me.lblApellido2TXT.Tag = "datos"
        Me.lblApellido2TXT.Text = "2° Apellido"
        '
        'lblCorreoTXT
        '
        Me.lblCorreoTXT.AutoSize = True
        Me.lblCorreoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreoTXT.Location = New System.Drawing.Point(752, 12)
        Me.lblCorreoTXT.Name = "lblCorreoTXT"
        Me.lblCorreoTXT.Size = New System.Drawing.Size(68, 24)
        Me.lblCorreoTXT.TabIndex = 317
        Me.lblCorreoTXT.Tag = "datos"
        Me.lblCorreoTXT.Text = "Correo"
        '
        'lblDireccionTXT
        '
        Me.lblDireccionTXT.AutoSize = True
        Me.lblDireccionTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionTXT.Location = New System.Drawing.Point(752, 42)
        Me.lblDireccionTXT.Name = "lblDireccionTXT"
        Me.lblDireccionTXT.Size = New System.Drawing.Size(90, 24)
        Me.lblDireccionTXT.TabIndex = 318
        Me.lblDireccionTXT.Tag = "datos"
        Me.lblDireccionTXT.Text = "Dirección"
        '
        'lblTelefonoTXT
        '
        Me.lblTelefonoTXT.AutoSize = True
        Me.lblTelefonoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoTXT.Location = New System.Drawing.Point(752, 75)
        Me.lblTelefonoTXT.Name = "lblTelefonoTXT"
        Me.lblTelefonoTXT.Size = New System.Drawing.Size(106, 24)
        Me.lblTelefonoTXT.TabIndex = 319
        Me.lblTelefonoTXT.Tag = "datos"
        Me.lblTelefonoTXT.Text = "Teléfono(s)"
        '
        'lblContrasenaTXT
        '
        Me.lblContrasenaTXT.AutoSize = True
        Me.lblContrasenaTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasenaTXT.Location = New System.Drawing.Point(752, 107)
        Me.lblContrasenaTXT.Name = "lblContrasenaTXT"
        Me.lblContrasenaTXT.Size = New System.Drawing.Size(106, 24)
        Me.lblContrasenaTXT.TabIndex = 320
        Me.lblContrasenaTXT.Tag = "datos"
        Me.lblContrasenaTXT.Text = "Contraseña"
        '
        'frmDatosAuxiliar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1038, 238)
        Me.Controls.Add(Me.lblContrasenaTXT)
        Me.Controls.Add(Me.lblTelefonoTXT)
        Me.Controls.Add(Me.lblDireccionTXT)
        Me.Controls.Add(Me.lblCorreoTXT)
        Me.Controls.Add(Me.lblApellido2TXT)
        Me.Controls.Add(Me.lblApellido1TXT)
        Me.Controls.Add(Me.lblNombre2TXT)
        Me.Controls.Add(Me.lblNombre1TXT)
        Me.Controls.Add(Me.lblCedulaTXT)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblContrasena)
        Me.Controls.Add(Me.lblApellido2)
        Me.Controls.Add(Me.lblNombre2)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblApellido1)
        Me.Controls.Add(Me.lblNombre1)
        Me.Controls.Add(Me.pBoxFotoAux)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnBaja)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDatosAuxiliar"
        Me.Text = "frmDatosAuxiliar"
        CType(Me.pBoxFotoAux, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBaja As Button
    Friend WithEvents pBoxFotoAux As PictureBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblContrasena As Label
    Friend WithEvents lblApellido2 As Label
    Friend WithEvents lblNombre2 As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblApellido1 As Label
    Friend WithEvents lblNombre1 As Label
    Friend WithEvents lblCedulaTXT As Label
    Friend WithEvents lblNombre1TXT As Label
    Friend WithEvents lblNombre2TXT As Label
    Friend WithEvents lblApellido1TXT As Label
    Friend WithEvents lblApellido2TXT As Label
    Friend WithEvents lblCorreoTXT As Label
    Friend WithEvents lblDireccionTXT As Label
    Friend WithEvents lblTelefonoTXT As Label
    Friend WithEvents lblContrasenaTXT As Label
End Class
