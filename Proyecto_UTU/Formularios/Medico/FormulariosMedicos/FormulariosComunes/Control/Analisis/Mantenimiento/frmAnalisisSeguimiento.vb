Public Class frmAnalisisSeguimiento
    Dim frmDatos As New frmDatosAnalisis
    Private Sub btnIngresarDatos_Click(sender As Object, e As EventArgs) Handles btnIngresarDatos.Click

        '1- Verificar que ese análisis aún no se haya llenado
        '2- Abrir formulario de datos en modo de ingreso (campos con textbox)

    End Sub

    Private Sub btnConsultarDatos_Click(sender As Object, e As EventArgs) Handles btnConsultarDatos.Click
        '-1 Abrir formulario de datos en modo de lectura (todo con labels)
    End Sub

    Private Sub frmAnalisisSeguimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class