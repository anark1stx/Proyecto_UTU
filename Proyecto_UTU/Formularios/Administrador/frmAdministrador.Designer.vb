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
        Me.BajaDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteBajaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicoBajaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificaciónDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteModificacionMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicoModificacionMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BúsquedaDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteBusquedaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MédicoBusquedaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.AltaDeUsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteAltaMenuItem, Me.MedicoAltaMenuItem})
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
        'BajaDeUsuariosToolStripMenuItem
        '
        Me.BajaDeUsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteBajaMenuItem, Me.MedicoBajaMenuItem})
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
        'ModificaciónDeUsuariosToolStripMenuItem
        '
        Me.ModificaciónDeUsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteModificacionMenuItem, Me.MedicoModificacionMenuItem})
        Me.ModificaciónDeUsuariosToolStripMenuItem.Name = "ModificaciónDeUsuariosToolStripMenuItem"
        Me.ModificaciónDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(258, 26)
        Me.ModificaciónDeUsuariosToolStripMenuItem.Text = "Modificación de usuarios"
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
        'BúsquedaDeUsuariosToolStripMenuItem
        '
        Me.BúsquedaDeUsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteBusquedaMenuItem, Me.MédicoBusquedaMenuItem})
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
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAdministrador"
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
End Class
