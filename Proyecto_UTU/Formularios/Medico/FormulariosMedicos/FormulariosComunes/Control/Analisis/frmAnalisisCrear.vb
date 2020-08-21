Public Class frmAnalisisCrear
    Dim listaParametros As New List(Of Label)
    Dim id As Integer = 0
    Private Sub btnAgregarParametro_Click(sender As Object, e As EventArgs) Handles btnAgregarParametro.Click
        If cbParametros.Text Is String.Empty Then
            MessageBox.Show("Ingrese el nombre del parametro", "Falta llenar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            For Each item As String In cbParametros.Items
                If item.ToLower = cbParametros.Text.ToLower Then
                    MessageBox.Show("Ese parametro ya fue registrado en la lista")
                    Exit Sub
                End If
            Next

            cbParametros.Items.Add(cbParametros.Text)

            Dim parametro As New Label With {
                .Name = "parametro" & id,
                .Tag = id,
                .Text = cbParametros.Text
            }

            listaParametros.Add(parametro)
            id += 1
        End If
    End Sub

    Private Sub frmAnalisisCrear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
    End Sub

    Private Sub btnEliminarParametro_Click(sender As Object, e As EventArgs) Handles btnEliminarParametro.Click
        If cbParametros.SelectedIndex = -1 Or cbParametros.SelectedItem Is String.Empty Then
            MessageBox.Show("Debe seleccionar un parametro de la lista.", "Seleccione un parametro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            cbParametros.Items.RemoveAt(cbParametros.SelectedIndex)

            For Each l As Label In listaParametros

                If l.Text = cbParametros.Text Then
                    listaParametros.Remove(l)
                End If
            Next
            cbParametros.Text = String.Empty

        End If
    End Sub

    Private Sub btnAgregarAnalisis_Click(sender As Object, e As EventArgs) Handles btnAgregarAnalisis.Click
        If MessageBox.Show("¿Seguro que desea guardar este análisis?", "Guardar nuevo análisis", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each p As Label In listaParametros

                Console.WriteLine("Texto: " & p.Text & " ID: " & p.Tag)

            Next
        Else
            Exit Sub
        End If
    End Sub
End Class