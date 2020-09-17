Imports Entidades
Imports FormulariosPersonalizados
Imports Utilidades
Imports Negocio
Public Class frmFiebre

    Protected _miFormulario As New E_Formulario

    Property MiFormulario As E_Formulario
        Get
            Return _miFormulario
        End Get
        Set(value As E_Formulario)
            _miFormulario = value
        End Set
    End Property
End Class