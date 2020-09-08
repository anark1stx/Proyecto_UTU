Imports Entidades
Imports Datos
Public Class N_Usuario

    Dim objDatos As New D_Usuario

    Public Overridable Function ListarUsuariosCI(CI As String) As E_Usuario
        Return objDatos.BuscarUsuariosCI(CI)
    End Function

    Public Overridable Function BuscarUsuariosApellido(ap As String) As List(Of E_Usuario)
        Return objDatos.BuscarUsuariosApellido(ap)
    End Function

    Public Overridable Function UsuarioExiste(CI As Integer) As Integer
        Return objDatos.UsuarioExiste(CI)
    End Function

    Public Function AltaUsuario(u As E_Usuario) As Integer 'usuario de mysql
        Return objDatos.AltaUsuario(u)
    End Function

    Public Function AltaUsuarioSIBIM(u As E_Usuario) As Integer
        Return objDatos.AltaUsuarioSIBIM(u)
    End Function

    Public Overridable Function ModificacionUsuario(u As E_Usuario) As Integer
        Return objDatos.ModificarUsuario(u)
    End Function

    Public Overridable Function BajaLogicaUsuario(u As E_Usuario) As Integer
        Return objDatos.BajaLogicaUsuario(u.Cedula)
    End Function

    Public Overridable Function AltaLogicaUsuario(u As E_Usuario) As Integer
        Return objDatos.AltaLogicaUsuario(u.Cedula)
    End Function

End Class
