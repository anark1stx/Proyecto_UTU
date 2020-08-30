Imports Entidades
Imports Datos
Public Class N_Usuario

    Dim objDatos As New D_Usuario

    Public Function ListarUsuariosCI(CI As String) As E_Usuario
        Return objDatos.BuscarUsuariosCI(CI)
    End Function

    Public Function UsuarioExiste(CI As String) As Integer
        Return objDatos.UsuarioExiste(CI)
    End Function

    Public Function AltaUsuario(u As E_Usuario) As Integer
        Return objDatos.AltaUsuario(u)
    End Function

    Public Overridable Sub ModificacionUsuario(u As E_Usuario)
        objDatos.ModificarUsuario(u)
    End Sub

    Public Overridable Sub BajaLogicaUsuario(u As E_Usuario)
        objDatos.BajaLogicaUsuario(u)
    End Sub

    Public Overridable Sub AltaLogicaUsuario(u As E_Usuario)
        objDatos.AltaLogicaUsuario(u)
    End Sub

End Class
