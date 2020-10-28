Public Class E_Corresponde
    Property Medico As E_Medico
    Property Auxiliar As E_Usuario
    Property Fecha As Date
    Property ErrCode As Integer

    Sub New()

    End Sub

    Sub New(med As E_Medico, aux As E_Usuario, fec As Date)
        Medico = med
        Auxiliar = aux
        Fecha = fec
    End Sub
End Class
