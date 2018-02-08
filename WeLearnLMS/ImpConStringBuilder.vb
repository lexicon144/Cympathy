Public Class ImpConStringBuilder
    Implements IConStringBuilder
    ''' <summary>
    ''' Return Current Implementation of ConStringBuilder
    ''' Use this Implementation as TESTING PURPOSES ONLY FOR LOCALHOST
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ConnString() As String Implements IConStringBuilder.ConnString
        Dim abc As New MySqlConnectionStringBuilder

        With abc
            .UserID = "root"
            .Password = ""
            .Server = My.Settings("city85")
            .Database = "we_learndb"
        End With

        Return abc.ToString

    End Function
End Class
