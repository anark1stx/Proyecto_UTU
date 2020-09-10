Imports Entidades
Imports Datos
Public Class N_Tratamiento
    Dim objDatos As New D_Tratamiento
    Public Function AltaTratamientoDatos(tratamiento As E_Tratamiento) As Integer

    End Function

    Public Function AltaTratamiento(tratamiento As E_Tratamiento) As Integer
        Return objDatos.AltaTratamiento(tratamiento)
    End Function


End Class
