Imports Entidades
Imports Datos
Public Class N_Medico
    Dim objDatos As New D_Medico

    Public Function ListarUsuariosCI(CI As String) As E_Medico
        Return objDatos.ListarMedicosCI(CI)
    End Function
    Public Function UsuarioExiste(CI As String) As Integer
        Return objDatos.UsuarioExiste(CI)
    End Function
    Public Function AltaMedico(u As E_Medico) As Integer
        Return objDatos.AltaMedico(u)
    End Function

    Public Sub ModificacionMedico(u As E_Medico)
        objDatos.ModificarUsuarioMedico(u)
    End Sub

    Public Sub BajaLogicaMedico(u As E_Medico)
        objDatos.BajaLogicaUsuario(u)
    End Sub

    Public Sub AltaLogicaMedico(u As E_Medico)
        objDatos.AltaLogicaUsuario(u)
    End Sub
End Class
