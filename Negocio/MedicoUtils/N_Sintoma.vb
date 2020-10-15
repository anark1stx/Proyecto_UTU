Imports Entidades
Imports Datos
Public Class N_Sintoma
    Dim objDatos As New D_Sintoma

    Public Function AltaModSintoma(s As E_Sintoma, altaomod As Boolean) As Integer
        Return objDatos.AltaModSintoma(s, altaomod)
    End Function

    Public Function AltaRegistraSintoma(s As E_Sintoma, consulta As E_Atiende) As Integer
        Return objDatos.AltaRegistraSintoma(s, consulta)
    End Function

    Public Function BuscarSintomasRegistrados(ID_consulta As Integer) As List(Of E_Sintoma)
        Return objDatos.BuscarSintomasRegistrados(ID_consulta)
    End Function

    Public Function ListarSintomas(nombre As String) As List(Of E_Sintoma)
        Return objDatos.ListarSintomas(nombre)
    End Function

    Public Function ConsultarDescripcionSintoma(s As E_Sintoma) As Integer
        Return objDatos.ConsultarDescripcionSintoma(s)
    End Function

End Class
