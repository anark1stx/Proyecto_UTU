Module mdlConexionBD 'modulo unicamente orientado a manejar las conexiones/desconexiones con la BD.
    Public conn As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public _usr As String = ""
    Public _pwd As String = ""
    Public _str As String = ""
    Public Sub Conectar() 'Procedimiento para abrir una conexión a la BD
        On Error GoTo AdoError

        _str = construirCnString(_usr, _pwd)
        If conn.State = ConnectionState.Open Then
            Exit Sub
        End If
        conn.Open(_str)
AdoError:
        If Err.Number <> 0 Then
            MessageBox.Show(Err.Description, "Ha ocurrido un error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Err.Clear()
        Exit Sub
    End Sub

    Public Sub Cerrar() 'Procedimiento para cerrar una conexión a la BD
        If Not conn.State = ConnectionState.Closed Then
            conn.Close()
        End If
    End Sub

    Public Function construirCnString(usr As String, pwd As String)
        Return "DSN=SIBIM;UID=" & usr & "; PWD=" & pwd & ";"
    End Function

End Module
