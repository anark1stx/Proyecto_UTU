﻿Public Class E_Analisis
    Protected _id As Integer
    Protected _nombre As String
    Protected _indicaciones As New List(Of Indicacion)
    Protected _parametros As New List(Of Parametro)
    Protected _consultaReq As E_Atiende
    Protected _fechaRes As Date
    Protected _errCode As Integer

    Property ErrCode As Integer
        Get
            Return _errCode
        End Get
        Set(value As Integer)
            _errCode = value
        End Set
    End Property
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

    Property ConsultaReq As E_Atiende
        Get
            Return _consultaReq
        End Get
        Set(value As E_Atiende)
            _consultaReq = value
        End Set
    End Property

    Property FechaRes As Date
        Get
            Return _fechaRes
        End Get
        Set(value As Date)
            _fechaRes = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(nombre As String, parametros As List(Of Parametro), indicaciones As List(Of Indicacion))
        _nombre = nombre
        _parametros = parametros
        _indicaciones = indicaciones
    End Sub

    Public Class Parametro
        Protected _id As Integer
        Protected _nombre As String
        Protected _unidad As String
        Protected _valorMinimo As Double
        Protected _valorMaximo As Double
        Protected _valor As Double
        Protected _errCode As Integer

        Property ErrCode As Integer
            Get
                Return _errCode
            End Get
            Set(value As Integer)
                _errCode = value
            End Set
        End Property

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

        Property Valor As Double
            Get
                Return _valor
            End Get
            Set(value As Double)
                _valor = value
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
        Protected _descripcion As String

        Property Nombre As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property

        Property Descripcion As String
            Get
                Return _descripcion
            End Get
            Set(value As String)
                _descripcion = value
            End Set
        End Property
        Sub New()

        End Sub

        Sub New(nombre As String, descripcion As String)
            _nombre = nombre
            _descripcion = descripcion
        End Sub

    End Class

End Class
