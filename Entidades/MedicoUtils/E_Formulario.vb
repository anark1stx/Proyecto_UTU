Public Class E_Formulario
    Protected _id As Integer
    Protected _nombre As String
    Protected _xml As String 'ruta .xml
    Protected _v_previa As String 'ruta .jpg/png

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

    Property VistaPrevia As String
        Get
            Return _v_previa
        End Get
        Set(value As String)
            _v_previa = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(nombre As String, xml As String, vPrevia As String)
        _nombre = nombre
        _xml = xml
        _v_previa = vPrevia
    End Sub

End Class