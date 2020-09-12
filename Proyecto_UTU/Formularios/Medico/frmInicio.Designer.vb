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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.lblAtender = New System.Windows.Forms.Label()
        Me.btnAtenderPaciente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCrearFormulario = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEditarFormulario = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblGestion = New System.Windows.Forms.Label()
        Me.btnGestion = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.fotoAuxOmed = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAtender
        '
        Me.lblAtender.AutoSize = True
        Me.lblAtender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAtender.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtender.Location = New System.Drawing.Point(0, 0)
        Me.lblAtender.Name = "lblAtender"
        Me.lblAtender.Size = New System.Drawing.Size(197, 29)
        Me.lblAtender.TabIndex = 2
        Me.lblAtender.Text = "Atender Paciente"
        '
        'btnAtenderPaciente
        '
        Me.btnAtenderPaciente.BackgroundImage = CType(resources.GetObject("btnAtenderPaciente.BackgroundImage"), System.Drawing.Image)
        Me.btnAtenderPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAtenderPaciente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAtenderPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtenderPaciente.Location = New System.Drawing.Point(0, 0)
        Me.btnAtenderPaciente.Name = "btnAtenderPaciente"
        Me.btnAtenderPaciente.Size = New System.Drawing.Size(442, 271)
        Me.btnAtenderPaciente.TabIndex = 3
        Me.btnAtenderPaciente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Crear Formularios"
        '
        'btnCrearFormulario
        '
        Me.btnCrearFormulario.BackgroundImage = CType(resources.GetObject("btnCrearFormulario.BackgroundImage"), System.Drawing.Image)
        Me.btnCrearFormulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCrearFormulario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCrearFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearFormulario.Location = New System.Drawing.Point(0, 0)
        Me.btnCrearFormulario.Name = "btnCrearFormulario"
        Me.btnCrearFormulario.Size = New System.Drawing.Size(442, 272)
        Me.btnCrearFormulario.TabIndex = 5
        Me.btnCrearFormulario.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Editar Formularios"
        '
        'btnEditarFormulario
        '
        Me.btnEditarFormulario.BackgroundImage = CType(resources.GetObject("btnEditarFormulario.BackgroundImage"), System.Drawing.Image)
        Me.btnEditarFormulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditarFormulario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEditarFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarFormulario.Location = New System.Drawing.Point(0, 0)
        Me.btnEditarFormulario.Name = "btnEditarFormulario"
        Me.btnEditarFormulario.Size = New System.Drawing.Size(442, 272)
        Me.btnEditarFormulario.TabIndex = 7
        Me.btnEditarFormulario.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(896, 555)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.btnEditarFormulario)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(451, 280)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(442, 272)
        Me.Panel4.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btnCrearFormulario)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 280)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(442, 272)
        Me.Panel3.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblGestion)
        Me.Panel1.Controls.Add(Me.btnGestion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(442, 271)
        Me.Panel1.TabIndex = 0
        '
        'lblGestion
        '
        Me.lblGestion.AutoSize = True
        Me.lblGestion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestion.Location = New System.Drawing.Point(0, 0)
        Me.lblGestion.Name = "lblGestion"
        Me.lblGestion.Size = New System.Drawing.Size(96, 29)
        Me.lblGestion.TabIndex = 2
        Me.lblGestion.Text = "Gestión"
        '
        'btnGestion
        '
        Me.btnGestion.BackgroundImage = CType(resources.GetObject("btnGestion.BackgroundImage"), System.Drawing.Image)
        Me.btnGestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGestion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestion.Location = New System.Drawing.Point(0, 0)
        Me.btnGestion.Name = "btnGestion"
        Me.btnGestion.Size = New System.Drawing.Size(442, 271)
        Me.btnGestion.TabIndex = 3
        Me.btnGestion.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblAtender)
        Me.Panel2.Controls.Add(Me.btnAtenderPaciente)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(451, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(442, 271)
        Me.Panel2.TabIndex = 1
        '
        'fotoAuxOmed
        '
        Me.fotoAuxOmed.ImageStream = CType(resources.GetObject("fotoAuxOmed.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.fotoAuxOmed.TransparentColor = System.Drawing.Color.Transparent
        Me.fotoAuxOmed.Images.SetKeyName(0, "solo_medico.png")
        Me.fotoAuxOmed.Images.SetKeyName(1, "solo_auxiliar.png")
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 555)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInicio"
        Me.Text = "frmInicio"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAtender As Label
    Friend WithEvents btnAtenderPaciente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCrearFormulario As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEditarFormulario As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblGestion As Label
    Friend WithEvents btnGestion As Button
    Friend WithEvents fotoAuxOmed As ImageList
End Class
