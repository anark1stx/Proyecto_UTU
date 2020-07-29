<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpcionesConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpcionesConsulta))
        Me.btnIdentificacion = New System.Windows.Forms.Button()
        Me.btnEntrevistaPaciente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnIdentificacion
        '
        Me.btnIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIdentificacion.Image = CType(resources.GetObject("btnIdentificacion.Image"), System.Drawing.Image)
        Me.btnIdentificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIdentificacion.Location = New System.Drawing.Point(205, 108)
        Me.btnIdentificacion.Name = "btnIdentificacion"
        Me.btnIdentificacion.Size = New System.Drawing.Size(467, 102)
        Me.btnIdentificacion.TabIndex = 0
        Me.btnIdentificacion.Text = "Identificación del paciente"
        Me.btnIdentificacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIdentificacion.UseVisualStyleBackColor = True
        '
        'btnEntrevistaPaciente
        '
        Me.btnEntrevistaPaciente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEntrevistaPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrevistaPaciente.Image = CType(resources.GetObject("btnEntrevistaPaciente.Image"), System.Drawing.Image)
        Me.btnEntrevistaPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntrevistaPaciente.Location = New System.Drawing.Point(205, 266)
        Me.btnEntrevistaPaciente.Name = "btnEntrevistaPaciente"
        Me.btnEntrevistaPaciente.Size = New System.Drawing.Size(467, 102)
        Me.btnEntrevistaPaciente.TabIndex = 1
        Me.btnEntrevistaPaciente.Text = "Entrevista al paciente"
        Me.btnEntrevistaPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEntrevistaPaciente.UseVisualStyleBackColor = True
        '
        'frmOpcionesConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 555)
        Me.Controls.Add(Me.btnEntrevistaPaciente)
        Me.Controls.Add(Me.btnIdentificacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOpcionesConsulta"
        Me.Text = "frmOpcionesConsulta"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnIdentificacion As Button
    Friend WithEvents btnEntrevistaPaciente As Button
End Class
