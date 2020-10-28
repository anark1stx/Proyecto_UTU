Imports Entidades
Imports Utilidades
Imports Negocio
Public Class Identificacion_Paciente
    Protected _paciente As New E_Paciente
    Protected _consulta As New E_Atiende
    Protected _consultas_previas As New List(Of E_Atiende)
    Protected _modo As Modo

    Property MiModo As Modo
        Get
            Return _modo
        End Get
        Set(value As Modo)
            _modo = value
            ResetMode()
        End Set
    End Property

    Sub ResetMode()
        Select Case MiModo
            Case Modo.ConsultaComoMedico
                tblAcciones.Visible = True
                btnAtenderAhora.Visible = True
                tblAcciones.SetRowSpan(btnAgregarLista, 1)
            Case Modo.ConsultaComoAuxiliar
                tblAcciones.Visible = True
                btnAtenderAhora.Visible = False
                tblAcciones.SetRow(btnAgregarLista, tblAcciones.GetRow(btnAtenderAhora))
                tblAcciones.SetRowSpan(btnAgregarLista, 2)
            Case Modo.AsignarTratamiento, Modo.HacerSeguimiento
                txtCedulaPaciente.Enabled = True
                tblAcciones.Visible = False
        End Select
    End Sub

    Property PacienteBuscar As E_Paciente
        Get
            Return _paciente
        End Get
        Set(value As E_Paciente)
            _paciente = value
        End Set
    End Property
    Property Consulta As E_Atiende
        Get
            Return _consulta
        End Get
        Set(value As E_Atiende)
            _consulta = value
        End Set
    End Property

    Property ConsultasPrevias As List(Of E_Atiende)
        Get
            Return _consultas_previas
        End Get
        Set(value As List(Of E_Atiende))
            _consultas_previas = value
            CargarConsultas()
        End Set
    End Property

    Public Enum Modo
        ConsultaComoMedico
        ConsultaComoAuxiliar
        AsignarTratamiento
        HacerSeguimiento
    End Enum

    Sub CargarConsultas()
        Select Case ConsultasPrevias(0).ErrCode
            Case -8
                cbConsultasPrevias.Text = "El paciente no tiene consultas previas"
                btnReferenciaConsulta.Enabled = False
                btnVerConsulta.Enabled = False
            Case <> -1, -2
                Dim itemFormateados = ConsultasPrevias.Select(Function(consulta) New With {
                    consulta.ID,
                    consulta.Fecha,
                    Key .FormattedItem = String.Format("{0} - {1}", consulta.Fecha.ToShortDateString(), consulta.NombreConsulta)
                }).ToArray()

                cbConsultasPrevias.DataSource = itemFormateados
                cbConsultasPrevias.DisplayMember = "FormattedItem"
                cbConsultasPrevias.ValueMember = "ID"
                btnReferenciaConsulta.Enabled = True
                btnVerConsulta.Enabled = True
        End Select
    End Sub

    Sub PoblarDatos()
        txtCedulaPaciente.Text = PacienteBuscar.Cedula

        If PacienteBuscar.Nombre2 IsNot String.Empty Then
            lblNombresTXT.Text = String.Format("{0}, {1}", PacienteBuscar.Nombre1, PacienteBuscar.Nombre2)
        Else
            lblNombresTXT.Text = PacienteBuscar.Nombre1
        End If

        If Not PacienteBuscar.Apellido2 Is String.Empty Then
            lblApellidosTXT.Text = String.Format("{0}, {1}", PacienteBuscar.Apellido1, PacienteBuscar.Apellido2)
        Else
            lblApellidosTXT.Text = PacienteBuscar.Apellido1
        End If

        lblDireccionTXT.Text = String.Format("{0}, {1}", PacienteBuscar.Direccion_Calle, PacienteBuscar.Direccion_Numero)
        lblFechaNacTXT.Text = PacienteBuscar.FechaNacimiento.ToShortDateString()
        lblOcupacionTXT.Text = PacienteBuscar.Ocupacion
        lblE_CivilTXT.Text = PacienteBuscar.Estado_civil
        txtEstado.Text = PacienteBuscar.Estado.Nombre
        pBoxFotoPaciente.Image = Bytes2Image(PacienteBuscar.Foto)

        lblTelefonoa.Text = ""
        For Each t As String In PacienteBuscar.TelefonosLista
            If Not t Is PacienteBuscar.TelefonosLista.Last() Then
                lblTelefonoa.Text &= t & ", "
            Else
                lblTelefonoa.Text &= t
            End If
        Next

        Select Case PacienteBuscar.Sexo
            Case "M"
                lblSexoTXT.Text = "Masculino"
            Case "F"
                lblSexoTXT.Text = "Femenino"
        End Select
    End Sub

    Private Sub Identificacion_Paciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
    End Sub

    Private Sub btnReferenciaConsulta_Click(sender As Object, e As EventArgs) Handles btnReferenciaConsulta.Click
        Consulta.ConsultaReferencia = ConsultasPrevias(cbConsultasPrevias.SelectedIndex)
    End Sub

    Private Sub txtMotivoC_TextChanged(sender As Object, e As EventArgs) Handles txtMotivoC.TextChanged
        Consulta.Motivo = txtMotivoC.Text
    End Sub

    Private Sub cbConsultasPrevias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbConsultasPrevias.SelectedIndexChanged
        Consulta.ConsultaReferencia = ConsultasPrevias(cbConsultasPrevias.SelectedIndex)
    End Sub

    Private Sub btnActualizarEstado_Click(sender As Object, e As EventArgs) Handles btnActualizarEstado.Click
        If Not check_regex(txtEstado.Text, RegexAlfaNumericoAcentosEspacios, True) Then
            MessageBox.Show(MensajeDeErrorCaracteres(), "Caracteres inválidos detectados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim np As New N_Paciente
            PacienteBuscar.Estado = New E_Estado With {.Nombre = txtEstado.Text}
            Dim res = np.RegistrarEstado(PacienteBuscar)
            Select Case res
                Case -1
                    MessageBox.Show(MensajeDeErrorConexion(), "Hay errores en la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case -2
                    MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error efectuando acción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 1
                    MessageBox.Show("Estado actualizado con éxito.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        End If
    End Sub

    Private Sub btnVerConsulta_Click(sender As Object, e As EventArgs) Handles btnVerConsulta.Click
        'abrir en una nueva ventana
    End Sub
End Class