Imports Entidades
Public Class Identificacion_Paciente
    Protected _paciente As New E_Paciente

    Property PacienteBuscar As E_Paciente
        Get
            Return _paciente
        End Get
        Set(value As E_Paciente)
            _paciente = value
        End Set
    End Property

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
        pBoxFotoPaciente.ImageLocation = PacienteBuscar.Foto

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

End Class