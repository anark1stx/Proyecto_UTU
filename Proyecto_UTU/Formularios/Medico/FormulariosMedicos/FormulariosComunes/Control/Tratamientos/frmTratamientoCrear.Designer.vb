<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTratamientoCrear
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTratamientoCrear))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.tblBusqueda = New System.Windows.Forms.TableLayoutPanel()
        Me.txtNombreTratamiento = New System.Windows.Forms.TextBox()
        Me.tblElementos = New System.Windows.Forms.TableLayoutPanel()
        Me.dgwTratamientos = New System.Windows.Forms.DataGridView()
        Me.txtDescripcionTratamiento = New System.Windows.Forms.TextBox()
        Me.lblIndicaciones = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblNombreTratamiento = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DefinirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ETratamientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlContenedor.SuspendLayout()
        Me.tblBusqueda.SuspendLayout()
        Me.tblElementos.SuspendLayout()
        CType(Me.dgwTratamientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ETratamientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        resources.ApplyResources(Me.pnlContenedor, "pnlContenedor")
        Me.pnlContenedor.Controls.Add(Me.tblBusqueda)
        Me.pnlContenedor.Controls.Add(Me.tblElementos)
        Me.pnlContenedor.Controls.Add(Me.btnGuardar)
        Me.pnlContenedor.Controls.Add(Me.lblNombreTratamiento)
        Me.pnlContenedor.Name = "pnlContenedor"
        '
        'tblBusqueda
        '
        resources.ApplyResources(Me.tblBusqueda, "tblBusqueda")
        Me.tblBusqueda.Controls.Add(Me.btnBuscar, 1, 0)
        Me.tblBusqueda.Controls.Add(Me.txtNombreTratamiento, 0, 0)
        Me.tblBusqueda.Name = "tblBusqueda"
        '
        'txtNombreTratamiento
        '
        resources.ApplyResources(Me.txtNombreTratamiento, "txtNombreTratamiento")
        Me.txtNombreTratamiento.Name = "txtNombreTratamiento"
        '
        'tblElementos
        '
        resources.ApplyResources(Me.tblElementos, "tblElementos")
        Me.tblElementos.Controls.Add(Me.dgwTratamientos, 0, 0)
        Me.tblElementos.Controls.Add(Me.txtDescripcionTratamiento, 0, 2)
        Me.tblElementos.Controls.Add(Me.lblIndicaciones, 0, 1)
        Me.tblElementos.Name = "tblElementos"
        '
        'dgwTratamientos
        '
        resources.ApplyResources(Me.dgwTratamientos, "dgwTratamientos")
        Me.dgwTratamientos.AllowUserToAddRows = False
        Me.dgwTratamientos.AllowUserToDeleteRows = False
        Me.dgwTratamientos.AutoGenerateColumns = False
        Me.dgwTratamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwTratamientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgwTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwTratamientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
        Me.dgwTratamientos.DataSource = Me.ETratamientoBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwTratamientos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgwTratamientos.Name = "dgwTratamientos"
        Me.dgwTratamientos.ReadOnly = True
        Me.dgwTratamientos.RowTemplate.Height = 24
        Me.dgwTratamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'txtDescripcionTratamiento
        '
        resources.ApplyResources(Me.txtDescripcionTratamiento, "txtDescripcionTratamiento")
        Me.txtDescripcionTratamiento.Name = "txtDescripcionTratamiento"
        '
        'lblIndicaciones
        '
        resources.ApplyResources(Me.lblIndicaciones, "lblIndicaciones")
        Me.lblIndicaciones.Name = "lblIndicaciones"
        '
        'btnGuardar
        '
        resources.ApplyResources(Me.btnGuardar, "btnGuardar")
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblNombreTratamiento
        '
        resources.ApplyResources(Me.lblNombreTratamiento, "lblNombreTratamiento")
        Me.lblNombreTratamiento.Name = "lblNombreTratamiento"
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefinirToolStripMenuItem})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'DefinirToolStripMenuItem
        '
        resources.ApplyResources(Me.DefinirToolStripMenuItem, "DefinirToolStripMenuItem")
        Me.DefinirToolStripMenuItem.Name = "DefinirToolStripMenuItem"
        '
        'btnBuscar
        '
        resources.ApplyResources(Me.btnBuscar, "btnBuscar")
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        resources.ApplyResources(Me.IDDataGridViewTextBoxColumn, "IDDataGridViewTextBoxColumn")
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        resources.ApplyResources(Me.NombreDataGridViewTextBoxColumn, "NombreDataGridViewTextBoxColumn")
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        resources.ApplyResources(Me.DescripcionDataGridViewTextBoxColumn, "DescripcionDataGridViewTextBoxColumn")
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ETratamientoBindingSource
        '
        Me.ETratamientoBindingSource.DataSource = GetType(Entidades.E_Tratamiento)
        '
        'frmTratamientoCrear
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmTratamientoCrear"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.tblBusqueda.ResumeLayout(False)
        Me.tblBusqueda.PerformLayout()
        Me.tblElementos.ResumeLayout(False)
        Me.tblElementos.PerformLayout()
        CType(Me.dgwTratamientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ETratamientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents txtNombreTratamiento As TextBox
    Friend WithEvents lblNombreTratamiento As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents ETratamientoBindingSource As BindingSource
    Friend WithEvents tblElementos As TableLayoutPanel
    Friend WithEvents dgwTratamientos As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtDescripcionTratamiento As TextBox
    Friend WithEvents lblIndicaciones As Label
    Friend WithEvents tblBusqueda As TableLayoutPanel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DefinirToolStripMenuItem As ToolStripMenuItem
End Class
