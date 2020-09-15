Imports System.Drawing
Imports System.Windows.Forms
Imports Entidades
Public Module mdlUtilsFormularios

    Public Function ColorTOHTML(col As Color) As String 'XMLSerializer no puede guardar System.Drawing.Color

        Return ColorTranslator.ToHtml(col)

    End Function

    Public Function HTMLTOColor(col As String) As Color
        Return ColorTranslator.FromHtml(col)
    End Function

    Public Sub BuscarPreguntas(contenedor As Control, ListaPreguntasYRespuestas As List(Of PreguntaRespuesta))

        For Each c As Control In contenedor.Controls
            Select Case c.GetType
                Case GetType(Panel), GetType(GroupBox), GetType(TableLayoutPanel)
                    UnirPreguntasConRespuestas(c, ListaPreguntasYRespuestas)
                Case Else
                    If Not String.IsNullOrEmpty(c.Tag) Then
                        Select Case c.GetType() 'primero guardo preguntas
                            Case GetType(Label) 'sabemos q label es el unico control que guarda solo preguntas
                                If c.Tag.StartsWith("p") Then
                                    Console.WriteLine("Pregunta: " & c.Tag)
                                    ListaPreguntasYRespuestas.Add(New PreguntaRespuesta(c.Tag, c))
                                End If
                            Case GetType(CheckBox) 'checkbox guarda pregunta y respuesta en el mismo.
                                If c.Tag.StartsWith("p") Then
                                    Console.WriteLine("PreguntaYrespuesta: " & c.Tag)
                                    ListaPreguntasYRespuestas.Add(New PreguntaRespuesta(c.Tag, c, c))
                                End If
                        End Select
                    End If

            End Select
        Next

    End Sub
    Public Sub UnirPreguntasConRespuestas(contenedor As Control, ListaPreguntasYRespuestas As List(Of PreguntaRespuesta))

        For Each c As Control In contenedor.Controls
            Select Case c.GetType
                Case GetType(Panel), GetType(GroupBox), GetType(TableLayoutPanel)
                    UnirPreguntasConRespuestas(c, ListaPreguntasYRespuestas)
                Case Else
                    If Not String.IsNullOrEmpty(c.Tag) Then
                        Select Case c.GetType() 'primero guardo preguntas
                            Case GetType(TextBox), GetType(ComboBox) 'sabemos q label es el unico control que guarda solo preguntas
                                If c.Tag.StartsWith("p") Then
                                    Console.WriteLine("Respuesta: " & c.Tag)
                                    ListaPreguntasYRespuestas.Find(Function(p) p.Tag = c.Tag).Respuesta = c
                                End If
                        End Select
                    End If

            End Select
        Next

    End Sub

End Module
