﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MsgBoxTipoDeTextBox
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
        Me.lblSeleccioneTipoDeDato = New System.Windows.Forms.Label()
        Me.cbPreguntas = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblSeleccioneTipoDeDato
        '
        Me.lblSeleccioneTipoDeDato.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccioneTipoDeDato.Location = New System.Drawing.Point(12, 46)
        Me.lblSeleccioneTipoDeDato.Name = "lblSeleccioneTipoDeDato"
        Me.lblSeleccioneTipoDeDato.Size = New System.Drawing.Size(757, 36)
        Me.lblSeleccioneTipoDeDato.TabIndex = 3
        Me.lblSeleccioneTipoDeDato.Text = "Seleccione la pregunta que será respondida en este campo"
        Me.lblSeleccioneTipoDeDato.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbPreguntas
        '
        Me.cbPreguntas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPreguntas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPreguntas.FormattingEnabled = True
        Me.cbPreguntas.IntegralHeight = False
        Me.cbPreguntas.Location = New System.Drawing.Point(12, 112)
        Me.cbPreguntas.Name = "cbPreguntas"
        Me.cbPreguntas.Size = New System.Drawing.Size(757, 37)
        Me.cbPreguntas.TabIndex = 2
        '
        'MsgBoxTipoDeTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(781, 181)
        Me.Controls.Add(Me.lblSeleccioneTipoDeDato)
        Me.Controls.Add(Me.cbPreguntas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MsgBoxTipoDeTextBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MsgBoxTipoDeTextBox"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblSeleccioneTipoDeDato As Label
    Friend WithEvents cbPreguntas As ComboBox
End Class
