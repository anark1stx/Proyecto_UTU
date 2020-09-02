Imports Entidades
Imports Datos
Public Class N_Paciente
    Inherits N_Usuario
    Dim objDatos As New D_Paciente

    Public Function ListarPacienteCI(CI As String) As E_Paciente
        Return objDatos.ListarPacientesCI(CI)
    End Function

    Public Function BuscarPacienteApellido(ap As String) As List(Of E_Paciente)
        Return objDatos.BuscarPacienteApellido(ap)
    End Function

    Public Overrides Function UsuarioExiste(CI As String) As Integer
        Return objDatos.UsuarioExiste(CI)
    End Function
    Public Function AltaPaciente(u As E_Paciente) As Integer
        Return objDatos.AltaPaciente(u)
    End Function

    Public Function ModificacionPaciente(u As E_Paciente) As Integer
        Return objDatos.ModificarPaciente(u)
    End Function

    Public Sub BajaLogicaPaciente(u As E_Paciente)
        objDatos.BajaLogicaUsuario(u)
    End Sub

    Public Sub AltaLogicaPaciente(u As E_Paciente)
        objDatos.AltaLogicaUsuario(u)
    End Sub

End Class
