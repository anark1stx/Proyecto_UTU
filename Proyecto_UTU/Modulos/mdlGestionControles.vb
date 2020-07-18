Module mdlGestionControles
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

End Module