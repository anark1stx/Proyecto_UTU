
Public Class GestorXMLv2
    Function Serializar(Of T As Class)(ByVal obj As T) As String

        Dim xmlSerializer As Xml.Serialization.XmlSerializer = New Xml.Serialization.XmlSerializer(obj.[GetType]())

        Using wr As IO.StringWriter = New IO.StringWriter()
            xmlSerializer.Serialize(wr, obj)

            Return wr.ToString()
        End Using

    End Function

    Function Deserializar(Of T As Class)(input As String) As T 'Uso de Generics para poder deserializar objetos serializados

        Dim ser As New Xml.Serialization.XmlSerializer(GetType(T))

        Using sr As IO.StringReader = New IO.StringReader(input)

            Return CType(ser.Deserialize(sr), T)

        End Using

    End Function
End Class
