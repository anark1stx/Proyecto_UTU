Public Class E_Enfermedad
    Protected _nombre As String
    Protected _descripcion As String
    Protected _f_etaria_min As Integer
    Protected _f_etaria_max As Integer
    Protected _sintomas As New List(Of E_Sintoma)
    Protected _signos As New List(Of E_SignoClinico)
    Protected _categorias As New List(Of E_Categoria)
    Protected _errCode As Integer

    Property Categorias As List(Of E_Categoria)
        Get
            Return _categorias
        End Get
        Set(value As List(Of E_Categoria))
            _categorias = value
        End Set
    End Property


    Property FranjaEtariaMax As Integer
        Get
            Return _f_etaria_max
        End Get
        Set(value As Integer)
            _f_etaria_max = value
        End Set
    End Property
    Property FranjaEtariaMin As Integer
        Get
            Return _f_etaria_min
        End Get
        Set(value As Integer)
            _f_etaria_min = value
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
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Property Sintomas As List(Of E_Sintoma)
        Get
            Return _sintomas
        End Get
        Set(value As List(Of E_Sintoma))
            _sintomas = value
        End Set
    End Property
    Property SignosClinicos As List(Of E_SignoClinico)
        Get
            Return _signos
        End Get
        Set(value As List(Of E_SignoClinico))
            _signos = value
        End Set
    End Property

End Class
