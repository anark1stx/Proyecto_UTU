Imports System.Drawing
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Module mdlUtilidades
    Dim lista_dominios As New List(Of String)(New String() {"gmail.com", "outlook.com", "yahoo.com", "zohomail.com", "tutanota.com", "yandex.com"})
    Public optMsg As String = ""
    Public RegexLiteralAcentos = New Regex("^[A-zÁ-ú]*$")
    Public RegexLiteral = New Regex("^[A-Za-z]*$")
    Public RegexAlfaNumericoEspaciosPuntosComasTildes = New Regex("^[a-z-ZA-Z0-9Á-ú., ]*$")
    Public RegexAlfaNumerico = New Regex("^[A-Za-z0-9]*$")
    Public RegexAlfaNumericoPuntos = New Regex("^[A-Za-z0-9+.]*$")
    Sub setLabelText(lbl As Label, msg As String)
        lbl.Text = msg
        lbl.Visible = True
    End Sub
    Sub hidelbl(lbl As Label) 'Este método esconde los mensajes de error.
        lbl.Visible = False
    End Sub
    Sub cambiarElementosCBox(cbox As ComboBox, listaElementos As List(Of String))
        cbox.Items.Clear() 'Limpiamos todos los elementos que estaban
        For i As Integer = 0 To listaElementos.Count - 1
            cbox.Items.Add(listaElementos(i)) 'Añadir el elemento al combobox
        Next
    End Sub
    Function subirImagen() As String

        Dim OFD As FileDialog = New OpenFileDialog With {
                .Filter = "Imagen (*.jpg;*.png)|*.jpg;*.png",
                .Title = "Elegir imagen",
                .RestoreDirectory = True,
                .Multiselect = False
        }

        If OFD.ShowDialog() = DialogResult.OK Then
            Return OFD.FileName
        Else
            Return Nothing
        End If

    End Function

    Public Function RemoverEspacios(str As String) As String
        Return str.Trim()
    End Function

    Public Sub LimpiarControles(contenedor As Control)
        For Each control As Control In contenedor.Controls

            If Not control.Tag Is "noLimpiar" Then
                Select Case control.GetType().ToString().Replace("System.Windows.Forms.", "")

                    Case "TextBox"
                        Dim txt = DirectCast(control, TextBox)
                        txt.Text = String.Empty
                        txt.DataBindings.Clear()
                    Case "MaskedTextBox"
                        Dim txt = DirectCast(control, MaskedTextBox)
                        txt.Text = String.Empty
                        txt.DataBindings.Clear()
                    Case "ComboBox"
                        Dim cbox = DirectCast(control, ComboBox)

                        If cbox.Tag Is "datos" Then
                            cbox.DataSource = Nothing
                            If cbox.DropDownStyle = ComboBoxStyle.DropDown Then
                                cbox.ResetText()
                                cbox.Items.Clear()
                            End If
                            cbox.SelectedItem = Nothing
                        End If

                    Case "DataGridView"
                        Dim dgw = DirectCast(control, DataGridView)
                        dgw.DataSource = Nothing
                        dgw.Rows.Clear()
                        dgw.Refresh()
                    Case "CheckBox"
                        Dim chk = DirectCast(control, CheckBox)
                        chk.Checked = False

                    Case "PictureBox"
                        Dim pbox = DirectCast(control, PictureBox)
                        pbox.DataBindings.Clear()
                        pbox.Image = Nothing
                        pbox.ImageLocation = Nothing

                    Case "DateTimePicker"
                        Dim dtp = DirectCast(control, DateTimePicker)
                        dtp.Value = Today
                        dtp.DataBindings.Clear()
                    Case "ListBox"
                        Dim lb = DirectCast(control, ListBox)
                        lb.Items.Clear()

                    Case "Label"
                        Dim lbl = DirectCast(control, Label)

                        If lbl.Tag Is "datos" Then 'Esto es para limpiar solo las labels en las que le cambio su texto original por los datos que llegan de la BD.
                            lbl.ResetText()
                            lbl.DataBindings.Clear()
                        End If
                    Case "Button"
                        Dim btn = DirectCast(control, Button)

                        If btn.Tag Is "datos" Then
                            btn.BackColor = Nothing
                        End If

                    Case "Panel", "GroupBox", "TableLayoutPanel"
                        LimpiarControles(control) 'RECURSIVA
                End Select
            End If
        Next
    End Sub

    Public Function ImprimirFormulario(contenedor As Control, rect As Rectangle) As Bitmap

        Dim memobmp = New Bitmap(contenedor.Width, contenedor.Height)

        contenedor.DrawToBitmap(memobmp, New Rectangle(0, 0, contenedor.Width, contenedor.Height))
        Dim resized = New Bitmap(memobmp, New Size(rect.Width, rect.Height))

        Return resized
    End Function

    Public Sub pintarFondo(ctrl As Control, selected As Boolean)

        If selected Then
            ctrl.BackColor = pickRandomColor()
        Else
            ctrl.BackColor = Color.LightBlue
        End If

    End Sub

    Public Function pickRandomColor() As Color
        Dim m_Rnd As New Random
        Return Color.FromArgb(m_Rnd.Next(78, 201), m_Rnd.Next(78, 201), m_Rnd.Next(78, 201))
    End Function

    Public Sub AgregarItemALista(item As String, lista As ListBox, Optional btn As Button = Nothing) 'btn es porque en el frmDolor (unico formulario el cual usa esta funcion por ahora), pinta el fondo de los botones cuando estos son seleccionados.

        If Not lista.Items.Contains(item) Then
            lista.Items.Add(item)
            If btn IsNot Nothing Then
                pintarFondo(btn, True)
            End If

        Else
            lista.Items.Remove(item)

            If btn IsNot Nothing Then
                pintarFondo(btn, False)
            End If

        End If

    End Sub

    Public Function getCtrls(pnl As Control) As List(Of Control)

        Dim list As New List(Of Control)

        For Each c As Control In pnl.Controls
            list.Add(c)
            If TypeOf c Is Panel Or TypeOf c Is TableLayoutPanel Or TypeOf c Is GroupBox Then
                getCtrls(c)
            End If
        Next
        Return list
    End Function
    Public Function Bytes2Image(ByVal bytes() As Byte) As Image
        If bytes Is Nothing Then
            Return Nothing
        Else
            Dim ms As New MemoryStream(bytes)
            Return Image.FromStream(ms)
        End If

    End Function

    Public Function Image2Bytes(ByVal img As Image) As Byte()
        If img Is Nothing Then
            Return {}
        End If
        Dim ms = New MemoryStream()
        img.Save(ms, Imaging.ImageFormat.Jpeg)
        Dim bytes = ms.ToArray()
        ms.Close()
        Return bytes

    End Function
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

    Function MensajeDeErrorCaracteres() As String
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
        If String.IsNullOrEmpty(propiedad) Then
            Return 0
        End If

        If regex.IsMatch(propiedad) Then
            Return 1
        Else
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

        Dim correo_antes_arroba As String = correo.Substring(0, correo.IndexOf("@"))

        If Not check_regex(correo_antes_arroba, RegexAlfaNumericoPuntos) Then
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

        If Not IsNumeric(cedula) Then
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

        If direccion.Count <> 2 Then
            Return 0
        Else
            If Not check_regex(direccion(0), RegexAlfaNumericoEspaciosPuntosComasTildes) Then
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