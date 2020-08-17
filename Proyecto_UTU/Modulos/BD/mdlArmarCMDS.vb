Module mdlArmarCMDS

    Public Function CMDSELECTMYSQLUSERROLE(usr As String) As ADODB.Command 'Este comando es exclusivamente para seleccionar roles
        Dim prm As New ADODB.Parameter
        Dim cmd = New ADODB.Command
        cmd.CommandType = ADODB.CommandTypeEnum.adCmdText
        cmd.CommandText = "SELECT FROM_USER FROM mysql.role_edges WHERE TO_USER= ?;"
        prm = cmd.CreateParameter("USR", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255)
        prm.Value = usr

        cmd.Parameters.Append(prm)
        Return cmd
    End Function

    Public Function CMDGenerico(query As String)
        Return New ADODB.Command With {
            .CommandType = ADODB.CommandTypeEnum.adCmdText,
            .CommandText = query
        }
    End Function


End Module
