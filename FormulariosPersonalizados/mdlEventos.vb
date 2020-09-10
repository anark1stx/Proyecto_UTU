Imports System.Drawing
Imports System.Windows.Forms
Imports Utilidades
Imports Entidades
Public Module mdlEventos 'la finalidad de este modulo es poder agregar eventos a los controles de los formularios personalizados en tiempo de ejecuccion

    Public Class EventosDeFormulario
        Protected _acciones As AccionesFormulario
        Protected _panelDestino As Panel
        Protected _pd As Printing.PrintDocument
        Protected _memobmp As Bitmap
        Protected _formDatos As E_Formulario

        Sub New(acciones As AccionesFormulario)
            _acciones = acciones
        End Sub
        Sub New()

        End Sub
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
        Property formDatos As E_Formulario
            Get
                Return _formDatos
            End Get
            Set(value As E_Formulario)
                _formDatos = value
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
            e.Graphics.DrawImage(memobmp, 0, 0, e.PageBounds.Width, e.PageBounds.Height)
        End Sub

        Sub Guardar()
            Console.WriteLine("Evento guardar!!!!")
            GuardarDatosFormulario(formDatos)
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

End Module
