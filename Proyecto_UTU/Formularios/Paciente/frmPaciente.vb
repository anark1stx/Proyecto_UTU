Imports Entidades
Imports Utilidades
Public Class frmPaciente
    Dim frmDiagnostico As New frmDiagnosticos 'Instancia de formulario que tiene los diagnosticos del paciente
    Dim frmAnalisis As New frmAnalisis 'Instancia de formulario que tiene los diagnosticos del paciente
    Dim frmGestion As New frmGestionPaciente 'Instancia del formulario que tiene la ventana de gestión del paciente
    Dim frmIni As New frmInicioPaciente
    Protected _paciente As New E_Paciente

    Property PacienteActual As E_Paciente
        Get
            Return _paciente
        End Get
        Set(value As E_Paciente)
            _paciente = value
            frmDiagnostico.CI_Paciente = value.Cedula
            frmGestion.PacienteLogeado = PacienteActual
        End Set
    End Property
    Private Sub GestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionToolStripMenuItem.Click
        'Cargar Formulario de gestión para el médico.
        InstanciarFormulario("Gestion")
    End Sub

    Private Sub DiagnosticoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiagnosticoToolStripMenuItem.Click
        'Cargar formulario de consulta con el paciente.
        InstanciarFormulario("Diagnostico")
    End Sub

    Private Sub AnalisisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnalisisToolStripMenuItem.Click
        InstanciarFormulario("Analisis")
    End Sub

    Public Sub InstanciarFormulario(formulario As String)

        Select Case formulario
            Case "Inicio"
                addFrm(frmIni, pnlContenedorFormularios)
            Case "Diagnostico"

                addFrm(frmDiagnostico, pnlContenedorFormularios)

            Case "Gestion"
                addFrm(frmGestion, pnlContenedorFormularios)

            Case "Analisis"

                addFrm(frmAnalisis, pnlContenedorFormularios)

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
        Me.Close()
    End Sub

    Public Sub agregarHandlers() 'Este evento agrega handlers a todos los formularios hijo

        'HANDLERS PARA FORMULARIO INICIO
        AddHandler frmIni.btnGestion.Click, AddressOf GestionToolStripMenuItem_Click
        AddHandler frmIni.btnDiagnosticos.Click, AddressOf DiagnosticoToolStripMenuItem_Click
        AddHandler frmIni.btnAnalisis.Click, AddressOf AnalisisToolStripMenuItem_Click
        AddHandler frmIni.btnSalir.Click, AddressOf SalirToolStripMenuItem_Click
    End Sub

End Class