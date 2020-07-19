Public Class frmMedico
    Dim frmConsulta As New frmConsultaConPaciente 'Instancia del formulario de consulta con el paciente
    Dim frmGestion As New frmGestionMedico 'Instancia del formulario de gestion del medico

    Dim frmCrearFrm As New frmCrearFormulario

    Dim llenoIdentificacion As Boolean = False 'Para controlar que antes de que prosiga a las demas instancias haya identificado al paciente.
    Private Sub GestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionMenuItem.Click
        'Cargar Formulario de gestión para el médico.
        InstanciarFormulario("Gestion")
    End Sub

    Public Sub InstanciarFormulario(formulario As String)

        Select Case formulario
            Case "Consulta"

                If Not pnlContenedorFormularios.Controls.Contains(frmConsulta) Then
                    pnlContenedorFormularios.Controls.Clear()
                    frmConsulta.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmConsulta no está en el nivel más alto.
                    frmConsulta.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.
                    Me.pnlContenedorFormularios.Controls.Add(frmConsulta) 'Añadir el formulario al panel
                    frmConsulta.Show()

                End If

            Case "Gestion"

                If Not pnlContenedorFormularios.Controls.Contains(frmGestion) Then
                    pnlContenedorFormularios.Controls.Clear()
                    frmGestion.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmConsulta no está en el nivel más alto.
                    frmGestion.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.
                    Me.pnlContenedorFormularios.Controls.Add(frmGestion) 'Añadir el formulario al panel
                    frmGestion.Show()

                End If

            Case "CrearFormulario"

                frmCrearFrm.Show()
        End Select

    End Sub

    Private Sub frmMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InstanciarFormulario("Gestion")
    End Sub

    Private Sub EntrevistaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IdentificacionMenuItem.Click
        InstanciarFormulario("Consulta")
    End Sub

    Private Sub ElegirFormularioMenuItem_Click(sender As Object, e As EventArgs) Handles ElegirFormularioMenuItem.Click
        If llenoIdentificacion = False Then
            MsgBox("Ingrese los datos de identificación del paciente primero. Anamnesis>Identificación.")
        Else
            'Abrir menú con todos los formularios guardados en la BD y dejarlo elegir, u ofrecerle los que ya dejemos nosotros pre-hechos
        End If
    End Sub

    Private Sub EntrevistaMenuItem_Click(sender As Object, e As EventArgs) Handles EntrevistaMenuItem.Click
        If llenoIdentificacion = False Then
            MsgBox("Ingrese los datos de identificación del paciente primero. Anamnesis>Identificación.")
        Else
            'Abrir menú con todos los formularios guardados en la BD y dejarlo elegir, , u ofrecerle los que ya dejemos nosotros pre-hechos
        End If
    End Sub

    Private Sub CrearFormularioMenuItem_Click(sender As Object, e As EventArgs) Handles CrearFormularioMenuItem.Click
        'Abrir la ventana interactiva con items drag&drop
        InstanciarFormulario("CrearFormulario")
    End Sub
End Class