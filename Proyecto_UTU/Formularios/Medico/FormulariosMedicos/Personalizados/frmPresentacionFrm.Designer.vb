<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresentacionFrm
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.tblDatosFrm = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNombreForm = New System.Windows.Forms.Label()
        Me.pBoxVistaPrevia = New System.Windows.Forms.PictureBox()
        Me.tblDatosFrm.SuspendLayout()
        CType(Me.pBoxVistaPrevia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblDatosFrm
        '
        Me.tblDatosFrm.ColumnCount = 1
        Me.tblDatosFrm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDatosFrm.Controls.Add(Me.lblNombreForm, 0, 0)
        Me.tblDatosFrm.Controls.Add(Me.pBoxVistaPrevia, 0, 1)
        Me.tblDatosFrm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDatosFrm.Location = New System.Drawing.Point(0, 0)
        Me.tblDatosFrm.Name = "tblDatosFrm"
        Me.tblDatosFrm.RowCount = 2
        Me.tblDatosFrm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.202454!))
        Me.tblDatosFrm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.79755!))
        Me.tblDatosFrm.Size = New System.Drawing.Size(364, 326)
        Me.tblDatosFrm.TabIndex = 0
        '
        'lblNombreForm
        '
        Me.lblNombreForm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNombreForm.AutoSize = True
        Me.lblNombreForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreForm.Location = New System.Drawing.Point(61, 0)
        Me.lblNombreForm.Name = "lblNombreForm"
        Me.lblNombreForm.Size = New System.Drawing.Size(241, 29)
        Me.lblNombreForm.TabIndex = 5
        Me.lblNombreForm.Text = "Nombre Formulario"
        '
        'pBoxVistaPrevia
        '
        Me.pBoxVistaPrevia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pBoxVistaPrevia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBoxVistaPrevia.Location = New System.Drawing.Point(3, 32)
        Me.pBoxVistaPrevia.Name = "pBoxVistaPrevia"
        Me.pBoxVistaPrevia.Size = New System.Drawing.Size(358, 291)
        Me.pBoxVistaPrevia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxVistaPrevia.TabIndex = 4
        Me.pBoxVistaPrevia.TabStop = False
        '
        'frmPresentacionFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.Controls.Add(Me.tblDatosFrm)
        Me.Name = "frmPresentacionFrm"
        Me.Size = New System.Drawing.Size(364, 326)
        Me.tblDatosFrm.ResumeLayout(False)
        Me.tblDatosFrm.PerformLayout()
        CType(Me.pBoxVistaPrevia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblDatosFrm As TableLayoutPanel
    Friend WithEvents lblNombreForm As Label
    Friend WithEvents pBoxVistaPrevia As PictureBox
End Class
