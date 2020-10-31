<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Identificacion_Paciente
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Identificacion_Paciente))
        Me.tblDatosPaciente = New System.Windows.Forms.TableLayoutPanel()
        Me.tabDatos = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblNombresTXT = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblApellidosTXT = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblDireccionTXT = New System.Windows.Forms.Label()
        Me.lblTelefonos = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.lblFechaNacTXT = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblSexoTXT = New System.Windows.Forms.Label()
        Me.lblOcupacion = New System.Windows.Forms.Label()
        Me.lblOcupacionTXT = New System.Windows.Forms.Label()
        Me.lblE_Civil = New System.Windows.Forms.Label()
        Me.lblE_CivilTXT = New System.Windows.Forms.Label()
        Me.lblEtapa = New System.Windows.Forms.Label()
        Me.tblCedulaBuscar = New System.Windows.Forms.TableLayoutPanel()
        Me.txtCedulaPaciente = New System.Windows.Forms.TextBox()
        Me.pnlEstado = New System.Windows.Forms.Panel()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.lblTelefonoTXT = New System.Windows.Forms.Label()
        Me.tblAcciones = New System.Windows.Forms.TableLayoutPanel()
        Me.imgsBtnEntrevistar = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlConsultasPrevias = New System.Windows.Forms.Panel()
        Me.btnReferenciaConsulta = New System.Windows.Forms.Button()
        Me.cbConsultasPrevias = New System.Windows.Forms.ComboBox()
        Me.lblConsultasPrevias = New System.Windows.Forms.Label()
        Me.txtMotivoC = New System.Windows.Forms.TextBox()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.btnAgregarLista = New System.Windows.Forms.Button()
        Me.btnAtenderAhora = New System.Windows.Forms.Button()
        Me.btnVerConsulta = New System.Windows.Forms.Button()
        Me.pBoxFotoPaciente = New System.Windows.Forms.PictureBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnActualizarEstado = New System.Windows.Forms.Button()
        Me.tblDatosPaciente.SuspendLayout()
        Me.tabDatos.SuspendLayout()
        Me.tblCedulaBuscar.SuspendLayout()
        Me.pnlEstado.SuspendLayout()
        Me.tblAcciones.SuspendLayout()
        Me.pnlConsultasPrevias.SuspendLayout()
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblDatosPaciente
        '
        resources.ApplyResources(Me.tblDatosPaciente, "tblDatosPaciente")
        Me.tblDatosPaciente.Controls.Add(Me.pBoxFotoPaciente, 0, 0)
        Me.tblDatosPaciente.Controls.Add(Me.tabDatos, 1, 0)
        Me.tblDatosPaciente.Name = "tblDatosPaciente"
        '
        'tabDatos
        '
        resources.ApplyResources(Me.tabDatos, "tabDatos")
        Me.tabDatos.Controls.Add(Me.lblCedula, 0, 0)
        Me.tabDatos.Controls.Add(Me.lblNombres, 0, 1)
        Me.tabDatos.Controls.Add(Me.lblNombresTXT, 1, 1)
        Me.tabDatos.Controls.Add(Me.lblApellido, 0, 2)
        Me.tabDatos.Controls.Add(Me.lblApellidosTXT, 1, 2)
        Me.tabDatos.Controls.Add(Me.lblDireccion, 0, 3)
        Me.tabDatos.Controls.Add(Me.lblDireccionTXT, 1, 3)
        Me.tabDatos.Controls.Add(Me.lblTelefonos, 0, 5)
        Me.tabDatos.Controls.Add(Me.lblFechaNac, 0, 4)
        Me.tabDatos.Controls.Add(Me.lblFechaNacTXT, 1, 4)
        Me.tabDatos.Controls.Add(Me.lblSexo, 0, 6)
        Me.tabDatos.Controls.Add(Me.lblSexoTXT, 1, 6)
        Me.tabDatos.Controls.Add(Me.lblOcupacionTXT, 1, 7)
        Me.tabDatos.Controls.Add(Me.lblE_Civil, 0, 8)
        Me.tabDatos.Controls.Add(Me.lblE_CivilTXT, 1, 8)
        Me.tabDatos.Controls.Add(Me.lblEtapa, 0, 9)
        Me.tabDatos.Controls.Add(Me.tblCedulaBuscar, 1, 0)
        Me.tabDatos.Controls.Add(Me.pnlEstado, 1, 9)
        Me.tabDatos.Controls.Add(Me.lblTelefonoTXT, 1, 5)
        Me.tabDatos.Controls.Add(Me.lblOcupacion, 0, 7)
        Me.tabDatos.Name = "tabDatos"
        '
        'lblCedula
        '
        resources.ApplyResources(Me.lblCedula, "lblCedula")
        Me.lblCedula.Name = "lblCedula"
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
        Me.lblNombresTXT.Tag = "datos"
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
        Me.lblApellidosTXT.Tag = "datos"
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
        Me.lblDireccionTXT.Tag = "datos"
        '
        'lblTelefonos
        '
        resources.ApplyResources(Me.lblTelefonos, "lblTelefonos")
        Me.lblTelefonos.Name = "lblTelefonos"
        Me.lblTelefonos.Tag = ""
        '
        'lblFechaNac
        '
        resources.ApplyResources(Me.lblFechaNac, "lblFechaNac")
        Me.lblFechaNac.Name = "lblFechaNac"
        '
        'lblFechaNacTXT
        '
        resources.ApplyResources(Me.lblFechaNacTXT, "lblFechaNacTXT")
        Me.lblFechaNacTXT.Name = "lblFechaNacTXT"
        Me.lblFechaNacTXT.Tag = "datos"
        '
        'lblSexo
        '
        resources.ApplyResources(Me.lblSexo, "lblSexo")
        Me.lblSexo.Name = "lblSexo"
        '
        'lblSexoTXT
        '
        resources.ApplyResources(Me.lblSexoTXT, "lblSexoTXT")
        Me.lblSexoTXT.Name = "lblSexoTXT"
        Me.lblSexoTXT.Tag = "datos"
        '
        'lblOcupacion
        '
        resources.ApplyResources(Me.lblOcupacion, "lblOcupacion")
        Me.lblOcupacion.Name = "lblOcupacion"
        '
        'lblOcupacionTXT
        '
        resources.ApplyResources(Me.lblOcupacionTXT, "lblOcupacionTXT")
        Me.lblOcupacionTXT.Name = "lblOcupacionTXT"
        Me.lblOcupacionTXT.Tag = "datos"
        '
        'lblE_Civil
        '
        resources.ApplyResources(Me.lblE_Civil, "lblE_Civil")
        Me.lblE_Civil.Name = "lblE_Civil"
        '
        'lblE_CivilTXT
        '
        resources.ApplyResources(Me.lblE_CivilTXT, "lblE_CivilTXT")
        Me.lblE_CivilTXT.Name = "lblE_CivilTXT"
        Me.lblE_CivilTXT.Tag = "datos"
        '
        'lblEtapa
        '
        resources.ApplyResources(Me.lblEtapa, "lblEtapa")
        Me.lblEtapa.Name = "lblEtapa"
        '
        'tblCedulaBuscar
        '
        resources.ApplyResources(Me.tblCedulaBuscar, "tblCedulaBuscar")
        Me.tblCedulaBuscar.Controls.Add(Me.btnBuscar, 1, 0)
        Me.tblCedulaBuscar.Controls.Add(Me.txtCedulaPaciente, 0, 0)
        Me.tblCedulaBuscar.Name = "tblCedulaBuscar"
        '
        'txtCedulaPaciente
        '
        resources.ApplyResources(Me.txtCedulaPaciente, "txtCedulaPaciente")
        Me.txtCedulaPaciente.Name = "txtCedulaPaciente"
        Me.txtCedulaPaciente.Tag = "noLimpiar"
        '
        'pnlEstado
        '
        resources.ApplyResources(Me.pnlEstado, "pnlEstado")
        Me.pnlEstado.Controls.Add(Me.btnActualizarEstado)
        Me.pnlEstado.Controls.Add(Me.txtEstado)
        Me.pnlEstado.Name = "pnlEstado"
        '
        'txtEstado
        '
        resources.ApplyResources(Me.txtEstado, "txtEstado")
        Me.txtEstado.Name = "txtEstado"
        '
        'lblTelefonoTXT
        '
        resources.ApplyResources(Me.lblTelefonoTXT, "lblTelefonoTXT")
        Me.lblTelefonoTXT.Name = "lblTelefonoTXT"
        Me.lblTelefonoTXT.Tag = "datos"
        '
        'tblAcciones
        '
        resources.ApplyResources(Me.tblAcciones, "tblAcciones")
        Me.tblAcciones.Controls.Add(Me.btnAgregarLista, 0, 4)
        Me.tblAcciones.Controls.Add(Me.btnAtenderAhora, 0, 3)
        Me.tblAcciones.Controls.Add(Me.pnlConsultasPrevias, 0, 2)
        Me.tblAcciones.Controls.Add(Me.txtMotivoC, 0, 1)
        Me.tblAcciones.Controls.Add(Me.lblMotivo, 0, 0)
        Me.tblAcciones.Name = "tblAcciones"
        '
        'imgsBtnEntrevistar
        '
        Me.imgsBtnEntrevistar.ImageStream = CType(resources.GetObject("imgsBtnEntrevistar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgsBtnEntrevistar.TransparentColor = System.Drawing.Color.Transparent
        Me.imgsBtnEntrevistar.Images.SetKeyName(0, "icons8-health-checkup-80.png")
        Me.imgsBtnEntrevistar.Images.SetKeyName(1, "subir.png")
        Me.imgsBtnEntrevistar.Images.SetKeyName(2, "MedicoAtiendePaciente.png")
        '
        'pnlConsultasPrevias
        '
        resources.ApplyResources(Me.pnlConsultasPrevias, "pnlConsultasPrevias")
        Me.pnlConsultasPrevias.Controls.Add(Me.btnReferenciaConsulta)
        Me.pnlConsultasPrevias.Controls.Add(Me.btnVerConsulta)
        Me.pnlConsultasPrevias.Controls.Add(Me.cbConsultasPrevias)
        Me.pnlConsultasPrevias.Controls.Add(Me.lblConsultasPrevias)
        Me.pnlConsultasPrevias.Name = "pnlConsultasPrevias"
        '
        'btnReferenciaConsulta
        '
        resources.ApplyResources(Me.btnReferenciaConsulta, "btnReferenciaConsulta")
        Me.btnReferenciaConsulta.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnReferenciaConsulta.Name = "btnReferenciaConsulta"
        Me.btnReferenciaConsulta.UseVisualStyleBackColor = False
        '
        'cbConsultasPrevias
        '
        resources.ApplyResources(Me.cbConsultasPrevias, "cbConsultasPrevias")
        Me.cbConsultasPrevias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConsultasPrevias.FormattingEnabled = True
        Me.cbConsultasPrevias.Name = "cbConsultasPrevias"
        '
        'lblConsultasPrevias
        '
        resources.ApplyResources(Me.lblConsultasPrevias, "lblConsultasPrevias")
        Me.lblConsultasPrevias.Name = "lblConsultasPrevias"
        '
        'txtMotivoC
        '
        resources.ApplyResources(Me.txtMotivoC, "txtMotivoC")
        Me.txtMotivoC.Name = "txtMotivoC"
        '
        'lblMotivo
        '
        resources.ApplyResources(Me.lblMotivo, "lblMotivo")
        Me.lblMotivo.Name = "lblMotivo"
        '
        'btnAgregarLista
        '
        resources.ApplyResources(Me.btnAgregarLista, "btnAgregarLista")
        Me.btnAgregarLista.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnAgregarLista.ImageList = Me.imgsBtnEntrevistar
        Me.btnAgregarLista.Name = "btnAgregarLista"
        Me.btnAgregarLista.UseVisualStyleBackColor = False
        '
        'btnAtenderAhora
        '
        resources.ApplyResources(Me.btnAtenderAhora, "btnAtenderAhora")
        Me.btnAtenderAhora.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnAtenderAhora.ImageList = Me.imgsBtnEntrevistar
        Me.btnAtenderAhora.Name = "btnAtenderAhora"
        Me.btnAtenderAhora.UseVisualStyleBackColor = False
        '
        'btnVerConsulta
        '
        resources.ApplyResources(Me.btnVerConsulta, "btnVerConsulta")
        Me.btnVerConsulta.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnVerConsulta.Name = "btnVerConsulta"
        Me.btnVerConsulta.UseVisualStyleBackColor = False
        '
        'pBoxFotoPaciente
        '
        resources.ApplyResources(Me.pBoxFotoPaciente, "pBoxFotoPaciente")
        Me.pBoxFotoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBoxFotoPaciente.Name = "pBoxFotoPaciente"
        Me.pBoxFotoPaciente.TabStop = False
        '
        'btnBuscar
        '
        resources.ApplyResources(Me.btnBuscar, "btnBuscar")
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnActualizarEstado
        '
        resources.ApplyResources(Me.btnActualizarEstado, "btnActualizarEstado")
        Me.btnActualizarEstado.Name = "btnActualizarEstado"
        Me.btnActualizarEstado.UseVisualStyleBackColor = True
        '
        'Identificacion_Paciente
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.tblAcciones)
        Me.Controls.Add(Me.tblDatosPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Identificacion_Paciente"
        Me.tblDatosPaciente.ResumeLayout(False)
        Me.tabDatos.ResumeLayout(False)
        Me.tabDatos.PerformLayout()
        Me.tblCedulaBuscar.ResumeLayout(False)
        Me.tblCedulaBuscar.PerformLayout()
        Me.pnlEstado.ResumeLayout(False)
        Me.pnlEstado.PerformLayout()
        Me.tblAcciones.ResumeLayout(False)
        Me.tblAcciones.PerformLayout()
        Me.pnlConsultasPrevias.ResumeLayout(False)
        Me.pnlConsultasPrevias.PerformLayout()
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tblDatosPaciente As TableLayoutPanel
    Friend WithEvents pBoxFotoPaciente As PictureBox
    Friend WithEvents tabDatos As TableLayoutPanel
    Friend WithEvents lblTelefonoTXT As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblNombresTXT As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblApellidosTXT As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblDireccionTXT As Label
    Friend WithEvents lblTelefonos As Label
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents lblFechaNacTXT As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblSexoTXT As Label
    Friend WithEvents lblOcupacion As Label
    Friend WithEvents lblOcupacionTXT As Label
    Friend WithEvents lblE_Civil As Label
    Friend WithEvents lblE_CivilTXT As Label
    Friend WithEvents lblEtapa As Label
    Friend WithEvents txtCedulaPaciente As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents tblAcciones As TableLayoutPanel
    Friend WithEvents imgsBtnEntrevistar As ImageList
    Friend WithEvents pnlConsultasPrevias As Panel
    Friend WithEvents lblConsultasPrevias As Label
    Friend WithEvents btnVerConsulta As Button
    Friend WithEvents cbConsultasPrevias As ComboBox
    Friend WithEvents btnReferenciaConsulta As Button
    Friend WithEvents txtMotivoC As TextBox
    Friend WithEvents btnAtenderAhora As Button
    Friend WithEvents btnAgregarLista As Button
    Friend WithEvents tblCedulaBuscar As TableLayoutPanel
    Friend WithEvents lblMotivo As Label
    Friend WithEvents pnlEstado As Panel
    Friend WithEvents btnActualizarEstado As Button
    Friend WithEvents txtEstado As TextBox
End Class
