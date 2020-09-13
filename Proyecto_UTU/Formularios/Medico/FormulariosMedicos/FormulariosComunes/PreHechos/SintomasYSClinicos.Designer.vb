<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SintomasYSClinicos
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SintomasYSClinicos))
        Me.btnAgregarSintoma = New System.Windows.Forms.Button()
        Me.lblIngreseSintoma = New System.Windows.Forms.Label()
        Me.txtSintoma = New System.Windows.Forms.TextBox()
        Me.lbSintomas = New System.Windows.Forms.ListBox()
        Me.btnAgregarSClinico = New System.Windows.Forms.Button()
        Me.lblIngreseSignoClinico = New System.Windows.Forms.Label()
        Me.txtSgClinico = New System.Windows.Forms.TextBox()
        Me.lbSignosClinicos = New System.Windows.Forms.ListBox()
        Me.btnBorrarSigno = New System.Windows.Forms.Button()
        Me.btnBorrarSintoma = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAgregarSintoma
        '
        Me.btnAgregarSintoma.BackgroundImage = CType(resources.GetObject("btnAgregarSintoma.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarSintoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarSintoma.Location = New System.Drawing.Point(1230, 37)
        Me.btnAgregarSintoma.Name = "btnAgregarSintoma"
        Me.btnAgregarSintoma.Size = New System.Drawing.Size(40, 30)
        Me.btnAgregarSintoma.TabIndex = 15
        Me.btnAgregarSintoma.UseVisualStyleBackColor = True
        '
        'lblIngreseSintoma
        '
        Me.lblIngreseSintoma.AutoSize = True
        Me.lblIngreseSintoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseSintoma.Location = New System.Drawing.Point(718, 38)
        Me.lblIngreseSintoma.Name = "lblIngreseSintoma"
        Me.lblIngreseSintoma.Size = New System.Drawing.Size(190, 29)
        Me.lblIngreseSintoma.TabIndex = 14
        Me.lblIngreseSintoma.Text = "Ingrese sintoma:"
        '
        'txtSintoma
        '
        Me.txtSintoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSintoma.Location = New System.Drawing.Point(914, 37)
        Me.txtSintoma.Name = "txtSintoma"
        Me.txtSintoma.Size = New System.Drawing.Size(310, 30)
        Me.txtSintoma.TabIndex = 13
        '
        'lbSintomas
        '
        Me.lbSintomas.FormattingEnabled = True
        Me.lbSintomas.ItemHeight = 16
        Me.lbSintomas.Location = New System.Drawing.Point(723, 89)
        Me.lbSintomas.Name = "lbSintomas"
        Me.lbSintomas.Size = New System.Drawing.Size(593, 660)
        Me.lbSintomas.TabIndex = 12
        '
        'btnAgregarSClinico
        '
        Me.btnAgregarSClinico.BackgroundImage = CType(resources.GetObject("btnAgregarSClinico.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarSClinico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarSClinico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarSClinico.Location = New System.Drawing.Point(523, 37)
        Me.btnAgregarSClinico.Name = "btnAgregarSClinico"
        Me.btnAgregarSClinico.Size = New System.Drawing.Size(40, 30)
        Me.btnAgregarSClinico.TabIndex = 11
        Me.btnAgregarSClinico.UseVisualStyleBackColor = True
        '
        'lblIngreseSignoClinico
        '
        Me.lblIngreseSignoClinico.AutoSize = True
        Me.lblIngreseSignoClinico.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseSignoClinico.Location = New System.Drawing.Point(11, 38)
        Me.lblIngreseSignoClinico.Name = "lblIngreseSignoClinico"
        Me.lblIngreseSignoClinico.Size = New System.Drawing.Size(240, 29)
        Me.lblIngreseSignoClinico.TabIndex = 10
        Me.lblIngreseSignoClinico.Text = "Ingrese signo clínico:"
        '
        'txtSgClinico
        '
        Me.txtSgClinico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSgClinico.Location = New System.Drawing.Point(257, 37)
        Me.txtSgClinico.Name = "txtSgClinico"
        Me.txtSgClinico.Size = New System.Drawing.Size(260, 30)
        Me.txtSgClinico.TabIndex = 9
        '
        'lbSignosClinicos
        '
        Me.lbSignosClinicos.FormattingEnabled = True
        Me.lbSignosClinicos.ItemHeight = 16
        Me.lbSignosClinicos.Location = New System.Drawing.Point(16, 89)
        Me.lbSignosClinicos.Name = "lbSignosClinicos"
        Me.lbSignosClinicos.Size = New System.Drawing.Size(593, 660)
        Me.lbSignosClinicos.TabIndex = 8
        '
        'btnBorrarSigno
        '
        Me.btnBorrarSigno.BackgroundImage = CType(resources.GetObject("btnBorrarSigno.BackgroundImage"), System.Drawing.Image)
        Me.btnBorrarSigno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBorrarSigno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarSigno.Location = New System.Drawing.Point(569, 37)
        Me.btnBorrarSigno.Name = "btnBorrarSigno"
        Me.btnBorrarSigno.Size = New System.Drawing.Size(40, 30)
        Me.btnBorrarSigno.TabIndex = 16
        Me.btnBorrarSigno.UseVisualStyleBackColor = True
        '
        'btnBorrarSintoma
        '
        Me.btnBorrarSintoma.BackgroundImage = CType(resources.GetObject("btnBorrarSintoma.BackgroundImage"), System.Drawing.Image)
        Me.btnBorrarSintoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBorrarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarSintoma.Location = New System.Drawing.Point(1276, 37)
        Me.btnBorrarSintoma.Name = "btnBorrarSintoma"
        Me.btnBorrarSintoma.Size = New System.Drawing.Size(40, 31)
        Me.btnBorrarSintoma.TabIndex = 17
        Me.btnBorrarSintoma.UseVisualStyleBackColor = True
        '
        'SintomasYSClinicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.btnBorrarSintoma)
        Me.Controls.Add(Me.btnBorrarSigno)
        Me.Controls.Add(Me.btnAgregarSintoma)
        Me.Controls.Add(Me.lblIngreseSintoma)
        Me.Controls.Add(Me.txtSintoma)
        Me.Controls.Add(Me.lbSintomas)
        Me.Controls.Add(Me.btnAgregarSClinico)
        Me.Controls.Add(Me.lblIngreseSignoClinico)
        Me.Controls.Add(Me.txtSgClinico)
        Me.Controls.Add(Me.lbSignosClinicos)
        Me.Name = "SintomasYSClinicos"
        Me.Size = New System.Drawing.Size(1326, 786)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgregarSintoma As Button
    Friend WithEvents lblIngreseSintoma As Label
    Friend WithEvents txtSintoma As TextBox
    Friend WithEvents lbSintomas As ListBox
    Friend WithEvents btnAgregarSClinico As Button
    Friend WithEvents lblIngreseSignoClinico As Label
    Friend WithEvents txtSgClinico As TextBox
    Friend WithEvents lbSignosClinicos As ListBox
    Friend WithEvents btnBorrarSigno As Button
    Friend WithEvents btnBorrarSintoma As Button
End Class
