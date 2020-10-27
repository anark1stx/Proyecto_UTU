Imports Entidades
Imports Datos
Public Class N_Categoria
    Dim objDatos As New D_Categoria
    Public Function AltaModCategoria(cat As E_Categoria, altaomod As Boolean) As Integer
        Return objDatos.AltaModcategoria(cat, altaomod)
    End Function

    Public Function AltaClasificacion(enf As E_Enfermedad, cat As E_Categoria) As Integer
        Return objDatos.AltaClasificacion(enf, cat)
    End Function

End Class
