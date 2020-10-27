Public Class E_SubCategoria
    Protected _categoria_padre As New E_Categoria
    Protected _sub_cat As New E_Categoria

    Property CategoriaPadre As E_Categoria
        Get
            Return _categoria_padre
        End Get
        Set(value As E_Categoria)
            _categoria_padre = value
        End Set
    End Property

    Property SubCategoria As E_Categoria
        Get
            Return _sub_cat
        End Get
        Set(value As E_Categoria)
            _sub_cat = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(categoria_padre As E_Categoria, sub_cat As E_Categoria)
        _categoria_padre = categoria_padre
        _sub_cat = sub_cat
    End Sub

End Class