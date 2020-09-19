Imports Entidades
Imports Negocio
Imports Utilidades
Public Class frmDiagnosticos
    Protected _formularioDesdeBD As New E_Formulario
    Protected _ci_Paciente As Integer
    Private np As New N_Paciente
    Private nf As New N_Formulario
    Private id_seleccionada As Integer
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
        Dim r = Await Task.Run(Function() np.BuscarMisDiagnosticos)
    End Sub

    Private Async Sub frmDiagnosticos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
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