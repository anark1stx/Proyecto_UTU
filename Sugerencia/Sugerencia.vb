Imports System.Windows.Forms.Control
Imports System.ComponentModel
Imports Entidades
Imports Negocio
Public Class Sugerir
    Protected _log As New BindingList(Of String) 'guardar cada accion que haga esta clase
    Protected _preguntasyrespuestas As New List(Of PreguntaRespuesta)
    Protected _sintomas As New List(Of E_Sintoma)
    Protected _signos_clinicos As New List(Of E_SignoClinico)
    Protected _enfermedad As New E_Enfermedad
    Protected _emitir As Boolean = False
    Private ne As New N_Enfermedad
    Private na As New N_Analisis
    Private nt As New N_Tratamiento
    Property PreguntasYRespuestas As List(Of PreguntaRespuesta)
        Get
            Return _preguntasyrespuestas
        End Get
        Set(value As List(Of PreguntaRespuesta))
            _preguntasyrespuestas = value
        End Set
    End Property

    Property Sintomas As List(Of E_Sintoma)
        Get
            Return _sintomas
        End Get
        Set(value As List(Of E_Sintoma))
            _sintomas = value
        End Set
    End Property

    Property SignosClinicos As List(Of E_SignoClinico)
        Get
            Return _signos_clinicos
        End Get
        Set(value As List(Of E_SignoClinico))
            _signos_clinicos = value
        End Set
    End Property

    Property Enfermedad As E_Enfermedad
        Get
            Return _enfermedad
        End Get
        Set(value As E_Enfermedad)
            _enfermedad = value
        End Set
    End Property

    Property Emitir As Boolean
        Get
            Return _emitir
        End Get
        Set(value As Boolean)
            _emitir = value
        End Set
    End Property

    Property Log As BindingList(Of String)
        Get
            Return _log
        End Get
        Set(value As BindingList(Of String))
            _log = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(pyrList As List(Of PreguntaRespuesta), sintomas As List(Of E_Sintoma), signosclinicos As List(Of E_SignoClinico))
        _preguntasyrespuestas = pyrList
        _sintomas = sintomas
        _signos_clinicos = signosclinicos
    End Sub

    Sub New(pyrList As List(Of PreguntaRespuesta), sintomas As List(Of E_Sintoma), signosclinicos As List(Of E_SignoClinico), enfermedad As E_Enfermedad)
        _preguntasyrespuestas = pyrList
        _sintomas = sintomas
        _signos_clinicos = signosclinicos
        _enfermedad = enfermedad
    End Sub

    Sub SugerirEnfermedad() 'respuestas a preguntas, sintomas, signosclinicos
        Emitir = False
        Dim posibles_enfermedades As New List(Of E_Enfermedad)
        Log.Add("---------SUGESTOR DE DIAGNÓSTICO---------" & Environment.NewLine)
        Log.Add("Recibiendo información..." & Environment.NewLine)
        Log.Add("Leyendo síntomas..." & Environment.NewLine)
        If Sintomas.Count < 1 Then
            Log.Add("No fueron registrados síntomas. Procure proporcionar la mayor cantidad de información posible para que el sistema sea más preciso :)." & Environment.NewLine)
        End If
        For Each s As E_Sintoma In Sintomas
            Log.Add(String.Format("Síntoma registrado: {0}" & Environment.NewLine, s.Nombre))
            Log.Add(String.Format("Buscando enfermedad más diagnosticadas para el síntoma {0}...: " & Environment.NewLine, s.Nombre))
            Dim enf = ne.SugerirEnfermedadSegunSintomas(s)
            Select Case enf.ErrCode
                Case -1, -2
                    Log.Add("Error consultando, abortando." & Environment.NewLine)

                    Exit Sub
                Case -8
                    Log.Add("No se encontraron enfermedades diagnosticadas con este síntoma." & Environment.NewLine)
                Case 1
                    Log.Add("Enfermedad encontrada: " & enf.Nombre & Environment.NewLine)
                    posibles_enfermedades.Add(enf)
            End Select
        Next

        Log.Add("Leyendo signos clínicos..." & Environment.NewLine)
        If SignosClinicos.Count < 1 Then
            Log.Add("No fueron registrados signos clínicos. Procure proporcionar la mayor cantidad de información posible para que el sistema sea más preciso :)." & Environment.NewLine)
        End If
        For Each s As E_SignoClinico In SignosClinicos
            Log.Add(String.Format("Signo clínico registrado: {0}" & Environment.NewLine, s.Nombre))
            Log.Add(String.Format("Buscando enfermedades diagnosticadas para el signo clínico {0}...: " & Environment.NewLine, s.Nombre))
            Dim enf = ne.SugerirEnfermedadSegunSignosC(s)
            Select Case enf.ErrCode
                Case -1, -2
                    Log.Add("Error consultando, abortando." & Environment.NewLine)

                    Exit Sub
                Case -8
                    Log.Add("No se encontraron enfermedades diagnosticadas con este signo clínico." & Environment.NewLine)
                Case 1
                    Log.Add("Enfermedad encontrada: " & enf.Nombre & Environment.NewLine)
                    posibles_enfermedades.Add(enf)
            End Select
        Next

        Log.Add("Leyendo respuestas a preguntas..." & Environment.NewLine)
        If PreguntasYRespuestas.Count < 1 Then
            Log.Add("No fueron respondidas las preguntas del formulario. Procure proporcionar la mayor cantidad de información posible para que el sistema sea más preciso :)." & Environment.NewLine)
        End If
        For Each pyr As PreguntaRespuesta In PreguntasYRespuestas
            Log.Add(String.Format("Pregunta: {0}" & Environment.NewLine, pyr.Pregunta.Text))
            Log.Add(String.Format("Buscando enfermedades diagnosticadas en base a la respuesta ''{0}'' a la pregunta ''{1}''...: " & Environment.NewLine, pyr.Respuesta.Text, pyr.Pregunta.Text))
            Dim enf = ne.SugerirEnfermedadSegunPyR(pyr)
            Select Case enf.ErrCode
                Case -1, -2
                    Log.Add("Error consultando, abortando." & Environment.NewLine)

                    Exit Sub
                Case -8
                    Log.Add("No se encontraron enfermedades diagnosticadas con esta respuesta a esa pregunta." & Environment.NewLine)
                Case 1
                    Log.Add("Enfermedad encontrada: " & enf.Nombre & Environment.NewLine)
                    posibles_enfermedades.Add(enf)
            End Select
        Next
        Dim enfermedades_prob = From enfermedad In posibles_enfermedades
                                Group enfermedad By enfermedad.Nombre
                                Into enfs = Group
                                Let Probabilidad = Math.Round((enfs.Count() * 100) / posibles_enfermedades.Count, 2)
                                Order By Probabilidad Descending Select New With {Nombre, Probabilidad}
        If enfermedades_prob.Count < 1 Then
            Log.Add("No fue encontrada una enfermedad.")
            Exit Sub
        End If
        Log.Add("|Enfermedad : Probabilidad|" & Environment.NewLine)
        For Each enf In enfermedades_prob
            Log.Add(String.Format("{0} : {1}%" & Environment.NewLine, enf.Nombre, enf.Probabilidad))
        Next
    End Sub

    Sub SugerirAnalisis() 'segun todo + enfermedad si es posible
        Emitir = False
        Dim posibles_analisis As New List(Of E_Analisis)
        Log.Add("---------SUGESTOR DE ANÁLISIS---------" & Environment.NewLine)
        Log.Add("Recibiendo información..." & Environment.NewLine)
        Log.Add("Leyendo síntomas..." & Environment.NewLine)
        If Sintomas.Count < 1 Then
            Log.Add("No fueron registrados síntomas. Procure proporcionar la mayor cantidad de información posible para que el sistema sea más preciso :)." & Environment.NewLine)
        End If
        For Each s As E_Sintoma In Sintomas
            Log.Add(String.Format("Síntoma registrado: {0}" & Environment.NewLine, s.Nombre))
            Log.Add(String.Format("Buscando análisis requeridos para el síntoma {0}...: " & Environment.NewLine, s.Nombre))
            Dim analisis = na.SugerirAnalisisSegunSintomas(s)
            Select Case analisis.ErrCode
                Case -1, -2
                    Log.Add("Error consultando, abortando." & Environment.NewLine)

                    Exit Sub
                Case -8
                    Log.Add("No se encontraron análisis requeridos para este síntoma." & Environment.NewLine)
                Case 1
                    Log.Add("Análisis encontrado: " & analisis.Nombre & Environment.NewLine)
                    posibles_analisis.Add(analisis)
            End Select
        Next

        Log.Add("Leyendo signos clínicos..." & Environment.NewLine)
        If SignosClinicos.Count < 1 Then
            Log.Add("No fueron registrados signos clínicos. Procure proporcionar la mayor cantidad de información posible para que el sistema sea más preciso :)." & Environment.NewLine)
        End If
        For Each s As E_SignoClinico In SignosClinicos
            Log.Add(String.Format("Signo clínico registrado: {0}" & Environment.NewLine, s.Nombre))
            Log.Add(String.Format("Buscando análisis requeridos para el signo clínico {0}...: ", s.Nombre))
            Dim analisis = na.SugerirAnalisisSegunSignosC(s)
            Select Case analisis.ErrCode
                Case -1, -2
                    Log.Add("Error consultando, abortando." & Environment.NewLine)

                    Exit Sub
                Case -8
                    Log.Add("No se encontraron análisis requeridos para este signo clinico." & Environment.NewLine)
                Case 1
                    Log.Add("Análisis encontrada: " & analisis.Nombre & Environment.NewLine)
                    posibles_analisis.Add(analisis)
            End Select
        Next

        Log.Add("Leyendo respuestas a preguntas..." & Environment.NewLine)
        If PreguntasYRespuestas.Count < 1 Then
            Log.Add("No fueron respondidas las preguntas del formulario. Procure proporcionar la mayor cantidad de información posible para que el sistema sea más preciso :)." & Environment.NewLine)
        End If
        For Each pyr As PreguntaRespuesta In PreguntasYRespuestas
            Log.Add(String.Format("Pregunta: {0}", pyr.Pregunta.Text))
            Log.Add(String.Format("Buscando análisis requeridos en base a la respuesta ''{0}'' a la pregunta ''{1}''...: " & Environment.NewLine, pyr.Respuesta.Text, pyr.Pregunta.Text))
            Dim analisis = na.SugerirAnalisisSegunPyR(pyr)
            Select Case analisis.ErrCode
                Case -1, -2
                    Log.Add("Error consultando, abortando." & Environment.NewLine)

                    Exit Sub
                Case -8
                    Log.Add("No se encontraron análisis requeridos con esta respuesta a esa pregunta." & Environment.NewLine)
                Case 1
                    Log.Add("Análisis encontrado: " & analisis.Nombre & Environment.NewLine)
                    posibles_analisis.Add(analisis)
            End Select
        Next

        Log.Add("Leyendo enfermedad diagnosticada..." & Environment.NewLine)
        If String.IsNullOrWhiteSpace(Enfermedad.Nombre) Then
            Log.Add("No fue registrada una enfermedad." & Environment.NewLine)
        Else
            Log.Add(String.Format("Buscando análisis requeridos para la enfermedad ''{0}''...: " & Environment.NewLine, Enfermedad.Nombre))
            Dim analisis = na.SugerirAnalisisSegunEnfermedad(Enfermedad)
            Select Case analisis.ErrCode
                Case -1, -2
                    Log.Add("Error consultando, abortando." & Environment.NewLine)

                    Exit Sub
                Case -8
                    Log.Add("No se encontraron análisis requeridos para esa enfermedad." & Environment.NewLine)
                Case 1
                    Log.Add("Análisis encontrado: " & analisis.Nombre & Environment.NewLine)
                    posibles_analisis.Add(analisis)
            End Select
        End If

        Dim analisis_prob = From analisis In posibles_analisis
                            Group analisis By analisis.Nombre
                            Into anlss = Group
                            Let Probabilidad = Math.Round((anlss.Count() * 100) / posibles_analisis.Count, 2)
                            Order By Probabilidad Descending Select New With {Nombre, Probabilidad}
        If analisis_prob.Count < 1 Then
            Log.Add("No fue encontrado un análisis.")
            Exit Sub
        End If
        Log.Add("|Análisis : Recomendación% |" & Environment.NewLine)
        For Each an In analisis_prob
            Log.Add(String.Format("{0} : {1}%" & Environment.NewLine, an.Nombre, an.Probabilidad))
        Next

    End Sub

    Sub SugerirTratamiento() 'segun todo + enfermedad si es posible
        Emitir = False
        Dim posibles_tratamientos As New List(Of E_Tratamiento)
        Log.Add("---------SUGESTOR DE TRATAMIENTOS---------" & Environment.NewLine)
        Log.Add("Recibiendo información..." & Environment.NewLine)
        Log.Add("Leyendo síntomas..." & Environment.NewLine)
        If Sintomas.Count < 1 Then
            Log.Add("No fueron registrados síntomas. Procure proporcionar la mayor cantidad de información posible para que el sistema sea más preciso :)." & Environment.NewLine)
        End If
        For Each s As E_Sintoma In Sintomas
            Log.Add(String.Format("Síntoma registrado: {0}" & Environment.NewLine, s.Nombre))
            Log.Add(String.Format("Buscando tratamientos sugeridos para el síntoma {0}...: " & Environment.NewLine, s.Nombre))
            Dim tratamiento = nt.SugerirTratamientoSegunSintomas(s)
            Select Case tratamiento.ErrCode
                Case -1, -2
                    Log.Add("Error consultando, abortando." & Environment.NewLine)

                    Exit Sub
                Case -8
                    Log.Add("No se encontraron tratamientos sugeridos para este síntoma." & Environment.NewLine)
                Case 1
                    Log.Add("Tratamiento encontrado: " & tratamiento.Nombre & Environment.NewLine)
                    posibles_tratamientos.Add(tratamiento)
            End Select
        Next

        Log.Add("Leyendo signos clínicos..." & Environment.NewLine)
        If SignosClinicos.Count < 1 Then
            Log.Add("No fueron registrados signos clínicos. Procure proporcionar la mayor cantidad de información posible para que el sistema sea más preciso :)." & Environment.NewLine)
        End If
        For Each s As E_SignoClinico In SignosClinicos
            Log.Add(String.Format("Signo clínico registrado: {0}" & Environment.NewLine, s.Nombre))
            Log.Add(String.Format("Buscando tratamientos sugeridos para el signo clínico {0}...: " & Environment.NewLine, s.Nombre))
            Dim tratamiento = nt.SugerirTratamientoSegunSignosC(s)
            Select Case tratamiento.ErrCode
                Case -1, -2
                    Log.Add("Error consultando, abortando." & Environment.NewLine)

                    Exit Sub
                Case -8
                    Log.Add("No se encontraron tratamientos sugeridos para este signo clinico." & Environment.NewLine)
                Case 1
                    Log.Add("Tratamiento encontrado: " & tratamiento.Nombre & Environment.NewLine)
                    posibles_tratamientos.Add(tratamiento)
            End Select
        Next

        Log.Add("Leyendo respuestas a preguntas..." & Environment.NewLine)
        If PreguntasYRespuestas.Count < 1 Then
            Log.Add("No fueron respondidas las preguntas del formulario. Procure proporcionar la mayor cantidad de información posible para que el sistema sea más preciso :)." & Environment.NewLine)
        End If
        For Each pyr As PreguntaRespuesta In PreguntasYRespuestas
            Log.Add(String.Format("Pregunta: {0}" & Environment.NewLine, pyr.Pregunta.Text))
            Log.Add(String.Format("Buscando tratamientos sugeridos en base a la respuesta ''{0}'' a la pregunta ''{1}''...: " & Environment.NewLine, pyr.Respuesta.Text, pyr.Pregunta.Text))
            Dim tratamiento = nt.SugerirTratamientoSegunPyR(pyr)
            Select Case tratamiento.ErrCode
                Case -1, -2
                    Log.Add("Error consultando, abortando." & Environment.NewLine)

                    Exit Sub
                Case -8
                    Log.Add("No se encontraron tratamientos sugeridos con esta respuesta a esa pregunta." & Environment.NewLine)
                Case 1
                    Log.Add("Tratamiento encontrado: " & tratamiento.Nombre & Environment.NewLine)
                    posibles_tratamientos.Add(tratamiento)
            End Select
        Next

        Log.Add("Leyendo enfermedad diagnosticada..." & Environment.NewLine)
        If String.IsNullOrWhiteSpace(Enfermedad.Nombre) Then
            Log.Add("No fue registrada una enfermedad." & Environment.NewLine)
        Else
            Log.Add(String.Format("Buscando tratamientos sugeridos para la enfermedad ''{0}''...: " & Environment.NewLine, Enfermedad.Nombre))
            Dim tratamiento = nt.SugerirTratamientoSegunEnfermedad(Enfermedad)
            Select Case tratamiento.ErrCode
                Case -1, -2
                    Log.Add("Error consultando, abortando." & Environment.NewLine)

                    Exit Sub
                Case -8
                    Log.Add("No se encontraron tratamientos requeridos para esa enfermedad." & Environment.NewLine)
                Case 1
                    Log.Add("Tratamiento encontrado: " & tratamiento.Nombre & Environment.NewLine)
                    posibles_tratamientos.Add(tratamiento)
            End Select
        End If
        Dim tratamiento_prob = From tratamiento In posibles_tratamientos
                               Group tratamiento By tratamiento.Nombre
                               Into trts = Group
                               Let Probabilidad = Math.Round((trts.Count() * 100) / posibles_tratamientos.Count, 2)
                               Order By Probabilidad Descending Select New With {Nombre, Probabilidad}
        If tratamiento_prob.Count < 1 Then
            Log.Add("No fue encontrado un tratamiento.")
            Exit Sub
        End If
        Log.Add("|Tratamiento : Recomendación%|" & Environment.NewLine)
        For Each tr In tratamiento_prob
            Log.Add(String.Format("{0} : {1}%" & Environment.NewLine, tr.Nombre, tr.Probabilidad))
        Next

    End Sub

End Class
