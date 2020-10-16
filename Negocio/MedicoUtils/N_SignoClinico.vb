Imports Entidades
Imports Datos
Public Class N_SignoClinico
    Dim objDatos As New D_SignoClinico

    Public Function AltaModSignoClinico(s As E_SignoClinico, altaomod As Boolean) As Integer
        Return objDatos.AltaModSignoClinico(s, altaomod)
    End Function

    Public Function AltaExamenFisico(s As E_SignoClinico, consulta As E_Atiende) As Integer
        Return objDatos.AltaExamenFisico(s, consulta)
    End Function

    Public Function BuscarSignosClinicosRegistrados(ID_consulta As Integer) As List(Of E_SignoClinico)
        Return objDatos.BuscarExamenFisico(ID_consulta)
    End Function

    Public Function ListarSignoClinicos(nombre As String) As List(Of E_SignoClinico)
        Return objDatos.ListarSignoCs(nombre)
    End Function

    Public Function ConsultarDescripcionSignoClinico(s As E_SignoClinico) As Integer
        Return objDatos.ConsultarDescripcionSignoC(s)
    End Function

End Class
