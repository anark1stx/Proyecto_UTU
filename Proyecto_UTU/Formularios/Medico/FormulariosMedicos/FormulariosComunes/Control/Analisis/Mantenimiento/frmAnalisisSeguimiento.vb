Imports Entidades
Imports Negocio
Imports Utilidades
Public Class frmAnalisisSeguimiento
    Dim frmDatos As New frmDatosAnalisis
    Protected _analisisSelect As New E_Analisis
    Protected _ci_p As Integer
    Protected _id_c As Integer
    Dim np As New N_Paciente
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
            _modo = value
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

        Select Case MiModo
            Case Modo.Buscar
                '1- Verificar que ese análisis aún no se haya llenado
                '2- Abrir formulario de datos en modo de ingreso (campos con textbox)
            Case Modo.Asignar
                'asignar el analisis seleccionado
                If AnalisisSelect.ID = 0 Then
                    MessageBox.Show("Seleccione un análisis primero", "Debe seleccionar un análisis", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim result = na.AsignarAnalisisAPaciente(CI_paciente, AnalisisSelect.ID, ID_C)
                Select Case result
                    Case -1
                        MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Case -2
                        MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando acción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Case 1
                        MessageBox.Show("El analisis " & AnalisisSelect.Nombre & "fue asignado correctamente al paciente.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                End Select
        End Select
    End Sub

    Private Sub btnConsultarDatos_Click(sender As Object, e As EventArgs) Handles btnConsultarDatos.Click
        '-1 Abrir formulario de datos en modo de lectura (todo con labels)
    End Sub

    Public Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Select Case MiModo
            Case Modo.Buscar 'busco pacientes x ci
                'primero buscar si existe paciente con esa cedula
                'primero buscar si existe paciente con esa cedula
                'primero buscar si existe paciente con esa cedula
                CI_paciente = txtBuscar.Text
                Dim result = np.BuscarMisAnalisis(CI_paciente)
                Select Case result(0).ID
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

                dgwAnalisisPaciente.DataSource = result
                analisis_encontrados = result
                Console.WriteLine("cantidad de analisis: " & analisis_encontrados.Count)
                Exit Sub
            Case Modo.Asignar 'busco analisis x nombre
                Dim result = na.BuscarAnalisisXNombre(txtBuscar.Text)
                Select Case result(0).ID
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
                Console.WriteLine("cantidad de analisis: " & analisis_encontrados.Count)
                dgwAnalisisPaciente.DataSource = analisis_encontrados

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
        AnalisisSelect = analisis_encontrados(e.RowIndex)
    End Sub
End Class