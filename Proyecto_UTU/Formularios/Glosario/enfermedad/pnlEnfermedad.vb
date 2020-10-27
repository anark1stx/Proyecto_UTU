Imports Entidades
Imports Utilidades
Imports Negocio
Public Class pnlEnfermedad

    Protected _modo As frmGlosarioContenedor.Modo
    Protected _enfermedad As New E_Enfermedad

    Property Enfermedad As E_Enfermedad
        Get
            Return _enfermedad
        End Get
        Set(value As E_Enfermedad)
            _enfermedad = value
        End Set
    End Property
    Property Modo As frmGlosarioContenedor.Modo
        Get
            Return _modo
        End Get
        Set(value As frmGlosarioContenedor.Modo)
            _modo = value
            ConfigurarControles()
        End Set
    End Property

    Sub ConfigurarControles()
        Select Case Modo
            Case frmGlosarioContenedor.Modo.Consulta
                loopReadOnly(Me, True)
                btnAgregarSC.Visible = False
                btnAgregarSintoma.Visible = False
                txtSignoC.Visible = False
                txtSintomas.Visible = False
                btnGuardar.Enabled = False
        End Select
    End Sub

    Sub IngresarDatosEnf()

    End Sub

    Private Sub btnCategorizarEnfermedad_Click(sender As Object, e As EventArgs) Handles btnCategorizarEnfermedad.Click
        Dim frmCategoria As New frmCategoriaEnf With {.Modo = frmGlosarioContenedor.Modo.Ingreso}
    End Sub
End Class
