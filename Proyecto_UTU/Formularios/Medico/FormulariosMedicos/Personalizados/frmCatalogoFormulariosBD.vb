Public Class frmCatalogoFormulariosBD

    Dim formAabrir As Formulario

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If txtBuscar.Text Is String.Empty Then
            MsgBox("Ingrese el nombre del formulario que desea utilizar")
            Exit Sub
        End If

        '1- Abrir catalogo
        '2- Guardar formulario seleccionado en variable por ID



    End Sub
End Class