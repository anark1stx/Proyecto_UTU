Public Class E_Formulario
    Protected _id As Integer
    Protected _nombre As String
    Protected _xml As String
    Protected _v_previa As Byte()
    Protected _paciente As E_Paciente 'paciente del cual se estan recabando los datos en la consulta
    Protected _medico As E_Medico 'medico que esta recabando datos del paciente en la consulta
    Protected _preguntasYrespuestas As List(Of PreguntaRespuesta)
    Protected _errMsg As String
    Property ID As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Property XML As String
        Get
            Return _xml
        End Get
        Set(value As String)
            _xml = value
        End Set
    End Property

    Property VistaPrevia As Byte()
        Get
            Return _v_previa
        End Get
        Set(value As Byte())
            _v_previa = value
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

    Property PreguntasYRespuestas As List(Of PreguntaRespuesta)
        Get
            Return _preguntasYrespuestas
        End Get
        Set(value As List(Of PreguntaRespuesta))
            _preguntasYrespuestas = value
        End Set
    End Property

    Property ErrMsg As String
        Get
            Return _errMsg
        End Get
        Set(value As String)
            _errMsg = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(nombre As String, xml As String, vPrevia As Byte())
        _nombre = nombre
        _xml = xml
        _v_previa = vPrevia
    End Sub

End Class