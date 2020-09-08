Imports System.Windows.Forms
Public Class PreguntaRespuesta
    Protected _pregunta As Control
    Protected _respuesta As Control
    Protected _preguntaTexto As String 'La razon de usar preguntaTexto en vez de pregunta.text es que en la capa de datos tendria que agregar una referencia a windows forms, cosa que no nos interesa usar en esa capa.
    Protected _respuestaTexto As String
    Property Pregunta As Control
        Get
            Return _pregunta
        End Get
        Set(value As Control)
            _pregunta = value
            _preguntaTexto = value.Text
        End Set
    End Property

    Property Respuesta As Control
        Get
            Return _respuesta
        End Get
        Set(value As Control)
            _respuesta = value
            _respuestaTexto = value.Text
        End Set
    End Property

    Property PreguntaTexto As String
        Get
            Return _preguntaTexto
        End Get
        Set(value As String)
            _preguntaTexto = value
        End Set
    End Property

    Property RespuestaTexto As String
        Get
            Return _respuestaTexto
        End Get
        Set(value As String)
            _respuestaTexto = value
        End Set
    End Property


    Sub New()

    End Sub

    Sub New(pregunta As Control, respuesta As Control)
        _pregunta = pregunta
        _respuesta = respuesta
    End Sub

End Class
