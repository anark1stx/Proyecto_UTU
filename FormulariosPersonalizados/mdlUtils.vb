Imports System.Drawing
Imports System.Windows.Forms
Imports Utilidades
Imports Entidades
Imports Negocio
Public Module mdlUtils 'la finalidad de este modulo es poder agregar eventos a los controles de los formularios personalizados en tiempo de ejecuccion
    Public Class EventosDeTBP
        Protected _acciones As AccionesFormulario
        Protected _panelDestino As Panel
        Protected _pd As Printing.PrintDocument
        Protected _memobmp As Bitmap
        Protected _formDatos As E_Formulario 'las respuestas que se hayan ingresado en el formulario, sintomas, signos clinicos, analisis requerido, tratamiento sugerido.

        Protected _analisisDatos As E_Analisis
        Protected _tratamientoDatos As E_Tratamiento

        Protected _exitCode As Integer
        Protected _modo As ModoEvento
        Sub New(acciones As AccionesFormulario)
            _acciones = acciones
        End Sub
        Sub New()

        End Sub

        Public Enum ModoEvento 'el boton guardar hace cosas diferentes segun lo q se haya seleccionado
            DatosFormulario = 0 'ingreso datos
            DatosTratamiento = 1 'ingreso datos
            DatosAnalisis = 2 'ingreso datos
            AsignarAnalisis = 3
            AsignarTratamiento = 4
            ConsultaDatos 'solo habilito btnImprimir, limpiar y guardar quedan deshabilitados.
        End Enum

        Property Modo As ModoEvento
            Get
                Return _modo
            End Get
            Set(value As ModoEvento)
                _modo = value
                Select Case value
                    Case ModoEvento.ConsultaDatos
                        Acciones.btnGuardar.Visible = False
                        Acciones.btnLimpiar.Visible = False
                End Select
            End Set
        End Property

        Property Acciones As AccionesFormulario
            Get
                Return _acciones
            End Get
            Set(value As AccionesFormulario)
                _acciones = value
            End Set
        End Property

        Property PanelDestino As Panel
            Get
                Return _panelDestino
            End Get
            Set(value As Panel)
                _panelDestino = value
            End Set
        End Property

        Property PrintDoc As Printing.PrintDocument
            Get
                Return _pd
            End Get
            Set(value As Printing.PrintDocument)
                _pd = value
            End Set
        End Property

        Property Memobmp As Bitmap
            Get
                Return _memobmp
            End Get
            Set(value As Bitmap)
                _memobmp = value
            End Set
        End Property
        Property FormDatos As E_Formulario
            Get
                Return _formDatos
            End Get
            Set(value As E_Formulario)
                _formDatos = value
            End Set
        End Property
        Property AnalisisDatos As E_Analisis
            Get
                Return _analisisDatos
            End Get
            Set(value As E_Analisis)
                _analisisDatos = value
            End Set
        End Property
        Property TratamientoDatos As E_Tratamiento
            Get
                Return _tratamientoDatos
            End Get
            Set(value As E_Tratamiento)
                _tratamientoDatos = value
            End Set
        End Property
        Sub AgregarHandlers()
            AddHandler Acciones.btnGuardar.Click, AddressOf Guardar
            AddHandler Acciones.btnImprimir.Click, AddressOf Imprimir
            AddHandler Acciones.btnLimpiar.Click, AddressOf Limpiar
        End Sub

        Sub Limpiar()
            LimpiarControles(PanelDestino)
        End Sub

        Sub Imprimir(sender As Object, e As EventArgs)
            Acciones.Visible = False
            PanelDestino.AutoScroll = False
            PrintDoc.DefaultPageSettings.Landscape = True
            Memobmp = ImprimirFormulario(PanelDestino, New Rectangle(0, 0, PanelDestino.Width, PanelDestino.Height))
            AddHandler PrintDoc.PrintPage, AddressOf Imprimir_PrintPage
            PrintDoc.Print()
            Acciones.Visible = True
            PanelDestino.AutoScroll = True
        End Sub

        Private Sub Imprimir_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
            e.Graphics.DrawImage(Memobmp, 0, 0, e.PageBounds.Width, e.PageBounds.Height)
        End Sub

         Sub Guardar()
            Dim resultado = 0
            Select Case Modo
                Case 0

                    If FormDatos.Enfermedad.SignosClinicos.Count < 1 Then
                        If MessageBox.Show("¿Desea guardar sin ingresar un signo clínico?", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning) = vbNo Then
                            Exit Sub
                        End If
                    End If


                    If FormDatos.Enfermedad.Sintomas.Count < 1 Then
                        If MessageBox.Show("¿Desea guardar sin ingresar un síntoma?", "Falta información", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbNo Then
                            Exit Sub
                        End If
                    End If

                    If String.IsNullOrWhiteSpace(FormDatos.Enfermedad.Nombre) Then
                        If MessageBox.Show("¿Desea guardar sin ingresar una enfermedad?", "Falta información", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbNo Then
                            Exit Sub
                        End If
                    End If

                    For Each p As PreguntaRespuesta In FormDatos.PreguntasYRespuestas
                        If String.IsNullOrEmpty(p.Respuesta.Text) Then
                            If MessageBox.Show("La pregunta: " & p.Pregunta.Text & " no fue respondida, seguro que desea guardar?", "Falta ingresar información", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbNo Then
                                Exit Sub
                            End If
                        End If
                    Next

                    If FormDatos.Analisis Is Nothing Then
                        If MessageBox.Show("¿Desea guardar sin ingresar un análisis?", "Falta información", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbNo Then
                            Exit Sub
                        End If
                    End If

                    If FormDatos.Tratamiento Is Nothing Then
                        If MessageBox.Show("¿Desea guardar sin ingresar un tratamiento?", "Falta información", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbNo Then
                            Exit Sub
                        End If
                    End If

                    Dim negocio As New N_Formulario
                    resultado = negocio.AltaFormularioDatos(FormDatos)
                    Console.WriteLine("ID DE LA CONSULTA: " & FormDatos.Atiende.ID)
                Case 1
                    'Console.WriteLine("Evento guardar Datos Tratamiento!!!!") 'por ahora solamente el tratamiento que se le asigno a un paciente, queda pendiente el seguimiento diario.
                    'Dim negocio As New N_Tratamiento
                    'resultado = negocio.AltaSeguimientoDiario(TratamientoDatos, TratamientoDatos.ListaSeguimientos(0),)
                Case 2
                    Console.WriteLine("Evento guardar Datos Analisis!!!!")
                    Dim Negocio As New N_Analisis
                    resultado = Negocio.AltaAnalisisResultados(AnalisisDatos)
            End Select
            Select Case resultado
                Case -1
                    MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 2
                    MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando accion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 1
                    MessageBox.Show("Se guardaron todos los datos correctamente.", "Alta de la consulta exitosa.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Acciones.btnGuardar.Enabled = False 'deshabilito el button para que no vuelva a guardar lo mismo
            End Select
        End Sub
    End Class

    Public Function ColorTOHTML(col As Color) As String 'XMLSerializer no puede guardar System.Drawing.Color

        Return ColorTranslator.ToHtml(col)

    End Function

    Public Function HTMLTOColor(col As String) As Color
        Return ColorTranslator.FromHtml(col)
    End Function

    Public Sub BuscarPreguntas(contenedor As Control, ListaPreguntasYRespuestas As List(Of PreguntaRespuesta))

        For Each c As Control In contenedor.Controls
            Select Case c.GetType
                Case GetType(Panel), GetType(GroupBox), GetType(TableLayoutPanel)
                    BuscarPreguntas(c, ListaPreguntasYRespuestas)
                Case Else
                    If Not String.IsNullOrEmpty(c.Tag) Then
                        Select Case c.GetType() 'primero guardo preguntas
                            Case GetType(Label) 'sabemos q label es el unico control que guarda solo preguntas
                                If c.Tag.StartsWith("p") Then
                                    Console.WriteLine("Pregunta: " & c.Tag)
                                    ListaPreguntasYRespuestas.Add(New PreguntaRespuesta(c.Tag, c))
                                End If
                            Case GetType(CheckBox) 'checkbox guarda pregunta y respuesta en el mismo.
                                If c.Tag.StartsWith("p") Then
                                    Console.WriteLine("PreguntaYrespuesta: " & c.Tag)
                                    ListaPreguntasYRespuestas.Add(New PreguntaRespuesta(c.Tag, c, c))
                                End If
                        End Select
                    End If

            End Select
        Next

    End Sub
    Public Sub UnirPreguntasConRespuestas(contenedor As Control, ListaPreguntasYRespuestas As List(Of PreguntaRespuesta))

        For Each c As Control In contenedor.Controls
            Select Case c.GetType
                Case GetType(Panel), GetType(GroupBox), GetType(TableLayoutPanel)
                    UnirPreguntasConRespuestas(c, ListaPreguntasYRespuestas)
                Case Else
                    If Not String.IsNullOrEmpty(c.Tag) Then
                        Select Case c.GetType()
                            Case GetType(TextBox), GetType(ComboBox)
                                If c.Tag.StartsWith("p") Then
                                    Console.WriteLine("Respuesta: " & c.Tag)
                                    ListaPreguntasYRespuestas.Find(Function(p) p.Tag = c.Tag).Respuesta = c
                                End If
                            Case GetType(ListBox)
                                If c.Tag.StartsWith("p") Then
                                    Console.WriteLine("Respuesta: " & c.Tag)
                                    ListaPreguntasYRespuestas.Find(Function(p) p.Tag = c.Tag).Respuesta = c
                                End If

                        End Select
                    End If

            End Select
        Next

    End Sub

    Public Sub PoblarRespuestas(pyr As List(Of PreguntaRespuesta), control_list As List(Of Control))
        For Each c As Control In control_list
            If Not String.IsNullOrWhiteSpace(c.Tag) AndAlso c.GetType() <> GetType(Label) Then 'es una respuesta
                Dim textR As String = pyr.Find(Function(p) p.Respuesta.Name = c.Name).Respuesta.Text
                Console.WriteLine("respuesta desde poblar = " & textR)
                Select Case c.GetType()
                    Case GetType(CheckBox)
                        Select Case textR
                            Case "True"
                                DirectCast(c, CheckBox).Checked = True
                            Case Else
                                DirectCast(c, CheckBox).Checked = False
                        End Select
                    Case GetType(ListBox)
                        DirectCast(c, ListBox).Items.AddRange(textR.Split(","))
                    Case Else
                        c.Text = textR
                End Select
            End If
        Next
    End Sub

    Function ConvertirFormulario(form As E_Formulario) As List(Of Control)
        Dim gestor As New GestorXMLv2
        Dim fbr As New FabricaDeControles
        Dim lista = gestor.Deserializar(Of ControlesGuardados.ListaControles)(form.XML)

        Return fbr.Crear(lista)
    End Function

    Async Sub BuscarIDsP(pregs As List(Of PreguntaRespuesta))
        Dim nf As New N_Formulario
        Dim result = Await Task.Run(Function() nf.BuscarID_preguntas(pregs))
        Select Case result
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando procedimiento", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 1
                MessageBox.Show("Formulario guardado con éxito.", "Alta/Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub

    Public Sub GuardarFormulario(FormDisenado As E_Formulario, lista_controles As ControlesGuardados.ListaControles, pnlDestino As Panel)
        Dim Negocio As New N_Formulario
        Dim gestor As New GestorXMLv2
        Dim resultado As Integer = 0
        FormDisenado.XML = gestor.Serializar(lista_controles)
        Dim capturaDePantalla = ImprimirFormulario(pnlDestino, New Rectangle(0, 0, 720, 480))
        FormDisenado.VistaPrevia = Image2Bytes(capturaDePantalla)
        BuscarPreguntas(pnlDestino, FormDisenado.PreguntasYRespuestas)
        UnirPreguntasConRespuestas(pnlDestino, FormDisenado.PreguntasYRespuestas)

        If FormDisenado.ID = 0 Then 'si es 0 es porque no lo estamos editando, es un form nuevo
            resultado = Negocio.AltaModFormulario(FormDisenado, 0)
        Else
            resultado = Negocio.AltaModFormulario(FormDisenado, 1) 'hacer alta y baja con las preguntas aca!
        End If
        Select Case resultado
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando procedimiento", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 1
                MessageBox.Show("Formulario guardado con éxito.", "Alta/Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select

    End Sub
    Sub BajaFormulario(FormDisenado As E_Formulario)
        Dim nf As New N_Formulario
        Dim resultado = nf.BajaFormulario(FormDisenado)
        Select Case resultado
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando procedimiento", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 1
                MessageBox.Show("Formulario dado de baja con éxito.", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
End Module
