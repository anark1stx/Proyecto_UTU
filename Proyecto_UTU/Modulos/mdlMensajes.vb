Module mdlMensajes
    Function MensajeDeErrorLongitud(min As Integer, max As Integer) As String
        Return "Verifique que haya ingresado más de " & min & " caracteres" & " y menos de " & max
    End Function
    Function MensajeDeErrorsoloLetras() As String
        Return "Ingrese solo letras"
    End Function
    Function MensajeDeErrorTelefonos() As String
        Return "Entrada inválida. " & optMsg
    End Function
    Function MensajeDeErrorCedula() As String
        Return "Entrada inválida. " & optMsg
    End Function
    Function MensajeDeErrorCorreo() As String
        Return "Entrada inválida. " & optMsg
    End Function
    Function MensajeDeErrorDireccion() As String
        Return "Entrada inválida. " & optMsg
    End Function
    Function ElUsuarioYaExiste() As String
        Return "El usuario ya existe"
    End Function
    Function MensajeDeErrorUsrOContrasenaInvalida() As String
        Return "El usuario o la contraseña es incorrecto."
    End Function
    Function ElCorreoYaExiste() As String
        Return "El correo ya existe"
    End Function

    Function MensajeDeErrorEspecialidad(esp As String) As String
        Return "La especialidad: " & esp & " es muy corta"
    End Function

    Function MensajeDeErrorSoloNumeros() As String
        Return "Ingrese solo números."
    End Function

End Module