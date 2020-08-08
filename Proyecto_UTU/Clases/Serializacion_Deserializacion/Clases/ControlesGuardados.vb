<Serializable()>
Public Class ControlesGuardados 'Xml.Serialization.XmlInclude(GetType(ListaControles)),
    <Xml.Serialization.XmlInclude(GetType(Panel)), Xml.Serialization.XmlInclude(GetType(TextControl)), Xml.Serialization.XmlInclude(GetType(Button))> 'Todos los controles que heredan directamente de SControl
    Public Class SControl 'Posicion, Nombre y tamaño son las unicas dos propiedades que vamos a tomar de todos los controles de forma obligatoria.
        <Xml.Serialization.XmlIgnore>
        Public _posicion As Point
        <Xml.Serialization.XmlIgnore>
        Public _tamano As Size
        <Xml.Serialization.XmlIgnore>
        Public _nombre As String
        <Xml.Serialization.XmlIgnore>
        Public _dock As DockStyle
        <Xml.Serialization.XmlIgnore>
        Public _anchor As AnchorStyles
        <Xml.Serialization.XmlIgnore>
        Public _fgColor As String
        <Xml.Serialization.XmlIgnore>
        Public _bgColor As String
        Property Posicion As Point
            Get
                Return _posicion
            End Get
            Set(value As Point)
                _posicion = value
            End Set
        End Property
        Property Tamano As Size
            Get
                Return _tamano
            End Get
            Set(value As Size)
                _tamano = value
            End Set
        End Property

        Property Nombre As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property
        Property Dock As DockStyle
            Get
                Return _dock
            End Get
            Set(value As DockStyle)
                _dock = value
            End Set
        End Property

        Property Anchor As AnchorStyles
            Get
                Return _anchor
            End Get
            Set(value As AnchorStyles)
                _anchor = value
            End Set
        End Property

        Property ForeColor As String
            Get
                Return _fgColor
            End Get
            Set(value As String)
                _fgColor = value
            End Set
        End Property
        Property BackColor As String
            Get
                Return _bgColor
            End Get
            Set(value As String)
                _bgColor = value
            End Set
        End Property
        'tipo As TipoControl
        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String)

            _posicion = posicion
            _tamano = tamano
            '_tipo = tipo
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
        End Sub

        Sub New()

        End Sub

    End Class
    <Xml.Serialization.XmlInclude(GetType(GroupBox)), Xml.Serialization.XmlInclude(GetType(Textbox)), Xml.Serialization.XmlInclude(GetType(Label)), Xml.Serialization.XmlInclude(GetType(ListBox)), Xml.Serialization.XmlInclude(GetType(CheckBox))>
    Public Class TextControl 'Aquellos controles que tienen texto
        Inherits SControl
        <Xml.Serialization.XmlIgnore>
        Public _texto As String
        'Public _font As Font
        Property text As String
            Get
                Return _texto
            End Get
            Set(value As String)
                _texto = value
            End Set
        End Property
        'Property fuente As Font
        '    Get
        '        Return
        '    End Get
        '    Set(value As Font)
        '        _font = value
        '    End Set
        'End Property
        'tipo As TipoControl
        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, texto As String)

            _posicion = posicion
            _tamano = tamano
            '_tipo = tipo
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            _texto = texto
            '_font = fuente
        End Sub
        Sub New()

        End Sub
    End Class
    Public Class Panel
        Inherits SControl
        <Xml.Serialization.XmlIgnore>
        Public _autoScroll As Boolean
        <Xml.Serialization.XmlIgnore>
        Public _childs As List(Of SControl)

        Property AutoScroll As Boolean
            Get
                Return _autoScroll
            End Get
            Set(value As Boolean)
                _autoScroll = value
            End Set
        End Property
        Property Childs As List(Of SControl)
            Get
                Return _childs
            End Get
            Set(value As List(Of SControl))
                _childs = value
            End Set
        End Property

        Sub New()

        End Sub
        'tipo As TipoControl
        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, autoSctroll As Boolean, childs As List(Of SControl))

            _posicion = posicion
            _tamano = tamano
            '_tipo = tipo
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            _autoScroll = autoSctroll
            _childs = childs
        End Sub
    End Class
    Public Class GroupBox
        Inherits TextControl 'Los groupBoxes suelen tener un texto.
        <Xml.Serialization.XmlIgnore>
        Public _childs As List(Of SControl)
        Property Childs As List(Of SControl)
            Get
                Return _childs
            End Get
            Set(value As List(Of SControl))
                _childs = value
            End Set
        End Property
        Sub New()

        End Sub
        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, texto As String, Childs As List(Of SControl))

            _posicion = posicion
            _tamano = tamano
            '_tipo = tipo
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            _texto = texto
            '_font = fuente
            _childs = Childs
        End Sub
    End Class

    Public Class TableLayoutPanel 'Si bien TBL esta compuesto de paneles, no nos interesa guardar si tiene autoScroll.
        Inherits SControl
        Public _childs As List(Of SControl)
        Public _rows As Integer 'cantidad de filas de la tbl
        Public _cols As Integer 'Cantidad de las columnas de la tbl

        Property Childs As List(Of SControl)
            Get
                Return _childs
            End Get
            Set(value As List(Of SControl))
                _childs = value
            End Set
        End Property

        Property Cols As Integer
            Get
                Return _cols
            End Get
            Set(value As Integer)
                _cols = value
            End Set
        End Property

        Property Rows As Integer
            Get
                Return _rows
            End Get
            Set(value As Integer)
                _rows = value
            End Set
        End Property

        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, texto As String, Childs As List(Of SControl), cols As Integer, rows As Integer)
            _posicion = posicion
            _tamano = tamano
            '_tipo = tipo
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            '_font = fuente
            _childs = Childs
            _cols = cols
            _rows = rows
        End Sub

        Sub New()

        End Sub

    End Class

    Public Class Textbox
        Inherits TextControl
        Sub New()

        End Sub
        'tipo As TipoControl
        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, texto As String)

            _posicion = posicion
            _tamano = tamano
            '_tipo = tipo
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            _texto = texto
            '_font = fuente
        End Sub
    End Class

    Public Class Label
        Inherits TextControl
        Sub New()

        End Sub
        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, texto As String)

            _posicion = posicion
            _tamano = tamano
            '_tipo = tipo
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            _texto = texto
            '_font = fuente
        End Sub
    End Class

    Public Class Button
        Inherits SControl
        <Xml.Serialization.XmlIgnore>
        Public _bgImage As String 'String en base64

        Property bgImage As String
            Get
                Return _bgImage
            End Get
            Set(value As String)

                _bgImage = value

            End Set
        End Property
        'tipo As TipoControl
        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, bg_Image As Bitmap)

            _posicion = posicion
            _tamano = tamano
            '_tipo = tipo
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            _bgImage = BmpToStrB64(bg_Image)
        End Sub

        Sub New()

        End Sub

        Public Function B64strToBmp() As Bitmap
            Dim ms As New IO.MemoryStream(Convert.FromBase64String(_bgImage))
            Return Bitmap.FromStream(ms)
            ms.Close()
        End Function

        Public Function BmpToStrB64(bmp As Bitmap) As String

            If Not bmp Is Nothing Then
                Dim ms As New IO.MemoryStream()
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                Return Convert.ToBase64String(ms.ToArray())
                ms.Close()
            End If

            Return 0
        End Function

    End Class
    <Xml.Serialization.XmlInclude(GetType(ComboBox))>
    Public Class ListBox
        Inherits TextControl 'Los items tienen fuente.
        <Xml.Serialization.XmlIgnore>
        Public _items As String()

        Property items As String()
            Get
                Return _items
            End Get
            Set(value As String())
                _items = value
            End Set
        End Property
        'tipo As TipoControl
        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, items As String())

            _posicion = posicion
            _tamano = tamano
            '_tipo = tipo
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            _items = items
            '_font = font
        End Sub

        Sub New()

        End Sub
    End Class

    Public Class CheckBox
        Inherits TextControl
        Sub New()

        End Sub
        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, texto As String)

            _posicion = posicion
            _tamano = tamano
            '_tipo = tipo
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            _texto = texto
            '_font = fuente
        End Sub
    End Class

    Public Class ComboBox
        Inherits ListBox 'Si bien ComboBox no es un ListBox, este tendría las mismas propiedades.
        Sub New()

        End Sub
        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, items As String())

            _posicion = posicion
            _tamano = tamano
            '_tipo = tipo
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            _items = items
        End Sub
    End Class

    Public Class ListaControles
        <Xml.Serialization.XmlIgnore>
        Public _Controles As List(Of SControl)
        Public Property Controles As List(Of SControl)
            Get
                Return _Controles
            End Get
            Set(value As List(Of SControl))
                _Controles = value
            End Set
        End Property
        Public Sub New()

        End Sub
        Public Sub New(controles As List(Of SControl))
            _Controles = controles
        End Sub

    End Class

End Class
