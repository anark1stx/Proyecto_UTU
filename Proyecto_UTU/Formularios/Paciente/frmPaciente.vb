Imports Entidades
Imports Utilidades
Public Class frmPaciente
    Dim frmDiagnostico As New frmDiagnosticos 'Instancia de formulario que tiene los diagnosticos del paciente
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
        InstanciarFormulario("Gestion")
    End Sub

    Private Sub DiagnosticoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiagnosticoToolStripMenuItem.Click
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
                Dim frmAnalisis As New frmAnalisisSeguimiento
                frmAnalisis.MiModo = frmAnalisisSeguimiento.Modo.Buscar
                frmAnalisis.btnIngresarDatos.Visible = False
                frmAnalisis.CI_paciente = PacienteActual.Cedula
                frmAnalisis.txtBuscar.Text = PacienteActual.Cedula.ToString()
                frmAnalisis.Show()
                frmAnalisis.btnBuscar.PerformClick()
            Case "Tratamiento"
                Dim frmTratamientoC As New frmTratamientoCrear
                frmTratamientoC.CI_Paciente = PacienteActual.Cedula
                frmTratamientoC.ModoActual = frmTratamientoCrear.Modo.HistorialPacienteConsulta
                frmTratamientoC.Show()
        End Select
    End Sub

    Private Sub frmPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        agregarHandlers()
        InstanciarFormulario("Inicio")
        Me.MaximizeBox = False
        Me.WindowState = FormWindowState.Maximized
        Me.Activate()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        InstanciarFormulario("Inicio")
    End Sub
    Public Sub agregarHandlers()
        AddHandler frmIni.btnGestion.Click, AddressOf GestionToolStripMenuItem_Click
        AddHandler frmIni.btnDiagnosticos.Click, AddressOf DiagnosticoToolStripMenuItem_Click
        AddHandler frmIni.btnAnalisis.Click, AddressOf AnalisisToolStripMenuItem_Click
        AddHandler frmIni.btnTratamientos.Click, AddressOf MisTratamientosToolStripMenuItem_Click
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MisTratamientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MisTratamientosToolStripMenuItem.Click
        InstanciarFormulario("Tratamiento")
    End Sub
End Class