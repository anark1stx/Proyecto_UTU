Imports Entidades
Imports Negocio
Public Class frmAnalisisSeguimiento
    Dim frmDatos As New frmDatosAnalisis
    Protected _analisisSelect As New E_Analisis

    Protected _modo
    Public Enum Modo
        Buscar 'buscamos x ci a los pacientes y mostramos sus datos
        Asignar 'habilito la busqueda de analisis x nombre y se la asigno a pacientes
    End Enum

    Property MiModo As Modo
        Get
            Return _modo
        End Get
        Set(value As Modo)
            _modo = value
        End Set
    End Property

    Property AnalisisSelect As E_Analisis
        Get
            Return _analisisSelect
        End Get
        Set(value As E_Analisis)
            _analisisSelect = value
        End Set
    End Property

    Private Sub btnIngresarDatos_Click(sender As Object, e As EventArgs) Handles btnIngresarDatos.Click

        Select Case MiModo
            Case Modo.Buscar
                '1- Verificar que ese análisis aún no se haya llenado
                '2- Abrir formulario de datos en modo de ingreso (campos con textbox)
            Case Modo.Asignar
                'asignar el analisis seleccionado
        End Select
    End Sub

    Private Sub btnConsultarDatos_Click(sender As Object, e As EventArgs) Handles btnConsultarDatos.Click
        '-1 Abrir formulario de datos en modo de lectura (todo con labels)
    End Sub

    Public Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Select Case MiModo
            Case Modo.Buscar 'busco pacientes x ci

            Case Modo.Asignar 'busco analisis x nombre
        End Select
    End Sub

    Sub resetMode()
        Select Case MiModo
            Case Modo.Buscar 'dejar todo normal
                lblCedulaPaciente.Text = "Cédula del paciente:"
                btnConsultarDatos.Text = "Consultar datos"
                btnIngresarDatos.Text = "Ingresar datos"
                btnConsultarDatos.Visible = True
                tblAcciones.SetColumnSpan(btnIngresarDatos, 1)
            Case Modo.Asignar
                lblCedulaPaciente.Text = "Nombre del análisis:"
                btnIngresarDatos.Text = "Asignar"
                btnConsultarDatos.Visible = False
                tblAcciones.SetColumnSpan(btnIngresarDatos, 2)
        End Select
    End Sub

End Class