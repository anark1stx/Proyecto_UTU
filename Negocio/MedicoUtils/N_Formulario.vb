Imports Entidades
Imports Datos
Public Class N_Formulario
    Dim objDatos As New D_Formulario

    Public Function AltaFormulario(form As E_Formulario) As Integer
        Return objDatos.AltaFormulario(form)
    End Function

    Public Function ModificarFormulario(form As E_Formulario) As Integer
        Return objDatos.ModificarFormulario(form)
    End Function

    Public Function BuscarFormularios(busqueda As String) As List(Of E_Formulario)
        Return objDatos.BuscarFormularios(busqueda)
    End Function

    Public Function BajaFormulario(form As E_Formulario) As Integer
        Return objDatos.BajaFormulario(form)
    End Function

    Public Function AltaFormularioDatos(form As E_Formulario) As Integer

    End Function

End Class
