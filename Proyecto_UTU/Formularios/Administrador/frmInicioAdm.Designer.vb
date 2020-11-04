<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicioAdm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicioAdm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnBusquedaAuxiliar = New System.Windows.Forms.Button()
        Me.btnModificarAuxiliar = New System.Windows.Forms.Button()
        Me.btnBajaAuxiliar = New System.Windows.Forms.Button()
        Me.btnAltaAuxiliar = New System.Windows.Forms.Button()
        Me.btnBusquedaPaciente = New System.Windows.Forms.Button()
        Me.btnModificarPaciente = New System.Windows.Forms.Button()
        Me.btnBajaPaciente = New System.Windows.Forms.Button()
        Me.btnAltaPaciente = New System.Windows.Forms.Button()
        Me.btnBusquedaMedico = New System.Windows.Forms.Button()
        Me.btnModificarMedico = New System.Windows.Forms.Button()
        Me.btnBajaMedico = New System.Windows.Forms.Button()
        Me.btnAltaMedico = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.btnBusquedaMedico)
        Me.GroupBox1.Controls.Add(Me.btnModificarMedico)
        Me.GroupBox1.Controls.Add(Me.btnBajaMedico)
        Me.GroupBox1.Controls.Add(Me.btnAltaMedico)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Controls.Add(Me.btnBusquedaPaciente)
        Me.GroupBox2.Controls.Add(Me.btnModificarPaciente)
        Me.GroupBox2.Controls.Add(Me.btnBajaPaciente)
        Me.GroupBox2.Controls.Add(Me.btnAltaPaciente)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Controls.Add(Me.btnBusquedaAuxiliar)
        Me.GroupBox3.Controls.Add(Me.btnModificarAuxiliar)
        Me.GroupBox3.Controls.Add(Me.btnBajaAuxiliar)
        Me.GroupBox3.Controls.Add(Me.btnAltaAuxiliar)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'btnBusquedaAuxiliar
        '
        resources.ApplyResources(Me.btnBusquedaAuxiliar, "btnBusquedaAuxiliar")
        Me.btnBusquedaAuxiliar.Name = "btnBusquedaAuxiliar"
        Me.btnBusquedaAuxiliar.UseVisualStyleBackColor = True
        '
        'btnModificarAuxiliar
        '
        resources.ApplyResources(Me.btnModificarAuxiliar, "btnModificarAuxiliar")
        Me.btnModificarAuxiliar.Name = "btnModificarAuxiliar"
        Me.btnModificarAuxiliar.UseVisualStyleBackColor = True
        '
        'btnBajaAuxiliar
        '
        resources.ApplyResources(Me.btnBajaAuxiliar, "btnBajaAuxiliar")
        Me.btnBajaAuxiliar.Name = "btnBajaAuxiliar"
        Me.btnBajaAuxiliar.UseVisualStyleBackColor = True
        '
        'btnAltaAuxiliar
        '
        resources.ApplyResources(Me.btnAltaAuxiliar, "btnAltaAuxiliar")
        Me.btnAltaAuxiliar.Name = "btnAltaAuxiliar"
        Me.btnAltaAuxiliar.UseVisualStyleBackColor = True
        '
        'btnBusquedaPaciente
        '
        resources.ApplyResources(Me.btnBusquedaPaciente, "btnBusquedaPaciente")
        Me.btnBusquedaPaciente.Name = "btnBusquedaPaciente"
        Me.btnBusquedaPaciente.UseVisualStyleBackColor = True
        '
        'btnModificarPaciente
        '
        resources.ApplyResources(Me.btnModificarPaciente, "btnModificarPaciente")
        Me.btnModificarPaciente.Name = "btnModificarPaciente"
        Me.btnModificarPaciente.UseVisualStyleBackColor = True
        '
        'btnBajaPaciente
        '
        resources.ApplyResources(Me.btnBajaPaciente, "btnBajaPaciente")
        Me.btnBajaPaciente.Name = "btnBajaPaciente"
        Me.btnBajaPaciente.UseVisualStyleBackColor = True
        '
        'btnAltaPaciente
        '
        resources.ApplyResources(Me.btnAltaPaciente, "btnAltaPaciente")
        Me.btnAltaPaciente.Name = "btnAltaPaciente"
        Me.btnAltaPaciente.UseVisualStyleBackColor = True
        '
        'btnBusquedaMedico
        '
        resources.ApplyResources(Me.btnBusquedaMedico, "btnBusquedaMedico")
        Me.btnBusquedaMedico.Name = "btnBusquedaMedico"
        Me.btnBusquedaMedico.UseVisualStyleBackColor = True
        '
        'btnModificarMedico
        '
        resources.ApplyResources(Me.btnModificarMedico, "btnModificarMedico")
        Me.btnModificarMedico.Name = "btnModificarMedico"
        Me.btnModificarMedico.UseVisualStyleBackColor = True
        '
        'btnBajaMedico
        '
        resources.ApplyResources(Me.btnBajaMedico, "btnBajaMedico")
        Me.btnBajaMedico.Name = "btnBajaMedico"
        Me.btnBajaMedico.UseVisualStyleBackColor = True
        '
        'btnAltaMedico
        '
        resources.ApplyResources(Me.btnAltaMedico, "btnAltaMedico")
        Me.btnAltaMedico.Name = "btnAltaMedico"
        Me.btnAltaMedico.UseVisualStyleBackColor = True
        '
        'frmInicioAdm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInicioAdm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBusquedaMedico As Button
    Friend WithEvents btnModificarMedico As Button
    Friend WithEvents btnBajaMedico As Button
    Friend WithEvents btnAltaMedico As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBusquedaPaciente As Button
    Friend WithEvents btnModificarPaciente As Button
    Friend WithEvents btnBajaPaciente As Button
    Friend WithEvents btnAltaPaciente As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnBusquedaAuxiliar As Button
    Friend WithEvents btnModificarAuxiliar As Button
    Friend WithEvents btnBajaAuxiliar As Button
    Friend WithEvents btnAltaAuxiliar As Button
End Class
