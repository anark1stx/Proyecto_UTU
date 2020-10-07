Public Class E_Enfermedad
    Protected _nombre As String
    Protected _descripcion As String
    Protected _sintomas As New List(Of E_Sintoma)
    Protected _signos As New List(Of E_SignoClinico)
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
