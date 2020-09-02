Imports Entidades
Imports Negocio
Public Class frmCatalogoFormulariosBD

    Dim listaFormularios As List(Of E_Formulario) = New List(Of E_Formulario)(5) 'La cantidad maxima de formularios que voy a estar mostrando por pagina del catalogo
    Dim cajaFormularios As List(Of frmPresentacionFormulario) = New List(Of frmPresentacionFormulario)(5)

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If txtBuscar.Text Is String.Empty Then
            MsgBox("Ingrese el nombre del formulario que desea utilizar")
            Exit Sub
        End If


        Dim formulariosEncontrados As Integer = 1 '<- Si bien la cantidad maxima es 5, puede ser que solo se hayan encontrado 2 o ninguno incluso, asi que debo corroborar que el resto no sean empty


        '()-> Hacer Busqueda en la BD



        'For i = 0 To listaFormularios.Count 'Ver cuantos resultados hubieron
        '    If listaFormularios(i).Nombre = String.Empty Then

        '        If i = 0 Then
        '            formulariosEncontrados = 0
        '            Exit For
        '        End If

        '        If i = 1 Then
        '            formulariosEncontrados = 1
        '            Exit For
        '        End If

        '        formulariosEncontrados = i - 1
        '        Exit For
        '    End If
        'Next

        Dim pFormulario = New frmPresentacionFormulario With {
            .TopMost = True,
            .TopLevel = False
        }

        cajaFormularios.Add(pFormulario)

        If formulariosEncontrados < 1 Then
            MsgBox("No se encontraron resultados")
        Else

            For i = 0 To formulariosEncontrados - 1

                tblFormularios.Controls.Add(cajaFormularios(i))

            Next

        End If

    End Sub

    Private Sub frmCatalogoFormulariosBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class