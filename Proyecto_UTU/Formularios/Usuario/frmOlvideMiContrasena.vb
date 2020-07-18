Public Class frmOlvideMiContrasena
    Private Sub btnReestablecerPWD_Click(sender As Object, e As EventArgs) Handles btnReestablecerPWD.Click
        'Verificar que esa cédula exista en la BD.
        'Posteriormente enviar notificacion a administrador
        'Por último enviar un mensaje por pantalla avisando que la administración fue notificada y que se pondrá en contacto pronto.
        If Not check_Cedula(txtIngresarCi.Text) Then
            MsgBox("Ingrese una cédula de identidad válida.")
        Else
            MsgBox("la administración fue notificada y se pondrá en contacto con usted pronto") 'Acá estaría bueno ver en que terminal de autoconsulta está la persona para que alguien se acerque a ella directamente y le ayude con eso.
            'La otra forma sería por telefono/correo, pero no tiene mucho sentido si la persona va a acceder al programa desde el hospital
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
End Class