Imports Entidades
Imports Negocio
Imports Utilidades
Public Class frmAnalisisSeguimiento
    Protected _analisisSelect As New E_Analisis
    Protected _ci_p As Integer
    Protected _id_c As Integer
    Dim na As New N_Analisis
    Dim analisis_encontrados As New List(Of E_Analisis)
    Protected _modo
    Public Enum Modo
        Buscar 'buscamos x ci a los pacientes y mostramos sus datos
        Asignar 'habilito la busqueda de analisis x nombre y se la asigno a pacientes
    End Enum

    Property MiModo As Modo
        Get
            Return _modo
        End Get
        Set(value As Modo)
            If _modo <> value Then
                _modo = value
                resetMode()
            End If
        End Set
    End Property

    Property AnalisisSelect As E_Analisis
        Get
            Return _analisisSelect
        End Get
        Set(value As E_Analisis)
            _analisisSelect = value
        End Set
    End Property

    Property CI_paciente As Integer
        Get
            Return _ci_p
        End Get
        Set(value As Integer)
            _ci_p = value
        End Set
    End Property

    Property ID_C As Integer
        Get
            Return _id_c
        End Get
        Set(value As Integer)
            _id_c = value
        End Set
    End Property

    Private Sub btnIngresarDatos_Click(sender As Object, e As EventArgs) Handles btnIngresarDatos.Click
        If AnalisisSelect.ID = 0 Then
            MessageBox.Show("Seleccione un análisis primero", "Debe seleccionar un análisis", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Select Case MiModo
            Case Modo.Buscar
                '1- Verificar que ese análisis aún no se haya llenado
                If AnalisisSelect.FechaRes.ToString() <> "1/1/0001 0:00:00" Then 'significa que aun no fueron ingresados los resultados
                    MessageBox.Show("Ya fueron ingresados resultados para ese análisis", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                'agregar todos los parametros del analisis
                Dim res = na.RetornarParametrosDeAnalisis(AnalisisSelect)
                Select Case res
                    Case -1
                        MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Case -2
                        MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error efectuando acción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                End Select

                '2- Abrir formulario de datos en modo de ingreso (campos con textbox)
                Dim resultadosA As New frmDatosAnalisis With {
                    .AnalisisACargar = AnalisisSelect,
                    .CI_Paciente = CI_paciente,
                    .MiModo = frmDatosAnalisis.Modo.Ingreso
                }
                resultadosA.ShowDialog()
            Case Modo.Asignar
                'asignar el analisis seleccionado
                Me.Hide() 'ya que cuando este formulario esta en modo "Asignar", en realidad esta como .ShowDialog(), y cuando este se cierra ContenedorEntrevistas lee el analisis que se guardo en AnalisisSelect
        End Select
    End Sub

    Private Sub btnConsultarDatos_Click(sender As Object, e As EventArgs) Handles btnConsultarDatos.Click
        If AnalisisSelect.ID = 0 Then
            MessageBox.Show("Seleccione un análisis primero", "Debe seleccionar un análisis", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        '1- Verificar que ese análisis aún no se haya llenado
        If AnalisisSelect.FechaRes.ToString() = "1/1/0001 0:00:00" Then 'significa que aun no fueron ingresados los resultados
            MessageBox.Show("Aún no hay resultados ingresados para el análisis.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'agregar todos los parametros del analisis
        Dim res = na.RetornarParametrosDeAnalisis(AnalisisSelect)
        Select Case res
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error efectuando acción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select

        '2- Abrir formulario de datos en modo de ingreso (campos con textbox)
        Dim resultadosA As New frmDatosAnalisis With {
            .AnalisisACargar = AnalisisSelect,
            .CI_Paciente = CI_paciente,
            .MiModo = frmDatosAnalisis.Modo.Consulta
        }
        resultadosA.ShowDialog()
    End Sub

    Public Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Select Case MiModo
            Case Modo.Buscar
                If Not check_Cedula(txtBuscar.Text) Then
                    Exit Sub
                End If
                CI_paciente = txtBuscar.Text
                Dim na As New N_Analisis
                Dim result = na.ListadoAnalisisPaciente(CI_paciente)
                Select Case result(0).ErrCode
                    Case -1
                        MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Case -2
                        MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando acción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Case -8
                        MessageBox.Show("No se encontraron análisis para este paciente.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                End Select
                analisis_encontrados = result
                fixCols()
            Case Modo.Asignar 'busco analisis x nombre
                Dim result = na.BuscarAnalisisXNombre(txtBuscar.Text)
                Select Case result(0).ErrCode
                    Case -1
                        MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Case -2
                        MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando acción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Case -8
                        MessageBox.Show("No se encontraron análisis con ese nombre.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                End Select
                analisis_encontrados = result
                For Each a As E_Analisis In analisis_encontrados
                    Console.WriteLine(a.Nombre)
                Next
                fixCols()
        End Select
    End Sub

    Sub fixCols()
        Select Case MiModo
            Case Modo.Buscar
                dgwAnalisisPaciente.Columns.Add("ID_analisis", "ID de análisis")
                dgwAnalisisPaciente.Columns.Add("nombreA", "Análisis")
                dgwAnalisisPaciente.Columns.Add("FechaR", "Fecha Requerido")
                dgwAnalisisPaciente.Columns.Add("FechaRes", "Fecha Resultado")

                For Each a As E_Analisis In analisis_encontrados
                    Dim fecha As String = "-"
                    If a.FechaRes.ToString() <> "1/1/0001 0:00:00" Then 'si no hay fecha de resultado defaultea a ese valor en vez de quedar en null.
                        fecha = a.FechaRes.ToString()
                    End If
                    dgwAnalisisPaciente.Rows.Add(a.ID, a.Nombre, a.ConsultaReq.Fecha, fecha)
                Next
            Case Modo.Asignar
                dgwAnalisisPaciente.Columns.Add("ID_analisis", "ID de análisis")
                dgwAnalisisPaciente.Columns.Add("nombreA", "Análisis")
                For Each a As E_Analisis In analisis_encontrados
                    Console.WriteLine("2 " & a.Nombre)
                    dgwAnalisisPaciente.Rows.Add(a.ID, a.Nombre)
                Next
        End Select

    End Sub

    Sub resetMode()
        Select Case MiModo
            Case Modo.Buscar 'dejar todo normal
                lblCedulaPaciente.Text = "Cédula del paciente:"
                btnConsultarDatos.Text = "Consultar datos"
                btnIngresarDatos.Text = "Ingresar datos"
                btnConsultarDatos.Visible = True
                tblAcciones.SetColumnSpan(btnIngresarDatos, 1)
            Case Modo.Asignar
                lblCedulaPaciente.Text = "Nombre del análisis:"
                btnIngresarDatos.Text = "Asignar"
                btnConsultarDatos.Visible = False
                tblAcciones.SetColumnSpan(btnIngresarDatos, 2)
        End Select
    End Sub
    Private Sub frmAnalisisSeguimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub dgwAnalisisPaciente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwAnalisisPaciente.CellClick
        If e.RowIndex = -1 Then
            Exit Sub
        End If
        AnalisisSelect = analisis_encontrados(e.RowIndex)
    End Sub
End Class