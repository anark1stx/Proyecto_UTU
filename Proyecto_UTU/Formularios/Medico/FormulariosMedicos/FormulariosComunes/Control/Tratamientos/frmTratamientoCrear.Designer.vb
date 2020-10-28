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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtNombreTratamiento = New System.Windows.Forms.TextBox()
        Me.tblElementos = New System.Windows.Forms.TableLayoutPanel()
        Me.dgwTratamientos = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ETratamientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtDescripcionTratamiento = New System.Windows.Forms.TextBox()
        Me.lblIndicaciones = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblNombreTratamiento = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DefinirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlContenedor.SuspendLayout()
        Me.tblBusqueda.SuspendLayout()
        Me.tblElementos.SuspendLayout()
        CType(Me.dgwTratamientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ETratamientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.tblBusqueda)
        Me.pnlContenedor.Controls.Add(Me.tblElementos)
        Me.pnlContenedor.Controls.Add(Me.btnGuardar)
        Me.pnlContenedor.Controls.Add(Me.lblNombreTratamiento)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 25)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1130, 873)
        Me.pnlContenedor.TabIndex = 0
        '
        'tblBusqueda
        '
        Me.tblBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblBusqueda.ColumnCount = 2
        Me.tblBusqueda.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.54839!))
        Me.tblBusqueda.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.451613!))
        Me.tblBusqueda.Controls.Add(Me.btnBuscar, 1, 0)
        Me.tblBusqueda.Controls.Add(Me.txtNombreTratamiento, 0, 0)
        Me.tblBusqueda.Location = New System.Drawing.Point(290, 12)
        Me.tblBusqueda.Name = "tblBusqueda"
        Me.tblBusqueda.RowCount = 1
        Me.tblBusqueda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblBusqueda.Size = New System.Drawing.Size(837, 37)
        Me.tblBusqueda.TabIndex = 92
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.Location = New System.Drawing.Point(787, 3)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(47, 30)
        Me.btnBuscar.TabIndex = 85
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtNombreTratamiento
        '
        Me.txtNombreTratamiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreTratamiento.Location = New System.Drawing.Point(3, 3)
        Me.txtNombreTratamiento.Name = "txtNombreTratamiento"
        Me.txtNombreTratamiento.Size = New System.Drawing.Size(776, 30)
        Me.txtNombreTratamiento.TabIndex = 82
        '
        'tblElementos
        '
        Me.tblElementos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblElementos.ColumnCount = 1
        Me.tblElementos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblElementos.Controls.Add(Me.dgwTratamientos, 0, 0)
        Me.tblElementos.Controls.Add(Me.txtDescripcionTratamiento, 0, 2)
        Me.tblElementos.Controls.Add(Me.lblIndicaciones, 0, 1)
        Me.tblElementos.Location = New System.Drawing.Point(3, 55)
        Me.tblElementos.Name = "tblElementos"
        Me.tblElementos.RowCount = 3
        Me.tblElementos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.92347!))
        Me.tblElementos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.377551!))
        Me.tblElementos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.69898!))
        Me.tblElementos.Size = New System.Drawing.Size(1127, 745)
        Me.tblElementos.TabIndex = 91
        '
        'dgwTratamientos
        '
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
        Me.dgwTratamientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwTratamientos.Location = New System.Drawing.Point(3, 3)
        Me.dgwTratamientos.Name = "dgwTratamientos"
        Me.dgwTratamientos.ReadOnly = True
        Me.dgwTratamientos.RowHeadersWidth = 51
        Me.dgwTratamientos.RowTemplate.Height = 24
        Me.dgwTratamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwTratamientos.Size = New System.Drawing.Size(1121, 105)
        Me.dgwTratamientos.TabIndex = 89
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ETratamientoBindingSource
        '
        Me.ETratamientoBindingSource.DataSource = GetType(Entidades.E_Tratamiento)
        '
        'txtDescripcionTratamiento
        '
        Me.txtDescripcionTratamiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcionTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionTratamiento.Location = New System.Drawing.Point(3, 161)
        Me.txtDescripcionTratamiento.MaxLength = 16000
        Me.txtDescripcionTratamiento.Multiline = True
        Me.txtDescripcionTratamiento.Name = "txtDescripcionTratamiento"
        Me.txtDescripcionTratamiento.Size = New System.Drawing.Size(1121, 581)
        Me.txtDescripcionTratamiento.TabIndex = 87
        '
        'lblIndicaciones
        '
        Me.lblIndicaciones.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIndicaciones.AutoSize = True
        Me.lblIndicaciones.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicaciones.Location = New System.Drawing.Point(407, 121)
        Me.lblIndicaciones.Name = "lblIndicaciones"
        Me.lblIndicaciones.Size = New System.Drawing.Size(312, 27)
        Me.lblIndicaciones.TabIndex = 90
        Me.lblIndicaciones.Text = "Indicaciones del tratamiento"
        '
        'btnGuardar
        '
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(0, 806)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(1130, 67)
        Me.btnGuardar.TabIndex = 84
        Me.btnGuardar.Text = "Guardar Tratamiento"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblNombreTratamiento
        '
        Me.lblNombreTratamiento.AutoSize = True
        Me.lblNombreTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTratamiento.Location = New System.Drawing.Point(12, 16)
        Me.lblNombreTratamiento.Name = "lblNombreTratamiento"
        Me.lblNombreTratamiento.Size = New System.Drawing.Size(272, 29)
        Me.lblNombreTratamiento.TabIndex = 78
        Me.lblNombreTratamiento.Text = "Nombre del tratamiento:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefinirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1130, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DefinirToolStripMenuItem
        '
        Me.DefinirToolStripMenuItem.Name = "DefinirToolStripMenuItem"
        Me.DefinirToolStripMenuItem.Size = New System.Drawing.Size(320, 21)
        Me.DefinirToolStripMenuItem.Text = "Definir parámetros temporales del tratamiento"
        '
        'frmTratamientoCrear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1130, 898)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmTratamientoCrear"
        Me.Text = "Crear y asignar tratamientos"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.tblBusqueda.ResumeLayout(False)
        Me.tblBusqueda.PerformLayout()
        Me.tblElementos.ResumeLayout(False)
        Me.tblElementos.PerformLayout()
        CType(Me.dgwTratamientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ETratamientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
