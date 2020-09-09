Imports Entidades
Imports Negocio
Imports Utilidades
Public Class frmCatalogoFormulariosBD
    Protected _formSeleccionado As E_Formulario
    'Dim cajaFormularios As List(Of frmPresentacionFormulario) = New List(Of frmPresentacionFormulario)
    Dim negocio As New N_Formulario

    Property FormSeleccionado As E_Formulario
        Get
            Return _formSeleccionado
        End Get
        Set(value As E_Formulario)
            _formSeleccionado = value
        End Set
    End Property

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        tblFormularios.Controls.Clear()

        If Not check_Largo(txtBuscar.Text, 3, 90, True) Then
            MsgBox("Ingrese el nombre del formulario que desea utilizar")
            Exit Sub
        End If

        Dim listaFormularios As List(Of E_Formulario) = negocio.BuscarFormularios(txtBuscar.Text)

        Select Case listaFormularios(0).ID
            Case -1
                MessageBox.Show(MensajeDeErrorConexion(), "Hay errores con la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case -2
                MessageBox.Show(MensajeDeErrorPermisoProcedimiento(), "Error ejecutando procedimiento", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case -8
                MessageBox.Show("No fueron encontrados formularios con ese nombre", "No se se encontraron elementos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
        End Select

        For Each f As E_Formulario In listaFormularios
            Dim pFormulario = New frmPresentacionFormulario With {
            .Formulario = f,
            .TopMost = True,
            .TopLevel = False,
            .Visible = True,
            .Dock = DockStyle.Fill
            }
            AddHandler pFormulario.Click, AddressOf ClickEnControlTBL
            tblFormularios.Controls.Add(pFormulario)
        Next

    End Sub


    Private Sub frmCatalogoFormulariosBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Podria ver de ejecutar un metodo que cargara todos los formularios capaz
    End Sub

    Sub ClickEnControlTBL(sender As Object, e As MouseEventArgs)
        Dim CellPos As TableLayoutPanelCellPosition = tblFormularios.GetCellPosition(DirectCast(sender, Control))
        Dim col As Integer = CellPos.Column
        Dim row As Integer = CellPos.Row
        Dim presentacionSelec = DirectCast(tblFormularios.GetControlFromPosition(col, row), frmPresentacionFormulario)
        FormSeleccionado = presentacionSelec.Formulario
        Console.WriteLine(FormSeleccionado.Nombre)
    End Sub

End Class