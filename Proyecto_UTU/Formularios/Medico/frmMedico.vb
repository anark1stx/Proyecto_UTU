Public Class frmMedico
    Dim frmIdentificacion As New Identificacion_Paciente 'Instancia del formulario de consulta con el paciente
    Dim frmGestion As New frmGestionMedico 'Instancia del formulario de gestion del medico

    Dim frmCrearFrm As New frmCrearFormulario 'Creacion de formularios personalizados

    Dim llenoIdentificacion As Boolean = False 'Para controlar que antes de que prosiga a las demas instancias haya identificado al paciente.

    Public frmPlano As New formularioPlano 'Usado para cargar las entrevistas en el.

    Private Sub GestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionMenuItem.Click
        'Cargar Formulario de gestión para el médico.
        InstanciarFormulario("Gestion")
    End Sub

    Public Sub InstanciarFormulario(formulario As String)

        Select Case formulario
            Case "Consulta"

                If Not pnlContenedorFormularios.Controls.Contains(frmIdentificacion) Then
                    pnlContenedorFormularios.Controls.Clear()
                    frmIdentificacion.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmIdentificacion no está en el nivel más alto.
                    frmIdentificacion.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.
                    Me.pnlContenedorFormularios.Controls.Add(frmIdentificacion) 'Añadir el formulario al panel
                    frmIdentificacion.Show()

                End If

            Case "Gestion"

                If Not pnlContenedorFormularios.Controls.Contains(frmGestion) Then
                    pnlContenedorFormularios.Controls.Clear()
                    frmGestion.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmIdentificacion no está en el nivel más alto.
                    frmGestion.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.
                    Me.pnlContenedorFormularios.Controls.Add(frmGestion) 'Añadir el formulario al panel
                    frmGestion.Show()

                End If

            Case "CrearFormulario"

                frmCrearFrm.Show()

            Case "Entrevista"
                If Not pnlContenedorFormularios.Controls.Contains(frmPlano) Then
                    pnlContenedorFormularios.Controls.Clear()
                    frmPlano.TopLevel = False 'es necesario marcar esto como false, ya que jerarquicamente frmIdentificacion no está en el nivel más alto.
                    frmPlano.TopMost = True 'si el formulario nuevo debe mostrarse encima del que ya habia.

                    frmPlano.Anchor += AnchorStyles.Bottom
                    frmPlano.Anchor += AnchorStyles.Right
                    frmPlano.Dock = DockStyle.Fill

                    Me.pnlContenedorFormularios.Controls.Add(frmPlano) 'Añadir el formulario al panel
                    frmPlano.Show()

                End If

        End Select

    End Sub

    Private Sub frmMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'fixSize()

        InstanciarFormulario("Gestion")
    End Sub

    Private Sub EntrevistaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IdentificacionMenuItem.Click
        InstanciarFormulario("Consulta")
    End Sub

    Private Sub EntrevistaMenuItem_Click(sender As Object, e As EventArgs) Handles EntrevistaMenuItem.Click
        If llenoIdentificacion = False Then
            MsgBox("Ingrese los datos de identificación del paciente primero. Anamnesis > Identificación.")
        Else
            'Abrir menú con todos los formularios guardados en la BD y dejarlo elegir, , u ofrecerle los que ya dejemos nosotros pre-hechos
        End If
    End Sub

    Private Sub CrearFormularioMenuItem_Click(sender As Object, e As EventArgs) Handles CrearFormularioMenuItem.Click
        'Abrir la ventana interactiva con items drag&drop
        InstanciarFormulario("CrearFormulario")
    End Sub

    Public Sub ciChecked(code As Integer) '0 = Cédula invalida, 1 = No existe en BD, 2 = All gucci.

        If code = 0 Then
            MsgBox("Cédula inválida.", MessageBoxIcon.Error)
        ElseIf code = 1 Then
            MsgBox("Paciente no registrado en el sistema.", MessageBoxIcon.Error)
        ElseIf code = 2 Then
            llenoIdentificacion = True
        End If

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

    Private Sub GenericoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenericoToolStripMenuItem.Click
        'Instanciar formulario generico
    End Sub

    Private Sub FiebreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FiebreToolStripMenuItem.Click
        'Instanciar formulario para la fiebre
    End Sub

    Private Sub DolorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DolorToolStripMenuItem.Click
        'Instanciar formulario para el dolor
    End Sub

    Private Sub OtroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtroToolStripMenuItem.Click
        'Abrir menú en el que puede cargar formularios desde la base de datos y la carpeta compartida de la VLAN de los medicos.
        Dim controles = ImportarFormulario()

        If controles.Count < 4 Then
            Exit Sub
        End If

        For Each control As Control In controles

            frmPlano.Controls.Add(control)

        Next

        InstanciarFormulario("Entrevista")
    End Sub
End Class