Imports Entidades
Public Class frmCargarTarjetasP
    Protected _listaE As New List(Of E_Atiende)
    Protected _e_seleccionada As E_Atiende
    Property ListaEntrevistas As List(Of E_Atiende)
        Get
            Return _listaE
        End Get
        Set(value As List(Of E_Atiende))
            _listaE = value
        End Set
    End Property

    Property EntrevistaSeleccionada As E_Atiende
        Get
            Return _e_seleccionada
        End Get
        Set(value As E_Atiende)
            _e_seleccionada = value
        End Set
    End Property
    Private Sub frmCargarTarjetasP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblAcciones.Enabled = False 'por defecto dejo las acciones desactivadas, para que se habiliten el medico tiene que seleccionar alguna de las tarjetas
        RefrescarTarjetas()
    End Sub

    Sub RefrescarTarjetas()
        tblTarjetas.Controls.Clear()
        tblTarjetas.RowStyles.Clear()
        tblTarjetas.RowCount = 1
        If ListaEntrevistas.Count > 0 Then
            For Each ei As E_Atiende In ListaEntrevistas
                If Not ei Is ListaEntrevistas.Last() Then
                    tblTarjetas.RowCount += 1
                End If
                Dim tarjeta = New TarjetaPaciente With {.MiEntrevista = ei}
                tblTarjetas.Controls.Add(tarjeta)
                tarjeta.Anchor += AnchorStyles.Bottom
                tarjeta.Anchor += AnchorStyles.Right
                addHandlers(tarjeta)
            Next
        End If
        Dim filas As Integer = tblTarjetas.RowCount
        Dim height_prom As Integer = 100 / filas

        For i = 0 To filas - 1 'ajustar alto de las filas del tbl
            tblTarjetas.RowStyles.Add(New RowStyle(SizeType.Percent, height_prom))
        Next

    End Sub

    Sub addHandlers(tarjeta As TarjetaPaciente)
        'AddHandler tarjeta.MouseHover, AddressOf SeleccionarTarjetaDeTBL
        AddHandler tarjeta.MouseDown, AddressOf SeleccionarTarjetaDeTBL
    End Sub

    Public Sub SeleccionarTarjetaDeTBL(sender As Object, e As MouseEventArgs)
        Refresh()
        Console.WriteLine(sender.Name)
        If sender.GetType() = GetType(TarjetaPaciente) Then
            Dim tj = DirectCast(sender, TarjetaPaciente)
            EntrevistaSeleccionada = tj.MiEntrevista
            Dim g As Graphics = tblTarjetas.CreateGraphics
            Dim r As Rectangle = tj.DisplayRectangle
            Dim rect As New Rectangle(tj.Location.X - 2, tj.Location.Y - 2, r.Width + 5, r.Height + 5)

            ControlPaint.DrawBorder(g, rect,
                                    Color.Red, 10, ButtonBorderStyle.Solid,
                                    Color.Red, 10, ButtonBorderStyle.Solid,
                                    Color.Red, 10, ButtonBorderStyle.Solid,
                                    Color.Red, 10, ButtonBorderStyle.Solid)
            tblAcciones.Enabled = True
        Else
            tblAcciones.Enabled = False
        End If
    End Sub

End Class