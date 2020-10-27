Public Class frmGlosarioContenedor
    Protected _filtro As Filtro
    Protected _modo As Modo

    Property FiltroBuscar As Filtro
        Get
            Return _filtro
        End Get
        Set(value As Filtro)
            _filtro = value
        End Set
    End Property

    Property MiModo As Modo
        Get
            Return _modo
        End Get
        Set(value As Modo)
            _modo = value
        End Set
    End Property
    Public Enum Modo
        Ingreso
        Consulta
    End Enum

    Public Enum Filtro
        Enfermedad
        Sintoma
        SignoClinico
        Categorias
    End Enum
End Class