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
        Me.TabControlFormulario = New System.Windows.Forms.TabControl()
        Me.tbpEntrevista = New System.Windows.Forms.TabPage()
        Me.tbpSintomasYsg = New System.Windows.Forms.TabPage()
        Me.btnBorrarSintoma = New System.Windows.Forms.Button()
        Me.btnBorrarSigno = New System.Windows.Forms.Button()
        Me.btnAgregarSintoma = New System.Windows.Forms.Button()
        Me.lblIngreseSintoma = New System.Windows.Forms.Label()
        Me.txtSintoma = New System.Windows.Forms.TextBox()
        Me.lbSintomas = New System.Windows.Forms.ListBox()
        Me.btnAgregarSClinico = New System.Windows.Forms.Button()
        Me.lblIngreseSignoClinico = New System.Windows.Forms.Label()
        Me.txtSgClinico = New System.Windows.Forms.TextBox()
        Me.lbSignosClinicos = New System.Windows.Forms.ListBox()
        Me.TabControlFormulario.SuspendLayout()
        Me.tbpSintomasYsg.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlFormulario
        '
        Me.TabControlFormulario.Controls.Add(Me.tbpEntrevista)
        Me.TabControlFormulario.Controls.Add(Me.tbpSintomasYsg)
        Me.TabControlFormulario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlFormulario.Location = New System.Drawing.Point(0, 0)
        Me.TabControlFormulario.Name = "TabControlFormulario"
        Me.TabControlFormulario.SelectedIndex = 0
        Me.TabControlFormulario.Size = New System.Drawing.Size(1326, 786)
        Me.TabControlFormulario.TabIndex = 0
        '
        'tbpEntrevista
        '
        Me.tbpEntrevista.BackColor = System.Drawing.Color.LightBlue
        Me.tbpEntrevista.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbpEntrevista.Location = New System.Drawing.Point(4, 25)
        Me.tbpEntrevista.Name = "tbpEntrevista"
        Me.tbpEntrevista.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpEntrevista.Size = New System.Drawing.Size(1318, 757)
        Me.tbpEntrevista.TabIndex = 0
        Me.tbpEntrevista.Text = "Entrevista"
        '
        'tbpSintomasYsg
        '
        Me.tbpSintomasYsg.BackColor = System.Drawing.Color.LightBlue
        Me.tbpSintomasYsg.Controls.Add(Me.btnBorrarSintoma)
        Me.tbpSintomasYsg.Controls.Add(Me.btnBorrarSigno)
        Me.tbpSintomasYsg.Controls.Add(Me.btnAgregarSintoma)
        Me.tbpSintomasYsg.Controls.Add(Me.lblIngreseSintoma)
        Me.tbpSintomasYsg.Controls.Add(Me.txtSintoma)
        Me.tbpSintomasYsg.Controls.Add(Me.lbSintomas)
        Me.tbpSintomasYsg.Controls.Add(Me.btnAgregarSClinico)
        Me.tbpSintomasYsg.Controls.Add(Me.lblIngreseSignoClinico)
        Me.tbpSintomasYsg.Controls.Add(Me.txtSgClinico)
        Me.tbpSintomasYsg.Controls.Add(Me.lbSignosClinicos)
        Me.tbpSintomasYsg.Location = New System.Drawing.Point(4, 25)
        Me.tbpSintomasYsg.Name = "tbpSintomasYsg"
        Me.tbpSintomasYsg.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpSintomasYsg.Size = New System.Drawing.Size(1318, 757)
        Me.tbpSintomasYsg.TabIndex = 1
        Me.tbpSintomasYsg.Text = "Signos clínicos y síntomas"
        '
        'btnBorrarSintoma
        '
        Me.btnBorrarSintoma.BackgroundImage = CType(resources.GetObject("btnBorrarSintoma.BackgroundImage"), System.Drawing.Image)
        Me.btnBorrarSintoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBorrarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarSintoma.Location = New System.Drawing.Point(1272, 22)
        Me.btnBorrarSintoma.Name = "btnBorrarSintoma"
        Me.btnBorrarSintoma.Size = New System.Drawing.Size(40, 31)
        Me.btnBorrarSintoma.TabIndex = 27
        Me.btnBorrarSintoma.UseVisualStyleBackColor = True
        '
        'btnBorrarSigno
        '
        Me.btnBorrarSigno.BackgroundImage = CType(resources.GetObject("btnBorrarSigno.BackgroundImage"), System.Drawing.Image)
        Me.btnBorrarSigno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBorrarSigno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarSigno.Location = New System.Drawing.Point(565, 22)
        Me.btnBorrarSigno.Name = "btnBorrarSigno"
        Me.btnBorrarSigno.Size = New System.Drawing.Size(40, 30)
        Me.btnBorrarSigno.TabIndex = 26
        Me.btnBorrarSigno.UseVisualStyleBackColor = True
        '
        'btnAgregarSintoma
        '
        Me.btnAgregarSintoma.BackgroundImage = CType(resources.GetObject("btnAgregarSintoma.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarSintoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarSintoma.Location = New System.Drawing.Point(1226, 22)
        Me.btnAgregarSintoma.Name = "btnAgregarSintoma"
        Me.btnAgregarSintoma.Size = New System.Drawing.Size(40, 30)
        Me.btnAgregarSintoma.TabIndex = 25
        Me.btnAgregarSintoma.UseVisualStyleBackColor = True
        '
        'lblIngreseSintoma
        '
        Me.lblIngreseSintoma.AutoSize = True
        Me.lblIngreseSintoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseSintoma.Location = New System.Drawing.Point(714, 23)
        Me.lblIngreseSintoma.Name = "lblIngreseSintoma"
        Me.lblIngreseSintoma.Size = New System.Drawing.Size(190, 29)
        Me.lblIngreseSintoma.TabIndex = 24
        Me.lblIngreseSintoma.Text = "Ingrese sintoma:"
        '
        'txtSintoma
        '
        Me.txtSintoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSintoma.Location = New System.Drawing.Point(910, 22)
        Me.txtSintoma.Name = "txtSintoma"
        Me.txtSintoma.Size = New System.Drawing.Size(310, 30)
        Me.txtSintoma.TabIndex = 23
        '
        'lbSintomas
        '
        Me.lbSintomas.FormattingEnabled = True
        Me.lbSintomas.ItemHeight = 16
        Me.lbSintomas.Location = New System.Drawing.Point(719, 74)
        Me.lbSintomas.Name = "lbSintomas"
        Me.lbSintomas.Size = New System.Drawing.Size(593, 660)
        Me.lbSintomas.TabIndex = 22
        '
        'btnAgregarSClinico
        '
        Me.btnAgregarSClinico.BackgroundImage = CType(resources.GetObject("btnAgregarSClinico.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarSClinico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarSClinico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarSClinico.Location = New System.Drawing.Point(519, 22)
        Me.btnAgregarSClinico.Name = "btnAgregarSClinico"
        Me.btnAgregarSClinico.Size = New System.Drawing.Size(40, 30)
        Me.btnAgregarSClinico.TabIndex = 21
        Me.btnAgregarSClinico.UseVisualStyleBackColor = True
        '
        'lblIngreseSignoClinico
        '
        Me.lblIngreseSignoClinico.AutoSize = True
        Me.lblIngreseSignoClinico.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseSignoClinico.Location = New System.Drawing.Point(7, 23)
        Me.lblIngreseSignoClinico.Name = "lblIngreseSignoClinico"
        Me.lblIngreseSignoClinico.Size = New System.Drawing.Size(240, 29)
        Me.lblIngreseSignoClinico.TabIndex = 20
        Me.lblIngreseSignoClinico.Text = "Ingrese signo clínico:"
        '
        'txtSgClinico
        '
        Me.txtSgClinico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSgClinico.Location = New System.Drawing.Point(253, 22)
        Me.txtSgClinico.Name = "txtSgClinico"
        Me.txtSgClinico.Size = New System.Drawing.Size(260, 30)
        Me.txtSgClinico.TabIndex = 19
        '
        'lbSignosClinicos
        '
        Me.lbSignosClinicos.FormattingEnabled = True
        Me.lbSignosClinicos.ItemHeight = 16
        Me.lbSignosClinicos.Location = New System.Drawing.Point(12, 74)
        Me.lbSignosClinicos.Name = "lbSignosClinicos"
        Me.lbSignosClinicos.Size = New System.Drawing.Size(593, 660)
        Me.lbSignosClinicos.TabIndex = 18
        '
        'SintomasYSClinicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.TabControlFormulario)
        Me.Name = "SintomasYSClinicos"
        Me.Size = New System.Drawing.Size(1326, 786)
        Me.TabControlFormulario.ResumeLayout(False)
        Me.tbpSintomasYsg.ResumeLayout(False)
        Me.tbpSintomasYsg.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlFormulario As TabControl
    Friend WithEvents tbpEntrevista As TabPage
    Friend WithEvents tbpSintomasYsg As TabPage
    Friend WithEvents btnBorrarSintoma As Button
    Friend WithEvents btnBorrarSigno As Button
    Friend WithEvents btnAgregarSintoma As Button
    Friend WithEvents lblIngreseSintoma As Label
    Friend WithEvents txtSintoma As TextBox
    Friend WithEvents lbSintomas As ListBox
    Friend WithEvents btnAgregarSClinico As Button
    Friend WithEvents lblIngreseSignoClinico As Label
    Friend WithEvents txtSgClinico As TextBox
    Friend WithEvents lbSignosClinicos As ListBox
End Class
