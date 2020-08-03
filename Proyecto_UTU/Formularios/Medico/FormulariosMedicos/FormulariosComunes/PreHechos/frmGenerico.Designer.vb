<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGenerico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenerico))
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.gbSintomas = New System.Windows.Forms.GroupBox()
        Me.txtSintoma1 = New System.Windows.Forms.TextBox()
        Me.txtSintoma2 = New System.Windows.Forms.TextBox()
        Me.txtSintoma3 = New System.Windows.Forms.TextBox()
        Me.lblSintoma3 = New System.Windows.Forms.Label()
        Me.lblSintoma2 = New System.Windows.Forms.Label()
        Me.lblSintoma1 = New System.Windows.Forms.Label()
        Me.gbMotivoConsulta = New System.Windows.Forms.GroupBox()
        Me.txtMotivoConsulta = New System.Windows.Forms.TextBox()
        Me.gbResolucion = New System.Windows.Forms.GroupBox()
        Me.btnPredictivo = New System.Windows.Forms.Button()
        Me.txtNomAnalisis = New System.Windows.Forms.TextBox()
        Me.gbTratamiento = New System.Windows.Forms.GroupBox()
        Me.txtTratamiento = New System.Windows.Forms.TextBox()
        Me.chkTratamiento = New System.Windows.Forms.CheckBox()
        Me.chkAnalisis = New System.Windows.Forms.CheckBox()
        Me.lblNomAnalisis = New System.Windows.Forms.Label()
        Me.chkPacienteEnfermo = New System.Windows.Forms.CheckBox()
        Me.txtEnfermedad = New System.Windows.Forms.TextBox()
        Me.lblPacientePres = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.gbInspeccionGeneral = New System.Windows.Forms.GroupBox()
        Me.cbGradoHidr = New System.Windows.Forms.ComboBox()
        Me.lblGradoHidratacion = New System.Windows.Forms.Label()
        Me.cbENutricion = New System.Windows.Forms.ComboBox()
        Me.lblEstadoNutricion = New System.Windows.Forms.Label()
        Me.cbActitud = New System.Windows.Forms.ComboBox()
        Me.lblActitud = New System.Windows.Forms.Label()
        Me.cbMovilidad = New System.Windows.Forms.ComboBox()
        Me.lblMovilidad = New System.Windows.Forms.Label()
        Me.cbGradoColab = New System.Windows.Forms.ComboBox()
        Me.lblGradoColaboracion = New System.Windows.Forms.Label()
        Me.cbEstadoConsciencia = New System.Windows.Forms.ComboBox()
        Me.lblEConsciencia = New System.Windows.Forms.Label()
        Me.gbConstantesVitales = New System.Windows.Forms.GroupBox()
        Me.txtFrecuenciaResp = New System.Windows.Forms.TextBox()
        Me.cbPulso = New System.Windows.Forms.ComboBox()
        Me.txtFrecuenciaCard = New System.Windows.Forms.TextBox()
        Me.txtTemperatura = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblFrecuenciaResp = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblFrecuenciaCard = New System.Windows.Forms.Label()
        Me.lblPulso = New System.Windows.Forms.Label()
        Me.lblTemperatura = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Imprimir = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.pnlContenedor.SuspendLayout()
        Me.gbSintomas.SuspendLayout()
        Me.gbMotivoConsulta.SuspendLayout()
        Me.gbResolucion.SuspendLayout()
        Me.gbTratamiento.SuspendLayout()
        Me.gbInspeccionGeneral.SuspendLayout()
        Me.gbConstantesVitales.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.AutoScroll = True
        Me.pnlContenedor.AutoSize = True
        Me.pnlContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlContenedor.Controls.Add(Me.gbSintomas)
        Me.pnlContenedor.Controls.Add(Me.gbMotivoConsulta)
        Me.pnlContenedor.Controls.Add(Me.gbResolucion)
        Me.pnlContenedor.Controls.Add(Me.btnGuardar)
        Me.pnlContenedor.Controls.Add(Me.btnImprimir)
        Me.pnlContenedor.Controls.Add(Me.gbInspeccionGeneral)
        Me.pnlContenedor.Controls.Add(Me.gbConstantesVitales)
        Me.pnlContenedor.Controls.Add(Me.btnLimpiar)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1300, 1040)
        Me.pnlContenedor.TabIndex = 0
        '
        'gbSintomas
        '
        Me.gbSintomas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbSintomas.Controls.Add(Me.txtSintoma1)
        Me.gbSintomas.Controls.Add(Me.txtSintoma2)
        Me.gbSintomas.Controls.Add(Me.txtSintoma3)
        Me.gbSintomas.Controls.Add(Me.lblSintoma3)
        Me.gbSintomas.Controls.Add(Me.lblSintoma2)
        Me.gbSintomas.Controls.Add(Me.lblSintoma1)
        Me.gbSintomas.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSintomas.Location = New System.Drawing.Point(-12, 538)
        Me.gbSintomas.Name = "gbSintomas"
        Me.gbSintomas.Size = New System.Drawing.Size(1294, 67)
        Me.gbSintomas.TabIndex = 45
        Me.gbSintomas.TabStop = False
        Me.gbSintomas.Text = "Síntomas"
        '
        'txtSintoma1
        '
        Me.txtSintoma1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSintoma1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSintoma1.Location = New System.Drawing.Point(240, 28)
        Me.txtSintoma1.Name = "txtSintoma1"
        Me.txtSintoma1.Size = New System.Drawing.Size(219, 30)
        Me.txtSintoma1.TabIndex = 26
        '
        'txtSintoma2
        '
        Me.txtSintoma2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSintoma2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSintoma2.Location = New System.Drawing.Point(632, 28)
        Me.txtSintoma2.Name = "txtSintoma2"
        Me.txtSintoma2.Size = New System.Drawing.Size(219, 30)
        Me.txtSintoma2.TabIndex = 25
        '
        'txtSintoma3
        '
        Me.txtSintoma3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSintoma3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSintoma3.Location = New System.Drawing.Point(1034, 27)
        Me.txtSintoma3.Name = "txtSintoma3"
        Me.txtSintoma3.Size = New System.Drawing.Size(205, 30)
        Me.txtSintoma3.TabIndex = 24
        '
        'lblSintoma3
        '
        Me.lblSintoma3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSintoma3.AutoSize = True
        Me.lblSintoma3.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSintoma3.Location = New System.Drawing.Point(913, 26)
        Me.lblSintoma3.Name = "lblSintoma3"
        Me.lblSintoma3.Size = New System.Drawing.Size(115, 29)
        Me.lblSintoma3.TabIndex = 23
        Me.lblSintoma3.Text = "Síntoma:"
        '
        'lblSintoma2
        '
        Me.lblSintoma2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSintoma2.AutoSize = True
        Me.lblSintoma2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSintoma2.Location = New System.Drawing.Point(511, 28)
        Me.lblSintoma2.Name = "lblSintoma2"
        Me.lblSintoma2.Size = New System.Drawing.Size(115, 29)
        Me.lblSintoma2.TabIndex = 21
        Me.lblSintoma2.Text = "Síntoma:"
        '
        'lblSintoma1
        '
        Me.lblSintoma1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSintoma1.AutoSize = True
        Me.lblSintoma1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSintoma1.Location = New System.Drawing.Point(116, 28)
        Me.lblSintoma1.Name = "lblSintoma1"
        Me.lblSintoma1.Size = New System.Drawing.Size(115, 29)
        Me.lblSintoma1.TabIndex = 19
        Me.lblSintoma1.Text = "Síntoma:"
        '
        'gbMotivoConsulta
        '
        Me.gbMotivoConsulta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbMotivoConsulta.Controls.Add(Me.txtMotivoConsulta)
        Me.gbMotivoConsulta.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMotivoConsulta.Location = New System.Drawing.Point(-12, 3)
        Me.gbMotivoConsulta.Name = "gbMotivoConsulta"
        Me.gbMotivoConsulta.Size = New System.Drawing.Size(1294, 187)
        Me.gbMotivoConsulta.TabIndex = 43
        Me.gbMotivoConsulta.TabStop = False
        Me.gbMotivoConsulta.Text = "Motivo de consulta"
        '
        'txtMotivoConsulta
        '
        Me.txtMotivoConsulta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMotivoConsulta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivoConsulta.Location = New System.Drawing.Point(12, 26)
        Me.txtMotivoConsulta.Multiline = True
        Me.txtMotivoConsulta.Name = "txtMotivoConsulta"
        Me.txtMotivoConsulta.Size = New System.Drawing.Size(1273, 157)
        Me.txtMotivoConsulta.TabIndex = 0
        '
        'gbResolucion
        '
        Me.gbResolucion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbResolucion.Controls.Add(Me.btnPredictivo)
        Me.gbResolucion.Controls.Add(Me.txtNomAnalisis)
        Me.gbResolucion.Controls.Add(Me.gbTratamiento)
        Me.gbResolucion.Controls.Add(Me.chkTratamiento)
        Me.gbResolucion.Controls.Add(Me.chkAnalisis)
        Me.gbResolucion.Controls.Add(Me.lblNomAnalisis)
        Me.gbResolucion.Controls.Add(Me.chkPacienteEnfermo)
        Me.gbResolucion.Controls.Add(Me.txtEnfermedad)
        Me.gbResolucion.Controls.Add(Me.lblPacientePres)
        Me.gbResolucion.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbResolucion.Location = New System.Drawing.Point(-12, 611)
        Me.gbResolucion.Name = "gbResolucion"
        Me.gbResolucion.Size = New System.Drawing.Size(1294, 381)
        Me.gbResolucion.TabIndex = 46
        Me.gbResolucion.TabStop = False
        Me.gbResolucion.Text = "Resolución"
        '
        'btnPredictivo
        '
        Me.btnPredictivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPredictivo.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnPredictivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPredictivo.Location = New System.Drawing.Point(557, 28)
        Me.btnPredictivo.Name = "btnPredictivo"
        Me.btnPredictivo.Size = New System.Drawing.Size(194, 111)
        Me.btnPredictivo.TabIndex = 28
        Me.btnPredictivo.Text = "Generar Diagnostico Predictivo"
        Me.btnPredictivo.UseVisualStyleBackColor = False
        '
        'txtNomAnalisis
        '
        Me.txtNomAnalisis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNomAnalisis.Enabled = False
        Me.txtNomAnalisis.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomAnalisis.Location = New System.Drawing.Point(1020, 85)
        Me.txtNomAnalisis.Name = "txtNomAnalisis"
        Me.txtNomAnalisis.Size = New System.Drawing.Size(219, 30)
        Me.txtNomAnalisis.TabIndex = 27
        '
        'gbTratamiento
        '
        Me.gbTratamiento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbTratamiento.Controls.Add(Me.txtTratamiento)
        Me.gbTratamiento.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTratamiento.Location = New System.Drawing.Point(6, 184)
        Me.gbTratamiento.Name = "gbTratamiento"
        Me.gbTratamiento.Size = New System.Drawing.Size(1285, 191)
        Me.gbTratamiento.TabIndex = 26
        Me.gbTratamiento.TabStop = False
        Me.gbTratamiento.Text = "Descripción del tratamiento"
        '
        'txtTratamiento
        '
        Me.txtTratamiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTratamiento.Enabled = False
        Me.txtTratamiento.Location = New System.Drawing.Point(6, 33)
        Me.txtTratamiento.Multiline = True
        Me.txtTratamiento.Name = "txtTratamiento"
        Me.txtTratamiento.Size = New System.Drawing.Size(1273, 152)
        Me.txtTratamiento.TabIndex = 1
        '
        'chkTratamiento
        '
        Me.chkTratamiento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkTratamiento.AutoSize = True
        Me.chkTratamiento.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTratamiento.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTratamiento.Location = New System.Drawing.Point(393, 145)
        Me.chkTratamiento.Name = "chkTratamiento"
        Me.chkTratamiento.Size = New System.Drawing.Size(508, 33)
        Me.chkTratamiento.TabIndex = 25
        Me.chkTratamiento.Text = "¿El paciente debe seguir un tratamiento?"
        Me.chkTratamiento.UseVisualStyleBackColor = True
        '
        'chkAnalisis
        '
        Me.chkAnalisis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkAnalisis.AutoSize = True
        Me.chkAnalisis.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAnalisis.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnalisis.Location = New System.Drawing.Point(753, 40)
        Me.chkAnalisis.Name = "chkAnalisis"
        Me.chkAnalisis.Size = New System.Drawing.Size(486, 33)
        Me.chkAnalisis.TabIndex = 24
        Me.chkAnalisis.Text = "¿El paciente debe solicitar un análisis?"
        Me.chkAnalisis.UseVisualStyleBackColor = True
        '
        'lblNomAnalisis
        '
        Me.lblNomAnalisis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNomAnalisis.AutoSize = True
        Me.lblNomAnalisis.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomAnalisis.Location = New System.Drawing.Point(757, 85)
        Me.lblNomAnalisis.Name = "lblNomAnalisis"
        Me.lblNomAnalisis.Size = New System.Drawing.Size(247, 29)
        Me.lblNomAnalisis.TabIndex = 22
        Me.lblNomAnalisis.Text = "Nombre del análisis:"
        '
        'chkPacienteEnfermo
        '
        Me.chkPacienteEnfermo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkPacienteEnfermo.AutoSize = True
        Me.chkPacienteEnfermo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPacienteEnfermo.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPacienteEnfermo.Location = New System.Drawing.Point(49, 40)
        Me.chkPacienteEnfermo.Name = "chkPacienteEnfermo"
        Me.chkPacienteEnfermo.Size = New System.Drawing.Size(347, 33)
        Me.chkPacienteEnfermo.TabIndex = 21
        Me.chkPacienteEnfermo.Text = "¿El paciente está enfermo?"
        Me.chkPacienteEnfermo.UseVisualStyleBackColor = True
        '
        'txtEnfermedad
        '
        Me.txtEnfermedad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEnfermedad.Enabled = False
        Me.txtEnfermedad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnfermedad.Location = New System.Drawing.Point(319, 84)
        Me.txtEnfermedad.Name = "txtEnfermedad"
        Me.txtEnfermedad.Size = New System.Drawing.Size(219, 30)
        Me.txtEnfermedad.TabIndex = 20
        '
        'lblPacientePres
        '
        Me.lblPacientePres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPacientePres.AutoSize = True
        Me.lblPacientePres.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPacientePres.Location = New System.Drawing.Point(50, 85)
        Me.lblPacientePres.Name = "lblPacientePres"
        Me.lblPacientePres.Size = New System.Drawing.Size(253, 29)
        Me.lblPacientePres.TabIndex = 19
        Me.lblPacientePres.Text = "El paciente presenta:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(667, 1015)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(146, 45)
        Me.btnGuardar.TabIndex = 47
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(515, 1015)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(146, 45)
        Me.btnImprimir.TabIndex = 49
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'gbInspeccionGeneral
        '
        Me.gbInspeccionGeneral.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbInspeccionGeneral.Controls.Add(Me.cbGradoHidr)
        Me.gbInspeccionGeneral.Controls.Add(Me.lblGradoHidratacion)
        Me.gbInspeccionGeneral.Controls.Add(Me.cbENutricion)
        Me.gbInspeccionGeneral.Controls.Add(Me.lblEstadoNutricion)
        Me.gbInspeccionGeneral.Controls.Add(Me.cbActitud)
        Me.gbInspeccionGeneral.Controls.Add(Me.lblActitud)
        Me.gbInspeccionGeneral.Controls.Add(Me.cbMovilidad)
        Me.gbInspeccionGeneral.Controls.Add(Me.lblMovilidad)
        Me.gbInspeccionGeneral.Controls.Add(Me.cbGradoColab)
        Me.gbInspeccionGeneral.Controls.Add(Me.lblGradoColaboracion)
        Me.gbInspeccionGeneral.Controls.Add(Me.cbEstadoConsciencia)
        Me.gbInspeccionGeneral.Controls.Add(Me.lblEConsciencia)
        Me.gbInspeccionGeneral.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInspeccionGeneral.Location = New System.Drawing.Point(-12, 196)
        Me.gbInspeccionGeneral.Name = "gbInspeccionGeneral"
        Me.gbInspeccionGeneral.Size = New System.Drawing.Size(1294, 203)
        Me.gbInspeccionGeneral.TabIndex = 42
        Me.gbInspeccionGeneral.TabStop = False
        Me.gbInspeccionGeneral.Text = "Inspección general"
        '
        'cbGradoHidr
        '
        Me.cbGradoHidr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbGradoHidr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGradoHidr.FormattingEnabled = True
        Me.cbGradoHidr.Items.AddRange(New Object() {"Hidratado", "Normohidratado", "Hiperhidratado", "Hipohidratado", "Deshidratado", "Rehidratado"})
        Me.cbGradoHidr.Location = New System.Drawing.Point(981, 160)
        Me.cbGradoHidr.Name = "cbGradoHidr"
        Me.cbGradoHidr.Size = New System.Drawing.Size(258, 31)
        Me.cbGradoHidr.TabIndex = 11
        '
        'lblGradoHidratacion
        '
        Me.lblGradoHidratacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGradoHidratacion.AutoSize = True
        Me.lblGradoHidratacion.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradoHidratacion.Location = New System.Drawing.Point(699, 167)
        Me.lblGradoHidratacion.Name = "lblGradoHidratacion"
        Me.lblGradoHidratacion.Size = New System.Drawing.Size(263, 29)
        Me.lblGradoHidratacion.TabIndex = 10
        Me.lblGradoHidratacion.Text = "Grado de hidratación:"
        '
        'cbENutricion
        '
        Me.cbENutricion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbENutricion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbENutricion.FormattingEnabled = True
        Me.cbENutricion.Items.AddRange(New Object() {"Obesidad", "Anorexia", "Caquexia", "Peso normal"})
        Me.cbENutricion.Location = New System.Drawing.Point(409, 160)
        Me.cbENutricion.Name = "cbENutricion"
        Me.cbENutricion.Size = New System.Drawing.Size(219, 31)
        Me.cbENutricion.TabIndex = 9
        '
        'lblEstadoNutricion
        '
        Me.lblEstadoNutricion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEstadoNutricion.AutoSize = True
        Me.lblEstadoNutricion.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoNutricion.Location = New System.Drawing.Point(148, 167)
        Me.lblEstadoNutricion.Name = "lblEstadoNutricion"
        Me.lblEstadoNutricion.Size = New System.Drawing.Size(246, 29)
        Me.lblEstadoNutricion.TabIndex = 8
        Me.lblEstadoNutricion.Text = "Estado de nutrición:"
        '
        'cbActitud
        '
        Me.cbActitud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbActitud.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbActitud.FormattingEnabled = True
        Me.cbActitud.Items.AddRange(New Object() {"Apatía", "Coma", "Excitación", "Desmotivación", "Desinterés", "Otro"})
        Me.cbActitud.Location = New System.Drawing.Point(981, 102)
        Me.cbActitud.Name = "cbActitud"
        Me.cbActitud.Size = New System.Drawing.Size(258, 31)
        Me.cbActitud.TabIndex = 7
        '
        'lblActitud
        '
        Me.lblActitud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblActitud.AutoSize = True
        Me.lblActitud.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActitud.Location = New System.Drawing.Point(872, 109)
        Me.lblActitud.Name = "lblActitud"
        Me.lblActitud.Size = New System.Drawing.Size(103, 29)
        Me.lblActitud.TabIndex = 6
        Me.lblActitud.Text = "Actitud:"
        '
        'cbMovilidad
        '
        Me.cbMovilidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbMovilidad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMovilidad.FormattingEnabled = True
        Me.cbMovilidad.Items.AddRange(New Object() {"Buena", "Mala", "Con dificultades"})
        Me.cbMovilidad.Location = New System.Drawing.Point(409, 102)
        Me.cbMovilidad.Name = "cbMovilidad"
        Me.cbMovilidad.Size = New System.Drawing.Size(219, 31)
        Me.cbMovilidad.TabIndex = 5
        '
        'lblMovilidad
        '
        Me.lblMovilidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMovilidad.AutoSize = True
        Me.lblMovilidad.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovilidad.Location = New System.Drawing.Point(270, 109)
        Me.lblMovilidad.Name = "lblMovilidad"
        Me.lblMovilidad.Size = New System.Drawing.Size(133, 29)
        Me.lblMovilidad.TabIndex = 4
        Me.lblMovilidad.Text = "Movilidad:"
        '
        'cbGradoColab
        '
        Me.cbGradoColab.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbGradoColab.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGradoColab.FormattingEnabled = True
        Me.cbGradoColab.Items.AddRange(New Object() {"Bueno", "Malo"})
        Me.cbGradoColab.Location = New System.Drawing.Point(981, 32)
        Me.cbGradoColab.Name = "cbGradoColab"
        Me.cbGradoColab.Size = New System.Drawing.Size(258, 31)
        Me.cbGradoColab.TabIndex = 3
        '
        'lblGradoColaboracion
        '
        Me.lblGradoColaboracion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGradoColaboracion.AutoSize = True
        Me.lblGradoColaboracion.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradoColaboracion.Location = New System.Drawing.Point(677, 39)
        Me.lblGradoColaboracion.Name = "lblGradoColaboracion"
        Me.lblGradoColaboracion.Size = New System.Drawing.Size(283, 29)
        Me.lblGradoColaboracion.TabIndex = 2
        Me.lblGradoColaboracion.Text = "Grado de colaboración:"
        '
        'cbEstadoConsciencia
        '
        Me.cbEstadoConsciencia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbEstadoConsciencia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstadoConsciencia.FormattingEnabled = True
        Me.cbEstadoConsciencia.Items.AddRange(New Object() {"Consciente", "Inconsciente"})
        Me.cbEstadoConsciencia.Location = New System.Drawing.Point(409, 32)
        Me.cbEstadoConsciencia.Name = "cbEstadoConsciencia"
        Me.cbEstadoConsciencia.Size = New System.Drawing.Size(219, 31)
        Me.cbEstadoConsciencia.TabIndex = 1
        '
        'lblEConsciencia
        '
        Me.lblEConsciencia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEConsciencia.AutoSize = True
        Me.lblEConsciencia.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEConsciencia.Location = New System.Drawing.Point(108, 39)
        Me.lblEConsciencia.Name = "lblEConsciencia"
        Me.lblEConsciencia.Size = New System.Drawing.Size(279, 29)
        Me.lblEConsciencia.TabIndex = 0
        Me.lblEConsciencia.Text = "Estado de consciencia:"
        '
        'gbConstantesVitales
        '
        Me.gbConstantesVitales.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbConstantesVitales.Controls.Add(Me.txtFrecuenciaResp)
        Me.gbConstantesVitales.Controls.Add(Me.cbPulso)
        Me.gbConstantesVitales.Controls.Add(Me.txtFrecuenciaCard)
        Me.gbConstantesVitales.Controls.Add(Me.txtTemperatura)
        Me.gbConstantesVitales.Controls.Add(Me.Label21)
        Me.gbConstantesVitales.Controls.Add(Me.lblFrecuenciaResp)
        Me.gbConstantesVitales.Controls.Add(Me.Label23)
        Me.gbConstantesVitales.Controls.Add(Me.Label24)
        Me.gbConstantesVitales.Controls.Add(Me.lblFrecuenciaCard)
        Me.gbConstantesVitales.Controls.Add(Me.lblPulso)
        Me.gbConstantesVitales.Controls.Add(Me.lblTemperatura)
        Me.gbConstantesVitales.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbConstantesVitales.Location = New System.Drawing.Point(-12, 405)
        Me.gbConstantesVitales.Name = "gbConstantesVitales"
        Me.gbConstantesVitales.Size = New System.Drawing.Size(1294, 127)
        Me.gbConstantesVitales.TabIndex = 44
        Me.gbConstantesVitales.TabStop = False
        Me.gbConstantesVitales.Text = "Constantes Vitales"
        '
        'txtFrecuenciaResp
        '
        Me.txtFrecuenciaResp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFrecuenciaResp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrecuenciaResp.Location = New System.Drawing.Point(969, 91)
        Me.txtFrecuenciaResp.Name = "txtFrecuenciaResp"
        Me.txtFrecuenciaResp.Size = New System.Drawing.Size(66, 30)
        Me.txtFrecuenciaResp.TabIndex = 22
        '
        'cbPulso
        '
        Me.cbPulso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbPulso.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPulso.FormattingEnabled = True
        Me.cbPulso.Items.AddRange(New Object() {"Fuerte", "Débil", "Filiforme"})
        Me.cbPulso.Location = New System.Drawing.Point(969, 37)
        Me.cbPulso.Name = "cbPulso"
        Me.cbPulso.Size = New System.Drawing.Size(270, 31)
        Me.cbPulso.TabIndex = 21
        '
        'txtFrecuenciaCard
        '
        Me.txtFrecuenciaCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFrecuenciaCard.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrecuenciaCard.Location = New System.Drawing.Point(393, 84)
        Me.txtFrecuenciaCard.Name = "txtFrecuenciaCard"
        Me.txtFrecuenciaCard.Size = New System.Drawing.Size(66, 30)
        Me.txtFrecuenciaCard.TabIndex = 20
        '
        'txtTemperatura
        '
        Me.txtTemperatura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTemperatura.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemperatura.Location = New System.Drawing.Point(393, 36)
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.Size = New System.Drawing.Size(66, 30)
        Me.txtTemperatura.TabIndex = 19
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(1041, 93)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 18)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "rpm"
        '
        'lblFrecuenciaResp
        '
        Me.lblFrecuenciaResp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFrecuenciaResp.AutoSize = True
        Me.lblFrecuenciaResp.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrecuenciaResp.Location = New System.Drawing.Point(635, 92)
        Me.lblFrecuenciaResp.Name = "lblFrecuenciaResp"
        Me.lblFrecuenciaResp.Size = New System.Drawing.Size(292, 29)
        Me.lblFrecuenciaResp.TabIndex = 16
        Me.lblFrecuenciaResp.Text = "Frecuencia Respiratoria:"
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(465, 85)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(38, 18)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "ppm"
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(462, 28)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(23, 29)
        Me.Label24.TabIndex = 13
        Me.Label24.Text = "°"
        '
        'lblFrecuenciaCard
        '
        Me.lblFrecuenciaCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFrecuenciaCard.AutoSize = True
        Me.lblFrecuenciaCard.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrecuenciaCard.Location = New System.Drawing.Point(115, 85)
        Me.lblFrecuenciaCard.Name = "lblFrecuenciaCard"
        Me.lblFrecuenciaCard.Size = New System.Drawing.Size(253, 29)
        Me.lblFrecuenciaCard.TabIndex = 4
        Me.lblFrecuenciaCard.Text = "Frecuencia Cardíaca:"
        '
        'lblPulso
        '
        Me.lblPulso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPulso.AutoSize = True
        Me.lblPulso.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPulso.Location = New System.Drawing.Point(863, 37)
        Me.lblPulso.Name = "lblPulso"
        Me.lblPulso.Size = New System.Drawing.Size(86, 29)
        Me.lblPulso.TabIndex = 2
        Me.lblPulso.Text = "Pulso:"
        '
        'lblTemperatura
        '
        Me.lblTemperatura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTemperatura.AutoSize = True
        Me.lblTemperatura.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperatura.Location = New System.Drawing.Point(215, 37)
        Me.lblTemperatura.Name = "lblTemperatura"
        Me.lblTemperatura.Size = New System.Drawing.Size(162, 29)
        Me.lblTemperatura.TabIndex = 0
        Me.lblTemperatura.Text = "Temperatura:"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(363, 1015)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(146, 45)
        Me.btnLimpiar.TabIndex = 48
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Imprimir
        '
        Me.Imprimir.DocumentName = "formulario"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.Imprimir
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmGenerico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1300, 1040)
        Me.Controls.Add(Me.pnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGenerico"
        Me.Text = "frmGenericoTest"
        Me.pnlContenedor.ResumeLayout(False)
        Me.gbSintomas.ResumeLayout(False)
        Me.gbSintomas.PerformLayout()
        Me.gbMotivoConsulta.ResumeLayout(False)
        Me.gbMotivoConsulta.PerformLayout()
        Me.gbResolucion.ResumeLayout(False)
        Me.gbResolucion.PerformLayout()
        Me.gbTratamiento.ResumeLayout(False)
        Me.gbTratamiento.PerformLayout()
        Me.gbInspeccionGeneral.ResumeLayout(False)
        Me.gbInspeccionGeneral.PerformLayout()
        Me.gbConstantesVitales.ResumeLayout(False)
        Me.gbConstantesVitales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents gbSintomas As GroupBox
    Friend WithEvents txtSintoma1 As TextBox
    Friend WithEvents txtSintoma2 As TextBox
    Friend WithEvents txtSintoma3 As TextBox
    Friend WithEvents lblSintoma3 As Label
    Friend WithEvents lblSintoma2 As Label
    Friend WithEvents lblSintoma1 As Label
    Friend WithEvents gbMotivoConsulta As GroupBox
    Friend WithEvents txtMotivoConsulta As TextBox
    Friend WithEvents gbResolucion As GroupBox
    Friend WithEvents btnPredictivo As Button
    Friend WithEvents txtNomAnalisis As TextBox
    Friend WithEvents gbTratamiento As GroupBox
    Friend WithEvents chkTratamiento As CheckBox
    Friend WithEvents chkAnalisis As CheckBox
    Friend WithEvents lblNomAnalisis As Label
    Friend WithEvents chkPacienteEnfermo As CheckBox
    Friend WithEvents txtEnfermedad As TextBox
    Friend WithEvents lblPacientePres As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents gbInspeccionGeneral As GroupBox
    Friend WithEvents cbGradoHidr As ComboBox
    Friend WithEvents lblGradoHidratacion As Label
    Friend WithEvents cbENutricion As ComboBox
    Friend WithEvents lblEstadoNutricion As Label
    Friend WithEvents cbActitud As ComboBox
    Friend WithEvents lblActitud As Label
    Friend WithEvents cbMovilidad As ComboBox
    Friend WithEvents lblMovilidad As Label
    Friend WithEvents cbGradoColab As ComboBox
    Friend WithEvents lblGradoColaboracion As Label
    Friend WithEvents cbEstadoConsciencia As ComboBox
    Friend WithEvents lblEConsciencia As Label
    Friend WithEvents gbConstantesVitales As GroupBox
    Friend WithEvents txtFrecuenciaResp As TextBox
    Friend WithEvents cbPulso As ComboBox
    Friend WithEvents txtFrecuenciaCard As TextBox
    Friend WithEvents txtTemperatura As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents lblFrecuenciaResp As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblFrecuenciaCard As Label
    Friend WithEvents lblPulso As Label
    Friend WithEvents lblTemperatura As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Imprimir As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents txtTratamiento As TextBox
End Class
