Imports System.Windows.Forms
Public Class PreguntaRespuesta
    Protected _pregunta As Control
    Protected _respuesta As Control
    Public Property Pregunta As Control
        Get
            Return _pregunta
        End Get
        Set(value As Control)
            _pregunta = value
        End Set
    End Property

    Public Property Respuesta As Control
        Get
            Return _respuesta
        End Get
        Set(value As Control)
            _respuesta = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(pregunta As Control, respuesta As Control)
        _pregunta = pregunta
        _respuesta = respuesta
    End Sub

End Class
