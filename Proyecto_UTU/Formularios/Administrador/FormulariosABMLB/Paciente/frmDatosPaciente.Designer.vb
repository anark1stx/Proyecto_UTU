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
        Me.lblCedulaTitulo = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblDireccionTitulo = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblEscolaridadTitulo = New System.Windows.Forms.Label()
        Me.lblEstadoEscolaridad = New System.Windows.Forms.Label()
        Me.lblEstadoCivilTitulo = New System.Windows.Forms.Label()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.lblOcupacionTitulo = New System.Windows.Forms.Label()
        Me.lblOcupacion = New System.Windows.Forms.Label()
        Me.lblSexoTitulo = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblEdadTitulo = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblTelefonoTitulo = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblApellidosTitulo = New System.Windows.Forms.Label()
        Me.lblNombresTitulo = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.pBoxFotoPaciente = New System.Windows.Forms.PictureBox()
        Me.lblAcompananteTitulo = New System.Windows.Forms.Label()
        Me.lblNomAcompanante = New System.Windows.Forms.Label()
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
        Me.lblDireccionTitulo.Location = New System.Drawing.Point(672, 70)
        Me.lblDireccionTitulo.Name = "lblDireccionTitulo"
        Me.lblDireccionTitulo.Size = New System.Drawing.Size(86, 20)
        Me.lblDireccionTitulo.TabIndex = 165
        Me.lblDireccionTitulo.Text = "Dirección:"
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
        'lblEscolaridadTitulo
        '
        Me.lblEscolaridadTitulo.AutoSize = True
        Me.lblEscolaridadTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEscolaridadTitulo.Location = New System.Drawing.Point(672, 38)
        Me.lblEscolaridadTitulo.Name = "lblEscolaridadTitulo"
        Me.lblEscolaridadTitulo.Size = New System.Drawing.Size(102, 20)
        Me.lblEscolaridadTitulo.TabIndex = 163
        Me.lblEscolaridadTitulo.Text = "Escolaridad:"
        '
        'lblEstadoEscolaridad
        '
        Me.lblEstadoEscolaridad.AutoSize = True
        Me.lblEstadoEscolaridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoEscolaridad.Location = New System.Drawing.Point(803, 38)
        Me.lblEstadoEscolaridad.Name = "lblEstadoEscolaridad"
        Me.lblEstadoEscolaridad.Size = New System.Drawing.Size(97, 20)
        Me.lblEstadoEscolaridad.TabIndex = 162
        Me.lblEstadoEscolaridad.Text = "Escolaridad"
        '
        'lblEstadoCivilTitulo
        '
        Me.lblEstadoCivilTitulo.AutoSize = True
        Me.lblEstadoCivilTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCivilTitulo.Location = New System.Drawing.Point(672, 9)
        Me.lblEstadoCivilTitulo.Name = "lblEstadoCivilTitulo"
        Me.lblEstadoCivilTitulo.Size = New System.Drawing.Size(100, 20)
        Me.lblEstadoCivilTitulo.TabIndex = 161
        Me.lblEstadoCivilTitulo.Text = "Estado civíl:"
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
        'lblOcupacionTitulo
        '
        Me.lblOcupacionTitulo.AutoSize = True
        Me.lblOcupacionTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacionTitulo.Location = New System.Drawing.Point(243, 169)
        Me.lblOcupacionTitulo.Name = "lblOcupacionTitulo"
        Me.lblOcupacionTitulo.Size = New System.Drawing.Size(94, 20)
        Me.lblOcupacionTitulo.TabIndex = 159
        Me.lblOcupacionTitulo.Text = "Ocupación:"
        '
        'lblOcupacion
        '
        Me.lblOcupacion.AutoSize = True
        Me.lblOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacion.Location = New System.Drawing.Point(374, 169)
        Me.lblOcupacion.Name = "lblOcupacion"
        Me.lblOcupacion.Size = New System.Drawing.Size(89, 20)
        Me.lblOcupacion.TabIndex = 158
        Me.lblOcupacion.Text = "Ocupación"
        '
        'lblSexoTitulo
        '
        Me.lblSexoTitulo.AutoSize = True
        Me.lblSexoTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexoTitulo.Location = New System.Drawing.Point(242, 139)
        Me.lblSexoTitulo.Name = "lblSexoTitulo"
        Me.lblSexoTitulo.Size = New System.Drawing.Size(69, 20)
        Me.lblSexoTitulo.TabIndex = 157
        Me.lblSexoTitulo.Text = "Género:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(374, 139)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(46, 20)
        Me.lblSexo.TabIndex = 156
        Me.lblSexo.Text = "Sexo"
        '
        'lblEdadTitulo
        '
        Me.lblEdadTitulo.AutoSize = True
        Me.lblEdadTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdadTitulo.Location = New System.Drawing.Point(241, 109)
        Me.lblEdadTitulo.Name = "lblEdadTitulo"
        Me.lblEdadTitulo.Size = New System.Drawing.Size(52, 20)
        Me.lblEdadTitulo.TabIndex = 155
        Me.lblEdadTitulo.Text = "Edad:"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(373, 109)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(47, 20)
        Me.lblEdad.TabIndex = 154
        Me.lblEdad.Text = "Edad"
        '
        'lblTelefonoTitulo
        '
        Me.lblTelefonoTitulo.AutoSize = True
        Me.lblTelefonoTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoTitulo.Location = New System.Drawing.Point(672, 102)
        Me.lblTelefonoTitulo.Name = "lblTelefonoTitulo"
        Me.lblTelefonoTitulo.Size = New System.Drawing.Size(78, 20)
        Me.lblTelefonoTitulo.TabIndex = 153
        Me.lblTelefonoTitulo.Text = "Teléfono:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(803, 102)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(108, 20)
        Me.lblTelefono.TabIndex = 152
        Me.lblTelefono.Text = "TELEFONO1"
        '
        'lblApellidosTitulo
        '
        Me.lblApellidosTitulo.AutoSize = True
        Me.lblApellidosTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosTitulo.Location = New System.Drawing.Point(242, 75)
        Me.lblApellidosTitulo.Name = "lblApellidosTitulo"
        Me.lblApellidosTitulo.Size = New System.Drawing.Size(73, 20)
        Me.lblApellidosTitulo.TabIndex = 150
        Me.lblApellidosTitulo.Text = "Apellido:"
        '
        'lblNombresTitulo
        '
        Me.lblNombresTitulo.AutoSize = True
        Me.lblNombresTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombresTitulo.Location = New System.Drawing.Point(242, 41)
        Me.lblNombresTitulo.Name = "lblNombresTitulo"
        Me.lblNombresTitulo.Size = New System.Drawing.Size(73, 20)
        Me.lblNombresTitulo.TabIndex = 149
        Me.lblNombresTitulo.Text = "Nombre:"
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
        'lblAcompananteTitulo
        '
        Me.lblAcompananteTitulo.AutoSize = True
        Me.lblAcompananteTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcompananteTitulo.Location = New System.Drawing.Point(672, 128)
        Me.lblAcompananteTitulo.Name = "lblAcompananteTitulo"
        Me.lblAcompananteTitulo.Size = New System.Drawing.Size(116, 20)
        Me.lblAcompananteTitulo.TabIndex = 198
        Me.lblAcompananteTitulo.Text = "Acompañante:"
        '
        'lblNomAcompanante
        '
        Me.lblNomAcompanante.AutoSize = True
        Me.lblNomAcompanante.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomAcompanante.Location = New System.Drawing.Point(803, 128)
        Me.lblNomAcompanante.Name = "lblNomAcompanante"
        Me.lblNomAcompanante.Size = New System.Drawing.Size(216, 20)
        Me.lblNomAcompanante.TabIndex = 199
        Me.lblNomAcompanante.Text = "NOMBRE ACOMPAÑANTE"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImage = CType(resources.GetObject("btnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLimpiar.Location = New System.Drawing.Point(916, 154)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(48, 40)
        Me.btnLimpiar.TabIndex = 248
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAceptar.Location = New System.Drawing.Point(970, 154)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(48, 40)
        Me.btnAceptar.TabIndex = 247
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'frmDatosPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1038, 203)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblNomAcompanante)
        Me.Controls.Add(Me.lblAcompananteTitulo)
        Me.Controls.Add(Me.lblCedulaTitulo)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblDireccionTitulo)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblEscolaridadTitulo)
        Me.Controls.Add(Me.lblEstadoEscolaridad)
        Me.Controls.Add(Me.lblEstadoCivilTitulo)
        Me.Controls.Add(Me.lblEstadoCivil)
        Me.Controls.Add(Me.lblOcupacionTitulo)
        Me.Controls.Add(Me.lblOcupacion)
        Me.Controls.Add(Me.lblSexoTitulo)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblEdadTitulo)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.lblTelefonoTitulo)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblApellidosTitulo)
        Me.Controls.Add(Me.lblNombresTitulo)
        Me.Controls.Add(Me.lblApellidos)
        Me.Controls.Add(Me.lblNombres)
        Me.Controls.Add(Me.pBoxFotoPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDatosPaciente"
        Me.Text = "frmDatosPaciente"
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCedulaTitulo As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblDireccionTitulo As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblEscolaridadTitulo As Label
    Friend WithEvents lblEstadoEscolaridad As Label
    Friend WithEvents lblEstadoCivilTitulo As Label
    Friend WithEvents lblEstadoCivil As Label
    Friend WithEvents lblOcupacionTitulo As Label
    Friend WithEvents lblOcupacion As Label
    Friend WithEvents lblSexoTitulo As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblEdadTitulo As Label
    Friend WithEvents lblEdad As Label
    Friend WithEvents lblTelefonoTitulo As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblApellidosTitulo As Label
    Friend WithEvents lblNombresTitulo As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents pBoxFotoPaciente As PictureBox
    Friend WithEvents lblAcompananteTitulo As Label
    Friend WithEvents lblNomAcompanante As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnAceptar As Button
End Class
