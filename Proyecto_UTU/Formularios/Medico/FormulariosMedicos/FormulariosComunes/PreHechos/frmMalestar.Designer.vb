<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMalestar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMalestar))
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.gbResolucion = New System.Windows.Forms.GroupBox()
        Me.btnPredictivo = New System.Windows.Forms.Button()
        Me.txtNomAnalisis = New System.Windows.Forms.TextBox()
        Me.gbTratamiento = New System.Windows.Forms.GroupBox()
        Me.txtTratamiento = New System.Windows.Forms.TextBox()
        Me.chkAnalisis = New System.Windows.Forms.CheckBox()
        Me.lblNomAnalisis = New System.Windows.Forms.Label()
        Me.gbPreguntas = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.tblGrHidr = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbGradoHidr = New System.Windows.Forms.ComboBox()
        Me.tblCambioDieta = New System.Windows.Forms.TableLayoutPanel()
        Me.chkCambioDieta_No = New System.Windows.Forms.CheckBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.chkCambioDieta_Si = New System.Windows.Forms.CheckBox()
        Me.tblDieta = New System.Windows.Forms.TableLayoutPanel()
        Me.txtDieta = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.tblTsens = New System.Windows.Forms.TableLayoutPanel()
        Me.chkT_Sens_No = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chkT_Sens_Si = New System.Windows.Forms.CheckBox()
        Me.txtTsensoriales = New System.Windows.Forms.TextBox()
        Me.tblActitud = New System.Windows.Forms.TableLayoutPanel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbActitud = New System.Windows.Forms.ComboBox()
        Me.tblENutricion = New System.Windows.Forms.TableLayoutPanel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cb_e_nutricion = New System.Windows.Forms.ComboBox()
        Me.tblTAliment = New System.Windows.Forms.TableLayoutPanel()
        Me.chkTAlimen_No = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.chkTAlimen_Si = New System.Windows.Forms.CheckBox()
        Me.txtDrugs = New System.Windows.Forms.TextBox()
        Me.tblPulso = New System.Windows.Forms.TableLayoutPanel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbPulso = New System.Windows.Forms.ComboBox()
        Me.tblDrogas = New System.Windows.Forms.TableLayoutPanel()
        Me.chkDrugs_No = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.chkDrugs_Si = New System.Windows.Forms.CheckBox()
        Me.txtDrogas = New System.Windows.Forms.TextBox()
        Me.tblOtrosProblemas = New System.Windows.Forms.TableLayoutPanel()
        Me.txtOtrosProblemas = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tblMedicina = New System.Windows.Forms.TableLayoutPanel()
        Me.txtMedicina = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tblViajes = New System.Windows.Forms.TableLayoutPanel()
        Me.chkViaje_No = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.chkViaje_Si = New System.Windows.Forms.CheckBox()
        Me.tblActividades = New System.Windows.Forms.TableLayoutPanel()
        Me.chkADiarias_No = New System.Windows.Forms.CheckBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.chkADiarias_Si = New System.Windows.Forms.CheckBox()
        Me.txtADiarias = New System.Windows.Forms.TextBox()
        Me.lblTitutloFRM = New System.Windows.Forms.Label()
        Me.Imprimir = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.pnlContenedor.SuspendLayout()
        Me.gbResolucion.SuspendLayout()
        Me.gbTratamiento.SuspendLayout()
        Me.gbPreguntas.SuspendLayout()
        Me.tblGrHidr.SuspendLayout()
        Me.tblCambioDieta.SuspendLayout()
        Me.tblDieta.SuspendLayout()
        Me.tblTsens.SuspendLayout()
        Me.tblActitud.SuspendLayout()
        Me.tblENutricion.SuspendLayout()
        Me.tblTAliment.SuspendLayout()
        Me.tblPulso.SuspendLayout()
        Me.tblDrogas.SuspendLayout()
        Me.tblOtrosProblemas.SuspendLayout()
        Me.tblMedicina.SuspendLayout()
        Me.tblViajes.SuspendLayout()
        Me.tblActividades.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.AutoScroll = True
        Me.pnlContenedor.Controls.Add(Me.gbResolucion)
        Me.pnlContenedor.Controls.Add(Me.gbPreguntas)
        Me.pnlContenedor.Controls.Add(Me.lblTitutloFRM)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1068, 673)
        Me.pnlContenedor.TabIndex = 0
        '
        'gbResolucion
        '
        Me.gbResolucion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbResolucion.Controls.Add(Me.btnPredictivo)
        Me.gbResolucion.Controls.Add(Me.txtNomAnalisis)
        Me.gbResolucion.Controls.Add(Me.gbTratamiento)
        Me.gbResolucion.Controls.Add(Me.chkAnalisis)
        Me.gbResolucion.Controls.Add(Me.lblNomAnalisis)
        Me.gbResolucion.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbResolucion.Location = New System.Drawing.Point(16, 625)
        Me.gbResolucion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbResolucion.Name = "gbResolucion"
        Me.gbResolucion.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbResolucion.Size = New System.Drawing.Size(1043, 318)
        Me.gbResolucion.TabIndex = 76
        Me.gbResolucion.TabStop = False
        Me.gbResolucion.Text = "Resolución"
        '
        'btnPredictivo
        '
        Me.btnPredictivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPredictivo.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnPredictivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPredictivo.Location = New System.Drawing.Point(617, 13)
        Me.btnPredictivo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPredictivo.Name = "btnPredictivo"
        Me.btnPredictivo.Size = New System.Drawing.Size(146, 81)
        Me.btnPredictivo.TabIndex = 29
        Me.btnPredictivo.Text = "Generar Diagnostico Predictivo"
        Me.btnPredictivo.UseVisualStyleBackColor = False
        '
        'txtNomAnalisis
        '
        Me.txtNomAnalisis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNomAnalisis.Enabled = False
        Me.txtNomAnalisis.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomAnalisis.Location = New System.Drawing.Point(429, 56)
        Me.txtNomAnalisis.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNomAnalisis.Name = "txtNomAnalisis"
        Me.txtNomAnalisis.Size = New System.Drawing.Size(165, 26)
        Me.txtNomAnalisis.TabIndex = 27
        '
        'gbTratamiento
        '
        Me.gbTratamiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbTratamiento.Controls.Add(Me.txtTratamiento)
        Me.gbTratamiento.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTratamiento.Location = New System.Drawing.Point(0, 85)
        Me.gbTratamiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbTratamiento.Name = "gbTratamiento"
        Me.gbTratamiento.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbTratamiento.Size = New System.Drawing.Size(1034, 228)
        Me.gbTratamiento.TabIndex = 26
        Me.gbTratamiento.TabStop = False
        Me.gbTratamiento.Text = "Descripción y diagnóstico"
        '
        'txtTratamiento
        '
        Me.txtTratamiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTratamiento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTratamiento.Location = New System.Drawing.Point(7, 27)
        Me.txtTratamiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTratamiento.Multiline = True
        Me.txtTratamiento.Name = "txtTratamiento"
        Me.txtTratamiento.Size = New System.Drawing.Size(1024, 197)
        Me.txtTratamiento.TabIndex = 2
        '
        'chkAnalisis
        '
        Me.chkAnalisis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkAnalisis.AutoSize = True
        Me.chkAnalisis.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAnalisis.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnalisis.Location = New System.Drawing.Point(220, 27)
        Me.chkAnalisis.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkAnalisis.Name = "chkAnalisis"
        Me.chkAnalisis.Size = New System.Drawing.Size(390, 26)
        Me.chkAnalisis.TabIndex = 24
        Me.chkAnalisis.Text = "¿El paciente debe solicitar un análisis?"
        Me.chkAnalisis.UseVisualStyleBackColor = True
        '
        'lblNomAnalisis
        '
        Me.lblNomAnalisis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNomAnalisis.AutoSize = True
        Me.lblNomAnalisis.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomAnalisis.Location = New System.Drawing.Point(224, 58)
        Me.lblNomAnalisis.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNomAnalisis.Name = "lblNomAnalisis"
        Me.lblNomAnalisis.Size = New System.Drawing.Size(199, 22)
        Me.lblNomAnalisis.TabIndex = 22
        Me.lblNomAnalisis.Text = "Nombre del análisis:"
        '
        'gbPreguntas
        '
        Me.gbPreguntas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbPreguntas.Controls.Add(Me.CheckBox1)
        Me.gbPreguntas.Controls.Add(Me.Label28)
        Me.gbPreguntas.Controls.Add(Me.txtDuracion)
        Me.gbPreguntas.Controls.Add(Me.tblGrHidr)
        Me.gbPreguntas.Controls.Add(Me.tblCambioDieta)
        Me.gbPreguntas.Controls.Add(Me.tblDieta)
        Me.gbPreguntas.Controls.Add(Me.tblTsens)
        Me.gbPreguntas.Controls.Add(Me.tblActitud)
        Me.gbPreguntas.Controls.Add(Me.tblENutricion)
        Me.gbPreguntas.Controls.Add(Me.tblTAliment)
        Me.gbPreguntas.Controls.Add(Me.tblPulso)
        Me.gbPreguntas.Controls.Add(Me.tblDrogas)
        Me.gbPreguntas.Controls.Add(Me.tblOtrosProblemas)
        Me.gbPreguntas.Controls.Add(Me.tblMedicina)
        Me.gbPreguntas.Controls.Add(Me.tblViajes)
        Me.gbPreguntas.Controls.Add(Me.tblActividades)
        Me.gbPreguntas.Location = New System.Drawing.Point(2, 28)
        Me.gbPreguntas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbPreguntas.Name = "gbPreguntas"
        Me.gbPreguntas.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbPreguntas.Size = New System.Drawing.Size(1043, 592)
        Me.gbPreguntas.TabIndex = 75
        Me.gbPreguntas.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold)
        Me.CheckBox1.Location = New System.Drawing.Point(72, 128)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(406, 27)
        Me.CheckBox1.TabIndex = 74
        Me.CheckBox1.Text = "¿El malestar es constante?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(74, 100)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(414, 22)
        Me.Label28.TabIndex = 73
        Me.Label28.Text = "¿Cuánto tiempo ha durado esta sensación?"
        '
        'txtDuracion
        '
        Me.txtDuracion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuracion.Location = New System.Drawing.Point(464, 98)
        Me.txtDuracion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDuracion.Multiline = True
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(516, 24)
        Me.txtDuracion.TabIndex = 7
        '
        'tblGrHidr
        '
        Me.tblGrHidr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblGrHidr.ColumnCount = 2
        Me.tblGrHidr.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234!))
        Me.tblGrHidr.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.tblGrHidr.Controls.Add(Me.Label9, 0, 0)
        Me.tblGrHidr.Controls.Add(Me.cbGradoHidr, 1, 0)
        Me.tblGrHidr.Location = New System.Drawing.Point(546, 17)
        Me.tblGrHidr.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tblGrHidr.Name = "tblGrHidr"
        Me.tblGrHidr.RowCount = 1
        Me.tblGrHidr.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblGrHidr.Size = New System.Drawing.Size(433, 30)
        Me.tblGrHidr.TabIndex = 72
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label9.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(2, 6)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(281, 24)
        Me.Label9.TabIndex = 2
        Me.Label9.Tag = "p3"
        Me.Label9.Text = "Grado de hidratación:"
        '
        'cbGradoHidr
        '
        Me.cbGradoHidr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbGradoHidr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGradoHidr.FormattingEnabled = True
        Me.cbGradoHidr.Items.AddRange(New Object() {"Hidratado", "Normohidratado", "Hiperhidratado", "Hipohidratado", "Deshidratado", "Rehidratado"})
        Me.cbGradoHidr.Location = New System.Drawing.Point(287, 2)
        Me.cbGradoHidr.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbGradoHidr.Name = "cbGradoHidr"
        Me.cbGradoHidr.Size = New System.Drawing.Size(144, 26)
        Me.cbGradoHidr.TabIndex = 13
        Me.cbGradoHidr.Tag = "r3"
        '
        'tblCambioDieta
        '
        Me.tblCambioDieta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblCambioDieta.ColumnCount = 3
        Me.tblCambioDieta.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.12304!))
        Me.tblCambioDieta.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.275805!))
        Me.tblCambioDieta.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.60115!))
        Me.tblCambioDieta.Controls.Add(Me.chkCambioDieta_No, 2, 0)
        Me.tblCambioDieta.Controls.Add(Me.Label32, 0, 0)
        Me.tblCambioDieta.Controls.Add(Me.chkCambioDieta_Si, 1, 0)
        Me.tblCambioDieta.Location = New System.Drawing.Point(66, 490)
        Me.tblCambioDieta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tblCambioDieta.Name = "tblCambioDieta"
        Me.tblCambioDieta.RowCount = 1
        Me.tblCambioDieta.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblCambioDieta.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tblCambioDieta.Size = New System.Drawing.Size(908, 28)
        Me.tblCambioDieta.TabIndex = 69
        '
        'chkCambioDieta_No
        '
        Me.chkCambioDieta_No.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkCambioDieta_No.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCambioDieta_No.Location = New System.Drawing.Point(431, 2)
        Me.chkCambioDieta_No.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkCambioDieta_No.Name = "chkCambioDieta_No"
        Me.chkCambioDieta_No.Size = New System.Drawing.Size(475, 24)
        Me.chkCambioDieta_No.TabIndex = 4
        Me.chkCambioDieta_No.Text = "No"
        Me.chkCambioDieta_No.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label32.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(2, 0)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(369, 28)
        Me.Label32.TabIndex = 5
        Me.Label32.Text = "¿Ha cambiado su dieta recientemente?"
        '
        'chkCambioDieta_Si
        '
        Me.chkCambioDieta_Si.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkCambioDieta_Si.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCambioDieta_Si.Location = New System.Drawing.Point(375, 2)
        Me.chkCambioDieta_Si.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkCambioDieta_Si.Name = "chkCambioDieta_Si"
        Me.chkCambioDieta_Si.Size = New System.Drawing.Size(52, 24)
        Me.chkCambioDieta_Si.TabIndex = 3
        Me.chkCambioDieta_Si.Text = "Si"
        Me.chkCambioDieta_Si.UseVisualStyleBackColor = True
        '
        'tblDieta
        '
        Me.tblDieta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblDieta.ColumnCount = 2
        Me.tblDieta.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.00494!))
        Me.tblDieta.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.99506!))
        Me.tblDieta.Controls.Add(Me.txtDieta, 0, 0)
        Me.tblDieta.Controls.Add(Me.Label31, 0, 0)
        Me.tblDieta.Location = New System.Drawing.Point(66, 522)
        Me.tblDieta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tblDieta.Name = "tblDieta"
        Me.tblDieta.RowCount = 1
        Me.tblDieta.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblDieta.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tblDieta.Size = New System.Drawing.Size(910, 28)
        Me.tblDieta.TabIndex = 71
        '
        'txtDieta
        '
        Me.txtDieta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDieta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDieta.Location = New System.Drawing.Point(193, 2)
        Me.txtDieta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDieta.Multiline = True
        Me.txtDieta.Name = "txtDieta"
        Me.txtDieta.Size = New System.Drawing.Size(715, 24)
        Me.txtDieta.TabIndex = 7
        '
        'Label31
        '
        Me.Label31.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label31.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(2, 3)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(187, 25)
        Me.Label31.TabIndex = 5
        Me.Label31.Text = "Dieta del paciente:"
        '
        'tblTsens
        '
        Me.tblTsens.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblTsens.ColumnCount = 4
        Me.tblTsens.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.17789!))
        Me.tblTsens.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.275731!))
        Me.tblTsens.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.54638!))
        Me.tblTsens.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 356.0!))
        Me.tblTsens.Controls.Add(Me.chkT_Sens_No, 2, 0)
        Me.tblTsens.Controls.Add(Me.Label18, 0, 0)
        Me.tblTsens.Controls.Add(Me.chkT_Sens_Si, 1, 0)
        Me.tblTsens.Controls.Add(Me.txtTsensoriales, 3, 0)
        Me.tblTsens.Location = New System.Drawing.Point(66, 555)
        Me.tblTsens.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tblTsens.Name = "tblTsens"
        Me.tblTsens.RowCount = 1
        Me.tblTsens.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTsens.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tblTsens.Size = New System.Drawing.Size(910, 28)
        Me.tblTsens.TabIndex = 68
        '
        'chkT_Sens_No
        '
        Me.chkT_Sens_No.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkT_Sens_No.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkT_Sens_No.Location = New System.Drawing.Point(497, 2)
        Me.chkT_Sens_No.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkT_Sens_No.Name = "chkT_Sens_No"
        Me.chkT_Sens_No.Size = New System.Drawing.Size(54, 24)
        Me.chkT_Sens_No.TabIndex = 4
        Me.chkT_Sens_No.Text = "No"
        Me.chkT_Sens_No.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label18.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(2, 0)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(438, 28)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "¿El paciente presenta trastornos sensoriales?"
        '
        'chkT_Sens_Si
        '
        Me.chkT_Sens_Si.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkT_Sens_Si.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkT_Sens_Si.Location = New System.Drawing.Point(446, 2)
        Me.chkT_Sens_Si.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkT_Sens_Si.Name = "chkT_Sens_Si"
        Me.chkT_Sens_Si.Size = New System.Drawing.Size(47, 24)
        Me.chkT_Sens_Si.TabIndex = 3
        Me.chkT_Sens_Si.Text = "Si"
        Me.chkT_Sens_Si.UseVisualStyleBackColor = True
        '
        'txtTsensoriales
        '
        Me.txtTsensoriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTsensoriales.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTsensoriales.Location = New System.Drawing.Point(555, 2)
        Me.txtTsensoriales.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTsensoriales.Multiline = True
        Me.txtTsensoriales.Name = "txtTsensoriales"
        Me.txtTsensoriales.Size = New System.Drawing.Size(353, 24)
        Me.txtTsensoriales.TabIndex = 6
        '
        'tblActitud
        '
        Me.tblActitud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblActitud.ColumnCount = 2
        Me.tblActitud.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234!))
        Me.tblActitud.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.tblActitud.Controls.Add(Me.Label16, 0, 0)
        Me.tblActitud.Controls.Add(Me.cbActitud, 1, 0)
        Me.tblActitud.Location = New System.Drawing.Point(72, 52)
        Me.tblActitud.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tblActitud.Name = "tblActitud"
        Me.tblActitud.RowCount = 1
        Me.tblActitud.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblActitud.Size = New System.Drawing.Size(374, 30)
        Me.tblActitud.TabIndex = 70
        '
        'Label16
        '
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label16.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(2, 2)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(222, 28)
        Me.Label16.TabIndex = 41
        Me.Label16.Tag = "p2"
        Me.Label16.Text = "Actitud:"
        '
        'cbActitud
        '
        Me.cbActitud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbActitud.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbActitud.FormattingEnabled = True
        Me.cbActitud.Items.AddRange(New Object() {"Apatía", "Coma", "Excitación", "Desmotivación", "Desinterés", "Otro"})
        Me.cbActitud.Location = New System.Drawing.Point(228, 2)
        Me.cbActitud.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbActitud.Name = "cbActitud"
        Me.cbActitud.Size = New System.Drawing.Size(144, 26)
        Me.cbActitud.TabIndex = 41
        Me.cbActitud.Tag = "r2"
        '
        'tblENutricion
        '
        Me.tblENutricion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblENutricion.ColumnCount = 2
        Me.tblENutricion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234!))
        Me.tblENutricion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.tblENutricion.Controls.Add(Me.Label17, 0, 0)
        Me.tblENutricion.Controls.Add(Me.cb_e_nutricion, 1, 0)
        Me.tblENutricion.Location = New System.Drawing.Point(546, 52)
        Me.tblENutricion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tblENutricion.Name = "tblENutricion"
        Me.tblENutricion.RowCount = 1
        Me.tblENutricion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblENutricion.Size = New System.Drawing.Size(433, 30)
        Me.tblENutricion.TabIndex = 69
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label17.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(2, 2)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(281, 28)
        Me.Label17.TabIndex = 2
        Me.Label17.Tag = "p4"
        Me.Label17.Text = "Estado de nutrición:"
        '
        'cb_e_nutricion
        '
        Me.cb_e_nutricion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cb_e_nutricion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_e_nutricion.FormattingEnabled = True
        Me.cb_e_nutricion.Items.AddRange(New Object() {"Obesidad", "Anorexia", "Caquexia", "Peso normal"})
        Me.cb_e_nutricion.Location = New System.Drawing.Point(287, 2)
        Me.cb_e_nutricion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cb_e_nutricion.Name = "cb_e_nutricion"
        Me.cb_e_nutricion.Size = New System.Drawing.Size(144, 26)
        Me.cb_e_nutricion.TabIndex = 38
        Me.cb_e_nutricion.Tag = "r4"
        '
        'tblTAliment
        '
        Me.tblTAliment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblTAliment.ColumnCount = 4
        Me.tblTAliment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.52287!))
        Me.tblTAliment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.150327!))
        Me.tblTAliment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.35857!))
        Me.tblTAliment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 339.0!))
        Me.tblTAliment.Controls.Add(Me.chkTAlimen_No, 2, 0)
        Me.tblTAliment.Controls.Add(Me.Label19, 0, 0)
        Me.tblTAliment.Controls.Add(Me.chkTAlimen_Si, 1, 0)
        Me.tblTAliment.Controls.Add(Me.txtDrugs, 3, 0)
        Me.tblTAliment.Location = New System.Drawing.Point(66, 457)
        Me.tblTAliment.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tblTAliment.Name = "tblTAliment"
        Me.tblTAliment.RowCount = 1
        Me.tblTAliment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTAliment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tblTAliment.Size = New System.Drawing.Size(910, 28)
        Me.tblTAliment.TabIndex = 67
        '
        'chkTAlimen_No
        '
        Me.chkTAlimen_No.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkTAlimen_No.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTAlimen_No.Location = New System.Drawing.Point(513, 2)
        Me.chkTAlimen_No.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkTAlimen_No.Name = "chkTAlimen_No"
        Me.chkTAlimen_No.Size = New System.Drawing.Size(55, 24)
        Me.chkTAlimen_No.TabIndex = 4
        Me.chkTAlimen_No.Text = "No"
        Me.chkTAlimen_No.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label19.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(2, 0)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(441, 28)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "¿El paciente presenta trastornos alimenticios?"
        '
        'chkTAlimen_Si
        '
        Me.chkTAlimen_Si.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkTAlimen_Si.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTAlimen_Si.Location = New System.Drawing.Point(461, 2)
        Me.chkTAlimen_Si.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkTAlimen_Si.Name = "chkTAlimen_Si"
        Me.chkTAlimen_Si.Size = New System.Drawing.Size(48, 24)
        Me.chkTAlimen_Si.TabIndex = 3
        Me.chkTAlimen_Si.Text = "Si"
        Me.chkTAlimen_Si.UseVisualStyleBackColor = True
        '
        'txtDrugs
        '
        Me.txtDrugs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDrugs.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrugs.Location = New System.Drawing.Point(572, 2)
        Me.txtDrugs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDrugs.Multiline = True
        Me.txtDrugs.Name = "txtDrugs"
        Me.txtDrugs.Size = New System.Drawing.Size(336, 24)
        Me.txtDrugs.TabIndex = 6
        '
        'tblPulso
        '
        Me.tblPulso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblPulso.ColumnCount = 2
        Me.tblPulso.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234!))
        Me.tblPulso.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.tblPulso.Controls.Add(Me.Label21, 0, 0)
        Me.tblPulso.Controls.Add(Me.cbPulso, 1, 0)
        Me.tblPulso.Location = New System.Drawing.Point(72, 17)
        Me.tblPulso.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tblPulso.Name = "tblPulso"
        Me.tblPulso.RowCount = 1
        Me.tblPulso.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPulso.Size = New System.Drawing.Size(374, 30)
        Me.tblPulso.TabIndex = 65
        '
        'Label21
        '
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label21.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(2, 6)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(222, 24)
        Me.Label21.TabIndex = 24
        Me.Label21.Tag = "p1"
        Me.Label21.Text = "Pulso:"
        '
        'cbPulso
        '
        Me.cbPulso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbPulso.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPulso.FormattingEnabled = True
        Me.cbPulso.Items.AddRange(New Object() {"Fuerte", "Débil", "Filiforme"})
        Me.cbPulso.Location = New System.Drawing.Point(228, 2)
        Me.cbPulso.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbPulso.Name = "cbPulso"
        Me.cbPulso.Size = New System.Drawing.Size(144, 26)
        Me.cbPulso.TabIndex = 23
        Me.cbPulso.Tag = "r1"
        '
        'tblDrogas
        '
        Me.tblDrogas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblDrogas.ColumnCount = 4
        Me.tblDrogas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.74803!))
        Me.tblDrogas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.1811!))
        Me.tblDrogas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.07087!))
        Me.tblDrogas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 429.0!))
        Me.tblDrogas.Controls.Add(Me.chkDrugs_No, 2, 0)
        Me.tblDrogas.Controls.Add(Me.Label20, 0, 0)
        Me.tblDrogas.Controls.Add(Me.chkDrugs_Si, 1, 0)
        Me.tblDrogas.Controls.Add(Me.txtDrogas, 3, 0)
        Me.tblDrogas.Location = New System.Drawing.Point(66, 424)
        Me.tblDrogas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tblDrogas.Name = "tblDrogas"
        Me.tblDrogas.RowCount = 1
        Me.tblDrogas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblDrogas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tblDrogas.Size = New System.Drawing.Size(910, 28)
        Me.tblDrogas.TabIndex = 66
        '
        'chkDrugs_No
        '
        Me.chkDrugs_No.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkDrugs_No.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDrugs_No.Location = New System.Drawing.Point(419, 2)
        Me.chkDrugs_No.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDrugs_No.Name = "chkDrugs_No"
        Me.chkDrugs_No.Size = New System.Drawing.Size(58, 24)
        Me.chkDrugs_No.TabIndex = 4
        Me.chkDrugs_No.Text = "No"
        Me.chkDrugs_No.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label20.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(2, 0)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(337, 28)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "¿Consume alcohol u otras drogas?"
        '
        'chkDrugs_Si
        '
        Me.chkDrugs_Si.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkDrugs_Si.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDrugs_Si.Location = New System.Drawing.Point(366, 2)
        Me.chkDrugs_Si.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDrugs_Si.Name = "chkDrugs_Si"
        Me.chkDrugs_Si.Size = New System.Drawing.Size(49, 24)
        Me.chkDrugs_Si.TabIndex = 3
        Me.chkDrugs_Si.Text = "Si"
        Me.chkDrugs_Si.UseVisualStyleBackColor = True
        '
        'txtDrogas
        '
        Me.txtDrogas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDrogas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrogas.Location = New System.Drawing.Point(481, 2)
        Me.txtDrogas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDrogas.Multiline = True
        Me.txtDrogas.Name = "txtDrogas"
        Me.txtDrogas.Size = New System.Drawing.Size(427, 24)
        Me.txtDrogas.TabIndex = 6
        '
        'tblOtrosProblemas
        '
        Me.tblOtrosProblemas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblOtrosProblemas.ColumnCount = 2
        Me.tblOtrosProblemas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.00988!))
        Me.tblOtrosProblemas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.99012!))
        Me.tblOtrosProblemas.Controls.Add(Me.txtOtrosProblemas, 0, 0)
        Me.tblOtrosProblemas.Controls.Add(Me.Label22, 0, 0)
        Me.tblOtrosProblemas.Location = New System.Drawing.Point(66, 392)
        Me.tblOtrosProblemas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tblOtrosProblemas.Name = "tblOtrosProblemas"
        Me.tblOtrosProblemas.RowCount = 1
        Me.tblOtrosProblemas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblOtrosProblemas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tblOtrosProblemas.Size = New System.Drawing.Size(910, 28)
        Me.tblOtrosProblemas.TabIndex = 64
        '
        'txtOtrosProblemas
        '
        Me.txtOtrosProblemas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOtrosProblemas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtrosProblemas.Location = New System.Drawing.Point(384, 2)
        Me.txtOtrosProblemas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtOtrosProblemas.Multiline = True
        Me.txtOtrosProblemas.Name = "txtOtrosProblemas"
        Me.txtOtrosProblemas.Size = New System.Drawing.Size(524, 24)
        Me.txtOtrosProblemas.TabIndex = 7
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label22.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(2, 0)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(364, 28)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "¿Qué otros problemas de salud tiene?"
        '
        'tblMedicina
        '
        Me.tblMedicina.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblMedicina.ColumnCount = 2
        Me.tblMedicina.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.09061!))
        Me.tblMedicina.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.90939!))
        Me.tblMedicina.Controls.Add(Me.txtMedicina, 0, 0)
        Me.tblMedicina.Controls.Add(Me.Label24, 0, 0)
        Me.tblMedicina.Location = New System.Drawing.Point(66, 359)
        Me.tblMedicina.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tblMedicina.Name = "tblMedicina"
        Me.tblMedicina.RowCount = 1
        Me.tblMedicina.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMedicina.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tblMedicina.Size = New System.Drawing.Size(910, 28)
        Me.tblMedicina.TabIndex = 62
        '
        'txtMedicina
        '
        Me.txtMedicina.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMedicina.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedicina.Location = New System.Drawing.Point(321, 2)
        Me.txtMedicina.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMedicina.Multiline = True
        Me.txtMedicina.Name = "txtMedicina"
        Me.txtMedicina.Size = New System.Drawing.Size(587, 24)
        Me.txtMedicina.TabIndex = 7
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label24.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(2, 0)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(303, 28)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "¿Qué medicinas está tomando?"
        '
        'tblViajes
        '
        Me.tblViajes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblViajes.ColumnCount = 3
        Me.tblViajes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.62675!))
        Me.tblViajes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.780347!))
        Me.tblViajes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5929!))
        Me.tblViajes.Controls.Add(Me.chkViaje_No, 2, 0)
        Me.tblViajes.Controls.Add(Me.Label25, 0, 0)
        Me.tblViajes.Controls.Add(Me.chkViaje_Si, 1, 0)
        Me.tblViajes.Location = New System.Drawing.Point(66, 327)
        Me.tblViajes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tblViajes.Name = "tblViajes"
        Me.tblViajes.RowCount = 1
        Me.tblViajes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblViajes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tblViajes.Size = New System.Drawing.Size(908, 28)
        Me.tblViajes.TabIndex = 61
        '
        'chkViaje_No
        '
        Me.chkViaje_No.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkViaje_No.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkViaje_No.Location = New System.Drawing.Point(341, 2)
        Me.chkViaje_No.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkViaje_No.Name = "chkViaje_No"
        Me.chkViaje_No.Size = New System.Drawing.Size(565, 24)
        Me.chkViaje_No.TabIndex = 4
        Me.chkViaje_No.Text = "No"
        Me.chkViaje_No.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label25.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(2, 0)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(267, 28)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "¿Ha viajado recientemente?"
        '
        'chkViaje_Si
        '
        Me.chkViaje_Si.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkViaje_Si.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkViaje_Si.Location = New System.Drawing.Point(289, 2)
        Me.chkViaje_Si.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkViaje_Si.Name = "chkViaje_Si"
        Me.chkViaje_Si.Size = New System.Drawing.Size(48, 24)
        Me.chkViaje_Si.TabIndex = 3
        Me.chkViaje_Si.Text = "Si"
        Me.chkViaje_Si.UseVisualStyleBackColor = True
        '
        'tblActividades
        '
        Me.tblActividades.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblActividades.ColumnCount = 4
        Me.tblActividades.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.00986!))
        Me.tblActividades.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.903353!))
        Me.tblActividades.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.086785!))
        Me.tblActividades.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tblActividades.Controls.Add(Me.chkADiarias_No, 2, 0)
        Me.tblActividades.Controls.Add(Me.Label26, 0, 0)
        Me.tblActividades.Controls.Add(Me.chkADiarias_Si, 1, 0)
        Me.tblActividades.Controls.Add(Me.txtADiarias, 3, 0)
        Me.tblActividades.Location = New System.Drawing.Point(66, 294)
        Me.tblActividades.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tblActividades.Name = "tblActividades"
        Me.tblActividades.RowCount = 1
        Me.tblActividades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblActividades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tblActividades.Size = New System.Drawing.Size(910, 28)
        Me.tblActividades.TabIndex = 60
        '
        'chkADiarias_No
        '
        Me.chkADiarias_No.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkADiarias_No.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkADiarias_No.Location = New System.Drawing.Point(700, 2)
        Me.chkADiarias_No.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkADiarias_No.Name = "chkADiarias_No"
        Me.chkADiarias_No.Size = New System.Drawing.Size(57, 24)
        Me.chkADiarias_No.TabIndex = 4
        Me.chkADiarias_No.Text = "No"
        Me.chkADiarias_No.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(2, 0)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(626, 22)
        Me.Label26.TabIndex = 5
        Me.Label26.Text = "¿Puede cumplir con sus actividades diarias? Si no, ¿Qué lo limita?"
        '
        'chkADiarias_Si
        '
        Me.chkADiarias_Si.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkADiarias_Si.Location = New System.Drawing.Point(648, 2)
        Me.chkADiarias_Si.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkADiarias_Si.Name = "chkADiarias_Si"
        Me.chkADiarias_Si.Size = New System.Drawing.Size(48, 23)
        Me.chkADiarias_Si.TabIndex = 3
        Me.chkADiarias_Si.Text = "Si"
        Me.chkADiarias_Si.UseVisualStyleBackColor = True
        '
        'txtADiarias
        '
        Me.txtADiarias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtADiarias.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtADiarias.Location = New System.Drawing.Point(761, 2)
        Me.txtADiarias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtADiarias.Multiline = True
        Me.txtADiarias.Name = "txtADiarias"
        Me.txtADiarias.Size = New System.Drawing.Size(147, 24)
        Me.txtADiarias.TabIndex = 6
        '
        'lblTitutloFRM
        '
        Me.lblTitutloFRM.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitutloFRM.AutoSize = True
        Me.lblTitutloFRM.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitutloFRM.Location = New System.Drawing.Point(216, -1)
        Me.lblTitutloFRM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitutloFRM.Name = "lblTitutloFRM"
        Me.lblTitutloFRM.Size = New System.Drawing.Size(548, 26)
        Me.lblTitutloFRM.TabIndex = 74
        Me.lblTitutloFRM.Text = "Formulario de entrevista para paciente con malestar"
        Me.lblTitutloFRM.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Imprimir
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmMalestar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1068, 673)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmMalestar"
        Me.Text = "frmMalestar"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.gbResolucion.ResumeLayout(False)
        Me.gbResolucion.PerformLayout()
        Me.gbTratamiento.ResumeLayout(False)
        Me.gbTratamiento.PerformLayout()
        Me.gbPreguntas.ResumeLayout(False)
        Me.gbPreguntas.PerformLayout()
        Me.tblGrHidr.ResumeLayout(False)
        Me.tblCambioDieta.ResumeLayout(False)
        Me.tblCambioDieta.PerformLayout()
        Me.tblDieta.ResumeLayout(False)
        Me.tblDieta.PerformLayout()
        Me.tblTsens.ResumeLayout(False)
        Me.tblTsens.PerformLayout()
        Me.tblActitud.ResumeLayout(False)
        Me.tblENutricion.ResumeLayout(False)
        Me.tblTAliment.ResumeLayout(False)
        Me.tblTAliment.PerformLayout()
        Me.tblPulso.ResumeLayout(False)
        Me.tblDrogas.ResumeLayout(False)
        Me.tblDrogas.PerformLayout()
        Me.tblOtrosProblemas.ResumeLayout(False)
        Me.tblOtrosProblemas.PerformLayout()
        Me.tblMedicina.ResumeLayout(False)
        Me.tblMedicina.PerformLayout()
        Me.tblViajes.ResumeLayout(False)
        Me.tblViajes.PerformLayout()
        Me.tblActividades.ResumeLayout(False)
        Me.tblActividades.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents gbResolucion As GroupBox
    Friend WithEvents txtNomAnalisis As TextBox
    Friend WithEvents gbTratamiento As GroupBox
    Friend WithEvents txtTratamiento As TextBox
    Friend WithEvents chkAnalisis As CheckBox
    Friend WithEvents lblNomAnalisis As Label
    Friend WithEvents gbPreguntas As GroupBox
    Friend WithEvents tblGrHidr As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents cbGradoHidr As ComboBox
    Friend WithEvents tblCambioDieta As TableLayoutPanel
    Friend WithEvents chkCambioDieta_No As CheckBox
    Friend WithEvents Label32 As Label
    Friend WithEvents chkCambioDieta_Si As CheckBox
    Friend WithEvents tblDieta As TableLayoutPanel
    Friend WithEvents txtDieta As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents tblTsens As TableLayoutPanel
    Friend WithEvents chkT_Sens_No As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents chkT_Sens_Si As CheckBox
    Friend WithEvents txtTsensoriales As TextBox
    Friend WithEvents tblActitud As TableLayoutPanel
    Friend WithEvents Label16 As Label
    Friend WithEvents cbActitud As ComboBox
    Friend WithEvents tblENutricion As TableLayoutPanel
    Friend WithEvents Label17 As Label
    Friend WithEvents cb_e_nutricion As ComboBox
    Friend WithEvents tblTAliment As TableLayoutPanel
    Friend WithEvents chkTAlimen_No As CheckBox
    Friend WithEvents Label19 As Label
    Friend WithEvents chkTAlimen_Si As CheckBox
    Friend WithEvents txtDrugs As TextBox
    Friend WithEvents tblPulso As TableLayoutPanel
    Friend WithEvents Label21 As Label
    Friend WithEvents cbPulso As ComboBox
    Friend WithEvents tblDrogas As TableLayoutPanel
    Friend WithEvents chkDrugs_No As CheckBox
    Friend WithEvents Label20 As Label
    Friend WithEvents chkDrugs_Si As CheckBox
    Friend WithEvents txtDrogas As TextBox
    Friend WithEvents tblOtrosProblemas As TableLayoutPanel
    Friend WithEvents txtOtrosProblemas As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents tblMedicina As TableLayoutPanel
    Friend WithEvents txtMedicina As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents tblViajes As TableLayoutPanel
    Friend WithEvents chkViaje_No As CheckBox
    Friend WithEvents Label25 As Label
    Friend WithEvents chkViaje_Si As CheckBox
    Friend WithEvents tblActividades As TableLayoutPanel
    Friend WithEvents chkADiarias_No As CheckBox
    Friend WithEvents Label26 As Label
    Friend WithEvents chkADiarias_Si As CheckBox
    Friend WithEvents txtADiarias As TextBox
    Friend WithEvents txtDuracion As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents lblTitutloFRM As Label
    Friend WithEvents Imprimir As Printing.PrintDocument
    Friend WithEvents btnPredictivo As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label28 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
