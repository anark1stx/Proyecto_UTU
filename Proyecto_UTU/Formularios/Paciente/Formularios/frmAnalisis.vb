Public Class frmAnalisis
    Private Sub frmAnalisis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fixSize()
    End Sub

    Public Sub fixSize() 'Metodo para redimensionar controles sin tener que entrar a las propiedades de cada uno a cambiarlo
        For Each c As Control In Me.Controls

            If c IsNot pnlContenedorAnalisis Then 'El unico control que no queremos modificar es el menu superior
                c.Anchor += AnchorStyles.Bottom
                c.Anchor += AnchorStyles.Top
                c.Anchor += AnchorStyles.Left
                c.Anchor += AnchorStyles.Right
                c.Dock = DockStyle.Top
            End If

        Next
    End Sub

End Class