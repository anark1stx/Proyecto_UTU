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
        Me.IndicacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrarIndic = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlContenedor.SuspendLayout()
        Me.pnlDatos.SuspendLayout()
        CType(Me.dgwIndicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IndicacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombreTratamiento
        '
        resources.ApplyResources(Me.lblNombreTratamiento, "lblNombreTratamiento")
        Me.lblNombreTratamiento.Name = "lblNombreTratamiento"
        '
        'txtNombreAnalisis
        '
        resources.ApplyResources(Me.txtNombreAnalisis, "txtNombreAnalisis")
        Me.txtNombreAnalisis.Name = "txtNombreAnalisis"
        '
        'pnlContenedor
        '
        resources.ApplyResources(Me.pnlContenedor, "pnlContenedor")
        Me.pnlContenedor.Controls.Add(Me.btnCheckNombreA)
        Me.pnlContenedor.Controls.Add(Me.pnlDatos)
        Me.pnlContenedor.Controls.Add(Me.txtNombreAnalisis)
        Me.pnlContenedor.Controls.Add(Me.lblNombreTratamiento)
        Me.pnlContenedor.Name = "pnlContenedor"
        '
        'btnCheckNombreA
        '
        resources.ApplyResources(Me.btnCheckNombreA, "btnCheckNombreA")
        Me.btnCheckNombreA.BackColor = System.Drawing.Color.Khaki
        Me.btnCheckNombreA.Name = "btnCheckNombreA"
        Me.btnCheckNombreA.UseVisualStyleBackColor = False
        '
        'pnlDatos
        '
        resources.ApplyResources(Me.pnlDatos, "pnlDatos")
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
        Me.pnlDatos.Name = "pnlDatos"
        '
        'txtNombrePrm
        '
        resources.ApplyResources(Me.txtNombrePrm, "txtNombrePrm")
        Me.txtNombrePrm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtNombrePrm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtNombrePrm.Name = "txtNombrePrm"
        '
        'txtNomIndicacion
        '
        resources.ApplyResources(Me.txtNomIndicacion, "txtNomIndicacion")
        Me.txtNomIndicacion.Name = "txtNomIndicacion"
        '
        'btnAgregarIndicacion
        '
        resources.ApplyResources(Me.btnAgregarIndicacion, "btnAgregarIndicacion")
        Me.btnAgregarIndicacion.Name = "btnAgregarIndicacion"
        Me.btnAgregarIndicacion.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'lblNomIndicacion
        '
        resources.ApplyResources(Me.lblNomIndicacion, "lblNomIndicacion")
        Me.lblNomIndicacion.Name = "lblNomIndicacion"
        '
        'dgwIndicaciones
        '
        Me.dgwIndicaciones.AllowUserToAddRows = False
        Me.dgwIndicaciones.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgwIndicaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.dgwIndicaciones, "dgwIndicaciones")
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
        Me.dgwIndicaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.BorrarIndic})
        Me.dgwIndicaciones.DataSource = Me.IndicacionBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwIndicaciones.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgwIndicaciones.Name = "dgwIndicaciones"
        Me.dgwIndicaciones.ReadOnly = True
        Me.dgwIndicaciones.RowTemplate.Height = 24
        '
        'dgwParametros
        '
        Me.dgwParametros.AllowUserToAddRows = False
        Me.dgwParametros.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgwParametros.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        resources.ApplyResources(Me.dgwParametros, "dgwParametros")
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
        Me.dgwParametros.Name = "dgwParametros"
        Me.dgwParametros.ReadOnly = True
        Me.dgwParametros.RowTemplate.Height = 24
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Nombre"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn13, "DataGridViewTextBoxColumn13")
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Unidad"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn14, "DataGridViewTextBoxColumn14")
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "ValorMinimo"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn15, "DataGridViewTextBoxColumn15")
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "ValorMaximo"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn16, "DataGridViewTextBoxColumn16")
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'BorrarPrm
        '
        Me.BorrarPrm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        resources.ApplyResources(Me.BorrarPrm, "BorrarPrm")
        Me.BorrarPrm.Name = "BorrarPrm"
        Me.BorrarPrm.ReadOnly = True
        Me.BorrarPrm.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BorrarPrm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BorrarPrm.Text = "Borrar"
        Me.BorrarPrm.UseColumnTextForButtonValue = True
        '
        'ParametroBindingSource
        '
        Me.ParametroBindingSource.DataSource = GetType(Entidades.E_Analisis.Parametro)
        '
        'txtIndicacionDescripcion
        '
        resources.ApplyResources(Me.txtIndicacionDescripcion, "txtIndicacionDescripcion")
        Me.txtIndicacionDescripcion.Name = "txtIndicacionDescripcion"
        '
        'txtVMax
        '
        resources.ApplyResources(Me.txtVMax, "txtVMax")
        Me.txtVMax.Name = "txtVMax"
        '
        'lblUnidadM
        '
        resources.ApplyResources(Me.lblUnidadM, "lblUnidadM")
        Me.lblUnidadM.Name = "lblUnidadM"
        '
        'lblNindicacion
        '
        resources.ApplyResources(Me.lblNindicacion, "lblNindicacion")
        Me.lblNindicacion.Name = "lblNindicacion"
        '
        'lblVMax
        '
        resources.ApplyResources(Me.lblVMax, "lblVMax")
        Me.lblVMax.Name = "lblVMax"
        '
        'txtUnidad
        '
        resources.ApplyResources(Me.txtUnidad, "txtUnidad")
        Me.txtUnidad.Name = "txtUnidad"
        '
        'lblNombreParametro
        '
        resources.ApplyResources(Me.lblNombreParametro, "lblNombreParametro")
        Me.lblNombreParametro.Name = "lblNombreParametro"
        '
        'btnAgregarAnalisis
        '
        resources.ApplyResources(Me.btnAgregarAnalisis, "btnAgregarAnalisis")
        Me.btnAgregarAnalisis.Name = "btnAgregarAnalisis"
        Me.btnAgregarAnalisis.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txtVMin
        '
        resources.ApplyResources(Me.txtVMin, "txtVMin")
        Me.txtVMin.Name = "txtVMin"
        '
        'lblVMin
        '
        resources.ApplyResources(Me.lblVMin, "lblVMin")
        Me.lblVMin.Name = "lblVMin"
        '
        'btnAgregarPrm
        '
        resources.ApplyResources(Me.btnAgregarPrm, "btnAgregarPrm")
        Me.btnAgregarPrm.Name = "btnAgregarPrm"
        Me.btnAgregarPrm.UseVisualStyleBackColor = True
        '
        'Borrar
        '
        Me.Borrar.FillWeight = 53.47594!
        resources.ApplyResources(Me.Borrar, "Borrar")
        Me.Borrar.Name = "Borrar"
        Me.Borrar.ReadOnly = True
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseColumnTextForButtonValue = True
        '
        'borrarInd
        '
        Me.borrarInd.DataPropertyName = "Nombre"
        Me.borrarInd.FillWeight = 32.08556!
        resources.ApplyResources(Me.borrarInd, "borrarInd")
        Me.borrarInd.Name = "borrarInd"
        Me.borrarInd.Text = "Borrar"
        Me.borrarInd.UseColumnTextForButtonValue = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn7.FillWeight = 110.511!
        resources.ApplyResources(Me.DataGridViewTextBoxColumn7, "DataGridViewTextBoxColumn7")
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ValorMinimo"
        Me.DataGridViewTextBoxColumn9.FillWeight = 112.0044!
        resources.ApplyResources(Me.DataGridViewTextBoxColumn9, "DataGridViewTextBoxColumn9")
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ValorMaximo"
        Me.DataGridViewTextBoxColumn10.FillWeight = 112.0044!
        resources.ApplyResources(Me.DataGridViewTextBoxColumn10, "DataGridViewTextBoxColumn10")
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.DataPropertyName = "Nombre"
        resources.ApplyResources(Me.DataGridViewButtonColumn1, "DataGridViewButtonColumn1")
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.Text = "Borrar"
        Me.DataGridViewButtonColumn1.UseColumnTextForButtonValue = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Indicacion"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn6, "DataGridViewTextBoxColumn6")
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Unidad"
        Me.DataGridViewTextBoxColumn8.FillWeight = 112.0044!
        resources.ApplyResources(Me.DataGridViewTextBoxColumn8, "DataGridViewTextBoxColumn8")
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Indicacion"
        Me.DataGridViewTextBoxColumn12.FillWeight = 133.9572!
        resources.ApplyResources(Me.DataGridViewTextBoxColumn12, "DataGridViewTextBoxColumn12")
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'IndicacionBindingSource
        '
        Me.IndicacionBindingSource.DataSource = GetType(Entidades.E_Analisis.Indicacion)
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
        'BorrarIndic
        '
        Me.BorrarIndic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        resources.ApplyResources(Me.BorrarIndic, "BorrarIndic")
        Me.BorrarIndic.Name = "BorrarIndic"
        Me.BorrarIndic.ReadOnly = True
        Me.BorrarIndic.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BorrarIndic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BorrarIndic.Text = "Borrar"
        Me.BorrarIndic.UseColumnTextForButtonValue = True
        '
        'frmAnalisisCrear
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.pnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAnalisisCrear"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.pnlDatos.ResumeLayout(False)
        Me.pnlDatos.PerformLayout()
        CType(Me.dgwIndicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwParametros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IndicacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents IndicacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtNombrePrm As TextBox
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents BorrarPrm As DataGridViewButtonColumn
    Friend WithEvents IndicacionBindingSource As BindingSource
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrarIndic As DataGridViewButtonColumn
End Class
