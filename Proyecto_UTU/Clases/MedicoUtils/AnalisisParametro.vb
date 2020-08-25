Public Class AnalisisParametro
    Protected _nombre As String
    Protected _unidad As String
    Protected _valorMinimo As Double
    Protected _valorMaximo As Double

    Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Property Unidad As String
        Get
            Return _unidad
        End Get
        Set(value As String)
            _unidad = value
        End Set
    End Property

    Property ValorMinimo As Double
        Get
            Return _valorMinimo
        End Get
        Set(value As Double)
            _valorMinimo = value
        End Set
    End Property

    Property ValorMaximo As Double
        Get
            Return _valorMaximo
        End Get
        Set(value As Double)
            _valorMaximo = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(nombre As String, unidad As String, valorminimo As Double, valormaximo As Double)
        _nombre = nombre
        _unidad = unidad
        _valorMinimo = valorminimo
        _valorMaximo = valormaximo
    End Sub

End Class
