Imports Entidades
Imports Negocio
Public Class frmAnalisis
    Protected _ci_paciente As Integer
    Protected _E_Analisis As E_Analisis
    Property CI_Paciente As Integer
        Get
            Return _ci_paciente
        End Get
        Set(value As Integer)
            _ci_paciente = value
        End Set
    End Property

    Property E_AnalisisElegido As E_Analisis
        Get
            Return _E_Analisis
        End Get
        Set(value As E_Analisis)
            _E_Analisis = value
        End Set
    End Property

    Private Sub frmE_Analisis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        cbAnalisis.SelectedIndex = 0
    End Sub

    Private Sub cbE_Analisis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAnalisis.SelectedIndexChanged
        'Cargar el formulario que corresponde al item seleccionado: 

        '()-> Cargar formulario a la prop E_Analisis
        '()-> Instanciar una label x cada parametro del objeto
        '()-> Cargar todos los valores de los parametros E_Analisis que vienen desde <datos>

    End Sub
End Class