Imports Entidades
Imports Datos
Public Class N_Atiende
    Dim objDatos As New D_Atiende

    Public Function ConsultarMisConsultasDeHoy(CI_m As Integer) As List(Of E_Atiende)
        Return objDatos.ConsultarConsultasPendientes(CI_m)
    End Function

    Public Function AltaAtiende(consulta As E_Atiende) As Integer
        Return objDatos.AltaAtiende(consulta)
    End Function

    Public Function BuscarAtiende(CI As Integer) As List(Of E_Atiende)
        Return objDatos.BuscarMisConsultas(CI)
    End Function

    Public Function FinalizarConsulta(ID_C As Integer) As Integer

    End Function

End Class
