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
        Me.txtNombreAnalisis = New System.Windows.Forms.TextBox()
        Me.lblNombreTratamiento = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregarAnalisis = New System.Windows.Forms.Button()
        Me.dgwParametros = New System.Windows.Forms.DataGridView()
        Me.btnAgregarPrm = New System.Windows.Forms.Button()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.lblVMax = New System.Windows.Forms.Label()
        Me.txtNombrePrm = New System.Windows.Forms.TextBox()
        Me.lblVMin = New System.Windows.Forms.Label()
        Me.lblUnidadM = New System.Windows.Forms.Label()
        Me.lblNombreParametro = New System.Windows.Forms.Label()
        Me.txtVMin = New System.Windows.Forms.TextBox()
        Me.txtVMax = New System.Windows.Forms.TextBox()
        Me.Borrar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorMinimoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorMaximoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnalisisParametroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgwParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnalisisParametroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombreAnalisis
        '
        Me.txtNombreAnalisis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreAnalisis.Location = New System.Drawing.Point(240, 11)
        Me.txtNombreAnalisis.Name = "txtNombreAnalisis"
        Me.txtNombreAnalisis.Size = New System.Drawing.Size(886, 34)
        Me.txtNombreAnalisis.TabIndex = 89
        '
        'lblNombreTratamiento
        '
        Me.lblNombreTratamiento.AutoSize = True
        Me.lblNombreTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTratamiento.Location = New System.Drawing.Point(0, 16)
        Me.lblNombreTratamiento.Name = "lblNombreTratamiento"
        Me.lblNombreTratamiento.Size = New System.Drawing.Size(234, 29)
        Me.lblNombreTratamiento.TabIndex = 78
        Me.lblNombreTratamiento.Text = "Nombre del análisis:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 29)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Parámetros a registrar:"
        '
        'btnAgregarAnalisis
        '
        Me.btnAgregarAnalisis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarAnalisis.Location = New System.Drawing.Point(5, 662)
        Me.btnAgregarAnalisis.Name = "btnAgregarAnalisis"
        Me.btnAgregarAnalisis.Size = New System.Drawing.Size(1121, 55)
        Me.btnAgregarAnalisis.TabIndex = 99
        Me.btnAgregarAnalisis.Text = "Guardar Análisis"
        Me.btnAgregarAnalisis.UseVisualStyleBackColor = True
        '
        'dgwParametros
        '
        Me.dgwParametros.AllowUserToAddRows = False
        Me.dgwParametros.AllowUserToOrderColumns = True
        Me.dgwParametros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwParametros.AutoGenerateColumns = False
        Me.dgwParametros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwParametros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.UnidadDataGridViewTextBoxColumn, Me.ValorMinimoDataGridViewTextBoxColumn, Me.ValorMaximoDataGridViewTextBoxColumn, Me.Borrar})
        Me.dgwParametros.DataSource = Me.AnalisisParametroBindingSource
        Me.dgwParametros.Location = New System.Drawing.Point(5, 185)
        Me.dgwParametros.Name = "dgwParametros"
        Me.dgwParametros.RowHeadersWidth = 51
        Me.dgwParametros.RowTemplate.Height = 24
        Me.dgwParametros.Size = New System.Drawing.Size(1121, 471)
        Me.dgwParametros.TabIndex = 104
        '
        'btnAgregarPrm
        '
        Me.btnAgregarPrm.BackgroundImage = CType(resources.GetObject("btnAgregarPrm.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarPrm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarPrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarPrm.Location = New System.Drawing.Point(1022, 62)
        Me.btnAgregarPrm.Name = "btnAgregarPrm"
        Me.btnAgregarPrm.Size = New System.Drawing.Size(104, 91)
        Me.btnAgregarPrm.TabIndex = 113
        Me.btnAgregarPrm.UseVisualStyleBackColor = True
        '
        'txtUnidad
        '
        Me.txtUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidad.Location = New System.Drawing.Point(813, 65)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(194, 34)
        Me.txtUnidad.TabIndex = 120
        '
        'lblVMax
        '
        Me.lblVMax.AutoSize = True
        Me.lblVMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVMax.Location = New System.Drawing.Point(642, 124)
        Me.lblVMax.Name = "lblVMax"
        Me.lblVMax.Size = New System.Drawing.Size(165, 29)
        Me.lblVMax.TabIndex = 119
        Me.lblVMax.Text = "Valor máximo:"
        '
        'txtNombrePrm
        '
        Me.txtNombrePrm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePrm.Location = New System.Drawing.Point(429, 62)
        Me.txtNombrePrm.Name = "txtNombrePrm"
        Me.txtNombrePrm.Size = New System.Drawing.Size(194, 34)
        Me.txtNombrePrm.TabIndex = 118
        '
        'lblVMin
        '
        Me.lblVMin.AutoSize = True
        Me.lblVMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVMin.Location = New System.Drawing.Point(263, 124)
        Me.lblVMin.Name = "lblVMin"
        Me.lblVMin.Size = New System.Drawing.Size(160, 29)
        Me.lblVMin.TabIndex = 117
        Me.lblVMin.Text = "Valor mínimo:"
        '
        'lblUnidadM
        '
        Me.lblUnidadM.AutoSize = True
        Me.lblUnidadM.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidadM.Location = New System.Drawing.Point(642, 70)
        Me.lblUnidadM.Name = "lblUnidadM"
        Me.lblUnidadM.Size = New System.Drawing.Size(96, 29)
        Me.lblUnidadM.TabIndex = 116
        Me.lblUnidadM.Text = "Unidad:"
        '
        'lblNombreParametro
        '
        Me.lblNombreParametro.AutoSize = True
        Me.lblNombreParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreParametro.Location = New System.Drawing.Point(263, 70)
        Me.lblNombreParametro.Name = "lblNombreParametro"
        Me.lblNombreParametro.Size = New System.Drawing.Size(107, 29)
        Me.lblNombreParametro.TabIndex = 115
        Me.lblNombreParametro.Text = "Nombre:"
        '
        'txtVMin
        '
        Me.txtVMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVMin.Location = New System.Drawing.Point(429, 119)
        Me.txtVMin.Name = "txtVMin"
        Me.txtVMin.Size = New System.Drawing.Size(194, 34)
        Me.txtVMin.TabIndex = 121
        '
        'txtVMax
        '
        Me.txtVMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVMax.Location = New System.Drawing.Point(813, 119)
        Me.txtVMax.Name = "txtVMax"
        Me.txtVMax.Size = New System.Drawing.Size(194, 34)
        Me.txtVMax.TabIndex = 122
        '
        'Borrar
        '
        Me.Borrar.HeaderText = "Borrar"
        Me.Borrar.MinimumWidth = 6
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseColumnTextForButtonValue = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'UnidadDataGridViewTextBoxColumn
        '
        Me.UnidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.HeaderText = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UnidadDataGridViewTextBoxColumn.Name = "UnidadDataGridViewTextBoxColumn"
        '
        'ValorMinimoDataGridViewTextBoxColumn
        '
        Me.ValorMinimoDataGridViewTextBoxColumn.DataPropertyName = "ValorMinimo"
        Me.ValorMinimoDataGridViewTextBoxColumn.HeaderText = "ValorMinimo"
        Me.ValorMinimoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ValorMinimoDataGridViewTextBoxColumn.Name = "ValorMinimoDataGridViewTextBoxColumn"
        '
        'ValorMaximoDataGridViewTextBoxColumn
        '
        Me.ValorMaximoDataGridViewTextBoxColumn.DataPropertyName = "ValorMaximo"
        Me.ValorMaximoDataGridViewTextBoxColumn.HeaderText = "ValorMaximo"
        Me.ValorMaximoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ValorMaximoDataGridViewTextBoxColumn.Name = "ValorMaximoDataGridViewTextBoxColumn"
        '
        'AnalisisParametroBindingSource
        '
        Me.AnalisisParametroBindingSource.DataSource = GetType(Proyecto_UTU.AnalisisParametro)
        '
        'frmAnalisisCrear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1130, 720)
        Me.Controls.Add(Me.txtVMax)
        Me.Controls.Add(Me.txtVMin)
        Me.Controls.Add(Me.lblVMax)
        Me.Controls.Add(Me.lblVMin)
        Me.Controls.Add(Me.txtUnidad)
        Me.Controls.Add(Me.lblUnidadM)
        Me.Controls.Add(Me.txtNombrePrm)
        Me.Controls.Add(Me.lblNombreParametro)
        Me.Controls.Add(Me.btnAgregarPrm)
        Me.Controls.Add(Me.dgwParametros)
        Me.Controls.Add(Me.btnAgregarAnalisis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombreAnalisis)
        Me.Controls.Add(Me.lblNombreTratamiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAnalisisCrear"
        Me.Text = "frmAnalisisCrear"
        CType(Me.dgwParametros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnalisisParametroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombreAnalisis As TextBox
    Friend WithEvents lblNombreTratamiento As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregarAnalisis As Button
    Friend WithEvents dgwParametros As DataGridView
    Friend WithEvents btnAgregarPrm As Button
    Friend WithEvents txtUnidad As TextBox
    Friend WithEvents lblVMax As Label
    Friend WithEvents txtNombrePrm As TextBox
    Friend WithEvents lblVMin As Label
    Friend WithEvents lblUnidadM As Label
    Friend WithEvents lblNombreParametro As Label
    Friend WithEvents txtVMin As TextBox
    Friend WithEvents txtVMax As TextBox
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorMinimoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorMaximoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Borrar As DataGridViewButtonColumn
    Friend WithEvents AnalisisParametroBindingSource As BindingSource
End Class
