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
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GestionMenuItem
        '
        Me.GestionMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeUsuariosToolStripMenuItem, Me.BajaDeUsuariosToolStripMenuItem, Me.ModificacionDeUsuariosToolStripMenuItem, Me.BusquedaDeUsuariosMenuItem})
        Me.GestionMenuItem.Name = "GestionMenuItem"
        Me.GestionMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.GestionMenuItem.Text = "Gestión de usuarios"
        '
        'AltaDeUsuariosToolStripMenuItem
        '
        Me.AltaDeUsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteAltaMenuItem, Me.MedicoAltaMenuItem, Me.AuxiliarMenuItemAlta})
        Me.AltaDeUsuariosToolStripMenuItem.Name = "AltaDeUsuariosToolStripMenuItem"
        Me.AltaDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(258, 26)
        Me.AltaDeUsuariosToolStripMenuItem.Text = "Alta de usuarios"
        '
        'PacienteAltaMenuItem
        '
        Me.PacienteAltaMenuItem.Name = "PacienteAltaMenuItem"
        Me.PacienteAltaMenuItem.Size = New System.Drawing.Size(147, 26)
        Me.PacienteAltaMenuItem.Text = "Paciente"
        '
        'MedicoAltaMenuItem
        '
        Me.MedicoAltaMenuItem.Name = "MedicoAltaMenuItem"
        Me.MedicoAltaMenuItem.Size = New System.Drawing.Size(147, 26)
        Me.MedicoAltaMenuItem.Text = "Médico"
        '
        'AuxiliarMenuItemAlta
        '
        Me.AuxiliarMenuItemAlta.Name = "AuxiliarMenuItemAlta"
        Me.AuxiliarMenuItemAlta.Size = New System.Drawing.Size(147, 26)
        Me.AuxiliarMenuItemAlta.Text = "Auxiliar"
        '
        'BajaDeUsuariosToolStripMenuItem
        '
        Me.BajaDeUsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteBajaMenuItem, Me.MedicoBajaMenuItem, Me.AuxiliarMenuItemBaja})
        Me.BajaDeUsuariosToolStripMenuItem.Name = "BajaDeUsuariosToolStripMenuItem"
        Me.BajaDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(258, 26)
        Me.BajaDeUsuariosToolStripMenuItem.Text = "Baja de usuarios"
        '
        'PacienteBajaMenuItem
        '
        Me.PacienteBajaMenuItem.Name = "PacienteBajaMenuItem"
        Me.PacienteBajaMenuItem.Size = New System.Drawing.Size(147, 26)
        Me.PacienteBajaMenuItem.Text = "Paciente"
        '
        'MedicoBajaMenuItem
        '
        Me.MedicoBajaMenuItem.Name = "MedicoBajaMenuItem"
        Me.MedicoBajaMenuItem.Size = New System.Drawing.Size(147, 26)
        Me.MedicoBajaMenuItem.Text = "Médico"
        '
        'AuxiliarMenuItemBaja
        '
        Me.AuxiliarMenuItemBaja.Name = "AuxiliarMenuItemBaja"
        Me.AuxiliarMenuItemBaja.Size = New System.Drawing.Size(147, 26)
        Me.AuxiliarMenuItemBaja.Text = "Auxiliar"
        '
        'ModificacionDeUsuariosToolStripMenuItem
        '
        Me.ModificacionDeUsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteModificacionMenuItem, Me.MedicoModificacionMenuItem, Me.AuxiliarMenuItemModificar})
        Me.ModificacionDeUsuariosToolStripMenuItem.Name = "ModificacionDeUsuariosToolStripMenuItem"
        Me.ModificacionDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(258, 26)
        Me.ModificacionDeUsuariosToolStripMenuItem.Text = "Modificación de usuarios"
        '
        'PacienteModificacionMenuItem
        '
        Me.PacienteModificacionMenuItem.Name = "PacienteModificacionMenuItem"
        Me.PacienteModificacionMenuItem.Size = New System.Drawing.Size(147, 26)
        Me.PacienteModificacionMenuItem.Text = "Paciente"
        '
        'MedicoModificacionMenuItem
        '
        Me.MedicoModificacionMenuItem.Name = "MedicoModificacionMenuItem"
        Me.MedicoModificacionMenuItem.Size = New System.Drawing.Size(147, 26)
        Me.MedicoModificacionMenuItem.Text = "Médico"
        '
        'AuxiliarMenuItemModificar
        '
        Me.AuxiliarMenuItemModificar.Name = "AuxiliarMenuItemModificar"
        Me.AuxiliarMenuItemModificar.Size = New System.Drawing.Size(147, 26)
        Me.AuxiliarMenuItemModificar.Text = "Auxiliar"
        '
        'BusquedaDeUsuariosMenuItem
        '
        Me.BusquedaDeUsuariosMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteBusquedaMenuItem, Me.MedicoBusquedaMenuItem, Me.AuxiliarBusquedaMenuItem})
        Me.BusquedaDeUsuariosMenuItem.Name = "BusquedaDeUsuariosMenuItem"
        Me.BusquedaDeUsuariosMenuItem.Size = New System.Drawing.Size(258, 26)
        Me.BusquedaDeUsuariosMenuItem.Text = "Búsqueda de usuarios"
        '
        'PacienteBusquedaMenuItem
        '
        Me.PacienteBusquedaMenuItem.Name = "PacienteBusquedaMenuItem"
        Me.PacienteBusquedaMenuItem.Size = New System.Drawing.Size(147, 26)
        Me.PacienteBusquedaMenuItem.Text = "Paciente"
        '
        'MedicoBusquedaMenuItem
        '
        Me.MedicoBusquedaMenuItem.Name = "MedicoBusquedaMenuItem"
        Me.MedicoBusquedaMenuItem.Size = New System.Drawing.Size(147, 26)
        Me.MedicoBusquedaMenuItem.Text = "Médico"
        '
        'AuxiliarBusquedaMenuItem
        '
        Me.AuxiliarBusquedaMenuItem.Name = "AuxiliarBusquedaMenuItem"
        Me.AuxiliarBusquedaMenuItem.Size = New System.Drawing.Size(147, 26)
        Me.AuxiliarBusquedaMenuItem.Text = "Auxiliar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioMenuItem, Me.GestionMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1062, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioMenuItem
        '
        Me.InicioMenuItem.Name = "InicioMenuItem"
        Me.InicioMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.InicioMenuItem.Text = "Inicio"
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 31)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1062, 639)
        Me.pnlContenedor.TabIndex = 1
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'frmAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1062, 673)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmAdministrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración"
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
End Class
