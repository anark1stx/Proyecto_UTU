Imports Datos
Imports Entidades
Public Class N_Corresponde
    Dim objDatos As New D_Corresponde
    Public Function AltaCorresponde(crr As E_Corresponde) As Integer
        Return objDatos.AltaCorresponde(crr)
    End Function
    Public Function BajaCorresponde(crr As E_Corresponde) As Integer
        Return objDatos.BajaCorresponde(crr)
    End Function
    Public Function BuscarAsignaciones(u As E_Usuario, auxomedico As Boolean) As List(Of E_Corresponde)
        Return objDatos.BuscarAsignaciones_PMedico(u, auxomedico)
    End Function
End Class
