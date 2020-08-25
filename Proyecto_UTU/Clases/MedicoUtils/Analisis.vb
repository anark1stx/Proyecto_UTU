﻿Public Class Analisis

    Protected _nombre As String
    Protected _indicaciones As List(Of Indicacion)
    Protected _parametros As List(Of Parametro)

    Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)

        End Set
    End Property
    Property Parametros As List(Of Parametro)
        Get
            Return _parametros
        End Get
        Set(value As List(Of Parametro))
            _parametros = value
        End Set
    End Property
    Property Indicaciones As List(Of Indicacion)
        Get
            Return _indicaciones
        End Get
        Set(value As List(Of Indicacion))
            _indicaciones = value
        End Set
    End Property

    <Xml.Serialization.XmlInclude(GetType(Parametro))>
    Public Class Parametro
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
    Public Class Indicacion
        Protected _nombre As String
        Protected _indicacion As String

        Property Nombre As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property

        Property Indicacion As String
            Get
                Return _indicacion
            End Get
            Set(value As String)
                _indicacion = value
            End Set
        End Property

        Sub New()

        End Sub

        Sub New(nombre As String, indicacion As String)
            _nombre = nombre
            _indicacion = indicacion
        End Sub

    End Class

End Class
