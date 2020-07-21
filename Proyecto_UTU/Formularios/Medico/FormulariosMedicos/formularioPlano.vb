Public Class formularioPlano
    Public Sub formularioPlano_ControlAdded(sender As Object, e As ControlEventArgs) Handles MyBase.ControlAdded


    End Sub

    Public Sub changeName()

        Console.WriteLine(Controls.Count)

        'If Me.Controls(Me.Controls.Count - 1).GetType().ToString.Equals("System.Windows.Forms.TextBox") Then
        '
        '       Dim control_nombre_fixed As New TextBox
        '
        '     control_nombre_fixed = Me.Controls(Me.Controls.Count - 1)
        '
        ' control_nombre_fixed.Name = frmCrearFormulario.tempname
        '
        'Me.Controls.RemoveAt(Me.Controls.Count - 1)

        'End If
    End Sub

End Class