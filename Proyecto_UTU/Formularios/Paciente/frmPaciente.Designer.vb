<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPaciente
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiagnosticoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalisisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlContenedorFormularios = New System.Windows.Forms.Panel()
        Me.MisTratamientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.GestionToolStripMenuItem, Me.DiagnosticoToolStripMenuItem, Me.AnalisisToolStripMenuItem, Me.MisTratamientosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(896, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.GestionToolStripMenuItem.Text = "Gestión"
        '
        'DiagnosticoToolStripMenuItem
        '
        Me.DiagnosticoToolStripMenuItem.Name = "DiagnosticoToolStripMenuItem"
        Me.DiagnosticoToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.DiagnosticoToolStripMenuItem.Text = "Mis diagnósticos"
        '
        'AnalisisToolStripMenuItem
        '
        Me.AnalisisToolStripMenuItem.Name = "AnalisisToolStripMenuItem"
        Me.AnalisisToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.AnalisisToolStripMenuItem.Text = "Mis análisis"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'pnlContenedorFormularios
        '
        Me.pnlContenedorFormularios.AutoSize = True
        Me.pnlContenedorFormularios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlContenedorFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedorFormularios.Location = New System.Drawing.Point(0, 28)
        Me.pnlContenedorFormularios.Name = "pnlContenedorFormularios"
        Me.pnlContenedorFormularios.Size = New System.Drawing.Size(896, 555)
        Me.pnlContenedorFormularios.TabIndex = 1
        '
        'MisTratamientosToolStripMenuItem
        '
        Me.MisTratamientosToolStripMenuItem.Name = "MisTratamientosToolStripMenuItem"
        Me.MisTratamientosToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.MisTratamientosToolStripMenuItem.Text = "Mis tratamientos"
        '
        'frmPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 583)
        Me.Controls.Add(Me.pnlContenedorFormularios)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paciente - Hospital xxxx xxxx"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiagnosticoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnalisisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlContenedorFormularios As Panel
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MisTratamientosToolStripMenuItem As ToolStripMenuItem
End Class
