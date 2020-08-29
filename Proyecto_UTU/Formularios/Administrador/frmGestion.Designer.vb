<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestion))
        Me.pnlDatosUsuario = New System.Windows.Forms.Panel()
        Me.pnlContenedorBusqueda = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.pnl_rdbtns_ci_nom_ap = New System.Windows.Forms.Panel()
        Me.rdBtnCedula = New System.Windows.Forms.RadioButton()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgwUsuarios = New System.Windows.Forms.DataGridView()
        Me.pnlContenedorBusqueda.SuspendLayout()
        Me.pnl_rdbtns_ci_nom_ap.SuspendLayout()
        CType(Me.dgwUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlDatosUsuario
        '
        Me.pnlDatosUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDatosUsuario.Location = New System.Drawing.Point(12, 4)
        Me.pnlDatosUsuario.Name = "pnlDatosUsuario"
        Me.pnlDatosUsuario.Size = New System.Drawing.Size(1038, 238)
        Me.pnlDatosUsuario.TabIndex = 103
        '
        'pnlContenedorBusqueda
        '
        Me.pnlContenedorBusqueda.Controls.Add(Me.btnBuscar)
        Me.pnlContenedorBusqueda.Controls.Add(Me.pnl_rdbtns_ci_nom_ap)
        Me.pnlContenedorBusqueda.Controls.Add(Me.txtBuscar)
        Me.pnlContenedorBusqueda.Controls.Add(Me.dgwUsuarios)
        Me.pnlContenedorBusqueda.Location = New System.Drawing.Point(12, 248)
        Me.pnlContenedorBusqueda.Name = "pnlContenedorBusqueda"
        Me.pnlContenedorBusqueda.Size = New System.Drawing.Size(1038, 379)
        Me.pnlContenedorBusqueda.TabIndex = 104
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(1004, 13)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(34, 32)
        Me.btnBuscar.TabIndex = 110
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'pnl_rdbtns_ci_nom_ap
        '
        Me.pnl_rdbtns_ci_nom_ap.Controls.Add(Me.rdBtnCedula)
        Me.pnl_rdbtns_ci_nom_ap.Location = New System.Drawing.Point(564, 13)
        Me.pnl_rdbtns_ci_nom_ap.Name = "pnl_rdbtns_ci_nom_ap"
        Me.pnl_rdbtns_ci_nom_ap.Size = New System.Drawing.Size(294, 32)
        Me.pnl_rdbtns_ci_nom_ap.TabIndex = 109
        '
        'rdBtnCedula
        '
        Me.rdBtnCedula.AutoSize = True
        Me.rdBtnCedula.Checked = True
        Me.rdBtnCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdBtnCedula.Location = New System.Drawing.Point(209, 5)
        Me.rdBtnCedula.Name = "rdBtnCedula"
        Me.rdBtnCedula.Size = New System.Drawing.Size(82, 24)
        Me.rdBtnCedula.TabIndex = 0
        Me.rdBtnCedula.TabStop = True
        Me.rdBtnCedula.Text = "Cedula"
        Me.rdBtnCedula.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(868, 15)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(131, 27)
        Me.txtBuscar.TabIndex = 108
        '
        'dgwUsuarios
        '
        Me.dgwUsuarios.AllowUserToAddRows = False
        Me.dgwUsuarios.AllowUserToDeleteRows = False
        Me.dgwUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwUsuarios.Location = New System.Drawing.Point(0, 51)
        Me.dgwUsuarios.Name = "dgwUsuarios"
        Me.dgwUsuarios.ReadOnly = True
        Me.dgwUsuarios.RowHeadersVisible = False
        Me.dgwUsuarios.RowHeadersWidth = 51
        Me.dgwUsuarios.RowTemplate.Height = 24
        Me.dgwUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwUsuarios.Size = New System.Drawing.Size(1038, 325)
        Me.dgwUsuarios.TabIndex = 107
        '
        'frmGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1062, 639)
        Me.Controls.Add(Me.pnlContenedorBusqueda)
        Me.Controls.Add(Me.pnlDatosUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGestion"
        Me.Text = "frmGestion"
        Me.pnlContenedorBusqueda.ResumeLayout(False)
        Me.pnlContenedorBusqueda.PerformLayout()
        Me.pnl_rdbtns_ci_nom_ap.ResumeLayout(False)
        Me.pnl_rdbtns_ci_nom_ap.PerformLayout()
        CType(Me.dgwUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlDatosUsuario As Panel
    Friend WithEvents pnlContenedorBusqueda As Panel
    Friend WithEvents btnBuscar As Button
    Friend WithEvents pnl_rdbtns_ci_nom_ap As Panel
    Friend WithEvents rdBtnCedula As RadioButton
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgwUsuarios As DataGridView
End Class
