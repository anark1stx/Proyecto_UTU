Imports Entidades
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

    Dim frmSelecMed As New frmSeleccionarMedico
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
        Consulta.Paciente.Cedula = 0
        Consulta.ID = 0
        resetMode()
        InstanciarFormulario("Inicio")
    End Sub

    Sub resetMode()
        Select Case MiModo
            Case Modo.SoyAuxiliar
                AsginarTratamientoPacienteToolStripMenuItem.Visible = False
                AsignarAnalisisPacienteToolStripMenuItem.Visible = False
                EntrevistarPacienteToolStripMenuItem.Visible = False
                IdentificarPacienteToolStripMenuItem.Visible = False
                AtenderMenuItem.Visible = False
                frmIni.btnAtenderPaciente.ImageIndex = 1
                frmIni.btnGestion.ImageIndex = 1
                SeleccionarMedicoToolStripMenuItem.Visible = True
                EntrevistaInicialToolStripMenuItem.Visible = True
                frmSelecMed.tblNomRef.Visible = False
                frmSelecMed.txtCIMedico.ReadOnly = False
                frmSelecMed.btnBuscarMedico.Visible = True
                frmSelecMed.txtCIMedico.BackColor = Color.White
                frmSelecMed.txtCIMedico.BorderStyle = BorderStyle.FixedSingle
                frmIni.btnGestion.ImageIndex = 1
                frmIni.lblAtender.Text = "Ingresar pacientes para consulta"
                frmIni.btnAtenderPaciente.ImageIndex = 1
                frmGestion.AuxiliarLogeado = New E_Usuario With {.Cedula = AuxiliarActual.Cedula}
                frmConsultasPendientes.tblAcciones.Visible = False
            Case Modo.SoyMedico
                AsginarTratamientoPacienteToolStripMenuItem.Visible = True
                AsignarAnalisisPacienteToolStripMenuItem.Visible = True
                EntrevistarPacienteToolStripMenuItem.Visible = True
                IdentificarPacienteToolStripMenuItem.Visible = True
                AtenderMenuItem.Visible = True
                frmIni.btnAtenderPaciente.ImageIndex = 0
                frmIni.btnGestion.ImageIndex = 0
                SeleccionarMedicoToolStripMenuItem.Visible = False
                EntrevistaInicialToolStripMenuItem.Visible = False
                frmSelecMed.tblNomRef.Visible = True
                frmSelecMed.txtCIMedico.ReadOnly = True
                frmSelecMed.btnBuscarMedico.Visible = False
                frmSelecMed.txtCIMedico.BackColor = Color.LightBlue
                frmSelecMed.txtCIMedico.BorderStyle = BorderStyle.None
                frmIni.btnGestion.ImageIndex = 0
                frmIni.lblAtender.Text = "Atender Paciente"
                frmIni.btnAtenderPaciente.ImageIndex = 0
                frmGestion.MedicoLogeado = New E_Medico With {.Cedula = MedicoActual.Cedula}
                frmConsultasPendientes.tblAcciones.Visible = True
        End Select
        frmGestion.MiModo = MiModo
    End Sub

    Public Sub addFrm(frm As Form)
        If Not pnlContenedorFormularios.Controls.Contains(frm) Then
            pnlContenedorFormularios.Controls.Clear()
            frm.Dock = DockStyle.Fill
            frm.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmIdentificacion no está en el nivel más alto.
            frm.TopMost = True
            Me.pnlContenedorFormularios.Controls.Add(frm)
            frm.Show()
        End If
    End Sub
    Public Sub CargarFormulario(f As E_Formulario)
        Dim fl = New FormularioEntrevista
        Dim controles = ConvertirFormulario(f)
        fl.pnlContenedor.Controls.AddRange(controles.ToArray())
        BuscarPreguntas(fl.pnlContenedor, f.PreguntasYRespuestas)
        UnirPreguntasConRespuestas(fl.pnlContenedor, f.PreguntasYRespuestas)
        BuscarIDsP(f.PreguntasYRespuestas)
        fl.MiFormulario = f
        fl.MiFormulario.Atiende = Consulta
        pnlContenedorFormularios.Controls.Clear()
        ContenedorE.Frmlimpio = fl
        ContenedorE.Dock = DockStyle.Fill
        pnlContenedorFormularios.Controls.Add(ContenedorE)
    End Sub
    Sub BloquearIdentificacion(_case As Boolean)
        frmIdentificacion.Enabled = Not _case
    End Sub

    Public Sub InstanciarFormulario(formulario As String)

        Select Case formulario
            Case "Inicio"
                addFrm(frmIni)
            Case "Gestion"
                addFrm(frmGestion)
            Case "Identificacion"
                If String.IsNullOrEmpty(Consulta.NombreConsulta) Then
                    InstanciarFormulario("SeleccionarMedico") 'pedimos el nombre de la consulta
                End If
                LimpiarControles(frmIdentificacion)
                Consulta.Paciente.Cedula = 0 'reseteo los datos
                Consulta.ID = 0
                addFrm(frmIdentificacion)
            Case "SeleccionarMedico"
                Select Case MiModo
                    Case Modo.SoyMedico
                        frmSelecMed.ComoMedico = True
                        CargarDatosMedico()
                        frmSelecMed.ActiveControl = frmSelecMed.txtNomConsulta
                    Case Modo.SoyAuxiliar
                        frmSelecMed.ComoMedico = False
                End Select
                frmSelecMed.ShowDialog()

                Select Case MiModo
                    Case Modo.SoyMedico
                        If String.IsNullOrWhiteSpace(frmSelecMed.txtNomConsulta.Text) Or Not check_regex(frmSelecMed.txtNomConsulta.Text, RegexAlfaNumericoEspaciosPuntosComasTildes) Or Not check_Largo(frmSelecMed.txtNomConsulta.Text, 5, 120, True) Then
                            MessageBox.Show("No se registró un nombre de consulta válido. Verifique.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            BloquearIdentificacion(True)
                            Exit Sub
                        End If
                        BloquearIdentificacion(False)
                        Consulta.NombreConsulta = frmSelecMed.NombreConsulta
                    Case Modo.SoyAuxiliar
                        If frmSelecMed.MedicoSelect.Cedula = 0 Then
                            MessageBox.Show("No se seleccionó ningún médico.", "No fue seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            BloquearIdentificacion(True)
                            Exit Sub
                        Else
                            MedicoActual.Cedula = frmSelecMed.MedicoSelect.Cedula
                            InstanciarFormulario("EntrevistaInicial") 'se lo dejamos cargado
                            BloquearIdentificacion(False)
                        End If
                End Select
            Case "EntrevistaInicial"
                LimpiarControles(frmIdentificacion)
                addFrm(frmIdentificacion)
                If MedicoActual.Cedula = 0 Then 'hasta que no seleccione un medico, no le dejamos agregar pacienes al listado
                    MessageBox.Show("Debe identificar al médico que va a atender la consulta primero.", "Falta identificar al medico", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BloquearIdentificacion(True)
                    InstanciarFormulario("SeleccionarMedico")
                    Exit Sub
                End If

            Case "VerListadoDeHoy"
                LimpiarControles(frmConsultasPendientes)
                VerConsultasDeHoy()
            Case "Entrevista"
                If Consulta.Paciente.Cedula = 0 Then
                    MessageBox.Show("Debe identificar al paciente primero.", "Falta identificar al paciente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                If String.IsNullOrEmpty(Consulta.NombreConsulta) Then
                    InstanciarFormulario("SeleccionarMedico") 'pedimos el nombre de la consulta
                End If

                addFrm(frmSeleccionarFrmEntrevista)
            Case "Otro"
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
                CargarFormulario(f)
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
                frmTratamientoC.CI_Paciente = Consulta.Paciente.Cedula
                frmTratamientoC.ID_C = Consulta.ID
                If String.IsNullOrWhiteSpace(ContenedorE.Frmlimpio.MiFormulario.Enfermedad.Nombre) Then 'si no fue ingresada una enfermedad, en vez de hacer alta a la tabla Sugiere, hago alta a la tabla Siguefc


                Else
                    frmTratamientoC.Enfermedad = ContenedorE.Frmlimpio.MiFormulario.Enfermedad.Nombre
                End If

                frmTratamientoC.ShowDialog()
            Case "AsignarAnalisis" 'agarrar la ID de consulta
                LimpiarControles(frmAnalisisS)
                frmAnalisisS.ID_C = Consulta.ID
                frmAnalisisS.CI_paciente = Consulta.Paciente.Cedula
                frmAnalisisS.MiModo = frmAnalisisSeguimiento.Modo.Asignar
                frmAnalisisS.ShowDialog()
            Case "SeguirTratamiento"
                LimpiarControles(frmTratamientoS)
                frmTratamientoS.ShowDialog()
            Case "IngresarAnalisis"
                LimpiarControles(frmAnalisisC)
                addFrm(frmAnalisisC)
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
                addFrm(frmAnalisisResultados)
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

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim _event = New FormClosingEventArgs(CloseReason.UserClosing, False)
        frmMedico_FormClosing(sender, _event)
    End Sub

    Private Sub frmMedico_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.pnlContenedorFormularios.Controls.Clear()
            Me.Hide()
            Consulta.Paciente.Cedula = 0
            Consulta.ID = 0
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
        AddHandler frmIni.btnAtenderPaciente.Click, AddressOf IdentificarPacienteToolStripMenuItem_Click
        AddHandler frmIni.btnCrearFormulario.Click,
                    Sub()
                        CrearFormularioMenuItem_Click(sender, e)
                    End Sub
        AddHandler frmIni.btnEditarFormulario.Click,
                    Sub()
                        InstanciarFormulario("EditarFormulario")
                    End Sub
        'HANDLERS PARA FORMULARIO SELECCIONAR MEDICO
        AddHandler frmSelecMed.btnBuscarMedico.Click, AddressOf CargarDatosMedico

        'HANDLERS PARA FORMULARIO IDENTIFICACION PACIENTE

        AddHandler frmIdentificacion.btnBuscar.Click, AddressOf CargarDatosPaciente
        AddHandler frmIdentificacion.btnAgregarLista.Click, AddressOf AgregarPacienteAListado
        AddHandler frmIdentificacion.txtCedulaPaciente.TextChanged, AddressOf CargarDatosPaciente

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
                Consulta.Paciente.Cedula = frmConsultasPendientes.ConsultaSeleccionada.Paciente.Cedula
                InstanciarFormulario("Entrevista")
            End Sub
        'HANDLERS PARA FORMULARIO SELECCIONAR FORMULARIO

        AddHandler frmSeleccionarFrmEntrevista.btnFrmGenerico.Click,
                    Sub()
                        filtroB = "generico"
                        InstanciarFormulario("Otro")
                    End Sub

        AddHandler frmSeleccionarFrmEntrevista.btnFrmDolor.Click,
                    Sub()
                        filtroB = "dolor"
                        InstanciarFormulario("Otro")
                    End Sub
        AddHandler frmSeleccionarFrmEntrevista.btnFrmFiebre.Click,
                    Sub()
                        filtroB = "fiebre"
                        InstanciarFormulario("Otro")
                    End Sub
        AddHandler frmSeleccionarFrmEntrevista.btnFrmMalestar.Click,
                    Sub()
                        filtroB = "malestar"
                        InstanciarFormulario("Otro")
                    End Sub
        AddHandler frmSeleccionarFrmEntrevista.btnFrmOtro.Click,
                    Sub()
                        filtroB = ""
                        InstanciarFormulario("Otro")
                    End Sub
        'HANDLERS PARA SEGUIMIENTO ANALISIS
        AddHandler frmAnalisisS.btnConsultarDatos.Click,
            Sub()
                InstanciarFormulario("DatosAnalisis")
            End Sub
    End Sub

    Async Sub AgregarPacienteAListado()
        If Not frmIdentificacion.txtCedulaPaciente.TextLength = 8 Then
            MessageBox.Show("La cédula ingresada no es valida. " & MensajeDeErrorCedula(), "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Consulta.Paciente.Cedula = 0
            LimpiarControles(frmIdentificacion)
            Exit Sub
        End If
        If Not frmIdentificacion.txtMotivoC.TextLength > 10 Then
            MessageBox.Show("La cédula ingresada no es valida. ", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

        Dim c As New E_Atiende(Consulta.NombreConsulta, frmIdentificacion.txtMotivoC.Text, Consulta.Paciente, MedicoActual)
        Dim na As New N_Atiende
        Dim existeE = Await Task.Run(Function() na.AtiendeExiste(c))
        Select Case existeE
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando comando", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 1
                MessageBox.Show("Ese paciente ya fue agregado al listado.", "Información duplicada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LimpiarControles(frmIdentificacion)
                Exit Sub
        End Select

        Dim result = Await Task.Run(Function() na.AltaAtiende(c))
        Select Case result
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando comando", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case 1
                MessageBox.Show("El paciente fue agregado al listado.", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarControles(frmIdentificacion)
        End Select
    End Sub

    Async Sub VerConsultasDeHoy()
        Dim na As New N_Atiende
        Dim result = Await Task.Run(Function() na.ConsultarMisConsultasDeHoy(MedicoActual.Cedula))
        Select Case result(0).ID
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
                'frmConsultasPendientes.tblTarjetas.Controls.Clear()
                frmConsultasPendientes.ListaConsultas = result
                addFrm(frmConsultasPendientes)
                frmConsultasPendientes.RefrescarTarjetas()
        End Select
    End Sub

    Async Sub CargarDatosPaciente() 'cargo tambien las consultas previas ademas de sus datos
        If Not frmIdentificacion.txtCedulaPaciente.TextLength = 8 Then
            Consulta.Paciente.Cedula = 0
            Exit Sub
        End If
        If Not check_Cedula(frmIdentificacion.txtCedulaPaciente.Text) Then
            MessageBox.Show("La cédula ingresada no es valida. " & MensajeDeErrorCedula(), "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Consulta.Paciente.Cedula = 0
            LimpiarControles(frmIdentificacion)
            Exit Sub
        End If

        Dim np As New N_Paciente
        frmIdentificacion.PacienteBuscar = Await Task.Run(Function() np.BuscarPacienteCI(CInt(frmIdentificacion.txtCedulaPaciente.Text)))
        frmIdentificacion.PacienteBuscar.Foto = Await Task.Run(Function() np.LeerFoto(frmIdentificacion.PacienteBuscar.Cedula))
        Select Case frmIdentificacion.PacienteBuscar.Cedula
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
        Select Case r(0).ID
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
                If Not frmSelecMed.txtCIMedico.TextLength = 8 Then
                    MedicoActual.Cedula = 0
                    Exit Sub
                End If
                If Not check_Cedula(frmSelecMed.txtCIMedico.Text) Then
                    MessageBox.Show("La cédula ingresada no es valida. " & MensajeDeErrorCedula(), "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MedicoActual.Cedula = 0
                    LimpiarControles(frmSelecMed)
                    Exit Sub
                End If
                ci = CInt(frmSelecMed.txtCIMedico.Text)
            Case Modo.SoyMedico
                ci = MedicoActual.Cedula
        End Select

        Dim nm As New N_Medico
        frmSelecMed.MedicoSelect = Await Task.Run(Function() nm.BuscarMedicoCI(ci))
        frmSelecMed.MedicoSelect.Foto = Await Task.Run(Function() nm.LeerFoto(ci))
        Select Case frmSelecMed.MedicoSelect.Cedula
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LimpiarControles(frmSelecMed)
                Exit Sub
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando comando", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LimpiarControles(frmSelecMed)
                Exit Sub
            Case -8
                MessageBox.Show("No se encontró un médico con esa cédula.", "Médico no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                LimpiarControles(frmSelecMed)
                Exit Sub
            Case Else
                Console.WriteLine(frmSelecMed.MedicoSelect.Cedula)
                _medico = New E_Medico With {.Cedula = frmSelecMed.MedicoSelect.Cedula}
                frmSelecMed.PoblarDatos()
        End Select
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
        'mostrar cuadro emergente en el que le permito buscar analisis por nombre y el selecciona.
        'frmTratamientoC.ModoActual = frmTratamientoCrear.Modo.Alta
        'frmTratamientoC.ResetMode()
        'frmTratamientoC.ResetMode()

        If Consulta.ID = 0 Then
            MessageBox.Show("Debe atender a un paciente y guardar su diagnóstico, posteriormente podrá asignar análisis y tratamientos.", "Atienda al paciente primero", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            InstanciarFormulario("AsignarAnalisis")
        End If
    End Sub
    Private Sub AsginarTratamientoPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsginarTratamientoPacienteToolStripMenuItem.Click
        If Consulta.ID = 0 Then
            MessageBox.Show("Debe atender a un paciente y guardar su diagnóstico, posteriormente podrá asignar análisis y tratamientos.", "Atienda al paciente primero", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            InstanciarFormulario("AsignarTratamiento")
        End If

    End Sub

    Private Sub IdentificarPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IdentificarPacienteToolStripMenuItem.Click
        InstanciarFormulario("Identificacion")
    End Sub

    Private Sub EntrevistarPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntrevistarPacienteToolStripMenuItem.Click
        InstanciarFormulario("Entrevista")
    End Sub

    Private Sub VerListadoDeHoyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerListadoDeHoyToolStripMenuItem.Click
        InstanciarFormulario("VerListadoDeHoy")
    End Sub

    Private Sub SeleccionarMedicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarMedicoToolStripMenuItem.Click
        InstanciarFormulario("SeleccionarMedico")
    End Sub

    Private Sub VerListadoDeHoyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerListadoDeHoyToolStripMenuItem1.Click
        InstanciarFormulario("VerListadoDeHoy")
    End Sub

    Private Sub DefinirConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefinirConsultaToolStripMenuItem.Click
        InstanciarFormulario("SeleccionarMedico")
    End Sub

    Private Sub IdentificarPacienteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IdentificarPacienteToolStripMenuItem1.Click
        InstanciarFormulario("EntrevistaInicial")
    End Sub

    Private Sub AnalisisMenuItem_Click(sender As Object, e As EventArgs) Handles AnalisisMenuItem.Click
        Console.WriteLine("Agarre ID= " & ContenedorE.Frmlimpio.MiFormulario.Atiende.ID)
        Consulta.ID = ContenedorE.Frmlimpio.MiFormulario.Atiende.ID
    End Sub

    Private Sub TratamientosMenuItem_Click(sender As Object, e As EventArgs) Handles TratamientosMenuItem.Click
        Console.WriteLine("Agarre ID= " & ContenedorE.Frmlimpio.MiFormulario.Atiende.ID)
        Consulta.ID = ContenedorE.Frmlimpio.MiFormulario.Atiende.ID
    End Sub
    Private Sub BitacoraMedicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BitacoraMedicaToolStripMenuItem.Click
        'abrir nueva ventana para buscar enfermedades y sintomas, guardar información sobre ellas.
    End Sub

End Class