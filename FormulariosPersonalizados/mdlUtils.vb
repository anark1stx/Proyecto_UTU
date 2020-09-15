Imports System.Drawing
Imports System.Windows.Forms
Imports Utilidades
Imports Entidades
Imports Negocio
Public Module mdlUtils 'la finalidad de este modulo es poder agregar eventos a los controles de los formularios personalizados en tiempo de ejecuccion
    Public Class EventosDeFormulario
        Protected _acciones As AccionesFormulario
        Protected _panelDestino As Panel
        Protected _pd As Printing.PrintDocument
        Protected _memobmp As Bitmap
        Protected _formDatos As E_Formulario 'las respuestas que se hayan ingresado en el formulario
        Protected _analisisDatos As E_Analisis
        Protected _tratamientoDatos As E_Tratamiento
        Protected _modo As ModoEvento
        Sub New(acciones As AccionesFormulario)
            _acciones = acciones
        End Sub
        Sub New()

        End Sub

        Public Enum ModoEvento 'el boton guardar hace cosas diferentes segun lo q se haya seleccionado
            DatosFormulario = 0
            DatosTratamiento = 1
            DatosAnalisis = 2
        End Enum

        Property Modo As ModoEvento
            Get
                Return _modo
            End Get
            Set(value As ModoEvento)
                _modo = value
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
            Console.WriteLine("EVENTO LIMPIAR!!")
            LimpiarControles(PanelDestino)
        End Sub

        Sub Imprimir(sender As Object, e As EventArgs)
            Console.WriteLine("EVENTO IMPRIMIR!!")
            Acciones.Visible = False
            PanelDestino.AutoScroll = False
            PrintDoc.DefaultPageSettings.Landscape = True
            Memobmp = ImprimirFormulario(PanelDestino, New Rectangle(0, 0, PanelDestino.Width, PanelDestino.Height))
            AddHandler PrintDoc.PrintPage, AddressOf Imprimir_PrintPage
            PrintDoc.Print()
        End Sub

        Private Sub Imprimir_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
            e.Graphics.DrawImage(Memobmp, 0, 0, e.PageBounds.Width, e.PageBounds.Height)
        End Sub

        Sub Guardar()

            Select Case Modo
                Case 0
                    Console.WriteLine("Evento guardar Datos Formulario!!!!")
                    Dim resultado = GuardarDatosFormulario(FormDatos) '=consulta medica

                Case 1
                    Console.WriteLine("Evento guardar Datos Tratamiento!!!!")
                    Dim resultado = GuardarDatosTratamiento(TratamientoDatos)


                Case 2
                    Console.WriteLine("Evento guardar Datos Analisis!!!!")
                    Dim resultado = GuardarDatosAnalisis(AnalisisDatos)

            End Select

        End Sub
    End Class

    'ctrlFuente seria un textbox, ctrlDestino seria un listbox/combobox
    Public Sub EvAgregarItemALista(ctrlFuente As Control, ctrlDestino As Control)
        Dim item As String = ctrlFuente.Text

        Select Case ctrlDestino.GetType()
            Case GetType(ListBox)
                Dim destino = DirectCast(ctrlDestino, ListBox)
                If Not destino.Items.Contains(item) Then
                    destino.Items.Add(item)
                End If
            Case GetType(ComboBox)
                Dim destino = DirectCast(ctrlDestino, ComboBox)
                If Not destino.Items.Contains(item) Then
                    destino.Items.Add(item)
                End If
        End Select

    End Sub

    Public Sub EvEliminarItemDeLista(ctrlFuente As Control)
        Dim item As String = ctrlFuente.Text

        Select Case ctrlFuente.GetType()
            Case GetType(ListBox)
                Dim destino = DirectCast(ctrlFuente, ListBox)
                If destino.Items.Contains(item) Then
                    destino.Items.Remove(destino.SelectedItem)
                End If
            Case GetType(ComboBox)
                Dim destino = DirectCast(ctrlFuente, ComboBox)
                If destino.Items.Contains(item) Then
                    destino.Items.Remove(destino.SelectedItem)
                End If
        End Select

    End Sub

    Public Sub EvCambiarFoto(ctrlFuente As Control)

        Select Case ctrlFuente.GetType()
            Case GetType(Button)
                Dim btn = DirectCast(ctrlFuente, Button)
                btn.Image = Image.FromFile(subirImagen())
        End Select
    End Sub

    Public Sub EvPintarFondo(ctrl As Control, selected As Boolean)

        If selected Then
            ctrl.BackColor = pickRandomColor()
        Else
            ctrl.BackColor = Color.LightBlue

        End If

    End Sub

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
                        Select Case c.GetType() 'primero guardo preguntas
                            Case GetType(TextBox), GetType(ComboBox) 'sabemos q label es el unico control que guarda solo preguntas
                                If c.Tag.StartsWith("p") Then
                                    Console.WriteLine("Respuesta: " & c.Tag)
                                    ListaPreguntasYRespuestas.Find(Function(p) p.Tag = c.Tag).Respuesta = c
                                End If
                        End Select
                    End If

            End Select
        Next

    End Sub
    Function ConvertirFormulario(form As E_Formulario) As List(Of Control)
        Dim gestor As New GestorXMLv2
        Dim fbr As New FabricaDeControles
        Dim lista = gestor.Deserializar(Of ControlesGuardados.ListaControles)(form.XML)

        Return fbr.Crear(lista)
    End Function

    Async Sub BuscarIDsP(pregs As List(Of PreguntaRespuesta))
        Dim result = Await Task.Run(Function() BuscarIDS_preguntas(pregs))
        Console.WriteLine("resultado: " & result)
    End Sub

    Function BuscarIDS_preguntas(pregs As List(Of PreguntaRespuesta))
        Dim nf As New N_Formulario
        Return nf.BuscarID_preguntas(pregs)
    End Function

    Function GuardarDatosFormulario(form As E_Formulario) As Integer
        Dim negocio As New N_Formulario
        Return negocio.AltaFormularioDatos(form)
    End Function

    Function GuardarDatosTratamiento(tratamiento As E_Tratamiento) As Integer
        Dim negocio As New N_Tratamiento
        Return negocio.AltaTratamientoDatos(tratamiento)
    End Function

    Function GuardarDatosAnalisis(analisis As E_Analisis) As Integer
        Dim negocio As New N_Analisis
        Return negocio.AltaAnalisisDatos(analisis)
    End Function

End Module
