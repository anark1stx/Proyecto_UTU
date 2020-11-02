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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaciente))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiagnosticoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalisisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MisTratamientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlContenedorFormularios = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.GestionToolStripMenuItem, Me.DiagnosticoToolStripMenuItem, Me.AnalisisToolStripMenuItem, Me.MisTratamientosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        resources.ApplyResources(Me.InicioToolStripMenuItem, "InicioToolStripMenuItem")
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        resources.ApplyResources(Me.GestionToolStripMenuItem, "GestionToolStripMenuItem")
        '
        'DiagnosticoToolStripMenuItem
        '
        Me.DiagnosticoToolStripMenuItem.Name = "DiagnosticoToolStripMenuItem"
        resources.ApplyResources(Me.DiagnosticoToolStripMenuItem, "DiagnosticoToolStripMenuItem")
        '
        'AnalisisToolStripMenuItem
        '
        Me.AnalisisToolStripMenuItem.Name = "AnalisisToolStripMenuItem"
        resources.ApplyResources(Me.AnalisisToolStripMenuItem, "AnalisisToolStripMenuItem")
        '
        'MisTratamientosToolStripMenuItem
        '
        Me.MisTratamientosToolStripMenuItem.Name = "MisTratamientosToolStripMenuItem"
        resources.ApplyResources(Me.MisTratamientosToolStripMenuItem, "MisTratamientosToolStripMenuItem")
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        resources.ApplyResources(Me.SalirToolStripMenuItem, "SalirToolStripMenuItem")
        '
        'pnlContenedorFormularios
        '
        resources.ApplyResources(Me.pnlContenedorFormularios, "pnlContenedorFormularios")
        Me.pnlContenedorFormularios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlContenedorFormularios.Name = "pnlContenedorFormularios"
        '
        'frmPaciente
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.pnlContenedorFormularios)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPaciente"
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
