<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatalogoFormulariosBD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatalogoFormulariosBD))
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.tblFormularios = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(748, 8)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(299, 34)
        Me.txtBuscar.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.Location = New System.Drawing.Point(1053, 8)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(37, 34)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'tblFormularios
        '
        Me.tblFormularios.ColumnCount = 3
        Me.tblFormularios.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblFormularios.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblFormularios.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblFormularios.Location = New System.Drawing.Point(12, 49)
        Me.tblFormularios.Name = "tblFormularios"
        Me.tblFormularios.RowCount = 2
        Me.tblFormularios.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblFormularios.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblFormularios.Size = New System.Drawing.Size(1078, 719)
        Me.tblFormularios.TabIndex = 3
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAceptar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(0, 774)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(1102, 48)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "CONFIRMAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'frmCatalogoFormulariosBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 822)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.tblFormularios)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Name = "frmCatalogoFormulariosBD"
        Me.Text = "frmCatalogoFormulariosBD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents tblFormularios As TableLayoutPanel
    Friend WithEvents btnAceptar As Button
End Class
