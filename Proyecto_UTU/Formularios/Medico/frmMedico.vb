Imports System.Globalization
Imports Entidades
Imports Negocio
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

    Dim _paciente As New E_Paciente
    Protected _medico As New E_Medico

    Property MedicoActual As E_Medico
        Get
            Return _medico
        End Get
        Set(value As E_Medico)
            _medico = value
        End Set
    End Property

    Private Sub frmMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        agregarHandlers()
        InstanciarFormulario("Inicio")
        _paciente.Cedula = 0
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

    Public Sub InstanciarFormulario(formulario As String)

        Select Case formulario

            Case "Inicio"
                Me.MaximizeBox = True

                addFrm(frmIni)

            Case "Gestion"
                frmGestion.MedicoLogeado = New E_Medico With {.Cedula = MedicoActual.Cedula}
                addFrm(frmGestion)

            Case "Atender"
                Me.MaximizeBox = False

                addFrm(frmOpsConsulta)

            Case "Identificacion"
                LimpiarControles(frmIdentificacion)
                addFrm(frmIdentificacion)

            Case "Entrevista"

                If _paciente.Cedula = 0 Then
                    MessageBox.Show("Debe identificar al paciente primero.", "Falta identificar al paciente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                Me.MaximizeBox = False
                fixSize()

                addFrm(frmEntrevista)

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
                addFrm(frmTratamientoC)
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
                'DATOS DE PRUEBA, BORRAR LUEGO

                'Dim p As New Analisis.Parametro("Globulos Rojos", "mm3/10e9", 4.0, 5.5)
                'p.Valor = 3.4
                'Dim p2 As New Analisis.Parametro("Linfocitos T", "mm3/10e-7", 3.3, 4.1)
                'p2.Valor = 3.34
                'Dim p3 As New Analisis.Parametro("Linfocitos T", "mm3/10e-7", 3.3, 4.1)
                'p3.Valor = 1.4
                'Dim p4 As New Analisis.Parametro("Linfocitos T", "mm3/10e-7", 3.3, 4.1)
                'p4.Valor = 4.4
                'Dim a As New Analisis(0, "Resonancia Magnética", New List(Of Analisis.Parametro)(New Analisis.Parametro() {p, p2, p3, p4}))

                'Dim pac As New Paciente()
                'pac.Nombre1 = "Mateo"
                'pac.Apellido1 = "Carriquí"

                'frmAnalisisDatos.AnalisisACargar = a
                'frmAnalisisDatos._paciente = pac

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
        'Cargar Formulario de gestión para el médico.
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
        InstanciarFormulario("Atender")
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

        'HANDLERS PARA FORMULARIO IDENTIFICACION PACIENTE

        AddHandler frmIdentificacion.btnBuscar.Click,
                    Sub()
                        CargarDatosPaciente()
                    End Sub
        AddHandler frmIdentificacion.btnEntrevistar.Click,
                    Sub()
                        InstanciarFormulario("Entrevista")
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

    Sub CargarDatosPaciente()
        If check_Cedula(frmIdentificacion.txtCedulaPaciente.Text) Then
            Dim np As New N_Paciente
            frmIdentificacion.PacienteBuscar = np.ListarPacienteCI(CInt(frmIdentificacion.txtCedulaPaciente.Text))
            If frmIdentificacion.PacienteBuscar.Cedula <> 0 Then
                _paciente.Cedula = frmIdentificacion.PacienteBuscar.Cedula
                frmIdentificacion.PoblarDatos()
            Else
                MessageBox.Show("No se encontró un paciente con esa cédula.", "Paciente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            MessageBox.Show("La cédula ingresada no es valida. " & MensajeDeErrorCedula(), "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            _paciente.Cedula = 0
        End If
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
End Class