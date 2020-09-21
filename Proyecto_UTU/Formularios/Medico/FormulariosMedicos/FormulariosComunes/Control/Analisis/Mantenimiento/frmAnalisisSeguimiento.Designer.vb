<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAnalisisSeguimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalisisSeguimiento))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblCedulaPaciente = New System.Windows.Forms.Label()
        Me.tblAcciones = New System.Windows.Forms.TableLayoutPanel()
        Me.btnConsultarDatos = New System.Windows.Forms.Button()
        Me.btnIngresarDatos = New System.Windows.Forms.Button()
        Me.dgwAnalisisPaciente = New System.Windows.Forms.DataGridView()
        Me.pnlContenedor.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tblAcciones.SuspendLayout()
        CType(Me.dgwAnalisisPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.TableLayoutPanel2)
        Me.pnlContenedor.Controls.Add(Me.tblAcciones)
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
        Me.lblCedulaPaciente.AutoSize = True
        Me.lblCedulaPaciente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCedulaPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedulaPaciente.Location = New System.Drawing.Point(3, 0)
        Me.lblCedulaPaciente.Name = "lblCedulaPaciente"
        Me.lblCedulaPaciente.Size = New System.Drawing.Size(202, 37)
        Me.lblCedulaPaciente.TabIndex = 2
        Me.lblCedulaPaciente.Text = "Cédula del paciente:"
        Me.lblCedulaPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tblAcciones
        '
        Me.tblAcciones.ColumnCount = 2
        Me.tblAcciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblAcciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblAcciones.Controls.Add(Me.btnConsultarDatos, 0, 0)
        Me.tblAcciones.Controls.Add(Me.btnIngresarDatos, 1, 0)
        Me.tblAcciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tblAcciones.Location = New System.Drawing.Point(0, 511)
        Me.tblAcciones.Name = "tblAcciones"
        Me.tblAcciones.RowCount = 1
        Me.tblAcciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblAcciones.Size = New System.Drawing.Size(1130, 209)
        Me.tblAcciones.TabIndex = 6
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
        Me.dgwAnalisisPaciente.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgwAnalisisPaciente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgwAnalisisPaciente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwAnalisisPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwAnalisisPaciente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgwAnalisisPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwAnalisisPaciente.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgwAnalisisPaciente.Location = New System.Drawing.Point(3, 65)
        Me.dgwAnalisisPaciente.MultiSelect = False
        Me.dgwAnalisisPaciente.Name = "dgwAnalisisPaciente"
        Me.dgwAnalisisPaciente.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwAnalisisPaciente.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgwAnalisisPaciente.RowHeadersWidth = 51
        Me.dgwAnalisisPaciente.RowTemplate.Height = 24
        Me.dgwAnalisisPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwAnalisisPaciente.Size = New System.Drawing.Size(1124, 440)
        Me.dgwAnalisisPaciente.TabIndex = 2
        '
        'frmAnalisisSeguimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1130, 720)
        Me.Controls.Add(Me.pnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAnalisisSeguimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAnalisisSeguimiento"
        Me.pnlContenedor.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.tblAcciones.ResumeLayout(False)
        CType(Me.dgwAnalisisPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents dgwAnalisisPaciente As DataGridView
    Friend WithEvents btnIngresarDatos As Button
    Friend WithEvents btnConsultarDatos As Button
    Friend WithEvents tblAcciones As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblCedulaPaciente As Label
End Class
