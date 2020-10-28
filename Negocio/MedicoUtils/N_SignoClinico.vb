Imports Entidades
Imports Datos
Public Class N_SignoClinico
    Dim objDatos As New D_SignoClinico

    Public Function AltaSignoClinico(s As E_SignoClinico) As Integer
        Return objDatos.AltaSignoClinico(s)
    End Function

    Public Function AltaExamenFisico(s As E_SignoClinico, consulta As E_Atiende) As Integer
        Return objDatos.AltaExamenFisico(s, consulta)
    End Function

    Public Function BuscarSignosClinicosRegistrados(ID_consulta As Integer) As List(Of E_SignoClinico)
        Return objDatos.BuscarExamenFisico(ID_consulta)
    End Function

End Class
