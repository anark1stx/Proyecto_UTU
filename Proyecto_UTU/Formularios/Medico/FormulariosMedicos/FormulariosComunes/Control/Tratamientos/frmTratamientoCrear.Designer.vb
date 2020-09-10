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
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cbDias = New System.Windows.Forms.ComboBox()
        Me.txtNombreTratamiento = New System.Windows.Forms.TextBox()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.lblIndicaciones = New System.Windows.Forms.Label()
        Me.txtDescripcionTratamiento = New System.Windows.Forms.TextBox()
        Me.lblNombreTratamiento = New System.Windows.Forms.Label()
        Me.pnlContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.btnGuardar)
        Me.pnlContenedor.Controls.Add(Me.cbDias)
        Me.pnlContenedor.Controls.Add(Me.txtNombreTratamiento)
        Me.pnlContenedor.Controls.Add(Me.lblDuracion)
        Me.pnlContenedor.Controls.Add(Me.lblIndicaciones)
        Me.pnlContenedor.Controls.Add(Me.txtDescripcionTratamiento)
        Me.pnlContenedor.Controls.Add(Me.lblNombreTratamiento)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1130, 720)
        Me.pnlContenedor.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(0, 653)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(1130, 67)
        Me.btnGuardar.TabIndex = 84
        Me.btnGuardar.Text = "Guardar Tratamiento"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'cbDias
        '
        Me.cbDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDias.FormattingEnabled = True
        Me.cbDias.Location = New System.Drawing.Point(290, 54)
        Me.cbDias.Name = "cbDias"
        Me.cbDias.Size = New System.Drawing.Size(121, 33)
        Me.cbDias.TabIndex = 83
        '
        'txtNombreTratamiento
        '
        Me.txtNombreTratamiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreTratamiento.Location = New System.Drawing.Point(290, 9)
        Me.txtNombreTratamiento.Name = "txtNombreTratamiento"
        Me.txtNombreTratamiento.Size = New System.Drawing.Size(838, 30)
        Me.txtNombreTratamiento.TabIndex = 82
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracion.Location = New System.Drawing.Point(12, 58)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(182, 29)
        Me.lblDuracion.TabIndex = 81
        Me.lblDuracion.Text = "Duración (días):"
        '
        'lblIndicaciones
        '
        Me.lblIndicaciones.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblIndicaciones.AutoSize = True
        Me.lblIndicaciones.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicaciones.Location = New System.Drawing.Point(402, 113)
        Me.lblIndicaciones.Name = "lblIndicaciones"
        Me.lblIndicaciones.Size = New System.Drawing.Size(312, 27)
        Me.lblIndicaciones.TabIndex = 80
        Me.lblIndicaciones.Text = "Indicaciones del tratamiento"
        '
        'txtDescripcionTratamiento
        '
        Me.txtDescripcionTratamiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionTratamiento.Location = New System.Drawing.Point(3, 143)
        Me.txtDescripcionTratamiento.Multiline = True
        Me.txtDescripcionTratamiento.Name = "txtDescripcionTratamiento"
        Me.txtDescripcionTratamiento.Size = New System.Drawing.Size(1125, 504)
        Me.txtDescripcionTratamiento.TabIndex = 79
        '
        'lblNombreTratamiento
        '
        Me.lblNombreTratamiento.AutoSize = True
        Me.lblNombreTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTratamiento.Location = New System.Drawing.Point(12, 9)
        Me.lblNombreTratamiento.Name = "lblNombreTratamiento"
        Me.lblNombreTratamiento.Size = New System.Drawing.Size(272, 29)
        Me.lblNombreTratamiento.TabIndex = 78
        Me.lblNombreTratamiento.Text = "Nombre del tratamiento:"
        '
        'frmTratamientoCrear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1130, 720)
        Me.Controls.Add(Me.pnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTratamientoCrear"
        Me.Text = "frmTratamiento"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents cbDias As ComboBox
    Friend WithEvents txtNombreTratamiento As TextBox
    Friend WithEvents lblDuracion As Label
    Friend WithEvents lblIndicaciones As Label
    Friend WithEvents txtDescripcionTratamiento As TextBox
    Friend WithEvents lblNombreTratamiento As Label
    Friend WithEvents btnGuardar As Button
End Class
