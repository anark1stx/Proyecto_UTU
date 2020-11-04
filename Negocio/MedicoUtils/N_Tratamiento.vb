Imports Entidades
Imports Datos
Public Class N_Tratamiento
    Dim objDatos As New D_Tratamiento

    Public Function AltaTratamiento(tratamiento As E_Tratamiento) As Integer
        Return objDatos.AltaTratamiento(tratamiento)
    End Function
    Public Function BuscarTratamientoXNombre(busqueda As String) As List(Of E_Tratamiento)
        Return objDatos.BuscarTratamientos(busqueda)
    End Function
    Function AltaPacienteSigueTratamiento(CI_P As Integer, t As E_Tratamiento) As Integer
        Return objDatos.AltaPacienteSigueTratamiento(CI_P, t)
    End Function
    Function AltaSeguimientoDiario(t As E_Tratamiento, seguimiento As E_Seguimiento, CI_P As Integer) As Integer
        Return objDatos.AltaSeguimientoDiario(t, seguimiento, CI_P)
    End Function
    Function AltaResultadoTratamiento(t As E_Tratamiento, CI_P As Integer) As Integer
        Return objDatos.AltaResultadoTratamiento(t, CI_P)
    End Function
    Function ConsultarHistorialTratamientos(CI_P As Integer) As List(Of E_Tratamiento)
        Return objDatos.ConsultarHistorialTratamientos(CI_P)
    End Function
    Function ConsultarDiasSemana(t As E_Tratamiento, CI_P As Integer) As Integer
        Return objDatos.ConsultarDiasSemana(t, CI_P)
    End Function
    Function ConsultarSeguimientoDiario(t As E_Tratamiento, CI_P As Integer, fecha As Date) As E_Seguimiento
        Return objDatos.ConsultarSeguimientoDiario(t, CI_P, fecha)
    End Function
    Function SugerirTratamientoSegunPyR(pyr As PreguntaRespuesta) As E_Tratamiento
        Return objDatos.SugerirTratamientoSegunPyR(pyr)
    End Function
    Function SugerirTratamientoSegunSintomas(sintoma As E_Sintoma) As E_Tratamiento
        Return objDatos.SugerirTratamientoSegunSintomas(sintoma)
    End Function
    Function SugerirTratamientoSegunSignosC(signoc As E_SignoClinico) As E_Tratamiento
        Return objDatos.SugerirTratamientoSegunSignosC(signoc)
    End Function
    Public Function SugerirTratamientoSegunEnfermedad(enfermedad As E_Enfermedad) As E_Tratamiento
        Return objDatos.SugerirTratamientoSegunEnfermedad(enfermedad)
    End Function
End Class
