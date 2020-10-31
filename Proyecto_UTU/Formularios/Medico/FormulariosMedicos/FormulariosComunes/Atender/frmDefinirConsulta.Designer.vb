<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDefinirConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDefinirConsulta))
        Me.tblDatosMedico = New System.Windows.Forms.TableLayoutPanel()
        Me.pBoxFotoMedico = New System.Windows.Forms.PictureBox()
        Me.tabDatos = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblNombresTXT = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblApellidosTXT = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEspecialidadTXT = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuscarMedico = New System.Windows.Forms.Button()
        Me.txtCIMedico = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.tblNomRef = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNomReferencia = New System.Windows.Forms.Label()
        Me.txtNomConsulta = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblHoraConsulta = New System.Windows.Forms.Label()
        Me.dtpHoraConsulta = New System.Windows.Forms.DateTimePicker()
        Me.tblDatosMedico.SuspendLayout()
        CType(Me.pBoxFotoMedico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDatos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tblNomRef.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblDatosMedico
        '
        resources.ApplyResources(Me.tblDatosMedico, "tblDatosMedico")
        Me.tblDatosMedico.BackColor = System.Drawing.Color.LightBlue
        Me.tblDatosMedico.Controls.Add(Me.pBoxFotoMedico, 0, 0)
        Me.tblDatosMedico.Controls.Add(Me.tabDatos, 1, 0)
        Me.tblDatosMedico.Name = "tblDatosMedico"
        '
        'pBoxFotoMedico
        '
        resources.ApplyResources(Me.pBoxFotoMedico, "pBoxFotoMedico")
        Me.pBoxFotoMedico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBoxFotoMedico.Name = "pBoxFotoMedico"
        Me.pBoxFotoMedico.TabStop = False
        '
        'tabDatos
        '
        resources.ApplyResources(Me.tabDatos, "tabDatos")
        Me.tabDatos.Controls.Add(Me.lblNombres, 0, 1)
        Me.tabDatos.Controls.Add(Me.lblNombresTXT, 1, 1)
        Me.tabDatos.Controls.Add(Me.lblApellido, 0, 2)
        Me.tabDatos.Controls.Add(Me.lblApellidosTXT, 1, 2)
        Me.tabDatos.Controls.Add(Me.Label1, 0, 3)
        Me.tabDatos.Controls.Add(Me.lblEspecialidadTXT, 1, 3)
        Me.tabDatos.Controls.Add(Me.Panel1, 1, 0)
        Me.tabDatos.Controls.Add(Me.lblCedula, 0, 0)
        Me.tabDatos.Name = "tabDatos"
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
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'lblEspecialidadTXT
        '
        resources.ApplyResources(Me.lblEspecialidadTXT, "lblEspecialidadTXT")
        Me.lblEspecialidadTXT.Name = "lblEspecialidadTXT"
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Controls.Add(Me.btnBuscarMedico)
        Me.Panel1.Controls.Add(Me.txtCIMedico)
        Me.Panel1.Name = "Panel1"
        '
        'btnBuscarMedico
        '
        resources.ApplyResources(Me.btnBuscarMedico, "btnBuscarMedico")
        Me.btnBuscarMedico.Name = "btnBuscarMedico"
        Me.btnBuscarMedico.UseVisualStyleBackColor = True
        '
        'txtCIMedico
        '
        resources.ApplyResources(Me.txtCIMedico, "txtCIMedico")
        Me.txtCIMedico.Name = "txtCIMedico"
        '
        'lblCedula
        '
        resources.ApplyResources(Me.lblCedula, "lblCedula")
        Me.lblCedula.Name = "lblCedula"
        '
        'btnConfirmar
        '
        resources.ApplyResources(Me.btnConfirmar, "btnConfirmar")
        Me.btnConfirmar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'tblNomRef
        '
        resources.ApplyResources(Me.tblNomRef, "tblNomRef")
        Me.tblNomRef.Controls.Add(Me.lblNomReferencia, 0, 0)
        Me.tblNomRef.Controls.Add(Me.txtNomConsulta, 1, 0)
        Me.tblNomRef.Name = "tblNomRef"
        '
        'lblNomReferencia
        '
        resources.ApplyResources(Me.lblNomReferencia, "lblNomReferencia")
        Me.lblNomReferencia.Name = "lblNomReferencia"
        '
        'txtNomConsulta
        '
        resources.ApplyResources(Me.txtNomConsulta, "txtNomConsulta")
        Me.txtNomConsulta.Name = "txtNomConsulta"
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.lblHoraConsulta, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpHoraConsulta, 1, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'lblHoraConsulta
        '
        resources.ApplyResources(Me.lblHoraConsulta, "lblHoraConsulta")
        Me.lblHoraConsulta.Name = "lblHoraConsulta"
        '
        'dtpHoraConsulta
        '
        resources.ApplyResources(Me.dtpHoraConsulta, "dtpHoraConsulta")
        Me.dtpHoraConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraConsulta.Name = "dtpHoraConsulta"
        Me.dtpHoraConsulta.ShowUpDown = True
        '
        'frmDefinirConsulta
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.tblNomRef)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.tblDatosMedico)
        Me.Name = "frmDefinirConsulta"
        Me.tblDatosMedico.ResumeLayout(False)
        CType(Me.pBoxFotoMedico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDatos.ResumeLayout(False)
        Me.tabDatos.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tblNomRef.ResumeLayout(False)
        Me.tblNomRef.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tblDatosMedico As TableLayoutPanel
    Friend WithEvents pBoxFotoMedico As PictureBox
    Friend WithEvents tabDatos As TableLayoutPanel
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblNombresTXT As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblApellidosTXT As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEspecialidadTXT As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBuscarMedico As Button
    Friend WithEvents txtCIMedico As TextBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents tblNomRef As TableLayoutPanel
    Friend WithEvents lblNomReferencia As Label
    Friend WithEvents txtNomConsulta As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblHoraConsulta As Label
    Friend WithEvents dtpHoraConsulta As DateTimePicker
End Class
