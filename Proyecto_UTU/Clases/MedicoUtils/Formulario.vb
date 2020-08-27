Public Class Formulario
    Protected _id As Integer
    Protected _nombre As String
    Protected _xml As String
    Protected v_previa As Byte()

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
            Return v_previa
        End Get
        Set(value As Byte())
            v_previa = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(nombre As String, xml As String, vPrevia As Byte())
        _nombre = nombre
        _xml = xml
        v_previa = vPrevia
    End Sub


    Public Function Alta() As Integer
        Dim retorno As Integer = 0

        Return retorno
    End Function

End Class