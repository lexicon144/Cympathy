Public Interface IDataDeserializer

    ''' <summary>
    ''' Use this to Deserialize the data
    ''' </summary>
    ''' <param name="data">XML String to return</param>
    ''' <returns>c_ShortQuiz</returns>
    ''' <remarks></remarks>
    Function DataDeserialize(ByVal data As String) As List(Of c_SmallQuestion)
        
End Interface
