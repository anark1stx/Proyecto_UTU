Imports Entidades
Imports FormulariosPersonalizados
Public Class ContenedorEntrevistas
    Protected _enfermedad As New E_Enfermedad
    Protected _frmLimpio As New formularioLimpio
    Dim AccionesFrm As New AccionesFormulario
    Dim Eventos As New EventosDeTBP

    Property Frmlimpio As formularioLimpio
        Get
            Return _frmLimpio
        End Get
        Set(value As formularioLimpio)
            _frmLimpio = value
        End Set
    End Property

    Property Enfermedad As E_Enfermedad
        Get
            Return _enfermedad
        End Get
        Set(value As E_Enfermedad)
            _enfermedad = value
        End Set
    End Property
    Private Sub btnAgregarSClinico_Click(sender As Object, e As EventArgs) Handles btnAgregarSClinico.Click
        If Not lbSignosClinicos.Items.Contains(txtSgClinico.Text) Then
            lbSignosClinicos.Items.Add(txtSgClinico.Text)
            Dim sg As New E_Enfermedad.SignoClinico
            sg.Nombre = txtSgClinico.Text
            Frmlimpio.MiFormulario.Enfermedad.SignosClinicos.Add(sg)
            txtSgClinico.Clear()
        Else
            MessageBox.Show("Ese signo clínico ya fue ingresado")
        End If

    End Sub

    Private Sub btnAgregarSintoma_Click(sender As Object, e As EventArgs) Handles btnAgregarSintoma.Click
        If Not lbSintomas.Items.Contains(txtSintoma.Text) Then
            lbSintomas.Items.Add(txtSintoma.Text)
            Dim sintoma As New E_Enfermedad.Sintoma
            sintoma.Nombre = txtSintoma.Text
            Frmlimpio.MiFormulario.Enfermedad.Sintomas.Add(sintoma)
            txtSintoma.Clear()
        Else
            MessageBox.Show("Ese síntoma ya fue ingresado")
        End If
    End Sub

    Private Sub btnBorrarSintoma_Click(sender As Object, e As EventArgs) Handles btnBorrarSintoma.Click
        If lbSintomas.SelectedItem IsNot String.Empty Then
            lbSintomas.Items.Remove(lbSintomas.SelectedItem)
            Frmlimpio.MiFormulario.Enfermedad.Sintomas.Remove(Frmlimpio.MiFormulario.Enfermedad.Sintomas.Find(Function(p) p.Nombre = lbSintomas.SelectedItem.ToString()))
        End If
    End Sub

    Private Sub btnBorrarSigno_Click(sender As Object, e As EventArgs) Handles btnBorrarSigno.Click
        If lbSignosClinicos.SelectedItem IsNot String.Empty Then
            lbSignosClinicos.Items.Remove(lbSignosClinicos.SelectedItem)
            Frmlimpio.MiFormulario.Enfermedad.SignosClinicos.Remove(Frmlimpio.MiFormulario.Enfermedad.SignosClinicos.Find(Function(p) p.Nombre = lbSignosClinicos.SelectedItem.ToString()))
        End If
    End Sub

    Private Sub chkEnfermo_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnfermo.CheckedChanged
        If chkEnfermo.Checked Then
            lblPresenta.Visible = True
            txtNomEnfermedad.Visible = True
            txtNomEnfermedad.Text = ""
        Else
            lblPresenta.Visible = False
            txtNomEnfermedad.Visible = False
        End If
    End Sub

    Private Sub chkAnalisis_CheckedChanged(sender As Object, e As EventArgs) Handles chkAnalisis.CheckedChanged
        If chkAnalisis.Checked Then
            lblAnalisisReq.Visible = True
            txtNomAnalisis.Visible = True
        Else
            lblAnalisisReq.Visible = False
            txtNomAnalisis.Visible = False
        End If
    End Sub
    Private Sub chkTratamiento_CheckedChanged(sender As Object, e As EventArgs) Handles chkTratamiento.CheckedChanged
        If chkTratamiento.Checked Then
            lblTratamientoS.Visible = True
            txtNomTratamiento.Visible = True
        Else
            lblTratamientoS.Visible = False
            txtNomTratamiento.Visible = False
        End If
    End Sub

    Private Sub ContenedorEntrevistas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Eventos.Modo = EventosDeTBP.ModoEvento.DatosFormulario

        Eventos.Acciones = AccionesFrm

        Eventos.PrintDoc = New Printing.PrintDocument
        Eventos.Acciones.TopLevel = False
        Eventos.Acciones.TopMost = True

        Eventos.PanelDestino = Frmlimpio.pnlContenedor
        Eventos.FormDatos = Frmlimpio.MiFormulario
        Frmlimpio.TopMost = True
        Frmlimpio.TopLevel = False
        tbpEntrevista.Controls.Add(Frmlimpio)
        Frmlimpio.Visible = True
        Frmlimpio.Dock = DockStyle.Fill
        Frmlimpio.pnlContenedor.Controls.Add(Eventos.Acciones)

        Eventos.Acciones.Dock = DockStyle.Bottom
        Eventos.Acciones.Visible = True
        Eventos.AgregarHandlers()
    End Sub

    Private Sub btnSugerirDiagnostico_Click(sender As Object, e As EventArgs) Handles btnSugerirDiagnostico.Click
        MsgBox("Aun no implementado.")
    End Sub

    Private Sub txtNomEnfermedad_TextChanged(sender As Object, e As EventArgs) Handles txtNomEnfermedad.TextChanged
        Frmlimpio.MiFormulario.Enfermedad.Nombre = txtNomEnfermedad.Text
    End Sub
End Class
