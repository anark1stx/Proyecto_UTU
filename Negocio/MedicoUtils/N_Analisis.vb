Imports Entidades
Imports Datos
Public Class N_Analisis
    Dim objDatos As New D_Analisis
    Public Function AltaAnalisis(a As E_Analisis) As Integer
        Return objDatos.AltaAnalisis(a)
    End Function
    Public Function AltaAnalisisDatos(a As E_Analisis) As Integer
        'Return objDatos.AltaAnalisis(a)
    End Function

    Public Function AnalisisExiste(nom As String) As Integer
        Return objDatos.AnalisisExiste(nom)
    End Function

    Public Function RetornarParametros() As List(Of E_Analisis.Parametro)
        Return objDatos.RetornarParametros()
    End Function

    Public Function ConsultarDatosAnalisis() As Integer

    End Function

    Public Function AsignarAnalisisAPaciente(CI_P As Integer, ID_A As Integer, ID_C As Integer) As Integer
        Return objDatos.AsignarAnalisis(CI_P, ID_A, ID_C)
    End Function

    Public Function BuscarAnalisisXNombre(nom As String) As List(Of E_Analisis)
        Return objDatos.BuscarAnalisisXNombre(nom)
    End Function


End Class
