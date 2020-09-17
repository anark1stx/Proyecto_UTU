Imports Entidades
Imports Datos
Public Class N_Medico
    Inherits N_Usuario
    Dim objDatos As New D_Medico

    Public Function BuscarMedicoCI(CI As String) As E_Medico
        Return objDatos.BuscarMedicoCI(CI)
    End Function

    Public Function BuscarMedicoApellido(ap As String) As List(Of E_Medico)
        Return objDatos.BuscarMedicoApellido(ap)
    End Function
    Public Function BuscarMedicoEspecialidad(es As String) As List(Of E_Medico)
        Return objDatos.BuscarMedicoEspecialidad(es)
    End Function

    Public Function AltaMedico(u As E_Medico) As Integer
        Return objDatos.AltaMedico(u)
    End Function

    Public Function ModificacionMedico(u As E_Medico) As Integer
        Return objDatos.ModificarUsuarioMedico(u)
    End Function

    Public Function AltaEntrevistaInicial(c As E_EntrevistaIni) As Integer
        Return objDatos.AltaEntrevistaInicial(c)
    End Function

    Public Function ConsultarMisConsultasDeHoy(CI_m As Integer) As List(Of E_EntrevistaIni)
        Return objDatos.ConsultarMisConsultasDeHoy(CI_m)
    End Function

    Public Function EntrevistaInicialExiste(ei As E_EntrevistaIni) As Integer
        Return objDatos.EntrevistaInicialExiste(ei)
    End Function

End Class
