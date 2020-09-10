Imports System.Text.RegularExpressions

Public Module mdlChecker
    Public optMsg As String = ""
    Public RegexLiteralAcentos = New Regex("^[A-zÁ-ú]*$")
    Public RegexLiteral = New Regex("^[A-Za-z]*$")
    Public RegexAlfaNumericoEspaciosPuntosComasTildes = New Regex("^[a-z-ZA-Z0-9Á-ú., ]*$")
    Public RegexAlfaNumerico = New Regex("^[A-Za-z0-9]*$")

    Function check_Largo(propiedad As String, cantidadMinima As Integer, cantidadMaxima As Integer, requerido As Boolean) As Boolean

        If requerido AndAlso String.IsNullOrWhiteSpace(propiedad) Then
            Return 0
        End If

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

    Public Function check_regex(propiedad As String, regex As Regex) As Boolean

        If regex.IsMatch(propiedad) Then
            Console.WriteLine("matches")
            Return 1
        Else
            Console.WriteLine("no match")
            optMsg = "Caracteres inválidos."
            Return 0
        End If

    End Function

    Public Function check_Sexo(sexo As String) As Boolean
        If sexo.Equals("Masculino") Or sexo.Equals("Femenino") Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Function check_Estado_Civil(estado As String) As Boolean
        If estado.Equals("Soltero") Or estado.Equals("Casado") Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Function check_Correo(correo As String) As Boolean

        If Not check_Largo(correo, 15, 50, True) Or Not correo.Contains("@") Then
            optMsg = "Verifique que cumpla con el siguiente formato: usuario@dominio.com, recuerde que el mínimo de caracteres que tiene un usuario de correo son 6."
            Return 0
        End If

        Dim lista_dominios As New List(Of String)(New String() {"gmail.com", "outlook.com", "yahoo.com", "zohomail.com", "tutanota.com", "yandex.com"}) '-> Guardar esto en la BD para que el administrador pueda modificarlo luego, por si quiere agregar o sacar dominios

        Dim correo_antes_arroba As String = correo.Substring(0, correo.IndexOf("@"))

        If Not check_regex(correo_antes_arroba, RegexAlfaNumerico) Then
            optMsg = "Hay Caracteres inválidos en su correo."
            Return 0
        End If

        Dim index_arroba, index_ultimo_char As Integer

        index_arroba = correo.IndexOf("@") + 1
        index_ultimo_char = correo.LastIndexOf("m") - index_arroba + 1

        Dim correo_despues_arroba As String = correo.Substring(index_arroba, index_ultimo_char)

        If Not lista_dominios.Contains(correo_despues_arroba) Then
            optMsg = "Verifique que el domino sea válido."
            Return 0
        End If

        Return 1
    End Function
    Public Function check_Telefonos(telefonos As List(Of String)) As Boolean

        If telefonos.Count = 1 Then
            If String.IsNullOrWhiteSpace(telefonos(0)) Then
                optMsg = "Ingrese un número telefónico de contacto"
                Return 0
            End If

        End If

        For Each tel In telefonos

            If Not IsNumeric(tel) Then
                optMsg = "El teléfono " & tel & " es inválido. Ingrese solo números"
                Return 0
            End If

        Next tel

        For Each tel In telefonos
            If Not check_Largo(tel, 8, 9, True) <> 0 Then
                optMsg = "El teléfono: " & tel & " es inválido. Los teléfonos celulares tienen 9 digitos, los teléfonos fijos 8."
                Return 0
            Else

                If tel.Length = 9 Then 'Longitud acorde a telefono celular
                    If Not tel.Substring(0, 2).Equals("09") Then 'Formato de los telefonos celulares 09*******
                        optMsg = "El teléfono: " & tel & " es inválido. Los telefonos celulares empiezan con '09'."
                        Return 0

                    End If
                ElseIf tel.Length = 8 Then 'Longitud acorde a telefono fijo
                    Dim primerdigito = Val(tel(0))

                    Select Case primerdigito
                        Case 2, 4
                            Return 1
                        Case Else
                            optMsg = "El teléfono: " & tel & " es inválido. Los teléfonos fijos empiezan con '2' o '4'."
                            Return 0
                    End Select

                End If
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
            optMsg = "Verifique la longitud de la cédula (8 dígitos)"
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
            resultado_cedula &= producto.ToString()
        Next i

        Dim suma As Integer = 0

        For j = 0 To nums_algoritmo.Length - 1
            suma += Val(resultado_cedula(j))
        Next

        Dim digito_verificador As Integer = 10 - (suma Mod 10)

        If Not digito_verificador = verificador_ingresado_x_usuario Then
            optMsg = "Su cédula es incorrecta, verifique que haya ingresado los 8 números que se muestran en el documento"
            Return 0
        End If

        Return 1

    End Function

    Public Function check_direccion(direccion As List(Of String)) As Boolean

        If direccion.Count <> 2 Then 'Si no hay de dos items pafuera
            Return 0
        Else
            If Not check_regex(direccion(1), RegexAlfaNumericoEspaciosPuntosComasTildes) Then
                optMsg = "Caractéres inválidos"
                Return 0
            End If

            If Not check_Largo(direccion(1), 2, 4, True) Then 'En Montevideo los numeros de puerta van desde 2 digitos hasta 4.
                optMsg = MensajeDeErrorLongitud(3, 160)
                Return 0
            End If
            If Not IsNumeric(direccion(1)) Then
                optMsg = "Número de puerta no válido."
                Return 0
            End If

            Return 1

        End If

    End Function


End Module