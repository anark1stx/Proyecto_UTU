<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametrosTemporalesT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParametrosTemporalesT))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbDiasSelect = New System.Windows.Forms.ListBox()
        Me.lblDiasSelect = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSacarDia = New System.Windows.Forms.Button()
        Me.btnAgregarDia = New System.Windows.Forms.Button()
        Me.cbDiasSemana = New System.Windows.Forms.ComboBox()
        Me.lblDiasSemana = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaIni = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lbDiasSelect)
        Me.Panel4.Controls.Add(Me.lblDiasSelect)
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Name = "Panel4"
        '
        'lbDiasSelect
        '
        resources.ApplyResources(Me.lbDiasSelect, "lbDiasSelect")
        Me.lbDiasSelect.FormattingEnabled = True
        Me.lbDiasSelect.Name = "lbDiasSelect"
        '
        'lblDiasSelect
        '
        resources.ApplyResources(Me.lblDiasSelect, "lblDiasSelect")
        Me.lblDiasSelect.Name = "lblDiasSelect"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnSacarDia)
        Me.Panel3.Controls.Add(Me.btnAgregarDia)
        Me.Panel3.Controls.Add(Me.cbDiasSemana)
        Me.Panel3.Controls.Add(Me.lblDiasSemana)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'btnSacarDia
        '
        resources.ApplyResources(Me.btnSacarDia, "btnSacarDia")
        Me.btnSacarDia.Name = "btnSacarDia"
        Me.btnSacarDia.UseVisualStyleBackColor = True
        '
        'btnAgregarDia
        '
        resources.ApplyResources(Me.btnAgregarDia, "btnAgregarDia")
        Me.btnAgregarDia.Name = "btnAgregarDia"
        Me.btnAgregarDia.UseVisualStyleBackColor = True
        '
        'cbDiasSemana
        '
        resources.ApplyResources(Me.cbDiasSemana, "cbDiasSemana")
        Me.cbDiasSemana.FormattingEnabled = True
        Me.cbDiasSemana.Name = "cbDiasSemana"
        '
        'lblDiasSemana
        '
        resources.ApplyResources(Me.lblDiasSemana, "lblDiasSemana")
        Me.lblDiasSemana.Name = "lblDiasSemana"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtpFechaFin)
        Me.Panel2.Controls.Add(Me.lblFechaFin)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'dtpFechaFin
        '
        resources.ApplyResources(Me.dtpFechaFin, "dtpFechaFin")
        Me.dtpFechaFin.Name = "dtpFechaFin"
        '
        'lblFechaFin
        '
        resources.ApplyResources(Me.lblFechaFin, "lblFechaFin")
        Me.lblFechaFin.Name = "lblFechaFin"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtpFechaInicio)
        Me.Panel1.Controls.Add(Me.lblFechaIni)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'dtpFechaInicio
        '
        resources.ApplyResources(Me.dtpFechaInicio, "dtpFechaInicio")
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        '
        'lblFechaIni
        '
        resources.ApplyResources(Me.lblFechaIni, "lblFechaIni")
        Me.lblFechaIni.Name = "lblFechaIni"
        '
        'btnConfirmar
        '
        resources.ApplyResources(Me.btnConfirmar, "btnConfirmar")
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'frmParametrosTemporalesT
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmParametrosTemporalesT"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblFechaIni As Label
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblDiasSemana As Label
    Friend WithEvents cbDiasSemana As ComboBox
    Friend WithEvents btnAgregarDia As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblDiasSelect As Label
    Friend WithEvents lbDiasSelect As ListBox
    Friend WithEvents btnSacarDia As Button
    Friend WithEvents btnConfirmar As Button
End Class
