<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicioAdministrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicioAdministrador))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBusquedaMedico = New System.Windows.Forms.Button()
        Me.btnModificacionMedico = New System.Windows.Forms.Button()
        Me.btnBajaMedico = New System.Windows.Forms.Button()
        Me.btnAltaMedico = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBusquedaPaciente = New System.Windows.Forms.Button()
        Me.btnModificarPaciente = New System.Windows.Forms.Button()
        Me.btnBajaPaciente = New System.Windows.Forms.Button()
        Me.btnAltaPaciente = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBusquedaMedico)
        Me.GroupBox1.Controls.Add(Me.btnModificacionMedico)
        Me.GroupBox1.Controls.Add(Me.btnBajaMedico)
        Me.GroupBox1.Controls.Add(Me.btnAltaMedico)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1038, 288)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestionar médicos"
        '
        'btnBusquedaMedico
        '
        Me.btnBusquedaMedico.BackgroundImage = CType(resources.GetObject("btnBusquedaMedico.BackgroundImage"), System.Drawing.Image)
        Me.btnBusquedaMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBusquedaMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBusquedaMedico.Location = New System.Drawing.Point(774, 21)
        Me.btnBusquedaMedico.Name = "btnBusquedaMedico"
        Me.btnBusquedaMedico.Size = New System.Drawing.Size(250, 252)
        Me.btnBusquedaMedico.TabIndex = 3
        Me.btnBusquedaMedico.UseVisualStyleBackColor = True
        '
        'btnModificacionMedico
        '
        Me.btnModificacionMedico.BackgroundImage = CType(resources.GetObject("btnModificacionMedico.BackgroundImage"), System.Drawing.Image)
        Me.btnModificacionMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnModificacionMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificacionMedico.Location = New System.Drawing.Point(518, 21)
        Me.btnModificacionMedico.Name = "btnModificacionMedico"
        Me.btnModificacionMedico.Size = New System.Drawing.Size(250, 252)
        Me.btnModificacionMedico.TabIndex = 2
        Me.btnModificacionMedico.UseVisualStyleBackColor = True
        '
        'btnBajaMedico
        '
        Me.btnBajaMedico.BackgroundImage = CType(resources.GetObject("btnBajaMedico.BackgroundImage"), System.Drawing.Image)
        Me.btnBajaMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBajaMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBajaMedico.Location = New System.Drawing.Point(262, 21)
        Me.btnBajaMedico.Name = "btnBajaMedico"
        Me.btnBajaMedico.Size = New System.Drawing.Size(250, 252)
        Me.btnBajaMedico.TabIndex = 1
        Me.btnBajaMedico.UseVisualStyleBackColor = True
        '
        'btnAltaMedico
        '
        Me.btnAltaMedico.BackgroundImage = CType(resources.GetObject("btnAltaMedico.BackgroundImage"), System.Drawing.Image)
        Me.btnAltaMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAltaMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAltaMedico.Location = New System.Drawing.Point(6, 21)
        Me.btnAltaMedico.Name = "btnAltaMedico"
        Me.btnAltaMedico.Size = New System.Drawing.Size(250, 252)
        Me.btnAltaMedico.TabIndex = 0
        Me.btnAltaMedico.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBusquedaPaciente)
        Me.GroupBox2.Controls.Add(Me.btnModificarPaciente)
        Me.GroupBox2.Controls.Add(Me.btnBajaPaciente)
        Me.GroupBox2.Controls.Add(Me.btnAltaPaciente)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 327)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1038, 288)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gestionar Pacientes"
        '
        'btnBusquedaPaciente
        '
        Me.btnBusquedaPaciente.BackgroundImage = CType(resources.GetObject("btnBusquedaPaciente.BackgroundImage"), System.Drawing.Image)
        Me.btnBusquedaPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBusquedaPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBusquedaPaciente.Location = New System.Drawing.Point(774, 21)
        Me.btnBusquedaPaciente.Name = "btnBusquedaPaciente"
        Me.btnBusquedaPaciente.Size = New System.Drawing.Size(250, 252)
        Me.btnBusquedaPaciente.TabIndex = 3
        Me.btnBusquedaPaciente.UseVisualStyleBackColor = True
        '
        'btnModificarPaciente
        '
        Me.btnModificarPaciente.BackgroundImage = CType(resources.GetObject("btnModificarPaciente.BackgroundImage"), System.Drawing.Image)
        Me.btnModificarPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnModificarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarPaciente.Location = New System.Drawing.Point(518, 21)
        Me.btnModificarPaciente.Name = "btnModificarPaciente"
        Me.btnModificarPaciente.Size = New System.Drawing.Size(250, 252)
        Me.btnModificarPaciente.TabIndex = 2
        Me.btnModificarPaciente.UseVisualStyleBackColor = True
        '
        'btnBajaPaciente
        '
        Me.btnBajaPaciente.BackgroundImage = CType(resources.GetObject("btnBajaPaciente.BackgroundImage"), System.Drawing.Image)
        Me.btnBajaPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBajaPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBajaPaciente.Location = New System.Drawing.Point(262, 21)
        Me.btnBajaPaciente.Name = "btnBajaPaciente"
        Me.btnBajaPaciente.Size = New System.Drawing.Size(250, 252)
        Me.btnBajaPaciente.TabIndex = 1
        Me.btnBajaPaciente.UseVisualStyleBackColor = True
        '
        'btnAltaPaciente
        '
        Me.btnAltaPaciente.BackgroundImage = CType(resources.GetObject("btnAltaPaciente.BackgroundImage"), System.Drawing.Image)
        Me.btnAltaPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAltaPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAltaPaciente.Location = New System.Drawing.Point(6, 21)
        Me.btnAltaPaciente.Name = "btnAltaPaciente"
        Me.btnAltaPaciente.Size = New System.Drawing.Size(250, 252)
        Me.btnAltaPaciente.TabIndex = 0
        Me.btnAltaPaciente.UseVisualStyleBackColor = True
        '
        'frmInicioAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1062, 639)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInicioAdministrador"
        Me.Text = "frmInicioAdministrador"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBusquedaMedico As Button
    Friend WithEvents btnModificacionMedico As Button
    Friend WithEvents btnBajaMedico As Button
    Friend WithEvents btnAltaMedico As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBusquedaPaciente As Button
    Friend WithEvents btnModificarPaciente As Button
    Friend WithEvents btnBajaPaciente As Button
    Friend WithEvents btnAltaPaciente As Button
End Class
