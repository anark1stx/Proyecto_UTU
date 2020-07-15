Public Class frmAdministrador
#Region "Instancias_formularios"
    Dim _frmInicio As New frmInicioAdministrador
    Dim _frmGestion As New frmGestion

    Dim _frmDatosPaciente As New frmDatosPaciente
    Dim _frmDatosMedico As New frmDatosMedico

    Dim _frmModificarPaciente As New frmDatosPacienteModificar 'El formulario de modificación es el mismo que el formulario de alta.
    Dim _frmModificarMedico As New frmDatosMedicoModificar 'El formulario de modificación es el mismo que el formulario de alta.
#End Region

    Public Sub InstanciarFormulario(formularioPadre As String, formularioHijo As String)

        Select Case formularioPadre

            Case "Inicio"
                If Not pnlContenedor.Controls.Contains(_frmInicio) Then
                    pnlContenedor.Controls.Clear()
                    _frmInicio.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmConsulta no está en el nivel más alto.
                    _frmInicio.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.
                    Me.pnlContenedor.Controls.Add(_frmInicio) 'Añadir el formulario al panel
                    _frmInicio.Show()
                End If


            Case "Gestion"

                If Not pnlContenedor.Controls.Contains(_frmGestion) Then
                    pnlContenedor.Controls.Clear()
                    _frmGestion.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmConsulta no está en el nivel más alto.
                    _frmGestion.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.
                    Me.pnlContenedor.Controls.Add(_frmGestion) 'Añadir el formulario al panel
                    _frmGestion.Show()
                End If

                Select Case formularioHijo
                    Case "DatosPaciente" 'Las queries van a filtrar por defecto solo a usuarios Paciente

                        _frmGestion.pnlDatosUsuario.Controls.Clear()
                        _frmGestion.pnlContenedorBusqueda.Show()
                        _frmDatosPaciente.TopLevel = False
                        _frmDatosPaciente.TopMost = True
                        _frmGestion.pnlDatosUsuario.Controls.Add(_frmDatosPaciente)


                        _frmDatosPaciente.Show()

                    Case "DatosMedico" 'Las queries van a filtrar por defecto solo a usuarios Medico

                        _frmGestion.pnlDatosUsuario.Controls.Clear()
                        _frmGestion.pnlContenedorBusqueda.Show()
                        _frmDatosMedico.TopLevel = False
                        _frmDatosMedico.TopMost = True
                        _frmGestion.pnlDatosUsuario.Controls.Add(_frmDatosMedico)

                        _frmDatosMedico.Show()

                    Case "ModificarPaciente" 'Las queries van a filtrar por defecto solo a usuarios Paciente

                        _frmGestion.pnlDatosUsuario.Controls.Clear()
                        _frmGestion.pnlContenedorBusqueda.Show()
                        _frmModificarPaciente.TopLevel = False
                        _frmModificarPaciente.TopMost = True
                        _frmGestion.pnlDatosUsuario.Controls.Add(_frmModificarPaciente)

                        _frmModificarPaciente.Show()

                    Case "ModificarMedico" 'Las queries van a filtrar por defecto solo a usuarios Paciente

                        _frmGestion.pnlDatosUsuario.Controls.Clear()
                        _frmGestion.pnlContenedorBusqueda.Show()
                        _frmModificarMedico.TopLevel = False
                        _frmModificarMedico.TopMost = True
                        _frmGestion.pnlDatosUsuario.Controls.Add(_frmModificarMedico)

                        _frmModificarMedico.Show()

                    Case "BajaPaciente" 'Las queries van a filtrar por defecto solo a usuarios Paciente

                        _frmGestion.pnlDatosUsuario.Controls.Clear()
                        _frmGestion.pnlContenedorBusqueda.Show()
                        _frmDatosPaciente.TopLevel = False
                        _frmDatosPaciente.TopMost = True
                        _frmGestion.pnlDatosUsuario.Controls.Add(_frmDatosPaciente)

                        _frmDatosPaciente.Show()

                    Case "BajaMedico" 'Las queries van a filtrar por defecto solo a usuarios Paciente

                        _frmGestion.pnlDatosUsuario.Controls.Clear()
                        _frmGestion.pnlContenedorBusqueda.Show()
                        _frmDatosPaciente.TopLevel = False
                        _frmDatosPaciente.TopMost = True
                        _frmGestion.pnlDatosUsuario.Controls.Add(_frmDatosPaciente)

                        _frmDatosPaciente.Show()

                    Case "AltaPaciente" 'Las queries van a filtrar por defecto solo a usuarios Paciente

                        _frmGestion.pnlDatosUsuario.Controls.Clear()
                        _frmGestion.pnlContenedorBusqueda.Hide()
                        _frmModificarPaciente.TopLevel = False
                        _frmModificarPaciente.TopMost = True
                        _frmGestion.pnlDatosUsuario.Controls.Add(_frmModificarPaciente)

                        _frmModificarPaciente.Show()

                    Case "AltaMedico" 'Las queries van a filtrar por defecto solo a usuarios Paciente

                        _frmGestion.pnlDatosUsuario.Controls.Clear()
                        _frmGestion.pnlContenedorBusqueda.Hide()
                        _frmModificarMedico.TopLevel = False
                        _frmModificarMedico.TopMost = True
                        _frmGestion.pnlDatosUsuario.Controls.Add(_frmModificarMedico)

                        _frmModificarMedico.Show()
                End Select

        End Select
    End Sub

#Region "Eventos"
    Private Sub MédicoBusquedaMenuItem_Click(sender As Object, e As EventArgs) Handles MédicoBusquedaMenuItem.Click
        InstanciarFormulario("Gestion", "DatosMedico")
    End Sub

    Private Sub PacienteBusquedaMenuItem_Click(sender As Object, e As EventArgs) Handles PacienteBusquedaMenuItem.Click
        InstanciarFormulario("Gestion", "DatosPaciente")
    End Sub

    Private Sub PacienteModificacionMenuItem_Click(sender As Object, e As EventArgs) Handles PacienteModificacionMenuItem.Click
        InstanciarFormulario("Gestion", "ModificarPaciente")
    End Sub


    Private Sub MedicoModificacionMenuItem_Click(sender As Object, e As EventArgs) Handles MedicoModificacionMenuItem.Click
        InstanciarFormulario("Gestion", "ModificarMedico")
    End Sub

    Private Sub PacienteBajaMenuItem_Click(sender As Object, e As EventArgs) Handles PacienteBajaMenuItem.Click
        InstanciarFormulario("Gestion", "BajaPaciente")
    End Sub

    Private Sub MedicoBajaMenuItem_Click(sender As Object, e As EventArgs) Handles MedicoBajaMenuItem.Click
        InstanciarFormulario("Gestion", "BajaMedico")
    End Sub

    Private Sub PacienteAltaMenuItem_Click(sender As Object, e As EventArgs) Handles PacienteAltaMenuItem.Click
        InstanciarFormulario("Gestion", "AltaPaciente")
    End Sub

    Private Sub MedicoAltaMenuItem_Click(sender As Object, e As EventArgs) Handles MedicoAltaMenuItem.Click
        InstanciarFormulario("Gestion", "AltaMedico")
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        InstanciarFormulario("Inicio", "")
    End Sub

    Private Sub frmAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicioToolStripMenuItem_Click(sender, e)
    End Sub
#End Region

End Class