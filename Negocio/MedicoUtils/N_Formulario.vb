﻿Imports Entidades
Imports Datos
Public Class N_Formulario
    Dim objDatos As New D_Formulario

    Public Function AltaModFormulario(form As E_Formulario, altaomod As Boolean) As Integer
        Return objDatos.AltaModFormulario(form, altaomod)
    End Function
    Public Function BuscarFormularios(busqueda As String) As List(Of E_Formulario)
        Return objDatos.BuscarFormularios(busqueda)
    End Function

    Public Function BajaFormulario(form As E_Formulario) As Integer
        Return objDatos.BajaFormulario(form)
    End Function

    Public Function BuscarID_preguntas(pList As List(Of PreguntaRespuesta)) As Integer
        Return objDatos.CargarIDpregunta(pList)
    End Function

    Public Function AltaFormularioDatos(form As E_Formulario) As Integer
        Return objDatos.AltaFormularioDatos(form)
    End Function

    Public Function AltaPreguntas(form As E_Formulario) As Integer
        Return objDatos.AltaPreguntas(form)
    End Function

    Public Function AltaSugiereTratamiento(form As E_Formulario) As Integer
        Return objDatos.AltaSugiereTratamiento(form)
    End Function
    Public Function BuscarDiagnostico(ID_C As Integer) As E_Formulario
        Return objDatos.BuscarDiagnostico(ID_C)
    End Function
    Public Function AsignarAnalisisAPaciente(form As E_Formulario) As Integer
        Return objDatos.AsignarAnalisis(form)
    End Function
End Class
