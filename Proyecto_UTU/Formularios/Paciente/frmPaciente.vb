﻿Imports Entidades
Imports Negocio
Public Class frmPaciente
    Dim frmDiagnostico As New frmDiagnosticos 'Instancia de formulario que tiene los diagnosticos del paciente
    Dim frmAnalisis As New frmAnalisis 'Instancia de formulario que tiene los diagnosticos del paciente
    Dim frmGestion As New frmGestionPaciente 'Instancia del formulario que tiene la ventana de gestión del paciente
    Dim frmIni As New frmInicioPaciente
    Protected _paciente As E_Paciente

    Property PacienteActual As E_Paciente
        Get
            Return _paciente
        End Get
        Set(value As E_Paciente)
            _paciente = value
            frmDiagnostico.CI_Paciente = value.Cedula
        End Set
    End Property

    Public Sub addFrm(frm As Form)
        If Not pnlContenedorFormularios.Controls.Contains(frm) Then
            pnlContenedorFormularios.Controls.Clear()
            frm.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmConsulta no está en el nivel más alto.
            frm.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.
            Me.pnlContenedorFormularios.Controls.Add(frm) 'Añadir el formulario al panel
            frm.Show()
            frm.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub GestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionToolStripMenuItem.Click
        'Cargar Formulario de gestión para el médico.
        InstanciarFormulario("Gestion")
    End Sub

    Private Sub DiagnosticoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiagnosticoToolStripMenuItem.Click
        'Cargar formulario de consulta con el paciente.

        InstanciarFormulario("Diagnostico")
    End Sub

    Private Sub AnalisisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnalisisToolStripMenuItem.Click
        'Cargar formulario de consulta con el paciente.

        InstanciarFormulario("Analisis")
    End Sub

    Public Sub InstanciarFormulario(formulario As String)

        Select Case formulario
            Case "Inicio"
                addFrm(frmIni)
            Case "Diagnostico"

                addFrm(frmDiagnostico)

            Case "Gestion"
                frmGestion.PacienteLogeado = New E_Paciente With {.Cedula = PacienteActual.Cedula}
                addFrm(frmGestion)

            Case "Analisis"

                addFrm(frmAnalisis)

        End Select

    End Sub

    Private Sub frmPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        agregarHandlers()
        InstanciarFormulario("Inicio")

    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        InstanciarFormulario("Inicio")
    End Sub

    Public Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        e = New FormClosingEventArgs(CloseReason.UserClosing, False)
        frmPaciente_FormClosing(sender, e)
    End Sub

    Private Sub frmPaciente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.pnlContenedorFormularios.Controls.Clear()
            Me.Hide()
            InicioToolStripMenuItem_Click(sender, e) 'dejar en el formulario de inicio
            frmIngreso_Usuario.Show()
        End If
    End Sub

    Public Sub agregarHandlers() 'Este evento agrega handlers a todos los formularios hijo

        Dim sender = New Object
        Dim e = New EventArgs

        'HANDLERS PARA FORMULARIO INICIO
        AddHandler frmIni.btnGestion.Click,
                    Sub()
                        GestionToolStripMenuItem_Click(sender, e)
                    End Sub
        AddHandler frmIni.btnDiagnosticos.Click,
                    Sub()
                        DiagnosticoToolStripMenuItem_Click(sender, e)
                    End Sub
        AddHandler frmIni.btnAnalisis.Click,
                    Sub()
                        AnalisisToolStripMenuItem_Click(sender, e)
                    End Sub
        AddHandler frmIni.btnSalir.Click,
                    Sub()
                        SalirToolStripMenuItem_Click(sender, e)
                    End Sub
    End Sub

End Class