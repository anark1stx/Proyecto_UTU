Imports Entidades
Imports Negocio
Imports Utilidades
Imports FormulariosPersonalizados
Public Class frmDiagnosticos
    Protected _formularioDesdeBD As New E_Formulario
    Protected _ci_Paciente As Integer
    Private np As New N_Paciente
    Private id_seleccionada As Integer
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
        id_seleccionada = CInt(cbDiagnostico.SelectedItem)
        'cargar el formulario
        Dim r = Await Task.Run(Function() np.BuscarDiagnostico(id_seleccionada))
        Select Case r.ID
            Case -1
                MessageBox.Show(MensajeDeErrorConexion, "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento, "Error ejecutando acción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case -5
                MessageBox.Show("Hubieron errores cargando datos sobre la enfermedad, síntomas y signos clinicos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                pnlContenedorFormularios.Controls.Clear()
                Formulario = r
                Dim fl = New formularioLimpio
                Dim controles = ConvertirFormulario(r)
                fl.pnlContenedor.Controls.AddRange(controles.ToArray())
                PoblarRespuestas(r.PreguntasYRespuestas, controles)
                fl.MiFormulario = r
                entrevista.lbSignosClinicos.Items.AddRange(r.Enfermedad.SignosClinicos.ToArray())
                entrevista.lbSignosClinicos.Items.AddRange(r.Enfermedad.Sintomas.ToArray())
                entrevista.txtNomEnfermedad.Text = r.Enfermedad.Nombre
                entrevista.Frmlimpio = fl
                entrevista.Visible = True


        End Select
    End Sub




    Private Async Sub frmDiagnosticos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        entrevista.Visible = False
        pnlContenedorFormularios.Controls.Add(entrevista)
        Dim r = Await Task.Run(Function() np.BuscarAtiende(CI_Paciente))

        Select Case r(0).ID
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error efectuando acción", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case -8
                MessageBox.Show("No se encontraron consultas médicas realizadas.", "Sin datos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select

    End Sub

End Class