Imports Entidades
Imports Negocio
Imports Utilidades
Public Class frmAnalisisCrear
    Dim negocio As New N_Analisis
    Dim listaParametrosAIngresar As New List(Of E_Analisis.Parametro)
    Dim listaIndicaciones As New List(Of E_Analisis.Indicacion)
    Dim listaParametrosBD As New List(Of E_Analisis.Parametro)
    Dim ACStringCol As New AutoCompleteStringCollection
    Dim parametroSeleccionado As New E_Analisis.Parametro

    ReadOnly Property ControlesDeParametro
        Get
            Return New List(Of Control)(New Control() {txtUnidad, txtVMax, txtVMin})
        End Get
    End Property

    ReadOnly Property ControlesDeIndicaciones
        Get
            Return New List(Of Control)(New Control() {txtIndicacionDescripcion, txtNomIndicacion})
        End Get
    End Property
    Private Sub btnAgregarPrm_Click(sender As Object, e As EventArgs) Handles btnAgregarPrm.Click

        If Not parametroSeleccionado.ID = 0 Then
            listaParametrosAIngresar.Add(parametroSeleccionado)
            ParametroBindingSource.Add(parametroSeleccionado)
            dgwParametros.DataSource = ParametroBindingSource
            Exit Sub
        End If

        If txtNombrePrm.Text = String.Empty Then
            MessageBox.Show("Ingrese el nombre del parametro que desea ingresar", "Falta llenar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If listaParametrosAIngresar.Exists(Function(p) p.Nombre = txtNombrePrm.Text) Then
            MessageBox.Show("Ya fue ingresado un parametro con ese nombre.", "Información duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim prm = New E_Analisis.Parametro

        For Each t As TextBox In ControlesDeParametro
            If t.Text = String.Empty Then
                Select Case t.Name
                    Case "txtUnidad"
                        MessageBox.Show("Ingrese la unidad de medida del parámetro", "Falta llenar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Case "txtVMax"
                        MessageBox.Show("Ingrese la unidad de medida del parámetro", "Falta llenar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Case "txtVMin"
                        MessageBox.Show("Ingrese la unidad de medida del parámetro", "Falta llenar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                End Select
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
        listaParametrosAIngresar.Add(pr)
        ParametroBindingSource.Add(pr)
        dgwParametros.DataSource = ParametroBindingSource
    End Sub

    Private Sub frmE_AnalisisCrear_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnlDatos.Enabled = False
        cargarParametros()

    End Sub

    Private Async Sub cargarParametros()
        listaParametrosBD = Await Task.Run(Function() negocio.RetornarParametros())

        Select Case listaParametrosBD(0).ErrCode
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Hay Errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case -2
                MessageBox.Show("No se pudieron cargar los parametros", "Error cargando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case -8
                MessageBox.Show("No se encontraron parametros precargados en la base de datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
        End Select

        For Each p As E_Analisis.Parametro In listaParametrosBD
            ACStringCol.Add(p.Nombre)
        Next

        txtNombrePrm.AutoCompleteCustomSource = ACStringCol
    End Sub

    Private Sub dgwParametros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwParametros.CellContentClick
        If dgwParametros.Columns(e.ColumnIndex).Name = "BorrarPrm" Then
            If MessageBox.Show("¿Seguro que desea eliminar este parametro?", "Eliminar parametro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                ParametroBindingSource.RemoveAt(e.RowIndex)
                listaParametrosAIngresar.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub btnAgregarIndicacion_Click(sender As Object, e As EventArgs) Handles btnAgregarIndicacion.Click

        For Each t As TextBox In ControlesDeIndicaciones
            If t.Text = String.Empty Then
                Select Case t.Name
                    Case "txtNomIndicacion"
                        MessageBox.Show("Ingrese el nombre de la indicación.", "Falta llenar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Case "txtIndicacionDescripcion"
                        MessageBox.Show("Ingrese una descripción de la indicación.", "Falta llenar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                End Select
            End If

        Next

        If listaIndicaciones.Exists(Function(i) i.Nombre = txtNomIndicacion.Text) Then
            MessageBox.Show("Ya fue ingresada una indicación con ese nombre.", "Información duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If listaIndicaciones.Exists(Function(i) i.Descripcion = txtIndicacionDescripcion.Text) Then
            MessageBox.Show("Ya fue ingresada una indicación con esa descripción.", "Información duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Dim ind As New E_Analisis.Indicacion With {.Nombre = txtNomIndicacion.Text, .Descripcion = txtIndicacionDescripcion.Text}
        listaIndicaciones.Add(ind)
        IndicacionBindingSource.Add(ind)
        dgwIndicaciones.DataSource = IndicacionBindingSource
    End Sub

    Private Sub dgwIndicaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwIndicaciones.CellContentClick
        Console.WriteLine(dgwIndicaciones.Columns(e.ColumnIndex).Name)
        If dgwIndicaciones.Columns(e.ColumnIndex).Name = "BorrarIndic" Then

            If MessageBox.Show("¿Seguro que desea eliminar esta indicación?", "Eliminar indicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                IndicacionBindingSource.RemoveAt(e.RowIndex)
                listaIndicaciones.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub dgwParametros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwParametros.CellClick
        txtNombrePrm.Text = listaParametrosAIngresar(e.RowIndex).Nombre
        txtUnidad.Text = listaParametrosAIngresar(e.RowIndex).Unidad
        txtVMin.Text = listaParametrosAIngresar(e.RowIndex).ValorMinimo
        txtVMax.Text = listaParametrosAIngresar(e.RowIndex).ValorMaximo
    End Sub

    Private Sub btnAgregarAnalisis_Click(sender As Object, e As EventArgs) Handles btnAgregarAnalisis.Click

        If listaParametrosAIngresar.Count < 5 Then
            MessageBox.Show("Ingrese al menos 5 parametros", "Falta ingresar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If listaIndicaciones.Count < 1 Then
            MessageBox.Show("Ingrese al menos 1 indicación", "Falta ingresar información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim analisisCreado As New E_Analisis(txtNombreAnalisis.Text, listaParametrosAIngresar, listaIndicaciones)
        Dim na As New N_Analisis
        Dim code = na.AltaAnalisis(analisisCreado)

        Select Case code
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 1
                MessageBox.Show("El análisis fue ingresado con éxito", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando procedimiento", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case -3, -5
                MessageBox.Show("Error ingresando parámetros.", "Error ejecutando procedimiento", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case -6
                MessageBox.Show("Error ingresando indicaciones.", "Error ejecutando procedimiento", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

    End Sub

    Private Async Sub btnCheckNombreA_Click(sender As Object, e As EventArgs) Handles btnCheckNombreA.Click, txtNombreAnalisis.Leave
        If Not txtNombreAnalisis.Text Is String.Empty Then
            Dim existe As Integer = Await Task.Run(Function() negocio.AnalisisExiste(txtNombreAnalisis.Text))

            Select Case existe
                Case -1
                    MessageBox.Show(MensajeDeErrorConexion(), "Errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    pnlDatos.Enabled = False
                    Exit Sub
                Case 1
                    MessageBox.Show("Ya existe registrado un análisis con ese nombre", "Análisis existente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    pnlDatos.Enabled = False
                    Exit Sub
                Case -2
                    MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando procedimiento", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    pnlDatos.Enabled = False
                    Exit Sub
                Case 0
                    pnlDatos.Enabled = True
            End Select

        End If
    End Sub

    Private Sub habilitarTXT(_case As Boolean)
        txtUnidad.Enabled = _case
        txtVMax.Enabled = _case
        txtVMin.Enabled = _case
    End Sub

    Private Sub txtNombrePrm_TextChanged(sender As Object, e As EventArgs) Handles txtNombrePrm.TextChanged

        If listaParametrosBD.Exists(Function(p) p.Nombre = txtNombrePrm.Text) Then
            Dim param As E_Analisis.Parametro = listaParametrosBD.Find(Function(p) p.Nombre = txtNombrePrm.Text)
            txtUnidad.Text = param.Unidad
            txtVMax.Text = param.ValorMaximo
            txtVMin.Text = param.ValorMinimo
            habilitarTXT(False)
            parametroSeleccionado = param
        Else
            habilitarTXT(True)
            parametroSeleccionado = New E_Analisis.Parametro With {.ID = 0}
            txtUnidad.Text = String.Empty
            txtVMax.Text = String.Empty
            txtVMin.Text = String.Empty
        End If

    End Sub

    Private Sub txtNombreAnalisis_TextChanged(sender As Object, e As EventArgs) Handles txtNombreAnalisis.TextChanged
        pnlDatos.Enabled = False
    End Sub

End Class