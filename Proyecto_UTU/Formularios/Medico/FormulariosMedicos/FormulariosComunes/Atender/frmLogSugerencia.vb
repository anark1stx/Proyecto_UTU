Imports Entidades
Imports Sugerencia
Imports System.ComponentModel
Public Class frmLogSugerencia
    Protected _modo As New ASugerir
    Property PreguntasYRespuestas As New List(Of PreguntaRespuesta)
    Property Sintomas As New List(Of E_Sintoma)
    Property SignosClinicos As New List(Of E_SignoClinico)
    Property Enfermedad As E_Enfermedad
    Property Modo As ASugerir
        Get
            Return _modo
        End Get
        Set(value As ASugerir)
            _modo = value
        End Set
    End Property
    Public Enum ASugerir
        Enfermedad
        Analisis
        Tratamiento
    End Enum

    Private Sub Sugerencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetBounds(0, 0, Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height)
        Me.MaximizeBox = False
        Select Case Modo
            Case ASugerir.Enfermedad
                Dim sugerir As New Sugerir(PreguntasYRespuestas, Sintomas, SignosClinicos)
                lbLog.DataSource = sugerir.Log
                sugerir.SugerirEnfermedad()
                Console.WriteLine(sugerir.Log().ToArray().ToString())
            Case ASugerir.Analisis
                Dim sugerir As New Sugerir(PreguntasYRespuestas, Sintomas, SignosClinicos, Enfermedad)
                lbLog.DataSource = sugerir.Log
                sugerir.SugerirAnalisis()
            Case ASugerir.Tratamiento
                Dim sugerir As New Sugerir(PreguntasYRespuestas, Sintomas, SignosClinicos, Enfermedad)
                lbLog.DataSource = sugerir.Log
                sugerir.SugerirTratamiento()
        End Select
    End Sub
End Class