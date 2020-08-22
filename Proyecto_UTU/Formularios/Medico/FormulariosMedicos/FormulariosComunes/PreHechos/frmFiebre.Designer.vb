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
        Me.gbResolucion = New System.Windows.Forms.GroupBox()
        Me.txtNomAnalisis = New System.Windows.Forms.TextBox()
        Me.gbTratamiento = New System.Windows.Forms.GroupBox()
        Me.txtTratamiento = New System.Windows.Forms.TextBox()
        Me.chkAnalisis = New System.Windows.Forms.CheckBox()
        Me.lblNomAnalisis = New System.Windows.Forms.Label()
        Me.lblTitutloFRM = New System.Windows.Forms.Label()
        Me.gbPreguntas = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblActitud = New System.Windows.Forms.Label()
        Me.cbActitud = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbENutricion = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkT_Sens_No = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chkT_Sens_Si = New System.Windows.Forms.CheckBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkT_Hums_No = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkT_Hums_Si = New System.Windows.Forms.CheckBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkT_Digs_No = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkT_Digs_Si = New System.Windows.Forms.CheckBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbPulso = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkVacs_No = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkVacs_Si = New System.Windows.Forms.CheckBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbGradoHidr = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkErups_No = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkErups_Si = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkCalor_No = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkCalor_Si = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkMeds_No = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkMeds_Si = New System.Windows.Forms.CheckBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkD_Resp_No = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkD_Resp_Si = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkNoD_Ap = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkSiD_Ap = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTemperatura = New System.Windows.Forms.TextBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.pp = New System.Windows.Forms.PrintPreviewDialog()
        Me.Imprimir = New System.Drawing.Printing.PrintDocument()
        Me.pnlContenedor.SuspendLayout()
        Me.gbResolucion.SuspendLayout()
        Me.gbTratamiento.SuspendLayout()
        Me.gbPreguntas.SuspendLayout()
        Me.TableLayoutPanel14.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.AutoScroll = True
        Me.pnlContenedor.Controls.Add(Me.gbResolucion)
        Me.pnlContenedor.Controls.Add(Me.lblTitutloFRM)
        Me.pnlContenedor.Controls.Add(Me.gbPreguntas)
        Me.pnlContenedor.Controls.Add(Me.btnImprimir)
        Me.pnlContenedor.Controls.Add(Me.btnLimpiar)
        Me.pnlContenedor.Controls.Add(Me.btnGuardar)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1334, 815)
        Me.pnlContenedor.TabIndex = 0
        '
        'gbResolucion
        '
        Me.gbResolucion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbResolucion.Controls.Add(Me.txtNomAnalisis)
        Me.gbResolucion.Controls.Add(Me.gbTratamiento)
        Me.gbResolucion.Controls.Add(Me.chkAnalisis)
        Me.gbResolucion.Controls.Add(Me.lblNomAnalisis)
        Me.gbResolucion.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbResolucion.Location = New System.Drawing.Point(80, 610)
        Me.gbResolucion.Name = "gbResolucion"
        Me.gbResolucion.Size = New System.Drawing.Size(1166, 392)
        Me.gbResolucion.TabIndex = 48
        Me.gbResolucion.TabStop = False
        Me.gbResolucion.Text = "Resolución"
        '
        'txtNomAnalisis
        '
        Me.txtNomAnalisis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNomAnalisis.Enabled = False
        Me.txtNomAnalisis.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomAnalisis.Location = New System.Drawing.Point(460, 69)
        Me.txtNomAnalisis.Name = "txtNomAnalisis"
        Me.txtNomAnalisis.Size = New System.Drawing.Size(219, 30)
        Me.txtNomAnalisis.TabIndex = 27
        '
        'gbTratamiento
        '
        Me.gbTratamiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbTratamiento.Controls.Add(Me.txtTratamiento)
        Me.gbTratamiento.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTratamiento.Location = New System.Drawing.Point(6, 105)
        Me.gbTratamiento.Name = "gbTratamiento"
        Me.gbTratamiento.Size = New System.Drawing.Size(1160, 281)
        Me.gbTratamiento.TabIndex = 26
        Me.gbTratamiento.TabStop = False
        Me.gbTratamiento.Text = "Descripción y diagnóstico"
        '
        'txtTratamiento
        '
        Me.txtTratamiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTratamiento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTratamiento.Location = New System.Drawing.Point(9, 33)
        Me.txtTratamiento.Multiline = True
        Me.txtTratamiento.Name = "txtTratamiento"
        Me.txtTratamiento.Size = New System.Drawing.Size(1142, 242)
        Me.txtTratamiento.TabIndex = 2
        '
        'chkAnalisis
        '
        Me.chkAnalisis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkAnalisis.AutoSize = True
        Me.chkAnalisis.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAnalisis.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnalisis.Location = New System.Drawing.Point(182, 33)
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
        Me.lblNomAnalisis.Location = New System.Drawing.Point(187, 72)
        Me.lblNomAnalisis.Name = "lblNomAnalisis"
        Me.lblNomAnalisis.Size = New System.Drawing.Size(247, 29)
        Me.lblNomAnalisis.TabIndex = 22
        Me.lblNomAnalisis.Text = "Nombre del análisis:"
        '
        'lblTitutloFRM
        '
        Me.lblTitutloFRM.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitutloFRM.AutoSize = True
        Me.lblTitutloFRM.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitutloFRM.Location = New System.Drawing.Point(270, -3)
        Me.lblTitutloFRM.Name = "lblTitutloFRM"
        Me.lblTitutloFRM.Size = New System.Drawing.Size(657, 33)
        Me.lblTitutloFRM.TabIndex = 47
        Me.lblTitutloFRM.Text = "Formulario de entrevista para paciente con fiebre"
        Me.lblTitutloFRM.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbPreguntas
        '
        Me.gbPreguntas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbPreguntas.Controls.Add(Me.TableLayoutPanel14)
        Me.gbPreguntas.Controls.Add(Me.TableLayoutPanel13)
        Me.gbPreguntas.Controls.Add(Me.TableLayoutPanel12)
        Me.gbPreguntas.Controls.Add(Me.TableLayoutPanel11)
        Me.gbPreguntas.Controls.Add(Me.TableLayoutPanel10)
        Me.gbPreguntas.Controls.Add(Me.TableLayoutPanel9)
        Me.gbPreguntas.Controls.Add(Me.TableLayoutPanel8)
        Me.gbPreguntas.Controls.Add(Me.TableLayoutPanel7)
        Me.gbPreguntas.Controls.Add(Me.TableLayoutPanel6)
        Me.gbPreguntas.Controls.Add(Me.TableLayoutPanel5)
        Me.gbPreguntas.Controls.Add(Me.TableLayoutPanel4)
        Me.gbPreguntas.Controls.Add(Me.TableLayoutPanel3)
        Me.gbPreguntas.Controls.Add(Me.TableLayoutPanel2)
        Me.gbPreguntas.Controls.Add(Me.TableLayoutPanel1)
        Me.gbPreguntas.Location = New System.Drawing.Point(86, 33)
        Me.gbPreguntas.Name = "gbPreguntas"
        Me.gbPreguntas.Size = New System.Drawing.Size(1160, 571)
        Me.gbPreguntas.TabIndex = 52
        Me.gbPreguntas.TabStop = False
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel14.ColumnCount = 2
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234!))
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197.0!))
        Me.TableLayoutPanel14.Controls.Add(Me.lblActitud, 0, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.cbActitud, 1, 0)
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(649, 70)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 1
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(499, 37)
        Me.TableLayoutPanel14.TabIndex = 56
        '
        'lblActitud
        '
        Me.lblActitud.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblActitud.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActitud.Location = New System.Drawing.Point(3, 0)
        Me.lblActitud.Name = "lblActitud"
        Me.lblActitud.Size = New System.Drawing.Size(296, 37)
        Me.lblActitud.TabIndex = 41
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
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel13.ColumnCount = 2
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.cbENutricion, 1, 0)
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(649, 113)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 1
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(499, 37)
        Me.TableLayoutPanel13.TabIndex = 55
        '
        'Label14
        '
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label14.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(296, 29)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Estado de nutrición:"
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
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel12.ColumnCount = 4
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.39436!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.450705!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.154929!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.chkT_Sens_No, 2, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.chkT_Sens_Si, 1, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.TextBox6, 3, 0)
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(9, 512)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 1
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(1142, 34)
        Me.TableLayoutPanel12.TabIndex = 54
        '
        'chkT_Sens_No
        '
        Me.chkT_Sens_No.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkT_Sens_No.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkT_Sens_No.Location = New System.Drawing.Point(767, 3)
        Me.chkT_Sens_No.Name = "chkT_Sens_No"
        Me.chkT_Sens_No.Size = New System.Drawing.Size(71, 28)
        Me.chkT_Sens_No.TabIndex = 4
        Me.chkT_Sens_No.Text = "No"
        Me.chkT_Sens_No.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label13.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(539, 34)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "¿El paciente presenta trastornos sensoriales?"
        '
        'chkT_Sens_Si
        '
        Me.chkT_Sens_Si.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkT_Sens_Si.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkT_Sens_Si.Location = New System.Drawing.Point(696, 3)
        Me.chkT_Sens_Si.Name = "chkT_Sens_Si"
        Me.chkT_Sens_Si.Size = New System.Drawing.Size(65, 28)
        Me.chkT_Sens_Si.TabIndex = 3
        Me.chkT_Sens_Si.Text = "Si"
        Me.chkT_Sens_Si.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(844, 3)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(295, 28)
        Me.TextBox6.TabIndex = 6
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel11.ColumnCount = 4
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.39436!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.450705!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.154929!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.chkT_Hums_No, 2, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.chkT_Hums_Si, 1, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.TextBox5, 3, 0)
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(9, 472)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(1142, 34)
        Me.TableLayoutPanel11.TabIndex = 53
        '
        'chkT_Hums_No
        '
        Me.chkT_Hums_No.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkT_Hums_No.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkT_Hums_No.Location = New System.Drawing.Point(767, 3)
        Me.chkT_Hums_No.Name = "chkT_Hums_No"
        Me.chkT_Hums_No.Size = New System.Drawing.Size(71, 28)
        Me.chkT_Hums_No.TabIndex = 4
        Me.chkT_Hums_No.Text = "No"
        Me.chkT_Hums_No.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(529, 34)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "¿El paciente presenta trastornos humorales?"
        '
        'chkT_Hums_Si
        '
        Me.chkT_Hums_Si.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkT_Hums_Si.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkT_Hums_Si.Location = New System.Drawing.Point(696, 3)
        Me.chkT_Hums_Si.Name = "chkT_Hums_Si"
        Me.chkT_Hums_Si.Size = New System.Drawing.Size(65, 28)
        Me.chkT_Hums_Si.TabIndex = 3
        Me.chkT_Hums_Si.Text = "Si"
        Me.chkT_Hums_Si.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(844, 3)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(295, 28)
        Me.TextBox5.TabIndex = 6
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel10.ColumnCount = 4
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.39436!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.450705!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.154929!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.chkT_Digs_No, 2, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.Label11, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.chkT_Digs_Si, 1, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.TextBox4, 3, 0)
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(9, 432)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 1
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(1142, 34)
        Me.TableLayoutPanel10.TabIndex = 52
        '
        'chkT_Digs_No
        '
        Me.chkT_Digs_No.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkT_Digs_No.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkT_Digs_No.Location = New System.Drawing.Point(767, 3)
        Me.chkT_Digs_No.Name = "chkT_Digs_No"
        Me.chkT_Digs_No.Size = New System.Drawing.Size(71, 28)
        Me.chkT_Digs_No.TabIndex = 4
        Me.chkT_Digs_No.Text = "No"
        Me.chkT_Digs_No.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(527, 34)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "¿El paciente presenta trastornos digestivos?"
        '
        'chkT_Digs_Si
        '
        Me.chkT_Digs_Si.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkT_Digs_Si.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkT_Digs_Si.Location = New System.Drawing.Point(696, 3)
        Me.chkT_Digs_Si.Name = "chkT_Digs_Si"
        Me.chkT_Digs_Si.Size = New System.Drawing.Size(65, 28)
        Me.chkT_Digs_Si.TabIndex = 3
        Me.chkT_Digs_Si.Text = "Si"
        Me.chkT_Digs_Si.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(844, 3)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(295, 28)
        Me.TextBox4.TabIndex = 6
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.cbPulso, 1, 0)
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(9, 67)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(499, 37)
        Me.TableLayoutPanel9.TabIndex = 51
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label10.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(295, 29)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Pulso:"
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
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel8.ColumnCount = 4
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.39436!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.450705!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.154929!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.chkVacs_No, 2, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.chkVacs_Si, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.TextBox3, 3, 0)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(9, 392)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(1142, 34)
        Me.TableLayoutPanel8.TabIndex = 50
        '
        'chkVacs_No
        '
        Me.chkVacs_No.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkVacs_No.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVacs_No.Location = New System.Drawing.Point(767, 3)
        Me.chkVacs_No.Name = "chkVacs_No"
        Me.chkVacs_No.Size = New System.Drawing.Size(71, 28)
        Me.chkVacs_No.TabIndex = 4
        Me.chkVacs_No.Text = "No"
        Me.chkVacs_No.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(500, 34)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "¿El paciente fue vacunado recientemente?"
        '
        'chkVacs_Si
        '
        Me.chkVacs_Si.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkVacs_Si.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVacs_Si.Location = New System.Drawing.Point(696, 3)
        Me.chkVacs_Si.Name = "chkVacs_Si"
        Me.chkVacs_Si.Size = New System.Drawing.Size(65, 28)
        Me.chkVacs_Si.TabIndex = 3
        Me.chkVacs_Si.Text = "Si"
        Me.chkVacs_Si.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(844, 3)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(295, 28)
        Me.TextBox3.TabIndex = 6
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.cbGradoHidr, 1, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(9, 110)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(499, 37)
        Me.TableLayoutPanel7.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label9.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(296, 29)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Grado de hidratación:"
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
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.45614!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.39599!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.022556!))
        Me.TableLayoutPanel6.Controls.Add(Me.chkErups_No, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.chkErups_Si, 1, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(9, 352)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(852, 34)
        Me.TableLayoutPanel6.TabIndex = 48
        '
        'chkErups_No
        '
        Me.chkErups_No.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkErups_No.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkErups_No.Location = New System.Drawing.Point(777, 3)
        Me.chkErups_No.Name = "chkErups_No"
        Me.chkErups_No.Size = New System.Drawing.Size(72, 28)
        Me.chkErups_No.TabIndex = 4
        Me.chkErups_No.Text = "No"
        Me.chkErups_No.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(540, 34)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "¿El paciente manifiesta erupciones cutáneas?"
        '
        'chkErups_Si
        '
        Me.chkErups_Si.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkErups_Si.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkErups_Si.Location = New System.Drawing.Point(706, 3)
        Me.chkErups_Si.Name = "chkErups_Si"
        Me.chkErups_Si.Size = New System.Drawing.Size(65, 28)
        Me.chkErups_Si.TabIndex = 3
        Me.chkErups_Si.Text = "Si"
        Me.chkErups_Si.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.45614!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.39599!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.022556!))
        Me.TableLayoutPanel5.Controls.Add(Me.chkCalor_No, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.chkCalor_Si, 1, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(9, 312)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(852, 34)
        Me.TableLayoutPanel5.TabIndex = 47
        '
        'chkCalor_No
        '
        Me.chkCalor_No.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkCalor_No.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCalor_No.Location = New System.Drawing.Point(777, 3)
        Me.chkCalor_No.Name = "chkCalor_No"
        Me.chkCalor_No.Size = New System.Drawing.Size(72, 28)
        Me.chkCalor_No.TabIndex = 4
        Me.chkCalor_No.Text = "No"
        Me.chkCalor_No.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(628, 34)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "¿El paciente se expone al calor? / ¿Estuvo expuesto?"
        '
        'chkCalor_Si
        '
        Me.chkCalor_Si.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkCalor_Si.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCalor_Si.Location = New System.Drawing.Point(706, 3)
        Me.chkCalor_Si.Name = "chkCalor_Si"
        Me.chkCalor_Si.Size = New System.Drawing.Size(65, 28)
        Me.chkCalor_Si.TabIndex = 3
        Me.chkCalor_Si.Text = "Si"
        Me.chkCalor_Si.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.7262!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.225616!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.048179!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.chkMeds_No, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.chkMeds_Si, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBox2, 3, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(9, 272)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1142, 34)
        Me.TableLayoutPanel4.TabIndex = 46
        '
        'chkMeds_No
        '
        Me.chkMeds_No.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkMeds_No.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMeds_No.Location = New System.Drawing.Point(767, 3)
        Me.chkMeds_No.Name = "chkMeds_No"
        Me.chkMeds_No.Size = New System.Drawing.Size(70, 28)
        Me.chkMeds_No.TabIndex = 4
        Me.chkMeds_No.Text = "No"
        Me.chkMeds_No.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(408, 34)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "¿El paciente toma medicamentos?"
        '
        'chkMeds_Si
        '
        Me.chkMeds_Si.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkMeds_Si.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMeds_Si.Location = New System.Drawing.Point(698, 3)
        Me.chkMeds_Si.Name = "chkMeds_Si"
        Me.chkMeds_Si.Size = New System.Drawing.Size(63, 28)
        Me.chkMeds_Si.TabIndex = 3
        Me.chkMeds_Si.Text = "Si"
        Me.chkMeds_Si.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(843, 3)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(296, 28)
        Me.TextBox2.TabIndex = 6
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.45614!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.39599!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.022556!))
        Me.TableLayoutPanel3.Controls.Add(Me.chkD_Resp_No, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.chkD_Resp_Si, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(9, 232)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(852, 34)
        Me.TableLayoutPanel3.TabIndex = 45
        '
        'chkD_Resp_No
        '
        Me.chkD_Resp_No.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkD_Resp_No.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkD_Resp_No.Location = New System.Drawing.Point(777, 3)
        Me.chkD_Resp_No.Name = "chkD_Resp_No"
        Me.chkD_Resp_No.Size = New System.Drawing.Size(72, 28)
        Me.chkD_Resp_No.TabIndex = 4
        Me.chkD_Resp_No.Text = "No"
        Me.chkD_Resp_No.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(569, 34)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "¿El paciente presenta dificultades para respirar?"
        '
        'chkD_Resp_Si
        '
        Me.chkD_Resp_Si.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkD_Resp_Si.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkD_Resp_Si.Location = New System.Drawing.Point(706, 3)
        Me.chkD_Resp_Si.Name = "chkD_Resp_Si"
        Me.chkD_Resp_Si.Size = New System.Drawing.Size(65, 28)
        Me.chkD_Resp_Si.TabIndex = 3
        Me.chkD_Resp_Si.Text = "Si"
        Me.chkD_Resp_Si.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.45614!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.39599!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.022556!))
        Me.TableLayoutPanel2.Controls.Add(Me.chkNoD_Ap, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.chkSiD_Ap, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(9, 192)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(852, 34)
        Me.TableLayoutPanel2.TabIndex = 44
        '
        'chkNoD_Ap
        '
        Me.chkNoD_Ap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkNoD_Ap.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoD_Ap.Location = New System.Drawing.Point(777, 3)
        Me.chkNoD_Ap.Name = "chkNoD_Ap"
        Me.chkNoD_Ap.Size = New System.Drawing.Size(72, 28)
        Me.chkNoD_Ap.TabIndex = 4
        Me.chkNoD_Ap.Text = "No"
        Me.chkNoD_Ap.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(631, 34)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "¿El paciente presenta dolor en el apéndice al tocarlo?"
        '
        'chkSiD_Ap
        '
        Me.chkSiD_Ap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkSiD_Ap.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSiD_Ap.Location = New System.Drawing.Point(706, 3)
        Me.chkSiD_Ap.Name = "chkSiD_Ap"
        Me.chkSiD_Ap.Size = New System.Drawing.Size(65, 28)
        Me.chkSiD_Ap.TabIndex = 3
        Me.chkSiD_Ap.Text = "Si"
        Me.chkSiD_Ap.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.27646!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.72354!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTemperatura, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(547, 37)
        Me.TableLayoutPanel1.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(508, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "°"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Temperatura:"
        '
        'txtTemperatura
        '
        Me.txtTemperatura.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtTemperatura.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemperatura.Location = New System.Drawing.Point(445, 3)
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.Size = New System.Drawing.Size(45, 30)
        Me.txtTemperatura.TabIndex = 3
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(580, 1008)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(146, 45)
        Me.btnImprimir.TabIndex = 51
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(428, 1008)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(146, 45)
        Me.btnLimpiar.TabIndex = 50
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(732, 1008)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(146, 45)
        Me.btnGuardar.TabIndex = 49
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
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
        'Imprimir
        '
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
        Me.pnlContenedor.PerformLayout()
        Me.gbResolucion.ResumeLayout(False)
        Me.gbResolucion.PerformLayout()
        Me.gbTratamiento.ResumeLayout(False)
        Me.gbTratamiento.PerformLayout()
        Me.gbPreguntas.ResumeLayout(False)
        Me.TableLayoutPanel14.ResumeLayout(False)
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents gbResolucion As GroupBox
    Friend WithEvents txtNomAnalisis As TextBox
    Friend WithEvents gbTratamiento As GroupBox
    Friend WithEvents txtTratamiento As TextBox
    Friend WithEvents chkAnalisis As CheckBox
    Friend WithEvents lblNomAnalisis As Label
    Friend WithEvents lblTitutloFRM As Label
    Friend WithEvents gbPreguntas As GroupBox
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents lblActitud As Label
    Friend WithEvents cbActitud As ComboBox
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents Label14 As Label
    Friend WithEvents cbENutricion As ComboBox
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents chkT_Sens_No As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents chkT_Sens_Si As CheckBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents chkT_Hums_No As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents chkT_Hums_Si As CheckBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents chkT_Digs_No As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents chkT_Digs_Si As CheckBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents cbPulso As ComboBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents chkVacs_No As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents chkVacs_Si As CheckBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents cbGradoHidr As ComboBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents chkErups_No As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chkErups_Si As CheckBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents chkCalor_No As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chkCalor_Si As CheckBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents chkMeds_No As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chkMeds_Si As CheckBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents chkD_Resp_No As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkD_Resp_Si As CheckBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents chkNoD_Ap As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkSiD_Ap As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTemperatura As TextBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents pp As PrintPreviewDialog
    Friend WithEvents Imprimir As Printing.PrintDocument
    Friend WithEvents Label2 As Label
End Class
