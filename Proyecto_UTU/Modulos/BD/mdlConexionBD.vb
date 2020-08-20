Module mdlConexionBD 'modulo unicamente orientado a manejar las conexiones/desconexiones con la BD.
    Public conn As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public _usr As String = ""
    Public _pwd As String = ""
    Public _str As String = ""
    Public Sub Conectar() 'Procedimiento para abrir una conexión a la BD y refrescar el recordset
        On Error GoTo AdoError

        If Not conn.State = ConnectionState.Open Then
            _str = construirCnString(_usr, _pwd)
            conn.Open(_str)
        End If

        If rs.State = ConnectionState.Open Then
            rs.Close()
        End If

AdoError:
        Select Case Err.Number
            Case -2147467259
                MessageBox.Show("Sus credenciales son incorrectas.", "Ha ocurrido un error. " & Err.Number, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 0
                'Nada, todo OK
            Case Else
                MessageBox.Show(Err.Description, "Ha ocurrido un error. " & Err.Number, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
        Err.Clear()
        Exit Sub
    End Sub

    Public Function construirCnString(usr As String, pwd As String)
        Return String.Format("DSN=SIBIM;UID={0}; PWD={1};", usr, pwd)
    End Function

End Module
