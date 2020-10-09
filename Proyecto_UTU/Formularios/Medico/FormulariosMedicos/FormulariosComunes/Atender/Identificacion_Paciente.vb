Imports Entidades
Imports Utilidades
Public Class Identificacion_Paciente
    Protected _paciente As New E_Paciente
    Protected _consulta As New E_Atiende
    Protected _consultas_previas As New List(Of E_Atiende)
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

    Sub CargarConsultas()
        Select Case ConsultasPrevias(0).ID
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
        lblEtapaTXT.Text = PacienteBuscar.Etapa
        pBoxFotoPaciente.Image = Bytes2Image(PacienteBuscar.Foto)

        lblTelefonoTXT.Text = ""
        For Each t As String In PacienteBuscar.TelefonosLista
            If Not t Is PacienteBuscar.TelefonosLista.Last() Then
                lblTelefonoTXT.Text &= t & ", "
            Else
                lblTelefonoTXT.Text &= t
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
End Class