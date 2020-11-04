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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        resources.ApplyResources(Me.pnlContenedor, "pnlContenedor")
        Me.pnlContenedor.Name = "pnlContenedor"
        '
        'TableLayoutPanel2
        '
        resources.ApplyResources(Me.TableLayoutPanel2, "TableLayoutPanel2")
        Me.TableLayoutPanel2.Controls.Add(Me.txtBuscar, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnBuscar, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCedulaPaciente, 0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        '
        'txtBuscar
        '
        resources.ApplyResources(Me.txtBuscar, "txtBuscar")
        Me.txtBuscar.Name = "txtBuscar"
        '
        'btnBuscar
        '
        resources.ApplyResources(Me.btnBuscar, "btnBuscar")
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblCedulaPaciente
        '
        resources.ApplyResources(Me.lblCedulaPaciente, "lblCedulaPaciente")
        Me.lblCedulaPaciente.Name = "lblCedulaPaciente"
        '
        'tblAcciones
        '
        resources.ApplyResources(Me.tblAcciones, "tblAcciones")
        Me.tblAcciones.Controls.Add(Me.btnConsultarDatos, 0, 0)
        Me.tblAcciones.Controls.Add(Me.btnIngresarDatos, 1, 0)
        Me.tblAcciones.Name = "tblAcciones"
        '
        'btnConsultarDatos
        '
        Me.btnConsultarDatos.BackColor = System.Drawing.Color.PaleGreen
        resources.ApplyResources(Me.btnConsultarDatos, "btnConsultarDatos")
        Me.btnConsultarDatos.Name = "btnConsultarDatos"
        Me.btnConsultarDatos.UseVisualStyleBackColor = False
        '
        'btnIngresarDatos
        '
        Me.btnIngresarDatos.BackColor = System.Drawing.Color.PaleGreen
        resources.ApplyResources(Me.btnIngresarDatos, "btnIngresarDatos")
        Me.btnIngresarDatos.Name = "btnIngresarDatos"
        Me.btnIngresarDatos.UseVisualStyleBackColor = False
        '
        'dgwAnalisisPaciente
        '
        Me.dgwAnalisisPaciente.AllowUserToAddRows = False
        Me.dgwAnalisisPaciente.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgwAnalisisPaciente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.dgwAnalisisPaciente, "dgwAnalisisPaciente")
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwAnalisisPaciente.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgwAnalisisPaciente.MultiSelect = False
        Me.dgwAnalisisPaciente.Name = "dgwAnalisisPaciente"
        Me.dgwAnalisisPaciente.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwAnalisisPaciente.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgwAnalisisPaciente.RowTemplate.Height = 24
        Me.dgwAnalisisPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'frmAnalisisSeguimiento
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.pnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAnalisisSeguimiento"
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
