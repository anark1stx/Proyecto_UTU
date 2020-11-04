Imports Datos
Imports Entidades
Public Class N_Usuario
    Inherits N_UsuarioMYSQL
    Dim objDatos As New D_Usuario
    Public Function BajaLogicaUsuario(u As E_Usuario) As Integer
        Return objDatos.A_BLogicaUsuario(u.Cedula, 0)
    End Function
    Public Function AltaLogicaUsuario(u As E_Usuario) As Integer
        Return objDatos.A_BLogicaUsuario(u.Cedula, 1)
    End Function
    Public Function LeerFoto(CI As Integer) As Byte()
        Return objDatos.LeerFotoUsuario(CI)
    End Function
    Public Function UsuarioExiste(CI As Integer) As Integer
        Return objDatos.UsuarioExiste(CI)
    End Function
End Class
