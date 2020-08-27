Imports System.Drawing
Module mdlUtils

    Public Function ColorTOHTML(col As Color) As String 'XMLSerializer no puede guardar System.Drawing.Color

        Return ColorTranslator.ToHtml(col)

    End Function

    Public Function HTMLTOColor(col As String) As Color
        Return ColorTranslator.FromHtml(col)
    End Function

End Module
