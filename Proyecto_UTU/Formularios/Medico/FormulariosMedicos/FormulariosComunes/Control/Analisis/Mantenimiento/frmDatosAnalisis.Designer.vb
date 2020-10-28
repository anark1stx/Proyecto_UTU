<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosAnalisis
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
        Me.pnlData = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tblParametros = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUnidad = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblParametro = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.pnlData.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tblParametros.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlData
        '
        Me.pnlData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlData.Controls.Add(Me.Panel1)
        Me.pnlData.Controls.Add(Me.lblTitulo)
        Me.pnlData.Location = New System.Drawing.Point(0, 0)
        Me.pnlData.Name = "pnlData"
        Me.pnlData.Size = New System.Drawing.Size(1130, 774)
        Me.pnlData.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.tblParametros)
        Me.Panel1.Location = New System.Drawing.Point(3, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1124, 707)
        Me.Panel1.TabIndex = 4
        '
        'tblParametros
        '
        Me.tblParametros.AutoSize = True
        Me.tblParametros.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tblParametros.ColumnCount = 5
        Me.tblParametros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblParametros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblParametros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblParametros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblParametros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblParametros.Controls.Add(Me.Label2, 4, 0)
        Me.tblParametros.Controls.Add(Me.Label1, 3, 0)
        Me.tblParametros.Controls.Add(Me.lblUnidad, 2, 0)
        Me.tblParametros.Controls.Add(Me.lblValor, 1, 0)
        Me.tblParametros.Controls.Add(Me.lblParametro, 0, 0)
        Me.tblParametros.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblParametros.Location = New System.Drawing.Point(0, 0)
        Me.tblParametros.MaximumSize = New System.Drawing.Size(0, 800)
        Me.tblParametros.Name = "tblParametros"
        Me.tblParametros.RowCount = 1
        Me.tblParametros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblParametros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tblParametros.Size = New System.Drawing.Size(1124, 27)
        Me.tblParametros.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(938, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Valor máximo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(716, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Valor mínimo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUnidad
        '
        Me.lblUnidad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblUnidad.AutoSize = True
        Me.lblUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidad.Location = New System.Drawing.Point(520, 1)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(80, 25)
        Me.lblUnidad.TabIndex = 2
        Me.lblUnidad.Text = "Unidad"
        Me.lblUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValor
        '
        Me.lblValor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.Location = New System.Drawing.Point(305, 1)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(63, 25)
        Me.lblValor.TabIndex = 1
        Me.lblValor.Text = "Valor"
        Me.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblParametro
        '
        Me.lblParametro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblParametro.AutoSize = True
        Me.lblParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParametro.Location = New System.Drawing.Point(57, 1)
        Me.lblParametro.Name = "lblParametro"
        Me.lblParametro.Size = New System.Drawing.Size(111, 25)
        Me.lblParametro.TabIndex = 0
        Me.lblParametro.Text = "Parámetro"
        Me.lblParametro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(319, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(411, 29)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Nombre del análisis - Paciente: CI"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(0, 777)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(1130, 64)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmDatosAnalisis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1130, 841)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.pnlData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDatosAnalisis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seguimiento análisis"
        Me.pnlData.ResumeLayout(False)
        Me.pnlData.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tblParametros.ResumeLayout(False)
        Me.tblParametros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlData As Panel
    Friend WithEvents tblParametros As TableLayoutPanel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblParametro As Label
    Friend WithEvents lblUnidad As Label
    Friend WithEvents lblValor As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
End Class
