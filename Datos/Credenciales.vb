Imports MySql.Data.MySqlClient
Module Credenciales
    Private _usr As String = ""
    Private _pwd As String = ""
    Private _str As String = ""

    Public Sub construirCnString(usr As String, pwd As String)
        _usr = usr
        _pwd = pwd
        _str = String.Format("SERVER=archivos.overclode.sibim;DATABASE=sibim;UID={0}; PWD={1};", _usr, _pwd)
    End Sub

    Public Function retornarCStringBD() As String
        Return _str
    End Function

    Public Function Conectar(ByVal conn As MySqlConnection) As Integer 'devuelve codigo de exito dependiendo de si pudo abrir la conexion o no.
        Try
            conn.ConnectionString = retornarCStringBD()
            conn.Open()
        Catch ex As MySqlException
            Select Case ex.Number 'como son numeros feos los cambio
                Case 1042 'codigo de exito para conexion fallida de la clase MysqlException
                    Return -1
                Case 0 'codigo de error de autenticacion
                    Return -5
                Case Else
                    Return ex.Number
            End Select
        End Try
        Return 1
    End Function

    Public Sub Cerrar(conn As MySqlConnection)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

End Module
