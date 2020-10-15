Imports Entidades
Imports Datos
Public Class N_Sintoma
    Dim objDatos As New D_Sintoma

    Public Function AltaSintoma(s As E_Sintoma)
        Return objDatos.AltaModSintoma(s, 0)
    End Function

End Class
