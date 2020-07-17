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
        Me.GestiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteAltaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicoAltaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuxiliarMenuItemAlta = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteBajaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicoBajaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuxiliarMenuItemBaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificaciónDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteModificacionMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicoModificacionMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuxiliarMenuItemModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.BúsquedaDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteBusquedaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MédicoBusquedaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuxiliarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GestiónToolStripMenuItem
        '
        Me.GestiónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeUsuariosToolStripMenuItem, Me.BajaDeUsuariosToolStripMenuItem, Me.ModificaciónDeUsuariosToolStripMenuItem, Me.BúsquedaDeUsuariosToolStripMenuItem})
        Me.GestiónToolStripMenuItem.Name = "GestiónToolStripMenuItem"
        Me.GestiónToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.GestiónToolStripMenuItem.Text = "Gestión de usuarios"
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
        'ModificaciónDeUsuariosToolStripMenuItem
        '
        Me.ModificaciónDeUsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteModificacionMenuItem, Me.MedicoModificacionMenuItem, Me.AuxiliarMenuItemModificar})
        Me.ModificaciónDeUsuariosToolStripMenuItem.Name = "ModificaciónDeUsuariosToolStripMenuItem"
        Me.ModificaciónDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(258, 26)
        Me.ModificaciónDeUsuariosToolStripMenuItem.Text = "Modificación de usuarios"
        '
        'PacienteModificacionMenuItem
        '
        Me.PacienteModificacionMenuItem.Name = "PacienteModificacionMenuItem"
        Me.PacienteModificacionMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PacienteModificacionMenuItem.Text = "Paciente"
        '
        'MedicoModificacionMenuItem
        '
        Me.MedicoModificacionMenuItem.Name = "MedicoModificacionMenuItem"
        Me.MedicoModificacionMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.MedicoModificacionMenuItem.Text = "Médico"
        '
        'AuxiliarMenuItemModificar
        '
        Me.AuxiliarMenuItemModificar.Name = "AuxiliarMenuItemModificar"
        Me.AuxiliarMenuItemModificar.Size = New System.Drawing.Size(224, 26)
        Me.AuxiliarMenuItemModificar.Text = "Auxiliar"
        '
        'BúsquedaDeUsuariosToolStripMenuItem
        '
        Me.BúsquedaDeUsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteBusquedaMenuItem, Me.MédicoBusquedaMenuItem, Me.AuxiliarToolStripMenuItem3})
        Me.BúsquedaDeUsuariosToolStripMenuItem.Name = "BúsquedaDeUsuariosToolStripMenuItem"
        Me.BúsquedaDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(258, 26)
        Me.BúsquedaDeUsuariosToolStripMenuItem.Text = "Búsqueda de usuarios"
        '
        'PacienteBusquedaMenuItem
        '
        Me.PacienteBusquedaMenuItem.Name = "PacienteBusquedaMenuItem"
        Me.PacienteBusquedaMenuItem.Size = New System.Drawing.Size(147, 26)
        Me.PacienteBusquedaMenuItem.Text = "Paciente"
        '
        'MédicoBusquedaMenuItem
        '
        Me.MédicoBusquedaMenuItem.Name = "MédicoBusquedaMenuItem"
        Me.MédicoBusquedaMenuItem.Size = New System.Drawing.Size(147, 26)
        Me.MédicoBusquedaMenuItem.Text = "Médico"
        '
        'AuxiliarToolStripMenuItem3
        '
        Me.AuxiliarToolStripMenuItem3.Name = "AuxiliarToolStripMenuItem3"
        Me.AuxiliarToolStripMenuItem3.Size = New System.Drawing.Size(224, 26)
        Me.AuxiliarToolStripMenuItem3.Text = "Auxiliar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.GestiónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1062, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 31)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1062, 639)
        Me.pnlContenedor.TabIndex = 1
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

    Friend WithEvents GestiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificaciónDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BúsquedaDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents PacienteAltaMenuItem As ToolStripMenuItem
    Friend WithEvents MedicoAltaMenuItem As ToolStripMenuItem
    Friend WithEvents PacienteBajaMenuItem As ToolStripMenuItem
    Friend WithEvents MedicoBajaMenuItem As ToolStripMenuItem
    Friend WithEvents PacienteModificacionMenuItem As ToolStripMenuItem
    Friend WithEvents PacienteBusquedaMenuItem As ToolStripMenuItem
    Friend WithEvents MedicoModificacionMenuItem As ToolStripMenuItem
    Friend WithEvents MédicoBusquedaMenuItem As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuxiliarMenuItemAlta As ToolStripMenuItem
    Friend WithEvents AuxiliarMenuItemBaja As ToolStripMenuItem
    Friend WithEvents AuxiliarMenuItemModificar As ToolStripMenuItem
    Friend WithEvents AuxiliarToolStripMenuItem3 As ToolStripMenuItem
End Class
