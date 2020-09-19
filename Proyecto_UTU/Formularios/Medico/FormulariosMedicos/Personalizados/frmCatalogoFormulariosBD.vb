Imports Entidades
Imports Negocio
Imports Utilidades
Public Class frmCatalogoFormulariosBD
    Protected _formSeleccionado As E_Formulario
    Dim negocio As New N_Formulario

    Property FormSeleccionado As E_Formulario
        Get
            Return _formSeleccionado
        End Get
        Set(value As E_Formulario)
            _formSeleccionado = value
        End Set
    End Property

    Public Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
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
            Dim pFormulario = New frmPresentacionFrm With {
            .Formulario = f,
            .Visible = True,
            .Dock = DockStyle.Fill
            }

            AddHandler pFormulario.Click, AddressOf ClickEnControlTBL
            AddHandler pFormulario.MouseMove, AddressOf MostrarManito
            AddHandler pFormulario.pBoxVistaPrevia.Click, AddressOf ClickEnControlTBL
            AddHandler pFormulario.pBoxVistaPrevia.MouseMove, AddressOf MostrarManito
            AddHandler pFormulario.lblNombreForm.Click, AddressOf ClickEnControlTBL
            AddHandler pFormulario.lblNombreForm.MouseMove, AddressOf MostrarManito
            tblFormularios.Controls.Add(pFormulario)
        Next

    End Sub

    Private Sub frmCatalogoFormulariosBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Podria ver de ejecutar un metodo que cargara todos los formularios capaz, puede ser un procedimiento con TOP 10 
    End Sub

    Sub MostrarManito(sender As Object, e As EventArgs)
        Cursor.Current = Cursors.Hand
    End Sub

    Sub ClickEnControlTBL(sender As Object, e As MouseEventArgs)
        Refresh()
        Dim g As Graphics = tblFormularios.CreateGraphics
        Dim ctrl = sender
        If sender.GetType IsNot GetType(UserControl) Then
            ctrl = sender.Parent.Parent 'primero esta el tablelayout panel y luego viene el usercontrol
        End If
        Dim presentacionSelec = DirectCast(tblFormularios.GetChildAtPoint(ctrl.Location), frmPresentacionFrm)
        FormSeleccionado = presentacionSelec.Formulario
        Dim r As Rectangle = presentacionSelec.DisplayRectangle
        Dim rect As New Rectangle(ctrl.Location.X - 2, ctrl.Location.Y - 2, r.Width + 5, r.Height + 5)

        ControlPaint.DrawBorder(g, rect,
                                Color.Red, 10, ButtonBorderStyle.Solid,
                                Color.Red, 10, ButtonBorderStyle.Solid,
                                Color.Red, 10, ButtonBorderStyle.Solid,
                                Color.Red, 10, ButtonBorderStyle.Solid)

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Hide()
    End Sub

    Private Sub frmCatalogoFormulariosBD_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then Me.FormSeleccionado = Nothing
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.TextLength > 3 Then btnBuscar_Click(sender, e)
    End Sub
End Class