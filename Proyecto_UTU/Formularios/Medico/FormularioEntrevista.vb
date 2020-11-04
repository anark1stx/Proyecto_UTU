Imports Entidades
Public Class FormularioEntrevista
    Protected _miFormulario As New E_Formulario
    Property MiFormulario As E_Formulario
        Get
            Return _miFormulario
        End Get
        Set(value As E_Formulario)
            _miFormulario = value 'aca en el set podria invocar un metodo para agregar automaticamente todos los controles
        End Set
    End Property
End Class