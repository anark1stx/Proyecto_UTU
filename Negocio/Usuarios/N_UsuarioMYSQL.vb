Imports Entidades
Imports Datos
Public Class N_UsuarioMYSQL
    Dim objDatos As New D_UsuarioMYSQL

    Public Function SeleccionarUsuario(CI As String, contrasena As String) As E_UsuarioMYSQL
        Return objDatos.SeleccionarUsuario(CI, contrasena)
    End Function

    Public Overridable Sub AltaUsuario(u As E_UsuarioMYSQL)
        objDatos.AltaUsuario(u)
    End Sub
End Class
