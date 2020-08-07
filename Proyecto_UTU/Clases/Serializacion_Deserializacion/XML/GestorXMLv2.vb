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

    Sub buildXML(controles_a_guardar As ControlesGuardados.ListaControles)
        Dim fname As String = "C:/Users/Mat/Desktop/test.xml"
        Console.WriteLine("Writing")
        Dim serializer As New Xml.Serialization.XmlSerializer(controles_a_guardar.GetType())

        Dim file As New System.IO.StreamWriter(fname)

        serializer.Serialize(file, controles_a_guardar)

        file.Close()
    End Sub




End Class
