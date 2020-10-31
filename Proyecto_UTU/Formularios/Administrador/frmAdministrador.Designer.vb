<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdministrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdministrador))
        Me.GestionMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteAltaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicoAltaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuxiliarMenuItemAlta = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteBajaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicoBajaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuxiliarMenuItemBaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificacionDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteModificacionMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicoModificacionMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuxiliarMenuItemModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaDeUsuariosMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteBusquedaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicoBusquedaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuxiliarBusquedaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarPersonalMedicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GestionMenuItem
        '
        resources.ApplyResources(Me.GestionMenuItem, "GestionMenuItem")
        Me.GestionMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeUsuariosToolStripMenuItem, Me.BajaDeUsuariosToolStripMenuItem, Me.ModificacionDeUsuariosToolStripMenuItem, Me.BusquedaDeUsuariosMenuItem})
        Me.GestionMenuItem.Name = "GestionMenuItem"
        '
        'AltaDeUsuariosToolStripMenuItem
        '
        resources.ApplyResources(Me.AltaDeUsuariosToolStripMenuItem, "AltaDeUsuariosToolStripMenuItem")
        Me.AltaDeUsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteAltaMenuItem, Me.MedicoAltaMenuItem, Me.AuxiliarMenuItemAlta})
        Me.AltaDeUsuariosToolStripMenuItem.Name = "AltaDeUsuariosToolStripMenuItem"
        '
        'PacienteAltaMenuItem
        '
        resources.ApplyResources(Me.PacienteAltaMenuItem, "PacienteAltaMenuItem")
        Me.PacienteAltaMenuItem.Name = "PacienteAltaMenuItem"
        '
        'MedicoAltaMenuItem
        '
        resources.ApplyResources(Me.MedicoAltaMenuItem, "MedicoAltaMenuItem")
        Me.MedicoAltaMenuItem.Name = "MedicoAltaMenuItem"
        '
        'AuxiliarMenuItemAlta
        '
        resources.ApplyResources(Me.AuxiliarMenuItemAlta, "AuxiliarMenuItemAlta")
        Me.AuxiliarMenuItemAlta.Name = "AuxiliarMenuItemAlta"
        '
        'BajaDeUsuariosToolStripMenuItem
        '
        resources.ApplyResources(Me.BajaDeUsuariosToolStripMenuItem, "BajaDeUsuariosToolStripMenuItem")
        Me.BajaDeUsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteBajaMenuItem, Me.MedicoBajaMenuItem, Me.AuxiliarMenuItemBaja})
        Me.BajaDeUsuariosToolStripMenuItem.Name = "BajaDeUsuariosToolStripMenuItem"
        '
        'PacienteBajaMenuItem
        '
        resources.ApplyResources(Me.PacienteBajaMenuItem, "PacienteBajaMenuItem")
        Me.PacienteBajaMenuItem.Name = "PacienteBajaMenuItem"
        '
        'MedicoBajaMenuItem
        '
        resources.ApplyResources(Me.MedicoBajaMenuItem, "MedicoBajaMenuItem")
        Me.MedicoBajaMenuItem.Name = "MedicoBajaMenuItem"
        '
        'AuxiliarMenuItemBaja
        '
        resources.ApplyResources(Me.AuxiliarMenuItemBaja, "AuxiliarMenuItemBaja")
        Me.AuxiliarMenuItemBaja.Name = "AuxiliarMenuItemBaja"
        '
        'ModificacionDeUsuariosToolStripMenuItem
        '
        resources.ApplyResources(Me.ModificacionDeUsuariosToolStripMenuItem, "ModificacionDeUsuariosToolStripMenuItem")
        Me.ModificacionDeUsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteModificacionMenuItem, Me.MedicoModificacionMenuItem, Me.AuxiliarMenuItemModificar})
        Me.ModificacionDeUsuariosToolStripMenuItem.Name = "ModificacionDeUsuariosToolStripMenuItem"
        '
        'PacienteModificacionMenuItem
        '
        resources.ApplyResources(Me.PacienteModificacionMenuItem, "PacienteModificacionMenuItem")
        Me.PacienteModificacionMenuItem.Name = "PacienteModificacionMenuItem"
        '
        'MedicoModificacionMenuItem
        '
        resources.ApplyResources(Me.MedicoModificacionMenuItem, "MedicoModificacionMenuItem")
        Me.MedicoModificacionMenuItem.Name = "MedicoModificacionMenuItem"
        '
        'AuxiliarMenuItemModificar
        '
        resources.ApplyResources(Me.AuxiliarMenuItemModificar, "AuxiliarMenuItemModificar")
        Me.AuxiliarMenuItemModificar.Name = "AuxiliarMenuItemModificar"
        '
        'BusquedaDeUsuariosMenuItem
        '
        resources.ApplyResources(Me.BusquedaDeUsuariosMenuItem, "BusquedaDeUsuariosMenuItem")
        Me.BusquedaDeUsuariosMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteBusquedaMenuItem, Me.MedicoBusquedaMenuItem, Me.AuxiliarBusquedaMenuItem})
        Me.BusquedaDeUsuariosMenuItem.Name = "BusquedaDeUsuariosMenuItem"
        '
        'PacienteBusquedaMenuItem
        '
        resources.ApplyResources(Me.PacienteBusquedaMenuItem, "PacienteBusquedaMenuItem")
        Me.PacienteBusquedaMenuItem.Name = "PacienteBusquedaMenuItem"
        '
        'MedicoBusquedaMenuItem
        '
        resources.ApplyResources(Me.MedicoBusquedaMenuItem, "MedicoBusquedaMenuItem")
        Me.MedicoBusquedaMenuItem.Name = "MedicoBusquedaMenuItem"
        '
        'AuxiliarBusquedaMenuItem
        '
        resources.ApplyResources(Me.AuxiliarBusquedaMenuItem, "AuxiliarBusquedaMenuItem")
        Me.AuxiliarBusquedaMenuItem.Name = "AuxiliarBusquedaMenuItem"
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioMenuItem, Me.GestionMenuItem, Me.GestionarPersonalMedicoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'InicioMenuItem
        '
        resources.ApplyResources(Me.InicioMenuItem, "InicioMenuItem")
        Me.InicioMenuItem.Name = "InicioMenuItem"
        '
        'GestionarPersonalMedicoToolStripMenuItem
        '
        resources.ApplyResources(Me.GestionarPersonalMedicoToolStripMenuItem, "GestionarPersonalMedicoToolStripMenuItem")
        Me.GestionarPersonalMedicoToolStripMenuItem.Name = "GestionarPersonalMedicoToolStripMenuItem"
        '
        'SalirToolStripMenuItem
        '
        resources.ApplyResources(Me.SalirToolStripMenuItem, "SalirToolStripMenuItem")
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        '
        'pnlContenedor
        '
        resources.ApplyResources(Me.pnlContenedor, "pnlContenedor")
        Me.pnlContenedor.Name = "pnlContenedor"
        '
        'frmAdministrador
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmAdministrador"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GestionMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificacionDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedaDeUsuariosMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents PacienteAltaMenuItem As ToolStripMenuItem
    Friend WithEvents MedicoAltaMenuItem As ToolStripMenuItem
    Friend WithEvents PacienteBajaMenuItem As ToolStripMenuItem
    Friend WithEvents MedicoBajaMenuItem As ToolStripMenuItem
    Friend WithEvents PacienteModificacionMenuItem As ToolStripMenuItem
    Friend WithEvents PacienteBusquedaMenuItem As ToolStripMenuItem
    Friend WithEvents MedicoModificacionMenuItem As ToolStripMenuItem
    Friend WithEvents MedicoBusquedaMenuItem As ToolStripMenuItem
    Friend WithEvents InicioMenuItem As ToolStripMenuItem
    Friend WithEvents AuxiliarMenuItemAlta As ToolStripMenuItem
    Friend WithEvents AuxiliarMenuItemBaja As ToolStripMenuItem
    Friend WithEvents AuxiliarMenuItemModificar As ToolStripMenuItem
    Friend WithEvents AuxiliarBusquedaMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarPersonalMedicoToolStripMenuItem As ToolStripMenuItem
End Class
