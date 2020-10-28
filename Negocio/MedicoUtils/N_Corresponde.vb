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
    Public Function BuscarAsignacionesM(m As E_Medico) As List(Of E_Corresponde)
        Return objDatos.BuscarAsignacionesM(m)
    End Function
    Public Function BuscarAsignacionesA(a As E_Usuario) As List(Of E_Corresponde)
        Return objDatos.BuscarAsignacionesA(a)
    End Function
End Class
