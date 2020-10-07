Public Class E_SignoClinico
    Property _id As Integer
    Protected _nombre As String
    Protected _descripcion As String
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