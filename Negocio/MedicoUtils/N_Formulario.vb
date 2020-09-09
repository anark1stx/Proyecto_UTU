Imports Entidades
Imports Datos
Public Class N_Formulario
    Dim objDatos As New D_Formulario

    Public Function AltaFormulario(form As E_Formulario) As Integer
        Return objDatos.AltaFormulario(form)
    End Function

    Public Function ImportarFormularioPrueba() As E_Formulario
        Return objDatos.ImportarForm()
    End Function

    Public Function BuscarFormularios(busqueda As String) As List(Of E_Formulario)
        'return objDatos.BuscarFormularios(busqueda)
    End Function

End Class
