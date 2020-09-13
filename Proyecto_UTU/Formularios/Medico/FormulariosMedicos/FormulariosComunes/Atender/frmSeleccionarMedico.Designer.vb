<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionarMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeleccionarMedico))
        Me.tblDatosMedico = New System.Windows.Forms.TableLayoutPanel()
        Me.pBoxFotoMedico = New System.Windows.Forms.PictureBox()
        Me.tabDatos = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblNombresTXT = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblApellidosTXT = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEspecialidadTXT = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuscarMedico = New System.Windows.Forms.Button()
        Me.txtCIMedico = New System.Windows.Forms.TextBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.tblNomRef = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNomReferencia = New System.Windows.Forms.Label()
        Me.txtNomConsulta = New System.Windows.Forms.TextBox()
        Me.tblDatosMedico.SuspendLayout()
        CType(Me.pBoxFotoMedico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDatos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tblNomRef.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblDatosMedico
        '
        Me.tblDatosMedico.AutoSize = True
        Me.tblDatosMedico.BackColor = System.Drawing.Color.LightBlue
        Me.tblDatosMedico.ColumnCount = 2
        Me.tblDatosMedico.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDatosMedico.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDatosMedico.Controls.Add(Me.pBoxFotoMedico, 0, 0)
        Me.tblDatosMedico.Controls.Add(Me.tabDatos, 1, 0)
        Me.tblDatosMedico.Location = New System.Drawing.Point(0, 0)
        Me.tblDatosMedico.Name = "tblDatosMedico"
        Me.tblDatosMedico.RowCount = 1
        Me.tblDatosMedico.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDatosMedico.Size = New System.Drawing.Size(1020, 544)
        Me.tblDatosMedico.TabIndex = 1
        '
        'pBoxFotoMedico
        '
        Me.pBoxFotoMedico.BackgroundImage = CType(resources.GetObject("pBoxFotoMedico.BackgroundImage"), System.Drawing.Image)
        Me.pBoxFotoMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pBoxFotoMedico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBoxFotoMedico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBoxFotoMedico.Location = New System.Drawing.Point(3, 3)
        Me.pBoxFotoMedico.Name = "pBoxFotoMedico"
        Me.pBoxFotoMedico.Size = New System.Drawing.Size(504, 538)
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
        Me.tabDatos.Controls.Add(Me.lblNombres, 0, 1)
        Me.tabDatos.Controls.Add(Me.lblNombresTXT, 1, 1)
        Me.tabDatos.Controls.Add(Me.lblApellido, 0, 2)
        Me.tabDatos.Controls.Add(Me.lblApellidosTXT, 1, 2)
        Me.tabDatos.Controls.Add(Me.Label1, 0, 3)
        Me.tabDatos.Controls.Add(Me.lblEspecialidadTXT, 1, 3)
        Me.tabDatos.Controls.Add(Me.Panel1, 1, 0)
        Me.tabDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDatos.Location = New System.Drawing.Point(513, 3)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.RowCount = 4
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tabDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tabDatos.Size = New System.Drawing.Size(504, 538)
        Me.tabDatos.TabIndex = 103
        '
        'lblCedula
        '
        Me.lblCedula.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(49, 57)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(66, 20)
        Me.lblCedula.TabIndex = 82
        Me.lblCedula.Text = "Cédula:"
        '
        'lblNombres
        '
        Me.lblNombres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.Location = New System.Drawing.Point(46, 191)
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
        Me.lblNombresTXT.Location = New System.Drawing.Point(239, 191)
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
        Me.lblApellido.Location = New System.Drawing.Point(46, 325)
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
        Me.lblApellidosTXT.Location = New System.Drawing.Point(230, 325)
        Me.lblApellidosTXT.Name = "lblApellidosTXT"
        Me.lblApellidosTXT.Size = New System.Drawing.Size(208, 20)
        Me.lblApellidosTXT.TabIndex = 79
        Me.lblApellidosTXT.Text = "APELLIDO 1 APELLIDO 2"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 460)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Especialidad:"
        '
        'lblEspecialidadTXT
        '
        Me.lblEspecialidadTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEspecialidadTXT.AutoSize = True
        Me.lblEspecialidadTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspecialidadTXT.Location = New System.Drawing.Point(282, 460)
        Me.lblEspecialidadTXT.Name = "lblEspecialidadTXT"
        Me.lblEspecialidadTXT.Size = New System.Drawing.Size(104, 20)
        Me.lblEspecialidadTXT.TabIndex = 101
        Me.lblEspecialidadTXT.Text = "Especialidad"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnBuscarMedico)
        Me.Panel1.Controls.Add(Me.txtCIMedico)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(168, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(333, 128)
        Me.Panel1.TabIndex = 103
        '
        'btnBuscarMedico
        '
        Me.btnBuscarMedico.BackgroundImage = CType(resources.GetObject("btnBuscarMedico.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscarMedico.Location = New System.Drawing.Point(288, 52)
        Me.btnBuscarMedico.Name = "btnBuscarMedico"
        Me.btnBuscarMedico.Size = New System.Drawing.Size(43, 30)
        Me.btnBuscarMedico.TabIndex = 105
        Me.btnBuscarMedico.UseVisualStyleBackColor = True
        '
        'txtCIMedico
        '
        Me.txtCIMedico.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCIMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCIMedico.Location = New System.Drawing.Point(3, 52)
        Me.txtCIMedico.MaxLength = 8
        Me.txtCIMedico.Name = "txtCIMedico"
        Me.txtCIMedico.Size = New System.Drawing.Size(281, 30)
        Me.txtCIMedico.TabIndex = 104
        Me.txtCIMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnConfirmar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Location = New System.Drawing.Point(0, 592)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(1020, 64)
        Me.btnConfirmar.TabIndex = 4
        Me.btnConfirmar.Text = "CONFIRMAR"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'tblNomRef
        '
        Me.tblNomRef.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tblNomRef.ColumnCount = 2
        Me.tblNomRef.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.80392!))
        Me.tblNomRef.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.19608!))
        Me.tblNomRef.Controls.Add(Me.lblNomReferencia, 0, 0)
        Me.tblNomRef.Controls.Add(Me.txtNomConsulta, 1, 0)
        Me.tblNomRef.Location = New System.Drawing.Point(0, 550)
        Me.tblNomRef.Name = "tblNomRef"
        Me.tblNomRef.RowCount = 1
        Me.tblNomRef.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblNomRef.Size = New System.Drawing.Size(1020, 39)
        Me.tblNomRef.TabIndex = 5
        '
        'lblNomReferencia
        '
        Me.lblNomReferencia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNomReferencia.AutoSize = True
        Me.lblNomReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomReferencia.Location = New System.Drawing.Point(33, 7)
        Me.lblNomReferencia.Name = "lblNomReferencia"
        Me.lblNomReferencia.Size = New System.Drawing.Size(441, 25)
        Me.lblNomReferencia.TabIndex = 2
        Me.lblNomReferencia.Text = "Ingrese un nombre de referencia para la consulta:"
        '
        'txtNomConsulta
        '
        Me.txtNomConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomConsulta.Location = New System.Drawing.Point(510, 3)
        Me.txtNomConsulta.Name = "txtNomConsulta"
        Me.txtNomConsulta.Size = New System.Drawing.Size(507, 30)
        Me.txtNomConsulta.TabIndex = 3
        '
        'frmSeleccionarMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1020, 656)
        Me.Controls.Add(Me.tblNomRef)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.tblDatosMedico)
        Me.Name = "frmSeleccionarMedico"
        Me.Text = "frmSeleccionarMedico"
        Me.tblDatosMedico.ResumeLayout(False)
        CType(Me.pBoxFotoMedico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDatos.ResumeLayout(False)
        Me.tabDatos.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tblNomRef.ResumeLayout(False)
        Me.tblNomRef.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tblDatosMedico As TableLayoutPanel
    Friend WithEvents pBoxFotoMedico As PictureBox
    Friend WithEvents tabDatos As TableLayoutPanel
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblNombresTXT As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblApellidosTXT As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEspecialidadTXT As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBuscarMedico As Button
    Friend WithEvents txtCIMedico As TextBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents tblNomRef As TableLayoutPanel
    Friend WithEvents lblNomReferencia As Label
    Friend WithEvents txtNomConsulta As TextBox
End Class
