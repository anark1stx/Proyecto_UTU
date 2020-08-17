Module mdlInteraccionBD
    Public Sub SQL_SELECT_ROL(cmd As ADODB.Command)

        Dim retorno = 0

        On Error GoTo queryErr

        If conn.State = ConnectionState.Closed Then
            Conectar()
        End If

        conn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        cmd.ActiveConnection = conn
        rs = cmd.Execute()

        If rs.RecordCount >= 1 Then
            MsgBox("Su rol es:" & rs(0).Value)
            Select Case rs(0).Value
                Case "administrador"

                Case "medico"

                Case "paciente"

                Case "auxiliar"

            End Select
        Else
            MsgBox("No tiene rol en la BD")
        End If
        Cerrar()
queryErr:
        If Err.Number <> 0 Then
            MessageBox.Show(Err.Number & ": " & Err.Description, "Ha Ocurrido un error.", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

End Module
