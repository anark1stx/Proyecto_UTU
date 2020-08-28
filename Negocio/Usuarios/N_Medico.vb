Imports Entidades
Imports Datos
Public Class N_Medico
    Dim objDatos As New D_Medico

    Public Function ListarUsuariosCI(CI As String)
        Return objDatos.ListarMedicosCI(CI)
    End Function
    Public Function UsuarioExiste(CI As String)
        Return objDatos.UsuarioExiste(CI)
    End Function
    Public Sub AltaMedico(u As E_Medico)
        objDatos.AltaMedico(u)
    End Sub

    Public Sub AltaMedicoTelefonos(u As E_Medico)
        objDatos.AltaMedicoTelefono(u)
    End Sub

    Public Sub AltaMedicoEspecialidades(u As E_Medico)
        objDatos.AltaMedicoEspecialidad(u)
    End Sub

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
