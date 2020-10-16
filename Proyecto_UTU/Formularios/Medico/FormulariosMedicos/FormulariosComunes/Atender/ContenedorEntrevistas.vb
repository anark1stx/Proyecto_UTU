Imports Entidades
Imports FormulariosPersonalizados
Public Class ContenedorEntrevistas
    Protected _enfermedad As New E_Enfermedad
    Protected _Entrevista As New FormularioEntrevista
    Dim AccionesFrm As New AccionesFormulario
    Dim Eventos As New EventosDeTBP
    Protected _modo As Modo
    Public Enum Modo
        Ingreso
        Consulta
    End Enum
    Property ModoActual As Modo
        Get
            Return _modo
        End Get
        Set(value As Modo)
            If value <> _modo Then
                _modo = value
                ResetMode()
            End If
        End Set
    End Property

    Property Entrevista As FormularioEntrevista
        Get
            Return _Entrevista
        End Get
        Set(value As FormularioEntrevista)
            _Entrevista = value
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

    Sub ResetMode()
        Select Case ModoActual
            Case Modo.Ingreso
                txtSgClinico.Visible = True
                lblIngreseSignoClinico.Text = "Ingrese signo clínico:"
                txtSintoma.Visible = True
                lblIngreseSignoClinico.Text = "Ingrese síntoma:"
                btnAgregarSClinico.Visible = True
                btnAgregarSintoma.Visible = True
                btnBorrarSigno.Visible = True
                btnBorrarSintoma.Visible = True
                btnSugerirDiagnostico.Visible = True
                chkEnfermo.AutoCheck = True
                chkAnalisis.Visible = False
                chkTratamiento.Visible = False
                Eventos.Modo = EventosDeTBP.ModoEvento.DatosFormulario
            Case Modo.Consulta
                'hacer todo readonly
                txtSgClinico.Visible = False
                lblIngreseSignoClinico.Text = "Signos clínicos registrados:"
                txtSintoma.Visible = False
                lblIngreseSintoma.Text = "Síntomas registrados:"
                btnAgregarSClinico.Visible = False
                btnAgregarSintoma.Visible = False
                btnBorrarSigno.Visible = False
                btnBorrarSintoma.Visible = False
                btnSugerirDiagnostico.Visible = False
                chkAnalisis.Visible = True
                chkTratamiento.Visible = True
                makeFormReadOnly(Me)
                Eventos.Modo = EventosDeTBP.ModoEvento.ConsultaDatos
        End Select
    End Sub

    Sub makeFormReadOnly(contenedor As Control)
        For Each c As Control In contenedor.Controls
            Select Case c.GetType()
                Case GetType(TextBox)
                    DirectCast(c, TextBox).ReadOnly = True
                Case GetType(CheckBox)
                    DirectCast(c, CheckBox).AutoCheck = False
                Case GetType(ComboBox)
                    Dim cb = DirectCast(c, ComboBox)
                    Try
                        Dim item = cb.SelectedItem
                        cb.Items.Clear()
                        cb.Items.Add(item)
                        cb.SelectedIndex = 0
                    Catch ex As Exception
                        Console.WriteLine("combo vacio")
                    End Try
                    cb.DropDownStyle = ComboBoxStyle.DropDownList
                Case GetType(TabControl), GetType(TabPage), GetType(Panel), GetType(FormularioEntrevista), GetType(TableLayoutPanel)
                    makeFormReadOnly(c)
            End Select
        Next
    End Sub

    Private Sub btnAgregarSClinico_Click(sender As Object, e As EventArgs) Handles btnAgregarSClinico.Click
        If String.IsNullOrWhiteSpace(txtSgClinico.Text) Then
            Exit Sub
        End If
        If Not lbSignosClinicos.Items.Contains(txtSgClinico.Text) Then
            lbSignosClinicos.Items.Add(txtSgClinico.Text)
            Dim sg As New E_SignoClinico
            sg.Nombre = txtSgClinico.Text
            Entrevista.MiFormulario.Enfermedad.SignosClinicos.Add(sg)
            txtSgClinico.Clear()
        Else
            MessageBox.Show("Ese signo clínico ya fue ingresado")
        End If

    End Sub

    Private Sub btnAgregarSintoma_Click(sender As Object, e As EventArgs) Handles btnAgregarSintoma.Click
        If String.IsNullOrWhiteSpace(txtSintoma.Text) Then
            Exit Sub
        End If
        If Not lbSintomas.Items.Contains(txtSintoma.Text) Then
            lbSintomas.Items.Add(txtSintoma.Text)
            Dim sintoma As New E_Sintoma With {
                .Nombre = txtSintoma.Text
            }
            Entrevista.MiFormulario.Enfermedad.Sintomas.Add(sintoma)
            txtSintoma.Clear()
        Else
            MessageBox.Show("Ese síntoma ya fue ingresado")
        End If
    End Sub

    Private Sub btnBorrarSintoma_Click(sender As Object, e As EventArgs) Handles btnBorrarSintoma.Click
        If lbSintomas.SelectedItem IsNot String.Empty Then
            Entrevista.MiFormulario.Enfermedad.Sintomas.Remove(Entrevista.MiFormulario.Enfermedad.Sintomas.Find(Function(p) p.Nombre = lbSintomas.SelectedItem.ToString()))
            lbSintomas.Items.Remove(lbSintomas.SelectedItem)
        End If
    End Sub

    Private Sub btnBorrarSigno_Click(sender As Object, e As EventArgs) Handles btnBorrarSigno.Click
        If lbSignosClinicos.SelectedItem IsNot String.Empty Then
            Entrevista.MiFormulario.Enfermedad.SignosClinicos.Remove(Entrevista.MiFormulario.Enfermedad.SignosClinicos.Find(Function(p) p.Nombre = lbSignosClinicos.SelectedItem.ToString()))
            lbSignosClinicos.Items.Remove(lbSignosClinicos.SelectedItem)
        End If
    End Sub

    Private Sub chkEnfermo_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnfermo.CheckedChanged
        If chkEnfermo.Checked Then
            lblPresenta.Visible = True
            txtNomEnfermedad.Visible = True
        Else
            lblPresenta.Visible = False
            txtNomEnfermedad.Visible = False
            txtNomEnfermedad.Text = ""
        End If
    End Sub

    Private Sub chkAnalisis_CheckedChanged(sender As Object, e As EventArgs) Handles chkAnalisis.CheckedChanged, txtNomAnalisis.Click
        If chkAnalisis.Checked Then
            lblAnalisisReq.Visible = True
            txtNomAnalisis.Visible = True
            Dim frmAsignarA As New frmAnalisisSeguimiento
            frmAsignarA.ShowDialog()
            If frmAsignarA.AnalisisSelect IsNot Nothing Then
                Entrevista.MiFormulario.Analisis = frmAsignarA.AnalisisSelect
            End If
        Else
            lblAnalisisReq.Visible = False
            txtNomAnalisis.Visible = False
            txtNomAnalisis.Clear()
            Entrevista.MiFormulario.Analisis = Nothing
        End If
    End Sub
    Private Sub chkTratamiento_CheckedChanged(sender As Object, e As EventArgs) Handles chkTratamiento.CheckedChanged, txtNomTratamiento.Click
        If chkTratamiento.Checked Then
            lblTratamientoS.Visible = True
            txtNomTratamiento.Visible = True
            Dim frmAsignarT As New frmTratamientoCrear
            frmAsignarT.ModoActual = frmTratamientoCrear.Modo.Asignar
            frmAsignarT.ShowDialog()
            If frmAsignarT.TratamientoSeleccionado IsNot Nothing Then
                Entrevista.MiFormulario.Tratamiento = frmAsignarT.TratamientoSeleccionado
            End If
        Else
            lblTratamientoS.Visible = False
            txtNomTratamiento.Visible = False
            txtNomTratamiento.Clear()
            Entrevista.MiFormulario.Tratamiento = Nothing
        End If
    End Sub

    Private Sub ContenedorEntrevistas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Eventos.Acciones = AccionesFrm

        Eventos.PrintDoc = New Printing.PrintDocument
        Eventos.Acciones.TopLevel = False
        Eventos.Acciones.TopMost = True

        Eventos.PanelDestino = Entrevista.pnlContenedor
        Eventos.FormDatos = Entrevista.MiFormulario
        Entrevista.TopMost = True
        Entrevista.TopLevel = False
        tbpEntrevista.Controls.Add(Entrevista)
        Entrevista.Visible = True
        Entrevista.Dock = DockStyle.Fill
        tpResolucion.Controls.Add(Eventos.Acciones)

        Eventos.Acciones.Dock = DockStyle.Bottom
        Eventos.Acciones.Visible = True
        Eventos.AgregarHandlers()
    End Sub

    Private Sub btnSugerirDiagnostico_Click(sender As Object, e As EventArgs) Handles btnSugerirDiagnostico.Click
        MsgBox("Aun no implementado.")
        'ejecutar los procedimientos Sugerir[{enfermedad,tratamiento,analisis}] según [{pyr,sintomas,signos clinicos}]
    End Sub
    Private Sub txtNomEnfermedad_TextChanged(sender As Object, e As EventArgs) Handles txtNomEnfermedad.TextChanged
        Entrevista.MiFormulario.Enfermedad.Nombre = txtNomEnfermedad.Text
    End Sub
    Public Sub FinalizarConsulta() 'llamo a este metodo desde frmMedico.FinalizarConsultaToolStripMenuItem_Click
        Eventos.Guardar()
    End Sub
End Class
