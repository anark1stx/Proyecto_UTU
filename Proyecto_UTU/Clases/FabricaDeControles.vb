Public Class FabricaDeControles
    'Serializar recibe controles de windows forms, y los transforma a Controles de la clase ControlesGuardados.
    Function Serializar(controles As List(Of Control)) As List(Of ControlesGuardados.SControl) 'Guardar como los types que cree en ControlesGuardados
        Dim lista As New List(Of ControlesGuardados.SControl)

        For Each c As Control In controles

            Select Case c.GetType()
                Case GetType(Panel)
                    If c.Controls.Count > 0 Then
                        Dim tmp_list As New List(Of Control)

                        For Each c2 As Control In c.Controls
                            tmp_list.Add(c2)
                        Next

                        lista.Add(New ControlesGuardados.Panel(c.Location, c.Size, c.Name, c.Dock, c.Anchor, c.ForeColor, c.BackColor, DirectCast(c, Panel).AutoScroll, Serializar(tmp_list))) 'Necesario castearlo como panel para sacar esa propiedad

                    End If
                Case GetType(GroupBox)
                    If c.Controls.Count > 0 Then
                        Dim tmp_list As New List(Of Control)
                        tmp_list.AddRange(c.Controls)
                        lista.Add(New ControlesGuardados.GroupBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, c.ForeColor, c.BackColor, c.Text, c.Font, Serializar(tmp_list))) 'Necesario castearlo como panel para sacar esa propiedad

                    End If
                Case GetType(Label)
                    lista.Add(New ControlesGuardados.Label(c.Location, c.Size, c.Name, c.Dock, c.Anchor, c.ForeColor, c.BackColor, c.Text, c.Font))
            End Select

        Next

        Return lista
    End Function

    Function Crear(controles As List(Of ControlesGuardados.SControl)) As List(Of Control) 'Control de windows forms
        Dim lista As New List(Of Control)

        Return lista
    End Function


End Class
