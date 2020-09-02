Imports Entidades
Imports Negocio
Public Class frmDiagnosticos
    Dim formulario_completo As New formularioPlano 'En esta variable va a ir guardado el formulario completo que diseño y lleno el medico
    Protected _formularioDesdeBD As New E_Formulario
    Protected _ci_Paciente As Integer

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

    Private Sub cbDiagnostico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDiagnostico.SelectedIndexChanged
        'Cargar el formulario que corresponde al item seleccionado: 

        '()-> Cargar formulario a la prop Formulario
        '()-> agregar frmPlano y deserializar los controles de la ruta Formulario.XML
        '()-> Cargar todas las respuestas de Responde a los campos segun su nombre, ex: Sintoma1 -> txtSintoma1.Text
    End Sub

    Private Sub frmDiagnosticos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '()-> cargar todos los registros de Atiende que su CI = CI_Paciente
        '()-> Dim na as new N_Atiende
        '()-> cbDiagnostico.Datasource = na.BuscarDiagnosticos(CI_Paciente)

        Me.Dock = DockStyle.Fill
    End Sub

End Class