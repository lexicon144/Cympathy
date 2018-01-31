Imports System.Xml.Serialization
Imports System.IO

Public Class ImpDataDeserializer
    Implements IDataDeserializer

    Public Sub New()

    End Sub

    ''' <summary>
    ''' Use this to Deserialize the data
    ''' </summary>
    ''' <param name="data">XML String to return</param>
    ''' <returns>c_ShortQuiz</returns>
    ''' <remarks></remarks>
    Public Function DataDeserialize(data As String) As List(Of c_SmallQuestion) Implements IDataDeserializer.DataDeserialize

        Dim xs As New XmlSerializer(GetType(List(Of c_SmallQuestion)))
        Dim newList As List(Of c_SmallQuestion) = CType(xs.Deserialize(New StringReader(data)), List(Of c_SmallQuestion))
        Return newList
    End Function
End Class
