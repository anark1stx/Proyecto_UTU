Module mdlMetodosGenerales
    Public Function RemoverEspacios(list1 As String()) As String()

        For Each i In list1

            i.Trim()

        Next

        Return list1

    End Function

End Module
