Public Class E_Sintoma
    Protected _id As Integer
    Protected _nombre As String
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
    Sub New()

    End Sub

    Sub New(nombre As String, descripcion As String)
        _nombre = nombre
    End Sub

End Class