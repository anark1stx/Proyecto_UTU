Imports Entidades
Imports Datos
Public Class N_Tratamiento
    Dim objDatos As New D_Tratamiento
    Public Function AltaTratamientoDatos(tratamiento As E_Tratamiento) As Integer

    End Function

    Public Function AltaTratamiento(tratamiento As E_Tratamiento) As Integer
        Return objDatos.AltaTratamiento(tratamiento)
    End Function

    Public Function BuscarTratamientoXNombre(busqueda As String) As List(Of E_Tratamiento)
        Return objDatos.BuscarTratamientos(busqueda)
    End Function

    Function AltaPacienteSigueTratamiento()

    End Function

    Function AltaSeguimientoDiario()

    End Function

End Class
