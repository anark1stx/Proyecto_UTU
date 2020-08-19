﻿Module mdlInteraccionBD
    Dim adpt As New Odbc.OdbcDataAdapter
    Public Function SQL_SELECT_ROL(cmd As ADODB.Command) As Integer 'Esta funcion es exclusivamente para seleccionar roles
        Conectar()
        Dim retorno = 0

        On Error GoTo queryErr

        conn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        cmd.ActiveConnection = conn
        rs = cmd.Execute()

        If rs.RecordCount >= 1 Then
            Select Case rs(0).Value '0 = administrador, 1 = medico, 2 = auxiliar, 3 = paciente
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
            MsgBox("No tiene rol en la BD")
        End If

        Return retorno
queryErr:
        If Err.Number <> 0 Then
            MessageBox.Show(Err.Number & ": " & Err.Description, "Ha Ocurrido un error.", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Function





End Module
