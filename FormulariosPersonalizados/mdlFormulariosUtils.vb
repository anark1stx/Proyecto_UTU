Imports Entidades
Imports Negocio
Imports System.Windows.Forms
Public Module mdlFormulariosUtils
    Function ConvertirFormulario(form As E_Formulario) As List(Of Control)
        Dim gestor As New GestorXMLv2
        Dim fbr As New FabricaDeControles()
        Dim lista = gestor.Deserializar(Of ControlesGuardados.ListaControles)(form.XML)

        Return fbr.Crear(lista)
    End Function

    Function GuardarDatosFormulario(form As E_Formulario) As Integer
        Dim negocio As New N_Formulario
        negocio.AltaFormularioDatos(form)
    End Function

End Module
