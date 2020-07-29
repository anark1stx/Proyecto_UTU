Public Class frmPaciente
    Dim frmDiagnostico As New frmDiagnosticos 'Instancia de formulario que tiene los diagnosticos del paciente
    Dim frmAnalisis As New frmAnalisis 'Instancia de formulario que tiene los diagnosticos del paciente
    Dim frmGestion As New frmGestionPaciente 'Instancia del formulario que tiene la ventana de gestión del paciente
    Private Sub GestiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionToolStripMenuItem.Click
        'Cargar Formulario de gestión para el médico.
        InstanciarFormulario("Gestion")
    End Sub

    Private Sub DiagnósticoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiagnosticoToolStripMenuItem.Click
        'Cargar formulario de consulta con el paciente.

        InstanciarFormulario("Diagnostico")
    End Sub

    Private Sub AnálisisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnalisisToolStripMenuItem.Click
        'Cargar formulario de consulta con el paciente.

        InstanciarFormulario("Analisis")
    End Sub

    Public Sub InstanciarFormulario(formulario As String)

        Select Case formulario
            Case "Diagnostico"

                If Not pnlContenedorFormularios.Controls.Contains(frmDiagnostico) Then
                    pnlContenedorFormularios.Controls.Clear()
                    frmDiagnostico.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmConsulta no está en el nivel más alto.
                    frmDiagnostico.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.
                    Me.pnlContenedorFormularios.Controls.Add(frmDiagnostico) 'Añadir el formulario al panel
                    frmDiagnostico.Show()

                End If

            Case "Gestion"

                If Not pnlContenedorFormularios.Controls.Contains(frmGestion) Then
                    pnlContenedorFormularios.Controls.Clear()
                    frmGestion.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmConsulta no está en el nivel más alto.
                    frmGestion.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.
                    Me.pnlContenedorFormularios.Controls.Add(frmGestion) 'Añadir el formulario al panel
                    frmGestion.Show()

                End If

            Case "Analisis"

                If Not pnlContenedorFormularios.Controls.Contains(frmAnalisis) Then
                    pnlContenedorFormularios.Controls.Clear()
                    frmAnalisis.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmConsulta no está en el nivel más alto.
                    frmAnalisis.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.
                    Me.pnlContenedorFormularios.Controls.Add(frmAnalisis) 'Añadir el formulario al panel
                    frmAnalisis.Show()

                End If

        End Select

    End Sub

    Private Sub frmPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InstanciarFormulario("Gestion")
        'fixSize()

    End Sub

    Public Sub fixSize() 'Metodo para redimensionar controles sin tener que entrar a las propiedades de cada uno a cambiarlo
        For Each c As Control In Me.Controls

            If c IsNot MenuStrip1 AndAlso c IsNot pnlContenedorFormularios Then 'El unico control que no queremos modificar es el menu superior
                c.Anchor += AnchorStyles.Bottom
                c.Anchor += AnchorStyles.Top
                c.Anchor += AnchorStyles.Left
                c.Anchor += AnchorStyles.Right
                If TypeOf c Is System.Windows.Forms.Form Then
                    c.Width = pnlContenedorFormularios.Width
                    c.Height = pnlContenedorFormularios.Height
                End If
            End If

        Next
    End Sub

End Class