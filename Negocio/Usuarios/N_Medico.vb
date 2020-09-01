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

    Public Sub ModificacionMedico(u As E_Medico)
        objDatos.ModificarUsuarioMedico(u)
    End Sub
End Class
