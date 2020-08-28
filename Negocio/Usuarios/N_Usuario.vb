Imports Entidades
Imports Datos
Public Class N_Usuario

    Dim objDatos As New D_Usuario

    Public Overridable Function ListarUsuariosCI(CI As String)
        Return objDatos.ListarUsuariosCI(CI)
    End Function

    Public Overridable Sub AltaUsuario(u As E_Usuario)
        objDatos.AltaUsuario(u)
    End Sub

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
