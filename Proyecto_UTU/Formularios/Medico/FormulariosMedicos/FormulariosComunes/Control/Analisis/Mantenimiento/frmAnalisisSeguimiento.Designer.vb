<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalisisSeguimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalisisSeguimiento))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblCedulaPaciente = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnConsultarDatos = New System.Windows.Forms.Button()
        Me.btnIngresarDatos = New System.Windows.Forms.Button()
        Me.dgwAnalisisPaciente = New System.Windows.Forms.DataGridView()
        Me.ID_analisis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_analisis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_analisis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlContenedor.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgwAnalisisPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.TableLayoutPanel2)
        Me.pnlContenedor.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlContenedor.Controls.Add(Me.dgwAnalisisPaciente)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1130, 720)
        Me.pnlContenedor.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.73874!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.58559!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.585586!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtBuscar, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnBuscar, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCedulaPaciente, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(8, 12)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1110, 37)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'txtBuscar
        '
        Me.txtBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(211, 3)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(833, 30)
        Me.txtBuscar.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBuscar.Location = New System.Drawing.Point(1050, 3)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(57, 31)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblCedulaPaciente
        '
        Me.lblCedulaPaciente.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblCedulaPaciente.AutoSize = True
        Me.lblCedulaPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedulaPaciente.Location = New System.Drawing.Point(14, 6)
        Me.lblCedulaPaciente.Name = "lblCedulaPaciente"
        Me.lblCedulaPaciente.Size = New System.Drawing.Size(191, 25)
        Me.lblCedulaPaciente.TabIndex = 2
        Me.lblCedulaPaciente.Text = "Cédula del paciente:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnConsultarDatos, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnIngresarDatos, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 511)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1130, 209)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'btnConsultarDatos
        '
        Me.btnConsultarDatos.BackColor = System.Drawing.Color.PaleGreen
        Me.btnConsultarDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConsultarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultarDatos.Image = CType(resources.GetObject("btnConsultarDatos.Image"), System.Drawing.Image)
        Me.btnConsultarDatos.Location = New System.Drawing.Point(3, 3)
        Me.btnConsultarDatos.Name = "btnConsultarDatos"
        Me.btnConsultarDatos.Size = New System.Drawing.Size(559, 203)
        Me.btnConsultarDatos.TabIndex = 5
        Me.btnConsultarDatos.Text = "Consultar datos"
        Me.btnConsultarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultarDatos.UseVisualStyleBackColor = False
        '
        'btnIngresarDatos
        '
        Me.btnIngresarDatos.BackColor = System.Drawing.Color.PaleGreen
        Me.btnIngresarDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnIngresarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarDatos.Image = CType(resources.GetObject("btnIngresarDatos.Image"), System.Drawing.Image)
        Me.btnIngresarDatos.Location = New System.Drawing.Point(568, 3)
        Me.btnIngresarDatos.Name = "btnIngresarDatos"
        Me.btnIngresarDatos.Size = New System.Drawing.Size(559, 203)
        Me.btnIngresarDatos.TabIndex = 4
        Me.btnIngresarDatos.Text = "Ingresar datos"
        Me.btnIngresarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIngresarDatos.UseVisualStyleBackColor = False
        '
        'dgwAnalisisPaciente
        '
        Me.dgwAnalisisPaciente.AllowUserToAddRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgwAnalisisPaciente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgwAnalisisPaciente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwAnalisisPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwAnalisisPaciente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgwAnalisisPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwAnalisisPaciente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_analisis, Me.nom_analisis, Me.fecha_analisis})
        Me.dgwAnalisisPaciente.Location = New System.Drawing.Point(3, 65)
        Me.dgwAnalisisPaciente.Name = "dgwAnalisisPaciente"
        Me.dgwAnalisisPaciente.RowHeadersWidth = 51
        Me.dgwAnalisisPaciente.RowTemplate.Height = 24
        Me.dgwAnalisisPaciente.Size = New System.Drawing.Size(1124, 440)
        Me.dgwAnalisisPaciente.TabIndex = 2
        '
        'ID_analisis
        '
        Me.ID_analisis.HeaderText = "ID del análisis"
        Me.ID_analisis.MinimumWidth = 6
        Me.ID_analisis.Name = "ID_analisis"
        '
        'nom_analisis
        '
        Me.nom_analisis.HeaderText = "Nombre"
        Me.nom_analisis.MinimumWidth = 6
        Me.nom_analisis.Name = "nom_analisis"
        '
        'fecha_analisis
        '
        Me.fecha_analisis.HeaderText = "Fecha"
        Me.fecha_analisis.MinimumWidth = 6
        Me.fecha_analisis.Name = "fecha_analisis"
        '
        'frmAnalisisSeguimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1130, 720)
        Me.Controls.Add(Me.pnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAnalisisSeguimiento"
        Me.Text = "frmAnalisisSeguimiento"
        Me.pnlContenedor.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgwAnalisisPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents dgwAnalisisPaciente As DataGridView
    Friend WithEvents ID_analisis As DataGridViewTextBoxColumn
    Friend WithEvents nom_analisis As DataGridViewTextBoxColumn
    Friend WithEvents fecha_analisis As DataGridViewTextBoxColumn
    Friend WithEvents btnIngresarDatos As Button
    Friend WithEvents btnConsultarDatos As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblCedulaPaciente As Label
End Class
