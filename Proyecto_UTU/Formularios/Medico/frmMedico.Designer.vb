<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMedico
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
        Me.GestionMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtenderMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormulariosMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearFormularioMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TratamientosMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarNuevoTratamientoMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TratamientoSeguimientoMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalisisMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalisisIngresarMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalisisHacerSeguimientoMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlContenedorFormularios = New System.Windows.Forms.Panel()
        Me.AsginarTratamientoPacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarAnalisisPacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.GestionMenuItem, Me.AtenderMenuItem, Me.FormulariosMenuItem, Me.TratamientosMenuItem, Me.AnalisisMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1130, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'GestionMenuItem
        '
        Me.GestionMenuItem.Name = "GestionMenuItem"
        Me.GestionMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.GestionMenuItem.Text = "Gestión"
        '
        'AtenderMenuItem
        '
        Me.AtenderMenuItem.Name = "AtenderMenuItem"
        Me.AtenderMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.AtenderMenuItem.Text = "Atender Paciente"
        '
        'FormulariosMenuItem
        '
        Me.FormulariosMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearFormularioMenuItem})
        Me.FormulariosMenuItem.Name = "FormulariosMenuItem"
        Me.FormulariosMenuItem.Size = New System.Drawing.Size(101, 24)
        Me.FormulariosMenuItem.Text = "Formularios"
        '
        'CrearFormularioMenuItem
        '
        Me.CrearFormularioMenuItem.Name = "CrearFormularioMenuItem"
        Me.CrearFormularioMenuItem.Size = New System.Drawing.Size(263, 26)
        Me.CrearFormularioMenuItem.Text = "Crear y Editar Formularios"
        '
        'TratamientosMenuItem
        '
        Me.TratamientosMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarNuevoTratamientoMenuItem, Me.TratamientoSeguimientoMenuItem, Me.AsginarTratamientoPacienteToolStripMenuItem})
        Me.TratamientosMenuItem.Name = "TratamientosMenuItem"
        Me.TratamientosMenuItem.Size = New System.Drawing.Size(109, 24)
        Me.TratamientosMenuItem.Text = "Tratamientos"
        '
        'IngresarNuevoTratamientoMenuItem
        '
        Me.IngresarNuevoTratamientoMenuItem.Name = "IngresarNuevoTratamientoMenuItem"
        Me.IngresarNuevoTratamientoMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.IngresarNuevoTratamientoMenuItem.Text = "Ingresar nuevo"
        '
        'TratamientoSeguimientoMenuItem
        '
        Me.TratamientoSeguimientoMenuItem.Name = "TratamientoSeguimientoMenuItem"
        Me.TratamientoSeguimientoMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.TratamientoSeguimientoMenuItem.Text = "Hacer seguimiento"
        '
        'AnalisisMenuItem
        '
        Me.AnalisisMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnalisisIngresarMenuItem1, Me.AnalisisHacerSeguimientoMenuItem1, Me.AsignarAnalisisPacienteToolStripMenuItem})
        Me.AnalisisMenuItem.Name = "AnalisisMenuItem"
        Me.AnalisisMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.AnalisisMenuItem.Text = "Análisis"
        '
        'AnalisisIngresarMenuItem1
        '
        Me.AnalisisIngresarMenuItem1.Name = "AnalisisIngresarMenuItem1"
        Me.AnalisisIngresarMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.AnalisisIngresarMenuItem1.Text = "Ingresar nuevo"
        '
        'AnalisisHacerSeguimientoMenuItem1
        '
        Me.AnalisisHacerSeguimientoMenuItem1.Name = "AnalisisHacerSeguimientoMenuItem1"
        Me.AnalisisHacerSeguimientoMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.AnalisisHacerSeguimientoMenuItem1.Text = "Hacer seguimiento"
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
        Me.pnlContenedorFormularios.Size = New System.Drawing.Size(1130, 720)
        Me.pnlContenedorFormularios.TabIndex = 1
        '
        'AsginarTratamientoPacienteToolStripMenuItem
        '
        Me.AsginarTratamientoPacienteToolStripMenuItem.Name = "AsginarTratamientoPacienteToolStripMenuItem"
        Me.AsginarTratamientoPacienteToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AsginarTratamientoPacienteToolStripMenuItem.Text = "Asginar a paciente"
        '
        'AsignarAnalisisPacienteToolStripMenuItem
        '
        Me.AsignarAnalisisPacienteToolStripMenuItem.Name = "AsignarAnalisisPacienteToolStripMenuItem"
        Me.AsignarAnalisisPacienteToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AsignarAnalisisPacienteToolStripMenuItem.Text = "Asignar a paciente"
        '
        'frmMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1130, 748)
        Me.Controls.Add(Me.pnlContenedorFormularios)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Médico - Hospital xxxx xxxx"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestionMenuItem As ToolStripMenuItem
    Friend WithEvents AtenderMenuItem As ToolStripMenuItem
    Friend WithEvents pnlContenedorFormularios As Panel
    Friend WithEvents FormulariosMenuItem As ToolStripMenuItem
    Friend WithEvents CrearFormularioMenuItem As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TratamientosMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarNuevoTratamientoMenuItem As ToolStripMenuItem
    Friend WithEvents TratamientoSeguimientoMenuItem As ToolStripMenuItem
    Friend WithEvents AnalisisMenuItem As ToolStripMenuItem
    Friend WithEvents AnalisisIngresarMenuItem1 As ToolStripMenuItem
    Friend WithEvents AnalisisHacerSeguimientoMenuItem1 As ToolStripMenuItem
    Friend WithEvents AsginarTratamientoPacienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignarAnalisisPacienteToolStripMenuItem As ToolStripMenuItem
End Class
