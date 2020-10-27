Imports Entidades
Imports Utilidades
Imports Negocio
Public Class frmCategoriaEnf
    Protected _modo As frmGlosarioContenedor.Modo
    Protected _categoria As New E_Categoria
    Protected _subcategoria As New E_Categoria
    Protected _es_sub As New E_SubCategoria
    Property Modo As frmGlosarioContenedor.Modo
        Get
            Return _modo
        End Get
        Set(value As frmGlosarioContenedor.Modo)
            _modo = value
        End Set
    End Property

    Property Categoria As E_Categoria
        Get
            Return _categoria
        End Get
        Set(value As E_Categoria)
            _categoria = value
        End Set
    End Property

    Property SubCategoria As E_Categoria
        Get
            Return _subcategoria
        End Get
        Set(value As E_Categoria)
            _subcategoria = value
        End Set
    End Property

    Property Cat2EsCatDeC1 As E_SubCategoria
        Get
            Return _es_sub
        End Get
        Set(value As E_SubCategoria)
            _es_sub = value
        End Set
    End Property

    Sub configurarControles()
        Select Case Modo
            Case frmGlosarioContenedor.Modo.Consulta
                readOnlyControl(Me, True)
        End Select
    End Sub


End Class
