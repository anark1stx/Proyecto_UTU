Imports Entidades
Imports Negocio
Public Class frmAnalisisCrear
    Dim listaParametros As New List(Of E_Analisis.Parametro)
    Dim listaIndicaciones As New List(Of E_Analisis.Indicacion)
    Dim _parametros As New List(Of Control)
    Dim _indicaciones As New List(Of Control)
    Private Sub btnAgregarPrm_Click(sender As Object, e As EventArgs) Handles btnAgregarPrm.Click

        If txtNombrePrm.Text = String.Empty Then
            MessageBox.Show("Ingrese el nombre del parametro que desea ingresar", "Falta llenar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For Each p As E_Analisis.Parametro In listaParametros
            If p.Nombre.ToLower() = txtNombrePrm.Text Then
                MessageBox.Show("El parametro " & p.Nombre & " ya existe", "Parametro ya registrado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Next

        Dim prm = New E_Analisis.Parametro()
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

        Dim pr = New E_Analisis.Parametro(txtNombrePrm.Text, txtUnidad.Text, min, max)
        listaParametros.Add(pr)
        ParametroBindingSource.Add(pr)
        dgwParametros.DataSource = ParametroBindingSource
    End Sub

    Private Sub frmE_AnalisisCrear_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _parametros.Add(txtUnidad)
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

        For Each i As E_Analisis.Indicacion In listaIndicaciones
            If i.Nombre.ToLower() = txtNomIndicacion.Text Then
                MessageBox.Show("La indicación: " & i.Nombre & " ya existe", "indicación ya registrada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If i.Indicacion.ToLower() = txtIndicacionDescripcion.Text Then
                MessageBox.Show("Ya existe una indicación con esa descripción.", "indicación ya registrada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

        Next

        For Each t As TextBox In _indicaciones
            If t.Text = String.Empty Then
                MessageBox.Show("Ingrese " & t.Tag, "Falta llenar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Next

        Dim ind As New E_Analisis.Indicacion With {.Nombre = txtNomIndicacion.Text, .Indicacion = txtIndicacionDescripcion.Text}
        listaIndicaciones.Add(ind)
        IndicacionBindingSource.Add(ind)
        dgwIndicaciones.DataSource = IndicacionBindingSource
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

    Private Sub dgwParametros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwParametros.CellClick
        txtNombrePrm.Text = listaParametros(e.RowIndex).Nombre
        txtUnidad.Text = listaParametros(e.RowIndex).Unidad
        txtVMin.Text = listaParametros(e.RowIndex).ValorMinimo
        txtVMax.Text = listaParametros(e.RowIndex).ValorMaximo
    End Sub

    Private Sub btnAgregarAnalisis_Click(sender As Object, e As EventArgs) Handles btnAgregarAnalisis.Click
        Dim analisisCreado As New E_Analisis(txtNombreAnalisis.Text, listaParametros, listaIndicaciones)
        Dim na As New N_Analisis
        Dim code = na.AltaAnalisis(analisisCreado)

        Select Case code
            Case 0
                MessageBox.Show("No se pudo ingresar el análisis", "Alta análisis falló", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 1
                MessageBox.Show("Análisis ingresado con éxito", "Alta análisis exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 2
                MessageBox.Show("No se pudieron ingresar los parametros", "Alta parametros falló", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 3
                MessageBox.Show("No se pudieron ingresar las indicaciones", "Alta indicaciones falló", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

    End Sub
End Class