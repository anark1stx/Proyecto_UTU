﻿Imports Entidades
Imports FormulariosPersonalizados
Imports Negocio
Imports Utilidades

Public Class frmMedico

    Dim frmIni As New frmInicio
    Dim frmGestion As New frmGestionMedico
    Dim frmIdentificacion As New Identificacion_Paciente
    Dim frmSeleccionarFrmEntrevista As New frmSeleccionarFormularioEntrevista

    Dim frmTratamientoC As New frmTratamientoCrear
    Dim frmTratamientoS As New frmTratamientoSeguir

    Dim frmAnalisisC As New frmAnalisisCrear
    Dim frmAnalisisS As New frmAnalisisSeguimiento
    Dim frmAnalisisResultados As New frmDatosAnalisis

    Dim frmCrear As New frmCrearFormulario

    Dim filtroB As String = ""
    Dim frmCatalogo As New frmCatalogoFormulariosBD

    Dim ContenedorE As New ContenedorEntrevistas

    Dim frmDefinirConsulta As New frmDefinirConsulta
    Dim frmConsultasPendientes As New frmCargarTarjetasP

    Protected _medico As E_Medico
    Protected _auxiliar As E_Usuario
    Protected _modo As New Modo
    Protected _consulta As New E_Atiende

    Public Enum Modo
        SoyMedico
        SoyAuxiliar
    End Enum

    Property MiModo As Modo
        Get
            Return _modo
        End Get
        Set(value As Modo)
            _modo = value
            resetMode()
        End Set
    End Property

    Property MedicoActual As E_Medico
        Get
            Return _medico
        End Get
        Set(value As E_Medico)
            _medico = value
        End Set
    End Property

    Property AuxiliarActual As E_Usuario
        Get
            Return _auxiliar
        End Get
        Set(value As E_Usuario)
            _auxiliar = value
        End Set
    End Property
    Property Consulta As E_Atiende
        Get
            Return _consulta
        End Get
        Set(value As E_Atiende)
            _consulta = value
        End Set
    End Property

    Private Sub frmMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        agregarHandlers()
        InstanciarFormulario("Inicio")
        Me.MaximizeBox = False
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Sub resetMode()
        Select Case MiModo
            Case Modo.SoyAuxiliar
                AsginarTratamientoPacienteToolStripMenuItem.Visible = False
                AsignarAnalisisPacienteToolStripMenuItem.Visible = False
                IdentificarPacienteToolStripMenuItem.Visible = False
                AtenderMenuItem.Visible = False
                frmIni.btnAtenderPaciente.ImageIndex = 1
                frmIni.btnGestion.ImageIndex = 1
                SeleccionarMedicoToolStripMenuItem.Visible = True
                EntrevistaInicialToolStripMenuItem.Visible = True
                frmDefinirConsulta.txtCIMedico.ReadOnly = False
                frmDefinirConsulta.btnBuscarMedico.Visible = True
                frmDefinirConsulta.txtCIMedico.BackColor = Color.White
                frmDefinirConsulta.txtCIMedico.BorderStyle = BorderStyle.FixedSingle
                frmIni.btnGestion.ImageIndex = 1
                frmIni.lblAtender.Text = "Ingresar pacientes para consulta"
                frmIni.btnAtenderPaciente.ImageIndex = 1
                frmGestion.AuxiliarLogeado = New E_Usuario With {.Cedula = AuxiliarActual.Cedula}
                frmConsultasPendientes.tblAcciones.Visible = False
                frmIdentificacion.btnAtenderAhora.Visible = False
                frmIdentificacion.tblAcciones.SetRow(frmIdentificacion.btnAgregarLista, frmIdentificacion.tblAcciones.GetRow(frmIdentificacion.btnAtenderAhora))
                frmIdentificacion.tblAcciones.SetRowSpan(frmIdentificacion.btnAgregarLista, 2)
            Case Modo.SoyMedico
                AsginarTratamientoPacienteToolStripMenuItem.Visible = True
                AsignarAnalisisPacienteToolStripMenuItem.Visible = True
                IdentificarPacienteToolStripMenuItem.Visible = True
                AtenderMenuItem.Visible = True
                frmIni.btnAtenderPaciente.ImageIndex = 0
                frmIni.btnGestion.ImageIndex = 0
                SeleccionarMedicoToolStripMenuItem.Visible = False
                EntrevistaInicialToolStripMenuItem.Visible = False
                frmDefinirConsulta.tblNomRef.Visible = True
                frmDefinirConsulta.txtCIMedico.ReadOnly = True
                frmDefinirConsulta.btnBuscarMedico.Visible = False
                frmDefinirConsulta.txtCIMedico.BackColor = Color.LightBlue
                frmDefinirConsulta.txtCIMedico.BorderStyle = BorderStyle.None
                frmIni.btnGestion.ImageIndex = 0
                frmIni.lblAtender.Text = "Atender Paciente"
                frmIni.btnAtenderPaciente.ImageIndex = 0
                frmGestion.MedicoLogeado = New E_Medico With {.Cedula = MedicoActual.Cedula}
                frmConsultasPendientes.tblAcciones.Visible = True
                frmIdentificacion.btnAtenderAhora.Visible = True
                frmIdentificacion.tblAcciones.SetRowSpan(frmIdentificacion.btnAgregarLista, 1)
        End Select
        frmGestion.MiModo = MiModo
    End Sub
    Public Sub CargarFormularioEntrevista(f As E_Formulario)
        Dim fe = New FormularioEntrevista
        Dim controles = ConvertirFormulario(f)
        fe.pnlContenedor.Controls.AddRange(controles.ToArray())
        BuscarPreguntas(fe.pnlContenedor, f.PreguntasYRespuestas)
        BuscarIDsP(f.PreguntasYRespuestas)
        UnirPreguntasConRespuestas(fe.pnlContenedor, f.PreguntasYRespuestas)
        fe.MiFormulario = f
        fe.MiFormulario.Atiende = Consulta
        pnlContenedorFormularios.Controls.Clear()
        ContenedorE.Entrevista = fe
        ContenedorE.Dock = DockStyle.Fill
        pnlContenedorFormularios.Controls.Add(ContenedorE)
        HabilitarMenu(False)
    End Sub
    Sub BloquearIdentificacion(_case As Boolean)
        frmIdentificacion.Enabled = Not _case
    End Sub

    Sub HabilitarMenu(_case As Boolean) 'cuando el medico abra un formulario de entrevista, bloqueo todos los toolstripbutton y solo habilito: {Tratamientos{crear,asignar},Analisis{asignar}}
        For Each item As ToolStripMenuItem In MenuOpciones.Controls
            If item IsNot AsginarTratamientoPacienteToolStripMenuItem AndAlso item IsNot AsignarAnalisisPacienteToolStripMenuItem AndAlso item IsNot AnalisisMenuItem AndAlso item IsNot TratamientosMenuItem AndAlso item IsNot IngresarNuevoTratamientoMenuItem Then
                item.Enabled = _case
            Else
                item.Enabled = Not _case
            End If
        Next
    End Sub

    Public Sub InstanciarFormulario(formulario As String)
        Select Case formulario
            Case "Inicio"
                addFrm(frmIni, pnlContenedorFormularios)
            Case "Gestion"
                addFrm(frmGestion, pnlContenedorFormularios)
            Case "Identificacion"
                If String.IsNullOrEmpty(Consulta.NombreConsulta) Then
                    InstanciarFormulario("SeleccionarMedico") 'pedimos el nombre de la consulta
                End If
                LimpiarControles(frmIdentificacion)
                Consulta.Paciente.Cedula = 0 'reseteo los datos
                Consulta.ID = 0
                addFrm(frmIdentificacion, pnlContenedorFormularios)
            Case "SeleccionarMedico"
                If MiModo = Modo.SoyMedico Then
                    CargarDatosMedico()
                End If
                frmDefinirConsulta.ActiveControl = frmDefinirConsulta.txtNomConsulta
                frmDefinirConsulta.ShowDialog()

                If String.IsNullOrWhiteSpace(frmDefinirConsulta.NombreConsulta) Or Not check_regex(frmDefinirConsulta.NombreConsulta, RegexAlfaNumericoEspaciosPuntosComasTildes) Or Not check_Largo(frmDefinirConsulta.txtNomConsulta.Text, 5, 120, True) Then
                    MessageBox.Show("No se registró un nombre de consulta válido. Verifique.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    BloquearIdentificacion(True)
                    Exit Sub
                End If

                BloquearIdentificacion(False)
                Consulta.NombreConsulta = frmDefinirConsulta.NombreConsulta
                Consulta.Fecha = frmDefinirConsulta.FechaConsulta
                Select Case MiModo
                    Case Modo.SoyAuxiliar
                        If frmDefinirConsulta.MedicoSelect.Cedula = 0 Then
                            MessageBox.Show("No se seleccionó ningún médico.", "No fue seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            BloquearIdentificacion(True)
                            Exit Sub
                        Else
                            MedicoActual.Cedula = frmDefinirConsulta.MedicoSelect.Cedula
                            BloquearIdentificacion(False)
                        End If
                End Select
            Case "EntrevistaInicial"
                If MedicoActual.Cedula = 0 Then 'hasta que no seleccione un medico, no le dejamos agregar pacienes al listado
                    MessageBox.Show("Debe identificar al médico que va a atender la consulta primero.", "Falta identificar al medico", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BloquearIdentificacion(True)
                    InstanciarFormulario("SeleccionarMedico")
                    Exit Sub
                Else
                    addFrm(frmIdentificacion, pnlContenedorFormularios)
                End If
            Case "Entrevista"
                addFrm(frmSeleccionarFrmEntrevista, pnlContenedorFormularios)
            Case "BuscarFormulario"
                If Not String.IsNullOrWhiteSpace(filtroB) Then
                    frmCatalogo.txtBuscar.Text = filtroB
                End If
                frmCatalogo.ShowDialog()
                If frmCatalogo.FormSeleccionado Is Nothing Then
                    Exit Sub
                End If
                Dim f = frmCatalogo.FormSeleccionado
                f.Atiende.Medico = MedicoActual
                f.Atiende.Paciente = Consulta.Paciente
                CargarFormularioEntrevista(f)
                filtroB = ""
            Case "CrearFormulario"
                frmCrear.Show()
            Case "EditarFormulario"
                frmCrear.Show()
                Dim sender As Object = New Object
                frmCrear.btnAbrir.PerformClick()
            Case "IngresarTratamiento"
                LimpiarControles(frmTratamientoC)
                frmTratamientoC.ModoActual = frmTratamientoCrear.Modo.Alta
                frmTratamientoC.ResetMode()
                frmTratamientoC.ShowDialog()
            Case "AsignarTratamiento" 'agarrar la ID de consulta
                LimpiarControles(frmTratamientoC)
                frmTratamientoC.ModoActual = frmTratamientoCrear.Modo.Asignar
                'frmTratamientoC.CI_Paciente = Consulta.Paciente.Cedula
                'frmTratamientoC.ID_C = Consulta.ID CAMBIAR ESTO POR UNA PROPIEDAD CONSULTA

                frmTratamientoC.ShowDialog()
            Case "AsignarAnalisis" 'agarrar la ID de consulta
                LimpiarControles(frmAnalisisS)
                'frmAnalisisS.ID_C = Consulta.ID LO MISMO QUE CON EL TRATAMIENTO
                'frmAnalisisS.CI_paciente = Consulta.Paciente.Cedula
                'frmAnalisisS.MiModo = frmAnalisisSeguimiento.Modo.Asignar
                'frmAnalisisS.ShowDialog()
            Case "SeguirTratamiento"
                LimpiarControles(frmTratamientoS)
                frmTratamientoS.ShowDialog()
            Case "IngresarAnalisis"
                LimpiarControles(frmAnalisisC)
                frmAnalisisC.ShowDialog()
            Case "SeguirAnalisis"
                LimpiarControles(frmAnalisisS)
                frmAnalisisS.MiModo = frmAnalisisSeguimiento.Modo.Buscar
                frmAnalisisS.resetMode()
                frmAnalisisS.ShowDialog()
            Case "DatosAnalisis"
                LimpiarControles(frmAnalisisS)

                'pac.buscarPorCI()

                'Dim a = pac.buscarAnalisis()

                'frmAnalisisResultados.Consulta.Paciente = pac
                addFrm(frmAnalisisResultados, pnlContenedorFormularios)
        End Select

    End Sub

    Private Sub GestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionMenuItem.Click
        InstanciarFormulario("Gestion")
    End Sub

    Private Sub EntrevistaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        InstanciarFormulario("Identificacion")
    End Sub

    Private Sub CrearFormularioMenuItem_Click(sender As Object, e As EventArgs) Handles CrearFormularioMenuItem.Click
        InstanciarFormulario("CrearFormulario")
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        InstanciarFormulario("Inicio")
    End Sub
    Private Sub frmMedico_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmIngreso_Usuario.Show()
        Me.Dispose()
    End Sub

    Public Sub agregarHandlers() 'Este evento agrega handlers a todos los formularios hijo
        AddHandler frmIni.btnGestion.Click, AddressOf GestionToolStripMenuItem_Click
        AddHandler frmIni.btnAtenderPaciente.Click, AddressOf IdentificarPacienteToolStripMenuItem_Click
        AddHandler frmIni.btnCrearFormulario.Click, AddressOf CrearFormularioMenuItem_Click
        AddHandler frmIni.btnEditarFormulario.Click,
                    Sub()
                        InstanciarFormulario("EditarFormulario")
                    End Sub
        'HANDLERS PARA FORMULARIO SELECCIONAR MEDICO
        AddHandler frmDefinirConsulta.btnBuscarMedico.Click, AddressOf CargarDatosMedico

        'HANDLERS PARA FORMULARIO IDENTIFICACION PACIENTE

        AddHandler frmIdentificacion.btnBuscar.Click, AddressOf CargarDatosPaciente
        AddHandler frmIdentificacion.btnAgregarLista.Click, Sub()
                                                                AgregarPacienteAListado(False)
                                                            End Sub
        AddHandler frmIdentificacion.txtCedulaPaciente.TextChanged, AddressOf CargarDatosPaciente

        AddHandler frmIdentificacion.btnAtenderAhora.Click,
            Sub()
                AgregarPacienteAListado(True)
            End Sub

        AddHandler frmConsultasPendientes.btnRefrescar.Click, AddressOf VerConsultasDeHoy
        'AddHandler frmConsultasPendientes.btnVerConsultasPrevias, <- pendiente

        AddHandler frmConsultasPendientes.btnVerAnalisis.Click,
            Sub()
                Consulta.Paciente.Cedula = frmConsultasPendientes.ConsultaSeleccionada.Paciente.Cedula
                InstanciarFormulario("SeguirAnalisis")
                frmAnalisisS.txtBuscar.Text = Consulta.Paciente.Cedula
                Dim s As New Object
                Dim ev As New EventArgs
                frmAnalisisS.btnBuscar_Click(s, ev)
            End Sub
        AddHandler frmConsultasPendientes.btnAtender.Click,
            Sub()
                Consulta = frmConsultasPendientes.ConsultaSeleccionada
                InstanciarFormulario("Entrevista")
            End Sub
        'HANDLERS PARA FORMULARIO SELECCIONAR FORMULARIO

        AddHandler frmSeleccionarFrmEntrevista.btnFrmGenerico.Click,
                    Sub()
                        filtroB = "generico"
                        InstanciarFormulario("BuscarFormulario")
                    End Sub

        AddHandler frmSeleccionarFrmEntrevista.btnFrmDolor.Click,
                    Sub()
                        filtroB = "dolor"
                        InstanciarFormulario("BuscarFormulario")
                    End Sub
        AddHandler frmSeleccionarFrmEntrevista.btnFrmFiebre.Click,
                    Sub()
                        filtroB = "fiebre"
                        InstanciarFormulario("BuscarFormulario")
                    End Sub
        AddHandler frmSeleccionarFrmEntrevista.btnFrmMalestar.Click,
                    Sub()
                        filtroB = "malestar"
                        InstanciarFormulario("BuscarFormulario")
                    End Sub
        AddHandler frmSeleccionarFrmEntrevista.btnFrmOtro.Click,
                    Sub()
                        filtroB = ""
                        InstanciarFormulario("BuscarFormulario")
                    End Sub
        'HANDLERS PARA SEGUIMIENTO ANALISIS
        AddHandler frmAnalisisS.btnConsultarDatos.Click,
            Sub()
                InstanciarFormulario("DatosAnalisis")
            End Sub
        'handler para boton Salir
        AddHandler SalirToolStripMenuItem.Click, AddressOf frmMedico_FormClosing
    End Sub

    Async Sub AgregarPacienteAListado(atenderahora As Boolean)
        If Not frmIdentificacion.txtCedulaPaciente.TextLength = 8 Then
            MessageBox.Show("La cédula ingresada no es valida. " & MensajeDeErrorCedula(), "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Consulta.Paciente.Cedula = 0
            LimpiarControles(frmIdentificacion)
            Exit Sub
        End If
        If frmIdentificacion.txtMotivoC.TextLength < 10 Then
            MessageBox.Show("Ingrese un motivo de consulta. ", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Not check_regex(frmIdentificacion.txtMotivoC.Text, RegexAlfaNumericoEspaciosPuntosComasTildes) Then
            MessageBox.Show(MensajeDeErrorCaracteres(), "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If _medico.Cedula = 0 Then
            MessageBox.Show("Ingrese la cédula del médico que atenderá esta consulta", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Consulta.Fecha = frmDefinirConsulta.FechaConsulta
        Consulta.Medico = frmDefinirConsulta.MedicoSelect
        Consulta.Motivo = frmIdentificacion.Consulta.Motivo
        Dim na As New N_Atiende

        Dim result = Await Task.Run(Function() na.AltaAtiende(Consulta))
        Select Case result
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando comando", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case 1
                LimpiarControles(frmIdentificacion)
        End Select
        Console.WriteLine("Agregar paciente a listado. ID DE CONSULTA = " & Consulta.ID)
        If atenderahora Then
            InstanciarFormulario("Entrevista")
        End If
    End Sub

    Async Sub VerConsultasDeHoy()
        LimpiarControles(frmConsultasPendientes)
        Dim na As New N_Atiende
        Dim result = Await Task.Run(Function() na.ConsultarMisConsultasDeHoy(MedicoActual.Cedula))
        Select Case result(0).ErrCode
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando comando", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case -8
                MessageBox.Show("No se encontraron pacientes para atender.", "Pacientes no encontrados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarControles(frmIdentificacion)
            Case Else
                frmConsultasPendientes.ListaConsultas = result
                addFrm(frmConsultasPendientes, pnlContenedorFormularios)
                frmConsultasPendientes.RefrescarTarjetas()
        End Select
    End Sub

    Async Sub CargarDatosPaciente() 'cargo tambien las consultas previas ademas de sus datos
        If Not frmIdentificacion.txtCedulaPaciente.TextLength = 8 Then
            Consulta.Paciente.Cedula = 0
            frmIdentificacion.btnReferenciaConsulta.Enabled = False
            frmIdentificacion.cbConsultasPrevias.Enabled = False
            frmIdentificacion.btnVerConsulta.Enabled = False
            LimpiarControles(frmIdentificacion)
            frmIdentificacion.PacienteBuscar.Cedula = 0
            Exit Sub
        End If
        If Not check_Cedula(frmIdentificacion.txtCedulaPaciente.Text) Then
            MessageBox.Show(MensajeDeErrorCedula(), "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Consulta.Paciente.Cedula = 0
            LimpiarControles(frmIdentificacion)
            Exit Sub
        Else
            frmIdentificacion.btnReferenciaConsulta.Enabled = True
            frmIdentificacion.cbConsultasPrevias.Enabled = True
            frmIdentificacion.btnVerConsulta.Enabled = True
        End If

        Dim np As New N_Paciente
        frmIdentificacion.PacienteBuscar = Await Task.Run(Function() np.BuscarPacienteCI(CInt(frmIdentificacion.txtCedulaPaciente.Text)))
        frmIdentificacion.PacienteBuscar.Foto = Await Task.Run(Function() np.LeerFoto(frmIdentificacion.PacienteBuscar.Cedula))
        Select Case frmIdentificacion.PacienteBuscar.ErrCode
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LimpiarControles(frmIdentificacion)
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando comando", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LimpiarControles(frmIdentificacion)
            Case -8
                MessageBox.Show("No se encontró un paciente con esa cédula.", "Paciente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                LimpiarControles(frmIdentificacion)
            Case Else
                Consulta.Paciente.Cedula = frmIdentificacion.PacienteBuscar.Cedula
                frmIdentificacion.PoblarDatos()
        End Select
        Dim na As New N_Atiende
        Dim r = Await Task.Run(Function() na.BuscarAtiende(Consulta.Paciente.Cedula))
        Select Case r(0).ErrCode
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error efectuando acción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select
        frmIdentificacion.ConsultasPrevias = r
    End Sub

    Async Sub CargarDatosMedico()
        Dim ci As Integer = 0
        Select Case MiModo
            Case Modo.SoyAuxiliar
                If Not frmDefinirConsulta.txtCIMedico.TextLength = 8 Then
                    MedicoActual.Cedula = 0
                    Exit Sub
                End If
                If Not check_Cedula(frmDefinirConsulta.txtCIMedico.Text) Then
                    MessageBox.Show("La cédula ingresada no es valida. " & MensajeDeErrorCedula(), "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MedicoActual.Cedula = 0
                    LimpiarControles(frmDefinirConsulta)
                    Exit Sub
                End If
                ci = CInt(frmDefinirConsulta.txtCIMedico.Text)
            Case Modo.SoyMedico
                ci = MedicoActual.Cedula
        End Select

        Dim nm As New N_Medico
        frmDefinirConsulta.MedicoSelect = Await Task.Run(Function() nm.BuscarMedicoCI(ci))
        frmDefinirConsulta.MedicoSelect.Foto = Await Task.Run(Function() nm.LeerFoto(ci))
        Select Case frmDefinirConsulta.MedicoSelect.ErrCode
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LimpiarControles(frmDefinirConsulta)
                Exit Sub
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando comando", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LimpiarControles(frmDefinirConsulta)
                Exit Sub
            Case -8
                MessageBox.Show("No se encontró un médico con esa cédula.", "Médico no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                LimpiarControles(frmDefinirConsulta)
                Exit Sub
        End Select
        Console.WriteLine(frmDefinirConsulta.MedicoSelect.Cedula)
        _medico = New E_Medico With {.Cedula = frmDefinirConsulta.MedicoSelect.Cedula}
        frmDefinirConsulta.PoblarDatos()
    End Sub

    Private Sub IngresarNuevoTratamientoMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarNuevoTratamientoMenuItem.Click
        InstanciarFormulario("IngresarTratamiento")
    End Sub

    Private Sub TratamientoSeguimientoMenuItem_Click(sender As Object, e As EventArgs) Handles TratamientoSeguimientoMenuItem.Click
        InstanciarFormulario("SeguirTratamiento")
    End Sub

    Private Sub AnalisisIngresarMenuItem1_Click(sender As Object, e As EventArgs) Handles AnalisisIngresarMenuItem1.Click
        InstanciarFormulario("IngresarAnalisis")
    End Sub

    Private Sub AnalisisHacerSeguimientoMenuItem1_Click(sender As Object, e As EventArgs) Handles AnalisisHacerSeguimientoMenuItem1.Click
        InstanciarFormulario("SeguirAnalisis")
    End Sub

    Private Sub AsignarAnalisisPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarAnalisisPacienteToolStripMenuItem.Click
        If Consulta.ID = 0 Then
            MessageBox.Show("Debe estar atendiendo un paciente para asignarle un análisis.", "Atienda al paciente primero", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            InstanciarFormulario("AsignarAnalisis")
        End If
    End Sub
    Private Sub AsginarTratamientoPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsginarTratamientoPacienteToolStripMenuItem.Click
        If Consulta.ID = 0 Then
            MessageBox.Show("Debe estar atendiendo un paciente para asignarle un tratamiento.", "Atienda al paciente primero", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            InstanciarFormulario("AsignarTratamiento")
        End If

    End Sub

    Private Sub IdentificarPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IdentificarPacienteToolStripMenuItem.Click
        InstanciarFormulario("Identificacion")
    End Sub

    Private Sub EntrevistarPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        InstanciarFormulario("Entrevista")
    End Sub

    Private Sub VerListadoDeHoyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerListadoDeHoyToolStripMenuItem.Click
        VerConsultasDeHoy()
    End Sub

    Private Sub SeleccionarMedicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarMedicoToolStripMenuItem.Click
        InstanciarFormulario("SeleccionarMedico")
    End Sub

    Private Sub VerListadoDeHoyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerListadoDeHoyToolStripMenuItem1.Click
        VerConsultasDeHoy()
    End Sub

    Private Sub DefinirConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefinirConsultaToolStripMenuItem.Click
        InstanciarFormulario("SeleccionarMedico")
    End Sub

    Private Sub IdentificarPacienteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IdentificarPacienteToolStripMenuItem1.Click
        InstanciarFormulario("EntrevistaInicial")
    End Sub

    Private Sub AnalisisMenuItem_Click(sender As Object, e As EventArgs) Handles AnalisisMenuItem.Click
        Console.WriteLine("Agarre ID= " & ContenedorE.Entrevista.MiFormulario.Atiende.ID)
        Consulta.ID = ContenedorE.Entrevista.MiFormulario.Atiende.ID
    End Sub

    Private Sub TratamientosMenuItem_Click(sender As Object, e As EventArgs) Handles TratamientosMenuItem.Click
        Console.WriteLine("Agarre ID= " & ContenedorE.Entrevista.MiFormulario.Atiende.ID)
        Consulta.ID = ContenedorE.Entrevista.MiFormulario.Atiende.ID
    End Sub
    Private Sub BitacoraMedicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BitacoraMedicaToolStripMenuItem.Click
        'abrir nueva ventana para buscar enfermedades y sintomas, guardar información sobre ellas.
    End Sub
End Class