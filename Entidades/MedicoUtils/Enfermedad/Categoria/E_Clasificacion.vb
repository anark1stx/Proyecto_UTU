Public Class E_Clasificacion
    Protected _enfermedad As New E_Enfermedad
    Protected _categoria As New E_Categoria
    Property NombreEnfermedad As E_Enfermedad
        Get
            Return _enfermedad
        End Get
        Set(value As E_Enfermedad)
            _enfermedad = value
        End Set
    End Property

    Property NombreCategoria As E_Categoria
        Get
            Return _categoria
        End Get
        Set(value As E_Categoria)
            _categoria = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(enfermedad As E_Enfermedad, categoria As E_Categoria)
        _enfermedad = enfermedad
        _categoria = categoria
    End Sub

End Class

