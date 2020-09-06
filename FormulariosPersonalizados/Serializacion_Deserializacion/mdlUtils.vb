Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Public Module mdlUtils

    Public Function ColorTOHTML(col As Color) As String 'XMLSerializer no puede guardar System.Drawing.Color

        Return ColorTranslator.ToHtml(col)

    End Function

    Public Function HTMLTOColor(col As String) As Color
        Return ColorTranslator.FromHtml(col)
    End Function

    Public Sub BuscarPreguntasYRespuestas(contenedor As Control, ListaPreguntasYRespuestas As List(Of PreguntaRespuesta), Preguntas As List(Of Control), Respuestas As List(Of Control))

        For Each c As Control In contenedor.Controls
            Select Case c.GetType
                Case GetType(Panel), GetType(GroupBox), GetType(TableLayoutPanel)
                    BuscarPreguntasYRespuestas(c, ListaPreguntasYRespuestas, Preguntas, Respuestas)
                Case Else
                    If Not String.IsNullOrEmpty(c.Tag) Then

                        If c.Tag.StartsWith("pr") Then
                            Console.WriteLine("PreguntaYRespuesta!: " & c.Tag)
                            ListaPreguntasYRespuestas.Add(New PreguntaRespuesta(c, c))
                        ElseIf c.Tag.StartsWith("p") Then 'pregunta
                            Console.WriteLine("Pregunta: " & c.Tag)
                            Preguntas.Add(c)
                        ElseIf c.Tag.StartsWith("r") Then ' respuesta
                            Console.WriteLine("Respuesta: " & c.Tag)
                            Console.WriteLine("Respuesta: " & c.Text)
                            Respuestas.Add(c)
                        End If

                    End If
            End Select
        Next

    End Sub

    Public Sub UnirPreguntasYRespuestas(Preguntas As List(Of Control), Respuestas As List(Of Control), ListaPreguntasYRespuestas As List(Of PreguntaRespuesta))

        For Each p As Control In Preguntas
            Dim respuesta = Respuestas.Find(Function(r) r.Tag = p.Tag)
            If respuesta Is Nothing Then
                respuesta = Respuestas.Find(Function(r) r.Tag.ToString().Substring(1, r.Tag.ToString().Length - 1) = p.Tag.ToString().Substring(1, p.Tag.ToString().Length - 1))
            End If
            'Console.WriteLine("la respuesta en p es: " & respuesta.Text)
            ListaPreguntasYRespuestas.Add(New PreguntaRespuesta(p, respuesta))
        Next

        For Each pyr As PreguntaRespuesta In ListaPreguntasYRespuestas
            Select Case pyr.Pregunta.GetType()
                Case GetType(CheckBox)
                    Console.WriteLine("PreguntaYRespuestaFinal!!: " & DirectCast(pyr.Pregunta, CheckBox).Text & " " & DirectCast(pyr.Respuesta, CheckBox).Checked) 'Si es un CheckBox, sabemos que la pregunta es la propiedad Text, y que la respuesta es su propiedad Checked (verdadero o falso)
                Case Else
                    Try
                        Console.WriteLine("PreguntaYRespuestaFinal!!: " & pyr.Pregunta.Text & " " & pyr.Respuesta.Text)
                    Catch ex As Exception
                        Console.WriteLine("err")
                    End Try

            End Select

        Next

    End Sub
    Public Function ImportarFormulario() As List(Of Control)

        Dim abrirFormulario As New OpenFileDialog With { 'Sustituir esto por un catalogo con los formularios que hay en la BD.
            .Filter = "XML|*.xml",
            .Title = "Abrir Formulario",
            .RestoreDirectory = True
        }

        If abrirFormulario.ShowDialog() = DialogResult.OK Then
            Dim path As String = System.IO.Path.GetFullPath(abrirFormulario.FileName.ToString())
            Dim contenido As String = File.ReadAllText(path)
            Dim gestor As New GestorXMLv2
            Dim fbr As New FabricaDeControles()
            Dim lista = gestor.Deserializar(Of ControlesGuardados.ListaControles)(contenido)

            Return fbr.Crear(lista)
        Else
            Return Nothing
        End If

    End Function

    Public Sub GuardarFormulario(lista_controles As ControlesGuardados.ListaControles)

        Dim archivo As New Xml.XmlDocument
        Dim gestor As New GestorXMLv2

        Dim xmlstring As String = gestor.Serializar(lista_controles)
        archivo.LoadXml(xmlstring)

        Dim guardarFormulario As New SaveFileDialog With {
            .Filter = "XML|*.xml",
            .Title = "Guardar Formulario",
            .RestoreDirectory = True
        }

        If guardarFormulario.ShowDialog() = DialogResult.OK Then
            Dim path As String = IO.Path.GetFullPath(guardarFormulario.FileName.ToString())
            archivo.Save(path)
        End If

    End Sub


End Module
