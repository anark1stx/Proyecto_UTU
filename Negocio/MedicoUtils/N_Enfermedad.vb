Imports Entidades
Imports Datos
Public Class N_Enfermedad
    Dim objDatos As New D_Enfermedad

    Public Function AltaEnfermedad(e As E_Enfermedad) As Integer
        Return objDatos.AltaEnfermedad(e)
    End Function
    Public Function SugerirEnfermedadSegunPyR(pyr As PreguntaRespuesta) As E_Enfermedad
        Return objDatos.SugerirEnfermedadSegunPyR(pyr)
    End Function

    Public Function SugerirEnfermedadSegunSintomas(sintoma As E_Sintoma) As E_Enfermedad
        Return objDatos.SugerirEnfermedadSegunSintomas(sintoma)
    End Function
    Public Function SugerirEnfermedadSegunSignosC(signoc As E_SignoClinico) As E_Enfermedad
        Return objDatos.SugerirEnfermedadSegunSignosC(signoc)
    End Function

End Class
