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
        Me.lblCedulaTitulo = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblDireccionTitulo = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblApellidosTitulo = New System.Windows.Forms.Label()
        Me.lblNombresTitulo = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.pBoxFotoPaciente = New System.Windows.Forms.PictureBox()
        Me.lblCorreoTitulo = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCedulaTitulo
        '
        Me.lblCedulaTitulo.AutoSize = True
        Me.lblCedulaTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedulaTitulo.Location = New System.Drawing.Point(243, 12)
        Me.lblCedulaTitulo.Name = "lblCedulaTitulo"
        Me.lblCedulaTitulo.Size = New System.Drawing.Size(66, 20)
        Me.lblCedulaTitulo.TabIndex = 151
        Me.lblCedulaTitulo.Text = "Cédula:"
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
        'lblDireccionTitulo
        '
        Me.lblDireccionTitulo.AutoSize = True
        Me.lblDireccionTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionTitulo.Location = New System.Drawing.Point(672, 12)
        Me.lblDireccionTitulo.Name = "lblDireccionTitulo"
        Me.lblDireccionTitulo.Size = New System.Drawing.Size(86, 20)
        Me.lblDireccionTitulo.TabIndex = 165
        Me.lblDireccionTitulo.Text = "Dirección:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(803, 12)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(81, 20)
        Me.lblDireccion.TabIndex = 164
        Me.lblDireccion.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(672, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 153
        Me.Label5.Text = "Teléfono:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(803, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 20)
        Me.Label6.TabIndex = 152
        Me.Label6.Text = "TELEFONO1"
        '
        'lblApellidosTitulo
        '
        Me.lblApellidosTitulo.AutoSize = True
        Me.lblApellidosTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosTitulo.Location = New System.Drawing.Point(242, 75)
        Me.lblApellidosTitulo.Name = "lblApellidosTitulo"
        Me.lblApellidosTitulo.Size = New System.Drawing.Size(82, 20)
        Me.lblApellidosTitulo.TabIndex = 150
        Me.lblApellidosTitulo.Text = "Apellidos:"
        '
        'lblNombresTitulo
        '
        Me.lblNombresTitulo.AutoSize = True
        Me.lblNombresTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombresTitulo.Location = New System.Drawing.Point(242, 41)
        Me.lblNombresTitulo.Name = "lblNombresTitulo"
        Me.lblNombresTitulo.Size = New System.Drawing.Size(82, 20)
        Me.lblNombresTitulo.TabIndex = 149
        Me.lblNombresTitulo.Text = "Nombres:"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.Location = New System.Drawing.Point(373, 75)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(208, 20)
        Me.lblApellidos.TabIndex = 148
        Me.lblApellidos.Text = "APELLIDO 1 APELLIDO 2"
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.Location = New System.Drawing.Point(373, 41)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(190, 20)
        Me.lblNombres.TabIndex = 147
        Me.lblNombres.Text = "NOMBRE 1 NOMBRE 2"
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
        'lblCorreoTitulo
        '
        Me.lblCorreoTitulo.AutoSize = True
        Me.lblCorreoTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreoTitulo.Location = New System.Drawing.Point(672, 75)
        Me.lblCorreoTitulo.Name = "lblCorreoTitulo"
        Me.lblCorreoTitulo.Size = New System.Drawing.Size(65, 20)
        Me.lblCorreoTitulo.TabIndex = 168
        Me.lblCorreoTitulo.Text = "Correo:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(805, 75)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(60, 20)
        Me.lblCorreo.TabIndex = 167
        Me.lblCorreo.Text = "Correo"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImage = CType(resources.GetObject("btnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLimpiar.Location = New System.Drawing.Point(915, 149)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(48, 40)
        Me.btnLimpiar.TabIndex = 231
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAceptar.Location = New System.Drawing.Point(969, 149)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(48, 40)
        Me.btnAceptar.TabIndex = 230
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'frmDatosAuxiliar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1038, 203)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblCorreoTitulo)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblCedulaTitulo)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblDireccionTitulo)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblApellidosTitulo)
        Me.Controls.Add(Me.lblNombresTitulo)
        Me.Controls.Add(Me.lblApellidos)
        Me.Controls.Add(Me.lblNombres)
        Me.Controls.Add(Me.pBoxFotoPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDatosAuxiliar"
        Me.Text = "frmDatosAuxiliar"
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCedulaTitulo As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblDireccionTitulo As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblApellidosTitulo As Label
    Friend WithEvents lblNombresTitulo As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents pBoxFotoPaciente As PictureBox
    Friend WithEvents lblCorreoTitulo As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnAceptar As Button
End Class
