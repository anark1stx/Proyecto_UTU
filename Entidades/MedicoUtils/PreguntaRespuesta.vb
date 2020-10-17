Imports System.Windows.Forms
Public Class PreguntaRespuesta
    Protected _pregunta As Control
    Protected _id_pregunta As Integer
    Protected _respuesta As Control
    Protected _tag As String
    Protected _errCode As Integer

    Property ErrCode As Integer
        Get
            Return _errCode
        End Get
        Set(value As Integer)
            _errCode = value
        End Set
    End Property
    Property Pregunta As Control
        Get
            Return _pregunta
        End Get
        Set(value As Control)
            _pregunta = value
            _pregunta.Tag = Tag
        End Set
    End Property

    Property Respuesta As Control
        Get
            Return _respuesta
        End Get
        Set(value As Control)
            _respuesta = value
            _respuesta.Tag = Tag
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

    Property Tag As String
        Get
            Return _tag
        End Get
        Set(value As String)
            _tag = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(tag As String, pregunta As Control, respuesta As Control)
        _tag = tag
        _pregunta = pregunta
        _respuesta = respuesta
    End Sub

    Sub New(tag As String, pregunta As Control)
        _tag = tag
        _pregunta = pregunta
    End Sub

End Class
