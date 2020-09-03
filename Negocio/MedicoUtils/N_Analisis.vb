Imports Entidades
Imports Datos
Public Class N_Analisis
    Dim objDatos As New D_Analisis
    Public Function AltaAnalisis(a As E_Analisis) As Integer
        Return objDatos.AltaAnalisis(a)
    End Function


End Class
