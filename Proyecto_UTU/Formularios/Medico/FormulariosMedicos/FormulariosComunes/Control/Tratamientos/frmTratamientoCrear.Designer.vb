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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTratamientoCrear))
        Me.lblNombreTratamiento = New System.Windows.Forms.Label()
        Me.txtDescripcionTratamiento = New System.Windows.Forms.TextBox()
        Me.lblIndicaciones = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.txtNombreTratamiento = New System.Windows.Forms.TextBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lblNombreTratamiento
        '
        Me.lblNombreTratamiento.AutoSize = True
        Me.lblNombreTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTratamiento.Location = New System.Drawing.Point(12, 19)
        Me.lblNombreTratamiento.Name = "lblNombreTratamiento"
        Me.lblNombreTratamiento.Size = New System.Drawing.Size(272, 29)
        Me.lblNombreTratamiento.TabIndex = 0
        Me.lblNombreTratamiento.Text = "Nombre del tratamiento:"
        '
        'txtDescripcionTratamiento
        '
        Me.txtDescripcionTratamiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionTratamiento.Location = New System.Drawing.Point(3, 223)
        Me.txtDescripcionTratamiento.Multiline = True
        Me.txtDescripcionTratamiento.Name = "txtDescripcionTratamiento"
        Me.txtDescripcionTratamiento.Size = New System.Drawing.Size(1125, 444)
        Me.txtDescripcionTratamiento.TabIndex = 1
        '
        'lblIndicaciones
        '
        Me.lblIndicaciones.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblIndicaciones.AutoSize = True
        Me.lblIndicaciones.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicaciones.Location = New System.Drawing.Point(402, 178)
        Me.lblIndicaciones.Name = "lblIndicaciones"
        Me.lblIndicaciones.Size = New System.Drawing.Size(312, 27)
        Me.lblIndicaciones.TabIndex = 2
        Me.lblIndicaciones.Text = "Indicaciones del tratamiento"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(215, 100)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(145, 30)
        Me.dtpFechaInicio.TabIndex = 3
        Me.dtpFechaInicio.Value = New Date(2020, 8, 19, 0, 0, 0, 0)
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInicio.Location = New System.Drawing.Point(12, 102)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(183, 29)
        Me.lblFechaInicio.TabIndex = 5
        Me.lblFechaInicio.Text = "Fecha de inicio:"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFin.Location = New System.Drawing.Point(366, 102)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(245, 29)
        Me.lblFechaFin.TabIndex = 7
        Me.lblFechaFin.Text = "Fecha de finalización:"
        '
        'txtDuracion
        '
        Me.txtDuracion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDuracion.Enabled = False
        Me.txtDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuracion.Location = New System.Drawing.Point(969, 102)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(159, 30)
        Me.txtDuracion.TabIndex = 10
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracion.Location = New System.Drawing.Point(781, 102)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(182, 29)
        Me.lblDuracion.TabIndex = 9
        Me.lblDuracion.Text = "Duración (días):"
        '
        'txtNombreTratamiento
        '
        Me.txtNombreTratamiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreTratamiento.Location = New System.Drawing.Point(290, 19)
        Me.txtNombreTratamiento.Name = "txtNombreTratamiento"
        Me.txtNombreTratamiento.Size = New System.Drawing.Size(828, 30)
        Me.txtNombreTratamiento.TabIndex = 76
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(457, 673)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(146, 45)
        Me.btnImprimir.TabIndex = 75
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(305, 673)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(146, 45)
        Me.btnLimpiar.TabIndex = 74
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(609, 673)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(146, 45)
        Me.btnGuardar.TabIndex = 73
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(617, 100)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(145, 30)
        Me.DateTimePicker1.TabIndex = 77
        Me.DateTimePicker1.Value = New Date(2020, 8, 19, 0, 0, 0, 0)
        '
        'frmTratamientoCrear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1130, 720)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtNombreTratamiento)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.lblDuracion)
        Me.Controls.Add(Me.lblFechaFin)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.lblIndicaciones)
        Me.Controls.Add(Me.txtDescripcionTratamiento)
        Me.Controls.Add(Me.lblNombreTratamiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTratamientoCrear"
        Me.Text = "frmTratamiento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombreTratamiento As Label
    Friend WithEvents txtDescripcionTratamiento As TextBox
    Friend WithEvents lblIndicaciones As Label
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents txtDuracion As TextBox
    Friend WithEvents lblDuracion As Label
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtNombreTratamiento As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
