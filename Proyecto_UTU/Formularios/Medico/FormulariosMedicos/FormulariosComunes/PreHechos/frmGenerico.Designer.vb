<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerico
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
        Me.lblEConsciencia = New System.Windows.Forms.Label()
        Me.cbEstadoConsciencia = New System.Windows.Forms.ComboBox()
        Me.lblGradoColaboracion = New System.Windows.Forms.Label()
        Me.cbGradoColab = New System.Windows.Forms.ComboBox()
        Me.lblMovilidad = New System.Windows.Forms.Label()
        Me.cbMovilidad = New System.Windows.Forms.ComboBox()
        Me.lblActitud = New System.Windows.Forms.Label()
        Me.cbActitud = New System.Windows.Forms.ComboBox()
        Me.lblEstadoNutricion = New System.Windows.Forms.Label()
        Me.cbENutricion = New System.Windows.Forms.ComboBox()
        Me.lblGradoHidratacion = New System.Windows.Forms.Label()
        Me.cbGradoHidr = New System.Windows.Forms.ComboBox()
        Me.gbInspeccionGeneral = New System.Windows.Forms.GroupBox()
        Me.lblTemperatura = New System.Windows.Forms.Label()
        Me.lblPulso = New System.Windows.Forms.Label()
        Me.cbPulso = New System.Windows.Forms.ComboBox()
        Me.lblFrecuenciaCard = New System.Windows.Forms.Label()
        Me.txtTemperatura = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtFrecuenciaCard = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblFrecuenciaResp = New System.Windows.Forms.Label()
        Me.txtFrecuenciaResp = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.gbConstantesVitales = New System.Windows.Forms.GroupBox()
        Me.lblSintoma1 = New System.Windows.Forms.Label()
        Me.txtSintoma1 = New System.Windows.Forms.TextBox()
        Me.lblSintoma2 = New System.Windows.Forms.Label()
        Me.txtSintoma2 = New System.Windows.Forms.TextBox()
        Me.lblSintoma3 = New System.Windows.Forms.Label()
        Me.txtSintoma3 = New System.Windows.Forms.TextBox()
        Me.gbSintomas = New System.Windows.Forms.GroupBox()
        Me.txtMotivoConsulta = New System.Windows.Forms.TextBox()
        Me.gbMotivoConsulta = New System.Windows.Forms.GroupBox()
        Me.lblPacientePres = New System.Windows.Forms.Label()
        Me.txtEnfermedad = New System.Windows.Forms.TextBox()
        Me.chkPacienteEnfermo = New System.Windows.Forms.CheckBox()
        Me.lblNomAnalisis = New System.Windows.Forms.Label()
        Me.chkAnalisis = New System.Windows.Forms.CheckBox()
        Me.chkTratamiento = New System.Windows.Forms.CheckBox()
        Me.gbTratamiento = New System.Windows.Forms.GroupBox()
        Me.txtTratamiento = New System.Windows.Forms.TextBox()
        Me.gbResolucion = New System.Windows.Forms.GroupBox()
        Me.txtNomAnalisis = New System.Windows.Forms.TextBox()
        Me.btnPredictivo = New System.Windows.Forms.Button()
        Me.gbInspeccionGeneral.SuspendLayout()
        Me.gbConstantesVitales.SuspendLayout()
        Me.gbSintomas.SuspendLayout()
        Me.gbMotivoConsulta.SuspendLayout()
        Me.gbTratamiento.SuspendLayout()
        Me.gbResolucion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEConsciencia
        '
        Me.lblEConsciencia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEConsciencia.AutoSize = True
        Me.lblEConsciencia.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEConsciencia.Location = New System.Drawing.Point(-46, 49)
        Me.lblEConsciencia.Name = "lblEConsciencia"
        Me.lblEConsciencia.Size = New System.Drawing.Size(279, 29)
        Me.lblEConsciencia.TabIndex = 0
        Me.lblEConsciencia.Text = "Estado de consciencia:"
        '
        'cbEstadoConsciencia
        '
        Me.cbEstadoConsciencia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbEstadoConsciencia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstadoConsciencia.FormattingEnabled = True
        Me.cbEstadoConsciencia.Items.AddRange(New Object() {"Consciente", "Inconsciente"})
        Me.cbEstadoConsciencia.Location = New System.Drawing.Point(255, 42)
        Me.cbEstadoConsciencia.Name = "cbEstadoConsciencia"
        Me.cbEstadoConsciencia.Size = New System.Drawing.Size(219, 31)
        Me.cbEstadoConsciencia.TabIndex = 1
        '
        'lblGradoColaboracion
        '
        Me.lblGradoColaboracion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGradoColaboracion.AutoSize = True
        Me.lblGradoColaboracion.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradoColaboracion.Location = New System.Drawing.Point(523, 49)
        Me.lblGradoColaboracion.Name = "lblGradoColaboracion"
        Me.lblGradoColaboracion.Size = New System.Drawing.Size(283, 29)
        Me.lblGradoColaboracion.TabIndex = 2
        Me.lblGradoColaboracion.Text = "Grado de colaboración:"
        '
        'cbGradoColab
        '
        Me.cbGradoColab.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbGradoColab.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGradoColab.FormattingEnabled = True
        Me.cbGradoColab.Items.AddRange(New Object() {"Bueno", "Malo"})
        Me.cbGradoColab.Location = New System.Drawing.Point(827, 42)
        Me.cbGradoColab.Name = "cbGradoColab"
        Me.cbGradoColab.Size = New System.Drawing.Size(219, 31)
        Me.cbGradoColab.TabIndex = 3
        '
        'lblMovilidad
        '
        Me.lblMovilidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMovilidad.AutoSize = True
        Me.lblMovilidad.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovilidad.Location = New System.Drawing.Point(116, 119)
        Me.lblMovilidad.Name = "lblMovilidad"
        Me.lblMovilidad.Size = New System.Drawing.Size(133, 29)
        Me.lblMovilidad.TabIndex = 4
        Me.lblMovilidad.Text = "Movilidad:"
        '
        'cbMovilidad
        '
        Me.cbMovilidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbMovilidad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMovilidad.FormattingEnabled = True
        Me.cbMovilidad.Items.AddRange(New Object() {"Buena", "Mala", "Con dificultades"})
        Me.cbMovilidad.Location = New System.Drawing.Point(255, 112)
        Me.cbMovilidad.Name = "cbMovilidad"
        Me.cbMovilidad.Size = New System.Drawing.Size(219, 31)
        Me.cbMovilidad.TabIndex = 5
        '
        'lblActitud
        '
        Me.lblActitud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblActitud.AutoSize = True
        Me.lblActitud.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActitud.Location = New System.Drawing.Point(718, 119)
        Me.lblActitud.Name = "lblActitud"
        Me.lblActitud.Size = New System.Drawing.Size(103, 29)
        Me.lblActitud.TabIndex = 6
        Me.lblActitud.Text = "Actitud:"
        '
        'cbActitud
        '
        Me.cbActitud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbActitud.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbActitud.FormattingEnabled = True
        Me.cbActitud.Items.AddRange(New Object() {"Apatía", "Coma", "Excitación", "Desmotivación", "Desinterés", "Otro"})
        Me.cbActitud.Location = New System.Drawing.Point(827, 112)
        Me.cbActitud.Name = "cbActitud"
        Me.cbActitud.Size = New System.Drawing.Size(219, 31)
        Me.cbActitud.TabIndex = 7
        '
        'lblEstadoNutricion
        '
        Me.lblEstadoNutricion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEstadoNutricion.AutoSize = True
        Me.lblEstadoNutricion.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoNutricion.Location = New System.Drawing.Point(-6, 177)
        Me.lblEstadoNutricion.Name = "lblEstadoNutricion"
        Me.lblEstadoNutricion.Size = New System.Drawing.Size(246, 29)
        Me.lblEstadoNutricion.TabIndex = 8
        Me.lblEstadoNutricion.Text = "Estado de nutrición:"
        '
        'cbENutricion
        '
        Me.cbENutricion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbENutricion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbENutricion.FormattingEnabled = True
        Me.cbENutricion.Items.AddRange(New Object() {"Obesidad", "Anorexia", "Caquexia", "Peso normal"})
        Me.cbENutricion.Location = New System.Drawing.Point(255, 170)
        Me.cbENutricion.Name = "cbENutricion"
        Me.cbENutricion.Size = New System.Drawing.Size(219, 31)
        Me.cbENutricion.TabIndex = 9
        '
        'lblGradoHidratacion
        '
        Me.lblGradoHidratacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGradoHidratacion.AutoSize = True
        Me.lblGradoHidratacion.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradoHidratacion.Location = New System.Drawing.Point(545, 177)
        Me.lblGradoHidratacion.Name = "lblGradoHidratacion"
        Me.lblGradoHidratacion.Size = New System.Drawing.Size(263, 29)
        Me.lblGradoHidratacion.TabIndex = 10
        Me.lblGradoHidratacion.Text = "Grado de hidratación:"
        '
        'cbGradoHidr
        '
        Me.cbGradoHidr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbGradoHidr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGradoHidr.FormattingEnabled = True
        Me.cbGradoHidr.Items.AddRange(New Object() {"Hidratado", "Normohidratado", "Hiperhidratado", "Hipohidratado", "Deshidratado", "Rehidratado"})
        Me.cbGradoHidr.Location = New System.Drawing.Point(827, 170)
        Me.cbGradoHidr.Name = "cbGradoHidr"
        Me.cbGradoHidr.Size = New System.Drawing.Size(219, 31)
        Me.cbGradoHidr.TabIndex = 11
        '
        'gbInspeccionGeneral
        '
        Me.gbInspeccionGeneral.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.gbInspeccionGeneral.Location = New System.Drawing.Point(18, 214)
        Me.gbInspeccionGeneral.Name = "gbInspeccionGeneral"
        Me.gbInspeccionGeneral.Size = New System.Drawing.Size(1148, 224)
        Me.gbInspeccionGeneral.TabIndex = 31
        Me.gbInspeccionGeneral.TabStop = False
        Me.gbInspeccionGeneral.Text = "Inspección general"
        '
        'lblTemperatura
        '
        Me.lblTemperatura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTemperatura.AutoSize = True
        Me.lblTemperatura.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperatura.Location = New System.Drawing.Point(61, 49)
        Me.lblTemperatura.Name = "lblTemperatura"
        Me.lblTemperatura.Size = New System.Drawing.Size(162, 29)
        Me.lblTemperatura.TabIndex = 0
        Me.lblTemperatura.Text = "Temperatura:"
        '
        'lblPulso
        '
        Me.lblPulso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPulso.AutoSize = True
        Me.lblPulso.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPulso.Location = New System.Drawing.Point(709, 49)
        Me.lblPulso.Name = "lblPulso"
        Me.lblPulso.Size = New System.Drawing.Size(86, 29)
        Me.lblPulso.TabIndex = 2
        Me.lblPulso.Text = "Pulso:"
        '
        'cbPulso
        '
        Me.cbPulso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbPulso.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPulso.FormattingEnabled = True
        Me.cbPulso.Items.AddRange(New Object() {"Fuerte", "Débil", "Filiforme"})
        Me.cbPulso.Location = New System.Drawing.Point(815, 42)
        Me.cbPulso.Name = "cbPulso"
        Me.cbPulso.Size = New System.Drawing.Size(219, 31)
        Me.cbPulso.TabIndex = 3
        '
        'lblFrecuenciaCard
        '
        Me.lblFrecuenciaCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFrecuenciaCard.AutoSize = True
        Me.lblFrecuenciaCard.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrecuenciaCard.Location = New System.Drawing.Point(-39, 97)
        Me.lblFrecuenciaCard.Name = "lblFrecuenciaCard"
        Me.lblFrecuenciaCard.Size = New System.Drawing.Size(253, 29)
        Me.lblFrecuenciaCard.TabIndex = 4
        Me.lblFrecuenciaCard.Text = "Frecuencia Cardíaca:"
        '
        'txtTemperatura
        '
        Me.txtTemperatura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTemperatura.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemperatura.Location = New System.Drawing.Point(239, 42)
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.Size = New System.Drawing.Size(66, 30)
        Me.txtTemperatura.TabIndex = 12
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(308, 40)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(23, 29)
        Me.Label24.TabIndex = 13
        Me.Label24.Text = "°"
        '
        'txtFrecuenciaCard
        '
        Me.txtFrecuenciaCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFrecuenciaCard.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrecuenciaCard.Location = New System.Drawing.Point(239, 97)
        Me.txtFrecuenciaCard.Name = "txtFrecuenciaCard"
        Me.txtFrecuenciaCard.Size = New System.Drawing.Size(66, 30)
        Me.txtFrecuenciaCard.TabIndex = 14
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(311, 97)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(38, 18)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "ppm"
        '
        'lblFrecuenciaResp
        '
        Me.lblFrecuenciaResp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFrecuenciaResp.AutoSize = True
        Me.lblFrecuenciaResp.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrecuenciaResp.Location = New System.Drawing.Point(481, 104)
        Me.lblFrecuenciaResp.Name = "lblFrecuenciaResp"
        Me.lblFrecuenciaResp.Size = New System.Drawing.Size(292, 29)
        Me.lblFrecuenciaResp.TabIndex = 16
        Me.lblFrecuenciaResp.Text = "Frecuencia Respiratoria:"
        '
        'txtFrecuenciaResp
        '
        Me.txtFrecuenciaResp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFrecuenciaResp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrecuenciaResp.Location = New System.Drawing.Point(815, 101)
        Me.txtFrecuenciaResp.Name = "txtFrecuenciaResp"
        Me.txtFrecuenciaResp.Size = New System.Drawing.Size(66, 30)
        Me.txtFrecuenciaResp.TabIndex = 17
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(887, 97)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 18)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "rpm"
        '
        'gbConstantesVitales
        '
        Me.gbConstantesVitales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbConstantesVitales.Controls.Add(Me.Label21)
        Me.gbConstantesVitales.Controls.Add(Me.txtFrecuenciaResp)
        Me.gbConstantesVitales.Controls.Add(Me.lblFrecuenciaResp)
        Me.gbConstantesVitales.Controls.Add(Me.Label23)
        Me.gbConstantesVitales.Controls.Add(Me.txtFrecuenciaCard)
        Me.gbConstantesVitales.Controls.Add(Me.Label24)
        Me.gbConstantesVitales.Controls.Add(Me.txtTemperatura)
        Me.gbConstantesVitales.Controls.Add(Me.lblFrecuenciaCard)
        Me.gbConstantesVitales.Controls.Add(Me.cbPulso)
        Me.gbConstantesVitales.Controls.Add(Me.lblPulso)
        Me.gbConstantesVitales.Controls.Add(Me.lblTemperatura)
        Me.gbConstantesVitales.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbConstantesVitales.Location = New System.Drawing.Point(18, 444)
        Me.gbConstantesVitales.Name = "gbConstantesVitales"
        Me.gbConstantesVitales.Size = New System.Drawing.Size(1148, 151)
        Me.gbConstantesVitales.TabIndex = 33
        Me.gbConstantesVitales.TabStop = False
        Me.gbConstantesVitales.Text = "Constantes Vitales"
        '
        'lblSintoma1
        '
        Me.lblSintoma1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSintoma1.AutoSize = True
        Me.lblSintoma1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSintoma1.Location = New System.Drawing.Point(-38, 44)
        Me.lblSintoma1.Name = "lblSintoma1"
        Me.lblSintoma1.Size = New System.Drawing.Size(115, 29)
        Me.lblSintoma1.TabIndex = 19
        Me.lblSintoma1.Text = "Síntoma:"
        '
        'txtSintoma1
        '
        Me.txtSintoma1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSintoma1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSintoma1.Location = New System.Drawing.Point(83, 39)
        Me.txtSintoma1.Name = "txtSintoma1"
        Me.txtSintoma1.Size = New System.Drawing.Size(219, 30)
        Me.txtSintoma1.TabIndex = 20
        '
        'lblSintoma2
        '
        Me.lblSintoma2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSintoma2.AutoSize = True
        Me.lblSintoma2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSintoma2.Location = New System.Drawing.Point(357, 44)
        Me.lblSintoma2.Name = "lblSintoma2"
        Me.lblSintoma2.Size = New System.Drawing.Size(115, 29)
        Me.lblSintoma2.TabIndex = 21
        Me.lblSintoma2.Text = "Síntoma:"
        '
        'txtSintoma2
        '
        Me.txtSintoma2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSintoma2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSintoma2.Location = New System.Drawing.Point(478, 39)
        Me.txtSintoma2.Name = "txtSintoma2"
        Me.txtSintoma2.Size = New System.Drawing.Size(219, 30)
        Me.txtSintoma2.TabIndex = 22
        '
        'lblSintoma3
        '
        Me.lblSintoma3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSintoma3.AutoSize = True
        Me.lblSintoma3.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSintoma3.Location = New System.Drawing.Point(759, 42)
        Me.lblSintoma3.Name = "lblSintoma3"
        Me.lblSintoma3.Size = New System.Drawing.Size(115, 29)
        Me.lblSintoma3.TabIndex = 23
        Me.lblSintoma3.Text = "Síntoma:"
        '
        'txtSintoma3
        '
        Me.txtSintoma3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSintoma3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSintoma3.Location = New System.Drawing.Point(874, 39)
        Me.txtSintoma3.Name = "txtSintoma3"
        Me.txtSintoma3.Size = New System.Drawing.Size(219, 30)
        Me.txtSintoma3.TabIndex = 24
        '
        'gbSintomas
        '
        Me.gbSintomas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSintomas.Controls.Add(Me.txtSintoma3)
        Me.gbSintomas.Controls.Add(Me.lblSintoma3)
        Me.gbSintomas.Controls.Add(Me.txtSintoma2)
        Me.gbSintomas.Controls.Add(Me.lblSintoma2)
        Me.gbSintomas.Controls.Add(Me.txtSintoma1)
        Me.gbSintomas.Controls.Add(Me.lblSintoma1)
        Me.gbSintomas.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSintomas.Location = New System.Drawing.Point(18, 601)
        Me.gbSintomas.Name = "gbSintomas"
        Me.gbSintomas.Size = New System.Drawing.Size(1148, 100)
        Me.gbSintomas.TabIndex = 34
        Me.gbSintomas.TabStop = False
        Me.gbSintomas.Text = "Síntomas"
        '
        'txtMotivoConsulta
        '
        Me.txtMotivoConsulta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMotivoConsulta.Location = New System.Drawing.Point(6, 26)
        Me.txtMotivoConsulta.Multiline = True
        Me.txtMotivoConsulta.Name = "txtMotivoConsulta"
        Me.txtMotivoConsulta.Size = New System.Drawing.Size(1142, 157)
        Me.txtMotivoConsulta.TabIndex = 0
        '
        'gbMotivoConsulta
        '
        Me.gbMotivoConsulta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbMotivoConsulta.Controls.Add(Me.txtMotivoConsulta)
        Me.gbMotivoConsulta.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMotivoConsulta.Location = New System.Drawing.Point(12, 12)
        Me.gbMotivoConsulta.Name = "gbMotivoConsulta"
        Me.gbMotivoConsulta.Size = New System.Drawing.Size(1154, 202)
        Me.gbMotivoConsulta.TabIndex = 32
        Me.gbMotivoConsulta.TabStop = False
        Me.gbMotivoConsulta.Text = "Motivo de consulta"
        '
        'lblPacientePres
        '
        Me.lblPacientePres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPacientePres.AutoSize = True
        Me.lblPacientePres.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPacientePres.Location = New System.Drawing.Point(-21, 68)
        Me.lblPacientePres.Name = "lblPacientePres"
        Me.lblPacientePres.Size = New System.Drawing.Size(253, 29)
        Me.lblPacientePres.TabIndex = 19
        Me.lblPacientePres.Text = "El paciente presenta:"
        '
        'txtEnfermedad
        '
        Me.txtEnfermedad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEnfermedad.Enabled = False
        Me.txtEnfermedad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnfermedad.Location = New System.Drawing.Point(271, 64)
        Me.txtEnfermedad.Name = "txtEnfermedad"
        Me.txtEnfermedad.Size = New System.Drawing.Size(219, 30)
        Me.txtEnfermedad.TabIndex = 20
        '
        'chkPacienteEnfermo
        '
        Me.chkPacienteEnfermo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkPacienteEnfermo.AutoSize = True
        Me.chkPacienteEnfermo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPacienteEnfermo.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPacienteEnfermo.Location = New System.Drawing.Point(-22, 26)
        Me.chkPacienteEnfermo.Name = "chkPacienteEnfermo"
        Me.chkPacienteEnfermo.Size = New System.Drawing.Size(347, 33)
        Me.chkPacienteEnfermo.TabIndex = 21
        Me.chkPacienteEnfermo.Text = "¿El paciente está enfermo?"
        Me.chkPacienteEnfermo.UseVisualStyleBackColor = True
        '
        'lblNomAnalisis
        '
        Me.lblNomAnalisis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNomAnalisis.AutoSize = True
        Me.lblNomAnalisis.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomAnalisis.Location = New System.Drawing.Point(526, 68)
        Me.lblNomAnalisis.Name = "lblNomAnalisis"
        Me.lblNomAnalisis.Size = New System.Drawing.Size(247, 29)
        Me.lblNomAnalisis.TabIndex = 22
        Me.lblNomAnalisis.Text = "Nombre del análisis:"
        '
        'chkAnalisis
        '
        Me.chkAnalisis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkAnalisis.AutoSize = True
        Me.chkAnalisis.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAnalisis.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnalisis.Location = New System.Drawing.Point(521, 29)
        Me.chkAnalisis.Name = "chkAnalisis"
        Me.chkAnalisis.Size = New System.Drawing.Size(486, 33)
        Me.chkAnalisis.TabIndex = 24
        Me.chkAnalisis.Text = "¿El paciente debe solicitar un análisis?"
        Me.chkAnalisis.UseVisualStyleBackColor = True
        '
        'chkTratamiento
        '
        Me.chkTratamiento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkTratamiento.AutoSize = True
        Me.chkTratamiento.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTratamiento.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTratamiento.Location = New System.Drawing.Point(271, 121)
        Me.chkTratamiento.Name = "chkTratamiento"
        Me.chkTratamiento.Size = New System.Drawing.Size(508, 33)
        Me.chkTratamiento.TabIndex = 25
        Me.chkTratamiento.Text = "¿El paciente debe seguir un tratamiento?"
        Me.chkTratamiento.UseVisualStyleBackColor = True
        '
        'gbTratamiento
        '
        Me.gbTratamiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbTratamiento.Controls.Add(Me.txtTratamiento)
        Me.gbTratamiento.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTratamiento.Location = New System.Drawing.Point(6, 155)
        Me.gbTratamiento.Name = "gbTratamiento"
        Me.gbTratamiento.Size = New System.Drawing.Size(1082, 215)
        Me.gbTratamiento.TabIndex = 26
        Me.gbTratamiento.TabStop = False
        Me.gbTratamiento.Text = "Descripción del tratamiento"
        '
        'txtTratamiento
        '
        Me.txtTratamiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTratamiento.Enabled = False
        Me.txtTratamiento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTratamiento.Location = New System.Drawing.Point(9, 26)
        Me.txtTratamiento.Multiline = True
        Me.txtTratamiento.Name = "txtTratamiento"
        Me.txtTratamiento.Size = New System.Drawing.Size(1062, 176)
        Me.txtTratamiento.TabIndex = 2
        '
        'gbResolucion
        '
        Me.gbResolucion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.gbResolucion.Location = New System.Drawing.Point(18, 707)
        Me.gbResolucion.Name = "gbResolucion"
        Me.gbResolucion.Size = New System.Drawing.Size(1148, 383)
        Me.gbResolucion.TabIndex = 35
        Me.gbResolucion.TabStop = False
        Me.gbResolucion.Text = "Resolución"
        '
        'txtNomAnalisis
        '
        Me.txtNomAnalisis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNomAnalisis.Enabled = False
        Me.txtNomAnalisis.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomAnalisis.Location = New System.Drawing.Point(799, 65)
        Me.txtNomAnalisis.Name = "txtNomAnalisis"
        Me.txtNomAnalisis.Size = New System.Drawing.Size(219, 30)
        Me.txtNomAnalisis.TabIndex = 27
        '
        'btnPredictivo
        '
        Me.btnPredictivo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnPredictivo.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnPredictivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPredictivo.Location = New System.Drawing.Point(971, 33)
        Me.btnPredictivo.Name = "btnPredictivo"
        Me.btnPredictivo.Size = New System.Drawing.Size(171, 128)
        Me.btnPredictivo.TabIndex = 28
        Me.btnPredictivo.Text = "Diagnostico Predictivo"
        Me.btnPredictivo.UseVisualStyleBackColor = False
        '
        'frmGenerico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1193, 868)
        Me.Controls.Add(Me.gbResolucion)
        Me.Controls.Add(Me.gbConstantesVitales)
        Me.Controls.Add(Me.gbSintomas)
        Me.Controls.Add(Me.gbInspeccionGeneral)
        Me.Controls.Add(Me.gbMotivoConsulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGenerico"
        Me.Text = "frmGenerico"
        Me.gbInspeccionGeneral.ResumeLayout(False)
        Me.gbInspeccionGeneral.PerformLayout()
        Me.gbConstantesVitales.ResumeLayout(False)
        Me.gbConstantesVitales.PerformLayout()
        Me.gbSintomas.ResumeLayout(False)
        Me.gbSintomas.PerformLayout()
        Me.gbMotivoConsulta.ResumeLayout(False)
        Me.gbMotivoConsulta.PerformLayout()
        Me.gbTratamiento.ResumeLayout(False)
        Me.gbTratamiento.PerformLayout()
        Me.gbResolucion.ResumeLayout(False)
        Me.gbResolucion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblEConsciencia As Label
    Friend WithEvents cbEstadoConsciencia As ComboBox
    Friend WithEvents lblGradoColaboracion As Label
    Friend WithEvents cbGradoColab As ComboBox
    Friend WithEvents lblMovilidad As Label
    Friend WithEvents cbMovilidad As ComboBox
    Friend WithEvents lblActitud As Label
    Friend WithEvents cbActitud As ComboBox
    Friend WithEvents lblEstadoNutricion As Label
    Friend WithEvents cbENutricion As ComboBox
    Friend WithEvents lblGradoHidratacion As Label
    Friend WithEvents cbGradoHidr As ComboBox
    Friend WithEvents gbInspeccionGeneral As GroupBox
    Friend WithEvents lblTemperatura As Label
    Friend WithEvents lblPulso As Label
    Friend WithEvents cbPulso As ComboBox
    Friend WithEvents lblFrecuenciaCard As Label
    Friend WithEvents txtTemperatura As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtFrecuenciaCard As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents lblFrecuenciaResp As Label
    Friend WithEvents txtFrecuenciaResp As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents gbConstantesVitales As GroupBox
    Friend WithEvents lblSintoma1 As Label
    Friend WithEvents txtSintoma1 As TextBox
    Friend WithEvents lblSintoma2 As Label
    Friend WithEvents txtSintoma2 As TextBox
    Friend WithEvents lblSintoma3 As Label
    Friend WithEvents txtSintoma3 As TextBox
    Friend WithEvents gbSintomas As GroupBox
    Friend WithEvents txtMotivoConsulta As TextBox
    Friend WithEvents gbMotivoConsulta As GroupBox
    Friend WithEvents lblPacientePres As Label
    Friend WithEvents txtEnfermedad As TextBox
    Friend WithEvents chkPacienteEnfermo As CheckBox
    Friend WithEvents lblNomAnalisis As Label
    Friend WithEvents chkAnalisis As CheckBox
    Friend WithEvents chkTratamiento As CheckBox
    Friend WithEvents gbTratamiento As GroupBox
    Friend WithEvents txtTratamiento As TextBox
    Friend WithEvents gbResolucion As GroupBox
    Friend WithEvents txtNomAnalisis As TextBox
    Friend WithEvents btnPredictivo As Button
End Class
