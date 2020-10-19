Imports Utilidades
Imports Entidades
Imports Negocio
Public Class frmTratamientoCrear
    Protected _modo As New Modo
    Dim negocio As New N_Tratamiento
    Protected listaTrats As New List(Of E_Tratamiento)
    Protected _tratamiento_seleccionado As New E_Tratamiento
    Protected CI_P As Integer

    Property CI_Paciente As Integer
        Get
            Return CI_P
        End Get
        Set(value As Integer)
            CI_P = value
        End Set
    End Property
    Property TratamientoSeleccionado As E_Tratamiento
        Get
            Return _tratamiento_seleccionado
        End Get
        Set(value As E_Tratamiento)
            _tratamiento_seleccionado = value
        End Set
    End Property
    Property HistorialT As List(Of E_Tratamiento)
        Get
            Return listaTrats
        End Get
        Set(value As List(Of E_Tratamiento))
            listaTrats = value
        End Set
    End Property
    Public Enum Modo
        Alta 'habilito los campos para escribir
        Asignar 'habilito la lupa y un datagridview
        Sugerir 'habilito la lupa y un datagridview
        HistorialPacienteConsulta 'cargo todos los tratamientos del paciente
        HistorialPacienteIngreso 'cargo todos los tratamientos del paciente
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
            Case Modo.Sugerir, Modo.Asignar
                If TratamientoSeleccionado.ID = 0 Then
                    MessageBox.Show("Seleccione un tratamiento primero", "Debe seleccionar un tratamiento", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    Me.Hide()
                End If
        End Select
    End Sub

    Private Sub frmTratamientoCrear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
    End Sub

    Sub ResetMode()

        Select Case ModoActual
            Case Modo.Alta
                tblBusqueda.Visible = True
                lblNombreTratamiento.Visible = True
                DefinirToolStripMenuItem.Visible = False
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
                tblBusqueda.Visible = True
                lblNombreTratamiento.Visible = True
                DefinirToolStripMenuItem.Visible = True
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
            Case Modo.Sugerir
                tblBusqueda.Visible = True
                lblNombreTratamiento.Visible = True
                DefinirToolStripMenuItem.Visible = False
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
                btnGuardar.Text = "Sugerir Tratamiento"
            Case Modo.HistorialPacienteConsulta, Modo.HistorialPacienteIngreso
                DefinirToolStripMenuItem.Visible = False
                tblBusqueda.Visible = False
                lblNombreTratamiento.Visible = False
                btnGuardar.Visible = False
                tblElementos.SetRowSpan(dgwTratamientos, 3)
                btnBuscar_Click(sender:=New Object, e:=New EventArgs)
        End Select
    End Sub

    Private Async Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Console.WriteLine("click en btnBuscar")
        Console.WriteLine(ModoActual.ToString())
        Select Case ModoActual
            Case Modo.Asignar, Modo.Sugerir
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
            Case Modo.HistorialPacienteConsulta, Modo.HistorialPacienteIngreso
                Dim result = Await Task.Run(Function() negocio.ConsultarHistorialTratamientos(CI_P))
                Console.WriteLine("buscando tratamientos para el paciente: " & CI_Paciente)
                Select Case result(0).ErrCode
                    Case -1
                        MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Case -2
                        MessageBox.Show(MensajeDeErrorPermisoProcedimiento, "Error ejecutando procedimiento", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Case -8
                        MessageBox.Show("No fueron encontrados tratamientos para ese paciente.", "No se encontraron resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                End Select
                listaTrats = result
                Console.WriteLine("trats encontrados: " & listaTrats.Count)
                fixCols()
        End Select
    End Sub
    Sub fixCols()
        dgwTratamientos.DataBindings.Clear()
        dgwTratamientos.DataSource = Nothing
        dgwTratamientos.Columns.Clear()
        dgwTratamientos.Columns.Add("ID_T", "ID")
        dgwTratamientos.Columns.Add("NOM_T", "Nombre")
        dgwTratamientos.Columns.Add("DESCR_T", "Descripcion")
        dgwTratamientos.Columns.Add("F_INI", "Fecha de Inicio")
        dgwTratamientos.Columns.Add("F_FIN", "Fecha de Finalización")
        dgwTratamientos.Columns.Add("RES", "Resultado")
        For Each t As E_Tratamiento In listaTrats
            dgwTratamientos.Rows.Add(t.ID, t.Nombre, t.Descripcion, t.FechaInicio.ToShortDateString(), t.FechaFin.ToShortDateString(), t.Resultado)
        Next
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
        Select Case ModoActual
            Case Modo.HistorialPacienteIngreso
                'abrir seguimiento
                Dim frmSeguir As New frmTratamientoSeguir
                frmSeguir.Tratamiento = TratamientoSeleccionado
                frmSeguir.CI_Paciente = CI_Paciente
                frmSeguir.dtpDiasDisponiblesSeguimiento.MinDate = TratamientoSeleccionado.FechaInicio
                frmSeguir.dtpDiasDisponiblesSeguimiento.MaxDate = TratamientoSeleccionado.FechaFin
                frmSeguir.MiModo = frmTratamientoSeguir.Modo.DefinirDatosS
                frmSeguir.ShowDialog()
            Case Modo.HistorialPacienteConsulta
                'abrir seguimiento
                Dim frmSeguir As New frmTratamientoSeguir
                frmSeguir.Tratamiento = TratamientoSeleccionado
                frmSeguir.CI_Paciente = CI_Paciente
                frmSeguir.dtpDiasDisponiblesSeguimiento.MinDate = TratamientoSeleccionado.FechaInicio
                frmSeguir.dtpDiasDisponiblesSeguimiento.MaxDate = TratamientoSeleccionado.FechaFin
                frmSeguir.MiModo = frmTratamientoSeguir.Modo.ConsultarDatosS
                frmSeguir.ShowDialog()
            Case Else
                txtDescripcionTratamiento.Text = TratamientoSeleccionado.Descripcion
        End Select

    End Sub

    Private Sub DefinirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefinirToolStripMenuItem.Click
        Dim tmpParams As New frmParametrosTemporalesT
        tmpParams.ShowDialog()
        TratamientoSeleccionado.FechaInicio = tmpParams.dtpFechaInicio.Value
        TratamientoSeleccionado.FechaFin = tmpParams.dtpFechaFin.Value
        TratamientoSeleccionado.DiasAsignados.Clear()
        For Each day As DayOfWeek In tmpParams.lbDiasSelect.Items
            TratamientoSeleccionado.DiasAsignados.Add(day)
        Next

        For Each day As DayOfWeek In TratamientoSeleccionado.DiasAsignados
            Console.WriteLine("dia asignado: " & day)
        Next

    End Sub

End Class