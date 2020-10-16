Public Class E_Tratamiento
    Protected _id As Integer
    Protected _nombre As String
    Protected _descripcion As String
    Protected _consultaReq As E_Atiende
    Protected _fecha_inicio As Date
    Protected _fecha_fin As Date
    Protected _resultado As String
    Protected _listaSeguimientos As List(Of E_Seguimiento)

    Property ConsultaReq As E_Atiende
        Get
            Return _consultaReq
        End Get
        Set(value As E_Atiende)
            _consultaReq = value
        End Set
    End Property
    Property FechaInicio As Date
        Get
            Return _fecha_inicio
        End Get
        Set(value As Date)
            _fecha_inicio = value
        End Set
    End Property
    Property FechaFin As Date
        Get
            Return _fecha_fin
        End Get
        Set(value As Date)
            _fecha_fin = value
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

    Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Property ListaSeguimientos As List(Of E_Seguimiento)
        Get
            Return _listaSeguimientos
        End Get
        Set(value As List(Of E_Seguimiento))
            _listaSeguimientos = value
        End Set
    End Property

    Property Resultado As String
        Get
            Return _resultado
        End Get
        Set(value As String)
            _resultado = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(nombre As String, descripcion As String)
        _nombre = nombre
        _descripcion = descripcion
    End Sub
End Class
