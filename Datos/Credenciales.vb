Imports MySql.Data.MySqlClient
Module Credenciales
    Public Sesion As MySQLSesion
    Public Class MySQLSesion
        Protected _usr As String = ""
        Protected _pwd As String = ""
        Protected _str As String = ""
        Private ReadOnly Property ConnectionString As String
            Get
                Return _str
            End Get
        End Property
        Sub New()

        End Sub

        Sub New(usr As String, pwd As String)
            _usr = usr
            _pwd = pwd
            _str = String.Format("SERVER=archivos.overclode.sibim;DATABASE=sibim;UID={0}; PWD={1};", _usr, _pwd)
        End Sub
        Public Function Conectar(ByVal conn As MySqlConnection) As Integer 'devuelve codigo de exito dependiendo de si pudo abrir la conexion o no.
            Try
                conn.ConnectionString = ConnectionString
                conn.Open()
            Catch ex As MySqlException
                Select Case ex.Number 'como son numeros feos los cambio
                    Case 1042 'codigo de salida para conexion fallida de la clase MysqlException
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
    End Class

End Module
