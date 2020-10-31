<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosAnalisis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosAnalisis))
        Me.pnlData = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tblParametros = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUnidad = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblParametro = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.pnlData.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tblParametros.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlData
        '
        resources.ApplyResources(Me.pnlData, "pnlData")
        Me.pnlData.Controls.Add(Me.Panel1)
        Me.pnlData.Controls.Add(Me.lblTitulo)
        Me.pnlData.Name = "pnlData"
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Controls.Add(Me.tblParametros)
        Me.Panel1.Name = "Panel1"
        '
        'tblParametros
        '
        resources.ApplyResources(Me.tblParametros, "tblParametros")
        Me.tblParametros.Controls.Add(Me.Label2, 4, 0)
        Me.tblParametros.Controls.Add(Me.Label1, 3, 0)
        Me.tblParametros.Controls.Add(Me.lblUnidad, 2, 0)
        Me.tblParametros.Controls.Add(Me.lblValor, 1, 0)
        Me.tblParametros.Controls.Add(Me.lblParametro, 0, 0)
        Me.tblParametros.Name = "tblParametros"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'lblUnidad
        '
        resources.ApplyResources(Me.lblUnidad, "lblUnidad")
        Me.lblUnidad.Name = "lblUnidad"
        '
        'lblValor
        '
        resources.ApplyResources(Me.lblValor, "lblValor")
        Me.lblValor.Name = "lblValor"
        '
        'lblParametro
        '
        resources.ApplyResources(Me.lblParametro, "lblParametro")
        Me.lblParametro.Name = "lblParametro"
        '
        'lblTitulo
        '
        resources.ApplyResources(Me.lblTitulo, "lblTitulo")
        Me.lblTitulo.Name = "lblTitulo"
        '
        'btnGuardar
        '
        resources.ApplyResources(Me.btnGuardar, "btnGuardar")
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmDatosAnalisis
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.pnlData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDatosAnalisis"
        Me.pnlData.ResumeLayout(False)
        Me.pnlData.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tblParametros.ResumeLayout(False)
        Me.tblParametros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlData As Panel
    Friend WithEvents tblParametros As TableLayoutPanel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblParametro As Label
    Friend WithEvents lblUnidad As Label
    Friend WithEvents lblValor As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
End Class
