<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestionMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionMedico))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tabDatos = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblCedulaTXT = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblNombresTXT = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblApellidosTXT = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblDireccionTXT = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblTelefonoTXT = New System.Windows.Forms.Label()
        Me.lblEspecialidad = New System.Windows.Forms.Label()
        Me.lblEspecialidadTXT = New System.Windows.Forms.Label()
        Me.pBoxFotoMedico = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tabDatos.SuspendLayout()
        CType(Me.pBoxFotoMedico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.pBoxFotoMedico, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tabDatos, 1, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'tabDatos
        '
        resources.ApplyResources(Me.tabDatos, "tabDatos")
        Me.tabDatos.Controls.Add(Me.lblCedula, 0, 0)
        Me.tabDatos.Controls.Add(Me.lblCedulaTXT, 1, 0)
        Me.tabDatos.Controls.Add(Me.lblNombres, 0, 1)
        Me.tabDatos.Controls.Add(Me.lblNombresTXT, 1, 1)
        Me.tabDatos.Controls.Add(Me.lblApellido, 0, 2)
        Me.tabDatos.Controls.Add(Me.lblApellidosTXT, 1, 2)
        Me.tabDatos.Controls.Add(Me.lblDireccion, 0, 3)
        Me.tabDatos.Controls.Add(Me.lblDireccionTXT, 1, 3)
        Me.tabDatos.Controls.Add(Me.lblTelefono, 0, 4)
        Me.tabDatos.Controls.Add(Me.lblTelefonoTXT, 1, 4)
        Me.tabDatos.Controls.Add(Me.lblEspecialidad, 0, 5)
        Me.tabDatos.Controls.Add(Me.lblEspecialidadTXT, 1, 5)
        Me.tabDatos.Name = "tabDatos"
        '
        'lblCedula
        '
        resources.ApplyResources(Me.lblCedula, "lblCedula")
        Me.lblCedula.Name = "lblCedula"
        '
        'lblCedulaTXT
        '
        resources.ApplyResources(Me.lblCedulaTXT, "lblCedulaTXT")
        Me.lblCedulaTXT.Name = "lblCedulaTXT"
        '
        'lblNombres
        '
        resources.ApplyResources(Me.lblNombres, "lblNombres")
        Me.lblNombres.Name = "lblNombres"
        '
        'lblNombresTXT
        '
        resources.ApplyResources(Me.lblNombresTXT, "lblNombresTXT")
        Me.lblNombresTXT.Name = "lblNombresTXT"
        '
        'lblApellido
        '
        resources.ApplyResources(Me.lblApellido, "lblApellido")
        Me.lblApellido.Name = "lblApellido"
        '
        'lblApellidosTXT
        '
        resources.ApplyResources(Me.lblApellidosTXT, "lblApellidosTXT")
        Me.lblApellidosTXT.Name = "lblApellidosTXT"
        '
        'lblDireccion
        '
        resources.ApplyResources(Me.lblDireccion, "lblDireccion")
        Me.lblDireccion.Name = "lblDireccion"
        '
        'lblDireccionTXT
        '
        resources.ApplyResources(Me.lblDireccionTXT, "lblDireccionTXT")
        Me.lblDireccionTXT.Name = "lblDireccionTXT"
        '
        'lblTelefono
        '
        resources.ApplyResources(Me.lblTelefono, "lblTelefono")
        Me.lblTelefono.Name = "lblTelefono"
        '
        'lblTelefonoTXT
        '
        resources.ApplyResources(Me.lblTelefonoTXT, "lblTelefonoTXT")
        Me.lblTelefonoTXT.Name = "lblTelefonoTXT"
        '
        'lblEspecialidad
        '
        resources.ApplyResources(Me.lblEspecialidad, "lblEspecialidad")
        Me.lblEspecialidad.Name = "lblEspecialidad"
        '
        'lblEspecialidadTXT
        '
        resources.ApplyResources(Me.lblEspecialidadTXT, "lblEspecialidadTXT")
        Me.lblEspecialidadTXT.Name = "lblEspecialidadTXT"
        '
        'pBoxFotoMedico
        '
        resources.ApplyResources(Me.pBoxFotoMedico, "pBoxFotoMedico")
        Me.pBoxFotoMedico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBoxFotoMedico.Name = "pBoxFotoMedico"
        Me.pBoxFotoMedico.TabStop = False
        Me.pBoxFotoMedico.Tag = "noLimpiar"
        '
        'frmGestionMedico
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGestionMedico"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tabDatos.ResumeLayout(False)
        Me.tabDatos.PerformLayout()
        CType(Me.pBoxFotoMedico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents pBoxFotoMedico As PictureBox
    Friend WithEvents tabDatos As TableLayoutPanel
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblCedulaTXT As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblNombresTXT As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblApellidosTXT As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblDireccionTXT As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblTelefonoTXT As Label
    Friend WithEvents lblEspecialidad As Label
    Friend WithEvents lblEspecialidadTXT As Label
End Class
