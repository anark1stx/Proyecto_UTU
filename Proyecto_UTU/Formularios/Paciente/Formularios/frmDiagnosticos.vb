Imports Entidades
Imports Negocio
Imports Utilidades
Imports FormulariosPersonalizados
Public Class frmDiagnosticos
    Protected _formularioDesdeBD As New E_Formulario
    Protected _ci_Paciente As Integer
    Private na As New N_Atiende
    Private nf As New N_Formulario
    Private entrevista As New ContenedorEntrevistas
    Property CI_Paciente As Integer
        Get
            Return _ci_Paciente
        End Get
        Set(value As Integer)
            _ci_Paciente = value
        End Set
    End Property

    Property Formulario As E_Formulario
        Get
            Return _formularioDesdeBD
        End Get
        Set(value As E_Formulario)
            _formularioDesdeBD = value
        End Set
    End Property

    Private Async Sub cbDiagnostico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDiagnostico.SelectedIndexChanged
        Dim id_seleccionada As Integer
        Try
            id_seleccionada = cbDiagnostico.SelectedValue
            Console.WriteLine(id_seleccionada)
        Catch ex As Exception
            Exit Sub
        End Try
        Dim r = Await Task.Run(Function() nf.BuscarDiagnostico(id_seleccionada))
        Select Case r.ID
            Case -1
                MessageBox.Show(MensajeDeErrorConexion, "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento, "Error ejecutando acción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select
        Formulario = r
        Dim fl = New FormularioEntrevista
        Dim controles = ConvertirFormulario(r)
        fl.pnlContenedor.Controls.AddRange(controles.ToArray())
        PoblarRespuestas(r.PreguntasYRespuestas, controles)
        fl.MiFormulario = r
        entrevista.Entrevista = fl
        entrevista.ModoActual = ContenedorEntrevistas.Modo.Consulta
        entrevista.lbSignosClinicos.DataSource = r.Enfermedad.SignosClinicos
        entrevista.lbSignosClinicos.DisplayMember = "Nombre"
        entrevista.lbSintomas.DataSource = r.Enfermedad.Sintomas
        entrevista.lbSintomas.DisplayMember = "Nombre"
        Console.WriteLine("tratamiento: " & r.Tratamiento.Nombre & "analisis: " & r.Analisis.Nombre)
        If Not String.IsNullOrWhiteSpace(r.Enfermedad.Nombre) Then
            entrevista.txtNomEnfermedad.Text = r.Enfermedad.Nombre
            entrevista.chkEnfermo.Checked = True
        End If
        If Not String.IsNullOrWhiteSpace(r.Analisis.Nombre) Then
            entrevista.txtNomAnalisis.Text = r.Analisis.Nombre
            entrevista.chkAnalisis.Checked = True
        End If
        If Not String.IsNullOrWhiteSpace(r.Tratamiento.Nombre) Then
            entrevista.txtNomTratamiento.Text = r.Tratamiento.Nombre
            entrevista.chkTratamiento.Checked = True
        End If
        entrevista.Visible = True
    End Sub

    Private Async Sub frmDiagnosticos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        entrevista.Visible = False

        entrevista.Dock = DockStyle.Fill
        pnlContenedorFormularios.Controls.Add(entrevista)
        Dim r = Await Task.Run(Function() na.BuscarAtiende(CI_Paciente))

        Select Case r(0).ID
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error efectuando acción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case -8
                MessageBox.Show("No se encontraron consultas médicas realizadas.", "Sin datos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
        End Select

        Dim itemFormateados = r.Select(Function(consulta) New With {
            consulta.ID,
            consulta.Fecha,
            Key .FormattedItem = String.Format("{0} - {1}", consulta.Fecha.ToShortDateString(), consulta.NombreConsulta)
        }).ToArray()

        cbDiagnostico.DataSource = itemFormateados
        cbDiagnostico.DisplayMember = "FormattedItem"
        cbDiagnostico.ValueMember = "ID"
    End Sub

End Class