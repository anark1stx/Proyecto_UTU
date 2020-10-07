Public Class E_Atiende
    Protected _id As Integer
    Protected _nombre_c As String
    Protected _fecha As Date
    Protected _motivo As String
    Protected _paciente As New E_Paciente
    Protected _medico As New E_Medico
    Protected _c_referencia As E_Atiende
    Property Paciente As E_Paciente
        Get
            Return _paciente
        End Get
        Set(value As E_Paciente)
            _paciente = value
        End Set
    End Property
    Property Medico As E_Medico
        Get
            Return _medico
        End Get
        Set(value As E_Medico)
            _medico = value
        End Set
    End Property

    Property ID As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Property NombreConsulta As String
        Get
            Return _nombre_c
        End Get
        Set(value As String)
            _nombre_c = value
        End Set
    End Property
    Property Motivo As String
        Get
            Return _motivo
        End Get
        Set(value As String)
            _motivo = value
        End Set
    End Property

    Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Property ConsultaReferencia As E_Atiende
        Get
            Return _c_referencia
        End Get
        Set(value As E_Atiende)
            _c_referencia = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(nombre As String, motivo As String, paciente As E_Paciente, medico As E_Medico)
        _nombre_c = nombre
        _medico = medico
        _paciente = paciente
        _motivo = motivo
    End Sub
End Class
