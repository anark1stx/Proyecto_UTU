Imports Entidades
Imports Datos
Public Class N_Analisis
    Dim objDatos As New D_Analisis
    Public Function AltaAnalisis(a As E_Analisis) As Integer
        Return objDatos.AltaAnalisis(a)
    End Function
    Public Function AltaAnalisisResultados(a As E_Analisis) As Integer
        Return objDatos.AltaAnalisisResultados(a)
    End Function

    Public Function AnalisisExiste(nom As String) As Integer
        Return objDatos.AnalisisExiste(nom)
    End Function

    Public Function RetornarParametros() As List(Of E_Analisis.Parametro)
        Return objDatos.RetornarParametros()
    End Function

    Public Function ConsultarResultadosAnalisis(a As E_Analisis) As Integer
        Return objDatos.ConsultarResultadosAnalisis(a)
    End Function

    Public Function BuscarAnalisisXNombre(nom As String) As List(Of E_Analisis)
        Return objDatos.BuscarAnalisisXNombre(nom)
    End Function

    Public Function ListadoAnalisisPaciente(CI As Integer) As List(Of E_Analisis)
        Return objDatos.ListarAnalisisDePaciente(CI)
    End Function

End Class
