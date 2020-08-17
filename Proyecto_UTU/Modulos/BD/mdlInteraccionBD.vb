Module mdlInteraccionBD

    Public Function SQL_SELECT(cmd As ADODB.Command) As DataTable
        On Error GoTo queryErr
        cmd.ActiveConnection = conn
        rs = cmd.Execute()

        MsgBox(rs.Fields.Item(0))
queryErr:
        If Err.Number <> 0 Then
            MessageBox.Show(Err.Number & ": " & Err.Description, "Ha ocurrido un error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Function

End Module
