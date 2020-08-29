<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDatosPacienteModificar
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosPacienteModificar))
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtOcupacion = New System.Windows.Forms.TextBox()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.txtNombre1 = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.imgsBotonAltaModif = New System.Windows.Forms.ImageList(Me.components)
        Me.txtNombre2 = New System.Windows.Forms.TextBox()
        Me.lblNombre2 = New System.Windows.Forms.Label()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.cb_e_civil = New System.Windows.Forms.ComboBox()
        Me.dateFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.cbTelefonos = New System.Windows.Forms.ComboBox()
        Me.btnAgregarTelefono = New System.Windows.Forms.Button()
        Me.btnSacarTelefono = New System.Windows.Forms.Button()
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(813, 100)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(204, 27)
        Me.txtDireccion.TabIndex = 195
        '
        'txtOcupacion
        '
        Me.txtOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOcupacion.Location = New System.Drawing.Point(813, 70)
        Me.txtOcupacion.Name = "txtOcupacion"
        Me.txtOcupacion.Size = New System.Drawing.Size(204, 27)
        Me.txtOcupacion.TabIndex = 192
        '
        'txtApellido1
        '
        Me.txtApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido1.Location = New System.Drawing.Point(372, 103)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(204, 27)
        Me.txtApellido1.TabIndex = 189
        '
        'txtNombre1
        '
        Me.txtNombre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre1.Location = New System.Drawing.Point(372, 40)
        Me.txtNombre1.Name = "txtNombre1"
        Me.txtNombre1.Size = New System.Drawing.Size(204, 27)
        Me.txtNombre1.TabIndex = 188
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(372, 8)
        Me.txtCedula.MaxLength = 8
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(204, 27)
        Me.txtCedula.TabIndex = 187
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(243, 9)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(75, 24)
        Me.lblCedula.TabIndex = 179
        Me.lblCedula.Text = "Cédula:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(672, 103)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(95, 24)
        Me.lblDireccion.TabIndex = 186
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCivil.Location = New System.Drawing.Point(672, 41)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(109, 24)
        Me.lblEstadoCivil.TabIndex = 184
        Me.lblEstadoCivil.Text = "Estado civíl:"
        '
        'lblOcupacion
        '
        Me.lblOcupacion.AutoSize = True
        Me.lblOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacion.Location = New System.Drawing.Point(672, 73)
        Me.lblOcupacion.Name = "lblOcupacion"
        Me.lblOcupacion.Size = New System.Drawing.Size(108, 24)
        Me.lblOcupacion.TabIndex = 183
        Me.lblOcupacion.Text = "Ocupación:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(243, 207)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(59, 24)
        Me.lblSexo.TabIndex = 182
        Me.lblSexo.Text = "Sexo:"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(243, 173)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(108, 24)
        Me.lblEdad.TabIndex = 181
        Me.lblEdad.Text = "Fecha Nac."
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(672, 134)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(99, 24)
        Me.lblTelefono.TabIndex = 180
        Me.lblTelefono.Text = "Teléfonos:"
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido1.Location = New System.Drawing.Point(242, 106)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(105, 24)
        Me.lblApellido1.TabIndex = 178
        Me.lblApellido1.Text = "1° Apellido:"
        '
        'lblNombre1
        '
        Me.lblNombre1.AutoSize = True
        Me.lblNombre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre1.Location = New System.Drawing.Point(242, 41)
        Me.lblNombre1.Name = "lblNombre1"
        Me.lblNombre1.Size = New System.Drawing.Size(105, 24)
        Me.lblNombre1.TabIndex = 177
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
        Me.pBoxFotoPaciente.TabIndex = 176
        Me.pBoxFotoPaciente.TabStop = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImage = CType(resources.GetObject("btnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpiar.Location = New System.Drawing.Point(915, 191)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(48, 40)
        Me.btnLimpiar.TabIndex = 247
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAceptar.ImageIndex = 0
        Me.btnAceptar.ImageList = Me.imgsBotonAltaModif
        Me.btnAceptar.Location = New System.Drawing.Point(969, 191)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(48, 40)
        Me.btnAceptar.TabIndex = 246
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'imgsBotonAltaModif
        '
        Me.imgsBotonAltaModif.ImageStream = CType(resources.GetObject("imgsBotonAltaModif.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgsBotonAltaModif.TransparentColor = System.Drawing.Color.Transparent
        Me.imgsBotonAltaModif.Images.SetKeyName(0, "plus.png")
        Me.imgsBotonAltaModif.Images.SetKeyName(1, "accept.png")
        '
        'txtNombre2
        '
        Me.txtNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre2.Location = New System.Drawing.Point(372, 71)
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(204, 27)
        Me.txtNombre2.TabIndex = 249
        '
        'lblNombre2
        '
        Me.lblNombre2.AutoSize = True
        Me.lblNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre2.Location = New System.Drawing.Point(242, 73)
        Me.lblNombre2.Name = "lblNombre2"
        Me.lblNombre2.Size = New System.Drawing.Size(105, 24)
        Me.lblNombre2.TabIndex = 248
        Me.lblNombre2.Text = "2° Nombre:"
        '
        'txtApellido2
        '
        Me.txtApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido2.Location = New System.Drawing.Point(372, 136)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(204, 27)
        Me.txtApellido2.TabIndex = 251
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido2.Location = New System.Drawing.Point(242, 139)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(105, 24)
        Me.lblApellido2.TabIndex = 250
        Me.lblApellido2.Text = "2° Apellido:"
        '
        'txtContrasena
        '
        Me.txtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasena.Location = New System.Drawing.Point(813, 162)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(204, 27)
        Me.txtContrasena.TabIndex = 253
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasena.Location = New System.Drawing.Point(672, 165)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(111, 24)
        Me.lblContrasena.TabIndex = 252
        Me.lblContrasena.Text = "Contraseña:"
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(813, 5)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(204, 27)
        Me.txtCorreo.TabIndex = 255
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(672, 8)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(73, 24)
        Me.lblCorreo.TabIndex = 254
        Me.lblCorreo.Text = "Correo:"
        '
        'cbSexo
        '
        Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cbSexo.Location = New System.Drawing.Point(372, 203)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(204, 28)
        Me.cbSexo.TabIndex = 256
        '
        'cb_e_civil
        '
        Me.cb_e_civil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_e_civil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_e_civil.FormattingEnabled = True
        Me.cb_e_civil.Items.AddRange(New Object() {"Soltero", "Casado"})
        Me.cb_e_civil.Location = New System.Drawing.Point(813, 37)
        Me.cb_e_civil.Name = "cb_e_civil"
        Me.cb_e_civil.Size = New System.Drawing.Size(204, 28)
        Me.cb_e_civil.TabIndex = 257
        '
        'dateFechaNacimiento
        '
        Me.dateFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFechaNacimiento.Location = New System.Drawing.Point(372, 169)
        Me.dateFechaNacimiento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dateFechaNacimiento.Name = "dateFechaNacimiento"
        Me.dateFechaNacimiento.Size = New System.Drawing.Size(204, 28)
        Me.dateFechaNacimiento.TabIndex = 258
        Me.dateFechaNacimiento.Value = New Date(2020, 8, 19, 0, 0, 0, 0)
        '
        'cbTelefonos
        '
        Me.cbTelefonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTelefonos.FormattingEnabled = True
        Me.cbTelefonos.Location = New System.Drawing.Point(813, 131)
        Me.cbTelefonos.Name = "cbTelefonos"
        Me.cbTelefonos.Size = New System.Drawing.Size(134, 26)
        Me.cbTelefonos.TabIndex = 259
        Me.cbTelefonos.Tag = "datos"
        '
        'btnAgregarTelefono
        '
        Me.btnAgregarTelefono.BackgroundImage = CType(resources.GetObject("btnAgregarTelefono.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarTelefono.ImageIndex = 0
        Me.btnAgregarTelefono.Location = New System.Drawing.Point(953, 131)
        Me.btnAgregarTelefono.Name = "btnAgregarTelefono"
        Me.btnAgregarTelefono.Size = New System.Drawing.Size(29, 27)
        Me.btnAgregarTelefono.TabIndex = 260
        Me.btnAgregarTelefono.UseVisualStyleBackColor = True
        '
        'btnSacarTelefono
        '
        Me.btnSacarTelefono.BackgroundImage = CType(resources.GetObject("btnSacarTelefono.BackgroundImage"), System.Drawing.Image)
        Me.btnSacarTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSacarTelefono.ImageIndex = 0
        Me.btnSacarTelefono.Location = New System.Drawing.Point(988, 131)
        Me.btnSacarTelefono.Name = "btnSacarTelefono"
        Me.btnSacarTelefono.Size = New System.Drawing.Size(29, 27)
        Me.btnSacarTelefono.TabIndex = 261
        Me.btnSacarTelefono.UseVisualStyleBackColor = True
        '
        'frmDatosPacienteModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1038, 238)
        Me.Controls.Add(Me.btnSacarTelefono)
        Me.Controls.Add(Me.btnAgregarTelefono)
        Me.Controls.Add(Me.cbTelefonos)
        Me.Controls.Add(Me.dateFechaNacimiento)
        Me.Controls.Add(Me.cb_e_civil)
        Me.Controls.Add(Me.cbSexo)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.lblContrasena)
        Me.Controls.Add(Me.txtApellido2)
        Me.Controls.Add(Me.lblApellido2)
        Me.Controls.Add(Me.txtNombre2)
        Me.Controls.Add(Me.lblNombre2)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtOcupacion)
        Me.Controls.Add(Me.txtApellido1)
        Me.Controls.Add(Me.txtNombre1)
        Me.Controls.Add(Me.txtCedula)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDatosPacienteModificar"
        Me.Text = "frmDatosPacienteModificar"
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtOcupacion As TextBox
    Friend WithEvents txtApellido1 As TextBox
    Friend WithEvents txtNombre1 As TextBox
    Friend WithEvents txtCedula As TextBox
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
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtNombre2 As TextBox
    Friend WithEvents lblNombre2 As Label
    Friend WithEvents txtApellido2 As TextBox
    Friend WithEvents lblApellido2 As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents lblContrasena As Label
    Friend WithEvents imgsBotonAltaModif As ImageList
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents cb_e_civil As ComboBox
    Friend WithEvents dateFechaNacimiento As DateTimePicker
    Friend WithEvents cbTelefonos As ComboBox
    Friend WithEvents btnAgregarTelefono As Button
    Friend WithEvents btnSacarTelefono As Button
End Class
