Imports Utilidades
Imports Entidades
Public Class TarjetaPaciente
    Protected _miconsulta As New E_Atiende
    Property MiConsulta As E_Atiende
        Get
            Return _miconsulta
        End Get
        Set(value As E_Atiende)
            _miconsulta = value
        End Set
    End Property
    Private Sub TarjetaPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = pickRandomColor()
        If Not MiConsulta Is Nothing Then
            pboxFotoPaciente.BackgroundImage = Bytes2Image(MiConsulta.Paciente.Foto)
            lblCIPaciente.Text = MiConsulta.Paciente.Cedula
            lblNomAp.Text = MiConsulta.Paciente.Nombre1 & " " & MiConsulta.Paciente.Nombre2 & " " & MiEntrevista.Paciente.Apellido1 & " " & MiEntrevista.Paciente.Apellido2
            lblSexo.Text = MiConsulta.Paciente.Sexo
            txtMotivo.Text = MiConsulta.Motivo
            txtMotivo.ReadOnly = True
        Else
        End If
    End Sub
End Class
