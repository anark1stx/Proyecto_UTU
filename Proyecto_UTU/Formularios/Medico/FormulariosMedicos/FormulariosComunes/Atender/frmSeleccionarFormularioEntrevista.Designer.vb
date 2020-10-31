<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionarFormularioEntrevista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeleccionarFormularioEntrevista))
        Me.btnFrmOtro = New System.Windows.Forms.Button()
        Me.btnFrmMalestar = New System.Windows.Forms.Button()
        Me.btnFrmFiebre = New System.Windows.Forms.Button()
        Me.btnFrmDolor = New System.Windows.Forms.Button()
        Me.btnFrmGenerico = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFrmOtro
        '
        resources.ApplyResources(Me.btnFrmOtro, "btnFrmOtro")
        Me.btnFrmOtro.Name = "btnFrmOtro"
        Me.btnFrmOtro.UseVisualStyleBackColor = True
        '
        'btnFrmMalestar
        '
        resources.ApplyResources(Me.btnFrmMalestar, "btnFrmMalestar")
        Me.btnFrmMalestar.Name = "btnFrmMalestar"
        Me.btnFrmMalestar.UseVisualStyleBackColor = True
        '
        'btnFrmFiebre
        '
        resources.ApplyResources(Me.btnFrmFiebre, "btnFrmFiebre")
        Me.btnFrmFiebre.Name = "btnFrmFiebre"
        Me.btnFrmFiebre.UseVisualStyleBackColor = True
        '
        'btnFrmDolor
        '
        resources.ApplyResources(Me.btnFrmDolor, "btnFrmDolor")
        Me.btnFrmDolor.Name = "btnFrmDolor"
        Me.btnFrmDolor.UseVisualStyleBackColor = True
        '
        'btnFrmGenerico
        '
        resources.ApplyResources(Me.btnFrmGenerico, "btnFrmGenerico")
        Me.btnFrmGenerico.Name = "btnFrmGenerico"
        Me.btnFrmGenerico.UseVisualStyleBackColor = True
        '
        'frmSeleccionarFormularioEntrevista
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.btnFrmOtro)
        Me.Controls.Add(Me.btnFrmMalestar)
        Me.Controls.Add(Me.btnFrmFiebre)
        Me.Controls.Add(Me.btnFrmDolor)
        Me.Controls.Add(Me.btnFrmGenerico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSeleccionarFormularioEntrevista"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFrmOtro As Button
    Friend WithEvents btnFrmMalestar As Button
    Friend WithEvents btnFrmFiebre As Button
    Friend WithEvents btnFrmDolor As Button
    Friend WithEvents btnFrmGenerico As Button
End Class
