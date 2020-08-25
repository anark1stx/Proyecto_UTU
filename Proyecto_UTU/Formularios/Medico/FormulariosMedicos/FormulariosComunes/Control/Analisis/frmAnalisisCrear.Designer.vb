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
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomIndicacion = New System.Windows.Forms.TextBox()
        Me.lblNomIndicacion = New System.Windows.Forms.Label()
        Me.dgwParametros = New System.Windows.Forms.DataGridView()
        Me.Borrar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParametroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAgregarIndicacion = New System.Windows.Forms.Button()
        Me.txtIndicacionDescripcion = New System.Windows.Forms.TextBox()
        Me.lblNindicacion = New System.Windows.Forms.Label()
        Me.txtVMax = New System.Windows.Forms.TextBox()
        Me.txtVMin = New System.Windows.Forms.TextBox()
        Me.lblVMax = New System.Windows.Forms.Label()
        Me.lblVMin = New System.Windows.Forms.Label()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.lblUnidadM = New System.Windows.Forms.Label()
        Me.txtNombrePrm = New System.Windows.Forms.TextBox()
        Me.lblNombreParametro = New System.Windows.Forms.Label()
        Me.btnAgregarPrm = New System.Windows.Forms.Button()
        Me.btnAgregarAnalisis = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreAnalisis = New System.Windows.Forms.TextBox()
        Me.lblNombreTratamiento = New System.Windows.Forms.Label()
        Me.dgwIndicaciones = New System.Windows.Forms.DataGridView()
        Me.IndicacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndicacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrarInd = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlContenedor.SuspendLayout()
        CType(Me.dgwParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwIndicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IndicacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.AutoScroll = True
        Me.pnlContenedor.Controls.Add(Me.dgwIndicaciones)
        Me.pnlContenedor.Controls.Add(Me.Label2)
        Me.pnlContenedor.Controls.Add(Me.txtNomIndicacion)
        Me.pnlContenedor.Controls.Add(Me.lblNomIndicacion)
        Me.pnlContenedor.Controls.Add(Me.dgwParametros)
        Me.pnlContenedor.Controls.Add(Me.btnAgregarIndicacion)
        Me.pnlContenedor.Controls.Add(Me.txtIndicacionDescripcion)
        Me.pnlContenedor.Controls.Add(Me.lblNindicacion)
        Me.pnlContenedor.Controls.Add(Me.txtVMax)
        Me.pnlContenedor.Controls.Add(Me.txtVMin)
        Me.pnlContenedor.Controls.Add(Me.lblVMax)
        Me.pnlContenedor.Controls.Add(Me.lblVMin)
        Me.pnlContenedor.Controls.Add(Me.txtUnidad)
        Me.pnlContenedor.Controls.Add(Me.lblUnidadM)
        Me.pnlContenedor.Controls.Add(Me.txtNombrePrm)
        Me.pnlContenedor.Controls.Add(Me.lblNombreParametro)
        Me.pnlContenedor.Controls.Add(Me.btnAgregarPrm)
        Me.pnlContenedor.Controls.Add(Me.btnAgregarAnalisis)
        Me.pnlContenedor.Controls.Add(Me.Label1)
        Me.pnlContenedor.Controls.Add(Me.txtNombreAnalisis)
        Me.pnlContenedor.Controls.Add(Me.lblNombreTratamiento)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1181, 720)
        Me.pnlContenedor.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 801)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 29)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "Descripción:"
        '
        'txtNomIndicacion
        '
        Me.txtNomIndicacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNomIndicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomIndicacion.Location = New System.Drawing.Point(156, 737)
        Me.txtNomIndicacion.Name = "txtNomIndicacion"
        Me.txtNomIndicacion.Size = New System.Drawing.Size(1001, 34)
        Me.txtNomIndicacion.TabIndex = 149
        '
        'lblNomIndicacion
        '
        Me.lblNomIndicacion.AutoSize = True
        Me.lblNomIndicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomIndicacion.Location = New System.Drawing.Point(3, 742)
        Me.lblNomIndicacion.Name = "lblNomIndicacion"
        Me.lblNomIndicacion.Size = New System.Drawing.Size(107, 29)
        Me.lblNomIndicacion.TabIndex = 148
        Me.lblNomIndicacion.Text = "Nombre:"
        '
        'dgwParametros
        '
        Me.dgwParametros.AllowUserToAddRows = False
        Me.dgwParametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwParametros.AutoGenerateColumns = False
        Me.dgwParametros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwParametros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Borrar})
        Me.dgwParametros.DataSource = Me.ParametroBindingSource
        Me.dgwParametros.Location = New System.Drawing.Point(8, 165)
        Me.dgwParametros.Name = "dgwParametros"
        Me.dgwParametros.RowHeadersWidth = 51
        Me.dgwParametros.RowTemplate.Height = 24
        Me.dgwParametros.Size = New System.Drawing.Size(1149, 522)
        Me.dgwParametros.TabIndex = 147
        '
        'Borrar
        '
        Me.Borrar.HeaderText = "Borrar"
        Me.Borrar.MinimumWidth = 6
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseColumnTextForButtonValue = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Unidad"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ValorMinimo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ValorMinimo"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ValorMaximo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ValorMaximo"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'ParametroBindingSource
        '
        Me.ParametroBindingSource.DataSource = GetType(Proyecto_UTU.Analisis.Parametro)
        '
        'btnAgregarIndicacion
        '
        Me.btnAgregarIndicacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarIndicacion.BackgroundImage = CType(resources.GetObject("btnAgregarIndicacion.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarIndicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarIndicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarIndicacion.Location = New System.Drawing.Point(1055, 777)
        Me.btnAgregarIndicacion.Name = "btnAgregarIndicacion"
        Me.btnAgregarIndicacion.Size = New System.Drawing.Size(102, 85)
        Me.btnAgregarIndicacion.TabIndex = 144
        Me.btnAgregarIndicacion.UseVisualStyleBackColor = True
        '
        'txtIndicacionDescripcion
        '
        Me.txtIndicacionDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIndicacionDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIndicacionDescripcion.Location = New System.Drawing.Point(156, 777)
        Me.txtIndicacionDescripcion.Multiline = True
        Me.txtIndicacionDescripcion.Name = "txtIndicacionDescripcion"
        Me.txtIndicacionDescripcion.Size = New System.Drawing.Size(893, 85)
        Me.txtIndicacionDescripcion.TabIndex = 143
        '
        'lblNindicacion
        '
        Me.lblNindicacion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNindicacion.AutoSize = True
        Me.lblNindicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNindicacion.Location = New System.Drawing.Point(402, 701)
        Me.lblNindicacion.Name = "lblNindicacion"
        Me.lblNindicacion.Size = New System.Drawing.Size(369, 29)
        Me.lblNindicacion.TabIndex = 142
        Me.lblNindicacion.Text = "Ingresar indicaciones del análisis"
        '
        'txtVMax
        '
        Me.txtVMax.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtVMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVMax.Location = New System.Drawing.Point(817, 116)
        Me.txtVMax.Name = "txtVMax"
        Me.txtVMax.Size = New System.Drawing.Size(194, 34)
        Me.txtVMax.TabIndex = 141
        '
        'txtVMin
        '
        Me.txtVMin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtVMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVMin.Location = New System.Drawing.Point(435, 116)
        Me.txtVMin.Name = "txtVMin"
        Me.txtVMin.Size = New System.Drawing.Size(194, 34)
        Me.txtVMin.TabIndex = 140
        '
        'lblVMax
        '
        Me.lblVMax.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblVMax.AutoSize = True
        Me.lblVMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVMax.Location = New System.Drawing.Point(646, 121)
        Me.lblVMax.Name = "lblVMax"
        Me.lblVMax.Size = New System.Drawing.Size(165, 29)
        Me.lblVMax.TabIndex = 138
        Me.lblVMax.Text = "Valor máximo:"
        '
        'lblVMin
        '
        Me.lblVMin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblVMin.AutoSize = True
        Me.lblVMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVMin.Location = New System.Drawing.Point(269, 121)
        Me.lblVMin.Name = "lblVMin"
        Me.lblVMin.Size = New System.Drawing.Size(160, 29)
        Me.lblVMin.TabIndex = 136
        Me.lblVMin.Text = "Valor mínimo:"
        '
        'txtUnidad
        '
        Me.txtUnidad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidad.Location = New System.Drawing.Point(817, 56)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(194, 34)
        Me.txtUnidad.TabIndex = 139
        '
        'lblUnidadM
        '
        Me.lblUnidadM.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblUnidadM.AutoSize = True
        Me.lblUnidadM.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidadM.Location = New System.Drawing.Point(646, 62)
        Me.lblUnidadM.Name = "lblUnidadM"
        Me.lblUnidadM.Size = New System.Drawing.Size(96, 29)
        Me.lblUnidadM.TabIndex = 135
        Me.lblUnidadM.Text = "Unidad:"
        '
        'txtNombrePrm
        '
        Me.txtNombrePrm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNombrePrm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePrm.Location = New System.Drawing.Point(435, 56)
        Me.txtNombrePrm.Name = "txtNombrePrm"
        Me.txtNombrePrm.Size = New System.Drawing.Size(194, 34)
        Me.txtNombrePrm.TabIndex = 137
        '
        'lblNombreParametro
        '
        Me.lblNombreParametro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNombreParametro.AutoSize = True
        Me.lblNombreParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreParametro.Location = New System.Drawing.Point(269, 62)
        Me.lblNombreParametro.Name = "lblNombreParametro"
        Me.lblNombreParametro.Size = New System.Drawing.Size(107, 29)
        Me.lblNombreParametro.TabIndex = 134
        Me.lblNombreParametro.Text = "Nombre:"
        '
        'btnAgregarPrm
        '
        Me.btnAgregarPrm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarPrm.BackgroundImage = CType(resources.GetObject("btnAgregarPrm.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarPrm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarPrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarPrm.Location = New System.Drawing.Point(1054, 56)
        Me.btnAgregarPrm.Name = "btnAgregarPrm"
        Me.btnAgregarPrm.Size = New System.Drawing.Size(103, 94)
        Me.btnAgregarPrm.TabIndex = 133
        Me.btnAgregarPrm.UseVisualStyleBackColor = True
        '
        'btnAgregarAnalisis
        '
        Me.btnAgregarAnalisis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarAnalisis.Location = New System.Drawing.Point(8, 953)
        Me.btnAgregarAnalisis.Name = "btnAgregarAnalisis"
        Me.btnAgregarAnalisis.Size = New System.Drawing.Size(1152, 98)
        Me.btnAgregarAnalisis.TabIndex = 131
        Me.btnAgregarAnalisis.Text = "Guardar Análisis"
        Me.btnAgregarAnalisis.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 29)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Nuevo parámetro:"
        '
        'txtNombreAnalisis
        '
        Me.txtNombreAnalisis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreAnalisis.Location = New System.Drawing.Point(243, 4)
        Me.txtNombreAnalisis.Name = "txtNombreAnalisis"
        Me.txtNombreAnalisis.Size = New System.Drawing.Size(916, 34)
        Me.txtNombreAnalisis.TabIndex = 129
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
        'dgwIndicaciones
        '
        Me.dgwIndicaciones.AllowUserToAddRows = False
        Me.dgwIndicaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwIndicaciones.AutoGenerateColumns = False
        Me.dgwIndicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwIndicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwIndicaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.IndicacionDataGridViewTextBoxColumn, Me.borrarInd})
        Me.dgwIndicaciones.DataSource = Me.IndicacionBindingSource
        Me.dgwIndicaciones.Location = New System.Drawing.Point(156, 868)
        Me.dgwIndicaciones.Name = "dgwIndicaciones"
        Me.dgwIndicaciones.RowHeadersWidth = 51
        Me.dgwIndicaciones.RowTemplate.Height = 24
        Me.dgwIndicaciones.Size = New System.Drawing.Size(1001, 79)
        Me.dgwIndicaciones.TabIndex = 151
        '
        'IndicacionBindingSource
        '
        Me.IndicacionBindingSource.DataSource = GetType(Proyecto_UTU.Analisis.Indicacion)
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'IndicacionDataGridViewTextBoxColumn
        '
        Me.IndicacionDataGridViewTextBoxColumn.DataPropertyName = "Indicacion"
        Me.IndicacionDataGridViewTextBoxColumn.HeaderText = "Indicacion"
        Me.IndicacionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IndicacionDataGridViewTextBoxColumn.Name = "IndicacionDataGridViewTextBoxColumn"
        '
        'borrarInd
        '
        Me.borrarInd.DataPropertyName = "Nombre"
        Me.borrarInd.HeaderText = "Borrar"
        Me.borrarInd.MinimumWidth = 6
        Me.borrarInd.Name = "borrarInd"
        Me.borrarInd.Text = "Borrar"
        Me.borrarInd.UseColumnTextForButtonValue = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Indicacion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Indicacion"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 316
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
        'frmAnalisisCrear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1181, 720)
        Me.Controls.Add(Me.pnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAnalisisCrear"
        Me.Text = "frmAnalisisCrear"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        CType(Me.dgwParametros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwIndicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IndicacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents txtVMax As TextBox
    Friend WithEvents txtVMin As TextBox
    Friend WithEvents lblVMax As Label
    Friend WithEvents lblVMin As Label
    Friend WithEvents txtUnidad As TextBox
    Friend WithEvents lblUnidadM As Label
    Friend WithEvents txtNombrePrm As TextBox
    Friend WithEvents lblNombreParametro As Label
    Friend WithEvents btnAgregarPrm As Button
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorMinimoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorMaximoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAgregarAnalisis As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreAnalisis As TextBox
    Friend WithEvents lblNombreTratamiento As Label
    Friend WithEvents lblNindicacion As Label
    Friend WithEvents btnAgregarIndicacion As Button
    Friend WithEvents txtIndicacionDescripcion As TextBox
    Friend WithEvents dgwParametros As DataGridView
    Friend WithEvents Borrar As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents ParametroBindingSource As BindingSource
    Friend WithEvents txtNomIndicacion As TextBox
    Friend WithEvents lblNomIndicacion As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgwIndicaciones As DataGridView
    Friend WithEvents IndicacionBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents IndicacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents borrarInd As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
End Class
