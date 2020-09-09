﻿Imports Entidades
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
        Dim g As Graphics = tblFormularios.CreateGraphics
        Dim ctrl = sender
        If sender.GetType IsNot GetType(UserControl) Then
            ctrl = sender.Parent.Parent 'primero esta el tablelayout panel y luego viene el usercontrol
        End If
        Dim presentacionSelec = DirectCast(tblFormularios.GetChildAtPoint(ctrl.Location), frmPresentacionFrm)
        FormSeleccionado = presentacionSelec.Formulario
        Dim posicion = New Point(presentacionSelec.Left - 1, presentacionSelec.Top - 1) ' es necesario el offset, este framework es demasiado bueno como para hacerlo bien por su cuenta
        Dim bounds = New Size(posicion.X + presentacionSelec.Width, posicion.Y + presentacionSelec.Height)
        Dim rect As New Rectangle(posicion, bounds)

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
        Me.FormSeleccionado = Nothing
    End Sub
End Class