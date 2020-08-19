Imports System.Globalization

Public Class frmMedico

    Dim frmIni As New frmInicio
    Dim frmGestion As New frmGestionMedico
    Dim frmOpsConsulta As New frmOpcionesConsulta
    Dim frmIdentificacion As New Identificacion_Paciente
    Dim frmEntrevista As New frmSeleccionarFormularioEntrevista

    Dim frmCrear As New frmCrearFormulario
    Dim frmPlano As New formularioPlano

    Dim generico As New frmGenerico
    Dim frmDlr As New frmDolor
    Dim frmFbr As New frmFiebre
    Dim frmMal As New frmMalestar

    Dim llenoIdentificacion As Boolean = False 'Para controlar que antes de que prosiga a las demas instancias haya identificado al paciente.
    Dim Ci As String = ""

    Dim _paciente As New Paciente

    Private Sub frmMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        agregarHandlers()
        InstanciarFormulario("Inicio")
    End Sub

    Public Sub addFrm(frm As Form, isMedicalForm As Boolean)
        If Not pnlContenedorFormularios.Controls.Contains(frm) Then
            pnlContenedorFormularios.Controls.Clear()

            If Not isMedicalForm Then
                frm.Anchor += AnchorStyles.Bottom
                frm.Anchor += AnchorStyles.Right
                frm.Dock = DockStyle.Fill
            Else
                frm.Dock = DockStyle.Fill
                frm.Height = pnlContenedorFormularios.Height
            End If

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

                addFrm(frmIni, 0)

            Case "Gestion"
                addFrm(frmGestion, 0)

            Case "Atender"
                Me.MaximizeBox = False

                If pnlContenedorFormularios.Controls.Contains(frmIdentificacion) Then
                    Ci = frmIdentificacion.txtCIPaciente.Text
                End If

                addFrm(frmOpsConsulta, 0)

            Case "Identificacion"

                addFrm(frmIdentificacion, 0)

            Case "Entrevista"

                If check_Cedula(Ci) Then
                    llenoIdentificacion = True
                Else
                    llenoIdentificacion = False
                    MsgBox("Debe identificar primero al paciente antes de proceder con su entrevista.")
                    Exit Sub
                End If
                Me.MaximizeBox = False
                fixSize()

                addFrm(frmEntrevista, 0)

            Case "Generico"
                addFrm(generico, 1)

            Case "Dolor"
                addFrm(frmDlr, 1)

            Case "Fiebre"
                addFrm(frmFbr, 1)

            Case "Malestar"
                addFrm(frmMal, 1)

            Case "Otro"

                frmPlano.Controls.Clear()

                Dim controles = ImportarFormulario()

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
                        chkCedulaTXTCIPACIENTE()
                        If frmIdentificacion.txtCIPaciente.TextLength < 8 Then
                            Ci = frmIdentificacion.txtCIPaciente.Text
                        End If
                    End Sub
        AddHandler frmIdentificacion.txtCIPaciente.TextChanged,
                    Sub()
                        chkCedulaTXTCIPACIENTE()
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
    End Sub

    Private Sub chkCedulaTXTCIPACIENTE() 'Evento para cuando el médico escribe la cédula del textbox del paciente en el sub-formulario de Identificacion_Paciente
        If frmIdentificacion.txtCIPaciente.TextLength = 8 Then

            If check_Cedula(frmIdentificacion.txtCIPaciente.Text) Then
                'Verificar que exista en la BD

                Ci = frmIdentificacion.txtCIPaciente.Text
                llenoIdentificacion = True
                _paciente = New Paciente()
                CargarDatosPaciente()

                'InstanciarFormulario("Entrevista") -> Mandar esto a otro botón
            Else
                Ci = frmIdentificacion.txtCIPaciente.Text
                MsgBox("Cédula inválida.", MessageBoxIcon.Error)
                llenoIdentificacion = False
            End If

        End If
    End Sub

    Private Sub CargarDatosPaciente()
        _paciente.Cedula = Ci.ToString()
        Dim datosP = _paciente.buscarPorCI()
        Select Case datosP
            Case 0
                MessageBox.Show("No se encontraron datos para este paciente", "Paciente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 1
                frmIdentificacion.lblNombresTXT.Text = _paciente.Nombre1 & ", " & _paciente.Nombre2
                frmIdentificacion.lblApellidosTXT.Text = _paciente.Apellido1 & ", " & _paciente.Apellido2

                frmIdentificacion.lblDireccionTXT.Text = String.Empty
                frmIdentificacion.lblTelefonoTXT.Text = String.Empty

                For i = 0 To _paciente.direccion.Count - 1
                    frmIdentificacion.lblDireccionTXT.Text &= (_paciente.direccion(i) & ", ")
                Next

                For i = 0 To _paciente.telefonosLista.Count - 1
                    frmIdentificacion.lblTelefonoTXT.Text &= (_paciente.telefonosLista(i) & ", ")
                Next


                frmIdentificacion.lblSexoTXT.Text = _paciente.Sexo
                frmIdentificacion.lblOcupacionTXT.Text = _paciente.Ocupacion
                frmIdentificacion.lblEstadoCivilTXT.Text = _paciente.Estado_civil
                frmIdentificacion.lblEdadTXT.Text = _paciente.Edad

                For Each l As Control In frmIdentificacion.Controls
                    If TypeOf l Is Label Then
                        If l.Text.EndsWith(", ") Then
                            l.Text = l.Text.Substring(0, l.Text.LastIndexOf(","))
                        End If
                    End If

                Next


        End Select

    End Sub

End Class