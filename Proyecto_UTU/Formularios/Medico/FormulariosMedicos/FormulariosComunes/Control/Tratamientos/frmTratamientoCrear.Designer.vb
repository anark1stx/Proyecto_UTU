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
        Me.lblNombreTratamiento = New System.Windows.Forms.Label()
        Me.txtDescripcionTratamiento = New System.Windows.Forms.TextBox()
        Me.lblIndicaciones = New System.Windows.Forms.Label()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.txtNombreTratamiento = New System.Windows.Forms.TextBox()
        Me.cbDias = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblNombreTratamiento
        '
        Me.lblNombreTratamiento.AutoSize = True
        Me.lblNombreTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTratamiento.Location = New System.Drawing.Point(12, 14)
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
        Me.txtDescripcionTratamiento.Location = New System.Drawing.Point(3, 148)
        Me.txtDescripcionTratamiento.Multiline = True
        Me.txtDescripcionTratamiento.Name = "txtDescripcionTratamiento"
        Me.txtDescripcionTratamiento.Size = New System.Drawing.Size(1125, 504)
        Me.txtDescripcionTratamiento.TabIndex = 1
        '
        'lblIndicaciones
        '
        Me.lblIndicaciones.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblIndicaciones.AutoSize = True
        Me.lblIndicaciones.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicaciones.Location = New System.Drawing.Point(402, 118)
        Me.lblIndicaciones.Name = "lblIndicaciones"
        Me.lblIndicaciones.Size = New System.Drawing.Size(312, 27)
        Me.lblIndicaciones.TabIndex = 2
        Me.lblIndicaciones.Text = "Indicaciones del tratamiento"
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracion.Location = New System.Drawing.Point(12, 63)
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
        Me.txtNombreTratamiento.Location = New System.Drawing.Point(290, 14)
        Me.txtNombreTratamiento.Name = "txtNombreTratamiento"
        Me.txtNombreTratamiento.Size = New System.Drawing.Size(838, 30)
        Me.txtNombreTratamiento.TabIndex = 76
        '
        'cbDias
        '
        Me.cbDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDias.FormattingEnabled = True
        Me.cbDias.Location = New System.Drawing.Point(290, 59)
        Me.cbDias.Name = "cbDias"
        Me.cbDias.Size = New System.Drawing.Size(121, 33)
        Me.cbDias.TabIndex = 77
        '
        'frmTratamientoCrear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1130, 720)
        Me.Controls.Add(Me.cbDias)
        Me.Controls.Add(Me.txtNombreTratamiento)
        Me.Controls.Add(Me.lblDuracion)
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
    Friend WithEvents lblDuracion As Label
    Friend WithEvents txtNombreTratamiento As TextBox
    Friend WithEvents cbDias As ComboBox
End Class
