Public Module mdlMensajes
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

    Function MensajeDeErrorConexion() As String
        Return "Hay problemas con la conexión, vuelva a intentar o contáctese con administración."
    End Function

    Function MensajeDeErrorRolDesconocido() As String
        Return "Usted no tiene asignado un rol para SIBIM, ingrese con un usuario registrado en el sistema."
    End Function

    Function MensajeDeErrorPermisoProcedimiento() As String
        Return "Su rol no cuenta con permisos de ejecucción para ese procedimiento."
    End Function

    Function MensajeDeErrorUsuarioMYSQL() As String
        Return "No se pudo crear el usuario de mysql."
    End Function

    Function MensajeDeErrorIngresoTelefonos() As String
        Return "No se pudieron ingresar los telefonos."
    End Function

    Function MensajeDeErrorUsuarioBase() As String
        Return "No se pudo crear el usuario base."
    End Function

    Function MensajeDeErrorCredsInvalidas() As String
        Return "Su usuario o contraseña son incorrectos. Si olvidó su contraseña presione el botón ""Olvidé mi contraseña."" "
    End Function

End Module