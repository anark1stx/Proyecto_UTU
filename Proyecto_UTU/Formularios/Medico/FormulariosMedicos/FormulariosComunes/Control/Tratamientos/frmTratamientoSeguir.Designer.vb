<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTratamientoSeguir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTratamientoSeguir))
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.txtFechaFinalizacion = New System.Windows.Forms.TextBox()
        Me.txtFechaInicio = New System.Windows.Forms.TextBox()
        Me.lbDiasSemana = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tblSeguimiento = New System.Windows.Forms.TableLayoutPanel()
        Me.txtSeguimiento = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.tblResultado = New System.Windows.Forms.TableLayoutPanel()
        Me.btnResultado = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDiasDisponiblesSeguimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblSeguimiento = New System.Windows.Forms.Label()
        Me.lblNombreTratamientoTXT = New System.Windows.Forms.Label()
        Me.lblIndicaciones = New System.Windows.Forms.Label()
        Me.txtDescripcionTratamiento = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlContenedor.SuspendLayout()
        Me.tblSeguimiento.SuspendLayout()
        Me.tblResultado.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        resources.ApplyResources(Me.pnlContenedor, "pnlContenedor")
        Me.pnlContenedor.Controls.Add(Me.txtFechaFinalizacion)
        Me.pnlContenedor.Controls.Add(Me.txtFechaInicio)
        Me.pnlContenedor.Controls.Add(Me.lbDiasSemana)
        Me.pnlContenedor.Controls.Add(Me.Label2)
        Me.pnlContenedor.Controls.Add(Me.tblSeguimiento)
        Me.pnlContenedor.Controls.Add(Me.lblFechaFin)
        Me.pnlContenedor.Controls.Add(Me.lblFechaInicio)
        Me.pnlContenedor.Controls.Add(Me.Label1)
        Me.pnlContenedor.Controls.Add(Me.dtpDiasDisponiblesSeguimiento)
        Me.pnlContenedor.Controls.Add(Me.lblSeguimiento)
        Me.pnlContenedor.Controls.Add(Me.lblNombreTratamientoTXT)
        Me.pnlContenedor.Controls.Add(Me.lblIndicaciones)
        Me.pnlContenedor.Controls.Add(Me.txtDescripcionTratamiento)
        Me.pnlContenedor.Name = "pnlContenedor"
        '
        'txtFechaFinalizacion
        '
        resources.ApplyResources(Me.txtFechaFinalizacion, "txtFechaFinalizacion")
        Me.txtFechaFinalizacion.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtFechaFinalizacion.Name = "txtFechaFinalizacion"
        Me.txtFechaFinalizacion.ReadOnly = True
        '
        'txtFechaInicio
        '
        resources.ApplyResources(Me.txtFechaInicio, "txtFechaInicio")
        Me.txtFechaInicio.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.ReadOnly = True
        '
        'lbDiasSemana
        '
        resources.ApplyResources(Me.lbDiasSemana, "lbDiasSemana")
        Me.lbDiasSemana.FormattingEnabled = True
        Me.lbDiasSemana.Name = "lbDiasSemana"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'tblSeguimiento
        '
        resources.ApplyResources(Me.tblSeguimiento, "tblSeguimiento")
        Me.tblSeguimiento.Controls.Add(Me.txtSeguimiento, 0, 0)
        Me.tblSeguimiento.Controls.Add(Me.btnGuardar, 0, 1)
        Me.tblSeguimiento.Controls.Add(Me.tblResultado, 0, 2)
        Me.tblSeguimiento.Name = "tblSeguimiento"
        '
        'txtSeguimiento
        '
        resources.ApplyResources(Me.txtSeguimiento, "txtSeguimiento")
        Me.txtSeguimiento.Name = "txtSeguimiento"
        '
        'btnGuardar
        '
        resources.ApplyResources(Me.btnGuardar, "btnGuardar")
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'tblResultado
        '
        resources.ApplyResources(Me.tblResultado, "tblResultado")
        Me.tblResultado.Controls.Add(Me.btnResultado, 2, 0)
        Me.tblResultado.Controls.Add(Me.Label3, 0, 0)
        Me.tblResultado.Controls.Add(Me.txtResultado, 1, 0)
        Me.tblResultado.Name = "tblResultado"
        '
        'btnResultado
        '
        resources.ApplyResources(Me.btnResultado, "btnResultado")
        Me.btnResultado.Name = "btnResultado"
        Me.btnResultado.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'txtResultado
        '
        resources.ApplyResources(Me.txtResultado, "txtResultado")
        Me.txtResultado.Name = "txtResultado"
        '
        'lblFechaFin
        '
        resources.ApplyResources(Me.lblFechaFin, "lblFechaFin")
        Me.lblFechaFin.Name = "lblFechaFin"
        '
        'lblFechaInicio
        '
        resources.ApplyResources(Me.lblFechaInicio, "lblFechaInicio")
        Me.lblFechaInicio.Name = "lblFechaInicio"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'dtpDiasDisponiblesSeguimiento
        '
        resources.ApplyResources(Me.dtpDiasDisponiblesSeguimiento, "dtpDiasDisponiblesSeguimiento")
        Me.dtpDiasDisponiblesSeguimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDiasDisponiblesSeguimiento.Name = "dtpDiasDisponiblesSeguimiento"
        Me.dtpDiasDisponiblesSeguimiento.Value = New Date(2020, 8, 19, 0, 0, 0, 0)
        '
        'lblSeguimiento
        '
        resources.ApplyResources(Me.lblSeguimiento, "lblSeguimiento")
        Me.lblSeguimiento.Name = "lblSeguimiento"
        '
        'lblNombreTratamientoTXT
        '
        resources.ApplyResources(Me.lblNombreTratamientoTXT, "lblNombreTratamientoTXT")
        Me.lblNombreTratamientoTXT.Name = "lblNombreTratamientoTXT"
        '
        'lblIndicaciones
        '
        resources.ApplyResources(Me.lblIndicaciones, "lblIndicaciones")
        Me.lblIndicaciones.Name = "lblIndicaciones"
        '
        'txtDescripcionTratamiento
        '
        resources.ApplyResources(Me.txtDescripcionTratamiento, "txtDescripcionTratamiento")
        Me.txtDescripcionTratamiento.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtDescripcionTratamiento.Name = "txtDescripcionTratamiento"
        Me.txtDescripcionTratamiento.ReadOnly = True
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Controls.Add(Me.pnlContenedor)
        Me.Panel1.Name = "Panel1"
        '
        'frmTratamientoSeguir
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTratamientoSeguir"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.tblSeguimiento.ResumeLayout(False)
        Me.tblSeguimiento.PerformLayout()
        Me.tblResultado.ResumeLayout(False)
        Me.tblResultado.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents lblIndicaciones As Label
    Friend WithEvents txtDescripcionTratamiento As TextBox
    Friend WithEvents lblNombreTratamientoTXT As Label
    Friend WithEvents lblSeguimiento As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDiasDisponiblesSeguimiento As DateTimePicker
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents tblSeguimiento As TableLayoutPanel
    Friend WithEvents txtSeguimiento As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbDiasSemana As ListBox
    Friend WithEvents txtFechaFinalizacion As TextBox
    Friend WithEvents txtFechaInicio As TextBox
    Friend WithEvents tblResultado As TableLayoutPanel
    Friend WithEvents btnResultado As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Panel1 As Panel
End Class
