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
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblSeguimiento = New System.Windows.Forms.Label()
        Me.lblNombreTratamientoTXT = New System.Windows.Forms.Label()
        Me.lblIndicaciones = New System.Windows.Forms.Label()
        Me.txtDescripcionTratamiento = New System.Windows.Forms.TextBox()
        Me.lblNombreTratamiento = New System.Windows.Forms.Label()
        Me.pnlContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.AutoScroll = True
        Me.pnlContenedor.AutoSize = True
        Me.pnlContenedor.Controls.Add(Me.DateTimePicker2)
        Me.pnlContenedor.Controls.Add(Me.txtDuracion)
        Me.pnlContenedor.Controls.Add(Me.lblDuracion)
        Me.pnlContenedor.Controls.Add(Me.lblFechaFin)
        Me.pnlContenedor.Controls.Add(Me.lblFechaInicio)
        Me.pnlContenedor.Controls.Add(Me.dtpFechaInicio)
        Me.pnlContenedor.Controls.Add(Me.TextBox1)
        Me.pnlContenedor.Controls.Add(Me.Label1)
        Me.pnlContenedor.Controls.Add(Me.DateTimePicker1)
        Me.pnlContenedor.Controls.Add(Me.lblSeguimiento)
        Me.pnlContenedor.Controls.Add(Me.lblNombreTratamientoTXT)
        Me.pnlContenedor.Controls.Add(Me.lblIndicaciones)
        Me.pnlContenedor.Controls.Add(Me.txtDescripcionTratamiento)
        Me.pnlContenedor.Controls.Add(Me.lblNombreTratamiento)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1153, 720)
        Me.pnlContenedor.TabIndex = 0
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(617, 65)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(145, 30)
        Me.DateTimePicker2.TabIndex = 112
        Me.DateTimePicker2.Value = New Date(2020, 8, 19, 0, 0, 0, 0)
        '
        'txtDuracion
        '
        Me.txtDuracion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDuracion.Enabled = False
        Me.txtDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuracion.Location = New System.Drawing.Point(969, 67)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(159, 30)
        Me.txtDuracion.TabIndex = 111
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracion.Location = New System.Drawing.Point(781, 67)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(182, 29)
        Me.lblDuracion.TabIndex = 110
        Me.lblDuracion.Text = "Duración (días):"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFin.Location = New System.Drawing.Point(366, 67)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(245, 29)
        Me.lblFechaFin.TabIndex = 109
        Me.lblFechaFin.Text = "Fecha de finalización:"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInicio.Location = New System.Drawing.Point(12, 67)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(183, 29)
        Me.lblFechaInicio.TabIndex = 108
        Me.lblFechaInicio.Text = "Fecha de inicio:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(215, 65)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(145, 30)
        Me.dtpFechaInicio.TabIndex = 107
        Me.dtpFechaInicio.Value = New Date(2020, 8, 19, 0, 0, 0, 0)
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(3, 710)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1125, 209)
        Me.TextBox1.TabIndex = 106
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(64, 674)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(159, 30)
        Me.DateTimePicker1.TabIndex = 104
        Me.DateTimePicker1.Value = New Date(2020, 8, 19, 0, 0, 0, 0)
        '
        'lblSeguimiento
        '
        Me.lblSeguimiento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSeguimiento.AutoSize = True
        Me.lblSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeguimiento.Location = New System.Drawing.Point(467, 640)
        Me.lblSeguimiento.Name = "lblSeguimiento"
        Me.lblSeguimiento.Size = New System.Drawing.Size(155, 29)
        Me.lblSeguimiento.TabIndex = 103
        Me.lblSeguimiento.Text = "Seguimiento:"
        '
        'lblNombreTratamientoTXT
        '
        Me.lblNombreTratamientoTXT.AutoSize = True
        Me.lblNombreTratamientoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTratamientoTXT.Location = New System.Drawing.Point(290, 14)
        Me.lblNombreTratamientoTXT.Name = "lblNombreTratamientoTXT"
        Me.lblNombreTratamientoTXT.Size = New System.Drawing.Size(248, 25)
        Me.lblNombreTratamientoTXT.TabIndex = 102
        Me.lblNombreTratamientoTXT.Text = "NOMBRE TRATAMIENTO"
        '
        'lblIndicaciones
        '
        Me.lblIndicaciones.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblIndicaciones.AutoSize = True
        Me.lblIndicaciones.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicaciones.Location = New System.Drawing.Point(402, 137)
        Me.lblIndicaciones.Name = "lblIndicaciones"
        Me.lblIndicaciones.Size = New System.Drawing.Size(312, 27)
        Me.lblIndicaciones.TabIndex = 92
        Me.lblIndicaciones.Text = "Indicaciones del tratamiento"
        '
        'txtDescripcionTratamiento
        '
        Me.txtDescripcionTratamiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionTratamiento.Location = New System.Drawing.Point(3, 182)
        Me.txtDescripcionTratamiento.Multiline = True
        Me.txtDescripcionTratamiento.Name = "txtDescripcionTratamiento"
        Me.txtDescripcionTratamiento.Size = New System.Drawing.Size(1125, 444)
        Me.txtDescripcionTratamiento.TabIndex = 91
        '
        'lblNombreTratamiento
        '
        Me.lblNombreTratamiento.AutoSize = True
        Me.lblNombreTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTratamiento.Location = New System.Drawing.Point(12, 11)
        Me.lblNombreTratamiento.Name = "lblNombreTratamiento"
        Me.lblNombreTratamiento.Size = New System.Drawing.Size(272, 29)
        Me.lblNombreTratamiento.TabIndex = 90
        Me.lblNombreTratamiento.Text = "Nombre del tratamiento:"
        '
        'frmTratamientoSeguir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1153, 720)
        Me.Controls.Add(Me.pnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTratamientoSeguir"
        Me.Text = "frmTratamientoSeguir"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents lblIndicaciones As Label
    Friend WithEvents txtDescripcionTratamiento As TextBox
    Friend WithEvents lblNombreTratamiento As Label
    Friend WithEvents lblNombreTratamientoTXT As Label
    Friend WithEvents lblSeguimiento As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents txtDuracion As TextBox
    Friend WithEvents lblDuracion As Label
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents dtpFechaInicio As DateTimePicker
End Class
