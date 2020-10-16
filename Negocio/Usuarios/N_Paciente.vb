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
End Class
