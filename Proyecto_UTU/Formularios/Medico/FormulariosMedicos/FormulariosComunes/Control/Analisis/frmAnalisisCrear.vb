Public Class frmAnalisisCrear
    Dim listaParametros As New List(Of AnalisisParametro)
    Dim _parametros As New List(Of Control)


    Private Sub btnAgregarPrm_Click(sender As Object, e As EventArgs) Handles btnAgregarPrm.Click


        Dim prm = New AnalisisParametro()
        If txtNombrePrm.Text = String.Empty Then
            MessageBox.Show("Ingrese el nombre del parametro que desea ingresar", "Falta llenar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For Each p As AnalisisParametro In listaParametros
            If p.Nombre.ToLower() = txtNombrePrm.Text Then
                MessageBox.Show("El parametro " & p.Nombre & " ya existe", "Parametro ya registrado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Next

        If txtNombrePrm.Text.ToLower() = "resultado" Then
            prm.Nombre = "Resultado"
            listaParametros.Add(prm)

            AnalisisParametroBindingSource.Add(prm)
            Exit Sub
        End If

        For Each t As TextBox In _parametros
            If t.Text = String.Empty Then
                MessageBox.Show("Ingrese " & t.Tag, "Falta llenar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Next

        Dim min As Double = 0.0
        Dim max As Double = 0.0

        Try
            min = Val(txtVMin.Text)
        Catch ex As Exception
            MessageBox.Show("Ingrese solo numeros en valor mínimo", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        Try
            max = Val(txtVMax.Text)
        Catch ex As Exception
            MessageBox.Show("Ingrese solo numeros en valor máximo", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        Dim pr = New AnalisisParametro(txtNombrePrm.Text, txtUnidad.Text, min, max)
        listaParametros.Add(pr)

        AnalisisParametroBindingSource.Add(pr)

    End Sub

    Private Sub frmAnalisisCrear_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _parametros.Add(txtUnidad) 'Por alguna razon no me deja agregarlos en el evento Load
        _parametros.Add(txtVMax)
        _parametros.Add(txtVMin)

    End Sub

    Private Sub dgwParametros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwParametros.CellContentClick
        If dgwParametros.Columns(e.ColumnIndex).Name = "Borrar" Then

            If MessageBox.Show("¿Seguro que desea eliminar este parametro?", "Eliminar parametro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                AnalisisParametroBindingSource.RemoveAt(e.RowIndex)
                listaParametros.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub
End Class