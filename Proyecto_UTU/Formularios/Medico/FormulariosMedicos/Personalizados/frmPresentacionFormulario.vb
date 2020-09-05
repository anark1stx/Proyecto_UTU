Imports Entidades
Public Class frmPresentacionFormulario
    Protected _formulario
    Property Formulario As E_Formulario
        Get
            Return _formulario
        End Get
        Set(value As E_Formulario)
            _formulario = value
        End Set
    End Property

End Class