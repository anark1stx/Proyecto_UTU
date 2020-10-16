Public Class E_Seguimiento
    Protected _id_seg As Integer
    Protected _descripcion As String
    Protected _fecha As Date
    Property ID_Seguimiento As Integer
        Get
            Return _id_seg
        End Get
        Set(value As Integer)
            _id_seg = value
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

    Sub New(id_seg As Integer, fecha As Date, descripcion As String)
        _id_seg = id_seg
        _fecha = fecha
        _descripcion = descripcion
    End Sub

End Class
