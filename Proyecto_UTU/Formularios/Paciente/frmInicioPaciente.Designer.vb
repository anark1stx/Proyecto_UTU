<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicioPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicioPaciente))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblGestion = New System.Windows.Forms.Label()
        Me.btnGestion = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblDiagnosticos = New System.Windows.Forms.Label()
        Me.btnDiagnosticos = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblAnalisis = New System.Windows.Forms.Label()
        Me.btnAnalisis = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(896, 555)
        Me.TableLayoutPanel1.TabIndex = 0
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
        Me.lblGestion.TabIndex = 1
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
        Me.btnGestion.TabIndex = 0
        Me.btnGestion.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblDiagnosticos)
        Me.Panel2.Controls.Add(Me.btnDiagnosticos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(451, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(442, 271)
        Me.Panel2.TabIndex = 1
        '
        'lblDiagnosticos
        '
        Me.lblDiagnosticos.AutoSize = True
        Me.lblDiagnosticos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDiagnosticos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiagnosticos.Location = New System.Drawing.Point(0, 0)
        Me.lblDiagnosticos.Name = "lblDiagnosticos"
        Me.lblDiagnosticos.Size = New System.Drawing.Size(152, 29)
        Me.lblDiagnosticos.TabIndex = 1
        Me.lblDiagnosticos.Text = "Diagnósticos"
        '
        'btnDiagnosticos
        '
        Me.btnDiagnosticos.BackgroundImage = CType(resources.GetObject("btnDiagnosticos.BackgroundImage"), System.Drawing.Image)
        Me.btnDiagnosticos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDiagnosticos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDiagnosticos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiagnosticos.Location = New System.Drawing.Point(0, 0)
        Me.btnDiagnosticos.Name = "btnDiagnosticos"
        Me.btnDiagnosticos.Size = New System.Drawing.Size(442, 271)
        Me.btnDiagnosticos.TabIndex = 0
        Me.btnDiagnosticos.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblAnalisis)
        Me.Panel3.Controls.Add(Me.btnAnalisis)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 280)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(442, 272)
        Me.Panel3.TabIndex = 2
        '
        'lblAnalisis
        '
        Me.lblAnalisis.AutoSize = True
        Me.lblAnalisis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnalisis.Location = New System.Drawing.Point(0, 0)
        Me.lblAnalisis.Name = "lblAnalisis"
        Me.lblAnalisis.Size = New System.Drawing.Size(96, 29)
        Me.lblAnalisis.TabIndex = 1
        Me.lblAnalisis.Text = "Análisis"
        '
        'btnAnalisis
        '
        Me.btnAnalisis.BackgroundImage = CType(resources.GetObject("btnAnalisis.BackgroundImage"), System.Drawing.Image)
        Me.btnAnalisis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAnalisis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnalisis.Location = New System.Drawing.Point(0, 0)
        Me.btnAnalisis.Name = "btnAnalisis"
        Me.btnAnalisis.Size = New System.Drawing.Size(442, 272)
        Me.btnAnalisis.TabIndex = 0
        Me.btnAnalisis.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.btnSalir)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(451, 280)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(442, 272)
        Me.Panel4.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Salir"
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(0, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(442, 272)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmInicioPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 555)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInicioPaciente"
        Me.Text = "frmInicioPaciente"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGestion As Button
    Friend WithEvents lblGestion As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblDiagnosticos As Label
    Friend WithEvents btnDiagnosticos As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAnalisis As Button
    Friend WithEvents lblAnalisis As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
End Class
