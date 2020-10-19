<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTratamientoSeguir
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
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.txtFechaFinalizacion = New System.Windows.Forms.TextBox()
        Me.txtFechaInicio = New System.Windows.Forms.TextBox()
        Me.lbDiasSemana = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tblSeguimiento = New System.Windows.Forms.TableLayoutPanel()
        Me.txtSeguimiento = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDiasDisponiblesSeguimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblSeguimiento = New System.Windows.Forms.Label()
        Me.lblNombreTratamientoTXT = New System.Windows.Forms.Label()
        Me.lblIndicaciones = New System.Windows.Forms.Label()
        Me.txtDescripcionTratamiento = New System.Windows.Forms.TextBox()
        Me.tblResultado = New System.Windows.Forms.TableLayoutPanel()
        Me.btnResultado = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.pnlContenedor.SuspendLayout()
        Me.tblSeguimiento.SuspendLayout()
        Me.tblResultado.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.AutoScroll = True
        Me.pnlContenedor.AutoSize = True
        Me.pnlContenedor.Controls.Add(Me.txtFechaFinalizacion)
        Me.pnlContenedor.Controls.Add(Me.txtFechaInicio)
        Me.pnlContenedor.Controls.Add(Me.lbDiasSemana)
        Me.pnlContenedor.Controls.Add(Me.Label2)
        Me.pnlContenedor.Controls.Add(Me.tblSeguimiento)
        Me.pnlContenedor.Controls.Add(Me.lblFechaFin)
        Me.pnlContenedor.Controls.Add(Me.lblFechaInicio)
        Me.pnlContenedor.Controls.Add(Me.Label1)
        Me.pnlContenedor.Controls.Add(Me.dtpDiasDisponiblesSeguimiento)
        Me.pnlContenedor.Controls.Add(Me.lblSeguimiento)
        Me.pnlContenedor.Controls.Add(Me.lblNombreTratamientoTXT)
        Me.pnlContenedor.Controls.Add(Me.lblIndicaciones)
        Me.pnlContenedor.Controls.Add(Me.txtDescripcionTratamiento)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1187, 720)
        Me.pnlContenedor.TabIndex = 0
        '
        'txtFechaFinalizacion
        '
        Me.txtFechaFinalizacion.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtFechaFinalizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaFinalizacion.Location = New System.Drawing.Point(282, 98)
        Me.txtFechaFinalizacion.Name = "txtFechaFinalizacion"
        Me.txtFechaFinalizacion.ReadOnly = True
        Me.txtFechaFinalizacion.Size = New System.Drawing.Size(138, 30)
        Me.txtFechaFinalizacion.TabIndex = 119
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaInicio.Location = New System.Drawing.Point(282, 51)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.ReadOnly = True
        Me.txtFechaInicio.Size = New System.Drawing.Size(138, 30)
        Me.txtFechaInicio.TabIndex = 118
        '
        'lbDiasSemana
        '
        Me.lbDiasSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDiasSemana.FormattingEnabled = True
        Me.lbDiasSemana.ItemHeight = 25
        Me.lbDiasSemana.Location = New System.Drawing.Point(586, 44)
        Me.lbDiasSemana.Name = "lbDiasSemana"
        Me.lbDiasSemana.Size = New System.Drawing.Size(558, 79)
        Me.lbDiasSemana.TabIndex = 117
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(597, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(532, 25)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Días de semana en los que se realiza este tratamiento"
        '
        'tblSeguimiento
        '
        Me.tblSeguimiento.ColumnCount = 1
        Me.tblSeguimiento.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblSeguimiento.Controls.Add(Me.txtSeguimiento, 0, 0)
        Me.tblSeguimiento.Controls.Add(Me.btnGuardar, 0, 1)
        Me.tblSeguimiento.Controls.Add(Me.tblResultado, 0, 2)
        Me.tblSeguimiento.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tblSeguimiento.Location = New System.Drawing.Point(0, 705)
        Me.tblSeguimiento.Name = "tblSeguimiento"
        Me.tblSeguimiento.RowCount = 3
        Me.tblSeguimiento.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.9222!))
        Me.tblSeguimiento.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0778!))
        Me.tblSeguimiento.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.tblSeguimiento.Size = New System.Drawing.Size(1166, 573)
        Me.tblSeguimiento.TabIndex = 113
        '
        'txtSeguimiento
        '
        Me.txtSeguimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeguimiento.Location = New System.Drawing.Point(3, 3)
        Me.txtSeguimiento.Multiline = True
        Me.txtSeguimiento.Name = "txtSeguimiento"
        Me.txtSeguimiento.Size = New System.Drawing.Size(1160, 397)
        Me.txtSeguimiento.TabIndex = 107
        '
        'btnGuardar
        '
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(3, 406)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(1160, 82)
        Me.btnGuardar.TabIndex = 108
        Me.btnGuardar.Text = "GUARDAR SEGUIMIENTO DIARIO"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFin.Location = New System.Drawing.Point(12, 99)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(245, 29)
        Me.lblFechaFin.TabIndex = 109
        Me.lblFechaFin.Text = "Fecha de finalización:"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInicio.Location = New System.Drawing.Point(12, 52)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(183, 29)
        Me.lblFechaInicio.TabIndex = 108
        Me.lblFechaInicio.Text = "Fecha de inicio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 676)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 29)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Día:"
        '
        'dtpDiasDisponiblesSeguimiento
        '
        Me.dtpDiasDisponiblesSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDiasDisponiblesSeguimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDiasDisponiblesSeguimiento.Location = New System.Drawing.Point(64, 674)
        Me.dtpDiasDisponiblesSeguimiento.Name = "dtpDiasDisponiblesSeguimiento"
        Me.dtpDiasDisponiblesSeguimiento.Size = New System.Drawing.Size(159, 30)
        Me.dtpDiasDisponiblesSeguimiento.TabIndex = 104
        Me.dtpDiasDisponiblesSeguimiento.Value = New Date(2020, 8, 19, 0, 0, 0, 0)
        '
        'lblSeguimiento
        '
        Me.lblSeguimiento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSeguimiento.AutoSize = True
        Me.lblSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeguimiento.Location = New System.Drawing.Point(483, 637)
        Me.lblSeguimiento.Name = "lblSeguimiento"
        Me.lblSeguimiento.Size = New System.Drawing.Size(155, 29)
        Me.lblSeguimiento.TabIndex = 103
        Me.lblSeguimiento.Text = "Seguimiento:"
        '
        'lblNombreTratamientoTXT
        '
        Me.lblNombreTratamientoTXT.AutoSize = True
        Me.lblNombreTratamientoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTratamientoTXT.Location = New System.Drawing.Point(12, 9)
        Me.lblNombreTratamientoTXT.Name = "lblNombreTratamientoTXT"
        Me.lblNombreTratamientoTXT.Size = New System.Drawing.Size(390, 25)
        Me.lblNombreTratamientoTXT.TabIndex = 102
        Me.lblNombreTratamientoTXT.Text = "CI PACIENTE - NOMBRE TRATAMIENTO"
        '
        'lblIndicaciones
        '
        Me.lblIndicaciones.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblIndicaciones.AutoSize = True
        Me.lblIndicaciones.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicaciones.Location = New System.Drawing.Point(427, 150)
        Me.lblIndicaciones.Name = "lblIndicaciones"
        Me.lblIndicaciones.Size = New System.Drawing.Size(312, 27)
        Me.lblIndicaciones.TabIndex = 92
        Me.lblIndicaciones.Text = "Indicaciones del tratamiento"
        '
        'txtDescripcionTratamiento
        '
        Me.txtDescripcionTratamiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionTratamiento.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtDescripcionTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionTratamiento.Location = New System.Drawing.Point(3, 191)
        Me.txtDescripcionTratamiento.Multiline = True
        Me.txtDescripcionTratamiento.Name = "txtDescripcionTratamiento"
        Me.txtDescripcionTratamiento.ReadOnly = True
        Me.txtDescripcionTratamiento.Size = New System.Drawing.Size(1159, 422)
        Me.txtDescripcionTratamiento.TabIndex = 91
        '
        'tblResultado
        '
        Me.tblResultado.ColumnCount = 3
        Me.tblResultado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblResultado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblResultado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblResultado.Controls.Add(Me.btnResultado, 2, 0)
        Me.tblResultado.Controls.Add(Me.Label3, 0, 0)
        Me.tblResultado.Controls.Add(Me.txtResultado, 1, 0)
        Me.tblResultado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblResultado.Location = New System.Drawing.Point(3, 494)
        Me.tblResultado.Name = "tblResultado"
        Me.tblResultado.RowCount = 1
        Me.tblResultado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblResultado.Size = New System.Drawing.Size(1160, 76)
        Me.tblResultado.TabIndex = 109
        '
        'btnResultado
        '
        Me.btnResultado.Enabled = False
        Me.btnResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResultado.Location = New System.Drawing.Point(775, 3)
        Me.btnResultado.Name = "btnResultado"
        Me.btnResultado.Size = New System.Drawing.Size(382, 69)
        Me.btnResultado.TabIndex = 110
        Me.btnResultado.Text = "ACTUALIZAR RESULTADO DEL TRATAMIENTO"
        Me.btnResultado.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(319, 29)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Resultado del tratamiento:"
        '
        'txtResultado
        '
        Me.txtResultado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.Location = New System.Drawing.Point(389, 21)
        Me.txtResultado.MaxLength = 60
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(380, 34)
        Me.txtResultado.TabIndex = 112
        '
        'frmTratamientoSeguir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1187, 720)
        Me.Controls.Add(Me.pnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTratamientoSeguir"
        Me.Text = "frmTratamientoSeguir"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.tblSeguimiento.ResumeLayout(False)
        Me.tblSeguimiento.PerformLayout()
        Me.tblResultado.ResumeLayout(False)
        Me.tblResultado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents lblIndicaciones As Label
    Friend WithEvents txtDescripcionTratamiento As TextBox
    Friend WithEvents lblNombreTratamientoTXT As Label
    Friend WithEvents lblSeguimiento As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDiasDisponiblesSeguimiento As DateTimePicker
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents tblSeguimiento As TableLayoutPanel
    Friend WithEvents txtSeguimiento As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbDiasSemana As ListBox
    Friend WithEvents txtFechaFinalizacion As TextBox
    Friend WithEvents txtFechaInicio As TextBox
    Friend WithEvents tblResultado As TableLayoutPanel
    Friend WithEvents btnResultado As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtResultado As TextBox
End Class
