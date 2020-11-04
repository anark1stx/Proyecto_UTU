<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.lblAtender = New System.Windows.Forms.Label()
        Me.btnAtenderPaciente = New System.Windows.Forms.Button()
        Me.fotoAtender = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCrearFormulario = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEditarFormulario = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblGestion = New System.Windows.Forms.Label()
        Me.btnGestion = New System.Windows.Forms.Button()
        Me.fotoAuxOmed = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAtender
        '
        resources.ApplyResources(Me.lblAtender, "lblAtender")
        Me.lblAtender.Name = "lblAtender"
        '
        'btnAtenderPaciente
        '
        resources.ApplyResources(Me.btnAtenderPaciente, "btnAtenderPaciente")
        Me.btnAtenderPaciente.ImageList = Me.fotoAtender
        Me.btnAtenderPaciente.Name = "btnAtenderPaciente"
        Me.btnAtenderPaciente.UseVisualStyleBackColor = True
        '
        'fotoAtender
        '
        Me.fotoAtender.ImageStream = CType(resources.GetObject("fotoAtender.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.fotoAtender.TransparentColor = System.Drawing.Color.Transparent
        Me.fotoAtender.Images.SetKeyName(0, "MedicoAtiendePaciente.png")
        Me.fotoAtender.Images.SetKeyName(1, "AuxAtiendePaciente.png")
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'btnCrearFormulario
        '
        resources.ApplyResources(Me.btnCrearFormulario, "btnCrearFormulario")
        Me.btnCrearFormulario.Name = "btnCrearFormulario"
        Me.btnCrearFormulario.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'btnEditarFormulario
        '
        resources.ApplyResources(Me.btnEditarFormulario, "btnEditarFormulario")
        Me.btnEditarFormulario.Name = "btnEditarFormulario"
        Me.btnEditarFormulario.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'Panel4
        '
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.btnEditarFormulario)
        Me.Panel4.Name = "Panel4"
        '
        'Panel3
        '
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btnCrearFormulario)
        Me.Panel3.Name = "Panel3"
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Controls.Add(Me.lblGestion)
        Me.Panel1.Controls.Add(Me.btnGestion)
        Me.Panel1.Name = "Panel1"
        '
        'lblGestion
        '
        resources.ApplyResources(Me.lblGestion, "lblGestion")
        Me.lblGestion.Name = "lblGestion"
        '
        'btnGestion
        '
        resources.ApplyResources(Me.btnGestion, "btnGestion")
        Me.btnGestion.ImageList = Me.fotoAuxOmed
        Me.btnGestion.Name = "btnGestion"
        Me.btnGestion.UseVisualStyleBackColor = True
        '
        'fotoAuxOmed
        '
        Me.fotoAuxOmed.ImageStream = CType(resources.GetObject("fotoAuxOmed.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.fotoAuxOmed.TransparentColor = System.Drawing.Color.Transparent
        Me.fotoAuxOmed.Images.SetKeyName(0, "solo_medico.png")
        Me.fotoAuxOmed.Images.SetKeyName(1, "solo_auxiliar.png")
        '
        'Panel2
        '
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Controls.Add(Me.lblAtender)
        Me.Panel2.Controls.Add(Me.btnAtenderPaciente)
        Me.Panel2.Name = "Panel2"
        '
        'frmInicio
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInicio"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAtender As Label
    Friend WithEvents btnAtenderPaciente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCrearFormulario As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEditarFormulario As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblGestion As Label
    Friend WithEvents btnGestion As Button
    Friend WithEvents fotoAuxOmed As ImageList
    Friend WithEvents fotoAtender As ImageList
End Class
