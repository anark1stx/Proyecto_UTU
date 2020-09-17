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
        Me.gbPreguntas = New System.Windows.Forms.GroupBox()
        Me.chkTS = New System.Windows.Forms.CheckBox()
        Me.txtDieta = New System.Windows.Forms.TextBox()
        Me.chkCambioDieta = New System.Windows.Forms.CheckBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtDrugs = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkViajo = New System.Windows.Forms.CheckBox()
        Me.chkMalestarConstante = New System.Windows.Forms.CheckBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtADiarias = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.tblGrHidr = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbGradoHidr = New System.Windows.Forms.ComboBox()
        Me.tblActitud = New System.Windows.Forms.TableLayoutPanel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbActitud = New System.Windows.Forms.ComboBox()
        Me.tblENutricion = New System.Windows.Forms.TableLayoutPanel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cb_e_nutricion = New System.Windows.Forms.ComboBox()
        Me.tblPulso = New System.Windows.Forms.TableLayoutPanel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbPulso = New System.Windows.Forms.ComboBox()
        Me.lblTitutloFRM = New System.Windows.Forms.Label()
        Me.Imprimir = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.pnlContenedor.SuspendLayout()
        Me.gbPreguntas.SuspendLayout()
        Me.tblGrHidr.SuspendLayout()
        Me.tblActitud.SuspendLayout()
        Me.tblENutricion.SuspendLayout()
        Me.tblPulso.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.AutoScroll = True
        Me.pnlContenedor.Controls.Add(Me.gbPreguntas)
        Me.pnlContenedor.Controls.Add(Me.lblTitutloFRM)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1424, 828)
        Me.pnlContenedor.TabIndex = 0
        '
        'gbPreguntas
        '
        Me.gbPreguntas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbPreguntas.Controls.Add(Me.chkTS)
        Me.gbPreguntas.Controls.Add(Me.txtDieta)
        Me.gbPreguntas.Controls.Add(Me.chkCambioDieta)
        Me.gbPreguntas.Controls.Add(Me.Label31)
        Me.gbPreguntas.Controls.Add(Me.TextBox3)
        Me.gbPreguntas.Controls.Add(Me.Label32)
        Me.gbPreguntas.Controls.Add(Me.Label19)
        Me.gbPreguntas.Controls.Add(Me.txtDrugs)
        Me.gbPreguntas.Controls.Add(Me.Label3)
        Me.gbPreguntas.Controls.Add(Me.TextBox2)
        Me.gbPreguntas.Controls.Add(Me.Label2)
        Me.gbPreguntas.Controls.Add(Me.TextBox1)
        Me.gbPreguntas.Controls.Add(Me.Label1)
        Me.gbPreguntas.Controls.Add(Me.chkViajo)
        Me.gbPreguntas.Controls.Add(Me.chkMalestarConstante)
        Me.gbPreguntas.Controls.Add(Me.Label26)
        Me.gbPreguntas.Controls.Add(Me.txtADiarias)
        Me.gbPreguntas.Controls.Add(Me.Label28)
        Me.gbPreguntas.Controls.Add(Me.txtDuracion)
        Me.gbPreguntas.Controls.Add(Me.tblGrHidr)
        Me.gbPreguntas.Controls.Add(Me.tblActitud)
        Me.gbPreguntas.Controls.Add(Me.tblENutricion)
        Me.gbPreguntas.Controls.Add(Me.tblPulso)
        Me.gbPreguntas.Location = New System.Drawing.Point(14, 34)
        Me.gbPreguntas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbPreguntas.Name = "gbPreguntas"
        Me.gbPreguntas.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbPreguntas.Size = New System.Drawing.Size(1391, 783)
        Me.gbPreguntas.TabIndex = 75
        Me.gbPreguntas.TabStop = False
        '
        'chkTS
        '
        Me.chkTS.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkTS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTS.Location = New System.Drawing.Point(95, 703)
        Me.chkTS.Name = "chkTS"
        Me.chkTS.Size = New System.Drawing.Size(1211, 33)
        Me.chkTS.TabIndex = 83
        Me.chkTS.Tag = "p16"
        Me.chkTS.Text = "¿El paciente presenta trastornos sensoriales?"
        Me.chkTS.UseVisualStyleBackColor = True
        '
        'txtDieta
        '
        Me.txtDieta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDieta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDieta.Location = New System.Drawing.Point(329, 651)
        Me.txtDieta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDieta.Multiline = True
        Me.txtDieta.Name = "txtDieta"
        Me.txtDieta.Size = New System.Drawing.Size(977, 29)
        Me.txtDieta.TabIndex = 7
        Me.txtDieta.Tag = "p15"
        '
        'chkCambioDieta
        '
        Me.chkCambioDieta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkCambioDieta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCambioDieta.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCambioDieta.Location = New System.Drawing.Point(98, 594)
        Me.chkCambioDieta.Name = "chkCambioDieta"
        Me.chkCambioDieta.Size = New System.Drawing.Size(1208, 46)
        Me.chkCambioDieta.TabIndex = 82
        Me.chkCambioDieta.Tag = "p14"
        Me.chkCambioDieta.Text = "¿Ha cambiado su dieta recientemente?"
        Me.chkCambioDieta.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(99, 651)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(224, 29)
        Me.Label31.TabIndex = 5
        Me.Label31.Tag = "p15"
        Me.Label31.Text = "Dieta del paciente:"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(523, 492)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(783, 30)
        Me.TextBox3.TabIndex = 81
        Me.TextBox3.Tag = "p12"
        '
        'Label32
        '
        Me.Label32.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(99, 598)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(0, 29)
        Me.Label32.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(99, 544)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(547, 29)
        Me.Label19.TabIndex = 5
        Me.Label19.Tag = "p13"
        Me.Label19.Text = "¿El paciente presenta trastornos alimenticios?"
        '
        'txtDrugs
        '
        Me.txtDrugs.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDrugs.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrugs.Location = New System.Drawing.Point(652, 544)
        Me.txtDrugs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDrugs.Multiline = True
        Me.txtDrugs.Name = "txtDrugs"
        Me.txtDrugs.Size = New System.Drawing.Size(653, 29)
        Me.txtDrugs.TabIndex = 6
        Me.txtDrugs.Tag = "p13"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(99, 493)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(418, 29)
        Me.Label3.TabIndex = 80
        Me.Label3.Tag = "p12"
        Me.Label3.Text = "¿Consume alcohol u otras drogas?"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(557, 439)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(749, 30)
        Me.TextBox2.TabIndex = 79
        Me.TextBox2.Tag = "p11"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 439)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(452, 29)
        Me.Label2.TabIndex = 78
        Me.Label2.Tag = "p10"
        Me.Label2.Text = "¿Qué otros problemas de salud tiene?"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(481, 379)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(825, 30)
        Me.TextBox1.TabIndex = 77
        Me.TextBox1.Tag = "p9"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 29)
        Me.Label1.TabIndex = 76
        Me.Label1.Tag = "p9"
        Me.Label1.Text = "¿Qué medicinas está tomando?"
        '
        'chkViajo
        '
        Me.chkViajo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkViajo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkViajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkViajo.Location = New System.Drawing.Point(97, 314)
        Me.chkViajo.Name = "chkViajo"
        Me.chkViajo.Size = New System.Drawing.Size(1209, 40)
        Me.chkViajo.TabIndex = 75
        Me.chkViajo.Tag = "p8"
        Me.chkViajo.Text = "¿Ha viajado recientemente?"
        Me.chkViajo.UseVisualStyleBackColor = True
        '
        'chkMalestarConstante
        '
        Me.chkMalestarConstante.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkMalestarConstante.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMalestarConstante.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold)
        Me.chkMalestarConstante.Location = New System.Drawing.Point(98, 209)
        Me.chkMalestarConstante.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkMalestarConstante.Name = "chkMalestarConstante"
        Me.chkMalestarConstante.Size = New System.Drawing.Size(1208, 33)
        Me.chkMalestarConstante.TabIndex = 74
        Me.chkMalestarConstante.Tag = "p6"
        Me.chkMalestarConstante.Text = "¿El malestar es constante?"
        Me.chkMalestarConstante.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(99, 259)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(784, 29)
        Me.Label26.TabIndex = 5
        Me.Label26.Tag = "p7"
        Me.Label26.Text = "¿Puede cumplir con sus actividades diarias? Si no, ¿Qué lo limita?"
        '
        'txtADiarias
        '
        Me.txtADiarias.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtADiarias.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtADiarias.Location = New System.Drawing.Point(889, 259)
        Me.txtADiarias.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtADiarias.Multiline = True
        Me.txtADiarias.Name = "txtADiarias"
        Me.txtADiarias.Size = New System.Drawing.Size(417, 29)
        Me.txtADiarias.TabIndex = 6
        Me.txtADiarias.Tag = "p7"
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(99, 165)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(514, 29)
        Me.Label28.TabIndex = 73
        Me.Label28.Tag = "p5"
        Me.Label28.Text = "¿Cuánto tiempo ha durado esta sensación?"
        '
        'txtDuracion
        '
        Me.txtDuracion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDuracion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuracion.Location = New System.Drawing.Point(618, 165)
        Me.txtDuracion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDuracion.Multiline = True
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(687, 29)
        Me.txtDuracion.TabIndex = 7
        Me.txtDuracion.Tag = "p5"
        '
        'tblGrHidr
        '
        Me.tblGrHidr.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tblGrHidr.ColumnCount = 2
        Me.tblGrHidr.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234!))
        Me.tblGrHidr.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197.0!))
        Me.tblGrHidr.Controls.Add(Me.Label9, 0, 0)
        Me.tblGrHidr.Controls.Add(Me.cbGradoHidr, 1, 0)
        Me.tblGrHidr.Location = New System.Drawing.Point(729, 32)
        Me.tblGrHidr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tblGrHidr.Name = "tblGrHidr"
        Me.tblGrHidr.RowCount = 1
        Me.tblGrHidr.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblGrHidr.Size = New System.Drawing.Size(577, 37)
        Me.tblGrHidr.TabIndex = 72
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label9.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(374, 30)
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
        Me.cbGradoHidr.Location = New System.Drawing.Point(383, 2)
        Me.cbGradoHidr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbGradoHidr.Name = "cbGradoHidr"
        Me.cbGradoHidr.Size = New System.Drawing.Size(191, 31)
        Me.cbGradoHidr.TabIndex = 13
        Me.cbGradoHidr.Tag = "p3"
        '
        'tblActitud
        '
        Me.tblActitud.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tblActitud.ColumnCount = 2
        Me.tblActitud.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234!))
        Me.tblActitud.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197.0!))
        Me.tblActitud.Controls.Add(Me.Label16, 0, 0)
        Me.tblActitud.Controls.Add(Me.cbActitud, 1, 0)
        Me.tblActitud.Location = New System.Drawing.Point(97, 87)
        Me.tblActitud.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tblActitud.Name = "tblActitud"
        Me.tblActitud.RowCount = 1
        Me.tblActitud.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblActitud.Size = New System.Drawing.Size(499, 37)
        Me.tblActitud.TabIndex = 70
        '
        'Label16
        '
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label16.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(296, 34)
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
        Me.cbActitud.Location = New System.Drawing.Point(305, 3)
        Me.cbActitud.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbActitud.Name = "cbActitud"
        Me.cbActitud.Size = New System.Drawing.Size(191, 31)
        Me.cbActitud.TabIndex = 41
        Me.cbActitud.Tag = "p2"
        '
        'tblENutricion
        '
        Me.tblENutricion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tblENutricion.ColumnCount = 2
        Me.tblENutricion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234!))
        Me.tblENutricion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197.0!))
        Me.tblENutricion.Controls.Add(Me.Label17, 0, 0)
        Me.tblENutricion.Controls.Add(Me.cb_e_nutricion, 1, 0)
        Me.tblENutricion.Location = New System.Drawing.Point(729, 84)
        Me.tblENutricion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tblENutricion.Name = "tblENutricion"
        Me.tblENutricion.RowCount = 1
        Me.tblENutricion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblENutricion.Size = New System.Drawing.Size(577, 37)
        Me.tblENutricion.TabIndex = 69
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label17.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(374, 34)
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
        Me.cb_e_nutricion.Location = New System.Drawing.Point(383, 3)
        Me.cb_e_nutricion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_e_nutricion.Name = "cb_e_nutricion"
        Me.cb_e_nutricion.Size = New System.Drawing.Size(191, 31)
        Me.cb_e_nutricion.TabIndex = 38
        Me.cb_e_nutricion.Tag = "p4"
        '
        'tblPulso
        '
        Me.tblPulso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tblPulso.ColumnCount = 2
        Me.tblPulso.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234!))
        Me.tblPulso.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197.0!))
        Me.tblPulso.Controls.Add(Me.Label21, 0, 0)
        Me.tblPulso.Controls.Add(Me.cbPulso, 1, 0)
        Me.tblPulso.Location = New System.Drawing.Point(97, 32)
        Me.tblPulso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tblPulso.Name = "tblPulso"
        Me.tblPulso.RowCount = 1
        Me.tblPulso.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPulso.Size = New System.Drawing.Size(499, 37)
        Me.tblPulso.TabIndex = 65
        '
        'Label21
        '
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label21.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(3, 7)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(296, 30)
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
        Me.cbPulso.Location = New System.Drawing.Point(305, 3)
        Me.cbPulso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbPulso.Name = "cbPulso"
        Me.cbPulso.Size = New System.Drawing.Size(191, 31)
        Me.cbPulso.TabIndex = 23
        Me.cbPulso.Tag = "p1"
        '
        'lblTitutloFRM
        '
        Me.lblTitutloFRM.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitutloFRM.AutoSize = True
        Me.lblTitutloFRM.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitutloFRM.Location = New System.Drawing.Point(299, -1)
        Me.lblTitutloFRM.Name = "lblTitutloFRM"
        Me.lblTitutloFRM.Size = New System.Drawing.Size(694, 33)
        Me.lblTitutloFRM.TabIndex = 74
        Me.lblTitutloFRM.Text = "Formulario de entrevista para paciente con malestar"
        Me.lblTitutloFRM.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1424, 828)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMalestar"
        Me.Text = "frmMalestar"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.gbPreguntas.ResumeLayout(False)
        Me.gbPreguntas.PerformLayout()
        Me.tblGrHidr.ResumeLayout(False)
        Me.tblActitud.ResumeLayout(False)
        Me.tblENutricion.ResumeLayout(False)
        Me.tblPulso.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents gbPreguntas As GroupBox
    Friend WithEvents tblGrHidr As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents cbGradoHidr As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtDieta As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents tblActitud As TableLayoutPanel
    Friend WithEvents Label16 As Label
    Friend WithEvents cbActitud As ComboBox
    Friend WithEvents tblENutricion As TableLayoutPanel
    Friend WithEvents Label17 As Label
    Friend WithEvents cb_e_nutricion As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtDrugs As TextBox
    Friend WithEvents tblPulso As TableLayoutPanel
    Friend WithEvents Label21 As Label
    Friend WithEvents cbPulso As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtADiarias As TextBox
    Friend WithEvents txtDuracion As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents lblTitutloFRM As Label
    Friend WithEvents Imprimir As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label28 As Label
    Friend WithEvents chkMalestarConstante As CheckBox
    Friend WithEvents chkViajo As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkTS As CheckBox
    Friend WithEvents chkCambioDieta As CheckBox
End Class
