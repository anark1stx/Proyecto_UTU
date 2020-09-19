Public Class E_Atiende
    Protected _id As Integer
    Protected _nombre_c As String
    Protected _fecha As Date

    Property ID As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Property NombreConsulta As String
        Get
            Return _nombre_c
        End Get
        Set(value As String)
            _nombre_c = value
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

    Public Sub New()

    End Sub

    Public Sub New(nombre)
        _nombre_c = nombre
        _fecha = Date.Now
    End Sub

End Class
