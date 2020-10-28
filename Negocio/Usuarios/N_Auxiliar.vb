Imports Entidades
Imports Datos
Public Class N_Auxiliar
    Inherits N_Usuario
    Dim objDatos As New D_auxiliar

    Public Function BuscarAuxiliarCI(CI As String) As E_Usuario
        Return objDatos.BuscarAuxiliarCI(CI)
    End Function
    Public Function BuscarAuxiliaresApellido(ap As String) As List(Of E_Usuario)
        Return objDatos.BuscarAuxiliarApellido(ap)
    End Function
    Public Function AltaAuxiliar(u As E_Usuario) As Integer
        Return objDatos.AltaAuxiliar(u)
    End Function
End Class
