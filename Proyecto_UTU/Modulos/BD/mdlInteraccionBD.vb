Module mdlInteraccionBD
    Dim rs As New ADODB.Recordset
    Public Function determinarUsr(usr As String) As Integer '1= Admin, 2 = paciente, 3 = Medico, 4 = Auxiliar

        Conectar()
        Try
            rs.Open(SELECTADMINUSER(), conn)
            If rs.RecordCount = -1 Then
                rs.Clone()
            Else
                Return 1
            End If



            rs.Open(SELECTPACIENTEUSER(), conn)
            If rs.RecordCount = -1 Then
                rs.Close()
            Else
                Return 2
            End If

            'If rs.RecordCount = -1 Then
            '    rs.Close()
            '    rs.Open(SELECTPMEDICOUSER(), conn)
            '    If rs.RecordCount = -1 Then
            '        rs.Close()
            '        Cerrar()
            '        Return 0 'No existe en las tablas de usuarios de SIBIM.
            '    Else
            '        rs.Open(SELECTMEDICOUSER(), conn)
            '        If rs.RecordCount = -1 Then
            '            rs.Close()
            '            rs.Open(SELECTAUXILIARUSER(), conn)
            '            If rs.RecordCount = -1 Then
            '                Cerrar()
            '                Return 0 'Es de Pmedico pero no fue ingresado ni como auxiliar ni medico.
            '            End If
            '        End If
            '    End If
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Cerrar()
    End Function


End Module
