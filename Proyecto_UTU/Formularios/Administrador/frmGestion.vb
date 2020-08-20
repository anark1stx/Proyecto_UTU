Public Class frmGestion
    Dim tipo_usuario As String = ""
    Dim filtro As String = "CI"
    Dim medico As New Medico
    Dim paciente As New Paciente
    Dim aux As New Usuario
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'Verificar que al menos uno de los radiobuttons esté seleccionado
        'Verificiar que txtBuscar no esté vacio
        '                                   -->Verificar que si seleccionó cédula, lo que puso en txtBuscar cumpla con el formato.
        '                                    --> "" seleccionó Nombre y Apellido, solo haya texto.

        If txtBuscar.Text = String.Empty Then
            MessageBox.Show("Ingrese un valor en el campo de texto de búsqueda", "Falta ingresar información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            For Each rdBTN As RadioButton In pnl_rdbtns_ci_nom_ap.Controls
                If rdBTN.Checked Then
                    filtro = rdBTN.Text
                End If
            Next

        End If

        Select Case filtro
            Case "Cedula"
                If Not check_Cedula(txtBuscar.Text) Then
                    MessageBox.Show("Ingrese una cédula válida", "Verifique la información ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else

                    Select Case tipo_usuario
                        Case "paciente"
                            paciente.Cedula = txtBuscar.Text
                            paciente.buscarPorCI()
                            '()-> Cargar datos en datagridview
                        Case "medico"
                            medico.Cedula = txtBuscar.Text
                            medico.buscarPorCI()
                            '()-> Cargar datos en datagridview
                        Case "aux"
                            aux.Cedula = txtBuscar.Text
                            aux.buscarPorCI()
                            '()-> Cargar datos en datagridview
                    End Select

                End If

            Case "Especialidad"
                medico.Especialidad(0) = txtBuscar.Text
                'medico.BuscarPorEspecialidad()
        End Select

    End Sub

    Private Sub frmGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarControles(Me)
    End Sub
End Class