<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPedirNombreForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedirNombreForm))
        Me.lblNomForm = New System.Windows.Forms.Label()
        Me.txtNombreForm = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNomForm
        '
        Me.lblNomForm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNomForm.AutoSize = True
        Me.lblNomForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomForm.Location = New System.Drawing.Point(99, 9)
        Me.lblNomForm.Name = "lblNomForm"
        Me.lblNomForm.Size = New System.Drawing.Size(560, 25)
        Me.lblNomForm.TabIndex = 0
        Me.lblNomForm.Text = "Ingrese el nombre con el que desea guardar el formulario"
        '
        'txtNombreForm
        '
        Me.txtNombreForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreForm.Location = New System.Drawing.Point(100, 50)
        Me.txtNombreForm.Name = "txtNombreForm"
        Me.txtNombreForm.Size = New System.Drawing.Size(499, 30)
        Me.txtNombreForm.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Yellow
        Me.btnOK.BackgroundImage = CType(resources.GetObject("btnOK.BackgroundImage"), System.Drawing.Image)
        Me.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Location = New System.Drawing.Point(605, 50)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(46, 30)
        Me.btnOK.TabIndex = 2
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'frmPedirNombreForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(794, 95)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtNombreForm)
        Me.Controls.Add(Me.lblNomForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPedirNombreForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmPedirNombreForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNomForm As Label
    Friend WithEvents txtNombreForm As TextBox
    Friend WithEvents btnOK As Button
End Class