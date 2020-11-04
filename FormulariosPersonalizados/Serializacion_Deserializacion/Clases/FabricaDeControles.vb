Imports System.Windows.Forms
Imports System.Drawing
Public Class FabricaDeControles
    'Serializar recibe controles de windows forms, y los transforma a Controles de la clase ControlesGuardados.
    Function Serializar(controles As List(Of Control)) As ControlesGuardados.ListaControles 'Guardar como los types que cree en ControlesGuardados

        Dim _lista As New List(Of ControlesGuardados.SControl)
        For Each c As Control In controles

            Select Case c.GetType()
                Case GetType(ComboBox)
                    _lista.Add(New ControlesGuardados.ComboBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), convertirItemsString(c), c.Font, c.Tag))
                Case GetType(Label)
                    _lista.Add(New ControlesGuardados.Label(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, c.Font, c.Tag))
                Case GetType(CheckBox)
                    _lista.Add(New ControlesGuardados.CheckBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, c.Font, c.Tag))
                Case GetType(TextBox)
                    _lista.Add(New ControlesGuardados.Textbox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.Text, c.Font, DirectCast(c, TextBox).Multiline, c.Tag))
                Case GetType(Button)
                    _lista.Add(New ControlesGuardados.Button(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), c.BackgroundImage, c.BackgroundImageLayout, c.Tag))
                Case GetType(ListBox)
                    _lista.Add(New ControlesGuardados.ListBox(c.Location, c.Size, c.Name, c.Dock, c.Anchor, ColorTOHTML(c.ForeColor), ColorTOHTML(c.BackColor), convertirItemsString(c), c.Font))
            End Select

        Next
        Dim lista As New ControlesGuardados.ListaControles(_lista)
        Return lista
    End Function

    Function Crear(controles As ControlesGuardados.ListaControles) As List(Of Control) 'Control de windows forms
        Dim lista As New List(Of Control)

        For Each c As ControlesGuardados.SControl In controles.Controles
            lista.Add(ConstruirControl(c))
        Next

        Return lista
    End Function

    Function ConstruirControl(Control As ControlesGuardados.SControl) As Control

        Select Case Control.GetType()
            Case GetType(ControlesGuardados.Button)
                Return buildButton(Control)
            Case GetType(ControlesGuardados.Textbox)
                Return buildTextBox(Control)
            Case GetType(ControlesGuardados.Label)
                Return buildLabel(Control)
            Case GetType(ControlesGuardados.CheckBox)
                Return buildCheckBox(Control)
            Case GetType(ControlesGuardados.ComboBox)
                Return buildComboBox(Control)
            Case GetType(ControlesGuardados.ListBox)
                Return buildListBox(Control)
            Case Else
                Return Nothing
        End Select

    End Function
    Private Function buildListBox(control As ControlesGuardados.ListBox) As ListBox
        Dim lb As New ListBox With {
            .Name = control.Nombre,
            .Location = control.Posicion,
            .Size = control.Tamano,
            .Dock = control.Dock,
            .Anchor = AnchorStyles.Top,
            .BackColor = HTMLTOColor(control.BackColor),
            .ForeColor = HTMLTOColor(control.ForeColor),
            .Text = control.Text,
            .Font = control.StrToFont()
        }
        For Each s As String In control.items
            lb.Items.Add(s)
        Next

        Return lb
    End Function
    Private Function buildComboBox(control As ControlesGuardados.ComboBox) As ComboBox
        Dim cb As New ComboBox With {
            .Name = control.Nombre,
            .Location = control.Posicion,
            .Size = control.Tamano,
            .Dock = control.Dock,
            .Anchor = AnchorStyles.Top,
            .BackColor = HTMLTOColor(control.BackColor),
            .ForeColor = HTMLTOColor(control.ForeColor),
            .Text = control.Text,
            .Font = control.StrToFont(),
            .Tag = control.Tag
        }
        For Each s As String In control.items
            cb.Items.Add(s)
        Next
        Return cb
    End Function

    Private Function buildCheckBox(control As ControlesGuardados.CheckBox) As CheckBox
        Return New CheckBox With {
            .Name = control.Nombre,
            .Location = control.Posicion,
            .Size = control.Tamano,
            .Dock = control.Dock,
            .Anchor = AnchorStyles.Top,
            .BackColor = HTMLTOColor(control.BackColor),
            .ForeColor = HTMLTOColor(control.ForeColor),
            .Text = control.Text,
            .Font = control.StrToFont(),
            .Tag = control.Tag,
            .CheckAlign = ContentAlignment.MiddleRight
        }
    End Function
    Function buildButton(control As ControlesGuardados.Button) As Button
        Dim btn As New Button With {
            .Name = control.Nombre,
            .Location = control.Posicion,
            .Size = control.Tamano,
            .Dock = control.Dock,
            .Anchor = AnchorStyles.Top,
            .BackColor = HTMLTOColor(control.BackColor),
            .ForeColor = HTMLTOColor(control.ForeColor),
            .Tag = control.Tag
        }

        If Not control.bgImage = String.Empty Then
            Try
                btn.BackgroundImage = control.B64strToBmp()
                btn.BackgroundImageLayout = control.bgLayout
            Catch ex As Exception
                Console.WriteLine("String no valido")
            End Try

        End If

        Return btn
    End Function
    Function buildTextBox(control As ControlesGuardados.Textbox) As TextBox
        Return New TextBox With {
            .Name = control.Nombre,
            .Location = control.Posicion,
            .Size = control.Tamano,
            .Dock = control.Dock,
            .Anchor = AnchorStyles.Top,
            .ForeColor = HTMLTOColor(control.ForeColor),
            .Text = control.Text,
            .Font = control.StrToFont(),
            .Multiline = control.Multiline,
            .Tag = control.Tag
        }
    End Function

    Function buildLabel(control As ControlesGuardados.Label) As Label
        Return New Label With {
            .Name = control.Nombre,
            .Location = control.Posicion,
            .Size = control.Tamano,
            .Dock = control.Dock,
            .Anchor = AnchorStyles.Top,
            .ForeColor = HTMLTOColor(control.ForeColor),
            .Text = control.Text,
            .Font = control.StrToFont(),
            .Tag = control.Tag
        }
    End Function

    Function convertirItemsString(control As Control) As List(Of String)
        Dim l As New List(Of String)

        Select Case control.GetType()
            Case GetType(ListBox)
                For Each i In DirectCast(control, ListBox).Items
                    l.Add(i.ToString())
                Next

            Case GetType(ComboBox)
                For Each i In DirectCast(control, ComboBox).Items
                    l.Add(i.ToString())
                Next

        End Select

        Return l
    End Function

End Class
