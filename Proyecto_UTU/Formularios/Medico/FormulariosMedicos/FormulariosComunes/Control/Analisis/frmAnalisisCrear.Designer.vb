<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAnalisisCrear
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalisisCrear))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblNombreTratamiento = New System.Windows.Forms.Label()
        Me.txtNombreAnalisis = New System.Windows.Forms.TextBox()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.btnCheckNombreA = New System.Windows.Forms.Button()
        Me.pnlDatos = New System.Windows.Forms.Panel()
        Me.txtNombrePrm = New System.Windows.Forms.TextBox()
        Me.txtNomIndicacion = New System.Windows.Forms.TextBox()
        Me.btnAgregarIndicacion = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNomIndicacion = New System.Windows.Forms.Label()
        Me.dgwIndicaciones = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrarIndic = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.IndicacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgwParametros = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrarPrm = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ParametroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtIndicacionDescripcion = New System.Windows.Forms.TextBox()
        Me.txtVMax = New System.Windows.Forms.TextBox()
        Me.lblUnidadM = New System.Windows.Forms.Label()
        Me.lblNindicacion = New System.Windows.Forms.Label()
        Me.lblVMax = New System.Windows.Forms.Label()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.lblNombreParametro = New System.Windows.Forms.Label()
        Me.btnAgregarAnalisis = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVMin = New System.Windows.Forms.TextBox()
        Me.lblVMin = New System.Windows.Forms.Label()
        Me.btnAgregarPrm = New System.Windows.Forms.Button()
        Me.Borrar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.borrarInd = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlContenedor.SuspendLayout()
        Me.pnlDatos.SuspendLayout()
        CType(Me.dgwIndicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IndicacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombreTratamiento
        '
        Me.lblNombreTratamiento.AutoSize = True
        Me.lblNombreTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTratamiento.Location = New System.Drawing.Point(3, 9)
        Me.lblNombreTratamiento.Name = "lblNombreTratamiento"
        Me.lblNombreTratamiento.Size = New System.Drawing.Size(234, 29)
        Me.lblNombreTratamiento.TabIndex = 128
        Me.lblNombreTratamiento.Text = "Nombre del análisis:"
        '
        'txtNombreAnalisis
        '
        Me.txtNombreAnalisis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreAnalisis.Location = New System.Drawing.Point(243, 4)
        Me.txtNombreAnalisis.MaxLength = 90
        Me.txtNombreAnalisis.Name = "txtNombreAnalisis"
        Me.txtNombreAnalisis.Size = New System.Drawing.Size(992, 34)
        Me.txtNombreAnalisis.TabIndex = 129
        '
        'pnlContenedor
        '
        Me.pnlContenedor.AutoScroll = True
        Me.pnlContenedor.Controls.Add(Me.btnCheckNombreA)
        Me.pnlContenedor.Controls.Add(Me.pnlDatos)
        Me.pnlContenedor.Controls.Add(Me.txtNombreAnalisis)
        Me.pnlContenedor.Controls.Add(Me.lblNombreTratamiento)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1313, 720)
        Me.pnlContenedor.TabIndex = 0
        '
        'btnCheckNombreA
        '
        Me.btnCheckNombreA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCheckNombreA.BackColor = System.Drawing.Color.Khaki
        Me.btnCheckNombreA.BackgroundImage = CType(resources.GetObject("btnCheckNombreA.BackgroundImage"), System.Drawing.Image)
        Me.btnCheckNombreA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCheckNombreA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckNombreA.Location = New System.Drawing.Point(1241, 4)
        Me.btnCheckNombreA.Name = "btnCheckNombreA"
        Me.btnCheckNombreA.Size = New System.Drawing.Size(48, 34)
        Me.btnCheckNombreA.TabIndex = 131
        Me.btnCheckNombreA.UseVisualStyleBackColor = False
        '
        'pnlDatos
        '
        Me.pnlDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDatos.Controls.Add(Me.txtNombrePrm)
        Me.pnlDatos.Controls.Add(Me.txtNomIndicacion)
        Me.pnlDatos.Controls.Add(Me.btnAgregarIndicacion)
        Me.pnlDatos.Controls.Add(Me.Label2)
        Me.pnlDatos.Controls.Add(Me.lblNomIndicacion)
        Me.pnlDatos.Controls.Add(Me.dgwIndicaciones)
        Me.pnlDatos.Controls.Add(Me.dgwParametros)
        Me.pnlDatos.Controls.Add(Me.txtIndicacionDescripcion)
        Me.pnlDatos.Controls.Add(Me.txtVMax)
        Me.pnlDatos.Controls.Add(Me.lblUnidadM)
        Me.pnlDatos.Controls.Add(Me.lblNindicacion)
        Me.pnlDatos.Controls.Add(Me.lblVMax)
        Me.pnlDatos.Controls.Add(Me.txtUnidad)
        Me.pnlDatos.Controls.Add(Me.lblNombreParametro)
        Me.pnlDatos.Controls.Add(Me.btnAgregarAnalisis)
        Me.pnlDatos.Controls.Add(Me.Label1)
        Me.pnlDatos.Controls.Add(Me.txtVMin)
        Me.pnlDatos.Controls.Add(Me.lblVMin)
        Me.pnlDatos.Controls.Add(Me.btnAgregarPrm)
        Me.pnlDatos.Location = New System.Drawing.Point(3, 41)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(1286, 1125)
        Me.pnlDatos.TabIndex = 130
        '
        'txtNombrePrm
        '
        Me.txtNombrePrm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNombrePrm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtNombrePrm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtNombrePrm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePrm.Location = New System.Drawing.Point(487, 19)
        Me.txtNombrePrm.MaxLength = 90
        Me.txtNombrePrm.Name = "txtNombrePrm"
        Me.txtNombrePrm.Size = New System.Drawing.Size(194, 34)
        Me.txtNombrePrm.TabIndex = 171
        '
        'txtNomIndicacion
        '
        Me.txtNomIndicacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNomIndicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomIndicacion.Location = New System.Drawing.Point(161, 709)
        Me.txtNomIndicacion.MaxLength = 90
        Me.txtNomIndicacion.Name = "txtNomIndicacion"
        Me.txtNomIndicacion.Size = New System.Drawing.Size(1122, 34)
        Me.txtNomIndicacion.TabIndex = 168
        '
        'btnAgregarIndicacion
        '
        Me.btnAgregarIndicacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarIndicacion.BackgroundImage = CType(resources.GetObject("btnAgregarIndicacion.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarIndicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarIndicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarIndicacion.Location = New System.Drawing.Point(1180, 749)
        Me.btnAgregarIndicacion.Name = "btnAgregarIndicacion"
        Me.btnAgregarIndicacion.Size = New System.Drawing.Size(102, 85)
        Me.btnAgregarIndicacion.TabIndex = 165
        Me.btnAgregarIndicacion.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 773)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 29)
        Me.Label2.TabIndex = 169
        Me.Label2.Text = "Descripción:"
        '
        'lblNomIndicacion
        '
        Me.lblNomIndicacion.AutoSize = True
        Me.lblNomIndicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomIndicacion.Location = New System.Drawing.Point(8, 714)
        Me.lblNomIndicacion.Name = "lblNomIndicacion"
        Me.lblNomIndicacion.Size = New System.Drawing.Size(107, 29)
        Me.lblNomIndicacion.TabIndex = 167
        Me.lblNomIndicacion.Text = "Nombre:"
        '
        'dgwIndicaciones
        '
        Me.dgwIndicaciones.AllowUserToAddRows = False
        Me.dgwIndicaciones.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgwIndicaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgwIndicaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwIndicaciones.AutoGenerateColumns = False
        Me.dgwIndicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwIndicaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgwIndicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwIndicaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.BorrarIndic})
        Me.dgwIndicaciones.DataSource = Me.IndicacionBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwIndicaciones.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgwIndicaciones.Location = New System.Drawing.Point(3, 840)
        Me.dgwIndicaciones.Name = "dgwIndicaciones"
        Me.dgwIndicaciones.ReadOnly = True
        Me.dgwIndicaciones.RowHeadersWidth = 51
        Me.dgwIndicaciones.RowTemplate.Height = 24
        Me.dgwIndicaciones.Size = New System.Drawing.Size(1280, 152)
        Me.dgwIndicaciones.TabIndex = 170
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BorrarIndic
        '
        Me.BorrarIndic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.BorrarIndic.HeaderText = "Borrar"
        Me.BorrarIndic.MinimumWidth = 6
        Me.BorrarIndic.Name = "BorrarIndic"
        Me.BorrarIndic.ReadOnly = True
        Me.BorrarIndic.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BorrarIndic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BorrarIndic.Text = "Borrar"
        Me.BorrarIndic.UseColumnTextForButtonValue = True
        Me.BorrarIndic.Width = 94
        '
        'IndicacionBindingSource
        '
        Me.IndicacionBindingSource.DataSource = GetType(Entidades.E_Analisis.Indicacion)
        '
        'dgwParametros
        '
        Me.dgwParametros.AllowUserToAddRows = False
        Me.dgwParametros.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgwParametros.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgwParametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwParametros.AutoGenerateColumns = False
        Me.dgwParametros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwParametros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgwParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwParametros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.BorrarPrm})
        Me.dgwParametros.DataSource = Me.ParametroBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwParametros.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgwParametros.Location = New System.Drawing.Point(0, 128)
        Me.dgwParametros.Name = "dgwParametros"
        Me.dgwParametros.ReadOnly = True
        Me.dgwParametros.RowHeadersWidth = 51
        Me.dgwParametros.RowTemplate.Height = 24
        Me.dgwParametros.Size = New System.Drawing.Size(1283, 522)
        Me.dgwParametros.TabIndex = 166
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Unidad"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "ValorMinimo"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Valor Mínimo"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "ValorMaximo"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Valor Máximo"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'BorrarPrm
        '
        Me.BorrarPrm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.BorrarPrm.HeaderText = "Borrar"
        Me.BorrarPrm.MinimumWidth = 6
        Me.BorrarPrm.Name = "BorrarPrm"
        Me.BorrarPrm.ReadOnly = True
        Me.BorrarPrm.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BorrarPrm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BorrarPrm.Text = "Borrar"
        Me.BorrarPrm.UseColumnTextForButtonValue = True
        Me.BorrarPrm.Width = 94
        '
        'ParametroBindingSource
        '
        Me.ParametroBindingSource.DataSource = GetType(Entidades.E_Analisis.Parametro)
        '
        'txtIndicacionDescripcion
        '
        Me.txtIndicacionDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIndicacionDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIndicacionDescripcion.Location = New System.Drawing.Point(161, 749)
        Me.txtIndicacionDescripcion.MaxLength = 1200
        Me.txtIndicacionDescripcion.Multiline = True
        Me.txtIndicacionDescripcion.Name = "txtIndicacionDescripcion"
        Me.txtIndicacionDescripcion.Size = New System.Drawing.Size(1013, 85)
        Me.txtIndicacionDescripcion.TabIndex = 164
        '
        'txtVMax
        '
        Me.txtVMax.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtVMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVMax.Location = New System.Drawing.Point(869, 79)
        Me.txtVMax.MaxLength = 9
        Me.txtVMax.Name = "txtVMax"
        Me.txtVMax.Size = New System.Drawing.Size(194, 34)
        Me.txtVMax.TabIndex = 162
        '
        'lblUnidadM
        '
        Me.lblUnidadM.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblUnidadM.AutoSize = True
        Me.lblUnidadM.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidadM.Location = New System.Drawing.Point(698, 25)
        Me.lblUnidadM.Name = "lblUnidadM"
        Me.lblUnidadM.Size = New System.Drawing.Size(96, 29)
        Me.lblUnidadM.TabIndex = 157
        Me.lblUnidadM.Text = "Unidad:"
        '
        'lblNindicacion
        '
        Me.lblNindicacion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNindicacion.AutoSize = True
        Me.lblNindicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNindicacion.Location = New System.Drawing.Point(454, 668)
        Me.lblNindicacion.Name = "lblNindicacion"
        Me.lblNindicacion.Size = New System.Drawing.Size(369, 29)
        Me.lblNindicacion.TabIndex = 163
        Me.lblNindicacion.Text = "Ingresar indicaciones del análisis"
        '
        'lblVMax
        '
        Me.lblVMax.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblVMax.AutoSize = True
        Me.lblVMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVMax.Location = New System.Drawing.Point(698, 84)
        Me.lblVMax.Name = "lblVMax"
        Me.lblVMax.Size = New System.Drawing.Size(165, 29)
        Me.lblVMax.TabIndex = 159
        Me.lblVMax.Text = "Valor máximo:"
        '
        'txtUnidad
        '
        Me.txtUnidad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidad.Location = New System.Drawing.Point(869, 19)
        Me.txtUnidad.MaxLength = 20
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(194, 34)
        Me.txtUnidad.TabIndex = 160
        '
        'lblNombreParametro
        '
        Me.lblNombreParametro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNombreParametro.AutoSize = True
        Me.lblNombreParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreParametro.Location = New System.Drawing.Point(321, 25)
        Me.lblNombreParametro.Name = "lblNombreParametro"
        Me.lblNombreParametro.Size = New System.Drawing.Size(107, 29)
        Me.lblNombreParametro.TabIndex = 156
        Me.lblNombreParametro.Text = "Nombre:"
        '
        'btnAgregarAnalisis
        '
        Me.btnAgregarAnalisis.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnAgregarAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarAnalisis.Location = New System.Drawing.Point(0, 1009)
        Me.btnAgregarAnalisis.Name = "btnAgregarAnalisis"
        Me.btnAgregarAnalisis.Size = New System.Drawing.Size(1286, 116)
        Me.btnAgregarAnalisis.TabIndex = 154
        Me.btnAgregarAnalisis.Text = "Guardar Análisis"
        Me.btnAgregarAnalisis.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 29)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "Nuevo parámetro:"
        '
        'txtVMin
        '
        Me.txtVMin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtVMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVMin.Location = New System.Drawing.Point(487, 79)
        Me.txtVMin.MaxLength = 9
        Me.txtVMin.Name = "txtVMin"
        Me.txtVMin.Size = New System.Drawing.Size(194, 34)
        Me.txtVMin.TabIndex = 161
        '
        'lblVMin
        '
        Me.lblVMin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblVMin.AutoSize = True
        Me.lblVMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVMin.Location = New System.Drawing.Point(321, 84)
        Me.lblVMin.Name = "lblVMin"
        Me.lblVMin.Size = New System.Drawing.Size(160, 29)
        Me.lblVMin.TabIndex = 158
        Me.lblVMin.Text = "Valor mínimo:"
        '
        'btnAgregarPrm
        '
        Me.btnAgregarPrm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarPrm.BackgroundImage = CType(resources.GetObject("btnAgregarPrm.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarPrm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarPrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarPrm.Location = New System.Drawing.Point(1180, 19)
        Me.btnAgregarPrm.Name = "btnAgregarPrm"
        Me.btnAgregarPrm.Size = New System.Drawing.Size(103, 94)
        Me.btnAgregarPrm.TabIndex = 155
        Me.btnAgregarPrm.UseVisualStyleBackColor = True
        '
        'Borrar
        '
        Me.Borrar.FillWeight = 53.47594!
        Me.Borrar.HeaderText = "Borrar"
        Me.Borrar.MinimumWidth = 6
        Me.Borrar.Name = "Borrar"
        Me.Borrar.ReadOnly = True
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseColumnTextForButtonValue = True
        Me.Borrar.Width = 125
        '
        'borrarInd
        '
        Me.borrarInd.DataPropertyName = "Nombre"
        Me.borrarInd.FillWeight = 32.08556!
        Me.borrarInd.HeaderText = "Borrar"
        Me.borrarInd.MinimumWidth = 6
        Me.borrarInd.Name = "borrarInd"
        Me.borrarInd.Text = "Borrar"
        Me.borrarInd.UseColumnTextForButtonValue = True
        Me.borrarInd.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn7.FillWeight = 110.511!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ValorMinimo"
        Me.DataGridViewTextBoxColumn9.FillWeight = 112.0044!
        Me.DataGridViewTextBoxColumn9.HeaderText = "ValorMinimo"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ValorMaximo"
        Me.DataGridViewTextBoxColumn10.FillWeight = 112.0044!
        Me.DataGridViewTextBoxColumn10.HeaderText = "ValorMaximo"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.DataPropertyName = "Nombre"
        Me.DataGridViewButtonColumn1.HeaderText = "Borrar"
        Me.DataGridViewButtonColumn1.MinimumWidth = 6
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.Text = "Borrar"
        Me.DataGridViewButtonColumn1.UseColumnTextForButtonValue = True
        Me.DataGridViewButtonColumn1.Width = 316
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Indicacion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Indicacion"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 316
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Unidad"
        Me.DataGridViewTextBoxColumn8.FillWeight = 112.0044!
        Me.DataGridViewTextBoxColumn8.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Indicacion"
        Me.DataGridViewTextBoxColumn12.FillWeight = 133.9572!
        Me.DataGridViewTextBoxColumn12.HeaderText = "Indicacion"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'frmAnalisisCrear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1313, 720)
        Me.Controls.Add(Me.pnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAnalisisCrear"
        Me.Text = "Crear análisis"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.pnlDatos.ResumeLayout(False)
        Me.pnlDatos.PerformLayout()
        CType(Me.dgwIndicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IndicacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwParametros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UnidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorMinimoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorMaximoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents lblNombreTratamiento As Label
    Friend WithEvents txtNombreAnalisis As TextBox
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents txtNomIndicacion As TextBox
    Friend WithEvents btnAgregarIndicacion As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNomIndicacion As Label
    Friend WithEvents dgwIndicaciones As DataGridView
    Friend WithEvents dgwParametros As DataGridView
    Friend WithEvents ParametroBindingSource As BindingSource
    Friend WithEvents txtIndicacionDescripcion As TextBox
    Friend WithEvents txtVMax As TextBox
    Friend WithEvents lblUnidadM As Label
    Friend WithEvents lblNindicacion As Label
    Friend WithEvents lblVMax As Label
    Friend WithEvents txtUnidad As TextBox
    Friend WithEvents lblNombreParametro As Label
    Friend WithEvents btnAgregarAnalisis As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtVMin As TextBox
    Friend WithEvents lblVMin As Label
    Friend WithEvents btnAgregarPrm As Button
    Friend WithEvents Borrar As DataGridViewButtonColumn
    Friend WithEvents borrarInd As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents btnCheckNombreA As Button
    Friend WithEvents IndicacionBindingSource As BindingSource
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndicacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrarIndic As DataGridViewButtonColumn
    Friend WithEvents txtNombrePrm As TextBox
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents BorrarPrm As DataGridViewButtonColumn
End Class
