<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDolor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDolor))
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.pnlDatosSeleccion = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbDorso = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbTorso = New System.Windows.Forms.ListBox()
        Me.tblDescripcion = New System.Windows.Forms.TableLayoutPanel()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnColDorsalDer = New System.Windows.Forms.Button()
        Me.btnColLumbarDer = New System.Windows.Forms.Button()
        Me.btnColLumbarIzq = New System.Windows.Forms.Button()
        Me.btnColDorsalIzq = New System.Windows.Forms.Button()
        Me.btnOmoplatoIzq = New System.Windows.Forms.Button()
        Me.btnOmoplatoDer = New System.Windows.Forms.Button()
        Me.btnCervicales = New System.Windows.Forms.Button()
        Me.btnCabezaDerBack = New System.Windows.Forms.Button()
        Me.btnCabezaIzqBack = New System.Windows.Forms.Button()
        Me.btnPiernaIzq = New System.Windows.Forms.Button()
        Me.btnPiernaDer = New System.Windows.Forms.Button()
        Me.btnAbdominalIzq = New System.Windows.Forms.Button()
        Me.btnAbdominalDer = New System.Windows.Forms.Button()
        Me.btnManoIzq = New System.Windows.Forms.Button()
        Me.btnManoDer = New System.Windows.Forms.Button()
        Me.btnBrazoIzq = New System.Windows.Forms.Button()
        Me.btnBrazoDer = New System.Windows.Forms.Button()
        Me.btnPechoIzq = New System.Windows.Forms.Button()
        Me.btnPechoDer = New System.Windows.Forms.Button()
        Me.btnHombroDer = New System.Windows.Forms.Button()
        Me.btnHombroIzq = New System.Windows.Forms.Button()
        Me.btnCuello = New System.Windows.Forms.Button()
        Me.btnCabezaIzq = New System.Windows.Forms.Button()
        Me.btnCabezaDer = New System.Windows.Forms.Button()
        Me.Imprimir = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.pnlContenedor.SuspendLayout()
        Me.pnlDatosSeleccion.SuspendLayout()
        Me.tblDescripcion.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.AutoScroll = True
        Me.pnlContenedor.AutoSize = True
        Me.pnlContenedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlContenedor.Controls.Add(Me.pnlDatosSeleccion)
        Me.pnlContenedor.Controls.Add(Me.tblDescripcion)
        Me.pnlContenedor.Controls.Add(Me.btnColDorsalDer)
        Me.pnlContenedor.Controls.Add(Me.btnColLumbarDer)
        Me.pnlContenedor.Controls.Add(Me.btnColLumbarIzq)
        Me.pnlContenedor.Controls.Add(Me.btnColDorsalIzq)
        Me.pnlContenedor.Controls.Add(Me.btnOmoplatoIzq)
        Me.pnlContenedor.Controls.Add(Me.btnOmoplatoDer)
        Me.pnlContenedor.Controls.Add(Me.btnCervicales)
        Me.pnlContenedor.Controls.Add(Me.btnCabezaDerBack)
        Me.pnlContenedor.Controls.Add(Me.btnCabezaIzqBack)
        Me.pnlContenedor.Controls.Add(Me.btnPiernaIzq)
        Me.pnlContenedor.Controls.Add(Me.btnPiernaDer)
        Me.pnlContenedor.Controls.Add(Me.btnAbdominalIzq)
        Me.pnlContenedor.Controls.Add(Me.btnAbdominalDer)
        Me.pnlContenedor.Controls.Add(Me.btnManoIzq)
        Me.pnlContenedor.Controls.Add(Me.btnManoDer)
        Me.pnlContenedor.Controls.Add(Me.btnBrazoIzq)
        Me.pnlContenedor.Controls.Add(Me.btnBrazoDer)
        Me.pnlContenedor.Controls.Add(Me.btnPechoIzq)
        Me.pnlContenedor.Controls.Add(Me.btnPechoDer)
        Me.pnlContenedor.Controls.Add(Me.btnHombroDer)
        Me.pnlContenedor.Controls.Add(Me.btnHombroIzq)
        Me.pnlContenedor.Controls.Add(Me.btnCuello)
        Me.pnlContenedor.Controls.Add(Me.btnCabezaIzq)
        Me.pnlContenedor.Controls.Add(Me.btnCabezaDer)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1870, 865)
        Me.pnlContenedor.TabIndex = 0
        '
        'pnlDatosSeleccion
        '
        Me.pnlDatosSeleccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDatosSeleccion.Controls.Add(Me.Label3)
        Me.pnlDatosSeleccion.Controls.Add(Me.lbDorso)
        Me.pnlDatosSeleccion.Controls.Add(Me.Label2)
        Me.pnlDatosSeleccion.Controls.Add(Me.lbTorso)
        Me.pnlDatosSeleccion.Location = New System.Drawing.Point(1377, 3)
        Me.pnlDatosSeleccion.Name = "pnlDatosSeleccion"
        Me.pnlDatosSeleccion.Size = New System.Drawing.Size(464, 752)
        Me.pnlDatosSeleccion.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(194, 434)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 29)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Dorso:"
        '
        'lbDorso
        '
        Me.lbDorso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbDorso.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDorso.FormattingEnabled = True
        Me.lbDorso.ItemHeight = 23
        Me.lbDorso.Location = New System.Drawing.Point(3, 466)
        Me.lbDorso.Name = "lbDorso"
        Me.lbDorso.Size = New System.Drawing.Size(458, 280)
        Me.lbDorso.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(194, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 29)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Torso:"
        '
        'lbTorso
        '
        Me.lbTorso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTorso.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTorso.FormattingEnabled = True
        Me.lbTorso.ItemHeight = 23
        Me.lbTorso.Location = New System.Drawing.Point(3, 41)
        Me.lbTorso.Name = "lbTorso"
        Me.lbTorso.Size = New System.Drawing.Size(458, 372)
        Me.lbTorso.TabIndex = 73
        '
        'tblDescripcion
        '
        Me.tblDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblDescripcion.AutoSize = True
        Me.tblDescripcion.ColumnCount = 1
        Me.tblDescripcion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDescripcion.Controls.Add(Me.txtDescripcion, 0, 1)
        Me.tblDescripcion.Controls.Add(Me.Label4, 0, 0)
        Me.tblDescripcion.Location = New System.Drawing.Point(529, 766)
        Me.tblDescripcion.Name = "tblDescripcion"
        Me.tblDescripcion.RowCount = 2
        Me.tblDescripcion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDescripcion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 196.0!))
        Me.tblDescripcion.Size = New System.Drawing.Size(1312, 228)
        Me.tblDescripcion.TabIndex = 74
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(3, 35)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(1306, 190)
        Me.txtDescripcion.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(522, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(267, 29)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Descripción detallada"
        '
        'btnColDorsalDer
        '
        Me.btnColDorsalDer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnColDorsalDer.BackgroundImage = CType(resources.GetObject("btnColDorsalDer.BackgroundImage"), System.Drawing.Image)
        Me.btnColDorsalDer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnColDorsalDer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnColDorsalDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColDorsalDer.Location = New System.Drawing.Point(957, 301)
        Me.btnColDorsalDer.Name = "btnColDorsalDer"
        Me.btnColDorsalDer.Size = New System.Drawing.Size(114, 190)
        Me.btnColDorsalDer.TabIndex = 62
        Me.btnColDorsalDer.UseVisualStyleBackColor = True
        '
        'btnColLumbarDer
        '
        Me.btnColLumbarDer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnColLumbarDer.BackgroundImage = CType(resources.GetObject("btnColLumbarDer.BackgroundImage"), System.Drawing.Image)
        Me.btnColLumbarDer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnColLumbarDer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnColLumbarDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColLumbarDer.Location = New System.Drawing.Point(957, 497)
        Me.btnColLumbarDer.Name = "btnColLumbarDer"
        Me.btnColLumbarDer.Size = New System.Drawing.Size(114, 238)
        Me.btnColLumbarDer.TabIndex = 61
        Me.btnColLumbarDer.Tag = "datos"
        Me.btnColLumbarDer.UseVisualStyleBackColor = True
        '
        'btnColLumbarIzq
        '
        Me.btnColLumbarIzq.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnColLumbarIzq.BackgroundImage = CType(resources.GetObject("btnColLumbarIzq.BackgroundImage"), System.Drawing.Image)
        Me.btnColLumbarIzq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnColLumbarIzq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnColLumbarIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColLumbarIzq.Location = New System.Drawing.Point(823, 497)
        Me.btnColLumbarIzq.Name = "btnColLumbarIzq"
        Me.btnColLumbarIzq.Size = New System.Drawing.Size(128, 238)
        Me.btnColLumbarIzq.TabIndex = 60
        Me.btnColLumbarIzq.Tag = "datos"
        Me.btnColLumbarIzq.UseVisualStyleBackColor = True
        '
        'btnColDorsalIzq
        '
        Me.btnColDorsalIzq.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnColDorsalIzq.BackgroundImage = CType(resources.GetObject("btnColDorsalIzq.BackgroundImage"), System.Drawing.Image)
        Me.btnColDorsalIzq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnColDorsalIzq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnColDorsalIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColDorsalIzq.Location = New System.Drawing.Point(823, 301)
        Me.btnColDorsalIzq.Name = "btnColDorsalIzq"
        Me.btnColDorsalIzq.Size = New System.Drawing.Size(128, 190)
        Me.btnColDorsalIzq.TabIndex = 59
        Me.btnColDorsalIzq.Tag = "datos"
        Me.btnColDorsalIzq.UseVisualStyleBackColor = True
        '
        'btnOmoplatoIzq
        '
        Me.btnOmoplatoIzq.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnOmoplatoIzq.BackgroundImage = CType(resources.GetObject("btnOmoplatoIzq.BackgroundImage"), System.Drawing.Image)
        Me.btnOmoplatoIzq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOmoplatoIzq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOmoplatoIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOmoplatoIzq.Location = New System.Drawing.Point(696, 226)
        Me.btnOmoplatoIzq.Name = "btnOmoplatoIzq"
        Me.btnOmoplatoIzq.Size = New System.Drawing.Size(121, 109)
        Me.btnOmoplatoIzq.TabIndex = 58
        Me.btnOmoplatoIzq.Tag = "datos"
        Me.btnOmoplatoIzq.UseVisualStyleBackColor = True
        '
        'btnOmoplatoDer
        '
        Me.btnOmoplatoDer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnOmoplatoDer.BackgroundImage = CType(resources.GetObject("btnOmoplatoDer.BackgroundImage"), System.Drawing.Image)
        Me.btnOmoplatoDer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOmoplatoDer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOmoplatoDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOmoplatoDer.Location = New System.Drawing.Point(1077, 226)
        Me.btnOmoplatoDer.Name = "btnOmoplatoDer"
        Me.btnOmoplatoDer.Size = New System.Drawing.Size(121, 109)
        Me.btnOmoplatoDer.TabIndex = 57
        Me.btnOmoplatoDer.Tag = "datos"
        Me.btnOmoplatoDer.UseVisualStyleBackColor = True
        '
        'btnCervicales
        '
        Me.btnCervicales.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCervicales.BackgroundImage = CType(resources.GetObject("btnCervicales.BackgroundImage"), System.Drawing.Image)
        Me.btnCervicales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCervicales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCervicales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCervicales.Location = New System.Drawing.Point(823, 165)
        Me.btnCervicales.Name = "btnCervicales"
        Me.btnCervicales.Size = New System.Drawing.Size(248, 130)
        Me.btnCervicales.TabIndex = 56
        Me.btnCervicales.Tag = "datos"
        Me.btnCervicales.UseVisualStyleBackColor = True
        '
        'btnCabezaDerBack
        '
        Me.btnCabezaDerBack.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCabezaDerBack.BackgroundImage = CType(resources.GetObject("btnCabezaDerBack.BackgroundImage"), System.Drawing.Image)
        Me.btnCabezaDerBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCabezaDerBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCabezaDerBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCabezaDerBack.Location = New System.Drawing.Point(957, 6)
        Me.btnCabezaDerBack.Name = "btnCabezaDerBack"
        Me.btnCabezaDerBack.Size = New System.Drawing.Size(74, 153)
        Me.btnCabezaDerBack.TabIndex = 55
        Me.btnCabezaDerBack.Tag = "datos"
        Me.btnCabezaDerBack.UseVisualStyleBackColor = True
        '
        'btnCabezaIzqBack
        '
        Me.btnCabezaIzqBack.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCabezaIzqBack.BackgroundImage = CType(resources.GetObject("btnCabezaIzqBack.BackgroundImage"), System.Drawing.Image)
        Me.btnCabezaIzqBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCabezaIzqBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCabezaIzqBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCabezaIzqBack.Location = New System.Drawing.Point(877, 6)
        Me.btnCabezaIzqBack.Name = "btnCabezaIzqBack"
        Me.btnCabezaIzqBack.Size = New System.Drawing.Size(74, 153)
        Me.btnCabezaIzqBack.TabIndex = 54
        Me.btnCabezaIzqBack.Tag = "datos"
        Me.btnCabezaIzqBack.UseVisualStyleBackColor = True
        '
        'btnPiernaIzq
        '
        Me.btnPiernaIzq.BackgroundImage = CType(resources.GetObject("btnPiernaIzq.BackgroundImage"), System.Drawing.Image)
        Me.btnPiernaIzq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPiernaIzq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPiernaIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPiernaIzq.Location = New System.Drawing.Point(356, 564)
        Me.btnPiernaIzq.Name = "btnPiernaIzq"
        Me.btnPiernaIzq.Size = New System.Drawing.Size(150, 430)
        Me.btnPiernaIzq.TabIndex = 53
        Me.btnPiernaIzq.Tag = "datos"
        Me.btnPiernaIzq.UseVisualStyleBackColor = True
        '
        'btnPiernaDer
        '
        Me.btnPiernaDer.BackgroundImage = CType(resources.GetObject("btnPiernaDer.BackgroundImage"), System.Drawing.Image)
        Me.btnPiernaDer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPiernaDer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPiernaDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPiernaDer.Location = New System.Drawing.Point(200, 564)
        Me.btnPiernaDer.Name = "btnPiernaDer"
        Me.btnPiernaDer.Size = New System.Drawing.Size(150, 430)
        Me.btnPiernaDer.TabIndex = 52
        Me.btnPiernaDer.Tag = "datos"
        Me.btnPiernaDer.UseVisualStyleBackColor = True
        '
        'btnAbdominalIzq
        '
        Me.btnAbdominalIzq.BackgroundImage = CType(resources.GetObject("btnAbdominalIzq.BackgroundImage"), System.Drawing.Image)
        Me.btnAbdominalIzq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAbdominalIzq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbdominalIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbdominalIzq.Location = New System.Drawing.Point(356, 363)
        Me.btnAbdominalIzq.Name = "btnAbdominalIzq"
        Me.btnAbdominalIzq.Size = New System.Drawing.Size(105, 195)
        Me.btnAbdominalIzq.TabIndex = 51
        Me.btnAbdominalIzq.Tag = "datos"
        Me.btnAbdominalIzq.UseVisualStyleBackColor = True
        '
        'btnAbdominalDer
        '
        Me.btnAbdominalDer.BackgroundImage = CType(resources.GetObject("btnAbdominalDer.BackgroundImage"), System.Drawing.Image)
        Me.btnAbdominalDer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAbdominalDer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbdominalDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbdominalDer.Location = New System.Drawing.Point(245, 363)
        Me.btnAbdominalDer.Name = "btnAbdominalDer"
        Me.btnAbdominalDer.Size = New System.Drawing.Size(105, 195)
        Me.btnAbdominalDer.TabIndex = 50
        Me.btnAbdominalDer.Tag = "datos"
        Me.btnAbdominalDer.UseVisualStyleBackColor = True
        '
        'btnManoIzq
        '
        Me.btnManoIzq.BackgroundImage = CType(resources.GetObject("btnManoIzq.BackgroundImage"), System.Drawing.Image)
        Me.btnManoIzq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnManoIzq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManoIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManoIzq.Location = New System.Drawing.Point(599, 539)
        Me.btnManoIzq.Name = "btnManoIzq"
        Me.btnManoIzq.Size = New System.Drawing.Size(101, 87)
        Me.btnManoIzq.TabIndex = 49
        Me.btnManoIzq.Tag = "datos"
        Me.btnManoIzq.UseVisualStyleBackColor = True
        '
        'btnManoDer
        '
        Me.btnManoDer.BackgroundImage = CType(resources.GetObject("btnManoDer.BackgroundImage"), System.Drawing.Image)
        Me.btnManoDer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnManoDer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManoDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManoDer.Location = New System.Drawing.Point(3, 539)
        Me.btnManoDer.Name = "btnManoDer"
        Me.btnManoDer.Size = New System.Drawing.Size(101, 87)
        Me.btnManoDer.TabIndex = 48
        Me.btnManoDer.Tag = "datos"
        Me.btnManoDer.UseVisualStyleBackColor = True
        '
        'btnBrazoIzq
        '
        Me.btnBrazoIzq.BackgroundImage = CType(resources.GetObject("btnBrazoIzq.BackgroundImage"), System.Drawing.Image)
        Me.btnBrazoIzq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBrazoIzq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrazoIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrazoIzq.Location = New System.Drawing.Point(526, 363)
        Me.btnBrazoIzq.Name = "btnBrazoIzq"
        Me.btnBrazoIzq.Size = New System.Drawing.Size(106, 170)
        Me.btnBrazoIzq.TabIndex = 47
        Me.btnBrazoIzq.Tag = "datos"
        Me.btnBrazoIzq.UseVisualStyleBackColor = True
        '
        'btnBrazoDer
        '
        Me.btnBrazoDer.BackgroundImage = CType(resources.GetObject("btnBrazoDer.BackgroundImage"), System.Drawing.Image)
        Me.btnBrazoDer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBrazoDer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrazoDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrazoDer.Location = New System.Drawing.Point(69, 363)
        Me.btnBrazoDer.Name = "btnBrazoDer"
        Me.btnBrazoDer.Size = New System.Drawing.Size(106, 170)
        Me.btnBrazoDer.TabIndex = 46
        Me.btnBrazoDer.Tag = "datos"
        Me.btnBrazoDer.UseVisualStyleBackColor = True
        '
        'btnPechoIzq
        '
        Me.btnPechoIzq.BackgroundImage = CType(resources.GetObject("btnPechoIzq.BackgroundImage"), System.Drawing.Image)
        Me.btnPechoIzq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPechoIzq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPechoIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPechoIzq.Location = New System.Drawing.Point(356, 248)
        Me.btnPechoIzq.Name = "btnPechoIzq"
        Me.btnPechoIzq.Size = New System.Drawing.Size(105, 109)
        Me.btnPechoIzq.TabIndex = 45
        Me.btnPechoIzq.Tag = "datos"
        Me.btnPechoIzq.UseVisualStyleBackColor = True
        '
        'btnPechoDer
        '
        Me.btnPechoDer.BackgroundImage = CType(resources.GetObject("btnPechoDer.BackgroundImage"), System.Drawing.Image)
        Me.btnPechoDer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPechoDer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPechoDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPechoDer.Location = New System.Drawing.Point(245, 248)
        Me.btnPechoDer.Name = "btnPechoDer"
        Me.btnPechoDer.Size = New System.Drawing.Size(105, 109)
        Me.btnPechoDer.TabIndex = 44
        Me.btnPechoDer.Tag = "datos"
        Me.btnPechoDer.UseVisualStyleBackColor = True
        '
        'btnHombroDer
        '
        Me.btnHombroDer.BackgroundImage = CType(resources.GetObject("btnHombroDer.BackgroundImage"), System.Drawing.Image)
        Me.btnHombroDer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHombroDer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHombroDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHombroDer.Location = New System.Drawing.Point(149, 248)
        Me.btnHombroDer.Name = "btnHombroDer"
        Me.btnHombroDer.Size = New System.Drawing.Size(90, 109)
        Me.btnHombroDer.TabIndex = 43
        Me.btnHombroDer.Tag = "datos"
        Me.btnHombroDer.UseVisualStyleBackColor = True
        '
        'btnHombroIzq
        '
        Me.btnHombroIzq.BackgroundImage = CType(resources.GetObject("btnHombroIzq.BackgroundImage"), System.Drawing.Image)
        Me.btnHombroIzq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHombroIzq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHombroIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHombroIzq.Location = New System.Drawing.Point(467, 248)
        Me.btnHombroIzq.Name = "btnHombroIzq"
        Me.btnHombroIzq.Size = New System.Drawing.Size(90, 109)
        Me.btnHombroIzq.TabIndex = 42
        Me.btnHombroIzq.Tag = "datos"
        Me.btnHombroIzq.UseVisualStyleBackColor = True
        '
        'btnCuello
        '
        Me.btnCuello.BackgroundImage = CType(resources.GetObject("btnCuello.BackgroundImage"), System.Drawing.Image)
        Me.btnCuello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCuello.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCuello.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuello.Location = New System.Drawing.Point(245, 164)
        Me.btnCuello.Name = "btnCuello"
        Me.btnCuello.Size = New System.Drawing.Size(202, 77)
        Me.btnCuello.TabIndex = 41
        Me.btnCuello.Tag = "datos"
        Me.btnCuello.UseVisualStyleBackColor = True
        '
        'btnCabezaIzq
        '
        Me.btnCabezaIzq.BackgroundImage = CType(resources.GetObject("btnCabezaIzq.BackgroundImage"), System.Drawing.Image)
        Me.btnCabezaIzq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCabezaIzq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCabezaIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCabezaIzq.Location = New System.Drawing.Point(356, 5)
        Me.btnCabezaIzq.Name = "btnCabezaIzq"
        Me.btnCabezaIzq.Size = New System.Drawing.Size(76, 153)
        Me.btnCabezaIzq.TabIndex = 40
        Me.btnCabezaIzq.Tag = "datos"
        Me.btnCabezaIzq.UseVisualStyleBackColor = True
        '
        'btnCabezaDer
        '
        Me.btnCabezaDer.BackgroundImage = CType(resources.GetObject("btnCabezaDer.BackgroundImage"), System.Drawing.Image)
        Me.btnCabezaDer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCabezaDer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCabezaDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCabezaDer.Location = New System.Drawing.Point(274, 5)
        Me.btnCabezaDer.Name = "btnCabezaDer"
        Me.btnCabezaDer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCabezaDer.Size = New System.Drawing.Size(76, 153)
        Me.btnCabezaDer.TabIndex = 39
        Me.btnCabezaDer.Tag = "datos"
        Me.btnCabezaDer.UseVisualStyleBackColor = True
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
        'frmDolor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1870, 865)
        Me.Controls.Add(Me.pnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDolor"
        Me.Text = "tmpDolor"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.pnlDatosSeleccion.ResumeLayout(False)
        Me.pnlDatosSeleccion.PerformLayout()
        Me.tblDescripcion.ResumeLayout(False)
        Me.tblDescripcion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnColDorsalDer As Button
    Friend WithEvents btnColLumbarDer As Button
    Friend WithEvents btnColLumbarIzq As Button
    Friend WithEvents btnColDorsalIzq As Button
    Friend WithEvents btnOmoplatoIzq As Button
    Friend WithEvents btnOmoplatoDer As Button
    Friend WithEvents btnCervicales As Button
    Friend WithEvents btnCabezaDerBack As Button
    Friend WithEvents btnCabezaIzqBack As Button
    Friend WithEvents btnPiernaIzq As Button
    Friend WithEvents btnPiernaDer As Button
    Friend WithEvents btnAbdominalIzq As Button
    Friend WithEvents btnAbdominalDer As Button
    Friend WithEvents btnManoIzq As Button
    Friend WithEvents btnManoDer As Button
    Friend WithEvents btnBrazoIzq As Button
    Friend WithEvents btnBrazoDer As Button
    Friend WithEvents btnPechoIzq As Button
    Friend WithEvents btnPechoDer As Button
    Friend WithEvents btnHombroDer As Button
    Friend WithEvents btnHombroIzq As Button
    Friend WithEvents btnCuello As Button
    Friend WithEvents btnCabezaIzq As Button
    Friend WithEvents btnCabezaDer As Button
    Friend WithEvents Imprimir As Printing.PrintDocument
    Friend WithEvents Label3 As Label
    Friend WithEvents lbDorso As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbTorso As ListBox
    Friend WithEvents pnlDatosSeleccion As Panel
    Friend WithEvents tblDescripcion As TableLayoutPanel
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
