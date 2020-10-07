Imports Entidades
Imports Negocio
Imports Utilidades
Public Class frmGestionMedico
    Protected _mimodo As frmMedico.Modo
    Protected _medico As E_Medico
    Protected _auxiliar As E_Usuario
    Private nm As New N_Medico
    Private na As New N_Auxiliar
    Property MedicoLogeado As E_Medico
        Get
            Return _medico
        End Get
        Set(value As E_Medico)
            _medico = value
        End Set
    End Property

    Property AuxiliarLogeado As E_Usuario
        Get
            Return _auxiliar
        End Get
        Set(value As E_Usuario)
            _auxiliar = value
        End Set
    End Property
    Property MiModo As frmMedico.Modo
        Get
            Return _mimodo
        End Get
        Set(value As frmMedico.Modo)
            _mimodo = value
        End Set
    End Property
    Private Async Sub frmGestionMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case MiModo
            Case frmMedico.Modo.SoyAuxiliar
                AuxiliarLogeado = Await Task.Run(Function() na.BuscarAuxiliarCI(AuxiliarLogeado.Cedula))
                AuxiliarLogeado.Foto = Await Task.Run(Function() nm.LeerFoto(AuxiliarLogeado.Cedula))
                bindPropsAuxiliar()
            Case frmMedico.Modo.SoyMedico
                MedicoLogeado = Await Task.Run(Function() nm.BuscarMedicoCI(MedicoLogeado.Cedula))
                MedicoLogeado.Foto = Await Task.Run(Function() nm.LeerFoto(MedicoLogeado.Cedula))
                bindPropsMedico()
        End Select

    End Sub

    Sub bindPropsMedico()
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
        lblEspecialidadTXT.Text = ""
        For Each es As String In MedicoLogeado.Especialidad
            If Not es Is MedicoLogeado.Especialidad.Last() Then
                lblEspecialidadTXT.Text &= es & ", "
            Else
                lblEspecialidadTXT.Text &= es
            End If
        Next
        lblEspecialidadTXT.Visible = True
    End Sub

    Sub bindPropsAuxiliar()
        lblCedulaTXT.Text = AuxiliarLogeado.Cedula

        If AuxiliarLogeado.Nombre2 IsNot String.Empty Then
            lblNombresTXT.Text = String.Format("{0}, {1}", AuxiliarLogeado.Nombre1, AuxiliarLogeado.Nombre2)
        Else
            lblNombresTXT.Text = AuxiliarLogeado.Nombre1
        End If

        If Not AuxiliarLogeado.Apellido2 Is String.Empty Then
            lblApellidosTXT.Text = String.Format("{0}, {1}", AuxiliarLogeado.Apellido1, AuxiliarLogeado.Apellido2)
        Else
            lblApellidosTXT.Text = MedicoLogeado.Apellido1
        End If

        lblDireccionTXT.Text = String.Format("{0}, {1}", AuxiliarLogeado.Direccion_Calle, AuxiliarLogeado.Direccion_Numero)

        pBoxFotoMedico.Image = Bytes2Image(AuxiliarLogeado.Foto)

        lblTelefonoTXT.Text = ""
        For Each t As String In AuxiliarLogeado.TelefonosLista
            If Not t Is AuxiliarLogeado.TelefonosLista.Last() Then
                lblTelefonoTXT.Text &= t & ", "
            Else
                lblTelefonoTXT.Text &= t
            End If

        Next
        lblEspecialidadTXT.Visible = False
    End Sub
End Class