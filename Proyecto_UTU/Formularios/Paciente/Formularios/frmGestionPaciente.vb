Imports Entidades
Imports Negocio
Public Class frmGestionPaciente
    Protected _paciente As E_Paciente
    Private np As New N_Paciente

    Property PacienteLogeado As E_paciente
        Get
            Return _paciente
        End Get
        Set(value As E_paciente)
            _paciente = value
        End Set
    End Property

    Private Sub frmGestionPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PacienteLogeado = np.ListarPacienteCI(PacienteLogeado.Cedula)
        bindProps()
    End Sub

    Sub bindProps()
        lblCedulaTXT.Text = PacienteLogeado.Cedula

        If PacienteLogeado.Nombre2 IsNot String.Empty Then
            lblNombresTXT.Text = String.Format("{0}, {1}", PacienteLogeado.Nombre1, PacienteLogeado.Nombre2)
        Else
            lblNombresTXT.Text = PacienteLogeado.Nombre1
        End If

        If Not PacienteLogeado.Apellido2 Is String.Empty Then
            lblApellidosTXT.Text = String.Format("{0}, {1}", PacienteLogeado.Apellido1, PacienteLogeado.Apellido2)
        Else
            lblApellidosTXT.Text = PacienteLogeado.Apellido1
        End If

        lblDireccionTXT.Text = String.Format("{0}, {1}", PacienteLogeado.Direccion_Calle, PacienteLogeado.Direccion_Numero)
        lblFechaNacTXT.Text = PacienteLogeado.FechaNacimiento.ToString()
        lblOcupacionTXT.Text = PacienteLogeado.Ocupacion
        lblE_CivilTXT.Text = PacienteLogeado.Estado_civil
        lblEtapaTXT.Text = PacienteLogeado.Etapa
        pBoxFotoPaciente.ImageLocation = PacienteLogeado.Foto

        lblTelefonoTXT.Text = ""
        For Each t As String In PacienteLogeado.TelefonosLista
            If Not t Is PacienteLogeado.TelefonosLista.Last() Then
                lblTelefonoTXT.Text &= t & ", "
            Else
                lblTelefonoTXT.Text &= t
            End If

        Next

        Select Case PacienteLogeado.Sexo
            Case "M"
                lblSexoTXT.Text = "Masculino"
            Case "F"
                lblSexoTXT.Text = "Femenino"
        End Select

    End Sub


End Class