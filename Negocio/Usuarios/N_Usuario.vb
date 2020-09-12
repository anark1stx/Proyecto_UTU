Imports Entidades
Imports Datos
Public Class N_Usuario

    Dim objDatos As New D_Usuario

    Public Function ListarUsuariosCI(CI As String) As E_Usuario
        Return objDatos.BuscarAuxiliarCI(CI)
    End Function

    Public Function BuscarUsuariosApellido(ap As String) As List(Of E_Usuario)
        Return objDatos.BuscarAuxiliarApellido(ap)
    End Function

    Public Function UsuarioExiste(CI As Integer) As Integer
        Return objDatos.UsuarioExiste(CI)
    End Function

    Public Function AltaUsuario(u As E_Usuario) As Integer 'usuario de mysql
        Return objDatos.AltaUsuario(u)
    End Function

    Public Function AltaUsuarioSIBIM(u As E_Usuario) As Integer
        Return objDatos.AltaAuxiliar(u)
    End Function

    Public Function ModificacionUsuario(u As E_Usuario) As Integer
        Return objDatos.ModificarUsuario(u)
    End Function

    Public Function BajaLogicaUsuario(u As E_Usuario) As Integer
        Return objDatos.BajaLogicaUsuario(u.Cedula)
    End Function

    Public Function AltaLogicaUsuario(u As E_Usuario) As Integer
        Return objDatos.AltaLogicaUsuario(u.Cedula)
    End Function

    Public Function LeerFoto(CI As Integer) As Byte()
        Return objDatos.leerFotoUsuario(CI)
    End Function

End Class
