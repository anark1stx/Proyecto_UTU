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
        Return objDatos.AltaModMedico(u, 0)
    End Function
    Public Function ModificacionMedico(u As E_Medico) As Integer
        Return objDatos.AltaModMedico(u, 1)
    End Function

End Class
