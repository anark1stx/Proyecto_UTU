Public Class Tratamiento
    Protected _id As Integer
    Protected _nombre As String
    Protected _descripcion As String

    Public Class Sigue 'Sigue es la relacion entre paciente y tratamiento
        Protected _ciPaciente As String
        Protected _id_tratamiento As Integer
        Protected _fecha_inicio As Date
        Protected _fecha_fin As Date
        Protected _resultado As String

        Property CiPaciente
            Get
                Return _ciPaciente
            End Get
            Set(value)
                _ciPaciente = value
            End Set
        End Property

        Property ID_Tratamiento As Integer
            Get
                Return _id_tratamiento
            End Get
            Set(value As Integer)
                _id_tratamiento = value
            End Set
        End Property

        Property Fecha_Inicio As Date
            Get
                Return _fecha_inicio
            End Get
            Set(value As Date)
                _fecha_inicio = value
            End Set
        End Property

        Property Fecha_Fin As Date
            Get
                Return _fecha_fin
            End Get
            Set(value As Date)
                _fecha_fin = value
            End Set
        End Property

        Property Resultado As String
            Get
                Return _resultado
            End Get
            Set(value As String)
                _resultado = value
            End Set
        End Property

        Sub New()

        End Sub

        Sub New(CI As String, id_trat As Integer, fechaIni As Date, fechaFin As Date)
            _ciPaciente = CI
            _id_tratamiento = id_trat
            _fecha_inicio = fechaIni
            _fecha_fin = fechaFin
        End Sub

    End Class

    Public Class Seguimiento 'Seguimiento es el dia a dia de el tratamiento que esta siguiendo el paciente (atributo multivaluado de la tabla Sigue que genera tabla)
        Protected _ciPaciente As String
        Protected _id_tratamiento As Integer
        Protected _fecha As Date
        Protected _descripcion As String

        Property CiPaciente
            Get
                Return _ciPaciente
            End Get
            Set(value)
                _ciPaciente = value
            End Set
        End Property

        Property ID_Tratamiento As Integer
            Get
                Return _id_tratamiento
            End Get
            Set(value As Integer)
                _id_tratamiento = value
            End Set
        End Property

        Property Fecha As Date
            Get
                Return _fecha
            End Get
            Set(value As Date)
                _fecha = value
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

        Sub New(CI As String, id_trat As Integer, fecha As Date, descripcion As String)
            _ciPaciente = CI
            _id_tratamiento = id_trat
            _fecha = fecha
            _descripcion = descripcion
        End Sub

    End Class

End Class
