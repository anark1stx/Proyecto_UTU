<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicioAdm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicioAdm))
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarAuxiliar = New System.Windows.Forms.Button()
        Me.btnModificarAuxiliar = New System.Windows.Forms.Button()
        Me.btnBajaAuxiliar = New System.Windows.Forms.Button()
        Me.btnAltaAuxiliar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBusquedaMedico)
        Me.GroupBox1.Controls.Add(Me.btnModificacionMedico)
        Me.GroupBox1.Controls.Add(Me.btnBajaMedico)
        Me.GroupBox1.Controls.Add(Me.btnAltaMedico)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 226)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1038, 196)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestionar médicos"
        '
        'btnBusquedaMedico
        '
        Me.btnBusquedaMedico.BackgroundImage = CType(resources.GetObject("btnBusquedaMedico.BackgroundImage"), System.Drawing.Image)
        Me.btnBusquedaMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBusquedaMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBusquedaMedico.Location = New System.Drawing.Point(791, 21)
        Me.btnBusquedaMedico.Name = "btnBusquedaMedico"
        Me.btnBusquedaMedico.Size = New System.Drawing.Size(211, 169)
        Me.btnBusquedaMedico.TabIndex = 3
        Me.btnBusquedaMedico.UseVisualStyleBackColor = True
        '
        'btnModificacionMedico
        '
        Me.btnModificacionMedico.BackgroundImage = CType(resources.GetObject("btnModificacionMedico.BackgroundImage"), System.Drawing.Image)
        Me.btnModificacionMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnModificacionMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificacionMedico.Location = New System.Drawing.Point(537, 21)
        Me.btnModificacionMedico.Name = "btnModificacionMedico"
        Me.btnModificacionMedico.Size = New System.Drawing.Size(211, 169)
        Me.btnModificacionMedico.TabIndex = 2
        Me.btnModificacionMedico.UseVisualStyleBackColor = True
        '
        'btnBajaMedico
        '
        Me.btnBajaMedico.BackgroundImage = CType(resources.GetObject("btnBajaMedico.BackgroundImage"), System.Drawing.Image)
        Me.btnBajaMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBajaMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBajaMedico.Location = New System.Drawing.Point(283, 21)
        Me.btnBajaMedico.Name = "btnBajaMedico"
        Me.btnBajaMedico.Size = New System.Drawing.Size(211, 169)
        Me.btnBajaMedico.TabIndex = 1
        Me.btnBajaMedico.UseVisualStyleBackColor = True
        '
        'btnAltaMedico
        '
        Me.btnAltaMedico.BackgroundImage = CType(resources.GetObject("btnAltaMedico.BackgroundImage"), System.Drawing.Image)
        Me.btnAltaMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAltaMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAltaMedico.Location = New System.Drawing.Point(25, 21)
        Me.btnAltaMedico.Name = "btnAltaMedico"
        Me.btnAltaMedico.Size = New System.Drawing.Size(211, 169)
        Me.btnAltaMedico.TabIndex = 0
        Me.btnAltaMedico.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBusquedaPaciente)
        Me.GroupBox2.Controls.Add(Me.btnModificarPaciente)
        Me.GroupBox2.Controls.Add(Me.btnBajaPaciente)
        Me.GroupBox2.Controls.Add(Me.btnAltaPaciente)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1038, 202)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gestionar Pacientes"
        '
        'btnBusquedaPaciente
        '
        Me.btnBusquedaPaciente.BackgroundImage = CType(resources.GetObject("btnBusquedaPaciente.BackgroundImage"), System.Drawing.Image)
        Me.btnBusquedaPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBusquedaPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBusquedaPaciente.Location = New System.Drawing.Point(785, 21)
        Me.btnBusquedaPaciente.Name = "btnBusquedaPaciente"
        Me.btnBusquedaPaciente.Size = New System.Drawing.Size(211, 169)
        Me.btnBusquedaPaciente.TabIndex = 3
        Me.btnBusquedaPaciente.UseVisualStyleBackColor = True
        '
        'btnModificarPaciente
        '
        Me.btnModificarPaciente.BackgroundImage = CType(resources.GetObject("btnModificarPaciente.BackgroundImage"), System.Drawing.Image)
        Me.btnModificarPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnModificarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarPaciente.Location = New System.Drawing.Point(531, 21)
        Me.btnModificarPaciente.Name = "btnModificarPaciente"
        Me.btnModificarPaciente.Size = New System.Drawing.Size(211, 169)
        Me.btnModificarPaciente.TabIndex = 2
        Me.btnModificarPaciente.UseVisualStyleBackColor = True
        '
        'btnBajaPaciente
        '
        Me.btnBajaPaciente.BackgroundImage = CType(resources.GetObject("btnBajaPaciente.BackgroundImage"), System.Drawing.Image)
        Me.btnBajaPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBajaPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBajaPaciente.Location = New System.Drawing.Point(277, 21)
        Me.btnBajaPaciente.Name = "btnBajaPaciente"
        Me.btnBajaPaciente.Size = New System.Drawing.Size(211, 169)
        Me.btnBajaPaciente.TabIndex = 1
        Me.btnBajaPaciente.UseVisualStyleBackColor = True
        '
        'btnAltaPaciente
        '
        Me.btnAltaPaciente.BackgroundImage = CType(resources.GetObject("btnAltaPaciente.BackgroundImage"), System.Drawing.Image)
        Me.btnAltaPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAltaPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAltaPaciente.Location = New System.Drawing.Point(19, 21)
        Me.btnAltaPaciente.Name = "btnAltaPaciente"
        Me.btnAltaPaciente.Size = New System.Drawing.Size(211, 169)
        Me.btnAltaPaciente.TabIndex = 0
        Me.btnAltaPaciente.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnBuscarAuxiliar)
        Me.GroupBox3.Controls.Add(Me.btnModificarAuxiliar)
        Me.GroupBox3.Controls.Add(Me.btnBajaAuxiliar)
        Me.GroupBox3.Controls.Add(Me.btnAltaAuxiliar)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 431)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1038, 196)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gestionar auxiliares"
        '
        'btnBuscarAuxiliar
        '
        Me.btnBuscarAuxiliar.BackgroundImage = CType(resources.GetObject("btnBuscarAuxiliar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarAuxiliar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscarAuxiliar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarAuxiliar.Location = New System.Drawing.Point(791, 21)
        Me.btnBuscarAuxiliar.Name = "btnBuscarAuxiliar"
        Me.btnBuscarAuxiliar.Size = New System.Drawing.Size(211, 169)
        Me.btnBuscarAuxiliar.TabIndex = 3
        Me.btnBuscarAuxiliar.UseVisualStyleBackColor = True
        '
        'btnModificarAuxiliar
        '
        Me.btnModificarAuxiliar.BackgroundImage = CType(resources.GetObject("btnModificarAuxiliar.BackgroundImage"), System.Drawing.Image)
        Me.btnModificarAuxiliar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnModificarAuxiliar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarAuxiliar.Location = New System.Drawing.Point(537, 21)
        Me.btnModificarAuxiliar.Name = "btnModificarAuxiliar"
        Me.btnModificarAuxiliar.Size = New System.Drawing.Size(211, 169)
        Me.btnModificarAuxiliar.TabIndex = 2
        Me.btnModificarAuxiliar.UseVisualStyleBackColor = True
        '
        'btnBajaAuxiliar
        '
        Me.btnBajaAuxiliar.BackgroundImage = CType(resources.GetObject("btnBajaAuxiliar.BackgroundImage"), System.Drawing.Image)
        Me.btnBajaAuxiliar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBajaAuxiliar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBajaAuxiliar.Location = New System.Drawing.Point(283, 21)
        Me.btnBajaAuxiliar.Name = "btnBajaAuxiliar"
        Me.btnBajaAuxiliar.Size = New System.Drawing.Size(211, 169)
        Me.btnBajaAuxiliar.TabIndex = 1
        Me.btnBajaAuxiliar.UseVisualStyleBackColor = True
        '
        'btnAltaAuxiliar
        '
        Me.btnAltaAuxiliar.BackgroundImage = CType(resources.GetObject("btnAltaAuxiliar.BackgroundImage"), System.Drawing.Image)
        Me.btnAltaAuxiliar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAltaAuxiliar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAltaAuxiliar.Location = New System.Drawing.Point(25, 21)
        Me.btnAltaAuxiliar.Name = "btnAltaAuxiliar"
        Me.btnAltaAuxiliar.Size = New System.Drawing.Size(211, 169)
        Me.btnAltaAuxiliar.TabIndex = 0
        Me.btnAltaAuxiliar.UseVisualStyleBackColor = True
        '
        'frmInicioAdm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1062, 639)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInicioAdm"
        Me.Text = "frmInicioAdm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
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
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnBuscarAuxiliar As Button
    Friend WithEvents btnModificarAuxiliar As Button
    Friend WithEvents btnBajaAuxiliar As Button
    Friend WithEvents btnAltaAuxiliar As Button
End Class
