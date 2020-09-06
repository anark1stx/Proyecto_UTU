Imports System.Drawing
Imports System.Windows.Forms
Imports Utilidades
Module mdlEventos 'la finalidad de este modulo es poder agregar eventos a los controles de los formularios personalizados en tiempo de ejecuccion

    'ctrlFuente seria un textbox, ctrlDestino seria un listbox/combobox
    Public Sub AgregarItemALista(ctrlFuente As Control, ctrlDestino As Control)
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

    Public Sub EliminarItemDeLista(ctrlFuente As Control)
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

    Public Sub CambiarFoto(ctrlFuente As Control)

        Select Case ctrlFuente.GetType()
            Case GetType(Button)
                Dim btn = DirectCast(ctrlFuente, Button)
                btn.Image = Image.FromFile(subirImagen())
        End Select
    End Sub

    Public Sub PintarFondo(ctrl As Control, selected As Boolean)

        If selected Then
            ctrl.BackColor = pickRandomColor()
        Else
            ctrl.BackColor = Color.LightBlue

        End If

    End Sub

End Module
