Imports System.Globalization
Imports Entidades
Imports Negocio
Imports Utilidades
Public Class frmMedico

    Dim frmIni As New frmInicio
    Dim frmGestion As New frmGestionMedico
    Dim frmOpsConsulta As New frmOpcionesConsulta
    Dim frmIdentificacion As New Identificacion_Paciente
    Dim frmEntrevista As New frmSeleccionarFormularioEntrevista

    Dim frmTratamientoC As New frmTratamientoCrear
    Dim frmTratamientoS As New frmTratamientoSeguir

    Dim frmAnalisisC As New frmAnalisisCrear
    Dim frmAnalisisS As New frmAnalisisSeguimiento
    Dim frmAnalisisDatos As New frmDatosAnalisis

    Dim frmCrear As New frmCrearFormulario
    Dim frmPlano As New formularioPlano
    Dim frmCatalogo As New frmCatalogoFormulariosBD

    Dim generico As New frmGenerico
    Dim frmDlr As New frmDolor
    Dim frmFbr As New frmFiebre
    Dim frmMal As New frmMalestar

    Dim frmSelecMed As New frmSeleccionarMedico
    Protected _id_consulta As Integer 'para tener persistencia cuando el medico pase del formulario a asignar tratamientos o analisis al paciente, nos interesa guardar en esa mimsma consulta que fue asignado para el predictivo.
    Dim _paciente As New E_Paciente With {.Cedula = 0}
    'Dim PreguntarNombreConsulta As New frmPreguntarNomCons
    Protected _nombreConsulta 'emergencias,oftalmologia,dermatologia,etc.
    Protected _medico As E_Medico
    Protected _auxiliar As E_Usuario
    Protected _modo As New Modo

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

    Property NombreConsulta
        Get
            Return _nombreConsulta
        End Get
        Set(value)
            _nombreConsulta = value
        End Set
    End Property

    Property ID_Consulta As Integer
        Get
            Return _id_consulta
        End Get
        Set(value As Integer)
            _id_consulta = value
        End Set
    End Property

    Private Sub frmMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        agregarHandlers()
        _paciente.Cedula = 0
        ID_Consulta = 0
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
            Case Modo.SoyMedico
                AsginarTratamientoPacienteToolStripMenuItem.Visible = True
                AsignarAnalisisPacienteToolStripMenuItem.Visible = True
                EntrevistarPacienteToolStripMenuItem.Visible = True
                IdentificarPacienteToolStripMenuItem.Visible = True
                AtenderMenuItem.Visible = True
                frmIni.btnAtenderPaciente.ImageIndex = 0
                frmIni.btnGestion.ImageIndex = 0
        End Select
    End Sub

    Public Sub addFrm(frm As Form)
        If Not pnlContenedorFormularios.Controls.Contains(frm) Then
            pnlContenedorFormularios.Controls.Clear()
            frm.Dock = DockStyle.Fill
            frm.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmIdentificacion no está en el nivel más alto.
            frm.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.
            Me.pnlContenedorFormularios.Controls.Add(frm) 'Añadir el formulario al panel
            frm.Show()
        End If

    End Sub

    Public Sub fixSize()

        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Sub BloquearIdentificacion(_case As Boolean)
        frmIdentificacion.Enabled = Not _case
    End Sub

    Public Sub InstanciarFormulario(formulario As String)

        Select Case formulario

            Case "Inicio"
                Me.MaximizeBox = True
                Select Case MiModo
                    Case Modo.SoyMedico
                        frmIni.btnGestion.ImageIndex = 0
                        frmIni.lblAtender.Text = "Atender Paciente"
                        frmIni.btnAtenderPaciente.ImageIndex = 0
                    Case Modo.SoyAuxiliar
                        frmIni.btnGestion.ImageIndex = 1
                        frmIni.lblAtender.Text = "Ingresar pacientes para consulta"
                        frmIni.btnAtenderPaciente.ImageIndex = 1
                End Select
                addFrm(frmIni)

            Case "Gestion"
                frmGestion.MedicoLogeado = New E_Medico With {.Cedula = MedicoActual.Cedula}
                addFrm(frmGestion)

            Case "Atender"
                Me.MaximizeBox = False
                addFrm(frmOpsConsulta)

            Case "Identificacion"
                LimpiarControles(frmIdentificacion)
                frmIdentificacion.ModoActual = Identificacion_Paciente.Modo.MedicoAtiende
                frmIdentificacion.configurarControles()
                '_paciente.Cedula = 0
                addFrm(frmIdentificacion)

            Case "SeleccionarMedico"
                LimpiarControles(frmSelecMed)
                frmSelecMed.ShowDialog()
                If frmSelecMed.MedicoSelect.Cedula = 0 Then
                    MessageBox.Show("No se seleccionó ningún médico.", "No fue seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    BloquearIdentificacion(True)
                    Exit Sub
                Else
                    If Not check_regex(frmSelecMed.txtNomConsulta.Text, RegexLiteralAcentos) Or Not check_Largo(frmSelecMed.txtNomConsulta.Text, 5, 120, True) Then
                        MessageBox.Show("No se registró un nombre de consulta válido. Verifique.", "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        BloquearIdentificacion(True)
                        Exit Sub
                    End If
                    MedicoActual.Cedula = frmSelecMed.MedicoSelect.Cedula
                    InstanciarFormulario("EntrevistaInicial") 'se lo dejamos cargado
                    BloquearIdentificacion(False)
                End If
            Case "EntrevistaInicial"
                LimpiarControles(frmIdentificacion)
                frmIdentificacion.ModoActual = Identificacion_Paciente.Modo.AgregarAListaHoy
                frmIdentificacion.configurarControles()
                addFrm(frmIdentificacion)
                If MedicoActual.Cedula = 0 Then 'hasta que no seleccione un medico, no le dejamos agregar pacienes al listado
                    MessageBox.Show("Debe identificar al médico que va a atender la consulta primero.", "Falta identificar al medico", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BloquearIdentificacion(True)
                    Exit Sub
                End If
            Case "Entrevista"

                If _paciente.Cedula = 0 Then
                    MessageBox.Show("Debe identificar al paciente primero.", "Falta identificar al paciente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                Me.MaximizeBox = False
                fixSize()

                addFrm(frmEntrevista)
                'PreguntarNombreConsulta.ShowDialog()
                'NombreConsulta = PreguntarNombreConsulta.Nombre
            Case "Generico"
                LimpiarControles(generico)
                addFrm(generico)

            Case "Dolor"
                LimpiarControles(frmDlr)
                addFrm(frmDlr)

            Case "Fiebre"
                LimpiarControles(frmFbr)
                addFrm(frmFbr)

            Case "Malestar"
                LimpiarControles(frmMal)
                addFrm(frmMal)

            Case "Otro"

                frmPlano.Controls.Clear()

                frmCatalogo.ShowDialog()

                'Dim controles = ImportarFormulario()

                'If controles.Count > 1 Then
                '    For Each control As Control In controles
                '        frmPlano.Controls.Add(control)

                '    Next
                '    addFrm(frmPlano, 1)
                'End If

            Case "CrearFormulario"

                frmCrear.Show()

            Case "EditarFormulario"

                frmCrear.Show()
                Dim sender As Object = New Object()
                Dim e As EventArgs = New EventArgs()
                frmCrear.btnAbrir_Click(sender, e)
            Case "IngresarTratamiento"
                LimpiarControles(frmTratamientoC)
                frmTratamientoC.ModoActual = frmTratamientoCrear.Modo.Alta
                frmTratamientoC.ResetMode()
                frmTratamientoC.ShowDialog()
            Case "AsignarTratamiento" 'agarrar la ID de consulta
                LimpiarControles(frmTratamientoC)
                frmTratamientoC.ModoActual = frmTratamientoCrear.Modo.Busqueda
                frmTratamientoC.ResetMode()
                frmTratamientoC.ShowDialog()
            Case "SeguirTratamiento"
                LimpiarControles(frmTratamientoS)
                addFrm(frmTratamientoS)
            Case "IngresarAnalisis"
                LimpiarControles(frmAnalisisC)
                addFrm(frmAnalisisC)
            Case "SeguirAnalisis"
                LimpiarControles(frmAnalisisS)
                addFrm(frmAnalisisS)
            Case "DatosAnalisis"
                LimpiarControles(frmAnalisisS)
                Dim pac As New E_Paciente With {
                    .Cedula = frmAnalisisS.txtBuscar.Text
                }

                'pac.buscarPorCI()

                'Dim a = pac.buscarAnalisis()

                'frmAnalisisDatos._paciente = pac
                addFrm(frmAnalisisDatos)
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

    Private Sub AtenderMenuItem_Click(sender As Object, e As EventArgs) Handles AtenderMenuItem.Click
        Select Case MiModo
            Case Modo.SoyMedico
                InstanciarFormulario("Atender")
            Case Modo.SoyAuxiliar
                InstanciarFormulario("EntrevistaInicial")
        End Select
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
            _paciente.Cedula = 0
            ID_Consulta = 0
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
        AddHandler frmIni.btnAtenderPaciente.Click,
                    Sub()
                        AtenderMenuItem_Click(sender, e)
                    End Sub
        AddHandler frmIni.btnCrearFormulario.Click,
                    Sub()
                        CrearFormularioMenuItem_Click(sender, e)
                    End Sub
        AddHandler frmIni.btnEditarFormulario.Click,
                    Sub()
                        InstanciarFormulario("EditarFormulario")
                    End Sub

        'HANDLERS PARA FORMULARIO DE OPCIONES DE CONSULTA
        AddHandler frmOpsConsulta.btnIdentificacion.Click,
                    Sub()
                        InstanciarFormulario("Identificacion")
                    End Sub
        AddHandler frmOpsConsulta.btnEntrevistaPaciente.Click,
                    Sub()
                        InstanciarFormulario("Entrevista")
                    End Sub
        'HANDLERS PARA FORMULARIO SELECCIONAR MEDICO
        AddHandler frmSelecMed.btnBuscarMedico.Click,
                    Sub()
                        CargarDatosMedico()
                    End Sub

        'HANDLERS PARA FORMULARIO IDENTIFICACION PACIENTE

        AddHandler frmIdentificacion.btnBuscar.Click,
                    Sub()
                        CargarDatosPaciente()
                    End Sub
        AddHandler frmIdentificacion.btnEntrevistar.Click,
                    Sub()
                        Select Case frmIdentificacion.ModoActual
                            Case Identificacion_Paciente.Modo.MedicoAtiende
                                InstanciarFormulario("Entrevista")
                            Case Identificacion_Paciente.Modo.AgregarAListaHoy
                                AgregarPacienteAListado()
                        End Select
                    End Sub
        AddHandler frmIdentificacion.txtCedulaPaciente.TextChanged,
                    Sub()
                        CargarDatosPaciente()
                    End Sub
        'HANDLERS PARA FORMULARIO SELECCIONAR FORMULARIO

        AddHandler frmEntrevista.btnFrmGenerico.Click,
                    Sub()
                        InstanciarFormulario("Generico")
                    End Sub
        AddHandler generico.txtMotivoConsulta.TextChanged,
                    Sub()
                        Dim culture As New CultureInfo("es-ES")
                        If culture.CompareInfo.IndexOf(generico.txtMotivoConsulta.Text, "fiebre", CompareOptions.IgnoreCase) = 0 Then
                            'Sugerir frmFiebre
                            Dim eleccion = MessageBox.Show("¿Desea usar el formulario orientado a la fiebre?", "Usted ingresó fiebre como motivo de consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

                            If eleccion = vbOK Then
                                InstanciarFormulario("Fiebre")
                            End If

                        End If

                        If culture.CompareInfo.IndexOf(generico.txtMotivoConsulta.Text, "dolor", CompareOptions.IgnoreCase) = 0 Then
                            'Sugerir frmDolor
                            Dim eleccion = MessageBox.Show("¿Desea usar el formulario orientado a la dolor?", "Usted ingresó fiebre como motivo de consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

                            If eleccion = vbOK Then
                                InstanciarFormulario("Dolor")
                            End If

                        End If

                        If culture.CompareInfo.IndexOf(generico.txtMotivoConsulta.Text, "malestar", CompareOptions.IgnoreCase) = 0 Then
                            'Sugerir frmDolor
                            Dim eleccion = MessageBox.Show("¿Desea usar el formulario orientado a la malestar?", "Usted ingresó fiebre como motivo de consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

                            If eleccion = vbOK Then
                                InstanciarFormulario("Malestar")
                            End If

                        End If
                    End Sub

        AddHandler frmEntrevista.btnFrmDolor.Click,
                    Sub()
                        InstanciarFormulario("Dolor")
                    End Sub
        AddHandler frmEntrevista.btnFrmFiebre.Click,
                    Sub()
                        InstanciarFormulario("Fiebre")
                    End Sub
        AddHandler frmEntrevista.btnFrmMalestar.Click,
                    Sub()
                        InstanciarFormulario("Malestar")
                    End Sub
        AddHandler frmEntrevista.btnFrmOtro.Click,
                    Sub()
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
            _paciente.Cedula = 0
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

        Dim naux As New N_Usuario
    End Sub

    Async Sub CargarDatosPaciente()
        If Not frmIdentificacion.txtCedulaPaciente.TextLength = 8 Then
            _paciente.Cedula = 0
            Exit Sub
        End If
        If Not check_Cedula(frmIdentificacion.txtCedulaPaciente.Text) Then
            MessageBox.Show("La cédula ingresada no es valida. " & MensajeDeErrorCedula(), "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            _paciente.Cedula = 0
            LimpiarControles(frmIdentificacion)
            Exit Sub
        End If

        Dim np As New N_Paciente
        frmIdentificacion.PacienteBuscar = Await Task.Run(Function() np.ListarPacienteCI(CInt(frmIdentificacion.txtCedulaPaciente.Text)))
        frmIdentificacion.PacienteBuscar.Foto = Await Task.Run(Function() np.LeerFoto(frmIdentificacion.PacienteBuscar.Cedula))
        Select Case frmIdentificacion.PacienteBuscar.ErrMsg
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LimpiarControles(frmIdentificacion)
            Case 2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando comando", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LimpiarControles(frmIdentificacion)
            Case 8
                MessageBox.Show("No se encontró un paciente con esa cédula.", "Paciente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                LimpiarControles(frmIdentificacion)
            Case Else
                _paciente.Cedula = frmIdentificacion.PacienteBuscar.Cedula
                frmIdentificacion.PoblarDatos()
        End Select
    End Sub
    Async Sub CargarDatosMedico()
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

        Dim nm As New N_Medico
        frmSelecMed.MedicoSelect = Await Task.Run(Function() nm.ListarMedicoCI(CInt(frmSelecMed.txtCIMedico.Text)))
        frmSelecMed.MedicoSelect.Foto = Await Task.Run(Function() nm.LeerFoto(frmSelecMed.txtCIMedico.Text))
        Select Case frmSelecMed.MedicoSelect.ErrMsg
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LimpiarControles(frmSelecMed)
                Exit Sub
            Case 2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando comando", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LimpiarControles(frmSelecMed)
                Exit Sub
            Case 8
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
    End Sub

    Private Sub AsginarTratamientoPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsginarTratamientoPacienteToolStripMenuItem.Click
        InstanciarFormulario("AsignarTratamiento")
        'mostrar cuadro emergente en el que le permito buscar tratamientos por nombre y el selecciona.
        'datagridview que los carga.
        'el medico va seleccionando
        'se cargan los datos a campos de texto con enabled = false
    End Sub

    Private Sub EntrevistaInicialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntrevistaInicialToolStripMenuItem.Click
        InstanciarFormulario("EntrevistaInicial")
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

    Private Sub SeleccionarMedicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarMédicoToolStripMenuItem.Click
        InstanciarFormulario("SeleccionarMedico")
    End Sub

    Private Sub VerListadoDeHoyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerListadoDeHoyToolStripMenuItem1.Click
        InstanciarFormulario("VerListadoDeHoy")
    End Sub
End Class