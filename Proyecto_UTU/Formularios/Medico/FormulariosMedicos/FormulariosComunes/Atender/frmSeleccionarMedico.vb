Imports Entidades
Imports Utilidades
Public Class frmSeleccionarMedico
    Protected _medicoSelect As E_Medico

    Property MedicoSelect As E_Medico
        Get
            Return _medicoSelect
        End Get
        Set(value As E_Medico)
            _medicoSelect = value
        End Set
    End Property

    Sub PoblarDatos()
        txtCIMedico.Text = MedicoSelect.Cedula

        If MedicoSelect.Nombre2 IsNot String.Empty Then
            lblNombresTXT.Text = String.Format("{0}, {1}", MedicoSelect.Nombre1, MedicoSelect.Nombre2)
        Else
            lblNombresTXT.Text = MedicoSelect.Nombre1
        End If

        If Not MedicoSelect.Apellido2 Is String.Empty Then
            lblApellidosTXT.Text = String.Format("{0}, {1}", MedicoSelect.Apellido1, MedicoSelect.Apellido2)
        Else
            lblApellidosTXT.Text = MedicoSelect.Apellido1
        End If


        pBoxFotoMedico.Image = Bytes2Image(MedicoSelect.Foto)

        lblEspecialidadTXT.Text = ""
        For Each es As String In MedicoSelect.Especialidad
            If Not es Is MedicoSelect.Especialidad.Last() Then
                lblEspecialidadTXT.Text &= es & ", "
            Else
                lblEspecialidadTXT.Text &= es
            End If
        Next
    End Sub

End Class