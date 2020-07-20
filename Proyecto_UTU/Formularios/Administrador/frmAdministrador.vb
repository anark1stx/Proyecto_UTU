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
                    _frmGestion.TopLevel = False
                    _frmGestion.TopMost = True
                    Me.pnlContenedor.Controls.Add(_frmGestion)
                    _frmGestion.Show()
                End If

                Select Case formularioHijo
#Region "Paciente"
                    Case "DatosPaciente" 'Las queries van a filtrar por defecto solo a usuarios Paciente

                        _frmGestion.pnlDatosUsuario.Controls.Clear()
                        _frmGestion.pnlContenedorBusqueda.Show()
                        _frmDatosPaciente.TopLevel = False
                        _frmDatosPaciente.TopMost = True
                        _frmGestion.pnlDatosUsuario.Controls.Add(_frmDatosPaciente)

                        _frmDatosPaciente.Show()

                    Case "ModificarPaciente" 'Las queries van a filtrar por defecto solo a usuarios Paciente

                        _frmGestion.pnlDatosUsuario.Controls.Clear()
                        _frmGestion.pnlContenedorBusqueda.Show()
                        _frmModificarPaciente.TopLevel = False
                        _frmModificarPaciente.TopMost = True
                        _frmGestion.pnlDatosUsuario.Controls.Add(_frmModificarPaciente)

                        _frmModificarPaciente.Show()

                    Case "BajaPaciente" 'Las queries van a filtrar por defecto solo a usuarios Paciente

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

#End Region
#Region "Medico"
                    Case "DatosMedico" 'Las queries van a filtrar por defecto solo a usuarios Medico

                        _frmGestion.pnlDatosUsuario.Controls.Clear()
                        _frmGestion.pnlContenedorBusqueda.Show()
                        _frmDatosMedico.TopLevel = False
                        _frmDatosMedico.TopMost = True
                        _frmGestion.pnlDatosUsuario.Controls.Add(_frmDatosMedico)

                        _frmDatosMedico.Show()

                    Case "ModificarMedico" 'Las queries van a filtrar por defecto solo a usuarios Medico

                        _frmGestion.pnlDatosUsuario.Controls.Clear()
                        _frmGestion.pnlContenedorBusqueda.Show()
                        _frmModificarMedico.TopLevel = False
                        _frmModificarMedico.TopMost = True
                        _frmGestion.pnlDatosUsuario.Controls.Add(_frmModificarMedico)

                        _frmModificarMedico.Show()

                    Case "BajaMedico" 'Las queries van a filtrar por defecto solo a usuarios Medico

                        _frmGestion.pnlDatosUsuario.Controls.Clear()
                        _frmGestion.pnlContenedorBusqueda.Show()
                        _frmDatosMedico.TopLevel = False
                        _frmDatosMedico.TopMost = True
                        _frmGestion.pnlDatosUsuario.Controls.Add(_frmDatosMedico)

                        _frmDatosMedico.Show()

                    Case "AltaMedico" 'Las queries van a filtrar por defecto solo a usuarios Medico

                        _frmGestion.pnlDatosUsuario.Controls.Clear()
                        _frmGestion.pnlContenedorBusqueda.Hide()
                        _frmModificarMedico.TopLevel = False
                        _frmModificarMedico.TopMost = True
                        _frmGestion.pnlDatosUsuario.Controls.Add(_frmModificarMedico)

                        _frmModificarMedico.Show()
#End Region
#Region "Auxiliar"
                    Case "DatosAuxiliar" 'Las queries van a filtrar por defecto solo a usuarios Medico

                        _frmGestion.pnlDatosUsuario.Controls.Clear()
                        _frmGestion.pnlContenedorBusqueda.Show()
                        _frmDatosAuxiliar.TopLevel = False
                        _frmDatosAuxiliar.TopMost = True
                        _frmGestion.pnlDatosUsuario.Controls.Add(_frmDatosAuxiliar)

                        _frmDatosAuxiliar.Show()

                    Case "ModificarAuxiliar" 'Las queries van a filtrar por defecto solo a usuarios Medico

                        _frmGestion.pnlDatosUsuario.Controls.Clear()
                        _frmGestion.pnlContenedorBusqueda.Show()
                        _frmModificarAuxiliar.TopLevel = False
                        _frmModificarAuxiliar.TopMost = True
                        _frmGestion.pnlDatosUsuario.Controls.Add(_frmModificarAuxiliar)

                        _frmModificarAuxiliar.Show()

                    Case "BajaAuxiliar" 'Las queries van a filtrar por defecto solo a usuarios Medico

                        _frmGestion.pnlDatosUsuario.Controls.Clear()
                        _frmGestion.pnlContenedorBusqueda.Show()
                        _frmDatosAuxiliar.TopLevel = False
                        _frmDatosAuxiliar.TopMost = True
                        _frmGestion.pnlDatosUsuario.Controls.Add(_frmDatosAuxiliar)

                        _frmDatosAuxiliar.Show()

                    Case "AltaAuxiliar" 'Las queries van a filtrar por defecto solo a usuarios Medico

                        _frmGestion.pnlDatosUsuario.Controls.Clear()
                        _frmGestion.pnlContenedorBusqueda.Hide()
                        _frmModificarAuxiliar.TopLevel = False
                        _frmModificarAuxiliar.TopMost = True
                        _frmGestion.pnlDatosUsuario.Controls.Add(_frmModificarAuxiliar)

                        _frmModificarAuxiliar.Show()
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
    Private Sub MédicoBusquedaMenuItem_Click(sender As Object, e As EventArgs) Handles MedicoBusquedaMenuItem.Click
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
        InicioToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub AuxiliarMenuItemAlta_Click(sender As Object, e As EventArgs) Handles AuxiliarMenuItemAlta.Click
        InstanciarFormulario("Gestion", "AltaAuxiliar")
    End Sub

    Private Sub AuxiliarMenuItemBaja_Click(sender As Object, e As EventArgs) Handles AuxiliarMenuItemBaja.Click
        InstanciarFormulario("Gestion", "BajaAuxiliar")
    End Sub

    Private Sub AuxiliarMenuItemModificar_Click(sender As Object, e As EventArgs) Handles AuxiliarMenuItemModificar.Click
        InstanciarFormulario("Gestion", "ModificarAuxiliar")
    End Sub

    Private Sub AuxiliarBusquedaMenuItem_Click(sender As Object, e As EventArgs) Handles AuxiliarBusquedaMenuItem.Click
        InstanciarFormulario("Gestion", "DatosAuxiliar")
    End Sub

#End Region

End Class