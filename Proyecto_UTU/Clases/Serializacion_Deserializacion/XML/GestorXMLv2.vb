
Public Class GestorXMLv2

    Protected _header As String = "<?xml version='1.0' encoding='UTF-8' standalone='yes' ?>" 'Encabezado del XML, puede ser util cambiarlo en algun momento.
    Protected _xmlString As String 'String que contiene toda la estructura XML.

    Property header As String
        Get
            Return _header
        End Get
        Set(value As String)
            _header = value
        End Set
    End Property

    Property xmlString As String
        Get
            Return _xmlString
        End Get
        Set(value As String)
            _xmlString = value
        End Set
    End Property

    'Sub buildXML(controles_a_guardar As ControlesGuardados.ListaControles)
    '    Dim fname As String = "C:/Users/Mat/Desktop/test.xml"
    '    Console.WriteLine("Writing")
    '    Dim serializer As New Xml.Serialization.XmlSerializer(controles_a_guardar.GetType())

    '    Dim file As New System.IO.StreamWriter(fname)

    '    serializer.Serialize(file, controles_a_guardar)

    '    file.Close()
    'End Sub

    Function buildXML(Of T As Class)(ByVal obj As T) As String

        Dim xmlSerializer As Xml.Serialization.XmlSerializer = New Xml.Serialization.XmlSerializer(obj.[GetType]())

        Using wr As IO.StringWriter = New IO.StringWriter()
            xmlSerializer.Serialize(wr, obj)

            Return wr.ToString()
        End Using

    End Function


    'path As String
    Function Deserializar(Of T As Class)(input As String) As T 'Uso de Generics para poder deserializar objetos serializados

        Dim ser As New Xml.Serialization.XmlSerializer(GetType(T))

        Using sr As IO.StringReader = New IO.StringReader(input)

            Return CType(ser.Deserialize(sr), T)

        End Using

    End Function




End Class
