Imports System.Windows.Forms
Public Class PreguntaRespuesta
    Protected _pregunta As Control
    Protected _id_pregunta As Integer
    Protected _respuesta As Control
    Property Pregunta As Control
        Get
            Return _pregunta
        End Get
        Set(value As Control)
            _pregunta = value
        End Set
    End Property

    Property Respuesta As Control
        Get
            Return _respuesta
        End Get
        Set(value As Control)
            _respuesta = value
        End Set
    End Property

    Property ID_Pregunta As Integer
        Get
            Return _id_pregunta
        End Get
        Set(value As Integer)
            _id_pregunta = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(pregunta As Control, respuesta As Control)
        _pregunta = pregunta
        _respuesta = respuesta
    End Sub

End Class
