Public Class frmAdministrador
#Region "Instancias_formularios"
    Dim _frmInicio As New frmInicioAdm 'Este es el formulario que muestra los botones grandes para hacer ABMLB

    Dim _frmGestion As New frmGestion 'Gestion muestra Datos[tipoUsuario] + DatagridView que lista a los usuarios según parametros de busqueda

    Dim _frmDatosPaciente As New frmDatosPaciente 'Muestra los datos de los pacientes según sus atributos de la BD.
    Dim _frmDatosMedico As New frmDatosMedico 'Muestra los datos de los pacientes según sus atributos de la BD.
    Dim _frmDatosAuxiliar As New frmDatosAuxiliar 'Muestra los datos de los auxiliares según sus atributos de la BD.

    Dim _frmModificarPaciente As New frmDatosPacienteModificar 'El formulario de modificación es el mismo que el formulario de alta.
    Dim _frmModificarMedico As New frmDatosMedicoModificar 'El formulario de modificación es el mismo que el formulario de alta.
    Dim _frmModificarAuxiliar As New frmDatosAuxiliarModificar 'El formulario de modificación es el mismo que el formulario de alta.
#End Region

    Private Sub addFrm(frm As Form, pnl As Panel)
        If Not pnl.Controls.Contains(frm) Then
            pnl.Controls.Clear()

            frm.TopLevel = False
            frm.TopMost = True
            pnl.Controls.Add(frm)

            frm.Show()
        End If

    End Sub

    Friend Sub InstanciarFormulario(formularioPadre As String, formularioHijo As String)

        Select Case formularioPadre

            Case "Inicio"
                addFrm(_frmInicio, pnlContenedor)

            Case "Gestion"
                addFrm(_frmGestion, pnlContenedor)

                Select Case formularioHijo
#Region "Paciente"
                    Case "DatosPaciente" 'Las queries van a filtrar por defecto solo a usuarios Paciente
                        LimpiarControles(_frmDatosPaciente)
                        addFrm(_frmDatosPaciente, _frmGestion.pnlDatosUsuario)
                        _frmGestion.pnlContenedorBusqueda.Show()

                    Case "ModificarPaciente" 'Las queries van a filtrar por defecto solo a usuarios Paciente
                        LimpiarControles(_frmModificarPaciente)
                        _frmModificarPaciente.altaOmod = 1
                        _frmModificarPaciente.configurarControles()
                        addFrm(_frmModificarPaciente, _frmGestion.pnlDatosUsuario)
                        _frmGestion.pnlContenedorBusqueda.Show()
                        _frmModificarPaciente.btnAceptar.ImageIndex = 1 '1 es para que salga el botón con tick (aceptar modificacion).

                    Case "BajaPaciente" 'Las queries van a filtrar por defecto solo a usuarios Paciente
                        LimpiarControles(_frmDatosPaciente)
                        addFrm(_frmDatosPaciente, _frmGestion.pnlDatosUsuario)
                        _frmGestion.pnlContenedorBusqueda.Show()

                    Case "AltaPaciente" 'Las queries van a filtrar por defecto solo a usuarios Paciente
                        LimpiarControles(_frmModificarPaciente)
                        _frmModificarPaciente.altaOmod = 0
                        _frmModificarPaciente.configurarControles()
                        addFrm(_frmModificarPaciente, _frmGestion.pnlDatosUsuario)
                        _frmGestion.pnlContenedorBusqueda.Show()
                        _frmModificarPaciente.btnAceptar.ImageIndex = 0 '0 es para que salga el botón con + (aceptar alta).

                        _frmGestion.pnlContenedorBusqueda.Hide()

#End Region
#Region "Medico"
                    Case "DatosMedico" 'Las queries van a filtrar por defecto solo a usuarios Medico
                        LimpiarControles(_frmDatosMedico)

                        addFrm(_frmDatosMedico, _frmGestion.pnlDatosUsuario)
                        _frmGestion.pnlContenedorBusqueda.Show()

                    Case "ModificarMedico" 'Las queries van a filtrar por defecto solo a usuarios Medico
                        LimpiarControles(_frmModificarMedico)
                        _frmModificarMedico.altaOmod = 1
                        _frmModificarMedico.configurarControles()
                        addFrm(_frmModificarMedico, _frmGestion.pnlDatosUsuario)
                        _frmGestion.pnlContenedorBusqueda.Show()
                        _frmModificarMedico.btnAceptar.ImageIndex = 1 '1 es para que salga el botón con tick (aceptar modificacion).

                    Case "BajaMedico" 'Las queries van a filtrar por defecto solo a usuarios Medico
                        LimpiarControles(_frmDatosMedico)
                        addFrm(_frmDatosMedico, _frmGestion.pnlDatosUsuario)
                        _frmGestion.pnlContenedorBusqueda.Show()

                    Case "AltaMedico" 'Las queries van a filtrar por defecto solo a usuarios Medico
                        LimpiarControles(_frmModificarMedico)
                        _frmModificarMedico.altaOmod = 0
                        _frmModificarMedico.configurarControles()
                        addFrm(_frmModificarMedico, _frmGestion.pnlDatosUsuario)
                        _frmGestion.pnlContenedorBusqueda.Show()
                        _frmModificarMedico.btnAceptar.ImageIndex = 0 '0 es para que salga el botón con + (aceptar alta).

                        _frmGestion.pnlContenedorBusqueda.Hide()
#End Region
#Region "Auxiliar"
                    Case "DatosAuxiliar" 'Las queries van a filtrar por defecto solo a usuarios Auxiliar
                        LimpiarControles(_frmDatosAuxiliar)
                        addFrm(_frmDatosAuxiliar, _frmGestion.pnlDatosUsuario)
                        _frmGestion.pnlContenedorBusqueda.Show()

                    Case "ModificarAuxiliar" 'Las queries van a filtrar por defecto solo a usuarios Auxiliar
                        LimpiarControles(_frmModificarAuxiliar)
                        _frmModificarAuxiliar.altaOmod = 1
                        _frmModificarAuxiliar.configurarControles()
                        addFrm(_frmModificarAuxiliar, _frmGestion.pnlDatosUsuario)
                        _frmGestion.pnlContenedorBusqueda.Show()
                        _frmModificarAuxiliar.btnAceptar.ImageIndex = 1 '1 es para que salga el botón con tick (aceptar modificacion).

                    Case "BajaAuxiliar" 'Las queries van a filtrar por defecto solo a usuarios Auxiliar
                        LimpiarControles(_frmDatosAuxiliar)
                        addFrm(_frmDatosAuxiliar, _frmGestion.pnlDatosUsuario)
                        _frmGestion.pnlContenedorBusqueda.Show()

                    Case "AltaAuxiliar" 'Las queries van a filtrar por defecto solo a usuarios Auxiliar
                        LimpiarControles(_frmModificarAuxiliar)
                        _frmModificarAuxiliar.altaOmod = 0
                        _frmModificarAuxiliar.configurarControles()
                        addFrm(_frmModificarAuxiliar, _frmGestion.pnlDatosUsuario)
                        _frmGestion.pnlContenedorBusqueda.Show()
                        _frmModificarAuxiliar.btnAceptar.ImageIndex = 0 '0 es para que salga el botón con + (aceptar alta).

                        _frmGestion.pnlContenedorBusqueda.Hide()
#End Region
                End Select

        End Select
    End Sub

    Public Sub solicitarConfirmacion(accion As String, tipo As String)
        Select Case accion
            Case "Baja"
                Select Case tipo
                    Case "Paciente"
                        Dim baja = MsgBox("Seguro que desea dar de baja al paciente " & _frmDatosPaciente.lblNombre1.Text & " " & _frmDatosPaciente.lblApellido1.Text & "?", vbYesNo)

                        If baja = DialogResult.Yes Then
                            Dim ci As String = _frmDatosPaciente.lblCedula.Text
                            '-->Dar de baja en la BD

                        End If
                    Case "Medico"
                        Dim baja = MsgBox("Seguro que desea dar de baja al médico " & _frmDatosMedico.lblNombre1.Text & " " & _frmDatosMedico.lblApellido1.Text & "?", vbYesNo)

                        If baja = DialogResult.Yes Then
                            Dim ci As String = _frmDatosMedico.lblCedula.Text
                            '-->Dar de baja en la BD

                        End If
                    Case "Auxiliar"
                        Dim baja = MsgBox("Seguro que desea dar de baja al auxiliar " & _frmDatosAuxiliar.lblNombre1.Text & " " & _frmDatosAuxiliar.lblApellido1.Text & "?", vbYesNo)

                        If baja = DialogResult.Yes Then
                            Dim ci As String = _frmDatosAuxiliar.lblCedula.Text
                            '-->Dar de baja en la BD

                        End If

                End Select
            Case "Modificación"
                Select Case tipo
                    Case "Paciente"
                        Dim modif = MsgBox("Seguro que desea modificar al paciente " & _frmDatosPaciente.lblNombre1.Text & " " & _frmDatosPaciente.lblApellido1.Text & "?", vbYesNo)

                        If modif = DialogResult.Yes Then
                            Dim ci As String = _frmDatosPaciente.lblCedula.Text
                            '-->Modificar en la BD

                        End If
                    Case "Medico"
                        Dim modif = MsgBox("Seguro que desea modificar al médico " & _frmDatosMedico.lblNombre1.Text & " " & _frmDatosMedico.lblApellido1.Text & "?", vbYesNo)

                        If modif = DialogResult.Yes Then
                            Dim ci As String = _frmDatosMedico.lblCedula.Text
                            '-->Modificar en la BD

                        End If
                    Case "Auxiliar"
                        Dim modif = MsgBox("Seguro que desea modificar al auxiliar " & _frmDatosAuxiliar.lblNombre1.Text & " " & _frmDatosAuxiliar.lblApellido1.Text & "?", vbYesNo)

                        If modif = DialogResult.Yes Then
                            Dim ci As String = _frmDatosAuxiliar.lblCedula.Text
                            '-->Modificar en la BD

                        End If

                End Select
        End Select
    End Sub

#Region "Eventos"
    Private Sub MedicoBusquedaMenuItem_Click(sender As Object, e As EventArgs) Handles MedicoBusquedaMenuItem.Click
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

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioMenuItem.Click
        InstanciarFormulario("Inicio", "")
    End Sub

    Private Sub frmAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        agregarHandlers()
        InicioToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub AuxiliarAltaMenuItem_Click(sender As Object, e As EventArgs) Handles AuxiliarMenuItemAlta.Click
        InstanciarFormulario("Gestion", "AltaAuxiliar")
    End Sub

    Private Sub AuxiliarBajaMenuItem_Click(sender As Object, e As EventArgs) Handles AuxiliarMenuItemBaja.Click
        InstanciarFormulario("Gestion", "BajaAuxiliar")
    End Sub

    Private Sub AuxiliarModificacionMenuItem_Click(sender As Object, e As EventArgs) Handles AuxiliarMenuItemModificar.Click
        InstanciarFormulario("Gestion", "ModificarAuxiliar")
    End Sub

    Private Sub AuxiliarBusquedaMenuItem_Click(sender As Object, e As EventArgs) Handles AuxiliarBusquedaMenuItem.Click
        InstanciarFormulario("Gestion", "DatosAuxiliar")
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        e = New FormClosingEventArgs(CloseReason.UserClosing, False)
        frmAdministrador_FormClosing(sender, e)
    End Sub

    Private Sub frmAdministrador_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.pnlContenedor.Controls.Clear() 'limpiar los controles
            Me.Hide()
            InicioToolStripMenuItem_Click(sender, e) 'dejar en el formulario de inicio
            frmIngreso_Usuario.Show()
        End If
    End Sub

#End Region

    Public Sub agregarHandlers() 'Este evento agrega handlers a todos los formularios hijo

        Dim sender = New Object
        Dim e = New EventArgs

        'HANDLERS PARA FORMULARIO INICIO -> Acciones Paciente
        AddHandler _frmInicio.btnAltaPaciente.Click,
                    Sub()
                        PacienteAltaMenuItem_Click(sender, e)
                    End Sub
        AddHandler _frmInicio.btnBajaPaciente.Click,
                    Sub()
                        PacienteBajaMenuItem_Click(sender, e)
                    End Sub
        AddHandler _frmDatosPaciente.btnEditar.Click,
            Sub()
                PacienteModificacionMenuItem_Click(sender, e)
            End Sub
        AddHandler _frmInicio.btnModificarPaciente.Click,
                    Sub()
                        PacienteModificacionMenuItem_Click(sender, e)
                    End Sub
        AddHandler _frmInicio.btnBusquedaPaciente.Click,
                    Sub()
                        PacienteBusquedaMenuItem_Click(sender, e)
                    End Sub

        'HANDLERS PARA FORMULARIO INICIO -> Acciones Medico
        AddHandler _frmInicio.btnAltaMedico.Click,
                    Sub()
                        MedicoAltaMenuItem_Click(sender, e)
                    End Sub
        AddHandler _frmInicio.btnBajaMedico.Click,
                    Sub()
                        MedicoBajaMenuItem_Click(sender, e)
                    End Sub
        AddHandler _frmDatosMedico.btnEditar.Click,
            Sub()
                MedicoModificacionMenuItem_Click(sender, e)
            End Sub
        AddHandler _frmInicio.btnModificarMedico.Click,
                    Sub()
                        MedicoModificacionMenuItem_Click(sender, e)
                    End Sub
        AddHandler _frmInicio.btnBusquedaMedico.Click,
                    Sub()
                        MedicoBusquedaMenuItem_Click(sender, e)
                    End Sub
        'HANDLERS PARA FORMULARIO INICIO -> Acciones Auxiliar
        AddHandler _frmInicio.btnAltaAuxiliar.Click,
                    Sub()
                        AuxiliarAltaMenuItem_Click(sender, e)
                    End Sub
        AddHandler _frmInicio.btnBajaAuxiliar.Click,
                    Sub()
                        AuxiliarBajaMenuItem_Click(sender, e)
                    End Sub
        AddHandler _frmDatosAuxiliar.btnEditar.Click,
            Sub()
                AuxiliarModificacionMenuItem_Click(sender, e)
            End Sub
        AddHandler _frmInicio.btnModificarAuxiliar.Click,
                    Sub()
                        AuxiliarModificacionMenuItem_Click(sender, e)
                    End Sub
        AddHandler _frmInicio.btnBusquedaAuxiliar.Click,
                    Sub()
                        AuxiliarBusquedaMenuItem_Click(sender, e)
                    End Sub

    End Sub

End Class