Module mdlQueriesComunes

    Public Function SELECTMYSQLUSER(usr As String) As String
        Return "SELECT User FROM `mysql`.`user` WHERE User=" & usr
    End Function

End Module
