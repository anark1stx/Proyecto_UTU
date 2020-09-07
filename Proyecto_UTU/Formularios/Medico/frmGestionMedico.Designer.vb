<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestionMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionMedico))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pBoxFotoMedico = New System.Windows.Forms.PictureBox()
        Me.tabDatos = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblCedulaTXT = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblNombresTXT = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblApellidosTXT = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblDireccionTXT = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblTelefonoTXT = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pBoxFotoMedico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pBoxFotoMedico, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tabDatos, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(896, 555)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'pBoxFotoMedico
        '
        Me.pBoxFotoMedico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBoxFotoMedico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBoxFotoMedico.Image = CType(resources.GetObject("pBoxFotoMedico.Image"), System.Drawing.Image)
        Me.pBoxFotoMedico.Location = New System.Drawing.Point(3, 3)
        Me.pBoxFotoMedico.Name = "pBoxFotoMedico"
        Me.pBoxFotoMedico.Size = New System.Drawing.Size(442, 549)
        Me.pBoxFotoMedico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxFotoMedico.TabIndex = 101
        Me.pBoxFotoMedico.TabStop = False
        '
        'tabDatos
        '
        Me.tabDatos.ColumnCount = 2
        Me.tabDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.88591!))
        Me.tabDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.1141!))
        Me.tabDatos.Controls.Add(Me.lblCedula, 0, 0)
        Me.tabDatos.Controls.Add(Me.lblCedulaTXT, 1, 0)
        Me.tabDatos.Controls.Add(Me.lblNombres, 0, 1)
        Me.tabDatos.Controls.Add(Me.lblNombresTXT, 1, 1)
        Me.tabDatos.Controls.Add(Me.lblApellido, 0, 2)
        Me.tabDatos.Controls.Add(Me.lblApellidosTXT, 1, 2)
        Me.tabDatos.Controls.Add(Me.lblDireccion, 0, 3)
        Me.tabDatos.Controls.Add(Me.lblDireccionTXT, 1, 3)
        Me.tabDatos.Controls.Add(Me.lblTelefono, 0, 4)
        Me.tabDatos.Controls.Add(Me.lblTelefonoTXT, 1, 4)
        Me.tabDatos.Controls.Add(Me.Label1, 0, 5)
        Me.tabDatos.Controls.Add(Me.Label2, 1, 5)
        Me.tabDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDatos.Location = New System.Drawing.Point(451, 3)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.RowCount = 6
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tabDatos.Size = New System.Drawing.Size(442, 549)
        Me.tabDatos.TabIndex = 103
        '
        'lblCedula
        '
        Me.lblCedula.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(39, 35)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(66, 20)
        Me.lblCedula.TabIndex = 82
        Me.lblCedula.Text = "Cédula:"
        '
        'lblCedulaTXT
        '
        Me.lblCedulaTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCedulaTXT.AutoSize = True
        Me.lblCedulaTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedulaTXT.Location = New System.Drawing.Point(263, 35)
        Me.lblCedulaTXT.Name = "lblCedulaTXT"
        Me.lblCedulaTXT.Size = New System.Drawing.Size(61, 20)
        Me.lblCedulaTXT.TabIndex = 99
        Me.lblCedulaTXT.Text = "Cédula"
        '
        'lblNombres
        '
        Me.lblNombres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.Location = New System.Drawing.Point(36, 126)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(73, 20)
        Me.lblNombres.TabIndex = 80
        Me.lblNombres.Text = "Nombre:"
        '
        'lblNombresTXT
        '
        Me.lblNombresTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNombresTXT.AutoSize = True
        Me.lblNombresTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombresTXT.Location = New System.Drawing.Point(198, 126)
        Me.lblNombresTXT.Name = "lblNombresTXT"
        Me.lblNombresTXT.Size = New System.Drawing.Size(190, 20)
        Me.lblNombresTXT.TabIndex = 78
        Me.lblNombresTXT.Text = "NOMBRE 1 NOMBRE 2"
        '
        'lblApellido
        '
        Me.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(36, 217)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(73, 20)
        Me.lblApellido.TabIndex = 81
        Me.lblApellido.Text = "Apellido:"
        '
        'lblApellidosTXT
        '
        Me.lblApellidosTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblApellidosTXT.AutoSize = True
        Me.lblApellidosTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosTXT.Location = New System.Drawing.Point(189, 217)
        Me.lblApellidosTXT.Name = "lblApellidosTXT"
        Me.lblApellidosTXT.Size = New System.Drawing.Size(208, 20)
        Me.lblApellidosTXT.TabIndex = 79
        Me.lblApellidosTXT.Text = "APELLIDO 1 APELLIDO 2"
        '
        'lblDireccion
        '
        Me.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(29, 308)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(86, 20)
        Me.lblDireccion.TabIndex = 98
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblDireccionTXT
        '
        Me.lblDireccionTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDireccionTXT.AutoSize = True
        Me.lblDireccionTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionTXT.Location = New System.Drawing.Point(253, 308)
        Me.lblDireccionTXT.Name = "lblDireccionTXT"
        Me.lblDireccionTXT.Size = New System.Drawing.Size(81, 20)
        Me.lblDireccionTXT.TabIndex = 97
        Me.lblDireccionTXT.Text = "Dirección"
        '
        'lblTelefono
        '
        Me.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(23, 399)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(99, 20)
        Me.lblTelefono.TabIndex = 84
        Me.lblTelefono.Text = "Teléfono(s):"
        '
        'lblTelefonoTXT
        '
        Me.lblTelefonoTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTelefonoTXT.AutoSize = True
        Me.lblTelefonoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoTXT.Location = New System.Drawing.Point(239, 399)
        Me.lblTelefonoTXT.Name = "lblTelefonoTXT"
        Me.lblTelefonoTXT.Size = New System.Drawing.Size(108, 20)
        Me.lblTelefonoTXT.TabIndex = 83
        Me.lblTelefonoTXT.Text = "TELEFONO1"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 492)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Especialidad:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(241, 492)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Especialidad"
        '
        'frmGestionMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 555)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGestionMedico"
        Me.Text = "frmGestion"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.pBoxFotoMedico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDatos.ResumeLayout(False)
        Me.tabDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents pBoxFotoMedico As PictureBox
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
    Friend WithEvents lblTelefonoTXT As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
