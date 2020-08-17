Module mdlInteraccionBD
    Public Function SQL_SELECT_ROL(cmd As ADODB.Command) As Integer
        Conectar()
        Dim retorno = 0

        On Error GoTo queryErr

        conn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        cmd.ActiveConnection = conn
        rs = cmd.Execute()

        If rs.RecordCount >= 1 Then
            MsgBox("Su rol es:" & rs(0).Value)
            Select Case rs(0).Value '0 = administrador, 1 = medico, 2 = auxiliar, 3 = paciente
                Case "administrador"
                    Return 0
                Case "medico"
                    Return 1
                Case "auxiliar"
                    Return 2
                Case "paciente"
                    Return 3
            End Select
        Else
            MsgBox("No tiene rol en la BD")
        End If
        Cerrar()

        Return retorno
queryErr:
        If Err.Number <> 0 Then
            MessageBox.Show(Err.Number & ": " & Err.Description, "Ha Ocurrido un error.", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Function

End Module
