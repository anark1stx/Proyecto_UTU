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
        Return negocio.AltaFormularioDatos(form)
    End Function

    Function GuardarDatosTratamiento(tratamiento As E_Tratamiento) As Integer
        Dim negocio As New N_Tratamiento
        Return negocio.AltaTratamientoDatos(tratamiento)
    End Function

    Function GuardarDatosAnalisis(analisis As E_Analisis) As Integer
        Dim negocio As New N_Analisis
        Return negocio.AltaAnalisisDatos(analisis)
    End Function

End Module
