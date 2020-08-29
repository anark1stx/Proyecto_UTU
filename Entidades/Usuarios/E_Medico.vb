﻿Public Class E_Medico
    Inherits E_Usuario

    Protected _especialidades As List(Of String)

    Property Especialidad() As List(Of String)
        Get
            Return (_especialidades)
        End Get
        Set(ByVal value As List(Of String))
            _especialidades = value
        End Set
    End Property
    Sub New()

    End Sub

    Sub New(cedula As Integer, nombre1 As String, nombre2 As String, apellido1 As String, apellido2 As String, direccion As List(Of String), telefonosLista As List(Of String), correo As String, contrasena As String, especialidades As List(Of String), foto As Byte())
        _cedula = cedula
        _nombre1 = nombre1
        _nombre2 = nombre2
        _apellido1 = apellido1
        _apellido2 = apellido2
        _correo = correo
        _contrasena = contrasena
        _telefonosLista = telefonosLista
        _direccion = direccion
        _especialidades = especialidades
        _foto = foto
    End Sub



End Class