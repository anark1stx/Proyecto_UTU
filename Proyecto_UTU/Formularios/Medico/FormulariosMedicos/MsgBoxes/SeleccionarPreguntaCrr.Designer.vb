<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionarPreguntaCrr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeleccionarPreguntaCrr))
        Me.lblSeleccioneTipoDeDato = New System.Windows.Forms.Label()
        Me.cbPreguntas = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblSeleccioneTipoDeDato
        '
        resources.ApplyResources(Me.lblSeleccioneTipoDeDato, "lblSeleccioneTipoDeDato")
        Me.lblSeleccioneTipoDeDato.Name = "lblSeleccioneTipoDeDato"
        '
        'cbPreguntas
        '
        resources.ApplyResources(Me.cbPreguntas, "cbPreguntas")
        Me.cbPreguntas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPreguntas.FormattingEnabled = True
        Me.cbPreguntas.Name = "cbPreguntas"
        '
        'SeleccionarPreguntaCrr
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.Controls.Add(Me.lblSeleccioneTipoDeDato)
        Me.Controls.Add(Me.cbPreguntas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SeleccionarPreguntaCrr"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSeleccioneTipoDeDato As Label
    Friend WithEvents cbPreguntas As ComboBox
End Class
