Imports Entidades
Imports Utilidades
Public Class Identificacion_Paciente
    Protected _paciente As New E_Paciente
    Protected _modo As New Modo

    Public Enum Modo
        AgregarAListaHoy
        MedicoAtiende
    End Enum

    Property ModoActual As Modo
        Get
            Return _modo
        End Get
        Set(value As Modo)
            _modo = value
        End Set
    End Property
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

    Sub configurarControles()
        Select Case ModoActual
            Case Modo.AgregarAListaHoy 'pedir CI y poner en botones "agregar a listado"
                btnEntrevistar.Text = "Agregar a listado"
                btnEntrevistar.ImageIndex = 1
                btnConsultasPrevias.Visible = False
                tblAcciones.SetRow(txtMotivoC, 0)
                tblAcciones.SetRow(btnConsultasPrevias, 2)
                tblAcciones.SetRow(btnEntrevistar, 1)
                txtMotivoC.Visible = True
                txtMotivoC.Multiline = True
            Case Modo.MedicoAtiende 'pedir CI y poner en botones "atender, ver consultas previas"
                btnEntrevistar.Text = "Atender"
                btnConsultasPrevias.Visible = True
                btnEntrevistar.ImageIndex = 0
                txtMotivoC.Anchor += AnchorStyles.Bottom
                txtMotivoC.Anchor += AnchorStyles.Right
                tblAcciones.SetRow(txtMotivoC, 2)
                tblAcciones.SetRow(btnEntrevistar, 0)
                tblAcciones.SetRow(btnConsultasPrevias, 1)
                txtMotivoC.Visible = False
        End Select
    End Sub

End Class