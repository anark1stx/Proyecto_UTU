<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarItems))
        Me.cbItems = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbItems
        '
        resources.ApplyResources(Me.cbItems, "cbItems")
        Me.cbItems.FormattingEnabled = True
        Me.cbItems.Name = "cbItems"
        '
        'btnAgregar
        '
        resources.ApplyResources(Me.btnAgregar, "btnAgregar")
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        resources.ApplyResources(Me.btnQuitar, "btnQuitar")
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'frmAgregarItems
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.cbItems)
        Me.Name = "frmAgregarItems"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbItems As ComboBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnQuitar As Button
End Class
