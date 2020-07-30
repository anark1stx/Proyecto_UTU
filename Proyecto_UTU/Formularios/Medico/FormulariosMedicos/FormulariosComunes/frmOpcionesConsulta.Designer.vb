<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpcionesConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpcionesConsulta))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnIdentificacion = New System.Windows.Forms.Button()
        Me.btnEntrevistaPaciente = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.58257!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnEntrevistaPaciente, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnIdentificacion, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(896, 555)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnIdentificacion
        '
        Me.btnIdentificacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIdentificacion.Image = CType(resources.GetObject("btnIdentificacion.Image"), System.Drawing.Image)
        Me.btnIdentificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIdentificacion.Location = New System.Drawing.Point(3, 3)
        Me.btnIdentificacion.Name = "btnIdentificacion"
        Me.btnIdentificacion.Size = New System.Drawing.Size(890, 271)
        Me.btnIdentificacion.TabIndex = 2
        Me.btnIdentificacion.Text = "Identificación del paciente"
        Me.btnIdentificacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIdentificacion.UseVisualStyleBackColor = True
        '
        'btnEntrevistaPaciente
        '
        Me.btnEntrevistaPaciente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEntrevistaPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrevistaPaciente.Image = CType(resources.GetObject("btnEntrevistaPaciente.Image"), System.Drawing.Image)
        Me.btnEntrevistaPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntrevistaPaciente.Location = New System.Drawing.Point(3, 280)
        Me.btnEntrevistaPaciente.Name = "btnEntrevistaPaciente"
        Me.btnEntrevistaPaciente.Size = New System.Drawing.Size(890, 272)
        Me.btnEntrevistaPaciente.TabIndex = 4
        Me.btnEntrevistaPaciente.Text = "Entrevista al paciente"
        Me.btnEntrevistaPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEntrevistaPaciente.UseVisualStyleBackColor = True
        '
        'frmOpcionesConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 555)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOpcionesConsulta"
        Me.Text = "frmOpcionesConsulta"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnIdentificacion As Button
    Friend WithEvents btnEntrevistaPaciente As Button
End Class
