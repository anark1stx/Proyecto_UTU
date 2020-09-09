Imports Entidades
Imports Utilidades
Public Class frmPresentacionFrm
    Protected _formulario
    Property Formulario As E_Formulario
        Get
            Return _formulario
        End Get
        Set(value As E_Formulario)
            _formulario = value
            lblNombreForm.Text = value.Nombre
            pBoxVistaPrevia.BackgroundImage = Bytes2Image(value.VistaPrevia)
        End Set
    End Property

End Class