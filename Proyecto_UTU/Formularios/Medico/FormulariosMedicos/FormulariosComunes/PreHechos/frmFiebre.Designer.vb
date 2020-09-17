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
        Me.Imprimir = New System.Drawing.Printing.PrintDocument()
        Me.pp = New System.Windows.Forms.PrintPreviewDialog()
        Me.txtFrecuenciaCard = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblFrecuenciaCard = New System.Windows.Forms.Label()
        Me.pnlContenedor.SuspendLayout()
        Me.gbPreguntas.SuspendLayout()
        Me.tblActitud.SuspendLayout()
        Me.tblNutricion.SuspendLayout()
        Me.tblPulso.SuspendLayout()
        Me.tblGradoHidratacion.SuspendLayout()
        Me.tblTemperatura.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.AutoScroll = True
        Me.pnlContenedor.Controls.Add(Me.gbPreguntas)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1334, 815)
        Me.pnlContenedor.TabIndex = 0
        '
        'gbPreguntas
        '
        Me.gbPreguntas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbPreguntas.Controls.Add(Me.txtFrecuenciaCard)
        Me.gbPreguntas.Controls.Add(Me.Label23)
        Me.gbPreguntas.Controls.Add(Me.lblFrecuenciaCard)
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
        Me.gbPreguntas.Location = New System.Drawing.Point(93, 7)
        Me.gbPreguntas.Name = "gbPreguntas"
        Me.gbPreguntas.Size = New System.Drawing.Size(1160, 796)
        Me.gbPreguntas.TabIndex = 56
        Me.gbPreguntas.TabStop = False
        '
        'chkSensoriales
        '
        Me.chkSensoriales.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSensoriales.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold)
        Me.chkSensoriales.Location = New System.Drawing.Point(17, 573)
        Me.chkSensoriales.Name = "chkSensoriales"
        Me.chkSensoriales.Size = New System.Drawing.Size(1134, 40)
        Me.chkSensoriales.TabIndex = 64
        Me.chkSensoriales.Tag = "p9"
        Me.chkSensoriales.Text = "¿El paciente presenta trastornos sensoriales?"
        Me.chkSensoriales.UseVisualStyleBackColor = True
        '
        'chkHumorales
        '
        Me.chkHumorales.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkHumorales.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold)
        Me.chkHumorales.Location = New System.Drawing.Point(17, 527)
        Me.chkHumorales.Name = "chkHumorales"
        Me.chkHumorales.Size = New System.Drawing.Size(1134, 40)
        Me.chkHumorales.TabIndex = 63
        Me.chkHumorales.Tag = "p8"
        Me.chkHumorales.Text = "¿El paciente presenta trastornos humorales?"
        Me.chkHumorales.UseVisualStyleBackColor = True
        '
        'chkDigestivos
        '
        Me.chkDigestivos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDigestivos.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold)
        Me.chkDigestivos.Location = New System.Drawing.Point(17, 481)
        Me.chkDigestivos.Name = "chkDigestivos"
        Me.chkDigestivos.Size = New System.Drawing.Size(1134, 40)
        Me.chkDigestivos.TabIndex = 62
        Me.chkDigestivos.Tag = "p7"
        Me.chkDigestivos.Text = "¿El paciente presenta trastornos digestivos?"
        Me.chkDigestivos.UseVisualStyleBackColor = True
        '
        'chkVacunas
        '
        Me.chkVacunas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkVacunas.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold)
        Me.chkVacunas.Location = New System.Drawing.Point(17, 435)
        Me.chkVacunas.Name = "chkVacunas"
        Me.chkVacunas.Size = New System.Drawing.Size(1134, 40)
        Me.chkVacunas.TabIndex = 61
        Me.chkVacunas.Tag = "p6"
        Me.chkVacunas.Text = "¿El paciente fue vacunado recientemente?"
        Me.chkVacunas.UseVisualStyleBackColor = True
        '
        'chkErupciones
        '
        Me.chkErupciones.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkErupciones.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold)
        Me.chkErupciones.Location = New System.Drawing.Point(17, 389)
        Me.chkErupciones.Name = "chkErupciones"
        Me.chkErupciones.Size = New System.Drawing.Size(1134, 40)
        Me.chkErupciones.TabIndex = 60
        Me.chkErupciones.Tag = "p5"
        Me.chkErupciones.Text = "¿El paciente manifiesta erupciones cutáneas?"
        Me.chkErupciones.UseVisualStyleBackColor = True
        '
        'chkCalor
        '
        Me.chkCalor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCalor.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold)
        Me.chkCalor.Location = New System.Drawing.Point(17, 343)
        Me.chkCalor.Name = "chkCalor"
        Me.chkCalor.Size = New System.Drawing.Size(1134, 40)
        Me.chkCalor.TabIndex = 59
        Me.chkCalor.Tag = "p4"
        Me.chkCalor.Text = "¿El paciente se expone al calor? / ¿Estuvo expuesto?"
        Me.chkCalor.UseVisualStyleBackColor = True
        '
        'chkMeds
        '
        Me.chkMeds.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMeds.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold)
        Me.chkMeds.Location = New System.Drawing.Point(17, 297)
        Me.chkMeds.Name = "chkMeds"
        Me.chkMeds.Size = New System.Drawing.Size(1134, 40)
        Me.chkMeds.TabIndex = 58
        Me.chkMeds.Tag = "p3"
        Me.chkMeds.Text = "¿El paciente toma medicamentos?"
        Me.chkMeds.UseVisualStyleBackColor = True
        '
        'chkDificultadesRespirar
        '
        Me.chkDificultadesRespirar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDificultadesRespirar.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold)
        Me.chkDificultadesRespirar.Location = New System.Drawing.Point(17, 251)
        Me.chkDificultadesRespirar.Name = "chkDificultadesRespirar"
        Me.chkDificultadesRespirar.Size = New System.Drawing.Size(1134, 40)
        Me.chkDificultadesRespirar.TabIndex = 57
        Me.chkDificultadesRespirar.Tag = "p2"
        Me.chkDificultadesRespirar.Text = "¿El paciente presenta dificultades para respirar?"
        Me.chkDificultadesRespirar.UseVisualStyleBackColor = True
        '
        'chkApendiceDolor
        '
        Me.chkApendiceDolor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkApendiceDolor.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold)
        Me.chkApendiceDolor.Location = New System.Drawing.Point(17, 205)
        Me.chkApendiceDolor.Name = "chkApendiceDolor"
        Me.chkApendiceDolor.Size = New System.Drawing.Size(1134, 40)
        Me.chkApendiceDolor.TabIndex = 28
        Me.chkApendiceDolor.Tag = "p1"
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
        Me.tblActitud.Location = New System.Drawing.Point(655, 21)
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
        Me.lblActitud.Tag = "p11"
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
        Me.cbActitud.Tag = "p12"
        '
        'tblNutricion
        '
        Me.tblNutricion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblNutricion.ColumnCount = 2
        Me.tblNutricion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234!))
        Me.tblNutricion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197.0!))
        Me.tblNutricion.Controls.Add(Me.lblENutricion, 0, 0)
        Me.tblNutricion.Controls.Add(Me.cbENutricion, 1, 0)
        Me.tblNutricion.Location = New System.Drawing.Point(655, 72)
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
        Me.lblENutricion.Tag = "p14"
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
        Me.cbENutricion.Tag = "p14"
        '
        'tblPulso
        '
        Me.tblPulso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblPulso.ColumnCount = 2
        Me.tblPulso.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234!))
        Me.tblPulso.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198.0!))
        Me.tblPulso.Controls.Add(Me.lblPulso, 0, 0)
        Me.tblPulso.Controls.Add(Me.cbPulso, 1, 0)
        Me.tblPulso.Location = New System.Drawing.Point(17, 72)
        Me.tblPulso.Name = "tblPulso"
        Me.tblPulso.RowCount = 1
        Me.tblPulso.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPulso.Size = New System.Drawing.Size(546, 37)
        Me.tblPulso.TabIndex = 51
        '
        'lblPulso
        '
        Me.lblPulso.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPulso.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPulso.Location = New System.Drawing.Point(3, 8)
        Me.lblPulso.Name = "lblPulso"
        Me.lblPulso.Size = New System.Drawing.Size(342, 29)
        Me.lblPulso.TabIndex = 24
        Me.lblPulso.Tag = "p13"
        Me.lblPulso.Text = "Pulso:"
        '
        'cbPulso
        '
        Me.cbPulso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbPulso.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPulso.FormattingEnabled = True
        Me.cbPulso.Items.AddRange(New Object() {"Fuerte", "Débil", "Filiforme"})
        Me.cbPulso.Location = New System.Drawing.Point(351, 3)
        Me.cbPulso.Name = "cbPulso"
        Me.cbPulso.Size = New System.Drawing.Size(192, 31)
        Me.cbPulso.TabIndex = 23
        Me.cbPulso.Tag = "p13"
        '
        'tblGradoHidratacion
        '
        Me.tblGradoHidratacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblGradoHidratacion.ColumnCount = 2
        Me.tblGradoHidratacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234!))
        Me.tblGradoHidratacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197.0!))
        Me.tblGradoHidratacion.Controls.Add(Me.lblGradoHidratacion, 0, 0)
        Me.tblGradoHidratacion.Controls.Add(Me.cbGradoHidr, 1, 0)
        Me.tblGradoHidratacion.Location = New System.Drawing.Point(655, 126)
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
        Me.lblGradoHidratacion.Tag = "p16"
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
        Me.cbGradoHidr.Tag = "p16"
        '
        'tblTemperatura
        '
        Me.tblTemperatura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblTemperatura.ColumnCount = 3
        Me.tblTemperatura.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.27646!))
        Me.tblTemperatura.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.72354!))
        Me.tblTemperatura.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.tblTemperatura.Controls.Add(Me.lblGrados, 2, 0)
        Me.tblTemperatura.Controls.Add(Me.lblTemperatura, 0, 0)
        Me.tblTemperatura.Controls.Add(Me.txtTemperatura, 1, 0)
        Me.tblTemperatura.Location = New System.Drawing.Point(17, 21)
        Me.tblTemperatura.Name = "tblTemperatura"
        Me.tblTemperatura.RowCount = 1
        Me.tblTemperatura.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTemperatura.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tblTemperatura.Size = New System.Drawing.Size(610, 37)
        Me.tblTemperatura.TabIndex = 43
        '
        'lblGrados
        '
        Me.lblGrados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGrados.AutoSize = True
        Me.lblGrados.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrados.Location = New System.Drawing.Point(566, 4)
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
        Me.lblTemperatura.Tag = "p10"
        Me.lblTemperatura.Text = "Temperatura:"
        '
        'txtTemperatura
        '
        Me.txtTemperatura.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtTemperatura.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemperatura.Location = New System.Drawing.Point(497, 3)
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.Size = New System.Drawing.Size(45, 30)
        Me.txtTemperatura.TabIndex = 3
        Me.txtTemperatura.Tag = "p10"
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
        'txtFrecuenciaCard
        '
        Me.txtFrecuenciaCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFrecuenciaCard.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrecuenciaCard.Location = New System.Drawing.Point(368, 133)
        Me.txtFrecuenciaCard.Name = "txtFrecuenciaCard"
        Me.txtFrecuenciaCard.Size = New System.Drawing.Size(191, 30)
        Me.txtFrecuenciaCard.TabIndex = 67
        Me.txtFrecuenciaCard.Tag = "p15"
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(568, 134)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(38, 18)
        Me.Label23.TabIndex = 66
        Me.Label23.Text = "ppm"
        '
        'lblFrecuenciaCard
        '
        Me.lblFrecuenciaCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFrecuenciaCard.AutoSize = True
        Me.lblFrecuenciaCard.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrecuenciaCard.Location = New System.Drawing.Point(20, 134)
        Me.lblFrecuenciaCard.Name = "lblFrecuenciaCard"
        Me.lblFrecuenciaCard.Size = New System.Drawing.Size(253, 29)
        Me.lblFrecuenciaCard.TabIndex = 65
        Me.lblFrecuenciaCard.Tag = "p15"
        Me.lblFrecuenciaCard.Text = "Frecuencia Cardíaca:"
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
        Me.gbPreguntas.ResumeLayout(False)
        Me.gbPreguntas.PerformLayout()
        Me.tblActitud.ResumeLayout(False)
        Me.tblNutricion.ResumeLayout(False)
        Me.tblPulso.ResumeLayout(False)
        Me.tblGradoHidratacion.ResumeLayout(False)
        Me.tblTemperatura.ResumeLayout(False)
        Me.tblTemperatura.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents Imprimir As Printing.PrintDocument
    Friend WithEvents pp As PrintPreviewDialog
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
    Friend WithEvents txtFrecuenciaCard As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents lblFrecuenciaCard As Label
End Class
