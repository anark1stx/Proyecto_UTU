Imports Entidades
Imports Utilidades
Imports Negocio
Public Class frmAgregarCategorias
    Dim ncat As New 
    Protected _listacats As New List(Of E_Categoria)

    Property ListaCategorias As List(Of E_Categoria)
        Get
            Return _listacats
        End Get
        Set(value As List(Of E_Categoria))
            _listacats = value
        End Set
    End Property

    Private Sub btnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles btnAgregarCategoria.Click
        If Not check_Largo(txtNomCat.Text, 3, 30, True) Then
            MessageBox.Show(MensajeDeErrorLongitud(3, 30), "Información inválida.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Not check_regex(txtNomCat.Text, RegexAlfaNumericoEspaciosPuntosComasTildes) Then
            MessageBox.Show(MensajeDeErrorCaracteres(), "Información inválida.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ListaCategorias.Add(New E_Categoria With {.Nombre = txtNomCat.Text})
        lbCategorias.DataSource = ListaCategorias
    End Sub

    Private Sub btnSacarCategoria_Click(sender As Object, e As EventArgs) Handles btnSacarCategoria.Click
        If lbCategorias.SelectedIndex <> -1 Then
            ListaCategorias.RemoveAt(lbCategorias.SelectedIndex)
            lbCategorias.DataSource = ListaCategorias
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'alta categoria
    End Sub
End Class