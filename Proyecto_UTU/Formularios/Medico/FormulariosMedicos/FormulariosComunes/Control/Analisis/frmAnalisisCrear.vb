Public Class frmAnalisisCrear
    Dim listaParametros As New List(Of Analisis.Parametro)
    Dim listaIndicaciones As New List(Of Analisis.Indicacion)
    Dim _parametros As New List(Of Control)
    Dim _indicaciones As New List(Of Control)
    Private Sub btnAgregarPrm_Click(sender As Object, e As EventArgs) Handles btnAgregarPrm.Click

        If txtNombrePrm.Text = String.Empty Then
            MessageBox.Show("Ingrese el nombre del parametro que desea ingresar", "Falta llenar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For Each p As Analisis.Parametro In listaParametros
            If p.Nombre.ToLower() = txtNombrePrm.Text Then
                MessageBox.Show("El parametro " & p.Nombre & " ya existe", "Parametro ya registrado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Next

        Dim prm = New Analisis.Parametro()
        If txtNombrePrm.Text.ToLower() = "resultado" Then
            prm.Nombre = "Resultado"
            listaParametros.Add(prm)

            ParametroBindingSource.Add(prm)
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

        Dim pr = New Analisis.Parametro(txtNombrePrm.Text, txtUnidad.Text, min, max)
        listaParametros.Add(pr)
        ParametroBindingSource.Add(pr)
    End Sub

    Private Sub frmAnalisisCrear_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _parametros.Add(txtUnidad) 'Por alguna razon no me deja agregarlos en el evento Load
        _parametros.Add(txtVMax)
        _parametros.Add(txtVMin)

        _indicaciones.Add(txtNomIndicacion)
        _indicaciones.Add(txtIndicacionDescripcion)

    End Sub

    Private Sub dgwParametros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwParametros.CellContentClick
        If dgwParametros.Columns(e.ColumnIndex).Name = "Borrar" Then

            If MessageBox.Show("¿Seguro que desea eliminar este parametro?", "Eliminar parametro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                ParametroBindingSource.RemoveAt(e.RowIndex)
                listaParametros.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub btnAgregarIndicacion_Click(sender As Object, e As EventArgs) Handles btnAgregarIndicacion.Click

        For Each i As Analisis.Indicacion In listaIndicaciones
            If i.Nombre.ToLower() = txtNomIndicacion.Text Then
                MessageBox.Show("La indicación: " & i.Nombre & " ya existe", "indicación ya registrada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            'If i.Indicacion.ToLower() = txtIndicacionDescripcion.Text Then
            '    MessageBox.Show("Ya existe una indicación con esa descripción.", "indicación ya registrada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Exit Sub
            'End If

        Next

        For Each t As TextBox In _indicaciones
            If t.Text = String.Empty Then
                MessageBox.Show("Ingrese " & t.Tag, "Falta llenar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Next

        Dim ind As New Analisis.Indicacion(txtNomIndicacion.Text, txtIndicacionDescripcion.Text)
        listaIndicaciones.Add(ind)
        IndicacionBindingSource.Add(ind)
    End Sub

    Private Sub dgwIndicaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwIndicaciones.CellContentClick
        Console.WriteLine(dgwIndicaciones.Columns(e.ColumnIndex).Name)
        If dgwIndicaciones.Columns(e.ColumnIndex).Name = "borrarInd" Then

            If MessageBox.Show("¿Seguro que desea eliminar esta indicación?", "Eliminar indicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                IndicacionBindingSource.RemoveAt(e.RowIndex)
                listaIndicaciones.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub
End Class