Public Class E_Enfermedad
    Protected _nombre As String
    Protected _descripcion As String
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

    Public Class Clasificacion
        Protected _nombre_e As String
        Protected _nombre_cat As String
        Property NombreEnfermedad As String
            Get
                Return _nombre_e
            End Get
            Set(value As String)
                _nombre_e = value
            End Set
        End Property

        Property NombreCategoria As String
            Get
                Return _nombre_cat
            End Get
            Set(value As String)
                _nombre_cat = value
            End Set
        End Property

        Sub New()

        End Sub

        Sub New(nombre_e As String, nom_categoria As String)
            _nombre_e = nombre_e
            _nombre_cat = nom_categoria
        End Sub

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

        Sub New()

        End Sub

        Sub New(nombre As String, descripcion As String)
            _nombre = nombre
            _descripcion = descripcion
        End Sub

        Public Class SubCategoria
            Protected _categoria_padre As String
            Protected _nombre As String
            Protected _descripcion As String

            Property CategoriaPadre As String
                Get
                    Return _categoria_padre
                End Get
                Set(value As String)
                    _categoria_padre = value
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
            Property Descripcion As String
                Get
                    Return _descripcion
                End Get
                Set(value As String)
                    _descripcion = value
                End Set
            End Property

            Sub New()

            End Sub

            Sub New(categoria_padre As String, nombre As String, descripcion As String)
                _categoria_padre = categoria_padre
                _nombre = nombre
                _descripcion = descripcion
            End Sub

        End Class

    End Class

End Class
