Imports Entidades
Imports Datos
Public Class N_Usuario
    Inherits N_UsuarioMYSQL

    Dim objDatos As New D_Usuario

    Public Function BuscarAuxiliarCI(CI As String) As E_Usuario
        Return objDatos.BuscarAuxiliarCI(CI)
    End Function

    Public Function BuscarAuxiliaresApellido(ap As String) As List(Of E_Usuario)
        Return objDatos.BuscarAuxiliarApellido(ap)
    End Function

    Public Function UsuarioExiste(CI As Integer) As Integer
        Return objDatos.UsuarioExiste(CI)
    End Function

    Public Function AltaAuxiliar(u As E_Usuario) As Integer
        Return objDatos.AltaAuxiliar(u)
    End Function

    Public Function ModificacionAuxiliar(u As E_Usuario) As Integer
        Return objDatos.ModificarUsuario(u)
    End Function

    Public Function BajaLogicaUsuario(u As E_Usuario) As Integer
        Return objDatos.BajaLogicaUsuario(u.Cedula)
    End Function

    Public Function AltaLogicaUsuario(u As E_Usuario) As Integer
        Return objDatos.AltaLogicaUsuario(u.Cedula)
    End Function

    Public Function LeerFoto(CI As Integer) As Byte()
        Return objDatos.LeerFotoUsuario(CI)
    End Function

End Class
