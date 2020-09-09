<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreguntarNomCons
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreguntarNomCons))
        Me.lblIngreseNom = New System.Windows.Forms.Label()
        Me.txtNomConsulta = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIngreseNom
        '
        Me.lblIngreseNom.AutoSize = True
        Me.lblIngreseNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseNom.Location = New System.Drawing.Point(12, 9)
        Me.lblIngreseNom.Name = "lblIngreseNom"
        Me.lblIngreseNom.Size = New System.Drawing.Size(861, 25)
        Me.lblIngreseNom.TabIndex = 0
        Me.lblIngreseNom.Text = "Ingrese un nombre de referencia para esta consulta médica. (Control, Emergencia, " &
    "Traumatología)"
        '
        'txtNomConsulta
        '
        Me.txtNomConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomConsulta.Location = New System.Drawing.Point(17, 47)
        Me.txtNomConsulta.Name = "txtNomConsulta"
        Me.txtNomConsulta.Size = New System.Drawing.Size(798, 34)
        Me.txtNomConsulta.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Yellow
        Me.btnOK.BackgroundImage = CType(resources.GetObject("btnOK.BackgroundImage"), System.Drawing.Image)
        Me.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Location = New System.Drawing.Point(821, 47)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(48, 34)
        Me.btnOK.TabIndex = 2
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'frmPreguntarNomCons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(872, 88)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtNomConsulta)
        Me.Controls.Add(Me.lblIngreseNom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPreguntarNomCons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmPreguntarNomCons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIngreseNom As Label
    Friend WithEvents txtNomConsulta As TextBox
    Friend WithEvents btnOK As Button
End Class
