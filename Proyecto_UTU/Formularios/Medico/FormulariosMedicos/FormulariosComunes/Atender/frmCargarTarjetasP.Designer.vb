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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tblAcciones = New System.Windows.Forms.TableLayoutPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAtender = New System.Windows.Forms.Button()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.tblTarjetas = New System.Windows.Forms.TableLayoutPanel()
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
        Me.tblAcciones.Controls.Add(Me.Button3, 0, 3)
        Me.tblAcciones.Controls.Add(Me.Button2, 0, 2)
        Me.tblAcciones.Controls.Add(Me.Button1, 0, 1)
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
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightCoral
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(3, 150)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(1118, 44)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Ver tratamientos"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGreen
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(3, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(1118, 43)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Ver análisis"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumPurple
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1118, 43)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Ver consultas previas"
        Me.Button1.UseVisualStyleBackColor = False
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
        'btnRefrescar
        '
        Me.btnRefrescar.BackgroundImage = CType(resources.GetObject("btnRefrescar.BackgroundImage"), System.Drawing.Image)
        Me.btnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRefrescar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefrescar.Location = New System.Drawing.Point(1071, 3)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(50, 37)
        Me.btnRefrescar.TabIndex = 2
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'tblTarjetas
        '
        Me.tblTarjetas.AutoScroll = True
        Me.tblTarjetas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tblTarjetas.ColumnCount = 1
        Me.tblTarjetas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTarjetas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblTarjetas.Location = New System.Drawing.Point(3, 46)
        Me.tblTarjetas.Name = "tblTarjetas"
        Me.tblTarjetas.RowCount = 1
        Me.tblTarjetas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTarjetas.Size = New System.Drawing.Size(1118, 464)
        Me.tblTarjetas.TabIndex = 3
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
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAtender As Button
    Friend WithEvents tblTarjetasYRefrescar As TableLayoutPanel
    Friend WithEvents btnRefrescar As Button
    Friend WithEvents tblTarjetas As TableLayoutPanel
End Class
