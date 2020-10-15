Imports Entidades
Imports Datos
Public Class N_Enfermedad
    Dim objDatos As New D_Enfermedad

    Public Function AltaModenfermedad(s As E_Enfermedad, altaomod As Boolean) As Integer
        Return objDatos.AltaModEnfermedad(s, altaomod)
    End Function

    Public Function Listarenfermedades(nombre As String) As List(Of E_Enfermedad)
        Return objDatos.ListarEnfermedades(nombre)
    End Function

    Public Function ConsultarDescripcionenfermedad(s As E_Enfermedad) As Integer
        Return objDatos.ConsultarDescripcionEnfermedad(s)
    End Function

    Public Function SugerirEnfermedadSegunPyR(pyrList As List(Of PreguntaRespuesta)) As E_Enfermedad
        Return objDatos.SugerirEnfermedadSegunPyR(pyrList)
    End Function

    Public Function SugerirEnfermedadSegunSintomas(sList As List(Of E_Sintoma)) As E_Enfermedad
        Return objDatos.SugerirEnfermedadSegunSintomas(sList)
    End Function
    Public Function SugerirEnfermedadSegunSignosC(scList As List(Of E_SignoClinico)) As E_Enfermedad
        Return objDatos.SugerirEnfermedadSegunSignosC(scList)
    End Function

End Class
