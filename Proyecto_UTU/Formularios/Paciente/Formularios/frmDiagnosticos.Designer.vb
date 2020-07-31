<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDiagnosticos
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
        Me.cbDiagnostico = New System.Windows.Forms.ComboBox()
        Me.cbVista = New System.Windows.Forms.ComboBox()
        Me.pnlContenedorDiagnosticos = New System.Windows.Forms.Panel()
        Me.tabPanelDiagnostico = New System.Windows.Forms.TabControl()
        Me.tabPageResolución = New System.Windows.Forms.TabPage()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblNombreEnfermedad = New System.Windows.Forms.Label()
        Me.lblPresenta = New System.Windows.Forms.Label()
        Me.tabPageTratamiento = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabPageSintomas = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbSintomas = New System.Windows.Forms.ListBox()
        Me.tabPageConstantesVitales = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlContenedorDiagnosticos.SuspendLayout()
        Me.tabPanelDiagnostico.SuspendLayout()
        Me.tabPageResolución.SuspendLayout()
        Me.tabPageTratamiento.SuspendLayout()
        Me.tabPageSintomas.SuspendLayout()
        Me.tabPageConstantesVitales.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbDiagnostico
        '
        Me.cbDiagnostico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbDiagnostico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDiagnostico.FormattingEnabled = True
        Me.cbDiagnostico.Items.AddRange(New Object() {"Seleccione un diagnóstico"})
        Me.cbDiagnostico.Location = New System.Drawing.Point(693, 12)
        Me.cbDiagnostico.Name = "cbDiagnostico"
        Me.cbDiagnostico.Size = New System.Drawing.Size(191, 24)
        Me.cbDiagnostico.TabIndex = 1
        '
        'cbVista
        '
        Me.cbVista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVista.FormattingEnabled = True
        Me.cbVista.Items.AddRange(New Object() {"Vista Simple", "Vista Completa"})
        Me.cbVista.Location = New System.Drawing.Point(16, 12)
        Me.cbVista.Name = "cbVista"
        Me.cbVista.Size = New System.Drawing.Size(191, 24)
        Me.cbVista.TabIndex = 3
        '
        'pnlContenedorDiagnosticos
        '
        Me.pnlContenedorDiagnosticos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContenedorDiagnosticos.AutoSize = True
        Me.pnlContenedorDiagnosticos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlContenedorDiagnosticos.Controls.Add(Me.tabPanelDiagnostico)
        Me.pnlContenedorDiagnosticos.Location = New System.Drawing.Point(16, 42)
        Me.pnlContenedorDiagnosticos.Name = "pnlContenedorDiagnosticos"
        Me.pnlContenedorDiagnosticos.Size = New System.Drawing.Size(870, 497)
        Me.pnlContenedorDiagnosticos.TabIndex = 7
        '
        'tabPanelDiagnostico
        '
        Me.tabPanelDiagnostico.Controls.Add(Me.tabPageResolución)
        Me.tabPanelDiagnostico.Controls.Add(Me.tabPageTratamiento)
        Me.tabPanelDiagnostico.Controls.Add(Me.tabPageSintomas)
        Me.tabPanelDiagnostico.Controls.Add(Me.tabPageConstantesVitales)
        Me.tabPanelDiagnostico.Location = New System.Drawing.Point(3, 3)
        Me.tabPanelDiagnostico.Name = "tabPanelDiagnostico"
        Me.tabPanelDiagnostico.SelectedIndex = 0
        Me.tabPanelDiagnostico.Size = New System.Drawing.Size(862, 489)
        Me.tabPanelDiagnostico.TabIndex = 7
        '
        'tabPageResolución
        '
        Me.tabPageResolución.Controls.Add(Me.txtDescripcion)
        Me.tabPageResolución.Controls.Add(Me.lblDescripcion)
        Me.tabPageResolución.Controls.Add(Me.lblNombreEnfermedad)
        Me.tabPageResolución.Controls.Add(Me.lblPresenta)
        Me.tabPageResolución.Location = New System.Drawing.Point(4, 25)
        Me.tabPageResolución.Name = "tabPageResolución"
        Me.tabPageResolución.Size = New System.Drawing.Size(854, 460)
        Me.tabPageResolución.TabIndex = 2
        Me.tabPageResolución.Text = "Resolución"
        Me.tabPageResolución.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtDescripcion.Location = New System.Drawing.Point(7, 176)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(842, 281)
        Me.txtDescripcion.TabIndex = 8
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(354, 138)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(141, 29)
        Me.lblDescripcion.TabIndex = 7
        Me.lblDescripcion.Text = "Descripción"
        '
        'lblNombreEnfermedad
        '
        Me.lblNombreEnfermedad.AutoSize = True
        Me.lblNombreEnfermedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEnfermedad.Location = New System.Drawing.Point(134, 25)
        Me.lblNombreEnfermedad.Name = "lblNombreEnfermedad"
        Me.lblNombreEnfermedad.Size = New System.Drawing.Size(158, 20)
        Me.lblNombreEnfermedad.TabIndex = 1
        Me.lblNombreEnfermedad.Text = "NombreEnfermedad"
        '
        'lblPresenta
        '
        Me.lblPresenta.AutoSize = True
        Me.lblPresenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresenta.Location = New System.Drawing.Point(13, 18)
        Me.lblPresenta.Name = "lblPresenta"
        Me.lblPresenta.Size = New System.Drawing.Size(115, 29)
        Me.lblPresenta.TabIndex = 0
        Me.lblPresenta.Text = "Presenta:"
        '
        'tabPageTratamiento
        '
        Me.tabPageTratamiento.Controls.Add(Me.Label2)
        Me.tabPageTratamiento.Location = New System.Drawing.Point(4, 25)
        Me.tabPageTratamiento.Name = "tabPageTratamiento"
        Me.tabPageTratamiento.Size = New System.Drawing.Size(854, 460)
        Me.tabPageTratamiento.TabIndex = 3
        Me.tabPageTratamiento.Text = "Plan de tratamiento"
        Me.tabPageTratamiento.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(210, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(390, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tratamiento recomendado a seguir"
        '
        'tabPageSintomas
        '
        Me.tabPageSintomas.Controls.Add(Me.Label3)
        Me.tabPageSintomas.Controls.Add(Me.TextBox1)
        Me.tabPageSintomas.Controls.Add(Me.Label1)
        Me.tabPageSintomas.Controls.Add(Me.lbSintomas)
        Me.tabPageSintomas.Location = New System.Drawing.Point(4, 25)
        Me.tabPageSintomas.Name = "tabPageSintomas"
        Me.tabPageSintomas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageSintomas.Size = New System.Drawing.Size(854, 460)
        Me.tabPageSintomas.TabIndex = 0
        Me.tabPageSintomas.Text = "Síntomas"
        Me.tabPageSintomas.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(329, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Observaciones"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(6, 271)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(842, 183)
        Me.TextBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sintomas descubiertos"
        '
        'lbSintomas
        '
        Me.lbSintomas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSintomas.FormattingEnabled = True
        Me.lbSintomas.ItemHeight = 22
        Me.lbSintomas.Items.AddRange(New Object() {"sintoma1", "sintoma2", "sintoma3", "sintoma4", "........."})
        Me.lbSintomas.Location = New System.Drawing.Point(6, 50)
        Me.lbSintomas.Name = "lbSintomas"
        Me.lbSintomas.Size = New System.Drawing.Size(842, 158)
        Me.lbSintomas.TabIndex = 0
        '
        'tabPageConstantesVitales
        '
        Me.tabPageConstantesVitales.Controls.Add(Me.Label10)
        Me.tabPageConstantesVitales.Controls.Add(Me.Label11)
        Me.tabPageConstantesVitales.Controls.Add(Me.Label8)
        Me.tabPageConstantesVitales.Controls.Add(Me.Label9)
        Me.tabPageConstantesVitales.Controls.Add(Me.Label6)
        Me.tabPageConstantesVitales.Controls.Add(Me.Label7)
        Me.tabPageConstantesVitales.Controls.Add(Me.Label5)
        Me.tabPageConstantesVitales.Controls.Add(Me.Label4)
        Me.tabPageConstantesVitales.Location = New System.Drawing.Point(4, 25)
        Me.tabPageConstantesVitales.Name = "tabPageConstantesVitales"
        Me.tabPageConstantesVitales.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageConstantesVitales.Size = New System.Drawing.Size(854, 460)
        Me.tabPageConstantesVitales.TabIndex = 1
        Me.tabPageConstantesVitales.Text = "Constantes Vitales"
        Me.tabPageConstantesVitales.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(351, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 17)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "valorTemperatura"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(170, 29)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Temperatura:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(351, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "frecuenciaRespiratoria"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(291, 29)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Frecuencia respiratoria:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(351, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "frecuenciaCardíaca"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(256, 29)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Frecuencia cardiaca:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(351, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "valorPulso"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 29)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Pulso:"
        '
        'frmDiagnosticos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 551)
        Me.Controls.Add(Me.pnlContenedorDiagnosticos)
        Me.Controls.Add(Me.cbVista)
        Me.Controls.Add(Me.cbDiagnostico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDiagnosticos"
        Me.Text = "frmDiagnosticos"
        Me.pnlContenedorDiagnosticos.ResumeLayout(False)
        Me.tabPanelDiagnostico.ResumeLayout(False)
        Me.tabPageResolución.ResumeLayout(False)
        Me.tabPageResolución.PerformLayout()
        Me.tabPageTratamiento.ResumeLayout(False)
        Me.tabPageTratamiento.PerformLayout()
        Me.tabPageSintomas.ResumeLayout(False)
        Me.tabPageSintomas.PerformLayout()
        Me.tabPageConstantesVitales.ResumeLayout(False)
        Me.tabPageConstantesVitales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbDiagnostico As ComboBox
    Friend WithEvents cbVista As ComboBox
    Friend WithEvents pnlContenedorDiagnosticos As Panel
    Friend WithEvents tabPanelDiagnostico As TabControl
    Friend WithEvents tabPageResolución As TabPage
    Friend WithEvents lblNombreEnfermedad As Label
    Friend WithEvents lblPresenta As Label
    Friend WithEvents tabPageTratamiento As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents tabPageSintomas As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbSintomas As ListBox
    Friend WithEvents tabPageConstantesVitales As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblDescripcion As Label
End Class
