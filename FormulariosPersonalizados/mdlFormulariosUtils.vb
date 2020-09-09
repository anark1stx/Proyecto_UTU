Imports Entidades
Public Module mdlFormulariosUtils
    Function ConvertirFormulario(form As E_Formulario)
        Dim gestor As New GestorXMLv2
        Dim fbr As New FabricaDeControles()
        Dim lista = gestor.Deserializar(Of ControlesGuardados.ListaControles)(form.XML)

        Return fbr.Crear(lista)
    End Function
End Module
