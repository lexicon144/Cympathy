Imports System.IO
Imports System.Xml.Serialization

Public Class ImpDataSerializer
    Implements IDataSerializer

    Public Sub New()

    End Sub

    ''' <summary>
    ''' Use this to Serialize the Data
    ''' </summary>
    ''' <param name="myList">C_Quiz to serialize</param>
    ''' <returns>XML String ready for being saved to the database</returns>
    ''' <remarks></remarks>
    Private Function DataSerialize(ByRef myList As List(Of c_SmallQuestion)) As String Implements IDataSerializer.DataSerialize

        Dim sw As New StringWriter
        Dim s As New XmlSerializer(myList.GetType())
        s.Serialize(sw, myList)
        Return sw.ToString()

    End Function
End Class
