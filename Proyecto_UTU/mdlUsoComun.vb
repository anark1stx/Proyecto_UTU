Imports Negocio
Imports Utilidades
Module mdlUsoComun
    Public Async Sub CargarUsuarioFotoDesdeBD(CI As Integer, pboxDestino As PictureBox)
        Dim negocio As New N_Usuario
        Dim fotoBytes = Await Task.Run(Function() negocio.LeerFoto(CI))

        pboxDestino.Image = Bytes2Image(fotoBytes)

    End Sub
End Module
