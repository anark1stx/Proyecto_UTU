<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionPaciente))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pBoxFotoPaciente = New System.Windows.Forms.PictureBox()
        Me.tabDatos = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblCedulaTXT = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblNombresTXT = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblApellidosTXT = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblDireccionTXT = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.lblFechaNacTXT = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblSexoTXT = New System.Windows.Forms.Label()
        Me.lblOcupacion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblE_Civil = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEtapa = New System.Windows.Forms.Label()
        Me.lblEtapaTXT = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.54464!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.45536!))
        Me.TableLayoutPanel1.Controls.Add(Me.pBoxFotoPaciente, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tabDatos, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(896, 551)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'pBoxFotoPaciente
        '
        Me.pBoxFotoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBoxFotoPaciente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBoxFotoPaciente.Image = CType(resources.GetObject("pBoxFotoPaciente.Image"), System.Drawing.Image)
        Me.pBoxFotoPaciente.Location = New System.Drawing.Point(3, 3)
        Me.pBoxFotoPaciente.Name = "pBoxFotoPaciente"
        Me.pBoxFotoPaciente.Size = New System.Drawing.Size(420, 545)
        Me.pBoxFotoPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxFotoPaciente.TabIndex = 101
        Me.pBoxFotoPaciente.TabStop = False
        '
        'tabDatos
        '
        Me.tabDatos.ColumnCount = 2
        Me.tabDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.71552!))
        Me.tabDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.28448!))
        Me.tabDatos.Controls.Add(Me.Label1, 0, 5)
        Me.tabDatos.Controls.Add(Me.lblCedula, 0, 0)
        Me.tabDatos.Controls.Add(Me.lblCedulaTXT, 1, 0)
        Me.tabDatos.Controls.Add(Me.lblNombres, 0, 1)
        Me.tabDatos.Controls.Add(Me.lblNombresTXT, 1, 1)
        Me.tabDatos.Controls.Add(Me.lblApellido, 0, 2)
        Me.tabDatos.Controls.Add(Me.lblApellidosTXT, 1, 2)
        Me.tabDatos.Controls.Add(Me.lblDireccion, 0, 3)
        Me.tabDatos.Controls.Add(Me.lblDireccionTXT, 1, 3)
        Me.tabDatos.Controls.Add(Me.lblTelefono, 0, 5)
        Me.tabDatos.Controls.Add(Me.lblFechaNac, 0, 4)
        Me.tabDatos.Controls.Add(Me.lblFechaNacTXT, 1, 4)
        Me.tabDatos.Controls.Add(Me.lblSexo, 0, 6)
        Me.tabDatos.Controls.Add(Me.lblSexoTXT, 1, 6)
        Me.tabDatos.Controls.Add(Me.lblOcupacion, 0, 7)
        Me.tabDatos.Controls.Add(Me.Label2, 1, 7)
        Me.tabDatos.Controls.Add(Me.lblE_Civil, 0, 8)
        Me.tabDatos.Controls.Add(Me.Label3, 1, 8)
        Me.tabDatos.Controls.Add(Me.lblEtapa, 0, 9)
        Me.tabDatos.Controls.Add(Me.lblEtapaTXT, 1, 9)
        Me.tabDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDatos.Location = New System.Drawing.Point(429, 3)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.RowCount = 10
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabDatos.Size = New System.Drawing.Size(464, 545)
        Me.tabDatos.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 24)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Teléfono(s):"
        '
        'lblCedula
        '
        Me.lblCedula.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(50, 15)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(75, 24)
        Me.lblCedula.TabIndex = 82
        Me.lblCedula.Text = "Cédula:"
        '
        'lblCedulaTXT
        '
        Me.lblCedulaTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCedulaTXT.AutoSize = True
        Me.lblCedulaTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedulaTXT.Location = New System.Drawing.Point(284, 15)
        Me.lblCedulaTXT.Name = "lblCedulaTXT"
        Me.lblCedulaTXT.Size = New System.Drawing.Size(70, 24)
        Me.lblCedulaTXT.TabIndex = 99
        Me.lblCedulaTXT.Text = "Cédula"
        '
        'lblNombres
        '
        Me.lblNombres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.Location = New System.Drawing.Point(45, 69)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(84, 24)
        Me.lblNombres.TabIndex = 80
        Me.lblNombres.Text = "Nombre:"
        '
        'lblNombresTXT
        '
        Me.lblNombresTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNombresTXT.AutoSize = True
        Me.lblNombresTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombresTXT.Location = New System.Drawing.Point(214, 69)
        Me.lblNombresTXT.Name = "lblNombresTXT"
        Me.lblNombresTXT.Size = New System.Drawing.Size(211, 24)
        Me.lblNombresTXT.TabIndex = 78
        Me.lblNombresTXT.Text = "NOMBRE 1 NOMBRE 2"
        '
        'lblApellido
        '
        Me.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(45, 123)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(84, 24)
        Me.lblApellido.TabIndex = 81
        Me.lblApellido.Text = "Apellido:"
        '
        'lblApellidosTXT
        '
        Me.lblApellidosTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblApellidosTXT.AutoSize = True
        Me.lblApellidosTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosTXT.Location = New System.Drawing.Point(207, 123)
        Me.lblApellidosTXT.Name = "lblApellidosTXT"
        Me.lblApellidosTXT.Size = New System.Drawing.Size(225, 24)
        Me.lblApellidosTXT.TabIndex = 79
        Me.lblApellidosTXT.Text = "APELLIDO 1 APELLIDO 2"
        '
        'lblDireccion
        '
        Me.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(40, 177)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(95, 24)
        Me.lblDireccion.TabIndex = 98
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblDireccionTXT
        '
        Me.lblDireccionTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDireccionTXT.AutoSize = True
        Me.lblDireccionTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionTXT.Location = New System.Drawing.Point(274, 177)
        Me.lblDireccionTXT.Name = "lblDireccionTXT"
        Me.lblDireccionTXT.Size = New System.Drawing.Size(90, 24)
        Me.lblDireccionTXT.TabIndex = 97
        Me.lblDireccionTXT.Text = "Dirección"
        '
        'lblTelefono
        '
        Me.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(264, 285)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(111, 24)
        Me.lblTelefono.TabIndex = 84
        Me.lblTelefono.Text = "Teléfono(s):"
        '
        'lblFechaNac
        '
        Me.lblFechaNac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNac.Location = New System.Drawing.Point(3, 231)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(169, 24)
        Me.lblFechaNac.TabIndex = 101
        Me.lblFechaNac.Text = "Fecha Nacimiento:"
        '
        'lblFechaNacTXT
        '
        Me.lblFechaNacTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFechaNacTXT.AutoSize = True
        Me.lblFechaNacTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacTXT.Location = New System.Drawing.Point(240, 231)
        Me.lblFechaNacTXT.Name = "lblFechaNacTXT"
        Me.lblFechaNacTXT.Size = New System.Drawing.Size(159, 24)
        Me.lblFechaNacTXT.TabIndex = 102
        Me.lblFechaNacTXT.Text = "FechaNacimiento"
        '
        'lblSexo
        '
        Me.lblSexo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(58, 339)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(59, 24)
        Me.lblSexo.TabIndex = 103
        Me.lblSexo.Text = "Sexo:"
        '
        'lblSexoTXT
        '
        Me.lblSexoTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSexoTXT.AutoSize = True
        Me.lblSexoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexoTXT.Location = New System.Drawing.Point(292, 339)
        Me.lblSexoTXT.Name = "lblSexoTXT"
        Me.lblSexoTXT.Size = New System.Drawing.Size(54, 24)
        Me.lblSexoTXT.TabIndex = 104
        Me.lblSexoTXT.Text = "Sexo"
        '
        'lblOcupacion
        '
        Me.lblOcupacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOcupacion.AutoSize = True
        Me.lblOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacion.Location = New System.Drawing.Point(33, 393)
        Me.lblOcupacion.Name = "lblOcupacion"
        Me.lblOcupacion.Size = New System.Drawing.Size(108, 24)
        Me.lblOcupacion.TabIndex = 105
        Me.lblOcupacion.Text = "Ocupación:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(268, 393)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 24)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Ocupacion"
        '
        'lblE_Civil
        '
        Me.lblE_Civil.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblE_Civil.AutoSize = True
        Me.lblE_Civil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE_Civil.Location = New System.Drawing.Point(31, 447)
        Me.lblE_Civil.Name = "lblE_Civil"
        Me.lblE_Civil.Size = New System.Drawing.Size(112, 24)
        Me.lblE_Civil.TabIndex = 107
        Me.lblE_Civil.Text = "Estado Civil:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(268, 447)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 24)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "EstadoCivil"
        '
        'lblEtapa
        '
        Me.lblEtapa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEtapa.AutoSize = True
        Me.lblEtapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtapa.Location = New System.Drawing.Point(56, 503)
        Me.lblEtapa.Name = "lblEtapa"
        Me.lblEtapa.Size = New System.Drawing.Size(63, 24)
        Me.lblEtapa.TabIndex = 109
        Me.lblEtapa.Text = "Etapa:"
        '
        'lblEtapaTXT
        '
        Me.lblEtapaTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEtapaTXT.AutoSize = True
        Me.lblEtapaTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtapaTXT.Location = New System.Drawing.Point(290, 503)
        Me.lblEtapaTXT.Name = "lblEtapaTXT"
        Me.lblEtapaTXT.Size = New System.Drawing.Size(58, 24)
        Me.lblEtapaTXT.TabIndex = 110
        Me.lblEtapaTXT.Text = "Etapa"
        '
        'frmGestionPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 551)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGestionPaciente"
        Me.Text = "frmGestionPaciente"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDatos.ResumeLayout(False)
        Me.tabDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents pBoxFotoPaciente As PictureBox
    Friend WithEvents tabDatos As TableLayoutPanel
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblCedulaTXT As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblNombresTXT As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblApellidosTXT As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblDireccionTXT As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents lblFechaNacTXT As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblSexoTXT As Label
    Friend WithEvents lblOcupacion As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblE_Civil As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblEtapa As Label
    Friend WithEvents lblEtapaTXT As Label
End Class
