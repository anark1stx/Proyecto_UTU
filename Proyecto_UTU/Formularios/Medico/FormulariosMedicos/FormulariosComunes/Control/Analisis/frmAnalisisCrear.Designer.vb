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
        Me.txtNombreTratamiento = New System.Windows.Forms.TextBox()
        Me.lblNombreTratamiento = New System.Windows.Forms.Label()
        Me.btnEliminarParametro = New System.Windows.Forms.Button()
        Me.btnAgregarParametro = New System.Windows.Forms.Button()
        Me.cbParametros = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregarAnalisis = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNombreTratamiento
        '
        Me.txtNombreTratamiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreTratamiento.Location = New System.Drawing.Point(290, 11)
        Me.txtNombreTratamiento.Name = "txtNombreTratamiento"
        Me.txtNombreTratamiento.Size = New System.Drawing.Size(593, 30)
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
        'btnEliminarParametro
        '
        Me.btnEliminarParametro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarParametro.Location = New System.Drawing.Point(757, 53)
        Me.btnEliminarParametro.Name = "btnEliminarParametro"
        Me.btnEliminarParametro.Size = New System.Drawing.Size(126, 37)
        Me.btnEliminarParametro.TabIndex = 98
        Me.btnEliminarParametro.Text = "ELIMINAR"
        Me.btnEliminarParametro.UseVisualStyleBackColor = True
        '
        'btnAgregarParametro
        '
        Me.btnAgregarParametro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarParametro.Location = New System.Drawing.Point(634, 53)
        Me.btnAgregarParametro.Name = "btnAgregarParametro"
        Me.btnAgregarParametro.Size = New System.Drawing.Size(117, 37)
        Me.btnAgregarParametro.TabIndex = 97
        Me.btnAgregarParametro.Text = "AGREGAR"
        Me.btnAgregarParametro.UseVisualStyleBackColor = True
        '
        'cbParametros
        '
        Me.cbParametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbParametros.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbParametros.FormattingEnabled = True
        Me.cbParametros.Location = New System.Drawing.Point(290, 53)
        Me.cbParametros.Name = "cbParametros"
        Me.cbParametros.Size = New System.Drawing.Size(338, 37)
        Me.cbParametros.TabIndex = 96
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
        'btnAgregarAnalisis
        '
        Me.btnAgregarAnalisis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarAnalisis.Location = New System.Drawing.Point(17, 113)
        Me.btnAgregarAnalisis.Name = "btnAgregarAnalisis"
        Me.btnAgregarAnalisis.Size = New System.Drawing.Size(866, 55)
        Me.btnAgregarAnalisis.TabIndex = 99
        Me.btnAgregarAnalisis.Text = "Guardar Análisis"
        Me.btnAgregarAnalisis.UseVisualStyleBackColor = True
        '
        'frmAnalisisCrear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 180)
        Me.Controls.Add(Me.btnAgregarAnalisis)
        Me.Controls.Add(Me.btnEliminarParametro)
        Me.Controls.Add(Me.btnAgregarParametro)
        Me.Controls.Add(Me.cbParametros)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents btnEliminarParametro As Button
    Friend WithEvents btnAgregarParametro As Button
    Friend WithEvents cbParametros As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregarAnalisis As Button
End Class
