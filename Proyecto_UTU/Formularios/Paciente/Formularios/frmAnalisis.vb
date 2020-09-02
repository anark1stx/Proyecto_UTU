Public Class frmAnalisis
    Protected _ci_paciente As Integer
    Protected _analisis As Analisis
    Property CI_Paciente As Integer
        Get
            Return _ci_paciente
        End Get
        Set(value As Integer)
            _ci_paciente = value
        End Set
    End Property

    Property AnalisisElegido As Analisis
        Get
            Return _analisis
        End Get
        Set(value As Analisis)
            _analisis = value
        End Set
    End Property

    Private Sub frmAnalisis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        cbAnalisis.SelectedIndex = 0
    End Sub

    Private Sub cbAnalisis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAnalisis.SelectedIndexChanged
        'Cargar el formulario que corresponde al item seleccionado: 

        '()-> Cargar formulario a la prop Analisis
        '()-> Instanciar una label x cada parametro del objeto
        '()-> Cargar todos los valores de los parametros analisis que vienen desde <datos>

    End Sub
End Class