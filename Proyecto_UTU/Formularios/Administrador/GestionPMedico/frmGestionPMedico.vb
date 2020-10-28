Imports Utilidades
Imports Entidades
Imports Negocio
Public Class frmGestionPMedico
    Private elegirMedico As New frmGestion With {.Mode = frmGestion.Accion.GestionarPMedico, .Usuario = frmGestion.TipoUsuario.Medico, .TopLevel = False, .TopMost = True, .Dock = DockStyle.Top}
    Private elegirAuxiliar As New frmGestion With {.Mode = frmGestion.Accion.GestionarPMedico, .Usuario = frmGestion.TipoUsuario.Auxiliar, .TopLevel = False, .TopMost = True, .Dock = DockStyle.Top}
    Private listaMedico As New List(Of E_Corresponde)
    Private listaAuxiliar As New List(Of E_Corresponde)
    Dim n_crr As New N_Corresponde
    Private Sub frmGestionPMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblPMedico.Controls.Add(elegirMedico, 0, 0)
        tblPMedico.Controls.Add(elegirAuxiliar, 0, 1)
        elegirMedico.Visible = True
        elegirAuxiliar.Visible = True
        Me.SetBounds(0, 0, Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height)
        Me.MaximizeBox = False
        AddHandler elegirMedico.dgwUsuarios.CurrentCellChanged, AddressOf CargarCrrMedico
        AddHandler elegirAuxiliar.dgwUsuarios.CurrentCellChanged, AddressOf CargarCrrAuxiliar
    End Sub

    Sub CargarCrrMedico()
        listaMedico = n_crr.BuscarAsignacionesM(elegirMedico.MedicoSelected)
        If listaMedico(0).Fecha.ToShortDateString() = "1/1/0001" Then
            listaMedico.Clear()
            Exit Sub
        End If
        Dim itemsFormateados = listaMedico.Select(Function(crr) New With {
        crr.Auxiliar.Cedula,
        crr.Fecha,
        Key .FormattedItem = String.Format("Auxiliar: {0} - Fecha: {1}", crr.Auxiliar.Cedula, crr.Fecha)
        }).ToArray()
        lbMedicoAsignaciones.DataSource = itemsFormateados
        lbMedicoAsignaciones.DisplayMember = "FormattedItem"
    End Sub
    Sub CargarCrrAuxiliar()
        listaAuxiliar = n_crr.BuscarAsignacionesA(elegirAuxiliar.AuxiliarSelected)
        If listaAuxiliar(0).Fecha.ToShortDateString() = "1/1/0001" Then
            listaAuxiliar.Clear()
            Exit Sub
        End If
        Dim itemsFormateados = listaAuxiliar.Select(Function(crr) New With {
        crr.Medico.Cedula,
        crr.Fecha,
        Key .FormattedItem = String.Format("Médico: {0} - Fecha: {1}", crr.Medico.Cedula, crr.Fecha)
        }).ToArray()
        lbAuxiliarAsignaciones.DataSource = itemsFormateados
        lbAuxiliarAsignaciones.DisplayMember = "FormattedItem"
    End Sub
    Private Sub btnAgregarAsignar_Click(sender As Object, e As EventArgs) Handles btnAgregarAsignar.Click
        If elegirMedico.MedicoSelected.Cedula = 0 Then
            MessageBox.Show("Seleccione un médico primero.", "Falta proporcionar información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If elegirAuxiliar.AuxiliarSelected.Cedula = 0 Then
            MessageBox.Show("Seleccione un auxiliar primero.", "Falta proporcionar información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim definirhorario As New frmDefinirFechaAsignacion
        definirhorario.ShowDialog()

        If Not definirhorario.Cancelar Then
            Dim fechaelegida = New Date(definirhorario.dtpFecha.Value.Year, definirhorario.dtpFecha.Value.Month, definirhorario.dtpFecha.Value.Day, definirhorario.dtpHora.Value.Hour, definirhorario.dtpHora.Value.Minute, 0)
            Dim corresponde As New E_Corresponde(elegirMedico.MedicoSelected, elegirAuxiliar.AuxiliarSelected, fechaelegida)
            Dim result = n_crr.AltaCorresponde(corresponde)
            Select Case result
                Case -1
                    MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case -2
                    MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando acción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 1
                    MessageBox.Show("Ingresado con éxito.", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        End If

    End Sub

    Private Sub btnSacarAsignarM_Click(sender As Object, e As EventArgs) Handles btnSacarAsignarM.Click
        If lbMedicoAsignaciones.Items.Count < 1 Then
            Exit Sub
        End If
        Dim result = n_crr.BajaCorresponde(listaMedico(lbMedicoAsignaciones.SelectedIndex))
        Select Case result
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando acción", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 1
                MessageBox.Show("Eliminado con éxito.", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarCrrAuxiliar()
                CargarCrrMedico()
        End Select
    End Sub

    Private Sub btnSacarCorrespondeA_Click(sender As Object, e As EventArgs) Handles btnSacarAsginarA.Click
        If lbAuxiliarAsignaciones.Items.Count < 1 Then
            Exit Sub
        End If
        Dim result = n_crr.BajaCorresponde(listaAuxiliar(lbAuxiliarAsignaciones.SelectedIndex))
        Select Case result
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando acción", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 1
                MessageBox.Show("Eliminado con éxito.", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarCrrAuxiliar()
                CargarCrrMedico()
        End Select
    End Sub
End Class