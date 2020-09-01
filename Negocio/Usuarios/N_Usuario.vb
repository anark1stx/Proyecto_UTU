Imports Entidades
Imports Datos
Public Class N_Usuario

    Dim objDatos As New D_Usuario

    Public Overridable Function ListarUsuariosCI(CI As String, auxiliar As Boolean) As E_Usuario
        Return objDatos.BuscarUsuariosCI(CI, auxiliar)
    End Function

    Public Overridable Function BuscarUsuariosApellido(ap As String, auxiliar As Boolean) As List(Of E_Usuario)
        Return objDatos.BuscarUsuariosApellido(ap, auxiliar)
    End Function

    Public Overridable Function UsuarioExiste(CI As String) As Integer
        Return objDatos.UsuarioExiste(CI)
    End Function

    Public Function AltaUsuario(u As E_Usuario) As Integer 'usuario de mysql
        Return objDatos.AltaUsuario(u)
    End Function

    Public Function AltaUsuarioSIBIM(u As E_Usuario) As Integer
        Return objDatos.AltaUsuarioSIBIM(u)
    End Function

    Public Overridable Sub ModificacionUsuario(u As E_Usuario)
        objDatos.ModificarUsuario(u)
    End Sub

    Public Overridable Function BajaLogicaUsuario(u As E_Usuario) As Integer
        Return objDatos.BajaLogicaUsuario(u)
    End Function

    Public Overridable Function AltaLogicaUsuario(u As E_Usuario) As Integer
        Return objDatos.AltaLogicaUsuario(u)
    End Function

End Class
