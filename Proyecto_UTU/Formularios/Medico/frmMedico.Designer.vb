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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedico))
        Me.MenuOpciones = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntrevistaInicialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeleccionarMedicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdentificarPacienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerListadoDeHoyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtenderMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefinirConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdentificarPacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerListadoDeHoyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormulariosMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearFormularioMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TratamientosMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarNuevoTratamientoMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TratamientoSeguimientoMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsginarTratamientoPacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalisisMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalisisIngresarMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalisisHacerSeguimientoMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlContenedorFormularios = New System.Windows.Forms.Panel()
        Me.MenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuOpciones
        '
        Me.MenuOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.GestionMenuItem, Me.EntrevistaInicialToolStripMenuItem, Me.AtenderMenuItem, Me.FormulariosMenuItem, Me.TratamientosMenuItem, Me.AnalisisMenuItem, Me.SalirToolStripMenuItem})
        resources.ApplyResources(Me.MenuOpciones, "MenuOpciones")
        Me.MenuOpciones.Name = "MenuOpciones"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        resources.ApplyResources(Me.InicioToolStripMenuItem, "InicioToolStripMenuItem")
        '
        'GestionMenuItem
        '
        Me.GestionMenuItem.Name = "GestionMenuItem"
        resources.ApplyResources(Me.GestionMenuItem, "GestionMenuItem")
        '
        'EntrevistaInicialToolStripMenuItem
        '
        Me.EntrevistaInicialToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeleccionarMedicoToolStripMenuItem, Me.IdentificarPacienteToolStripMenuItem1, Me.VerListadoDeHoyToolStripMenuItem1})
        Me.EntrevistaInicialToolStripMenuItem.Name = "EntrevistaInicialToolStripMenuItem"
        resources.ApplyResources(Me.EntrevistaInicialToolStripMenuItem, "EntrevistaInicialToolStripMenuItem")
        '
        'SeleccionarMedicoToolStripMenuItem
        '
        Me.SeleccionarMedicoToolStripMenuItem.Name = "SeleccionarMedicoToolStripMenuItem"
        resources.ApplyResources(Me.SeleccionarMedicoToolStripMenuItem, "SeleccionarMedicoToolStripMenuItem")
        '
        'IdentificarPacienteToolStripMenuItem1
        '
        Me.IdentificarPacienteToolStripMenuItem1.Name = "IdentificarPacienteToolStripMenuItem1"
        resources.ApplyResources(Me.IdentificarPacienteToolStripMenuItem1, "IdentificarPacienteToolStripMenuItem1")
        '
        'VerListadoDeHoyToolStripMenuItem1
        '
        Me.VerListadoDeHoyToolStripMenuItem1.Name = "VerListadoDeHoyToolStripMenuItem1"
        resources.ApplyResources(Me.VerListadoDeHoyToolStripMenuItem1, "VerListadoDeHoyToolStripMenuItem1")
        '
        'AtenderMenuItem
        '
        Me.AtenderMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefinirConsultaToolStripMenuItem, Me.IdentificarPacienteToolStripMenuItem, Me.VerListadoDeHoyToolStripMenuItem})
        Me.AtenderMenuItem.Name = "AtenderMenuItem"
        resources.ApplyResources(Me.AtenderMenuItem, "AtenderMenuItem")
        '
        'DefinirConsultaToolStripMenuItem
        '
        Me.DefinirConsultaToolStripMenuItem.Name = "DefinirConsultaToolStripMenuItem"
        resources.ApplyResources(Me.DefinirConsultaToolStripMenuItem, "DefinirConsultaToolStripMenuItem")
        '
        'IdentificarPacienteToolStripMenuItem
        '
        Me.IdentificarPacienteToolStripMenuItem.Name = "IdentificarPacienteToolStripMenuItem"
        resources.ApplyResources(Me.IdentificarPacienteToolStripMenuItem, "IdentificarPacienteToolStripMenuItem")
        '
        'VerListadoDeHoyToolStripMenuItem
        '
        Me.VerListadoDeHoyToolStripMenuItem.Name = "VerListadoDeHoyToolStripMenuItem"
        resources.ApplyResources(Me.VerListadoDeHoyToolStripMenuItem, "VerListadoDeHoyToolStripMenuItem")
        '
        'FormulariosMenuItem
        '
        Me.FormulariosMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearFormularioMenuItem})
        Me.FormulariosMenuItem.Name = "FormulariosMenuItem"
        resources.ApplyResources(Me.FormulariosMenuItem, "FormulariosMenuItem")
        '
        'CrearFormularioMenuItem
        '
        Me.CrearFormularioMenuItem.Name = "CrearFormularioMenuItem"
        resources.ApplyResources(Me.CrearFormularioMenuItem, "CrearFormularioMenuItem")
        '
        'TratamientosMenuItem
        '
        Me.TratamientosMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarNuevoTratamientoMenuItem, Me.TratamientoSeguimientoMenuItem, Me.AsginarTratamientoPacienteToolStripMenuItem})
        Me.TratamientosMenuItem.Name = "TratamientosMenuItem"
        resources.ApplyResources(Me.TratamientosMenuItem, "TratamientosMenuItem")
        '
        'IngresarNuevoTratamientoMenuItem
        '
        Me.IngresarNuevoTratamientoMenuItem.Name = "IngresarNuevoTratamientoMenuItem"
        resources.ApplyResources(Me.IngresarNuevoTratamientoMenuItem, "IngresarNuevoTratamientoMenuItem")
        '
        'TratamientoSeguimientoMenuItem
        '
        Me.TratamientoSeguimientoMenuItem.Name = "TratamientoSeguimientoMenuItem"
        resources.ApplyResources(Me.TratamientoSeguimientoMenuItem, "TratamientoSeguimientoMenuItem")
        '
        'AsginarTratamientoPacienteToolStripMenuItem
        '
        Me.AsginarTratamientoPacienteToolStripMenuItem.Name = "AsginarTratamientoPacienteToolStripMenuItem"
        resources.ApplyResources(Me.AsginarTratamientoPacienteToolStripMenuItem, "AsginarTratamientoPacienteToolStripMenuItem")
        '
        'AnalisisMenuItem
        '
        Me.AnalisisMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnalisisIngresarMenuItem1, Me.AnalisisHacerSeguimientoMenuItem1})
        Me.AnalisisMenuItem.Name = "AnalisisMenuItem"
        resources.ApplyResources(Me.AnalisisMenuItem, "AnalisisMenuItem")
        '
        'AnalisisIngresarMenuItem1
        '
        Me.AnalisisIngresarMenuItem1.Name = "AnalisisIngresarMenuItem1"
        resources.ApplyResources(Me.AnalisisIngresarMenuItem1, "AnalisisIngresarMenuItem1")
        '
        'AnalisisHacerSeguimientoMenuItem1
        '
        Me.AnalisisHacerSeguimientoMenuItem1.Name = "AnalisisHacerSeguimientoMenuItem1"
        resources.ApplyResources(Me.AnalisisHacerSeguimientoMenuItem1, "AnalisisHacerSeguimientoMenuItem1")
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
        'frmMedico
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.pnlContenedorFormularios)
        Me.Controls.Add(Me.MenuOpciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuOpciones
        Me.Name = "frmMedico"
        Me.MenuOpciones.ResumeLayout(False)
        Me.MenuOpciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuOpciones As MenuStrip
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
    Friend WithEvents EntrevistaInicialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdentificarPacienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerListadoDeHoyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarMedicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerListadoDeHoyToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DefinirConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdentificarPacienteToolStripMenuItem1 As ToolStripMenuItem
End Class
