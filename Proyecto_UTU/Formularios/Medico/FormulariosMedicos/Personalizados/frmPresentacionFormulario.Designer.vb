<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresentacionFormulario
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
        Me.pBoxVistaPrevia = New System.Windows.Forms.PictureBox()
        Me.lblNombreForm = New System.Windows.Forms.Label()
        CType(Me.pBoxVistaPrevia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pBoxVistaPrevia
        '
        Me.pBoxVistaPrevia.Location = New System.Drawing.Point(12, 42)
        Me.pBoxVistaPrevia.Name = "pBoxVistaPrevia"
        Me.pBoxVistaPrevia.Size = New System.Drawing.Size(333, 278)
        Me.pBoxVistaPrevia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxVistaPrevia.TabIndex = 0
        Me.pBoxVistaPrevia.TabStop = False
        '
        'lblNombreForm
        '
        Me.lblNombreForm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNombreForm.AutoSize = True
        Me.lblNombreForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreForm.Location = New System.Drawing.Point(52, 10)
        Me.lblNombreForm.Name = "lblNombreForm"
        Me.lblNombreForm.Size = New System.Drawing.Size(241, 29)
        Me.lblNombreForm.TabIndex = 1
        Me.lblNombreForm.Text = "Nombre Formulario"
        '
        'frmPresentacionFormulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(357, 332)
        Me.Controls.Add(Me.lblNombreForm)
        Me.Controls.Add(Me.pBoxVistaPrevia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPresentacionFormulario"
        Me.Text = "frmPresentacionFormulario"
        CType(Me.pBoxVistaPrevia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pBoxVistaPrevia As PictureBox
    Friend WithEvents lblNombreForm As Label
End Class
