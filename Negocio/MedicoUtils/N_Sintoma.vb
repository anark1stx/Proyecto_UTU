Imports Entidades
Imports Datos
Public Class N_Sintoma
    Dim objDatos As New D_Sintoma

    Public Function AltaSintoma(s As E_Sintoma) As Integer
        Return objDatos.AltaSintoma(s)
    End Function

    Public Function AltaRegistraSintoma(s As E_Sintoma, consulta As E_Atiende) As Integer
        Return objDatos.AltaRegistraSintoma(s, consulta)
    End Function

    Public Function BuscarSintomasRegistrados(ID_consulta As Integer) As List(Of E_Sintoma)
        Return objDatos.BuscarSintomasRegistrados(ID_consulta)
    End Function

End Class
