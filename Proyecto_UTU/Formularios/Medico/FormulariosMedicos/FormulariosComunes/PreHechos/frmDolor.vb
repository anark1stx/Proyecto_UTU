Public Class frmDolor
    Public Sub AgregarItemALista(item As String, lista As ListBox)
        If Not lista.Items.Contains(item) Then
            lista.Items.Add(item)
        End If

    End Sub
    Private Sub btnCabezaDer_Click(sender As Object, e As EventArgs) Handles btnCabezaDer.Click
        AgregarItemALista("Cabeza Derecha", lbTorso)

    End Sub
    Private Sub btnCabezaIzq_Click(sender As Object, e As EventArgs) Handles btnCabezaIzq.Click
        AgregarItemALista("Cabeza Izquierda", lbTorso)
    End Sub

    Private Sub btnHombroIzq_Click(sender As Object, e As EventArgs) Handles btnHombroIzq.Click
        AgregarItemALista("Hombro Izquierdo", lbTorso)
    End Sub

    Private Sub btnBrazoIzq_Click(sender As Object, e As EventArgs) Handles btnBrazoIzq.Click
        AgregarItemALista("Brazo Izquierdo", lbTorso)
    End Sub

    Private Sub btnManoIzq_Click(sender As Object, e As EventArgs) Handles btnManoIzq.Click
        AgregarItemALista("Mano Izquierda", lbTorso)
    End Sub

    Private Sub btnPechoIzq_Click(sender As Object, e As EventArgs) Handles btnPechoIzq.Click
        AgregarItemALista("Pecho Izquierdo", lbTorso)
    End Sub

    Private Sub btnAbdominalIzq_Click(sender As Object, e As EventArgs) Handles btnAbdominalIzq.Click
        AgregarItemALista("Zona Abdominal Izquierda", lbTorso)
    End Sub

    Private Sub btnPiernaIzq_Click(sender As Object, e As EventArgs) Handles btnPiernaIzq.Click
        AgregarItemALista("Pierna Izquierda", lbTorso)
    End Sub

    Private Sub btnHombroDer_Click(sender As Object, e As EventArgs) Handles btnHombroDer.Click
        AgregarItemALista("Hombro Derecho", lbTorso)
    End Sub

    Private Sub btnBrazoDer_Click(sender As Object, e As EventArgs) Handles btnBrazoDer.Click
        AgregarItemALista("Brazo Derecho", lbTorso)
    End Sub

    Private Sub btnManoDer_Click(sender As Object, e As EventArgs) Handles btnManoDer.Click
        AgregarItemALista("Mano Derecha", lbTorso)
    End Sub

    Private Sub btnPechoDer_Click(sender As Object, e As EventArgs) Handles btnPechoDer.Click
        AgregarItemALista("Pecho Derecho", lbTorso)
    End Sub

    Private Sub btnAbdominalDer_Click(sender As Object, e As EventArgs) Handles btnAbdominalDer.Click
        AgregarItemALista("Zona Abdominal Derecha", lbTorso)
    End Sub

    Private Sub btnPiernaDer_Click(sender As Object, e As EventArgs) Handles btnPiernaDer.Click
        AgregarItemALista("Pierna Derecha", lbTorso)
    End Sub

    Private Sub btnCuello_Click(sender As Object, e As EventArgs) Handles btnCuello.Click
        AgregarItemALista("Cuello", lbTorso)
    End Sub

    Private Sub btnCabezaIzqBack_Click(sender As Object, e As EventArgs) Handles btnCabezaIzqBack.Click
        AgregarItemALista("Cabeza Izquierda", lbDorso)
    End Sub

    Private Sub btnCabezaDerBack_Click(sender As Object, e As EventArgs) Handles btnCabezaDerBack.Click
        AgregarItemALista("Cabeza Derecha", lbDorso)
    End Sub

    Private Sub btnCervicales_Click(sender As Object, e As EventArgs) Handles btnCervicales.Click
        AgregarItemALista("Cervicales", lbDorso)
    End Sub

    Private Sub btnColDorsalIzq_Click(sender As Object, e As EventArgs) Handles btnColDorsalIzq.Click
        AgregarItemALista("Columna Dorsal Izquierda", lbDorso)
    End Sub

    Private Sub btnColDorsalDer_Click(sender As Object, e As EventArgs) Handles btnColDorsalDer.Click
        AgregarItemALista("Columna Dorsal Derecha", lbDorso)
    End Sub

    Private Sub btnColLumbarIzq_Click(sender As Object, e As EventArgs) Handles btnColLumbarIzq.Click
        AgregarItemALista("Columna Lumbar Izquierda", lbDorso)
    End Sub

    Private Sub btnColLumbarDer_Click(sender As Object, e As EventArgs) Handles btnColLumbarDer.Click
        AgregarItemALista("Columna Lumbar Derecha", lbDorso)
    End Sub

    Private Sub btnOmoplatoIzq_Click(sender As Object, e As EventArgs) Handles btnOmoplatoIzq.Click
        AgregarItemALista("Omoplato Izquierdo", lbDorso)
    End Sub

    Private Sub btnOmoplatoDer_Click(sender As Object, e As EventArgs) Handles btnOmoplatoDer.Click
        AgregarItemALista("Omoplato Derecho", lbDorso)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        lbDorso.Items.Clear()
        lbTorso.Items.Clear()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If lbTorso.Items.Count < 1 AndAlso lbDorso.Items.Count < 1 Then
            MsgBox("Seleccione al menos una parte del cuerpo para guardar la información.", vbExclamation)
        Else
            If txtDescripcion.TextLength < 5 Then
                Dim ans = MsgBox("¿Seguro que desea guardar sin haber proveido una descripción detallada?", vbYesNo, vbQuestion)
                If ans = vbYes Then
                    'Guardar datos en la BD
                End If
            End If
        End If
    End Sub
End Class