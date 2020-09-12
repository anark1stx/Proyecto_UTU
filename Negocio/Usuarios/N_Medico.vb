Imports Entidades
Imports Datos
Public Class N_Medico
    Inherits N_Usuario
    Dim objDatos As New D_Medico

    Public Function ListarMedicoCI(CI As String) As E_Medico
        Return objDatos.ListarMedicosCI(CI)
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

    Public Function AltaEntrevistaInicial(auxCI As Integer, medCI As Integer, pacCI As Integer, motivo As String) As Integer
        Return objDatos.AltaEntrevistaInicial(auxCI, medCI, pacCI, motivo)
    End Function

End Class
