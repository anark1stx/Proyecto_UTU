<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Identificacion_Paciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Identificacion_Paciente))
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblDireccionTXT = New System.Windows.Forms.Label()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.lblEstadoCivilTXT = New System.Windows.Forms.Label()
        Me.lblOcupacion = New System.Windows.Forms.Label()
        Me.lblOcupacionTXT = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblSexoTXT = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblEdadTXT = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblTelefonoTXT = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblApellidosTXT = New System.Windows.Forms.Label()
        Me.lblNombresTXT = New System.Windows.Forms.Label()
        Me.pBoxFotoPaciente = New System.Windows.Forms.PictureBox()
        Me.txtCIPaciente = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(363, 239)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(121, 29)
        Me.lblDireccion.TabIndex = 98
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblDireccionTXT
        '
        Me.lblDireccionTXT.AutoSize = True
        Me.lblDireccionTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionTXT.Location = New System.Drawing.Point(529, 240)
        Me.lblDireccionTXT.Name = "lblDireccionTXT"
        Me.lblDireccionTXT.Size = New System.Drawing.Size(93, 25)
        Me.lblDireccionTXT.TabIndex = 97
        Me.lblDireccionTXT.Text = "Dirección"
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCivil.Location = New System.Drawing.Point(363, 209)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(141, 29)
        Me.lblEstadoCivil.TabIndex = 94
        Me.lblEstadoCivil.Text = "Estado civíl:"
        '
        'lblEstadoCivilTXT
        '
        Me.lblEstadoCivilTXT.AutoSize = True
        Me.lblEstadoCivilTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCivilTXT.Location = New System.Drawing.Point(529, 210)
        Me.lblEstadoCivilTXT.Name = "lblEstadoCivilTXT"
        Me.lblEstadoCivilTXT.Size = New System.Drawing.Size(110, 25)
        Me.lblEstadoCivilTXT.TabIndex = 93
        Me.lblEstadoCivilTXT.Text = "Estado civil"
        '
        'lblOcupacion
        '
        Me.lblOcupacion.AutoSize = True
        Me.lblOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacion.Location = New System.Drawing.Point(363, 177)
        Me.lblOcupacion.Name = "lblOcupacion"
        Me.lblOcupacion.Size = New System.Drawing.Size(135, 29)
        Me.lblOcupacion.TabIndex = 92
        Me.lblOcupacion.Text = "Ocupación:"
        '
        'lblOcupacionTXT
        '
        Me.lblOcupacionTXT.AutoSize = True
        Me.lblOcupacionTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacionTXT.Location = New System.Drawing.Point(529, 178)
        Me.lblOcupacionTXT.Name = "lblOcupacionTXT"
        Me.lblOcupacionTXT.Size = New System.Drawing.Size(107, 25)
        Me.lblOcupacionTXT.TabIndex = 91
        Me.lblOcupacionTXT.Text = "Ocupación"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(362, 147)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(74, 29)
        Me.lblSexo.TabIndex = 90
        Me.lblSexo.Text = "Sexo:"
        '
        'lblSexoTXT
        '
        Me.lblSexoTXT.AutoSize = True
        Me.lblSexoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexoTXT.Location = New System.Drawing.Point(529, 148)
        Me.lblSexoTXT.Name = "lblSexoTXT"
        Me.lblSexoTXT.Size = New System.Drawing.Size(58, 25)
        Me.lblSexoTXT.TabIndex = 89
        Me.lblSexoTXT.Text = "Sexo"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(362, 115)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(76, 29)
        Me.lblEdad.TabIndex = 88
        Me.lblEdad.Text = "Edad:"
        '
        'lblEdadTXT
        '
        Me.lblEdadTXT.AutoSize = True
        Me.lblEdadTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdadTXT.Location = New System.Drawing.Point(529, 116)
        Me.lblEdadTXT.Name = "lblEdadTXT"
        Me.lblEdadTXT.Size = New System.Drawing.Size(58, 25)
        Me.lblEdadTXT.TabIndex = 87
        Me.lblEdadTXT.Text = "Edad"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(363, 270)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(116, 29)
        Me.lblTelefono.TabIndex = 84
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblTelefonoTXT
        '
        Me.lblTelefonoTXT.AutoSize = True
        Me.lblTelefonoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoTXT.Location = New System.Drawing.Point(529, 271)
        Me.lblTelefonoTXT.Name = "lblTelefonoTXT"
        Me.lblTelefonoTXT.Size = New System.Drawing.Size(131, 25)
        Me.lblTelefonoTXT.TabIndex = 83
        Me.lblTelefonoTXT.Text = "TELEFONO1"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(363, 12)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(96, 29)
        Me.lblCedula.TabIndex = 82
        Me.lblCedula.Text = "Cédula:"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(363, 81)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(108, 29)
        Me.lblApellido.TabIndex = 81
        Me.lblApellido.Text = "Apellido:"
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.Location = New System.Drawing.Point(363, 47)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(107, 29)
        Me.lblNombres.TabIndex = 80
        Me.lblNombres.Text = "Nombre:"
        '
        'lblApellidosTXT
        '
        Me.lblApellidosTXT.AutoSize = True
        Me.lblApellidosTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosTXT.Location = New System.Drawing.Point(529, 82)
        Me.lblApellidosTXT.Name = "lblApellidosTXT"
        Me.lblApellidosTXT.Size = New System.Drawing.Size(243, 25)
        Me.lblApellidosTXT.TabIndex = 79
        Me.lblApellidosTXT.Text = "APELLIDO 1 APELLIDO 2"
        '
        'lblNombresTXT
        '
        Me.lblNombresTXT.AutoSize = True
        Me.lblNombresTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombresTXT.Location = New System.Drawing.Point(529, 48)
        Me.lblNombresTXT.Name = "lblNombresTXT"
        Me.lblNombresTXT.Size = New System.Drawing.Size(221, 25)
        Me.lblNombresTXT.TabIndex = 78
        Me.lblNombresTXT.Text = "NOMBRE 1 NOMBRE 2"
        '
        'pBoxFotoPaciente
        '
        Me.pBoxFotoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBoxFotoPaciente.Image = CType(resources.GetObject("pBoxFotoPaciente.Image"), System.Drawing.Image)
        Me.pBoxFotoPaciente.Location = New System.Drawing.Point(12, 12)
        Me.pBoxFotoPaciente.Name = "pBoxFotoPaciente"
        Me.pBoxFotoPaciente.Size = New System.Drawing.Size(325, 287)
        Me.pBoxFotoPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxFotoPaciente.TabIndex = 77
        Me.pBoxFotoPaciente.TabStop = False
        '
        'txtCIPaciente
        '
        Me.txtCIPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCIPaciente.Location = New System.Drawing.Point(533, 11)
        Me.txtCIPaciente.MaxLength = 8
        Me.txtCIPaciente.Name = "txtCIPaciente"
        Me.txtCIPaciente.Size = New System.Drawing.Size(239, 30)
        Me.txtCIPaciente.TabIndex = 99
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(778, 9)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(93, 34)
        Me.btnBuscar.TabIndex = 100
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Identificacion_Paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 555)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtCIPaciente)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblDireccionTXT)
        Me.Controls.Add(Me.lblEstadoCivil)
        Me.Controls.Add(Me.lblEstadoCivilTXT)
        Me.Controls.Add(Me.lblOcupacion)
        Me.Controls.Add(Me.lblOcupacionTXT)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblSexoTXT)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.lblEdadTXT)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblTelefonoTXT)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombres)
        Me.Controls.Add(Me.lblApellidosTXT)
        Me.Controls.Add(Me.lblNombresTXT)
        Me.Controls.Add(Me.pBoxFotoPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Identificacion_Paciente"
        Me.Text = "frmConsultaConPaciente"
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblDireccionTXT As Label
    Friend WithEvents lblEstadoCivil As Label
    Friend WithEvents lblEstadoCivilTXT As Label
    Friend WithEvents lblOcupacion As Label
    Friend WithEvents lblOcupacionTXT As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblSexoTXT As Label
    Friend WithEvents lblEdad As Label
    Friend WithEvents lblEdadTXT As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblTelefonoTXT As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblApellidosTXT As Label
    Friend WithEvents lblNombresTXT As Label
    Friend WithEvents pBoxFotoPaciente As PictureBox
    Public WithEvents txtCIPaciente As TextBox
    Public WithEvents btnBuscar As Button
End Class
