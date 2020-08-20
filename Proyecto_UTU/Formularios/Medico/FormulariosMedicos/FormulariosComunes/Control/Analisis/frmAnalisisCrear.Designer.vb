<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalisisCrear
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
        Me.txtNombreTratamiento = New System.Windows.Forms.TextBox()
        Me.lblNombreTratamiento = New System.Windows.Forms.Label()
        Me.lblTipoResultados = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNombreTratamiento
        '
        Me.txtNombreTratamiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreTratamiento.Location = New System.Drawing.Point(290, 11)
        Me.txtNombreTratamiento.Name = "txtNombreTratamiento"
        Me.txtNombreTratamiento.Size = New System.Drawing.Size(828, 30)
        Me.txtNombreTratamiento.TabIndex = 89
        '
        'lblNombreTratamiento
        '
        Me.lblNombreTratamiento.AutoSize = True
        Me.lblNombreTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTratamiento.Location = New System.Drawing.Point(12, 11)
        Me.lblNombreTratamiento.Name = "lblNombreTratamiento"
        Me.lblNombreTratamiento.Size = New System.Drawing.Size(234, 29)
        Me.lblNombreTratamiento.TabIndex = 78
        Me.lblNombreTratamiento.Text = "Nombre del análisis:"
        '
        'lblTipoResultados
        '
        Me.lblTipoResultados.AutoSize = True
        Me.lblTipoResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoResultados.Location = New System.Drawing.Point(12, 112)
        Me.lblTipoResultados.Name = "lblTipoResultados"
        Me.lblTipoResultados.Size = New System.Drawing.Size(238, 29)
        Me.lblTipoResultados.TabIndex = 90
        Me.lblTipoResultados.Text = "Resultados posibles:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(290, 104)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(640, 37)
        Me.ComboBox1.TabIndex = 92
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(936, 104)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(90, 37)
        Me.btnAgregar.TabIndex = 93
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(1028, 104)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(90, 37)
        Me.btnEliminar.TabIndex = 94
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1028, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 37)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "ELIMINAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(936, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 37)
        Me.Button2.TabIndex = 97
        Me.Button2.Text = "AGREGAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(290, 53)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(640, 37)
        Me.ComboBox2.TabIndex = 96
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 29)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Parámetros a registrar:"
        '
        'frmAnalisisCrear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1130, 171)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblTipoResultados)
        Me.Controls.Add(Me.txtNombreTratamiento)
        Me.Controls.Add(Me.lblNombreTratamiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAnalisisCrear"
        Me.Text = "frmAnalisisCrear"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombreTratamiento As TextBox
    Friend WithEvents lblNombreTratamiento As Label
    Friend WithEvents lblTipoResultados As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label1 As Label
End Class
