<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiebre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFiebre))
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.tabs = New System.Windows.Forms.TabControl()
        Me.tabEntrevista = New System.Windows.Forms.TabPage()
        Me.gbResolucion = New System.Windows.Forms.GroupBox()
        Me.txtNomAnalisis = New System.Windows.Forms.TextBox()
        Me.gbDescripcionDiagnostico = New System.Windows.Forms.GroupBox()
        Me.lblDiagnostico = New System.Windows.Forms.Label()
        Me.txtTratamiento = New System.Windows.Forms.TextBox()
        Me.chkAnalisis = New System.Windows.Forms.CheckBox()
        Me.lblNomAnalisis = New System.Windows.Forms.Label()
        Me.gbPreguntas = New System.Windows.Forms.GroupBox()
        Me.chkSensoriales = New System.Windows.Forms.CheckBox()
        Me.chkHumorales = New System.Windows.Forms.CheckBox()
        Me.chkDigestivos = New System.Windows.Forms.CheckBox()
        Me.chkVacunas = New System.Windows.Forms.CheckBox()
        Me.chkErupciones = New System.Windows.Forms.CheckBox()
        Me.chkCalor = New System.Windows.Forms.CheckBox()
        Me.chkMeds = New System.Windows.Forms.CheckBox()
        Me.chkDificultadesRespirar = New System.Windows.Forms.CheckBox()
        Me.chkApendiceDolor = New System.Windows.Forms.CheckBox()
        Me.tblActitud = New System.Windows.Forms.TableLayoutPanel()
        Me.lblActitud = New System.Windows.Forms.Label()
        Me.cbActitud = New System.Windows.Forms.ComboBox()
        Me.tblNutricion = New System.Windows.Forms.TableLayoutPanel()
        Me.lblENutricion = New System.Windows.Forms.Label()
        Me.cbENutricion = New System.Windows.Forms.ComboBox()
        Me.tblPulso = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPulso = New System.Windows.Forms.Label()
        Me.cbPulso = New System.Windows.Forms.ComboBox()
        Me.tblGradoHidratacion = New System.Windows.Forms.TableLayoutPanel()
        Me.lblGradoHidratacion = New System.Windows.Forms.Label()
        Me.cbGradoHidr = New System.Windows.Forms.ComboBox()
        Me.tblTemperatura = New System.Windows.Forms.TableLayoutPanel()
        Me.lblGrados = New System.Windows.Forms.Label()
        Me.lblTemperatura = New System.Windows.Forms.Label()
        Me.txtTemperatura = New System.Windows.Forms.TextBox()
        Me.tabSintomasYSignos = New System.Windows.Forms.TabPage()
        Me.btnAgregarSintoma = New System.Windows.Forms.Button()
        Me.lblIngreseSintoma = New System.Windows.Forms.Label()
        Me.txtSintoma = New System.Windows.Forms.TextBox()
        Me.lbSintomas = New System.Windows.Forms.ListBox()
        Me.btnAgregarSClinico = New System.Windows.Forms.Button()
        Me.lblIngreseSignoClinico = New System.Windows.Forms.Label()
        Me.txtSgClinico = New System.Windows.Forms.TextBox()
        Me.lbSignosClinicos = New System.Windows.Forms.ListBox()
        Me.Imprimir = New System.Drawing.Printing.PrintDocument()
        Me.pp = New System.Windows.Forms.PrintPreviewDialog()
        Me.pnlContenedor.SuspendLayout()
        Me.tabs.SuspendLayout()
        Me.tabEntrevista.SuspendLayout()
        Me.gbResolucion.SuspendLayout()
        Me.gbDescripcionDiagnostico.SuspendLayout()
        Me.gbPreguntas.SuspendLayout()
        Me.tblActitud.SuspendLayout()
        Me.tblNutricion.SuspendLayout()
        Me.tblPulso.SuspendLayout()
        Me.tblGradoHidratacion.SuspendLayout()
        Me.tblTemperatura.SuspendLayout()
        Me.tabSintomasYSignos.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.AutoScroll = True
        Me.pnlContenedor.Controls.Add(Me.tabs)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1334, 815)
        Me.pnlContenedor.TabIndex = 0
        '
        'tabs
        '
        Me.tabs.Controls.Add(Me.tabEntrevista)
        Me.tabs.Controls.Add(Me.tabSintomasYSignos)
        Me.tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabs.Location = New System.Drawing.Point(0, 0)
        Me.tabs.Name = "tabs"
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(1334, 815)
        Me.tabs.TabIndex = 0
        '
        'tabEntrevista
        '
        Me.tabEntrevista.AutoScroll = True
        Me.tabEntrevista.BackColor = System.Drawing.Color.LightBlue
        Me.tabEntrevista.Controls.Add(Me.gbResolucion)
        Me.tabEntrevista.Controls.Add(Me.gbPreguntas)
        Me.tabEntrevista.Location = New System.Drawing.Point(4, 25)
        Me.tabEntrevista.Margin = New System.Windows.Forms.Padding(0)
        Me.tabEntrevista.Name = "tabEntrevista"
        Me.tabEntrevista.Size = New System.Drawing.Size(1326, 786)
        Me.tabEntrevista.TabIndex = 0
        Me.tabEntrevista.Text = "Entrevista"
        '
        'gbResolucion
        '
        Me.gbResolucion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbResolucion.Controls.Add(Me.txtNomAnalisis)
        Me.gbResolucion.Controls.Add(Me.gbDescripcionDiagnostico)
        Me.gbResolucion.Controls.Add(Me.chkAnalisis)
        Me.gbResolucion.Controls.Add(Me.lblNomAnalisis)
        Me.gbResolucion.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbResolucion.Location = New System.Drawing.Point(58, 581)
        Me.gbResolucion.Name = "gbResolucion"
        Me.gbResolucion.Size = New System.Drawing.Size(1160, 381)
        Me.gbResolucion.TabIndex = 53
        Me.gbResolucion.TabStop = False
        Me.gbResolucion.Text = "Resolución"
        '
        'txtNomAnalisis
        '
        Me.txtNomAnalisis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNomAnalisis.Enabled = False
        Me.txtNomAnalisis.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomAnalisis.Location = New System.Drawing.Point(440, 58)
        Me.txtNomAnalisis.Name = "txtNomAnalisis"
        Me.txtNomAnalisis.Size = New System.Drawing.Size(714, 30)
        Me.txtNomAnalisis.TabIndex = 27
        Me.txtNomAnalisis.Tag = "r15"
        '
        'gbDescripcionDiagnostico
        '
        Me.gbDescripcionDiagnostico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDescripcionDiagnostico.Controls.Add(Me.lblDiagnostico)
        Me.gbDescripcionDiagnostico.Controls.Add(Me.txtTratamiento)
        Me.gbDescripcionDiagnostico.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDescripcionDiagnostico.Location = New System.Drawing.Point(9, 108)
        Me.gbDescripcionDiagnostico.Name = "gbDescripcionDiagnostico"
        Me.gbDescripcionDiagnostico.Size = New System.Drawing.Size(1154, 266)
        Me.gbDescripcionDiagnostico.TabIndex = 26
        Me.gbDescripcionDiagnostico.TabStop = False
        '
        'lblDiagnostico
        '
        Me.lblDiagnostico.AutoSize = True
        Me.lblDiagnostico.Location = New System.Drawing.Point(13, 0)
        Me.lblDiagnostico.Name = "lblDiagnostico"
        Me.lblDiagnostico.Size = New System.Drawing.Size(295, 28)
        Me.lblDiagnostico.TabIndex = 28
        Me.lblDiagnostico.Tag = "p17"
        Me.lblDiagnostico.Text = "Descripción y diagnóstico"
        '
        'txtTratamiento
        '
        Me.txtTratamiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTratamiento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTratamiento.Location = New System.Drawing.Point(9, 33)
        Me.txtTratamiento.Multiline = True
        Me.txtTratamiento.Name = "txtTratamiento"
        Me.txtTratamiento.Size = New System.Drawing.Size(1136, 227)
        Me.txtTratamiento.TabIndex = 2
        Me.txtTratamiento.Tag = "r17"
        '
        'chkAnalisis
        '
        Me.chkAnalisis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkAnalisis.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAnalisis.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnalisis.Location = New System.Drawing.Point(162, 22)
        Me.chkAnalisis.Name = "chkAnalisis"
        Me.chkAnalisis.Size = New System.Drawing.Size(497, 33)
        Me.chkAnalisis.TabIndex = 24
        Me.chkAnalisis.Tag = ""
        Me.chkAnalisis.Text = "¿El paciente debe solicitar un análisis?"
        Me.chkAnalisis.UseVisualStyleBackColor = True
        '
        'lblNomAnalisis
        '
        Me.lblNomAnalisis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNomAnalisis.AutoSize = True
        Me.lblNomAnalisis.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomAnalisis.Location = New System.Drawing.Point(167, 61)
        Me.lblNomAnalisis.Name = "lblNomAnalisis"
        Me.lblNomAnalisis.Size = New System.Drawing.Size(247, 29)
        Me.lblNomAnalisis.TabIndex = 22
        Me.lblNomAnalisis.Tag = "p15"
        Me.lblNomAnalisis.Text = "Nombre del análisis:"
        '
        'gbPreguntas
        '
        Me.gbPreguntas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbPreguntas.Controls.Add(Me.chkSensoriales)
        Me.gbPreguntas.Controls.Add(Me.chkHumorales)
        Me.gbPreguntas.Controls.Add(Me.chkDigestivos)
        Me.gbPreguntas.Controls.Add(Me.chkVacunas)
        Me.gbPreguntas.Controls.Add(Me.chkErupciones)
        Me.gbPreguntas.Controls.Add(Me.chkCalor)
        Me.gbPreguntas.Controls.Add(Me.chkMeds)
        Me.gbPreguntas.Controls.Add(Me.chkDificultadesRespirar)
        Me.gbPreguntas.Controls.Add(Me.chkApendiceDolor)
        Me.gbPreguntas.Controls.Add(Me.tblActitud)
        Me.gbPreguntas.Controls.Add(Me.tblNutricion)
        Me.gbPreguntas.Controls.Add(Me.tblPulso)
        Me.gbPreguntas.Controls.Add(Me.tblGradoHidratacion)
        Me.gbPreguntas.Controls.Add(Me.tblTemperatura)
        Me.gbPreguntas.Location = New System.Drawing.Point(58, 3)
        Me.gbPreguntas.Name = "gbPreguntas"
        Me.gbPreguntas.Size = New System.Drawing.Size(1160, 572)
        Me.gbPreguntas.TabIndex = 54
        Me.gbPreguntas.TabStop = False
        '
        'chkSensoriales
        '
        Me.chkSensoriales.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSensoriales.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold)
        Me.chkSensoriales.Location = New System.Drawing.Point(6, 531)
        Me.chkSensoriales.Name = "chkSensoriales"
        Me.chkSensoriales.Size = New System.Drawing.Size(653, 40)
        Me.chkSensoriales.TabIndex = 64
        Me.chkSensoriales.Tag = "pr9"
        Me.chkSensoriales.Text = "¿El paciente presenta trastornos sensoriales?"
        Me.chkSensoriales.UseVisualStyleBackColor = True
        '
        'chkHumorales
        '
        Me.chkHumorales.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkHumorales.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold)
        Me.chkHumorales.Location = New System.Drawing.Point(6, 485)
        Me.chkHumorales.Name = "chkHumorales"
        Me.chkHumorales.Size = New System.Drawing.Size(653, 40)
        Me.chkHumorales.TabIndex = 63
        Me.chkHumorales.Tag = "pr8"
        Me.chkHumorales.Text = "¿El paciente presenta trastornos humorales?"
        Me.chkHumorales.UseVisualStyleBackColor = True
        '
        'chkDigestivos
        '
        Me.chkDigestivos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDigestivos.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold)
        Me.chkDigestivos.Location = New System.Drawing.Point(6, 439)
        Me.chkDigestivos.Name = "chkDigestivos"
        Me.chkDigestivos.Size = New System.Drawing.Size(653, 40)
        Me.chkDigestivos.TabIndex = 62
        Me.chkDigestivos.Tag = "pr7"
        Me.chkDigestivos.Text = "¿El paciente presenta trastornos digestivos?"
        Me.chkDigestivos.UseVisualStyleBackColor = True
        '
        'chkVacunas
        '
        Me.chkVacunas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkVacunas.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold)
        Me.chkVacunas.Location = New System.Drawing.Point(6, 393)
        Me.chkVacunas.Name = "chkVacunas"
        Me.chkVacunas.Size = New System.Drawing.Size(653, 40)
        Me.chkVacunas.TabIndex = 61
        Me.chkVacunas.Tag = "pr6"
        Me.chkVacunas.Text = "¿El paciente fue vacunado recientemente?"
        Me.chkVacunas.UseVisualStyleBackColor = True
        '
        'chkErupciones
        '
        Me.chkErupciones.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkErupciones.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold)
        Me.chkErupciones.Location = New System.Drawing.Point(6, 347)
        Me.chkErupciones.Name = "chkErupciones"
        Me.chkErupciones.Size = New System.Drawing.Size(653, 40)
        Me.chkErupciones.TabIndex = 60
        Me.chkErupciones.Tag = "pr5"
        Me.chkErupciones.Text = "¿El paciente manifiesta erupciones cutáneas?"
        Me.chkErupciones.UseVisualStyleBackColor = True
        '
        'chkCalor
        '
        Me.chkCalor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCalor.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold)
        Me.chkCalor.Location = New System.Drawing.Point(6, 301)
        Me.chkCalor.Name = "chkCalor"
        Me.chkCalor.Size = New System.Drawing.Size(653, 40)
        Me.chkCalor.TabIndex = 59
        Me.chkCalor.Tag = "pr4"
        Me.chkCalor.Text = "¿El paciente se expone al calor? / ¿Estuvo expuesto?"
        Me.chkCalor.UseVisualStyleBackColor = True
        '
        'chkMeds
        '
        Me.chkMeds.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMeds.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold)
        Me.chkMeds.Location = New System.Drawing.Point(6, 255)
        Me.chkMeds.Name = "chkMeds"
        Me.chkMeds.Size = New System.Drawing.Size(653, 40)
        Me.chkMeds.TabIndex = 58
        Me.chkMeds.Tag = "pr3"
        Me.chkMeds.Text = "¿El paciente toma medicamentos?"
        Me.chkMeds.UseVisualStyleBackColor = True
        '
        'chkDificultadesRespirar
        '
        Me.chkDificultadesRespirar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDificultadesRespirar.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold)
        Me.chkDificultadesRespirar.Location = New System.Drawing.Point(6, 209)
        Me.chkDificultadesRespirar.Name = "chkDificultadesRespirar"
        Me.chkDificultadesRespirar.Size = New System.Drawing.Size(653, 40)
        Me.chkDificultadesRespirar.TabIndex = 57
        Me.chkDificultadesRespirar.Tag = "pr2"
        Me.chkDificultadesRespirar.Text = "¿El paciente presenta dificultades para respirar?"
        Me.chkDificultadesRespirar.UseVisualStyleBackColor = True
        '
        'chkApendiceDolor
        '
        Me.chkApendiceDolor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkApendiceDolor.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold)
        Me.chkApendiceDolor.Location = New System.Drawing.Point(6, 163)
        Me.chkApendiceDolor.Name = "chkApendiceDolor"
        Me.chkApendiceDolor.Size = New System.Drawing.Size(653, 40)
        Me.chkApendiceDolor.TabIndex = 28
        Me.chkApendiceDolor.Tag = "pr1"
        Me.chkApendiceDolor.Text = "¿El paciente presenta dolor en el apéndice al tocarlo?"
        Me.chkApendiceDolor.UseVisualStyleBackColor = True
        '
        'tblActitud
        '
        Me.tblActitud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblActitud.ColumnCount = 2
        Me.tblActitud.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234!))
        Me.tblActitud.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197.0!))
        Me.tblActitud.Controls.Add(Me.lblActitud, 0, 0)
        Me.tblActitud.Controls.Add(Me.cbActitud, 1, 0)
        Me.tblActitud.Location = New System.Drawing.Point(649, 51)
        Me.tblActitud.Name = "tblActitud"
        Me.tblActitud.RowCount = 1
        Me.tblActitud.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblActitud.Size = New System.Drawing.Size(499, 37)
        Me.tblActitud.TabIndex = 56
        '
        'lblActitud
        '
        Me.lblActitud.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblActitud.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActitud.Location = New System.Drawing.Point(3, 0)
        Me.lblActitud.Name = "lblActitud"
        Me.lblActitud.Size = New System.Drawing.Size(296, 37)
        Me.lblActitud.TabIndex = 41
        Me.lblActitud.Tag = "p4"
        Me.lblActitud.Text = "Actitud:"
        '
        'cbActitud
        '
        Me.cbActitud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbActitud.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbActitud.FormattingEnabled = True
        Me.cbActitud.Items.AddRange(New Object() {"Apatía", "Coma", "Excitación", "Desmotivación", "Desinterés", "Otro"})
        Me.cbActitud.Location = New System.Drawing.Point(305, 3)
        Me.cbActitud.Name = "cbActitud"
        Me.cbActitud.Size = New System.Drawing.Size(191, 31)
        Me.cbActitud.TabIndex = 41
        Me.cbActitud.Tag = "r4"
        '
        'tblNutricion
        '
        Me.tblNutricion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblNutricion.ColumnCount = 2
        Me.tblNutricion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234!))
        Me.tblNutricion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197.0!))
        Me.tblNutricion.Controls.Add(Me.lblENutricion, 0, 0)
        Me.tblNutricion.Controls.Add(Me.cbENutricion, 1, 0)
        Me.tblNutricion.Location = New System.Drawing.Point(649, 94)
        Me.tblNutricion.Name = "tblNutricion"
        Me.tblNutricion.RowCount = 1
        Me.tblNutricion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblNutricion.Size = New System.Drawing.Size(499, 37)
        Me.tblNutricion.TabIndex = 55
        '
        'lblENutricion
        '
        Me.lblENutricion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblENutricion.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblENutricion.Location = New System.Drawing.Point(3, 8)
        Me.lblENutricion.Name = "lblENutricion"
        Me.lblENutricion.Size = New System.Drawing.Size(296, 29)
        Me.lblENutricion.TabIndex = 2
        Me.lblENutricion.Tag = "p5"
        Me.lblENutricion.Text = "Estado de nutrición:"
        '
        'cbENutricion
        '
        Me.cbENutricion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbENutricion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbENutricion.FormattingEnabled = True
        Me.cbENutricion.Items.AddRange(New Object() {"Obesidad", "Anorexia", "Caquexia", "Peso normal"})
        Me.cbENutricion.Location = New System.Drawing.Point(305, 3)
        Me.cbENutricion.Name = "cbENutricion"
        Me.cbENutricion.Size = New System.Drawing.Size(191, 31)
        Me.cbENutricion.TabIndex = 38
        Me.cbENutricion.Tag = "r5"
        '
        'tblPulso
        '
        Me.tblPulso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblPulso.ColumnCount = 2
        Me.tblPulso.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234!))
        Me.tblPulso.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198.0!))
        Me.tblPulso.Controls.Add(Me.lblPulso, 0, 0)
        Me.tblPulso.Controls.Add(Me.cbPulso, 1, 0)
        Me.tblPulso.Location = New System.Drawing.Point(9, 48)
        Me.tblPulso.Name = "tblPulso"
        Me.tblPulso.RowCount = 1
        Me.tblPulso.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPulso.Size = New System.Drawing.Size(499, 37)
        Me.tblPulso.TabIndex = 51
        '
        'lblPulso
        '
        Me.lblPulso.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPulso.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPulso.Location = New System.Drawing.Point(3, 8)
        Me.lblPulso.Name = "lblPulso"
        Me.lblPulso.Size = New System.Drawing.Size(295, 29)
        Me.lblPulso.TabIndex = 24
        Me.lblPulso.Tag = "p2"
        Me.lblPulso.Text = "Pulso:"
        '
        'cbPulso
        '
        Me.cbPulso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbPulso.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPulso.FormattingEnabled = True
        Me.cbPulso.Items.AddRange(New Object() {"Fuerte", "Débil", "Filiforme"})
        Me.cbPulso.Location = New System.Drawing.Point(304, 3)
        Me.cbPulso.Name = "cbPulso"
        Me.cbPulso.Size = New System.Drawing.Size(192, 31)
        Me.cbPulso.TabIndex = 23
        Me.cbPulso.Tag = "r2"
        '
        'tblGradoHidratacion
        '
        Me.tblGradoHidratacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblGradoHidratacion.ColumnCount = 2
        Me.tblGradoHidratacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234!))
        Me.tblGradoHidratacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197.0!))
        Me.tblGradoHidratacion.Controls.Add(Me.lblGradoHidratacion, 0, 0)
        Me.tblGradoHidratacion.Controls.Add(Me.cbGradoHidr, 1, 0)
        Me.tblGradoHidratacion.Location = New System.Drawing.Point(9, 91)
        Me.tblGradoHidratacion.Name = "tblGradoHidratacion"
        Me.tblGradoHidratacion.RowCount = 1
        Me.tblGradoHidratacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblGradoHidratacion.Size = New System.Drawing.Size(499, 37)
        Me.tblGradoHidratacion.TabIndex = 49
        '
        'lblGradoHidratacion
        '
        Me.lblGradoHidratacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblGradoHidratacion.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradoHidratacion.Location = New System.Drawing.Point(3, 8)
        Me.lblGradoHidratacion.Name = "lblGradoHidratacion"
        Me.lblGradoHidratacion.Size = New System.Drawing.Size(296, 29)
        Me.lblGradoHidratacion.TabIndex = 2
        Me.lblGradoHidratacion.Tag = "p3"
        Me.lblGradoHidratacion.Text = "Grado de hidratación:"
        '
        'cbGradoHidr
        '
        Me.cbGradoHidr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbGradoHidr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGradoHidr.FormattingEnabled = True
        Me.cbGradoHidr.Items.AddRange(New Object() {"Hidratado", "Normohidratado", "Hiperhidratado", "Hipohidratado", "Deshidratado", "Rehidratado"})
        Me.cbGradoHidr.Location = New System.Drawing.Point(305, 3)
        Me.cbGradoHidr.Name = "cbGradoHidr"
        Me.cbGradoHidr.Size = New System.Drawing.Size(191, 31)
        Me.cbGradoHidr.TabIndex = 13
        Me.cbGradoHidr.Tag = "r3"
        '
        'tblTemperatura
        '
        Me.tblTemperatura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblTemperatura.ColumnCount = 3
        Me.tblTemperatura.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.27646!))
        Me.tblTemperatura.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.72354!))
        Me.tblTemperatura.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tblTemperatura.Controls.Add(Me.lblGrados, 2, 0)
        Me.tblTemperatura.Controls.Add(Me.lblTemperatura, 0, 0)
        Me.tblTemperatura.Controls.Add(Me.txtTemperatura, 1, 0)
        Me.tblTemperatura.Location = New System.Drawing.Point(9, 5)
        Me.tblTemperatura.Name = "tblTemperatura"
        Me.tblTemperatura.RowCount = 1
        Me.tblTemperatura.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTemperatura.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tblTemperatura.Size = New System.Drawing.Size(561, 37)
        Me.tblTemperatura.TabIndex = 43
        '
        'lblGrados
        '
        Me.lblGrados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGrados.AutoSize = True
        Me.lblGrados.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrados.Location = New System.Drawing.Point(519, 4)
        Me.lblGrados.Name = "lblGrados"
        Me.lblGrados.Size = New System.Drawing.Size(23, 29)
        Me.lblGrados.TabIndex = 4
        Me.lblGrados.Text = "°"
        '
        'lblTemperatura
        '
        Me.lblTemperatura.AutoSize = True
        Me.lblTemperatura.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTemperatura.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperatura.Location = New System.Drawing.Point(3, 0)
        Me.lblTemperatura.Name = "lblTemperatura"
        Me.lblTemperatura.Size = New System.Drawing.Size(162, 37)
        Me.lblTemperatura.TabIndex = 2
        Me.lblTemperatura.Tag = "p1"
        Me.lblTemperatura.Text = "Temperatura:"
        '
        'txtTemperatura
        '
        Me.txtTemperatura.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtTemperatura.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemperatura.Location = New System.Drawing.Point(452, 3)
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.Size = New System.Drawing.Size(45, 30)
        Me.txtTemperatura.TabIndex = 3
        Me.txtTemperatura.Tag = "r1"
        '
        'tabSintomasYSignos
        '
        Me.tabSintomasYSignos.BackColor = System.Drawing.Color.LightBlue
        Me.tabSintomasYSignos.Controls.Add(Me.btnAgregarSintoma)
        Me.tabSintomasYSignos.Controls.Add(Me.lblIngreseSintoma)
        Me.tabSintomasYSignos.Controls.Add(Me.txtSintoma)
        Me.tabSintomasYSignos.Controls.Add(Me.lbSintomas)
        Me.tabSintomasYSignos.Controls.Add(Me.btnAgregarSClinico)
        Me.tabSintomasYSignos.Controls.Add(Me.lblIngreseSignoClinico)
        Me.tabSintomasYSignos.Controls.Add(Me.txtSgClinico)
        Me.tabSintomasYSignos.Controls.Add(Me.lbSignosClinicos)
        Me.tabSintomasYSignos.Location = New System.Drawing.Point(4, 25)
        Me.tabSintomasYSignos.Name = "tabSintomasYSignos"
        Me.tabSintomasYSignos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSintomasYSignos.Size = New System.Drawing.Size(1326, 786)
        Me.tabSintomasYSignos.TabIndex = 1
        Me.tabSintomasYSignos.Text = "Síntomas y Signos Clínicos"
        '
        'btnAgregarSintoma
        '
        Me.btnAgregarSintoma.BackgroundImage = CType(resources.GetObject("btnAgregarSintoma.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarSintoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarSintoma.Location = New System.Drawing.Point(1271, 66)
        Me.btnAgregarSintoma.Name = "btnAgregarSintoma"
        Me.btnAgregarSintoma.Size = New System.Drawing.Size(40, 30)
        Me.btnAgregarSintoma.TabIndex = 7
        Me.btnAgregarSintoma.UseVisualStyleBackColor = True
        '
        'lblIngreseSintoma
        '
        Me.lblIngreseSintoma.AutoSize = True
        Me.lblIngreseSintoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseSintoma.Location = New System.Drawing.Point(713, 67)
        Me.lblIngreseSintoma.Name = "lblIngreseSintoma"
        Me.lblIngreseSintoma.Size = New System.Drawing.Size(190, 29)
        Me.lblIngreseSintoma.TabIndex = 6
        Me.lblIngreseSintoma.Text = "Ingrese sintoma:"
        '
        'txtSintoma
        '
        Me.txtSintoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSintoma.Location = New System.Drawing.Point(909, 66)
        Me.txtSintoma.Name = "txtSintoma"
        Me.txtSintoma.Size = New System.Drawing.Size(356, 30)
        Me.txtSintoma.TabIndex = 5
        '
        'lbSintomas
        '
        Me.lbSintomas.FormattingEnabled = True
        Me.lbSintomas.ItemHeight = 16
        Me.lbSintomas.Location = New System.Drawing.Point(718, 118)
        Me.lbSintomas.Name = "lbSintomas"
        Me.lbSintomas.Size = New System.Drawing.Size(593, 660)
        Me.lbSintomas.TabIndex = 4
        '
        'btnAgregarSClinico
        '
        Me.btnAgregarSClinico.BackgroundImage = CType(resources.GetObject("btnAgregarSClinico.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarSClinico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarSClinico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarSClinico.Location = New System.Drawing.Point(564, 66)
        Me.btnAgregarSClinico.Name = "btnAgregarSClinico"
        Me.btnAgregarSClinico.Size = New System.Drawing.Size(40, 30)
        Me.btnAgregarSClinico.TabIndex = 3
        Me.btnAgregarSClinico.UseVisualStyleBackColor = True
        '
        'lblIngreseSignoClinico
        '
        Me.lblIngreseSignoClinico.AutoSize = True
        Me.lblIngreseSignoClinico.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseSignoClinico.Location = New System.Drawing.Point(6, 67)
        Me.lblIngreseSignoClinico.Name = "lblIngreseSignoClinico"
        Me.lblIngreseSignoClinico.Size = New System.Drawing.Size(240, 29)
        Me.lblIngreseSignoClinico.TabIndex = 2
        Me.lblIngreseSignoClinico.Text = "Ingrese signo clínico:"
        '
        'txtSgClinico
        '
        Me.txtSgClinico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSgClinico.Location = New System.Drawing.Point(252, 66)
        Me.txtSgClinico.Name = "txtSgClinico"
        Me.txtSgClinico.Size = New System.Drawing.Size(306, 30)
        Me.txtSgClinico.TabIndex = 1
        '
        'lbSignosClinicos
        '
        Me.lbSignosClinicos.FormattingEnabled = True
        Me.lbSignosClinicos.ItemHeight = 16
        Me.lbSignosClinicos.Location = New System.Drawing.Point(11, 118)
        Me.lbSignosClinicos.Name = "lbSignosClinicos"
        Me.lbSignosClinicos.Size = New System.Drawing.Size(593, 660)
        Me.lbSignosClinicos.TabIndex = 0
        '
        'pp
        '
        Me.pp.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.pp.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.pp.ClientSize = New System.Drawing.Size(400, 300)
        Me.pp.Enabled = True
        Me.pp.Icon = CType(resources.GetObject("pp.Icon"), System.Drawing.Icon)
        Me.pp.Name = "pp"
        Me.pp.Visible = False
        '
        'frmFiebre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1334, 815)
        Me.Controls.Add(Me.pnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFiebre"
        Me.Text = "frm"
        Me.pnlContenedor.ResumeLayout(False)
        Me.tabs.ResumeLayout(False)
        Me.tabEntrevista.ResumeLayout(False)
        Me.gbResolucion.ResumeLayout(False)
        Me.gbResolucion.PerformLayout()
        Me.gbDescripcionDiagnostico.ResumeLayout(False)
        Me.gbDescripcionDiagnostico.PerformLayout()
        Me.gbPreguntas.ResumeLayout(False)
        Me.tblActitud.ResumeLayout(False)
        Me.tblNutricion.ResumeLayout(False)
        Me.tblPulso.ResumeLayout(False)
        Me.tblGradoHidratacion.ResumeLayout(False)
        Me.tblTemperatura.ResumeLayout(False)
        Me.tblTemperatura.PerformLayout()
        Me.tabSintomasYSignos.ResumeLayout(False)
        Me.tabSintomasYSignos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents tabs As TabControl
    Friend WithEvents tabEntrevista As TabPage
    Friend WithEvents tabSintomasYSignos As TabPage
    Friend WithEvents gbResolucion As GroupBox
    Friend WithEvents txtNomAnalisis As TextBox
    Friend WithEvents gbDescripcionDiagnostico As GroupBox
    Friend WithEvents lblDiagnostico As Label
    Friend WithEvents txtTratamiento As TextBox
    Friend WithEvents chkAnalisis As CheckBox
    Friend WithEvents lblNomAnalisis As Label
    Friend WithEvents gbPreguntas As GroupBox
    Friend WithEvents chkSensoriales As CheckBox
    Friend WithEvents chkHumorales As CheckBox
    Friend WithEvents chkDigestivos As CheckBox
    Friend WithEvents chkVacunas As CheckBox
    Friend WithEvents chkErupciones As CheckBox
    Friend WithEvents chkCalor As CheckBox
    Friend WithEvents chkMeds As CheckBox
    Friend WithEvents chkDificultadesRespirar As CheckBox
    Friend WithEvents chkApendiceDolor As CheckBox
    Friend WithEvents tblActitud As TableLayoutPanel
    Friend WithEvents lblActitud As Label
    Friend WithEvents cbActitud As ComboBox
    Friend WithEvents tblNutricion As TableLayoutPanel
    Friend WithEvents lblENutricion As Label
    Friend WithEvents cbENutricion As ComboBox
    Friend WithEvents tblPulso As TableLayoutPanel
    Friend WithEvents lblPulso As Label
    Friend WithEvents cbPulso As ComboBox
    Friend WithEvents tblGradoHidratacion As TableLayoutPanel
    Friend WithEvents lblGradoHidratacion As Label
    Friend WithEvents cbGradoHidr As ComboBox
    Friend WithEvents tblTemperatura As TableLayoutPanel
    Friend WithEvents lblGrados As Label
    Friend WithEvents lblTemperatura As Label
    Friend WithEvents txtTemperatura As TextBox
    Friend WithEvents Imprimir As Printing.PrintDocument
    Friend WithEvents pp As PrintPreviewDialog
    Friend WithEvents lblIngreseSignoClinico As Label
    Friend WithEvents txtSgClinico As TextBox
    Friend WithEvents lbSignosClinicos As ListBox
    Friend WithEvents btnAgregarSClinico As Button
    Friend WithEvents btnAgregarSintoma As Button
    Friend WithEvents lblIngreseSintoma As Label
    Friend WithEvents txtSintoma As TextBox
    Friend WithEvents lbSintomas As ListBox
End Class
