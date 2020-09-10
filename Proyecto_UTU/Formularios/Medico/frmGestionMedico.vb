Imports Entidades
Imports Negocio
Imports Utilidades
Public Class frmGestionMedico

    Protected _medico As E_Medico
    Private nm As New N_Medico

    Property MedicoLogeado As E_Medico
        Get
            Return _medico
        End Get
        Set(value As E_Medico)
            _medico = value
        End Set
    End Property

    Private Async Sub frmGestionMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MedicoLogeado = Await Task.Run(Function() nm.ListarMedicoCI(MedicoLogeado.Cedula))
        MedicoLogeado.Foto = Await Task.Run(Function() nm.LeerFoto(MedicoLogeado.Cedula))
        bindProps()
    End Sub

    Sub bindProps()
        lblCedulaTXT.Text = MedicoLogeado.Cedula

        If MedicoLogeado.Nombre2 IsNot String.Empty Then
            lblNombresTXT.Text = String.Format("{0}, {1}", MedicoLogeado.Nombre1, MedicoLogeado.Nombre2)
        Else
            lblNombresTXT.Text = MedicoLogeado.Nombre1
        End If

        If Not MedicoLogeado.Apellido2 Is String.Empty Then
            lblApellidosTXT.Text = String.Format("{0}, {1}", MedicoLogeado.Apellido1, MedicoLogeado.Apellido2)
        Else
            lblApellidosTXT.Text = MedicoLogeado.Apellido1
        End If

        lblDireccionTXT.Text = String.Format("{0}, {1}", MedicoLogeado.Direccion_Calle, MedicoLogeado.Direccion_Numero)

        pBoxFotoMedico.Image = Bytes2Image(MedicoLogeado.Foto)

        lblTelefonoTXT.Text = ""
        For Each t As String In MedicoLogeado.TelefonosLista
            If Not t Is MedicoLogeado.TelefonosLista.Last() Then
                lblTelefonoTXT.Text &= t & ", "
            Else
                lblTelefonoTXT.Text &= t
            End If

        Next

        For Each es As String In MedicoLogeado.Especialidad
            If Not es Is MedicoLogeado.Especialidad.Last() Then
                lblEspecialidadTXT.Text &= es & ", "
            Else
                lblEspecialidadTXT.Text &= es
            End If
        Next

    End Sub
End Class