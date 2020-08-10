Module mdlConexionBD 'modulo unicamente orientado a manejar las conexiones/desconexiones con la BD.
    Public conn As New ADODB.Connection
    Public _usr As String = ""
    Public _pwd As String = ""
    Public _str As String = ""
    'Método para conectarnos a la BD'
    Public Function Conectar() As Integer
        Try
            conn.Open(_str)
            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function

    Public Function verificar_usr(connection_string As String)
        Try
            conn.Open(connection_string)
            _str = connection_string
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    'Cerrar conexión'
    Public Sub Cerrar()
        conn.Close()
    End Sub

    'Retornamos los datos de la conexión como String'
    Public Function CONNECTION_STRING(usr As String, contrasena As String) As String
        Dim myConnectionString As String = "DSN=SIBIM;UID=" & usr & "; PWD=" & contrasena & ";"
        Return myConnectionString
    End Function

    Public Function CONNECTION_STRING_USRPublico()
        Dim myConnectionString As String = "DSN=SIBIM;UID=publico;PWD=us3r_c0nsult4;"
        Return myConnectionString
    End Function


End Module
