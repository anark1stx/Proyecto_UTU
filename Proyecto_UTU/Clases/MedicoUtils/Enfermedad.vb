Public Class Enfermedad
    Protected _nombre As String
    Protected _descripcion As String
    Protected _categorias As List(Of Categoria)
    Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Property Descripcion As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Property Categorias As List(Of Categoria)
        Get
            Return _categorias
        End Get
        Set(value As List(Of Categoria))
            _categorias = value
        End Set
    End Property

    Public Class Clasificacion
        Protected _nombre
        Protected _descripcion
        Protected _categoria As Categoria
        Property Nombre As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property

        Property Descripcion As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property

        Property Categoria As Categoria
            Get
                Return _categoria
            End Get
            Set(value As Categoria)
                _categoria = value
            End Set
        End Property

    End Class
    Public Class Categoria
        Protected _nombre
        Protected _descripcion
        Property Nombre As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property

        Property Descripcion As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property

    End Class



End Class
