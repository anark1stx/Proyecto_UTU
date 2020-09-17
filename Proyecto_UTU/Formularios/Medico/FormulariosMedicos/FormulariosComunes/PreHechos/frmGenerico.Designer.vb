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
        Me.pnlContenedor = New System.Windows.Forms.Panel()
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
        Me.pnlContenedor.SuspendLayout()
        Me.gbInspeccionGeneral.SuspendLayout()
        Me.gbConstantesVitales.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.AutoScroll = True
        Me.pnlContenedor.AutoSize = True
        Me.pnlContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlContenedor.Controls.Add(Me.gbInspeccionGeneral)
        Me.pnlContenedor.Controls.Add(Me.gbConstantesVitales)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1300, 1000)
        Me.pnlContenedor.TabIndex = 0
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
        Me.gbInspeccionGeneral.Location = New System.Drawing.Point(11, 3)
        Me.gbInspeccionGeneral.Name = "gbInspeccionGeneral"
        Me.gbInspeccionGeneral.Size = New System.Drawing.Size(1276, 203)
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
        Me.cbGradoHidr.Location = New System.Drawing.Point(972, 160)
        Me.cbGradoHidr.Name = "cbGradoHidr"
        Me.cbGradoHidr.Size = New System.Drawing.Size(258, 31)
        Me.cbGradoHidr.TabIndex = 11
        Me.cbGradoHidr.Tag = "p6"
        '
        'lblGradoHidratacion
        '
        Me.lblGradoHidratacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGradoHidratacion.AutoSize = True
        Me.lblGradoHidratacion.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradoHidratacion.Location = New System.Drawing.Point(690, 167)
        Me.lblGradoHidratacion.Name = "lblGradoHidratacion"
        Me.lblGradoHidratacion.Size = New System.Drawing.Size(263, 29)
        Me.lblGradoHidratacion.TabIndex = 10
        Me.lblGradoHidratacion.Tag = "p6"
        Me.lblGradoHidratacion.Text = "Grado de hidratación:"
        '
        'cbENutricion
        '
        Me.cbENutricion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbENutricion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbENutricion.FormattingEnabled = True
        Me.cbENutricion.Items.AddRange(New Object() {"Obesidad", "Anorexia", "Caquexia", "Peso normal"})
        Me.cbENutricion.Location = New System.Drawing.Point(400, 160)
        Me.cbENutricion.Name = "cbENutricion"
        Me.cbENutricion.Size = New System.Drawing.Size(219, 31)
        Me.cbENutricion.TabIndex = 9
        Me.cbENutricion.Tag = "p5"
        '
        'lblEstadoNutricion
        '
        Me.lblEstadoNutricion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEstadoNutricion.AutoSize = True
        Me.lblEstadoNutricion.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoNutricion.Location = New System.Drawing.Point(139, 167)
        Me.lblEstadoNutricion.Name = "lblEstadoNutricion"
        Me.lblEstadoNutricion.Size = New System.Drawing.Size(246, 29)
        Me.lblEstadoNutricion.TabIndex = 8
        Me.lblEstadoNutricion.Tag = "p5"
        Me.lblEstadoNutricion.Text = "Estado de nutrición:"
        '
        'cbActitud
        '
        Me.cbActitud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbActitud.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbActitud.FormattingEnabled = True
        Me.cbActitud.Items.AddRange(New Object() {"Apatía", "Coma", "Excitación", "Desmotivación", "Desinterés", "Otro"})
        Me.cbActitud.Location = New System.Drawing.Point(972, 102)
        Me.cbActitud.Name = "cbActitud"
        Me.cbActitud.Size = New System.Drawing.Size(258, 31)
        Me.cbActitud.TabIndex = 7
        Me.cbActitud.Tag = "p4"
        '
        'lblActitud
        '
        Me.lblActitud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblActitud.AutoSize = True
        Me.lblActitud.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActitud.Location = New System.Drawing.Point(848, 109)
        Me.lblActitud.Name = "lblActitud"
        Me.lblActitud.Size = New System.Drawing.Size(103, 29)
        Me.lblActitud.TabIndex = 6
        Me.lblActitud.Tag = "p4"
        Me.lblActitud.Text = "Actitud:"
        '
        'cbMovilidad
        '
        Me.cbMovilidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbMovilidad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMovilidad.FormattingEnabled = True
        Me.cbMovilidad.Items.AddRange(New Object() {"Buena", "Mala", "Con dificultades"})
        Me.cbMovilidad.Location = New System.Drawing.Point(400, 102)
        Me.cbMovilidad.Name = "cbMovilidad"
        Me.cbMovilidad.Size = New System.Drawing.Size(219, 31)
        Me.cbMovilidad.TabIndex = 5
        Me.cbMovilidad.Tag = "p3"
        '
        'lblMovilidad
        '
        Me.lblMovilidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMovilidad.AutoSize = True
        Me.lblMovilidad.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovilidad.Location = New System.Drawing.Point(261, 109)
        Me.lblMovilidad.Name = "lblMovilidad"
        Me.lblMovilidad.Size = New System.Drawing.Size(133, 29)
        Me.lblMovilidad.TabIndex = 4
        Me.lblMovilidad.Tag = "p3"
        Me.lblMovilidad.Text = "Movilidad:"
        '
        'cbGradoColab
        '
        Me.cbGradoColab.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbGradoColab.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGradoColab.FormattingEnabled = True
        Me.cbGradoColab.Items.AddRange(New Object() {"Bueno", "Malo"})
        Me.cbGradoColab.Location = New System.Drawing.Point(972, 32)
        Me.cbGradoColab.Name = "cbGradoColab"
        Me.cbGradoColab.Size = New System.Drawing.Size(258, 31)
        Me.cbGradoColab.TabIndex = 3
        Me.cbGradoColab.Tag = "p2"
        '
        'lblGradoColaboracion
        '
        Me.lblGradoColaboracion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGradoColaboracion.AutoSize = True
        Me.lblGradoColaboracion.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradoColaboracion.Location = New System.Drawing.Point(670, 39)
        Me.lblGradoColaboracion.Name = "lblGradoColaboracion"
        Me.lblGradoColaboracion.Size = New System.Drawing.Size(283, 29)
        Me.lblGradoColaboracion.TabIndex = 2
        Me.lblGradoColaboracion.Tag = "p2"
        Me.lblGradoColaboracion.Text = "Grado de colaboración:"
        '
        'cbEstadoConsciencia
        '
        Me.cbEstadoConsciencia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbEstadoConsciencia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstadoConsciencia.FormattingEnabled = True
        Me.cbEstadoConsciencia.Items.AddRange(New Object() {"Consciente", "Inconsciente"})
        Me.cbEstadoConsciencia.Location = New System.Drawing.Point(400, 32)
        Me.cbEstadoConsciencia.Name = "cbEstadoConsciencia"
        Me.cbEstadoConsciencia.Size = New System.Drawing.Size(219, 31)
        Me.cbEstadoConsciencia.TabIndex = 1
        Me.cbEstadoConsciencia.Tag = "p1"
        '
        'lblEConsciencia
        '
        Me.lblEConsciencia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEConsciencia.AutoSize = True
        Me.lblEConsciencia.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEConsciencia.Location = New System.Drawing.Point(99, 39)
        Me.lblEConsciencia.Name = "lblEConsciencia"
        Me.lblEConsciencia.Size = New System.Drawing.Size(279, 29)
        Me.lblEConsciencia.TabIndex = 0
        Me.lblEConsciencia.Tag = "p1"
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
        Me.gbConstantesVitales.Location = New System.Drawing.Point(11, 225)
        Me.gbConstantesVitales.Name = "gbConstantesVitales"
        Me.gbConstantesVitales.Size = New System.Drawing.Size(1276, 127)
        Me.gbConstantesVitales.TabIndex = 44
        Me.gbConstantesVitales.TabStop = False
        Me.gbConstantesVitales.Text = "Constantes Vitales"
        '
        'txtFrecuenciaResp
        '
        Me.txtFrecuenciaResp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFrecuenciaResp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrecuenciaResp.Location = New System.Drawing.Point(960, 84)
        Me.txtFrecuenciaResp.Name = "txtFrecuenciaResp"
        Me.txtFrecuenciaResp.Size = New System.Drawing.Size(66, 30)
        Me.txtFrecuenciaResp.TabIndex = 22
        Me.txtFrecuenciaResp.Tag = "p10"
        '
        'cbPulso
        '
        Me.cbPulso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbPulso.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPulso.FormattingEnabled = True
        Me.cbPulso.Items.AddRange(New Object() {"Fuerte", "Débil", "Filiforme"})
        Me.cbPulso.Location = New System.Drawing.Point(960, 37)
        Me.cbPulso.Name = "cbPulso"
        Me.cbPulso.Size = New System.Drawing.Size(270, 31)
        Me.cbPulso.TabIndex = 21
        Me.cbPulso.Tag = "p8"
        '
        'txtFrecuenciaCard
        '
        Me.txtFrecuenciaCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFrecuenciaCard.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrecuenciaCard.Location = New System.Drawing.Point(400, 84)
        Me.txtFrecuenciaCard.Name = "txtFrecuenciaCard"
        Me.txtFrecuenciaCard.Size = New System.Drawing.Size(66, 30)
        Me.txtFrecuenciaCard.TabIndex = 20
        Me.txtFrecuenciaCard.Tag = "p9"
        '
        'txtTemperatura
        '
        Me.txtTemperatura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTemperatura.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemperatura.Location = New System.Drawing.Point(400, 36)
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.Size = New System.Drawing.Size(66, 30)
        Me.txtTemperatura.TabIndex = 19
        Me.txtTemperatura.Tag = "p7"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(1032, 84)
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
        Me.lblFrecuenciaResp.Location = New System.Drawing.Point(648, 85)
        Me.lblFrecuenciaResp.Name = "lblFrecuenciaResp"
        Me.lblFrecuenciaResp.Size = New System.Drawing.Size(292, 29)
        Me.lblFrecuenciaResp.TabIndex = 16
        Me.lblFrecuenciaResp.Tag = "p10"
        Me.lblFrecuenciaResp.Text = "Frecuencia Respiratoria:"
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(472, 84)
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
        Me.Label24.Location = New System.Drawing.Point(471, 36)
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
        Me.lblFrecuenciaCard.Location = New System.Drawing.Point(106, 85)
        Me.lblFrecuenciaCard.Name = "lblFrecuenciaCard"
        Me.lblFrecuenciaCard.Size = New System.Drawing.Size(253, 29)
        Me.lblFrecuenciaCard.TabIndex = 4
        Me.lblFrecuenciaCard.Tag = "p9"
        Me.lblFrecuenciaCard.Text = "Frecuencia Cardíaca:"
        '
        'lblPulso
        '
        Me.lblPulso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPulso.AutoSize = True
        Me.lblPulso.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPulso.Location = New System.Drawing.Point(854, 39)
        Me.lblPulso.Name = "lblPulso"
        Me.lblPulso.Size = New System.Drawing.Size(86, 29)
        Me.lblPulso.TabIndex = 2
        Me.lblPulso.Tag = "p8"
        Me.lblPulso.Text = "Pulso:"
        '
        'lblTemperatura
        '
        Me.lblTemperatura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTemperatura.AutoSize = True
        Me.lblTemperatura.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperatura.Location = New System.Drawing.Point(206, 37)
        Me.lblTemperatura.Name = "lblTemperatura"
        Me.lblTemperatura.Size = New System.Drawing.Size(162, 29)
        Me.lblTemperatura.TabIndex = 0
        Me.lblTemperatura.Tag = "p7"
        Me.lblTemperatura.Text = "Temperatura:"
        '
        'frmGenerico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1300, 1000)
        Me.Controls.Add(Me.pnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGenerico"
        Me.Text = "frmGenericoTest"
        Me.pnlContenedor.ResumeLayout(False)
        Me.gbInspeccionGeneral.ResumeLayout(False)
        Me.gbInspeccionGeneral.PerformLayout()
        Me.gbConstantesVitales.ResumeLayout(False)
        Me.gbConstantesVitales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlContenedor As Panel
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
End Class
