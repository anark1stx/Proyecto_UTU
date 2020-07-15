Public Class frmMedico
    Dim frmConsulta As New frmConsultaConPaciente 'Instancia del formulario de consulta con el paciente
    Dim frmGestion As New frmGestionMedico 'Instancia del formulario de gestion del medico
    Private Sub GestiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónToolStripMenuItem.Click
        'Cargar Formulario de gestión para el médico.
        InstanciarFormulario("Gestion")
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        'Cargar formulario de consulta con el paciente.

        InstanciarFormulario("Consulta")
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

        End Select

    End Sub

    Private Sub frmMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InstanciarFormulario("Consulta")
    End Sub

End Class