Imports Entidades
Imports Datos
Public Class N_Paciente
    Inherits N_Usuario
    Dim objDatos As New D_Paciente
    Public Function BuscarPacienteCI(CI As Integer) As E_Paciente
        Return objDatos.BuscarPacienteCI(CI)
    End Function

    Public Function BuscarPacienteApellido(ap As String) As List(Of E_Paciente)
        Return objDatos.BuscarPacienteApellido(ap)
    End Function
    Public Function AltaPaciente(u As E_Paciente) As Integer
        Return objDatos.AltaModPaciente(u, 0)
    End Function

    Public Function ModificacionPaciente(u As E_Paciente) As Integer
        Return objDatos.AltaModPaciente(u, 1)
    End Function

    Public Function BuscarMisAnalisis(CI As Integer) As List(Of E_Analisis)
        Return objDatos.BuscarMisAnalisis(CI)
    End Function

    Public Function BuscarAtiende(CI As Integer) As List(Of E_Atiende)
        Return objDatos.BuscarMisConsultas(CI)
    End Function

    Public Function BuscarDiagnostico(ID_C As Integer) As E_Formulario
        Return objDatos.BuscarDiagnostico(ID_C)
    End Function

End Class
