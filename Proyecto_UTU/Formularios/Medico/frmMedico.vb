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

    Public llenoIdentificacion As Boolean = False 'Para controlar que antes de que prosiga a las demas instancias haya identificado al paciente.
    Public Ci As String = ""

    Private Sub GestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionMenuItem.Click
        'Cargar Formulario de gestión para el médico.
        InstanciarFormulario("Gestion")
    End Sub

    Public Sub InstanciarFormulario(formulario As String)

        Select Case formulario

            Case "Inicio"
                Me.MaximizeBox = True
                If Not pnlContenedorFormularios.Controls.Contains(frmIni) Then
                    pnlContenedorFormularios.Controls.Clear()
                    frmIni.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmIdentificacion no está en el nivel más alto.
                    frmIni.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.
                    Me.pnlContenedorFormularios.Controls.Add(frmIni) 'Añadir el formulario al panel

                    frmIni.Anchor += AnchorStyles.Bottom
                    frmIni.Anchor += AnchorStyles.Right
                    frmIni.Dock = DockStyle.Fill

                    frmIni.Show()

                End If

            Case "Gestion"
                'If Me.WindowState = FormWindowState.Maximized Then
                'Me.WindowState = FormWindowState.Normal
                'End If
                'Me.MaximizeBox = False
                If Not pnlContenedorFormularios.Controls.Contains(frmGestion) Then
                    pnlContenedorFormularios.Controls.Clear()
                    frmGestion.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmIdentificacion no está en el nivel más alto.
                    frmGestion.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.
                    Me.pnlContenedorFormularios.Controls.Add(frmGestion) 'Añadir el formulario al panel

                    frmGestion.Anchor += AnchorStyles.Bottom
                    frmGestion.Anchor += AnchorStyles.Right
                    frmGestion.Dock = DockStyle.Fill

                    frmGestion.Show()

                End If

            Case "Atender"
                Me.MaximizeBox = False
                If pnlContenedorFormularios.Controls.Contains(frmIdentificacion) Then
                    Ci = frmIdentificacion.txtCIPaciente.Text
                End If

                If Not pnlContenedorFormularios.Controls.Contains(frmOpsConsulta) Then
                    pnlContenedorFormularios.Controls.Clear()
                    frmOpsConsulta.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmIdentificacion no está en el nivel más alto.
                    frmOpsConsulta.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.
                    Me.pnlContenedorFormularios.Controls.Add(frmOpsConsulta) 'Añadir el formulario al panel

                    frmOpsConsulta.Anchor += AnchorStyles.Bottom
                    frmOpsConsulta.Anchor += AnchorStyles.Right
                    frmOpsConsulta.Dock = DockStyle.Fill

                    frmOpsConsulta.Show()

                End If

            Case "Identificacion"

                If Not pnlContenedorFormularios.Controls.Contains(frmIdentificacion) Then
                    pnlContenedorFormularios.Controls.Clear()
                    frmIdentificacion.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmIdentificacion no está en el nivel más alto.
                    frmIdentificacion.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.
                    Me.pnlContenedorFormularios.Controls.Add(frmIdentificacion) 'Añadir el formulario al panel
                    frmIdentificacion.Show()

                End If

            Case "Entrevista"
                Me.MaximizeBox = False
                If check_Cedula(Ci) Then
                    llenoIdentificacion = True
                Else
                    llenoIdentificacion = False

                End If

                If Not llenoIdentificacion Then
                    MsgBox("Debe identificar primero al paciente antes de proceder con su entrevista.")
                    Exit Sub
                Else
                    If Me.WindowState = FormWindowState.Normal Then
                        Me.WindowState = FormWindowState.Maximized
                    End If
                    If Not pnlContenedorFormularios.Controls.Contains(frmEntrevista) Then
                        pnlContenedorFormularios.Controls.Clear()
                        frmEntrevista.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmIdentificacion no está en el nivel más alto.
                        frmEntrevista.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.

                        frmEntrevista.Anchor += AnchorStyles.Bottom
                        frmEntrevista.Anchor += AnchorStyles.Right
                        frmEntrevista.Dock = DockStyle.Fill

                        Me.pnlContenedorFormularios.Controls.Add(frmEntrevista) 'Añadir el formulario al panel
                        frmEntrevista.Show()

                    End If
                End If

            Case "Generico"

                If Not pnlContenedorFormularios.Controls.Contains(generico) Then
                    pnlContenedorFormularios.Controls.Clear()
                    generico.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmIdentificacion no está en el nivel más alto.
                    generico.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.

                    generico.Width = pnlContenedorFormularios.Width - 20
                    generico.Height = pnlContenedorFormularios.Height
                    Me.pnlContenedorFormularios.Controls.Add(generico) 'Añadir el formulario al panel
                    generico.Show()

                End If
            Case "Dolor"
                If Not pnlContenedorFormularios.Controls.Contains(frmDlr) Then
                    pnlContenedorFormularios.Controls.Clear()
                    frmDlr.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmIdentificacion no está en el nivel más alto.
                    frmDlr.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.

                    frmDlr.Width = pnlContenedorFormularios.Width - 20
                    frmDlr.Height = pnlContenedorFormularios.Height
                    Me.pnlContenedorFormularios.Controls.Add(frmDlr) 'Añadir el formulario al panel
                    frmDlr.Show()

                End If
            Case "Fiebre"
                If Not pnlContenedorFormularios.Controls.Contains(frmFbr) Then
                    pnlContenedorFormularios.Controls.Clear()
                    frmFbr.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmIdentificacion no está en el nivel más alto.
                    frmFbr.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.

                    frmFbr.Width = pnlContenedorFormularios.Width - 20
                    frmFbr.Height = pnlContenedorFormularios.Height
                    Me.pnlContenedorFormularios.Controls.Add(frmFbr) 'Añadir el formulario al panel
                    frmFbr.Show()

                End If

            Case "Malestar"
                If Not pnlContenedorFormularios.Controls.Contains(frmMal) Then
                    pnlContenedorFormularios.Controls.Clear()
                    frmMal.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmIdentificacion no está en el nivel más alto.
                    frmMal.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.

                    frmMal.Width = pnlContenedorFormularios.Width - 20
                    frmMal.Height = pnlContenedorFormularios.Height
                    Me.pnlContenedorFormularios.Controls.Add(frmMal) 'Añadir el formulario al panel
                    frmMal.Show()

                End If

            Case "Otro"

                If Not pnlContenedorFormularios.Controls.Contains(frmPlano) Then
                    pnlContenedorFormularios.Controls.Clear()
                    frmPlano.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmIdentificacion no está en el nivel más alto.
                    frmPlano.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.

                    frmPlano.Width = pnlContenedorFormularios.Width - 20
                    frmPlano.Height = pnlContenedorFormularios.Height

                End If

                Dim controles = ImportarFormulario()

                If controles.Count > 1 Then
                    For Each control As Control In controles
                        frmPlano.Controls.Add(control)

                    Next
                    Me.pnlContenedorFormularios.Controls.Add(frmPlano) 'Añadir el formulario al panel
                    frmPlano.Dock = DockStyle.Fill
                    frmPlano.Show()
                End If

            Case "CrearFormulario"

                frmCrear.Show()

            Case "EditarFormulario"

                frmCrear.Show()
                Dim sender As Object = New Object()
                Dim e As EventArgs = New EventArgs()
                frmCrear.btnAbrir_Click(sender, e)
        End Select

    End Sub

    Private Sub frmMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InstanciarFormulario("Inicio")
    End Sub

    Private Sub EntrevistaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        InstanciarFormulario("Identificacion")
    End Sub

    Private Sub CrearFormularioMenuItem_Click(sender As Object, e As EventArgs) Handles CrearFormularioMenuItem.Click
        'Abrir la ventana interactiva con items drag&drop
        InstanciarFormulario("CrearFormulario")
    End Sub

    Public Sub ciChecked(code As Integer) '0 = Cédula invalida, 1 = No existe en BD, 2 = All gucci.

        If code = 0 Then
            MsgBox("Cédula inválida.", MessageBoxIcon.Error)
            llenoIdentificacion = False
        ElseIf code = 1 Then
            MsgBox("Paciente no registrado en el sistema.", MessageBoxIcon.Error)
            llenoIdentificacion = False
        ElseIf code = 2 Then
            llenoIdentificacion = True
            LlenarDatosPaciente()
            MsgBox("Paciente Encontrado")
            InstanciarFormulario("Entrevista")
        End If
        Console.WriteLine(code)
    End Sub

    Public Sub LlenarDatosPaciente()
        'Este evento necesita integracion con la BD
    End Sub

    Public Sub fixSize() 'Metodo para redimensionar controles sin tener que entrar a las propiedades de cada uno a cambiarlo
        For Each c As Control In Me.Controls

            If c IsNot MenuStrip1 Then 'El unico control que no queremos modificar es el menu superior
                c.Anchor += AnchorStyles.Bottom
                c.Anchor += AnchorStyles.Top
                c.Anchor += AnchorStyles.Left
                c.Anchor += AnchorStyles.Right
                c.Dock = DockStyle.Top
            End If

        Next
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

End Class