<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionarFormularioEntrevista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeleccionarFormularioEntrevista))
        Me.btnFrmOtro = New System.Windows.Forms.Button()
        Me.btnFrmMalestar = New System.Windows.Forms.Button()
        Me.btnFrmFiebre = New System.Windows.Forms.Button()
        Me.btnFrmDolor = New System.Windows.Forms.Button()
        Me.btnFrmGenerico = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFrmOtro
        '
        Me.btnFrmOtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFrmOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrmOtro.Image = CType(resources.GetObject("btnFrmOtro.Image"), System.Drawing.Image)
        Me.btnFrmOtro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFrmOtro.Location = New System.Drawing.Point(204, 432)
        Me.btnFrmOtro.Name = "btnFrmOtro"
        Me.btnFrmOtro.Size = New System.Drawing.Size(467, 94)
        Me.btnFrmOtro.TabIndex = 11
        Me.btnFrmOtro.Text = "Otro (Elegir)"
        Me.btnFrmOtro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFrmOtro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFrmOtro.UseVisualStyleBackColor = True
        '
        'btnFrmMalestar
        '
        Me.btnFrmMalestar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFrmMalestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrmMalestar.Image = CType(resources.GetObject("btnFrmMalestar.Image"), System.Drawing.Image)
        Me.btnFrmMalestar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFrmMalestar.Location = New System.Drawing.Point(204, 329)
        Me.btnFrmMalestar.Name = "btnFrmMalestar"
        Me.btnFrmMalestar.Size = New System.Drawing.Size(467, 94)
        Me.btnFrmMalestar.TabIndex = 10
        Me.btnFrmMalestar.Text = "Formulario para el malestar"
        Me.btnFrmMalestar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFrmMalestar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFrmMalestar.UseVisualStyleBackColor = True
        '
        'btnFrmFiebre
        '
        Me.btnFrmFiebre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFrmFiebre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrmFiebre.Image = CType(resources.GetObject("btnFrmFiebre.Image"), System.Drawing.Image)
        Me.btnFrmFiebre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFrmFiebre.Location = New System.Drawing.Point(204, 222)
        Me.btnFrmFiebre.Name = "btnFrmFiebre"
        Me.btnFrmFiebre.Size = New System.Drawing.Size(467, 94)
        Me.btnFrmFiebre.TabIndex = 9
        Me.btnFrmFiebre.Text = "Formulario para la fiebre"
        Me.btnFrmFiebre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFrmFiebre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFrmFiebre.UseVisualStyleBackColor = True
        '
        'btnFrmDolor
        '
        Me.btnFrmDolor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFrmDolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrmDolor.Image = CType(resources.GetObject("btnFrmDolor.Image"), System.Drawing.Image)
        Me.btnFrmDolor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFrmDolor.Location = New System.Drawing.Point(204, 117)
        Me.btnFrmDolor.Name = "btnFrmDolor"
        Me.btnFrmDolor.Size = New System.Drawing.Size(467, 94)
        Me.btnFrmDolor.TabIndex = 8
        Me.btnFrmDolor.Text = "Formulario para el dolor"
        Me.btnFrmDolor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFrmDolor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFrmDolor.UseVisualStyleBackColor = True
        '
        'btnFrmGenerico
        '
        Me.btnFrmGenerico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFrmGenerico.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrmGenerico.Image = CType(resources.GetObject("btnFrmGenerico.Image"), System.Drawing.Image)
        Me.btnFrmGenerico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFrmGenerico.Location = New System.Drawing.Point(204, 12)
        Me.btnFrmGenerico.Name = "btnFrmGenerico"
        Me.btnFrmGenerico.Size = New System.Drawing.Size(467, 94)
        Me.btnFrmGenerico.TabIndex = 7
        Me.btnFrmGenerico.Text = "Formulario Genérico"
        Me.btnFrmGenerico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFrmGenerico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFrmGenerico.UseVisualStyleBackColor = True
        '
        'frmSeleccionarFormularioEntrevista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 555)
        Me.Controls.Add(Me.btnFrmOtro)
        Me.Controls.Add(Me.btnFrmMalestar)
        Me.Controls.Add(Me.btnFrmFiebre)
        Me.Controls.Add(Me.btnFrmDolor)
        Me.Controls.Add(Me.btnFrmGenerico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSeleccionarFormularioEntrevista"
        Me.Text = "frmSeleccionarFormularioEntrevista"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFrmOtro As Button
    Friend WithEvents btnFrmMalestar As Button
    Friend WithEvents btnFrmFiebre As Button
    Friend WithEvents btnFrmDolor As Button
    Friend WithEvents btnFrmGenerico As Button
End Class
