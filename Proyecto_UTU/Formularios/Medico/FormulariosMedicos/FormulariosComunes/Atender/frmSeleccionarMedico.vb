﻿Imports Entidades
Imports Utilidades
Public Class frmSeleccionarMedico
    Protected _medicoSelect As New E_Medico
    Protected _nombreConsulta As String 'no se va a guardar en entrevistainicial, queda guardado en Atiende, nosotros aca lo persistimos nomas
    Property MedicoSelect As E_Medico
        Get
            Return _medicoSelect
        End Get
        Set(value As E_Medico)
            _medicoSelect = value
        End Set
    End Property

    Property NombreConsulta As String
        Get
            Return _nombreConsulta
        End Get
        Set(value As String)
            _nombreConsulta = value
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

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If MedicoSelect.Cedula = 0 Then
            MessageBox.Show("No fue seleccionado ningún médico. Luego de ingresar su cédula presione el botón de buscar.", "No se seleccionó un médico.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            If Not check_Largo(txtNomConsulta.Text, 5, 120, True) Then
                MessageBox.Show(MensajeDeErrorLongitud(5, 120), "Información inválida.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Not check_regex(txtNomConsulta.Text, RegexLiteralAcentos) Then
                MessageBox.Show(MensajeDeErrorCaracteres(), "Se detectaron caracteres inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Me.Hide() 'si esta todo bien
        End If
    End Sub

    Private Sub txtCIMedico_TextChanged(sender As Object, e As EventArgs) Handles txtCIMedico.TextChanged

        If txtCIMedico.TextLength < 8 Then
            LimpiarControles(Me)
            MedicoSelect.Cedula = 0
        End If
    End Sub
End Class