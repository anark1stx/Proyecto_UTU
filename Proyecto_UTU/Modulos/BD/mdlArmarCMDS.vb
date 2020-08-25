Module mdlArmarCMDS

    Public Function CMDSELECTMYSQLUSERROLE(usr As String) As ADODB.Command 'Este comando es exclusivamente para seleccionar roles
        Dim prm As New ADODB.Parameter
        Dim cmd = New ADODB.Command
        cmd.CommandType = ADODB.CommandTypeEnum.adCmdText
        cmd.CommandText = "SELECT DEFAULT_ROLE_USER FROM mysql.default_roles WHERE USER= ?;"
        prm = cmd.CreateParameter("USR", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255)
        prm.Value = usr

        cmd.Parameters.Append(prm)
        Return cmd
    End Function


End Module
