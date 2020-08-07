Public Class frmDiagnosticos
    'Dim gestor As New GestorXML
    Dim formulario_completo As New formularioPlano 'En esta variable va a ir guardado el formulario completo que diseño y lleno el medico
    Private Sub cbDiagnostico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDiagnostico.SelectedIndexChanged
        'Cargar el formulario que corresponde al item seleccionado: 
        'gestor.generarInstancias(...)

    End Sub

    Private Sub frmDiagnosticos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbVista.SelectedIndex = 1 '1=Formulario completo como lo diseño y guardo el medico ->Obviamente aún no implementado, requerimos conexión con la BD para cargar esos formularios
        '2=Formulario simple con tabs para facilitar la comprensión de los datos.
        tabPanelDiagnostico.Hide()
        '->Cargar el ultimo diagnostico que se le hizo desde la BD.
        Me.Dock = DockStyle.Fill
        cbDiagnostico.SelectedIndex = 0
    End Sub

    Private Sub cbVista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVista.SelectedIndexChanged
        Select Case cbVista.SelectedIndex
            Case 1
                tabPanelDiagnostico.Hide()
                'controls = gestor.generarInstancias(...)
                'formulario_completo.Controls.Add(controls)
                formulario_completo.TopLevel = False
                formulario_completo.TopMost = True
                formulario_completo.Anchor += AnchorStyles.Bottom
                formulario_completo.Anchor += AnchorStyles.Right
                formulario_completo.Dock = DockStyle.Fill
                pnlContenedorDiagnosticos.Controls.Add(formulario_completo)
                formulario_completo.Show()
            Case 0
                formulario_completo.Hide()
                'Con este es parecido, solo que en vez de cargar todos los controles con todos los datos, solo se cargan los datos que se piden en el diagnostico simple.
                tabPanelDiagnostico.Show()
                tabPanelDiagnostico.Anchor += AnchorStyles.Bottom
                tabPanelDiagnostico.Anchor += AnchorStyles.Right
                tabPanelDiagnostico.Dock = DockStyle.Fill


                Console.WriteLine(lblDescripcion.Location)
        End Select
    End Sub

End Class