<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarTarjetasP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargarTarjetasP))
        Me.tblTodo = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlTodo = New System.Windows.Forms.Panel()
        Me.tblTarjetasYRefrescar = New System.Windows.Forms.TableLayoutPanel()
        Me.tblTarjetas = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tblAcciones = New System.Windows.Forms.TableLayoutPanel()
        Me.btnVerTratamientos = New System.Windows.Forms.Button()
        Me.btnVerAnalisis = New System.Windows.Forms.Button()
        Me.btnVerConsultasPrevias = New System.Windows.Forms.Button()
        Me.btnAtender = New System.Windows.Forms.Button()
        Me.tblTodo.SuspendLayout()
        Me.pnlTodo.SuspendLayout()
        Me.tblTarjetasYRefrescar.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tblAcciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblTodo
        '
        Me.tblTodo.ColumnCount = 1
        Me.tblTodo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTodo.Controls.Add(Me.pnlTodo, 0, 0)
        Me.tblTodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblTodo.Location = New System.Drawing.Point(0, 0)
        Me.tblTodo.Name = "tblTodo"
        Me.tblTodo.RowCount = 1
        Me.tblTodo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTodo.Size = New System.Drawing.Size(1130, 720)
        Me.tblTodo.TabIndex = 0
        '
        'pnlTodo
        '
        Me.pnlTodo.Controls.Add(Me.tblTarjetasYRefrescar)
        Me.pnlTodo.Controls.Add(Me.Panel2)
        Me.pnlTodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTodo.Location = New System.Drawing.Point(3, 3)
        Me.pnlTodo.Name = "pnlTodo"
        Me.pnlTodo.Size = New System.Drawing.Size(1124, 714)
        Me.pnlTodo.TabIndex = 0
        '
        'tblTarjetasYRefrescar
        '
        Me.tblTarjetasYRefrescar.AutoScroll = True
        Me.tblTarjetasYRefrescar.ColumnCount = 1
        Me.tblTarjetasYRefrescar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTarjetasYRefrescar.Controls.Add(Me.tblTarjetas, 0, 1)
        Me.tblTarjetasYRefrescar.Controls.Add(Me.btnRefrescar, 0, 0)
        Me.tblTarjetasYRefrescar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblTarjetasYRefrescar.Location = New System.Drawing.Point(0, 0)
        Me.tblTarjetasYRefrescar.Name = "tblTarjetasYRefrescar"
        Me.tblTarjetasYRefrescar.RowCount = 2
        Me.tblTarjetasYRefrescar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.382067!))
        Me.tblTarjetasYRefrescar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.61794!))
        Me.tblTarjetasYRefrescar.Size = New System.Drawing.Size(1124, 513)
        Me.tblTarjetasYRefrescar.TabIndex = 1
        '
        'tblTarjetas
        '
        Me.tblTarjetas.AutoScroll = True
        Me.tblTarjetas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tblTarjetas.ColumnCount = 1
        Me.tblTarjetas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTarjetas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblTarjetas.Location = New System.Drawing.Point(3, 45)
        Me.tblTarjetas.Name = "tblTarjetas"
        Me.tblTarjetas.RowCount = 1
        Me.tblTarjetas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTarjetas.Size = New System.Drawing.Size(1118, 465)
        Me.tblTarjetas.TabIndex = 3
        '
        'btnRefrescar
        '
        Me.btnRefrescar.BackgroundImage = CType(resources.GetObject("btnRefrescar.BackgroundImage"), System.Drawing.Image)
        Me.btnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRefrescar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefrescar.Location = New System.Drawing.Point(1071, 3)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(50, 36)
        Me.btnRefrescar.TabIndex = 2
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tblAcciones)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 513)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1124, 201)
        Me.Panel2.TabIndex = 0
        '
        'tblAcciones
        '
        Me.tblAcciones.ColumnCount = 1
        Me.tblAcciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblAcciones.Controls.Add(Me.btnVerTratamientos, 0, 3)
        Me.tblAcciones.Controls.Add(Me.btnVerAnalisis, 0, 2)
        Me.tblAcciones.Controls.Add(Me.btnVerConsultasPrevias, 0, 1)
        Me.tblAcciones.Controls.Add(Me.btnAtender, 0, 0)
        Me.tblAcciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tblAcciones.Location = New System.Drawing.Point(0, 4)
        Me.tblAcciones.Name = "tblAcciones"
        Me.tblAcciones.RowCount = 4
        Me.tblAcciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblAcciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblAcciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblAcciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblAcciones.Size = New System.Drawing.Size(1124, 197)
        Me.tblAcciones.TabIndex = 3
        '
        'btnVerTratamientos
        '
        Me.btnVerTratamientos.BackColor = System.Drawing.Color.LightCoral
        Me.btnVerTratamientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnVerTratamientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerTratamientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerTratamientos.Location = New System.Drawing.Point(3, 150)
        Me.btnVerTratamientos.Name = "btnVerTratamientos"
        Me.btnVerTratamientos.Size = New System.Drawing.Size(1118, 44)
        Me.btnVerTratamientos.TabIndex = 5
        Me.btnVerTratamientos.Text = "Ver tratamientos"
        Me.btnVerTratamientos.UseVisualStyleBackColor = False
        '
        'btnVerAnalisis
        '
        Me.btnVerAnalisis.BackColor = System.Drawing.Color.LightGreen
        Me.btnVerAnalisis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnVerAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerAnalisis.Location = New System.Drawing.Point(3, 101)
        Me.btnVerAnalisis.Name = "btnVerAnalisis"
        Me.btnVerAnalisis.Size = New System.Drawing.Size(1118, 43)
        Me.btnVerAnalisis.TabIndex = 4
        Me.btnVerAnalisis.Text = "Ver análisis"
        Me.btnVerAnalisis.UseVisualStyleBackColor = False
        '
        'btnVerConsultasPrevias
        '
        Me.btnVerConsultasPrevias.BackColor = System.Drawing.Color.MediumPurple
        Me.btnVerConsultasPrevias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnVerConsultasPrevias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerConsultasPrevias.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerConsultasPrevias.Location = New System.Drawing.Point(3, 52)
        Me.btnVerConsultasPrevias.Name = "btnVerConsultasPrevias"
        Me.btnVerConsultasPrevias.Size = New System.Drawing.Size(1118, 43)
        Me.btnVerConsultasPrevias.TabIndex = 3
        Me.btnVerConsultasPrevias.Text = "Ver consultas previas"
        Me.btnVerConsultasPrevias.UseVisualStyleBackColor = False
        '
        'btnAtender
        '
        Me.btnAtender.BackColor = System.Drawing.Color.SkyBlue
        Me.btnAtender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAtender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtender.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtender.Location = New System.Drawing.Point(3, 3)
        Me.btnAtender.Name = "btnAtender"
        Me.btnAtender.Size = New System.Drawing.Size(1118, 43)
        Me.btnAtender.TabIndex = 2
        Me.btnAtender.Text = "Atender"
        Me.btnAtender.UseVisualStyleBackColor = False
        '
        'frmCargarTarjetasP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1130, 720)
        Me.Controls.Add(Me.tblTodo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCargarTarjetasP"
        Me.Text = "frmCargarTarjetasP"
        Me.tblTodo.ResumeLayout(False)
        Me.pnlTodo.ResumeLayout(False)
        Me.tblTarjetasYRefrescar.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.tblAcciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblTodo As TableLayoutPanel
    Friend WithEvents pnlTodo As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tblAcciones As TableLayoutPanel
    Friend WithEvents btnVerTratamientos As Button
    Friend WithEvents btnVerAnalisis As Button
    Friend WithEvents btnVerConsultasPrevias As Button
    Friend WithEvents btnAtender As Button
    Friend WithEvents tblTarjetasYRefrescar As TableLayoutPanel
    Friend WithEvents btnRefrescar As Button
    Friend WithEvents tblTarjetas As TableLayoutPanel
End Class
