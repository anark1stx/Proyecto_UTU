Imports System.Windows.Forms
Imports System.Drawing
<Serializable()>
Public Class ControlesGuardados
    <Xml.Serialization.XmlInclude(GetType(Panel)), Xml.Serialization.XmlInclude(GetType(TextControl)), Xml.Serialization.XmlInclude(GetType(Button)), Xml.Serialization.XmlInclude(GetType(TableLayoutPanel)), Xml.Serialization.XmlInclude(GetType(TabControl)), Xml.Serialization.XmlInclude(GetType(TabPage))> 'Todos los controles que heredan directamente de SControl
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
        <Xml.Serialization.XmlIgnore>
        Public _tag As String

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

        Property Tag As String
            Get
                Return _tag
            End Get
            Set(value As String)
                _tag = value
            End Set
        End Property
        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, tag As String)

            _posicion = posicion
            _tamano = tamano
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            _tag = tag
        End Sub

        Sub New()

        End Sub

    End Class
    <Xml.Serialization.XmlInclude(GetType(GroupBox)), Xml.Serialization.XmlInclude(GetType(Textbox)), Xml.Serialization.XmlInclude(GetType(Label)), Xml.Serialization.XmlInclude(GetType(ListBox)), Xml.Serialization.XmlInclude(GetType(CheckBox))>
    Public Class TextControl 'Aquellos controles que tienen Texto
        Inherits SControl
        <Xml.Serialization.XmlIgnore>
        Public _Texto As String
        <Xml.Serialization.XmlIgnore>
        Public _font As String
        <Xml.Serialization.XmlIgnore>
        Public _multiline As Boolean
        Property Text As String
            Get
                Return _Texto
            End Get
            Set(value As String)
                _Texto = value
            End Set
        End Property
        Property Multiline As Boolean
            Get
                Return _multiline
            End Get
            Set(value As Boolean)
                _multiline = value
            End Set
        End Property
        Property Font As String
            Get
                Return _font
            End Get
            Set(value As String)
                _font = value
            End Set
        End Property
        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, Texto As String, font As Font, multiline As Boolean, tag As String)

            _posicion = posicion
            _tamano = tamano
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            _Texto = Texto
            _font = FontToStr(font)
            _multiline = multiline
            _tag = tag
        End Sub
        Sub New()

        End Sub

        Public Function StrToFont() As Font

            Dim fntConverter As New FontConverter()

            Return fntConverter.ConvertFromString(_font)

        End Function
        Public Function FontToStr(fnt As Font) As String

            Dim fntConverter As New FontConverter()

            Return fntConverter.ConvertToString(fnt)

        End Function


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
        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, autoScroll As Boolean, childs As List(Of SControl))

            _posicion = posicion
            _tamano = tamano
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            _autoScroll = autoScroll
            _childs = childs
        End Sub
    End Class
    Public Class GroupBox
        Inherits TextControl 'Los groupBoxes suelen tener un Texto.
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
        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, Texto As String, Childs As List(Of SControl), font As Font)

            _posicion = posicion
            _tamano = tamano
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            _Texto = Texto
            _childs = Childs
            _font = FontToStr(font)
        End Sub
    End Class

    Public Class TableLayoutPanel 'Si bien TBL esta compuesto de paneles, no nos interesa guardar si tiene autoScroll.
        Inherits SControl
        <Xml.Serialization.XmlIgnore>
        Public __childs As List(Of TBLControl)
        <Xml.Serialization.XmlIgnore>
        Public _rows As Integer 'cantidad de filas de la tbl
        <Xml.Serialization.XmlIgnore>
        Public _cols As Integer 'Cantidad de las columnas de la tbl
        Property ChildsTuple As List(Of TBLControl)
            Get
                Return __childs
            End Get
            Set(value As List(Of TBLControl))
                __childs = value
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


        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, childs As List(Of TBLControl), cols As Integer, rows As Integer)
            _posicion = posicion
            _tamano = tamano
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            __childs = childs
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
        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, Texto As String, font As Font, multiline As Boolean, tag As String)

            _posicion = posicion
            _tamano = tamano
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            _Texto = Texto
            _font = FontToStr(font)
            _multiline = multiline
            _tag = tag
        End Sub
    End Class

    Public Class Label
        Inherits TextControl
        Sub New()

        End Sub
        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, Texto As String, font As Font, tag As String)

            _posicion = posicion
            _tamano = tamano
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            _Texto = Texto
            _font = FontToStr(font)
            _tag = tag
        End Sub
    End Class

    Public Class Button
        Inherits SControl
        <Xml.Serialization.XmlIgnore>
        Public _bgImage As String 'String en base64
        <Xml.Serialization.XmlIgnore>
        Public _bgLayout As ImageLayout
        Property bgImage As String
            Get
                Return _bgImage
            End Get
            Set(value As String)

                _bgImage = value

            End Set
        End Property
        Property bgLayout As ImageLayout
            Get
                Return _bgLayout
            End Get
            Set(value As ImageLayout)

                _bgLayout = value

            End Set
        End Property
        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, bg_Image As Bitmap, bg_Layout As ImageLayout, tag As String)

            _posicion = posicion
            _tamano = tamano
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            _bgImage = BmpToStrB64(bg_Image)
            _bgLayout = bg_Layout
            _tag = tag
        End Sub

        Sub New()

        End Sub

        Public Function B64strToBmp() As Bitmap
            If Not _bgImage = String.Empty Then
                Dim ms As New IO.MemoryStream(Convert.FromBase64String(_bgImage))
                Return Bitmap.FromStream(ms)
                ms.Close()
            End If
            Return Nothing
        End Function

        Public Function BmpToStrB64(bmp As Bitmap) As String

            If Not bmp Is Nothing Then
                Dim ms As New IO.MemoryStream()
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                Return Convert.ToBase64String(ms.ToArray())
                ms.Close()
            End If

            Return String.Empty
        End Function

    End Class
    <Xml.Serialization.XmlInclude(GetType(ComboBox))>
    Public Class ListBox
        Inherits TextControl 'Los items tienen fuente.
        <Xml.Serialization.XmlIgnore>
        Public _items As New List(Of String)

        Property items As List(Of String)
            Get
                Return _items
            End Get
            Set(value As List(Of String))
                _items = value
            End Set
        End Property
        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, items As List(Of String), font As Font)

            _posicion = posicion
            _tamano = tamano
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            _items = items
            _font = FontToStr(font)
        End Sub

        Sub New()

        End Sub
    End Class

    Public Class CheckBox
        Inherits TextControl
        Sub New()

        End Sub
        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, Texto As String, font As Font, tag As String)
            _posicion = posicion
            _tamano = tamano
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            _Texto = Texto
            _font = FontToStr(font)
            _tag = tag
        End Sub
    End Class

    Public Class ComboBox
        Inherits ListBox 'Si bien ComboBox no es un ListBox, este tendría las mismas propiedades.
        Sub New()

        End Sub
        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, anchor As AnchorStyles, fg As String, bg As String, items As List(Of String), font As Font, tag As String)

            _posicion = posicion
            _tamano = tamano
            _nombre = nombre
            _dock = dock
            _anchor = anchor
            _fgColor = fg
            _bgColor = bg
            _items = items
            _font = FontToStr(font)
            _tag = tag
        End Sub
    End Class

    Public Class TabControl
        Inherits SControl
        <Xml.Serialization.XmlIgnore>
        Public _Pages As List(Of TabPage)

        Property Pages As List(Of TabPage)
            Get
                Return _Pages
            End Get
            Set(value As List(Of TabPage))
                _Pages = value
            End Set
        End Property

        Sub New()

        End Sub

        Sub New(posicion As Point, tamano As Size, nombre As String, dock As DockStyle, bg As String, pages As List(Of TabPage))

            _posicion = posicion
            _tamano = tamano
            _nombre = nombre
            _dock = dock
            _anchor = Anchor
            _bgColor = bg
            _Pages = pages
        End Sub

    End Class

    Public Class TabPage
        Inherits Panel
        <Xml.Serialization.XmlIgnore>
        Public _texto As String

        Property Texto As String
            Get
                Return _texto
            End Get
            Set(value As String)
                _texto = value
            End Set
        End Property

        Sub New()

        End Sub

        Sub New(posicion As Point, tamano As Size, nombre As String, bg As String, childs As List(Of SControl), autoScroll As Boolean, texto As String)
            _posicion = posicion
            _tamano = tamano
            _nombre = nombre
            _dock = Dock
            _anchor = Anchor
            _bgColor = bg
            _childs = childs
            _autoScroll = autoScroll
            _texto = texto

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

    Public Class TBLControl 'CHILD,COL,ROW
        <Xml.Serialization.XmlIgnore>
        Protected _control As SControl
        <Xml.Serialization.XmlIgnore>
        Protected _colIndex As Integer
        <Xml.Serialization.XmlIgnore>
        Protected _rowIndex As Integer

        Property Control As SControl
            Get
                Return _control
            End Get
            Set(value As SControl)
                _control = value
            End Set
        End Property

        Property ColIndex As Integer
            Get
                Return _colIndex
            End Get
            Set(value As Integer)
                _colIndex = value
            End Set
        End Property
        Property RowIndex As Integer
            Get
                Return _rowIndex
            End Get
            Set(value As Integer)
                _rowIndex = value
            End Set
        End Property

        Public Sub New()

        End Sub

        Public Sub New(control As SControl, colIndex As Integer, rowIndex As Integer)
            _control = control
            _colIndex = colIndex
            _rowIndex = rowIndex
        End Sub

    End Class

End Class
