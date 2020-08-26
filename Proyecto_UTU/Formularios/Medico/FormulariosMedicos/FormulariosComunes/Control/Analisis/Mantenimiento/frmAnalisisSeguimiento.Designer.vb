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
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnConsultarDatos = New System.Windows.Forms.Button()
        Me.btnIngresarDatos = New System.Windows.Forms.Button()
        Me.dgwAnalisisPaciente = New System.Windows.Forms.DataGridView()
        Me.ID_analisis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_analisis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_analisis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCedulaPaciente = New System.Windows.Forms.TextBox()
        Me.lblPacienteCI = New System.Windows.Forms.Label()
        Me.pnlContenedor.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgwAnalisisPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlContenedor.Controls.Add(Me.dgwAnalisisPaciente)
        Me.pnlContenedor.Controls.Add(Me.txtCedulaPaciente)
        Me.pnlContenedor.Controls.Add(Me.lblPacienteCI)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1130, 720)
        Me.pnlContenedor.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnConsultarDatos, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnIngresarDatos, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 511)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1110, 197)
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
        Me.btnConsultarDatos.Size = New System.Drawing.Size(549, 191)
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
        Me.btnIngresarDatos.Location = New System.Drawing.Point(558, 3)
        Me.btnIngresarDatos.Name = "btnIngresarDatos"
        Me.btnIngresarDatos.Size = New System.Drawing.Size(549, 191)
        Me.btnIngresarDatos.TabIndex = 4
        Me.btnIngresarDatos.Text = "Ingresar datos"
        Me.btnIngresarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIngresarDatos.UseVisualStyleBackColor = False
        '
        'dgwAnalisisPaciente
        '
        Me.dgwAnalisisPaciente.AllowUserToAddRows = False
        Me.dgwAnalisisPaciente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwAnalisisPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwAnalisisPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwAnalisisPaciente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_analisis, Me.nom_analisis, Me.fecha_analisis})
        Me.dgwAnalisisPaciente.Location = New System.Drawing.Point(8, 65)
        Me.dgwAnalisisPaciente.Name = "dgwAnalisisPaciente"
        Me.dgwAnalisisPaciente.RowHeadersWidth = 51
        Me.dgwAnalisisPaciente.RowTemplate.Height = 24
        Me.dgwAnalisisPaciente.Size = New System.Drawing.Size(1110, 440)
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
        'txtCedulaPaciente
        '
        Me.txtCedulaPaciente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCedulaPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedulaPaciente.Location = New System.Drawing.Point(875, 12)
        Me.txtCedulaPaciente.Name = "txtCedulaPaciente"
        Me.txtCedulaPaciente.Size = New System.Drawing.Size(243, 34)
        Me.txtCedulaPaciente.TabIndex = 1
        '
        'lblPacienteCI
        '
        Me.lblPacienteCI.AutoSize = True
        Me.lblPacienteCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPacienteCI.Location = New System.Drawing.Point(3, 17)
        Me.lblPacienteCI.Name = "lblPacienteCI"
        Me.lblPacienteCI.Size = New System.Drawing.Size(866, 29)
        Me.lblPacienteCI.TabIndex = 0
        Me.lblPacienteCI.Text = "Ingrese la cédula de identidad del paciente del cuál desea consultar un análisis:" &
    ""
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
        Me.pnlContenedor.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgwAnalisisPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents txtCedulaPaciente As TextBox
    Friend WithEvents lblPacienteCI As Label
    Friend WithEvents dgwAnalisisPaciente As DataGridView
    Friend WithEvents ID_analisis As DataGridViewTextBoxColumn
    Friend WithEvents nom_analisis As DataGridViewTextBoxColumn
    Friend WithEvents fecha_analisis As DataGridViewTextBoxColumn
    Friend WithEvents btnIngresarDatos As Button
    Friend WithEvents btnConsultarDatos As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
