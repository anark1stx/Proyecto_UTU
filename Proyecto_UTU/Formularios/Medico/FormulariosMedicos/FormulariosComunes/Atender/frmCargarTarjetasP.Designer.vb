<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarTarjetasP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargarTarjetasP))
        Me.tblTodo = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlTodo = New System.Windows.Forms.Panel()
        Me.tblTarjetasYRefrescar = New System.Windows.Forms.TableLayoutPanel()
        Me.tblTarjetas = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tblAcciones = New System.Windows.Forms.TableLayoutPanel()
        Me.btnVerTratamientos = New System.Windows.Forms.Button()
        Me.btnVerAnalisis = New System.Windows.Forms.Button()
        Me.btnVerConsultasPrevias = New System.Windows.Forms.Button()
        Me.btnAtender = New System.Windows.Forms.Button()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.tblTodo.SuspendLayout()
        Me.pnlTodo.SuspendLayout()
        Me.tblTarjetasYRefrescar.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tblAcciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblTodo
        '
        resources.ApplyResources(Me.tblTodo, "tblTodo")
        Me.tblTodo.Controls.Add(Me.pnlTodo, 0, 0)
        Me.tblTodo.Name = "tblTodo"
        '
        'pnlTodo
        '
        resources.ApplyResources(Me.pnlTodo, "pnlTodo")
        Me.pnlTodo.Controls.Add(Me.tblTarjetasYRefrescar)
        Me.pnlTodo.Controls.Add(Me.Panel2)
        Me.pnlTodo.Name = "pnlTodo"
        '
        'tblTarjetasYRefrescar
        '
        resources.ApplyResources(Me.tblTarjetasYRefrescar, "tblTarjetasYRefrescar")
        Me.tblTarjetasYRefrescar.Controls.Add(Me.tblTarjetas, 0, 1)
        Me.tblTarjetasYRefrescar.Controls.Add(Me.btnRefrescar, 0, 0)
        Me.tblTarjetasYRefrescar.Name = "tblTarjetasYRefrescar"
        '
        'tblTarjetas
        '
        resources.ApplyResources(Me.tblTarjetas, "tblTarjetas")
        Me.tblTarjetas.Name = "tblTarjetas"
        '
        'Panel2
        '
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Controls.Add(Me.tblAcciones)
        Me.Panel2.Name = "Panel2"
        '
        'tblAcciones
        '
        resources.ApplyResources(Me.tblAcciones, "tblAcciones")
        Me.tblAcciones.Controls.Add(Me.btnVerTratamientos, 0, 3)
        Me.tblAcciones.Controls.Add(Me.btnVerAnalisis, 0, 2)
        Me.tblAcciones.Controls.Add(Me.btnVerConsultasPrevias, 0, 1)
        Me.tblAcciones.Controls.Add(Me.btnAtender, 0, 0)
        Me.tblAcciones.Name = "tblAcciones"
        '
        'btnVerTratamientos
        '
        resources.ApplyResources(Me.btnVerTratamientos, "btnVerTratamientos")
        Me.btnVerTratamientos.BackColor = System.Drawing.Color.LightCoral
        Me.btnVerTratamientos.Name = "btnVerTratamientos"
        Me.btnVerTratamientos.UseVisualStyleBackColor = False
        '
        'btnVerAnalisis
        '
        resources.ApplyResources(Me.btnVerAnalisis, "btnVerAnalisis")
        Me.btnVerAnalisis.BackColor = System.Drawing.Color.LightGreen
        Me.btnVerAnalisis.Name = "btnVerAnalisis"
        Me.btnVerAnalisis.UseVisualStyleBackColor = False
        '
        'btnVerConsultasPrevias
        '
        resources.ApplyResources(Me.btnVerConsultasPrevias, "btnVerConsultasPrevias")
        Me.btnVerConsultasPrevias.BackColor = System.Drawing.Color.MediumPurple
        Me.btnVerConsultasPrevias.Name = "btnVerConsultasPrevias"
        Me.btnVerConsultasPrevias.UseVisualStyleBackColor = False
        '
        'btnAtender
        '
        resources.ApplyResources(Me.btnAtender, "btnAtender")
        Me.btnAtender.BackColor = System.Drawing.Color.SkyBlue
        Me.btnAtender.Name = "btnAtender"
        Me.btnAtender.UseVisualStyleBackColor = False
        '
        'btnRefrescar
        '
        resources.ApplyResources(Me.btnRefrescar, "btnRefrescar")
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'frmCargarTarjetasP
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.tblTodo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCargarTarjetasP"
        Me.tblTodo.ResumeLayout(False)
        Me.pnlTodo.ResumeLayout(False)
        Me.tblTarjetasYRefrescar.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.tblAcciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblTodo As TableLayoutPanel
    Friend WithEvents pnlTodo As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tblAcciones As TableLayoutPanel
    Friend WithEvents btnVerTratamientos As Button
    Friend WithEvents btnVerAnalisis As Button
    Friend WithEvents btnVerConsultasPrevias As Button
    Friend WithEvents btnAtender As Button
    Friend WithEvents tblTarjetasYRefrescar As TableLayoutPanel
    Friend WithEvents btnRefrescar As Button
    Friend WithEvents tblTarjetas As TableLayoutPanel
End Class
