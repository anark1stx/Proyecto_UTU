Public Class E_EntrevistaIni
    Protected _id As Integer
    Protected _auxiliar As E_Usuario
    Protected _medico As E_Medico
    Protected _paciente As E_Paciente
    Protected _motivo As String

    Property Auxiliar As E_Usuario
        Get
            Return _auxiliar
        End Get
        Set(value As E_Usuario)
            _auxiliar = value
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

    Property Paciente As E_Paciente
        Get
            Return _paciente
        End Get
        Set(value As E_Paciente)
            _paciente = value
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

    Property ID As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Sub New()

    End Sub

    Sub New(a As E_Usuario, m As E_Medico, p As E_Paciente, motivo As String)
        _auxiliar = a
        _medico = m
        _paciente = p
        _motivo = motivo
    End Sub
End Class
