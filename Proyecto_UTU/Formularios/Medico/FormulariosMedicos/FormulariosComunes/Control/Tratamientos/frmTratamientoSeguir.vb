﻿Imports Entidades
Imports Negocio
Imports Utilidades
Public Class frmTratamientoSeguir
    Protected t As New E_Tratamiento
    Protected _ci_paciente As Integer
    Protected _modo As Modo
    Dim nt As New N_Tratamiento
    Dim lastDatePicked As Date
    Property Tratamiento As E_Tratamiento
        Get
            Return t
        End Get
        Set(value As E_Tratamiento)
            t = value
        End Set
    End Property
    Property CI_Paciente As Integer
        Get
            Return _ci_paciente
        End Get
        Set(value As Integer)
            _ci_paciente = value
        End Set
    End Property
    Property MiModo As Modo
        Get
            Return _modo
        End Get
        Set(value As Modo)
            _modo = value
        End Set
    End Property
    Public Enum Modo
        DefinirDatosS
        ConsultarDatosS
    End Enum
    Private Sub frmTratamientoSeguir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombreTratamientoTXT.Text = String.Format("Paciente: {0}, Tratamiento: {1} (#{2})", CI_Paciente, Tratamiento.Nombre, Tratamiento.ID)
        txtFechaFinalizacion.Text = Tratamiento.FechaInicio.ToShortDateString()
        txtFechaInicio.Text = Tratamiento.FechaFin.ToShortDateString()
        txtDescripcionTratamiento.Text = t.Descripcion
        CargarInfoSeguimientos()
        If MiModo = Modo.ConsultarDatosS Then
            btnGuardar.Visible = False
            txtSeguimiento.ReadOnly = True
            tblResultado.Visible = False
        End If
    End Sub

    Async Sub CargarInfoSeguimientos()
        Dim result = Await Task.Run(Function() nt.ConsultarDiasSemana(t, CI_Paciente))
        Select Case result
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dtpDiasDisponiblesSeguimiento.Enabled = False
                btnGuardar.Enabled = True
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando acción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dtpDiasDisponiblesSeguimiento.Enabled = False
                btnGuardar.Enabled = True
            Case 1
                dtpDiasDisponiblesSeguimiento.Enabled = True
                btnGuardar.Enabled = True
                For Each day As DayOfWeek In t.DiasAsignados
                    lbDiasSemana.Items.Add(day)
                    Console.WriteLine(day.ToString())
                Next
        End Select

        Dim resultBusqueda As Integer = -1
        Dim diff = t.FechaFin - t.FechaInicio
        For i = 0 To diff.Days
            Dim fecha = t.FechaInicio + New TimeSpan(i, 0, 0, 0)
            If Tratamiento.DiasAsignados.Contains(fecha.DayOfWeek) Then
                Dim result2 = Await Task.Run(Function() nt.ConsultarSeguimientoDiario(t, CI_Paciente, fecha))
                Select Case result2.ErrCode
                    Case -1
                        resultBusqueda = -1
                        MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        dtpDiasDisponiblesSeguimiento.Enabled = False
                        btnGuardar.Enabled = False
                        Exit For
                    Case -2
                        resultBusqueda = -2
                        MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando acción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        dtpDiasDisponiblesSeguimiento.Enabled = False
                        btnGuardar.Enabled = False
                        Exit For
                    Case -8
                        Console.WriteLine("no hay seguimiento registrado para la fecha: " & fecha.ToShortDateString())
                        resultBusqueda = 1
                    Case 0
                        resultBusqueda = 1
                        Tratamiento.ListaSeguimientos.Add(result2)
                        dtpDiasDisponiblesSeguimiento.Value = result2.Fecha
                        dtpDiasDisponiblesSeguimiento.Value += New TimeSpan(0, 0, 1) 'esto es para forzar el evento value changed
                End Select
            End If
        Next
        Console.WriteLine("resultBusqueda: " & resultBusqueda)
        If resultBusqueda = 1 Then
            dtpDiasDisponiblesSeguimiento.Enabled = True
            btnGuardar.Enabled = True
        End If

        If MiModo = Modo.DefinirDatosS Then
            VerificarSeguimientos()
        End If
        VerificarResultado()

    End Sub

    Sub VerificarSeguimientos() 'si el tratamiento tiene todos sus seguimientos definidos, habilito el tblResultado
        If Now() < t.FechaFin Then
            Exit Sub
        Else
            Dim diff = t.FechaFin - t.FechaInicio
            Dim completo As Boolean = False
            For i = 0 To diff.Days
                Dim fecha = t.FechaInicio + New TimeSpan(i, 0, 0, 0)
                If Not t.ListaSeguimientos.Exists(Function(s) s.Fecha = fecha) Then
                    completo = False
                Else
                    completo = True
                End If
            Next

            If completo Then
                tblResultado.Visible = True
            Else
                tblResultado.Visible = False
            End If
        End If
    End Sub

    Sub VerificarResultado()
        If Not String.IsNullOrEmpty(t.Resultado) Then
            btnResultado.Enabled = False
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If dtpDiasDisponiblesSeguimiento.Value > Now() Then
            MessageBox.Show("No puede ingresar información sobre el seguimiento de un día posterior al actual.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Not check_Largo(txtSeguimiento.Text, 10, 3600, True) Then
            MessageBox.Show(MensajeDeErrorLongitud(10, 3600), "Falta ingresar información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Not check_regex(txtSeguimiento.Text, RegexAlfaNumericoEspaciosPuntosComasTildes, True) Then
            MessageBox.Show(MensajeDeErrorCaracteres(), "Caracteres inválidos detectados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim seguimiento As New E_Seguimiento With {.Descripcion = txtSeguimiento.Text, .Fecha = dtpDiasDisponiblesSeguimiento.Value}

        Dim result = nt.AltaSeguimientoDiario(t, seguimiento, CI_Paciente)
        Select Case result
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dtpDiasDisponiblesSeguimiento.Enabled = False
                btnGuardar.Enabled = True
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando acción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dtpDiasDisponiblesSeguimiento.Enabled = False
                btnGuardar.Enabled = True
            Case 1
                MessageBox.Show("Seguimiento diario guardado con éxito", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Tratamiento.ListaSeguimientos.Add(seguimiento)
                txtSeguimiento.ReadOnly = True
                btnGuardar.Enabled = False
                VerificarSeguimientos()
        End Select
    End Sub

    Private Sub dtpDiasDisponiblesSeguimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtpDiasDisponiblesSeguimiento.ValueChanged

        If Tratamiento.DiasAsignados.Count < 1 Then
            Exit Sub
        End If

        If Not Tratamiento.DiasAsignados.Contains(dtpDiasDisponiblesSeguimiento.Value.DayOfWeek) Then
            MessageBox.Show("El día " & dtpDiasDisponiblesSeguimiento.Value.DayOfWeek.ToString() & " no es un día de semana registrado para este tratamiento", "Día inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSeguimiento.Clear()
            dtpDiasDisponiblesSeguimiento.Value = lastDatePicked
            Exit Sub
        Else
            lastDatePicked = dtpDiasDisponiblesSeguimiento.Value
            btnGuardar.Enabled = True
        End If
        'si el dia seleccionado tiene info, la cargo y dejo en readonly, deshabilito guardar
        If Tratamiento.ListaSeguimientos.Exists(Function(s) s.Fecha.ToShortDateString() = dtpDiasDisponiblesSeguimiento.Value.ToShortDateString()) Then
            btnGuardar.Enabled = False
            txtSeguimiento.Text = Tratamiento.ListaSeguimientos.Find(Function(s) s.Fecha.ToShortDateString() = dtpDiasDisponiblesSeguimiento.Value.ToShortDateString()).Descripcion
            txtSeguimiento.ReadOnly = True
            Exit Sub
        Else
            btnGuardar.Enabled = True
            txtSeguimiento.Clear()
            txtSeguimiento.ReadOnly = False
        End If
    End Sub

    Private Sub btnResultado_Click(sender As Object, e As EventArgs) Handles btnResultado.Click
        If Not check_Largo(txtResultado.Text, 3, 30, True) Then
            MessageBox.Show("Escriba el resultado primero", "Falta proveer información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Not check_regex(txtResultado.Text, RegexLiteralAcentos, True) Then
            MessageBox.Show(MensajeDeErrorCaracteres(), "Caracteres inválidos detectados.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        t.Resultado = txtResultado.Text

        Dim res = nt.AltaResultadoTratamiento(t, CI_Paciente)
        Select Case res
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando acción", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 1
                MessageBox.Show("Resultado de tratamiento actualizado con éxito", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                VerificarResultado()
        End Select
    End Sub
End Class