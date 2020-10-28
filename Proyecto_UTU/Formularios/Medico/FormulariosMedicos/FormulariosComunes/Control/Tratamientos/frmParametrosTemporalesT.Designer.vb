<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametrosTemporalesT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParametrosTemporalesT))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbDiasSelect = New System.Windows.Forms.ListBox()
        Me.lblDiasSelect = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSacarDia = New System.Windows.Forms.Button()
        Me.btnAgregarDia = New System.Windows.Forms.Button()
        Me.cbDiasSemana = New System.Windows.Forms.ComboBox()
        Me.lblDiasSemana = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaIni = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(905, 340)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lbDiasSelect)
        Me.Panel4.Controls.Add(Me.lblDiasSelect)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(455, 173)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(447, 164)
        Me.Panel4.TabIndex = 4
        '
        'lbDiasSelect
        '
        Me.lbDiasSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDiasSelect.FormattingEnabled = True
        Me.lbDiasSelect.ItemHeight = 29
        Me.lbDiasSelect.Location = New System.Drawing.Point(10, 37)
        Me.lbDiasSelect.Name = "lbDiasSelect"
        Me.lbDiasSelect.Size = New System.Drawing.Size(430, 120)
        Me.lbDiasSelect.TabIndex = 1
        '
        'lblDiasSelect
        '
        Me.lblDiasSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiasSelect.Location = New System.Drawing.Point(3, 6)
        Me.lblDiasSelect.Name = "lblDiasSelect"
        Me.lblDiasSelect.Size = New System.Drawing.Size(440, 32)
        Me.lblDiasSelect.TabIndex = 0
        Me.lblDiasSelect.Text = "Días seleccionados:"
        Me.lblDiasSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnSacarDia)
        Me.Panel3.Controls.Add(Me.btnAgregarDia)
        Me.Panel3.Controls.Add(Me.cbDiasSemana)
        Me.Panel3.Controls.Add(Me.lblDiasSemana)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 173)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(446, 164)
        Me.Panel3.TabIndex = 3
        '
        'btnSacarDia
        '
        Me.btnSacarDia.BackgroundImage = CType(resources.GetObject("btnSacarDia.BackgroundImage"), System.Drawing.Image)
        Me.btnSacarDia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSacarDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSacarDia.Location = New System.Drawing.Point(396, 96)
        Me.btnSacarDia.Name = "btnSacarDia"
        Me.btnSacarDia.Size = New System.Drawing.Size(47, 37)
        Me.btnSacarDia.TabIndex = 3
        Me.btnSacarDia.UseVisualStyleBackColor = True
        '
        'btnAgregarDia
        '
        Me.btnAgregarDia.BackgroundImage = CType(resources.GetObject("btnAgregarDia.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarDia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarDia.Location = New System.Drawing.Point(343, 96)
        Me.btnAgregarDia.Name = "btnAgregarDia"
        Me.btnAgregarDia.Size = New System.Drawing.Size(47, 37)
        Me.btnAgregarDia.TabIndex = 2
        Me.btnAgregarDia.UseVisualStyleBackColor = True
        '
        'cbDiasSemana
        '
        Me.cbDiasSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDiasSemana.FormattingEnabled = True
        Me.cbDiasSemana.Location = New System.Drawing.Point(17, 96)
        Me.cbDiasSemana.Name = "cbDiasSemana"
        Me.cbDiasSemana.Size = New System.Drawing.Size(320, 37)
        Me.cbDiasSemana.TabIndex = 1
        '
        'lblDiasSemana
        '
        Me.lblDiasSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiasSemana.Location = New System.Drawing.Point(3, 10)
        Me.lblDiasSemana.Name = "lblDiasSemana"
        Me.lblDiasSemana.Size = New System.Drawing.Size(440, 83)
        Me.lblDiasSemana.TabIndex = 0
        Me.lblDiasSemana.Text = "Días de la semana en los que se hace este tratamiento:"
        Me.lblDiasSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtpFechaFin)
        Me.Panel2.Controls.Add(Me.lblFechaFin)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(455, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(447, 164)
        Me.Panel2.TabIndex = 2
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Location = New System.Drawing.Point(57, 96)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(332, 34)
        Me.dtpFechaFin.TabIndex = 1
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFin.Location = New System.Drawing.Point(6, 53)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(434, 25)
        Me.lblFechaFin.TabIndex = 0
        Me.lblFechaFin.Text = "Indique fecha de finalización del tratamiento"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtpFechaInicio)
        Me.Panel1.Controls.Add(Me.lblFechaIni)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(446, 164)
        Me.Panel1.TabIndex = 0
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Location = New System.Drawing.Point(45, 96)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(332, 34)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'lblFechaIni
        '
        Me.lblFechaIni.AutoSize = True
        Me.lblFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIni.Location = New System.Drawing.Point(27, 53)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(376, 25)
        Me.lblFechaIni.TabIndex = 0
        Me.lblFechaIni.Text = "Indique fecha de inicio del tratamiento"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Location = New System.Drawing.Point(0, 341)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(905, 55)
        Me.btnConfirmar.TabIndex = 1
        Me.btnConfirmar.Text = "CONFIRMAR"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'frmParametrosTemporalesT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(905, 396)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmParametrosTemporalesT"
        Me.Text = "Definir parámetros temporales"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblFechaIni As Label
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblDiasSemana As Label
    Friend WithEvents cbDiasSemana As ComboBox
    Friend WithEvents btnAgregarDia As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblDiasSelect As Label
    Friend WithEvents lbDiasSelect As ListBox
    Friend WithEvents btnSacarDia As Button
    Friend WithEvents btnConfirmar As Button
End Class
