Module mdlChecker
    Public optMsg As String = ""
    Public Function check_contieneNumeros(propiedad As String) As Boolean

        For i = 0 To propiedad.Length - 1
            If IsNumeric(propiedad(i)) Then
                Return 1
            End If
        Next i

        Return 0

    End Function
    Function check_Largo(propiedad As String, cantidadMinima As Integer, cantidadMaxima As Integer, requerido As Boolean) As Boolean

        If propiedad.Length >= cantidadMinima AndAlso propiedad.Length <= cantidadMaxima Then
            Return 1
        Else
            If requerido = True Then
                Return 0
            Else
                If propiedad.Length > 0 Then 'Esto va por el segundo nombre y el segundo apellido, no son requeridos, pero si el usuario ingresa una longitud invalida, ej 2 caracteres tenemos que pedirle que lo corrija.
                    Return 0
                Else 'En caso de que hayan 0 caracteres y la propiedad no sea requerida, no pasa nada.
                    Return 1
                End If
            End If
        End If

    End Function
    Public Function check_Correo(correo As String) As Boolean

        If Not check_Largo(correo, 15, 45, True) Or Not correo.Contains("@") Then
            optMsg = "Verifique que cumpla con el siguiente formato: usuario@dominio.com, recuerde que el mínimo de caracteres que tiene un usuario de correo son 6."
            Return 0
        End If

        Dim lista_dominios As New List(Of String)(New String() {"gmail.com", "outlook.com", "yahoo.com", "zohomail.com", "tutanota.com", "yandex.com"})

        Dim correo_antes_arroba As String = correo.Substring(0, correo.IndexOf("@"))

        Dim index_arroba, index_ultimo_char As Integer

        index_arroba = correo.IndexOf("@") + 1
        index_ultimo_char = correo.LastIndexOf("m") - index_arroba + 1

        Dim correo_despues_arroba As String = correo.Substring(index_arroba, index_ultimo_char)

        If Not lista_dominios.Contains(correo_despues_arroba) Then
            optMsg = "Verifique que cumpla con el siguiente formato: usuario@dominio.com"
            Return 0
        Else
            Return 1
        End If

    End Function
    Public Function check_Telefonos(telefonos As List(Of String)) As Boolean

        'If telefonos.Count = 1 Then
        '    If telefonos(0) = "" Then
        '        optMsg = "Por favor Ingrese un número telefónico"
        '        Return 0
        '    End If

        'End If

        For Each tel In telefonos

            If Not IsNumeric(tel) Then
                optMsg = "El teléfono " & tel & " es inválido. Ingrese solo números"
                Return 0
            End If

        Next tel

        For Each tel In telefonos
            If Not check_Largo(tel, 8, 9, True) <> 0 Then
                optMsg = "El teléfono: " & tel & "es inválido. Ingrese entre 8 y 9 caracteres"
                Return 0
            End If
        Next tel

        Return 1

    End Function
    Public Function check_Cedula(cedula As String) As Boolean

        If IsNumeric(cedula) = 0 Then
            optMsg = "Verifique la cedula, ingrese solo numeros."
            Return 0
        End If

        If Not check_Largo(cedula, 8, 8, True) Then
            optMsg = "Verifique la longitud de la cédula (8 caracteres)"
            Return 0
        End If

        Const nums_algoritmo = "2987634"

        Dim cedula_7digs As String = cedula.Substring(0, 7)
        Dim verificador_ingresado_x_usuario As Integer = (cedula.Substring(7))
        Dim resultado_cedula As String = ""

        For i = 0 To nums_algoritmo.Length - 1
            Dim producto As Integer = Val(cedula_7digs(i)) * Val(nums_algoritmo(i))

            If producto.ToString().Length > 1 Then
                Dim producto_corregido = producto.ToString().Substring(1)
                producto = CInt(producto_corregido)
            End If
            resultado_cedula = resultado_cedula & producto.ToString()
        Next i

        Dim suma As Integer = 0

        For j = 0 To nums_algoritmo.Length - 1
            suma += Val(resultado_cedula(j))
        Next

        Dim digito_verificador As Integer = 10 - (suma Mod 10)
        If Not digito_verificador = verificador_ingresado_x_usuario Then
            optMsg = "Su cédula es incorrecta, verifique que haya ingresado los 8 números que se muestran en el documento"
            Return 0
        Else
            Return 1
        End If

    End Function
    Public Function check_caracteres(propiedad As String) As Boolean

        Const caracteres = "~^;:><?¿[]()/&%@$#!¡|°¬=,.+ `´{}-_*'"

        For i = 0 To caracteres.Length - 1

            If propiedad.Contains(caracteres(i)) Then
                Return 1
            End If

        Next

        Return 0

    End Function
    Public Function check_UsuarioExiste(usuario As String) As Boolean
        'Si el usuario existe, retornamos 1, si no existe, retornamos 0
        Return 0
    End Function
    Public Function check_ContrasenaOk(contrasena As String) As Boolean
        'Si la contrasena está bien, retornamos 1, si esta mal, retornamos 0
        Return 0
    End Function
    Public Function check_CorreoExiste(correo As String) As Boolean
        'Si el correo existe, retornamos 1, si no existe, retornamos 0
        Return 0
    End Function

    Public Function check_Usuario_Medico_Ingreso() As Boolean

    End Function



End Module