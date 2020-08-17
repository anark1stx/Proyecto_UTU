Module mdlArmarCMDS

    Public Function CMDSELECTMYSQLUSERROLE(usr As String) As ADODB.Command
        Dim cmd As ADODB.Command
        cmd = New ADODB.Command With {
            .CommandType = ADODB.CommandTypeEnum.adCmdText,
            .CommandText = "SELECT FROM_USER FROM mysql.role_edges WHERE TO_USER = @usr;"
        }
        cmd.Parameters.Append(cmd.CreateParameter("@usr", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, usr))
        Console.WriteLine(cmd.CommandText)
        Return cmd
    End Function

End Module
