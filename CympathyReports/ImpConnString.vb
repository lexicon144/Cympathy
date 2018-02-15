Public Class ImpConnString
    Implements IConString

    Public Function ConnString() As String Implements IConString.ConnString
        Dim abc As New MySqlConnectionStringBuilder

        With abc
            .UserID = "cympathy"
            .Password = "8wJQdshQe8LyHAPX"
            .Server = My.Settings("city85")
            .Database = "we_learndb"
        End With

        Return abc.ToString

    End Function
End Class
