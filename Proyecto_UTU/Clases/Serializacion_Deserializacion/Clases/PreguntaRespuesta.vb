Public Class PreguntaRespuesta
    Protected _pregunta As Control
    Protected _respuesta As Control
    Protected _tag As String
    Public Property Pregunta As Control
        Get
            Return _pregunta
        End Get
        Set(value As Control)
            _pregunta = value
            _tag = Pregunta.Text
            _pregunta.Tag = Tag
        End Set
    End Property

    Public Property Respuesta As Control
        Get
            Return _respuesta
        End Get
        Set(value As Control)
            _respuesta = value
            _respuesta.Tag = Tag
        End Set
    End Property

    Public Property Tag As String
        Get
            Return _tag
        End Get
        Set(value As String)
            _tag = value
            _pregunta.Tag = value
            _respuesta.Tag = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(pregunta As Control, respuesta As Control)
        _pregunta = pregunta
        _respuesta = respuesta
    End Sub
End Class
