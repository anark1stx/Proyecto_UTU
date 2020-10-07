Imports Utilidades
Imports Entidades
Public Class TarjetaPaciente
    Protected _mientrevista As New E_Atiende
    Property MiEntrevista As E_Atiende
        Get
            Return _mientrevista
        End Get
        Set(value As E_Atiende)
            _mientrevista = value
        End Set
    End Property
    Private Sub TarjetaPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = pickRandomColor()
        If Not MiEntrevista Is Nothing Then
            pboxFotoPaciente.BackgroundImage = Bytes2Image(MiEntrevista.Paciente.Foto)
            lblCIPaciente.Text = MiEntrevista.Paciente.Cedula
            lblNomAp.Text = MiEntrevista.Paciente.Nombre1 & " " & MiEntrevista.Paciente.Nombre2 & " " & MiEntrevista.Paciente.Apellido1 & " " & MiEntrevista.Paciente.Apellido2
            lblSexo.Text = MiEntrevista.Paciente.Sexo
            txtMotivo.Text = MiEntrevista.Motivo
            txtMotivo.ReadOnly = True
        Else
        End If
    End Sub
End Class
