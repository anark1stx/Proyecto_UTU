<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosPaciente))
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.lblNombre2 = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.lblOcupacion = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.lblNombre1 = New System.Windows.Forms.Label()
        Me.pBoxFotoPaciente = New System.Windows.Forms.PictureBox()
        Me.lblTelefonoTXT = New System.Windows.Forms.Label()
        Me.lblDireccionTXT = New System.Windows.Forms.Label()
        Me.lblCorreoTXT = New System.Windows.Forms.Label()
        Me.lblApellido2TXT = New System.Windows.Forms.Label()
        Me.lblApellido1TXT = New System.Windows.Forms.Label()
        Me.lblNombre2TXT = New System.Windows.Forms.Label()
        Me.lblNombre1TXT = New System.Windows.Forms.Label()
        Me.lblCedulaTXT = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSexoTXT = New System.Windows.Forms.Label()
        Me.lblEstadoCivilTXT = New System.Windows.Forms.Label()
        Me.lblOcupacionTXT = New System.Windows.Forms.Label()
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = CType(resources.GetObject("btnEditar.BackgroundImage"), System.Drawing.Image)
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditar.Location = New System.Drawing.Point(924, 191)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(48, 40)
        Me.btnEditar.TabIndex = 248
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.BackgroundImage = CType(resources.GetObject("btnBaja.BackgroundImage"), System.Drawing.Image)
        Me.btnBaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBaja.Location = New System.Drawing.Point(978, 191)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(48, 40)
        Me.btnBaja.TabIndex = 247
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(672, 8)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(73, 24)
        Me.lblCorreo.TabIndex = 268
        Me.lblCorreo.Text = "Correo:"
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido2.Location = New System.Drawing.Point(242, 139)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(105, 24)
        Me.lblApellido2.TabIndex = 266
        Me.lblApellido2.Text = "2° Apellido:"
        '
        'lblNombre2
        '
        Me.lblNombre2.AutoSize = True
        Me.lblNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre2.Location = New System.Drawing.Point(242, 73)
        Me.lblNombre2.Name = "lblNombre2"
        Me.lblNombre2.Size = New System.Drawing.Size(105, 24)
        Me.lblNombre2.TabIndex = 265
        Me.lblNombre2.Text = "2° Nombre:"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(243, 9)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(75, 24)
        Me.lblCedula.TabIndex = 258
        Me.lblCedula.Text = "Cédula:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(672, 103)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(95, 24)
        Me.lblDireccion.TabIndex = 264
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCivil.Location = New System.Drawing.Point(672, 41)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(109, 24)
        Me.lblEstadoCivil.TabIndex = 263
        Me.lblEstadoCivil.Text = "Estado civíl:"
        '
        'lblOcupacion
        '
        Me.lblOcupacion.AutoSize = True
        Me.lblOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacion.Location = New System.Drawing.Point(672, 73)
        Me.lblOcupacion.Name = "lblOcupacion"
        Me.lblOcupacion.Size = New System.Drawing.Size(108, 24)
        Me.lblOcupacion.TabIndex = 262
        Me.lblOcupacion.Text = "Ocupación:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(243, 207)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(59, 24)
        Me.lblSexo.TabIndex = 261
        Me.lblSexo.Text = "Sexo:"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(243, 173)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(108, 24)
        Me.lblEdad.TabIndex = 260
        Me.lblEdad.Text = "Fecha Nac."
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(672, 134)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(90, 24)
        Me.lblTelefono.TabIndex = 259
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido1.Location = New System.Drawing.Point(242, 106)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(105, 24)
        Me.lblApellido1.TabIndex = 257
        Me.lblApellido1.Text = "1° Apellido:"
        '
        'lblNombre1
        '
        Me.lblNombre1.AutoSize = True
        Me.lblNombre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre1.Location = New System.Drawing.Point(242, 41)
        Me.lblNombre1.Name = "lblNombre1"
        Me.lblNombre1.Size = New System.Drawing.Size(105, 24)
        Me.lblNombre1.TabIndex = 256
        Me.lblNombre1.Text = "1° Nombre:"
        '
        'pBoxFotoPaciente
        '
        Me.pBoxFotoPaciente.BackgroundImage = CType(resources.GetObject("pBoxFotoPaciente.BackgroundImage"), System.Drawing.Image)
        Me.pBoxFotoPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pBoxFotoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBoxFotoPaciente.Location = New System.Drawing.Point(3, 3)
        Me.pBoxFotoPaciente.Name = "pBoxFotoPaciente"
        Me.pBoxFotoPaciente.Size = New System.Drawing.Size(223, 230)
        Me.pBoxFotoPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxFotoPaciente.TabIndex = 255
        Me.pBoxFotoPaciente.TabStop = False
        '
        'lblTelefonoTXT
        '
        Me.lblTelefonoTXT.AutoSize = True
        Me.lblTelefonoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoTXT.Location = New System.Drawing.Point(821, 134)
        Me.lblTelefonoTXT.Name = "lblTelefonoTXT"
        Me.lblTelefonoTXT.Size = New System.Drawing.Size(106, 24)
        Me.lblTelefonoTXT.TabIndex = 328
        Me.lblTelefonoTXT.Text = "Teléfono(s)"
        '
        'lblDireccionTXT
        '
        Me.lblDireccionTXT.AutoSize = True
        Me.lblDireccionTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionTXT.Location = New System.Drawing.Point(821, 103)
        Me.lblDireccionTXT.Name = "lblDireccionTXT"
        Me.lblDireccionTXT.Size = New System.Drawing.Size(90, 24)
        Me.lblDireccionTXT.TabIndex = 327
        Me.lblDireccionTXT.Text = "Dirección"
        '
        'lblCorreoTXT
        '
        Me.lblCorreoTXT.AutoSize = True
        Me.lblCorreoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreoTXT.Location = New System.Drawing.Point(821, 9)
        Me.lblCorreoTXT.Name = "lblCorreoTXT"
        Me.lblCorreoTXT.Size = New System.Drawing.Size(68, 24)
        Me.lblCorreoTXT.TabIndex = 326
        Me.lblCorreoTXT.Text = "Correo"
        '
        'lblApellido2TXT
        '
        Me.lblApellido2TXT.AutoSize = True
        Me.lblApellido2TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido2TXT.Location = New System.Drawing.Point(375, 139)
        Me.lblApellido2TXT.Name = "lblApellido2TXT"
        Me.lblApellido2TXT.Size = New System.Drawing.Size(100, 24)
        Me.lblApellido2TXT.TabIndex = 325
        Me.lblApellido2TXT.Text = "2° Apellido"
        '
        'lblApellido1TXT
        '
        Me.lblApellido1TXT.AutoSize = True
        Me.lblApellido1TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido1TXT.Location = New System.Drawing.Point(375, 107)
        Me.lblApellido1TXT.Name = "lblApellido1TXT"
        Me.lblApellido1TXT.Size = New System.Drawing.Size(100, 24)
        Me.lblApellido1TXT.TabIndex = 324
        Me.lblApellido1TXT.Text = "1° Apellido"
        '
        'lblNombre2TXT
        '
        Me.lblNombre2TXT.AutoSize = True
        Me.lblNombre2TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre2TXT.Location = New System.Drawing.Point(375, 73)
        Me.lblNombre2TXT.Name = "lblNombre2TXT"
        Me.lblNombre2TXT.Size = New System.Drawing.Size(100, 24)
        Me.lblNombre2TXT.TabIndex = 323
        Me.lblNombre2TXT.Text = "2° Nombre"
        '
        'lblNombre1TXT
        '
        Me.lblNombre1TXT.AutoSize = True
        Me.lblNombre1TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre1TXT.Location = New System.Drawing.Point(375, 41)
        Me.lblNombre1TXT.Name = "lblNombre1TXT"
        Me.lblNombre1TXT.Size = New System.Drawing.Size(100, 24)
        Me.lblNombre1TXT.TabIndex = 322
        Me.lblNombre1TXT.Text = "1° Nombre"
        '
        'lblCedulaTXT
        '
        Me.lblCedulaTXT.AutoSize = True
        Me.lblCedulaTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedulaTXT.Location = New System.Drawing.Point(375, 9)
        Me.lblCedulaTXT.Name = "lblCedulaTXT"
        Me.lblCedulaTXT.Size = New System.Drawing.Size(70, 24)
        Me.lblCedulaTXT.TabIndex = 321
        Me.lblCedulaTXT.Text = "Cedula"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(375, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 24)
        Me.Label1.TabIndex = 329
        Me.Label1.Text = "Fecha Nacimiento"
        '
        'lblSexoTXT
        '
        Me.lblSexoTXT.AutoSize = True
        Me.lblSexoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexoTXT.Location = New System.Drawing.Point(375, 205)
        Me.lblSexoTXT.Name = "lblSexoTXT"
        Me.lblSexoTXT.Size = New System.Drawing.Size(54, 24)
        Me.lblSexoTXT.TabIndex = 330
        Me.lblSexoTXT.Text = "Sexo"
        '
        'lblEstadoCivilTXT
        '
        Me.lblEstadoCivilTXT.AutoSize = True
        Me.lblEstadoCivilTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCivilTXT.Location = New System.Drawing.Point(821, 41)
        Me.lblEstadoCivilTXT.Name = "lblEstadoCivilTXT"
        Me.lblEstadoCivilTXT.Size = New System.Drawing.Size(107, 24)
        Me.lblEstadoCivilTXT.TabIndex = 331
        Me.lblEstadoCivilTXT.Text = "Estado Civil"
        '
        'lblOcupacionTXT
        '
        Me.lblOcupacionTXT.AutoSize = True
        Me.lblOcupacionTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacionTXT.Location = New System.Drawing.Point(821, 73)
        Me.lblOcupacionTXT.Name = "lblOcupacionTXT"
        Me.lblOcupacionTXT.Size = New System.Drawing.Size(103, 24)
        Me.lblOcupacionTXT.TabIndex = 332
        Me.lblOcupacionTXT.Text = "Ocupacion"
        '
        'frmDatosPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1038, 238)
        Me.Controls.Add(Me.lblOcupacionTXT)
        Me.Controls.Add(Me.lblEstadoCivilTXT)
        Me.Controls.Add(Me.lblSexoTXT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTelefonoTXT)
        Me.Controls.Add(Me.lblDireccionTXT)
        Me.Controls.Add(Me.lblCorreoTXT)
        Me.Controls.Add(Me.lblApellido2TXT)
        Me.Controls.Add(Me.lblApellido1TXT)
        Me.Controls.Add(Me.lblNombre2TXT)
        Me.Controls.Add(Me.lblNombre1TXT)
        Me.Controls.Add(Me.lblCedulaTXT)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblApellido2)
        Me.Controls.Add(Me.lblNombre2)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblEstadoCivil)
        Me.Controls.Add(Me.lblOcupacion)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblApellido1)
        Me.Controls.Add(Me.lblNombre1)
        Me.Controls.Add(Me.pBoxFotoPaciente)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnBaja)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDatosPaciente"
        Me.Text = "frmDatosPaciente"
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBaja As Button
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblApellido2 As Label
    Friend WithEvents lblNombre2 As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblEstadoCivil As Label
    Friend WithEvents lblOcupacion As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblEdad As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblApellido1 As Label
    Friend WithEvents lblNombre1 As Label
    Friend WithEvents pBoxFotoPaciente As PictureBox
    Friend WithEvents lblTelefonoTXT As Label
    Friend WithEvents lblDireccionTXT As Label
    Friend WithEvents lblCorreoTXT As Label
    Friend WithEvents lblApellido2TXT As Label
    Friend WithEvents lblApellido1TXT As Label
    Friend WithEvents lblNombre2TXT As Label
    Friend WithEvents lblNombre1TXT As Label
    Friend WithEvents lblCedulaTXT As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSexoTXT As Label
    Friend WithEvents lblEstadoCivilTXT As Label
    Friend WithEvents lblOcupacionTXT As Label
End Class
