<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.lblGestion = New System.Windows.Forms.Label()
        Me.btnGestion = New System.Windows.Forms.Button()
        Me.btnAtenderPaciente = New System.Windows.Forms.Button()
        Me.lblAtender = New System.Windows.Forms.Label()
        Me.btnCrearFormulario = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEditarFormulario = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGestion
        '
        Me.lblGestion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblGestion.AutoSize = True
        Me.lblGestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestion.Location = New System.Drawing.Point(86, 18)
        Me.lblGestion.Name = "lblGestion"
        Me.lblGestion.Size = New System.Drawing.Size(96, 29)
        Me.lblGestion.TabIndex = 0
        Me.lblGestion.Text = "Gestión"
        '
        'btnGestion
        '
        Me.btnGestion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnGestion.BackgroundImage = CType(resources.GetObject("btnGestion.BackgroundImage"), System.Drawing.Image)
        Me.btnGestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestion.Location = New System.Drawing.Point(29, 50)
        Me.btnGestion.Name = "btnGestion"
        Me.btnGestion.Size = New System.Drawing.Size(242, 205)
        Me.btnGestion.TabIndex = 1
        Me.btnGestion.UseVisualStyleBackColor = True
        '
        'btnAtenderPaciente
        '
        Me.btnAtenderPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAtenderPaciente.BackgroundImage = CType(resources.GetObject("btnAtenderPaciente.BackgroundImage"), System.Drawing.Image)
        Me.btnAtenderPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAtenderPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtenderPaciente.Location = New System.Drawing.Point(629, 50)
        Me.btnAtenderPaciente.Name = "btnAtenderPaciente"
        Me.btnAtenderPaciente.Size = New System.Drawing.Size(242, 205)
        Me.btnAtenderPaciente.TabIndex = 3
        Me.btnAtenderPaciente.UseVisualStyleBackColor = True
        '
        'lblAtender
        '
        Me.lblAtender.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAtender.AutoSize = True
        Me.lblAtender.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtender.Location = New System.Drawing.Point(650, 18)
        Me.lblAtender.Name = "lblAtender"
        Me.lblAtender.Size = New System.Drawing.Size(197, 29)
        Me.lblAtender.TabIndex = 2
        Me.lblAtender.Text = "Atender Paciente"
        '
        'btnCrearFormulario
        '
        Me.btnCrearFormulario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCrearFormulario.BackgroundImage = CType(resources.GetObject("btnCrearFormulario.BackgroundImage"), System.Drawing.Image)
        Me.btnCrearFormulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCrearFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearFormulario.Location = New System.Drawing.Point(29, 333)
        Me.btnCrearFormulario.Name = "btnCrearFormulario"
        Me.btnCrearFormulario.Size = New System.Drawing.Size(242, 205)
        Me.btnCrearFormulario.TabIndex = 5
        Me.btnCrearFormulario.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 301)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Crear Formularios"
        '
        'btnEditarFormulario
        '
        Me.btnEditarFormulario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEditarFormulario.BackgroundImage = CType(resources.GetObject("btnEditarFormulario.BackgroundImage"), System.Drawing.Image)
        Me.btnEditarFormulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEditarFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarFormulario.Location = New System.Drawing.Point(629, 333)
        Me.btnEditarFormulario.Name = "btnEditarFormulario"
        Me.btnEditarFormulario.Size = New System.Drawing.Size(242, 205)
        Me.btnEditarFormulario.TabIndex = 7
        Me.btnEditarFormulario.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(650, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Editar Formularios"
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 555)
        Me.Controls.Add(Me.btnEditarFormulario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCrearFormulario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAtenderPaciente)
        Me.Controls.Add(Me.lblAtender)
        Me.Controls.Add(Me.btnGestion)
        Me.Controls.Add(Me.lblGestion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInicio"
        Me.Text = "frmInicio"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGestion As Label
    Friend WithEvents btnGestion As Button
    Friend WithEvents btnAtenderPaciente As Button
    Friend WithEvents lblAtender As Label
    Friend WithEvents btnCrearFormulario As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEditarFormulario As Button
    Friend WithEvents Label2 As Label
End Class
