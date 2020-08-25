Module mdlInteraccionBD
    Dim adpt As New Odbc.OdbcDataAdapter
    Public Function SQL_SELECT_ROL(cmd As ADODB.Command) As Integer 'Esta funcion es exclusivamente para seleccionar roles
        Conectar()

        conn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        cmd.ActiveConnection = conn
        rs = cmd.Execute()

        If rs.RecordCount > 0 Then
            Select Case rs(0).Value '0 = administrador, 1 = medico, 2 = auxiliar, 3 = paciente, '999 = rol desconocido
                Case "administrador"
                    Return 0
                Case "medico"
                    Return 1
                Case "auxiliar"
                    Return 2
                Case "paciente"
                    Return 3
                Case Else
                    Return 999
            End Select
        Else
            Return -1 'no existe
        End If


    End Function

End Module
