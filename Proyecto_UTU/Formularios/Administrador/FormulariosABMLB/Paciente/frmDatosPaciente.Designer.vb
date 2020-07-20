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
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.lblNombre1 = New System.Windows.Forms.Label()
        Me.pBoxFotoPaciente = New System.Windows.Forms.PictureBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.lblContrasenaTitulo = New System.Windows.Forms.Label()
        Me.lblApellido2Titulo = New System.Windows.Forms.Label()
        Me.lblNombre2Titulo = New System.Windows.Forms.Label()
        Me.lblAcompananteTitulo = New System.Windows.Forms.Label()
        Me.lblCedulaTitulo = New System.Windows.Forms.Label()
        Me.lblDireccionTitulo = New System.Windows.Forms.Label()
        Me.lblEstadoCivilTitulo = New System.Windows.Forms.Label()
        Me.lblOcupacionTitulo = New System.Windows.Forms.Label()
        Me.lblSexoTitulo = New System.Windows.Forms.Label()
        Me.lblEdadTitulo = New System.Windows.Forms.Label()
        Me.lblTelefonoTitulo = New System.Windows.Forms.Label()
        Me.lblApellido1Titulo = New System.Windows.Forms.Label()
        Me.lblNombre1Titulo = New System.Windows.Forms.Label()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.lblNombre2 = New System.Windows.Forms.Label()
        Me.lblOcupacion = New System.Windows.Forms.Label()
        Me.lblAcompanante = New System.Windows.Forms.Label()
        Me.lblContrasena = New System.Windows.Forms.Label()
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(373, 12)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(78, 20)
        Me.lblCedula.TabIndex = 166
        Me.lblCedula.Text = "CÉDULA"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(803, 70)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(81, 20)
        Me.lblDireccion.TabIndex = 164
        Me.lblDireccion.Text = "Dirección"
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCivil.Location = New System.Drawing.Point(803, 9)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(95, 20)
        Me.lblEstadoCivil.TabIndex = 160
        Me.lblEstadoCivil.Text = "Estado civil"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(374, 190)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(46, 20)
        Me.lblSexo.TabIndex = 156
        Me.lblSexo.Text = "Sexo"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(373, 160)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(47, 20)
        Me.lblEdad.TabIndex = 154
        Me.lblEdad.Text = "Edad"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(803, 101)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(108, 20)
        Me.lblTelefono.TabIndex = 152
        Me.lblTelefono.Text = "TELEFONO1"
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido1.Location = New System.Drawing.Point(373, 101)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(106, 20)
        Me.lblApellido1.TabIndex = 148
        Me.lblApellido1.Text = "APELLIDO 1"
        '
        'lblNombre1
        '
        Me.lblNombre1.AutoSize = True
        Me.lblNombre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre1.Location = New System.Drawing.Point(373, 41)
        Me.lblNombre1.Name = "lblNombre1"
        Me.lblNombre1.Size = New System.Drawing.Size(102, 20)
        Me.lblNombre1.TabIndex = 147
        Me.lblNombre1.Text = "NOMBRE 1 "
        '
        'pBoxFotoPaciente
        '
        Me.pBoxFotoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBoxFotoPaciente.Image = CType(resources.GetObject("pBoxFotoPaciente.Image"), System.Drawing.Image)
        Me.pBoxFotoPaciente.Location = New System.Drawing.Point(12, 12)
        Me.pBoxFotoPaciente.Name = "pBoxFotoPaciente"
        Me.pBoxFotoPaciente.Size = New System.Drawing.Size(189, 177)
        Me.pBoxFotoPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxFotoPaciente.TabIndex = 146
        Me.pBoxFotoPaciente.TabStop = False
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = CType(resources.GetObject("btnEditar.BackgroundImage"), System.Drawing.Image)
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditar.Location = New System.Drawing.Point(918, 186)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(48, 40)
        Me.btnEditar.TabIndex = 248
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.BackgroundImage = CType(resources.GetObject("btnBaja.BackgroundImage"), System.Drawing.Image)
        Me.btnBaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBaja.Location = New System.Drawing.Point(972, 186)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(48, 40)
        Me.btnBaja.TabIndex = 247
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'lblContrasenaTitulo
        '
        Me.lblContrasenaTitulo.AutoSize = True
        Me.lblContrasenaTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasenaTitulo.Location = New System.Drawing.Point(674, 160)
        Me.lblContrasenaTitulo.Name = "lblContrasenaTitulo"
        Me.lblContrasenaTitulo.Size = New System.Drawing.Size(100, 20)
        Me.lblContrasenaTitulo.TabIndex = 265
        Me.lblContrasenaTitulo.Text = "Contraseña:"
        '
        'lblApellido2Titulo
        '
        Me.lblApellido2Titulo.AutoSize = True
        Me.lblApellido2Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido2Titulo.Location = New System.Drawing.Point(245, 131)
        Me.lblApellido2Titulo.Name = "lblApellido2Titulo"
        Me.lblApellido2Titulo.Size = New System.Drawing.Size(94, 20)
        Me.lblApellido2Titulo.TabIndex = 264
        Me.lblApellido2Titulo.Text = "2° Apellido:"
        '
        'lblNombre2Titulo
        '
        Me.lblNombre2Titulo.AutoSize = True
        Me.lblNombre2Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre2Titulo.Location = New System.Drawing.Point(245, 70)
        Me.lblNombre2Titulo.Name = "lblNombre2Titulo"
        Me.lblNombre2Titulo.Size = New System.Drawing.Size(94, 20)
        Me.lblNombre2Titulo.TabIndex = 263
        Me.lblNombre2Titulo.Text = "2° Nombre:"
        '
        'lblAcompananteTitulo
        '
        Me.lblAcompananteTitulo.AutoSize = True
        Me.lblAcompananteTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcompananteTitulo.Location = New System.Drawing.Point(674, 131)
        Me.lblAcompananteTitulo.Name = "lblAcompananteTitulo"
        Me.lblAcompananteTitulo.Size = New System.Drawing.Size(116, 20)
        Me.lblAcompananteTitulo.TabIndex = 262
        Me.lblAcompananteTitulo.Text = "Acompañante:"
        '
        'lblCedulaTitulo
        '
        Me.lblCedulaTitulo.AutoSize = True
        Me.lblCedulaTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedulaTitulo.Location = New System.Drawing.Point(245, 12)
        Me.lblCedulaTitulo.Name = "lblCedulaTitulo"
        Me.lblCedulaTitulo.Size = New System.Drawing.Size(66, 20)
        Me.lblCedulaTitulo.TabIndex = 255
        Me.lblCedulaTitulo.Text = "Cédula:"
        '
        'lblDireccionTitulo
        '
        Me.lblDireccionTitulo.AutoSize = True
        Me.lblDireccionTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionTitulo.Location = New System.Drawing.Point(674, 70)
        Me.lblDireccionTitulo.Name = "lblDireccionTitulo"
        Me.lblDireccionTitulo.Size = New System.Drawing.Size(86, 20)
        Me.lblDireccionTitulo.TabIndex = 261
        Me.lblDireccionTitulo.Text = "Dirección:"
        '
        'lblEstadoCivilTitulo
        '
        Me.lblEstadoCivilTitulo.AutoSize = True
        Me.lblEstadoCivilTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCivilTitulo.Location = New System.Drawing.Point(674, 9)
        Me.lblEstadoCivilTitulo.Name = "lblEstadoCivilTitulo"
        Me.lblEstadoCivilTitulo.Size = New System.Drawing.Size(100, 20)
        Me.lblEstadoCivilTitulo.TabIndex = 260
        Me.lblEstadoCivilTitulo.Text = "Estado civíl:"
        '
        'lblOcupacionTitulo
        '
        Me.lblOcupacionTitulo.AutoSize = True
        Me.lblOcupacionTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacionTitulo.Location = New System.Drawing.Point(674, 40)
        Me.lblOcupacionTitulo.Name = "lblOcupacionTitulo"
        Me.lblOcupacionTitulo.Size = New System.Drawing.Size(94, 20)
        Me.lblOcupacionTitulo.TabIndex = 259
        Me.lblOcupacionTitulo.Text = "Ocupación:"
        '
        'lblSexoTitulo
        '
        Me.lblSexoTitulo.AutoSize = True
        Me.lblSexoTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexoTitulo.Location = New System.Drawing.Point(244, 190)
        Me.lblSexoTitulo.Name = "lblSexoTitulo"
        Me.lblSexoTitulo.Size = New System.Drawing.Size(51, 20)
        Me.lblSexoTitulo.TabIndex = 258
        Me.lblSexoTitulo.Text = "Sexo:"
        '
        'lblEdadTitulo
        '
        Me.lblEdadTitulo.AutoSize = True
        Me.lblEdadTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdadTitulo.Location = New System.Drawing.Point(244, 160)
        Me.lblEdadTitulo.Name = "lblEdadTitulo"
        Me.lblEdadTitulo.Size = New System.Drawing.Size(52, 20)
        Me.lblEdadTitulo.TabIndex = 257
        Me.lblEdadTitulo.Text = "Edad:"
        '
        'lblTelefonoTitulo
        '
        Me.lblTelefonoTitulo.AutoSize = True
        Me.lblTelefonoTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoTitulo.Location = New System.Drawing.Point(674, 101)
        Me.lblTelefonoTitulo.Name = "lblTelefonoTitulo"
        Me.lblTelefonoTitulo.Size = New System.Drawing.Size(78, 20)
        Me.lblTelefonoTitulo.TabIndex = 256
        Me.lblTelefonoTitulo.Text = "Teléfono:"
        '
        'lblApellido1Titulo
        '
        Me.lblApellido1Titulo.AutoSize = True
        Me.lblApellido1Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido1Titulo.Location = New System.Drawing.Point(245, 101)
        Me.lblApellido1Titulo.Name = "lblApellido1Titulo"
        Me.lblApellido1Titulo.Size = New System.Drawing.Size(94, 20)
        Me.lblApellido1Titulo.TabIndex = 254
        Me.lblApellido1Titulo.Text = "1° Apellido:"
        '
        'lblNombre1Titulo
        '
        Me.lblNombre1Titulo.AutoSize = True
        Me.lblNombre1Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre1Titulo.Location = New System.Drawing.Point(244, 42)
        Me.lblNombre1Titulo.Name = "lblNombre1Titulo"
        Me.lblNombre1Titulo.Size = New System.Drawing.Size(94, 20)
        Me.lblNombre1Titulo.TabIndex = 253
        Me.lblNombre1Titulo.Text = "1° Nombre:"
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido2.Location = New System.Drawing.Point(373, 131)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(106, 20)
        Me.lblApellido2.TabIndex = 266
        Me.lblApellido2.Text = "APELLIDO 2"
        '
        'lblNombre2
        '
        Me.lblNombre2.AutoSize = True
        Me.lblNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre2.Location = New System.Drawing.Point(373, 70)
        Me.lblNombre2.Name = "lblNombre2"
        Me.lblNombre2.Size = New System.Drawing.Size(102, 20)
        Me.lblNombre2.TabIndex = 267
        Me.lblNombre2.Text = "NOMBRE 2 "
        '
        'lblOcupacion
        '
        Me.lblOcupacion.AutoSize = True
        Me.lblOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacion.Location = New System.Drawing.Point(803, 40)
        Me.lblOcupacion.Name = "lblOcupacion"
        Me.lblOcupacion.Size = New System.Drawing.Size(89, 20)
        Me.lblOcupacion.TabIndex = 268
        Me.lblOcupacion.Text = "Ocupación"
        '
        'lblAcompanante
        '
        Me.lblAcompanante.AutoSize = True
        Me.lblAcompanante.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcompanante.Location = New System.Drawing.Point(803, 131)
        Me.lblAcompanante.Name = "lblAcompanante"
        Me.lblAcompanante.Size = New System.Drawing.Size(111, 20)
        Me.lblAcompanante.TabIndex = 269
        Me.lblAcompanante.Text = "Acompañante"
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasena.Location = New System.Drawing.Point(803, 160)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(95, 20)
        Me.lblContrasena.TabIndex = 270
        Me.lblContrasena.Text = "Contraseña"
        '
        'frmDatosPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1038, 238)
        Me.Controls.Add(Me.lblContrasena)
        Me.Controls.Add(Me.lblAcompanante)
        Me.Controls.Add(Me.lblOcupacion)
        Me.Controls.Add(Me.lblNombre2)
        Me.Controls.Add(Me.lblApellido2)
        Me.Controls.Add(Me.lblContrasenaTitulo)
        Me.Controls.Add(Me.lblApellido2Titulo)
        Me.Controls.Add(Me.lblNombre2Titulo)
        Me.Controls.Add(Me.lblAcompananteTitulo)
        Me.Controls.Add(Me.lblCedulaTitulo)
        Me.Controls.Add(Me.lblDireccionTitulo)
        Me.Controls.Add(Me.lblEstadoCivilTitulo)
        Me.Controls.Add(Me.lblOcupacionTitulo)
        Me.Controls.Add(Me.lblSexoTitulo)
        Me.Controls.Add(Me.lblEdadTitulo)
        Me.Controls.Add(Me.lblTelefonoTitulo)
        Me.Controls.Add(Me.lblApellido1Titulo)
        Me.Controls.Add(Me.lblNombre1Titulo)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblEstadoCivil)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblApellido1)
        Me.Controls.Add(Me.lblNombre1)
        Me.Controls.Add(Me.pBoxFotoPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDatosPaciente"
        Me.Text = "frmDatosPaciente"
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pBoxFotoPaciente As PictureBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBaja As Button
    Public WithEvents lblCedula As Label
    Public WithEvents lblDireccion As Label
    Public WithEvents lblEstadoCivil As Label
    Public WithEvents lblSexo As Label
    Public WithEvents lblEdad As Label
    Public WithEvents lblTelefono As Label
    Public WithEvents lblApellido1 As Label
    Public WithEvents lblNombre1 As Label
    Friend WithEvents lblContrasenaTitulo As Label
    Friend WithEvents lblApellido2Titulo As Label
    Friend WithEvents lblNombre2Titulo As Label
    Friend WithEvents lblAcompananteTitulo As Label
    Friend WithEvents lblCedulaTitulo As Label
    Friend WithEvents lblDireccionTitulo As Label
    Friend WithEvents lblEstadoCivilTitulo As Label
    Friend WithEvents lblOcupacionTitulo As Label
    Friend WithEvents lblSexoTitulo As Label
    Friend WithEvents lblEdadTitulo As Label
    Friend WithEvents lblTelefonoTitulo As Label
    Friend WithEvents lblApellido1Titulo As Label
    Friend WithEvents lblNombre1Titulo As Label
    Friend WithEvents lblApellido2 As Label
    Public WithEvents lblNombre2 As Label
    Friend WithEvents lblOcupacion As Label
    Friend WithEvents lblAcompanante As Label
    Friend WithEvents lblContrasena As Label
End Class
