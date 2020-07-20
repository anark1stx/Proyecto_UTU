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
        Me.lblCorreoTitulo = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblCedulaTitulo = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblDireccionTitulo = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pBoxFotoPaciente = New System.Windows.Forms.PictureBox()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombre2Titulo = New System.Windows.Forms.Label()
        Me.lblApellido2Titulo = New System.Windows.Forms.Label()
        Me.lblNombre1Titulo = New System.Windows.Forms.Label()
        Me.lblNombre2 = New System.Windows.Forms.Label()
        Me.lblNombre1 = New System.Windows.Forms.Label()
        Me.lblEspecialidadTitulo = New System.Windows.Forms.Label()
        Me.lblEspecialidad = New System.Windows.Forms.Label()
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = CType(resources.GetObject("btnEditar.BackgroundImage"), System.Drawing.Image)
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditar.Location = New System.Drawing.Point(915, 149)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(48, 40)
        Me.btnEditar.TabIndex = 246
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.BackgroundImage = CType(resources.GetObject("btnBaja.BackgroundImage"), System.Drawing.Image)
        Me.btnBaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBaja.Location = New System.Drawing.Point(969, 149)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(48, 40)
        Me.btnBaja.TabIndex = 245
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'lblCorreoTitulo
        '
        Me.lblCorreoTitulo.AutoSize = True
        Me.lblCorreoTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreoTitulo.Location = New System.Drawing.Point(671, 77)
        Me.lblCorreoTitulo.Name = "lblCorreoTitulo"
        Me.lblCorreoTitulo.Size = New System.Drawing.Size(65, 20)
        Me.lblCorreoTitulo.TabIndex = 244
        Me.lblCorreoTitulo.Text = "Correo:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(802, 77)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(60, 20)
        Me.lblCorreo.TabIndex = 243
        Me.lblCorreo.Text = "Correo"
        '
        'lblCedulaTitulo
        '
        Me.lblCedulaTitulo.AutoSize = True
        Me.lblCedulaTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedulaTitulo.Location = New System.Drawing.Point(244, 12)
        Me.lblCedulaTitulo.Name = "lblCedulaTitulo"
        Me.lblCedulaTitulo.Size = New System.Drawing.Size(66, 20)
        Me.lblCedulaTitulo.TabIndex = 237
        Me.lblCedulaTitulo.Text = "Cédula:"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(373, 12)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(78, 20)
        Me.lblCedula.TabIndex = 242
        Me.lblCedula.Text = "CÉDULA"
        '
        'lblDireccionTitulo
        '
        Me.lblDireccionTitulo.AutoSize = True
        Me.lblDireccionTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionTitulo.Location = New System.Drawing.Point(671, 12)
        Me.lblDireccionTitulo.Name = "lblDireccionTitulo"
        Me.lblDireccionTitulo.Size = New System.Drawing.Size(86, 20)
        Me.lblDireccionTitulo.TabIndex = 241
        Me.lblDireccionTitulo.Text = "Dirección:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(802, 12)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(81, 20)
        Me.lblDireccion.TabIndex = 240
        Me.lblDireccion.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(671, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 239
        Me.Label5.Text = "Teléfono:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(802, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 20)
        Me.Label6.TabIndex = 238
        Me.Label6.Text = "TELEFONO1"
        '
        'pBoxFotoPaciente
        '
        Me.pBoxFotoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBoxFotoPaciente.Image = CType(resources.GetObject("pBoxFotoPaciente.Image"), System.Drawing.Image)
        Me.pBoxFotoPaciente.Location = New System.Drawing.Point(12, 12)
        Me.pBoxFotoPaciente.Name = "pBoxFotoPaciente"
        Me.pBoxFotoPaciente.Size = New System.Drawing.Size(189, 177)
        Me.pBoxFotoPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxFotoPaciente.TabIndex = 232
        Me.pBoxFotoPaciente.TabStop = False
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido2.Location = New System.Drawing.Point(373, 145)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(99, 20)
        Me.lblApellido2.TabIndex = 254
        Me.lblApellido2.Text = "lblApellido 2"
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido1.Location = New System.Drawing.Point(373, 111)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(82, 20)
        Me.lblApellido1.TabIndex = 253
        Me.lblApellido1.Text = "Apellido 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(243, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 252
        Me.Label1.Text = "1° Apellido:"
        '
        'lblNombre2Titulo
        '
        Me.lblNombre2Titulo.AutoSize = True
        Me.lblNombre2Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre2Titulo.Location = New System.Drawing.Point(244, 79)
        Me.lblNombre2Titulo.Name = "lblNombre2Titulo"
        Me.lblNombre2Titulo.Size = New System.Drawing.Size(94, 20)
        Me.lblNombre2Titulo.TabIndex = 251
        Me.lblNombre2Titulo.Text = "2° Nombre:"
        '
        'lblApellido2Titulo
        '
        Me.lblApellido2Titulo.AutoSize = True
        Me.lblApellido2Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido2Titulo.Location = New System.Drawing.Point(244, 145)
        Me.lblApellido2Titulo.Name = "lblApellido2Titulo"
        Me.lblApellido2Titulo.Size = New System.Drawing.Size(94, 20)
        Me.lblApellido2Titulo.TabIndex = 250
        Me.lblApellido2Titulo.Text = "2° Apellido:"
        '
        'lblNombre1Titulo
        '
        Me.lblNombre1Titulo.AutoSize = True
        Me.lblNombre1Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre1Titulo.Location = New System.Drawing.Point(243, 46)
        Me.lblNombre1Titulo.Name = "lblNombre1Titulo"
        Me.lblNombre1Titulo.Size = New System.Drawing.Size(94, 20)
        Me.lblNombre1Titulo.TabIndex = 249
        Me.lblNombre1Titulo.Text = "1° Nombre:"
        '
        'lblNombre2
        '
        Me.lblNombre2.AutoSize = True
        Me.lblNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre2.Location = New System.Drawing.Point(373, 80)
        Me.lblNombre2.Name = "lblNombre2"
        Me.lblNombre2.Size = New System.Drawing.Size(97, 20)
        Me.lblNombre2.TabIndex = 248
        Me.lblNombre2.Text = "NOMBRE 2"
        '
        'lblNombre1
        '
        Me.lblNombre1.AutoSize = True
        Me.lblNombre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre1.Location = New System.Drawing.Point(373, 46)
        Me.lblNombre1.Name = "lblNombre1"
        Me.lblNombre1.Size = New System.Drawing.Size(97, 20)
        Me.lblNombre1.TabIndex = 247
        Me.lblNombre1.Text = "NOMBRE 1"
        '
        'lblEspecialidadTitulo
        '
        Me.lblEspecialidadTitulo.AutoSize = True
        Me.lblEspecialidadTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspecialidadTitulo.Location = New System.Drawing.Point(671, 111)
        Me.lblEspecialidadTitulo.Name = "lblEspecialidadTitulo"
        Me.lblEspecialidadTitulo.Size = New System.Drawing.Size(109, 20)
        Me.lblEspecialidadTitulo.TabIndex = 258
        Me.lblEspecialidadTitulo.Text = "Especialidad:"
        '
        'lblEspecialidad
        '
        Me.lblEspecialidad.AutoSize = True
        Me.lblEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspecialidad.Location = New System.Drawing.Point(802, 111)
        Me.lblEspecialidad.Name = "lblEspecialidad"
        Me.lblEspecialidad.Size = New System.Drawing.Size(131, 20)
        Me.lblEspecialidad.TabIndex = 257
        Me.lblEspecialidad.Text = "ESPECIALIDAD"
        '
        'frmDatosMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1038, 203)
        Me.Controls.Add(Me.lblEspecialidadTitulo)
        Me.Controls.Add(Me.lblEspecialidad)
        Me.Controls.Add(Me.lblApellido2)
        Me.Controls.Add(Me.lblApellido1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNombre2Titulo)
        Me.Controls.Add(Me.lblApellido2Titulo)
        Me.Controls.Add(Me.lblNombre1Titulo)
        Me.Controls.Add(Me.lblNombre2)
        Me.Controls.Add(Me.lblNombre1)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.lblCorreoTitulo)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblCedulaTitulo)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblDireccionTitulo)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pBoxFotoPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDatosMedico"
        Me.Text = "frmDatosMedicos"
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBaja As Button
    Friend WithEvents lblCorreoTitulo As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblCedulaTitulo As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblDireccionTitulo As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pBoxFotoPaciente As PictureBox
    Friend WithEvents lblApellido2 As Label
    Friend WithEvents lblApellido1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombre2Titulo As Label
    Friend WithEvents lblApellido2Titulo As Label
    Friend WithEvents lblNombre1Titulo As Label
    Friend WithEvents lblNombre2 As Label
    Friend WithEvents lblNombre1 As Label
    Friend WithEvents lblEspecialidadTitulo As Label
    Friend WithEvents lblEspecialidad As Label
End Class
