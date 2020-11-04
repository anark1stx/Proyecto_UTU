Imports Entidades
Imports Utilidades
Public Class frmAdministrador
    Dim _frmInicio As New frmInicioAdm 'Este es el formulario que muestra los botones grandes para hacer ABMLB

    Dim _frmGestion As New frmGestion 'Gestion muestra Datos[tipoUsuario] + DatagridView que lista a los usuarios según parametros de busqueda
    Friend Sub InstanciarFormulario(formularioPadre As String, Optional uType As frmGestion.TipoUsuario = Nothing, Optional aType As frmGestion.Accion = Nothing)
        Select Case formularioPadre
            Case "Inicio"
                addFrm(_frmInicio, pnlContenedor)
            Case "Gestion"
                _frmGestion.Usuario = uType
                _frmGestion.Mode = aType
                addFrm(_frmGestion, pnlContenedor)
                LimpiarControles(_frmGestion)
                _frmGestion.Usuario = uType
                _frmGestion.Mode = aType
                _frmGestion.RRefresh()
                _frmGestion.setup()
        End Select
    End Sub
    Private Sub PacienteModificacionMenuItem_Click(sender As Object, e As EventArgs) Handles PacienteModificacionMenuItem.Click
        InstanciarFormulario("Gestion", frmGestion.TipoUsuario.Paciente, frmGestion.Accion.Modificacion)
    End Sub

    Private Sub MedicoModificacionMenuItem_Click(sender As Object, e As EventArgs) Handles MedicoModificacionMenuItem.Click
        InstanciarFormulario("Gestion", frmGestion.TipoUsuario.Medico, frmGestion.Accion.Modificacion)
    End Sub

    Private Sub PacienteBajaMenuItem_Click(sender As Object, e As EventArgs) Handles PacienteBajaMenuItem.Click, PacienteBusquedaMenuItem.Click
        InstanciarFormulario("Gestion", frmGestion.TipoUsuario.Paciente, frmGestion.Accion.Baja)
    End Sub

    Private Sub MedicoBajaMenuItem_Click(sender As Object, e As EventArgs) Handles MedicoBajaMenuItem.Click, MedicoBusquedaMenuItem.Click
        InstanciarFormulario("Gestion", frmGestion.TipoUsuario.Medico, frmGestion.Accion.Baja)
    End Sub

    Private Sub PacienteAltaMenuItem_Click(sender As Object, e As EventArgs) Handles PacienteAltaMenuItem.Click
        InstanciarFormulario("Gestion", frmGestion.TipoUsuario.Paciente, frmGestion.Accion.Alta)
    End Sub

    Private Sub MedicoAltaMenuItem_Click(sender As Object, e As EventArgs) Handles MedicoAltaMenuItem.Click
        InstanciarFormulario("Gestion", frmGestion.TipoUsuario.Medico, frmGestion.Accion.Alta)
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioMenuItem.Click
        InstanciarFormulario("Inicio")
    End Sub

    Private Sub frmAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        agregarHandlers()
        InicioToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub AuxiliarAltaMenuItem_Click(sender As Object, e As EventArgs) Handles AuxiliarMenuItemAlta.Click
        InstanciarFormulario("Gestion", frmGestion.TipoUsuario.Auxiliar, frmGestion.Accion.Alta)
    End Sub

    Private Sub AuxiliarModificacionMenuItem_Click(sender As Object, e As EventArgs) Handles AuxiliarMenuItemModificar.Click
        InstanciarFormulario("Gestion", frmGestion.TipoUsuario.Auxiliar, frmGestion.Accion.Modificacion)
    End Sub

    Private Sub AuxiliarMenuItemBaja_Click(sender As Object, e As EventArgs) Handles AuxiliarBusquedaMenuItem.Click, AuxiliarMenuItemBaja.Click
        InstanciarFormulario("Gestion", frmGestion.TipoUsuario.Auxiliar, frmGestion.Accion.Baja)
    End Sub

    Public Sub agregarHandlers()
        AddHandler _frmInicio.btnAltaPaciente.Click, AddressOf PacienteAltaMenuItem_Click
        AddHandler _frmInicio.btnBajaPaciente.Click, AddressOf PacienteBajaMenuItem_Click
        AddHandler _frmInicio.btnModificarPaciente.Click, AddressOf PacienteModificacionMenuItem_Click
        AddHandler _frmInicio.btnBusquedaPaciente.Click, AddressOf PacienteBajaMenuItem_Click
        AddHandler _frmInicio.btnAltaMedico.Click, AddressOf MedicoAltaMenuItem_Click
        AddHandler _frmInicio.btnBajaMedico.Click, AddressOf MedicoBajaMenuItem_Click
        AddHandler _frmInicio.btnModificarMedico.Click, AddressOf MedicoModificacionMenuItem_Click
        AddHandler _frmInicio.btnBusquedaMedico.Click, AddressOf MedicoBajaMenuItem_Click
        AddHandler _frmInicio.btnAltaAuxiliar.Click, AddressOf AuxiliarAltaMenuItem_Click
        AddHandler _frmInicio.btnBajaAuxiliar.Click, AddressOf AuxiliarMenuItemBaja_Click
        AddHandler _frmInicio.btnModificarAuxiliar.Click, AddressOf AuxiliarModificacionMenuItem_Click
        AddHandler _frmInicio.btnBusquedaAuxiliar.Click, AddressOf AuxiliarMenuItemBaja_Click
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GestionarPersonalMedicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarPersonalMedicoToolStripMenuItem.Click
        Dim gestionarPMedico As New frmGestionPMedico
        gestionarPMedico.ShowDialog()
    End Sub
End Class