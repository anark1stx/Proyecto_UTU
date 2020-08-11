Module mdlQueriesComunes

    Public Function SELECTMYSQLUSER(usr As String) As String
        Return "SELECT User FROM `mysql`.`user` WHERE User=" & usr
    End Function

    Public Function SELECTPACIENTEUSER() As String
        Return "SELECT CI FROM `SIBIM`.`Usuario` WHERE CI IN(SELECT CI FROM Paciente)"
    End Function

    Public Function SELECTPMEDICOUSER() As String
        Return "SELECT CI FROM `SIBIM`.`Usuario` WHERE CI IN(SELECT CI FROM personalmedico)"
    End Function

    Public Function SELECTMEDICOUSER() As String
        Return "SELECT CI FROM `SIBIM`.`Pmedico` WHERE CI IN(SELECT CI FROM Medico)"
    End Function

    Public Function SELECTAUXILIARUSER() As String
        Return "SELECT CI FROM `SIBIM`.`Pmedico` WHERE CI IN(SELECT CI FROM Auxiliar)"
    End Function
    Public Function SELECTADMINUSER() As String
        Return "SELECT CI FROM `SIBIM`.`Pmedico` WHERE CI IN(SELECT CI FROM Auxiliar)"
    End Function

End Module
