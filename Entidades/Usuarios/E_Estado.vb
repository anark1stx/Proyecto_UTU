Public Class E_Estado
    Protected _nombre As String
    Protected _fecha As Date
    Protected _errCode As Integer
    Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Property ErrCode As Integer
        Get
            Return _errCode
        End Get
        Set(value As Integer)
            _errCode = value
        End Set
    End Property
End Class
