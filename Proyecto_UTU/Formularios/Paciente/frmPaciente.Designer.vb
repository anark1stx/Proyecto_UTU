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
        Me.GestiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiagnósticoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnálisisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlContenedorFormularios = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónToolStripMenuItem, Me.DiagnósticoToolStripMenuItem, Me.AnálisisToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(896, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GestiónToolStripMenuItem
        '
        Me.GestiónToolStripMenuItem.Name = "GestiónToolStripMenuItem"
        Me.GestiónToolStripMenuItem.Size = New System.Drawing.Size(73, 26)
        Me.GestiónToolStripMenuItem.Text = "Gestión"
        '
        'DiagnósticoToolStripMenuItem
        '
        Me.DiagnósticoToolStripMenuItem.Name = "DiagnósticoToolStripMenuItem"
        Me.DiagnósticoToolStripMenuItem.Size = New System.Drawing.Size(103, 26)
        Me.DiagnósticoToolStripMenuItem.Text = "Diagnóstico"
        '
        'AnálisisToolStripMenuItem
        '
        Me.AnálisisToolStripMenuItem.Name = "AnálisisToolStripMenuItem"
        Me.AnálisisToolStripMenuItem.Size = New System.Drawing.Size(73, 26)
        Me.AnálisisToolStripMenuItem.Text = "Análisis"
        '
        'pnlContenedorFormularios
        '
        Me.pnlContenedorFormularios.Location = New System.Drawing.Point(0, 31)
        Me.pnlContenedorFormularios.Name = "pnlContenedorFormularios"
        Me.pnlContenedorFormularios.Size = New System.Drawing.Size(896, 551)
        Me.pnlContenedorFormularios.TabIndex = 1
        '
        'frmPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 583)
        Me.Controls.Add(Me.pnlContenedorFormularios)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPaciente"
        Me.Text = "Paciente - Hospital Ricardo Ramón"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiagnósticoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnálisisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlContenedorFormularios As Panel
End Class
