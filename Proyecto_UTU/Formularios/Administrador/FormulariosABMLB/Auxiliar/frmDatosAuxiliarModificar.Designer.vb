<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosAuxiliarModificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosAuxiliarModificar))
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.pBoxFotoPaciente = New System.Windows.Forms.PictureBox()
        Me.lblMensajeError = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(813, 42)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(204, 22)
        Me.txtTelefono.TabIndex = 223
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(813, 14)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(204, 22)
        Me.txtDireccion.TabIndex = 222
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(373, 72)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(204, 22)
        Me.txtApellido.TabIndex = 216
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(373, 41)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(204, 22)
        Me.txtNombres.TabIndex = 215
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(373, 12)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(204, 22)
        Me.txtCedula.TabIndex = 214
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(243, 12)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(66, 20)
        Me.lblCedula.TabIndex = 206
        Me.lblCedula.Text = "Cédula:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(672, 14)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(86, 20)
        Me.lblDireccion.TabIndex = 213
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(672, 44)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(78, 20)
        Me.lblTelefono.TabIndex = 207
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.Location = New System.Drawing.Point(242, 75)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(82, 20)
        Me.lblApellidos.TabIndex = 205
        Me.lblApellidos.Text = "Apellidos:"
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.Location = New System.Drawing.Point(242, 42)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(82, 20)
        Me.lblNombres.TabIndex = 204
        Me.lblNombres.Text = "Nombres:"
        '
        'pBoxFotoPaciente
        '
        Me.pBoxFotoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBoxFotoPaciente.Image = CType(resources.GetObject("pBoxFotoPaciente.Image"), System.Drawing.Image)
        Me.pBoxFotoPaciente.Location = New System.Drawing.Point(12, 12)
        Me.pBoxFotoPaciente.Name = "pBoxFotoPaciente"
        Me.pBoxFotoPaciente.Size = New System.Drawing.Size(189, 177)
        Me.pBoxFotoPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxFotoPaciente.TabIndex = 203
        Me.pBoxFotoPaciente.TabStop = False
        '
        'lblMensajeError
        '
        Me.lblMensajeError.ForeColor = System.Drawing.Color.Red
        Me.lblMensajeError.Location = New System.Drawing.Point(243, 111)
        Me.lblMensajeError.Name = "lblMensajeError"
        Me.lblMensajeError.Size = New System.Drawing.Size(334, 78)
        Me.lblMensajeError.TabIndex = 224
        Me.lblMensajeError.Text = "Msg error"
        Me.lblMensajeError.Visible = False
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(813, 73)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(204, 22)
        Me.txtCorreo.TabIndex = 226
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(672, 75)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(65, 20)
        Me.lblCorreo.TabIndex = 225
        Me.lblCorreo.Text = "Correo:"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAceptar.Location = New System.Drawing.Point(969, 151)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(48, 40)
        Me.btnAceptar.TabIndex = 227
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImage = CType(resources.GetObject("btnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpiar.Location = New System.Drawing.Point(915, 151)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(48, 40)
        Me.btnLimpiar.TabIndex = 229
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'frmDatosAuxiliarModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1038, 203)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblMensajeError)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblApellidos)
        Me.Controls.Add(Me.lblNombres)
        Me.Controls.Add(Me.pBoxFotoPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDatosAuxiliarModificar"
        Me.Text = "frmDatosAuxiliarModificar"
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents pBoxFotoPaciente As PictureBox
    Friend WithEvents lblMensajeError As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnLimpiar As Button
End Class
