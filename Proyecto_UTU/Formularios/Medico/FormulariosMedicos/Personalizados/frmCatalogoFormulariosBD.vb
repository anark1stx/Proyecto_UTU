Imports Entidades
Imports Negocio
Public Class frmCatalogoFormulariosBD

    Dim cajaFormularios As List(Of frmPresentacionFormulario) = New List(Of frmPresentacionFormulario)
    Dim negocio As N_Formulario
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        cajaFormularios.Clear()
        tblFormularios.Controls.Clear()

        If txtBuscar.Text Is String.Empty Then
            MsgBox("Ingrese el nombre del formulario que desea utilizar")
            Exit Sub
        End If

        'hacer busqueda en bd
        'listaFormularios = negocio.BuscarFormularios(txtBuscar.Text,6) 'siendo 6 la cantidad maxima de formularios que voy a mostrar

        Dim listaFormularios As List(Of E_Formulario) = negocio.BuscarFormularios(txtBuscar.Text)

        For Each f As E_Formulario In listaFormularios
            Dim pFormulario = New frmPresentacionFormulario With {
            .Formulario = f,
            .TopMost = True,
            .TopLevel = False,
            .Visible = True
            }

            cajaFormularios.Add(pFormulario)
        Next

        If cajaFormularios.Count < 1 Then
            MsgBox("No se encontraron resultados")
        Else

            For i = 0 To cajaFormularios.Count - 1

                tblFormularios.Controls.Add(cajaFormularios(i))

            Next

        End If

    End Sub

    Private Sub frmCatalogoFormulariosBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Podria ver de ejecutar un metodo que cargara todos los formularios capaz
    End Sub
End Class