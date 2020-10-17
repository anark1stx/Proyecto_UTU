Imports Utilidades
Imports Entidades
Imports FormulariosPersonalizados
Imports Negocio
Public Class frmTratamientoCrear
    Protected _modo As New Modo
    Dim negocio As New N_Tratamiento
    Dim listaTrats As New List(Of E_Tratamiento)
    Protected _tratamiento_seleccionado As New E_Tratamiento

    Property TratamientoSeleccionado As E_Tratamiento
        Get
            Return _tratamiento_seleccionado
        End Get
        Set(value As E_Tratamiento)
            _tratamiento_seleccionado = value
        End Set
    End Property

    Public Enum Modo
        Alta 'habilito los campos para escribir
        Asignar 'habilito la lupa y un datagridview
    End Enum

    Property ModoActual As Modo
        Get
            Return _modo
        End Get
        Set(value As Modo)
            If _modo <> value Then 'si modo es diferente del valor que tenia antes, reset.
                _modo = value
                ResetMode()
            End If
        End Set
    End Property

    Private Async Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Select Case ModoActual
            Case Modo.Alta
                If Not check_regex(txtNombreTratamiento.Text, RegexAlfaNumericoEspaciosPuntosComasTildes) Then
                    MessageBox.Show("Nombre de tratamiento inválido. " & MensajeDeErrorCaracteres(), "Caracteres inválidos detectados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If Not check_Largo(txtNombreTratamiento.Text, 10, 160, True) Then
                    MessageBox.Show("Nombre: " & MensajeDeErrorLongitud(10, 160), "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If Not check_Largo(txtDescripcionTratamiento.Text, 10, 16000, True) Then
                    MessageBox.Show("Descripción: " & MensajeDeErrorLongitud(10, 16000), "Información inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim t = New E_Tratamiento(txtNombreTratamiento.Text, txtDescripcionTratamiento.Text)
                Dim result = Await Task.Run(Function() negocio.AltaTratamiento(t))
                Select Case result
                    Case -1
                        MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case -2
                        MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando procedimiento", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case 1
                        MessageBox.Show("Tratamiento ingresado con éxito", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Select
        End Select
    End Sub

    Private Sub frmTratamientoCrear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
    End Sub

    Sub ResetMode()

        Select Case ModoActual
            Case Modo.Alta
                dgwTratamientos.Visible = False
                txtDescripcionTratamiento.Enabled = True
                btnBuscar.Visible = False
                tblElementos.SetColumnSpan(txtNombreTratamiento, 2)
                txtNombreTratamiento.Width += btnBuscar.Width
                dgwTratamientos.Visible = False
                tblElementos.SetRow(dgwTratamientos, 2)
                tblElementos.SetRow(lblIndicaciones, 0)
                tblElementos.SetRow(txtDescripcionTratamiento, 1)
                tblElementos.RowStyles(2).Height = 6.38
                tblElementos.RowStyles(1).Height = 78.7
                btnGuardar.Text = "Guardar Tratamiento"
            Case Modo.Asignar 'asignar
                dgwTratamientos.Visible = True
                txtNombreTratamiento.Width -= btnBuscar.Width * 2
                txtDescripcionTratamiento.Enabled = False
                tblElementos.SetColumnSpan(txtNombreTratamiento, 1)
                btnBuscar.Visible = True
                tblElementos.SetRow(dgwTratamientos, 0)
                tblElementos.SetRow(lblIndicaciones, 1)
                tblElementos.SetRow(txtDescripcionTratamiento, 2)
                tblElementos.RowStyles(1).Height = 6.38
                tblElementos.RowStyles(2).Height = 78.7
                dgwTratamientos.Visible = True
                btnGuardar.Text = "Asingar Tratamiento"
        End Select
    End Sub

    Private Async Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If ModoActual = Modo.Asignar Then
            If Not check_regex(txtNombreTratamiento.Text, RegexAlfaNumericoEspaciosPuntosComasTildes) Then
                MessageBox.Show("Nombre de tratamiento inválido. " & MensajeDeErrorCaracteres(), "Caracteres inválidos detectados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                Dim result = Await Task.Run(Function() negocio.BuscarTratamientoXNombre(txtDescripcionTratamiento.Text))
                Select Case result(0).ErrCode
                    Case -1
                        MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Case -2
                        MessageBox.Show(MensajeDeErrorPermisoProcedimiento, "Error ejecutando procedimiento", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Case -8
                        MessageBox.Show("No fueron encontrados tratamientos con ese nombre.", "No se encontraron resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                End Select
                listaTrats = result
                dgwTratamientos.DataSource = listaTrats
            End If

        End If
    End Sub

    Private Sub txtNombreTratamiento_TextChanged(sender As Object, e As EventArgs) Handles txtNombreTratamiento.TextChanged
        If listaTrats.Exists(Function(p) p.Nombre = txtNombreTratamiento.Text) Then
            Dim trat As E_Tratamiento = listaTrats.Find(Function(p) p.Nombre = txtNombreTratamiento.Text)
            txtDescripcionTratamiento.Text = trat.Descripcion
            TratamientoSeleccionado = trat
        Else
            TratamientoSeleccionado = New E_Tratamiento With {.ID = 0}
        End If
    End Sub

    Private Sub dgwTratamientos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgwTratamientos.CellMouseClick
        TratamientoSeleccionado = listaTrats(dgwTratamientos.CurrentCell.RowIndex)
        txtDescripcionTratamiento.Text = TratamientoSeleccionado.Descripcion
    End Sub
End Class