Imports System.IO

Module mdlUtilidades

    Public Function ImportarFormulario() As List(Of Control)

        Dim abrirFormulario As New OpenFileDialog
        abrirFormulario.Filter = "XML|*.xml"
        abrirFormulario.Title = "Abrir Formulario"
        abrirFormulario.RestoreDirectory = True
        Dim path As String = ""

        If abrirFormulario.ShowDialog() = DialogResult.OK Then
            path = System.IO.Path.GetFullPath(abrirFormulario.FileName.ToString())
            Dim contenido As String = File.ReadAllText(path)
            Dim gestor As New GestorXMLv2
            Dim fbr As New FabricaDeControles()
            Dim lista = gestor.Deserializar(Of ControlesGuardados.ListaControles)(contenido)

            Return fbr.Crear(lista)
        Else
            Return Nothing

        End If

    End Function

    Public Sub GuardarFormulario(lista_controles As ControlesGuardados.ListaControles)

        Dim archivo As New Xml.XmlDocument
        Dim gestor As New GestorXMLv2

        Dim xmlstring As String = gestor.buildXML(lista_controles)
        archivo.LoadXml(xmlstring)

        Dim guardarFormulario As New SaveFileDialog
        guardarFormulario.Filter = "XML|*.xml"
        guardarFormulario.Title = "Guardar Formulario"
        guardarFormulario.RestoreDirectory = True

        If guardarFormulario.ShowDialog() = DialogResult.OK Then
            Dim path As String = System.IO.Path.GetFullPath(guardarFormulario.FileName.ToString())
            archivo.Save(path)
        End If

    End Sub

    Public Function RemoverEspacios(str As String) As String
        Return str.Trim()
    End Function

    Public Sub LimpiarControles(contenedor As Control)
        For Each control As Control In contenedor.Controls

            Select Case control.GetType().ToString().Replace("System.Windows.Forms.", "")

                Case "TextBox"
                    Dim txt = DirectCast(control, TextBox)
                    txt.Text = String.Empty
                Case "ComboBox"
                    Dim cbox = DirectCast(control, ComboBox)

                    If cbox.DropDownStyle = ComboBoxStyle.DropDown Then
                        control.ResetText()
                    Else
                        cbox.SelectedIndex = 0
                    End If
                Case "CheckBox"
                    Dim chk = DirectCast(control, CheckBox)
                    chk.Checked = CheckState.Unchecked

                Case "DataGridView"
                    Dim dgw = DirectCast(control, DataGridView)
                    dgw.Rows.Clear()
            End Select
        Next
    End Sub

    Public Function ImprimirFormulario(pd As Printing.PrintDocument, landscape As Boolean, contenedor As Control, rect As Rectangle) As Bitmap

        pd.DefaultPageSettings.Landscape = landscape

        Dim memobmp = New Bitmap(contenedor.Width, contenedor.Height)

        contenedor.DrawToBitmap(memobmp, rect)

        Return memobmp
    End Function



End Module