Module Credenciales
    Private _usr As String = ""
    Private _pwd As String = ""
    Private _str As String = ""

    Public Sub construirCnString(usr As String, pwd As String)
        _usr = usr
        _pwd = pwd
        _str = String.Format("DSN=SIBIM_OVERCLODE;UID={0}; PWD={1};", _usr, _pwd)
    End Sub

    Public Function retornarCString() As String
        Return _str
    End Function

End Module
