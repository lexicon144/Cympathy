Public Class ImpConStringBuilderDeployment
    Implements IConStringBuilder

    Public Function ConnString() As String Implements IConStringBuilder.ConnString
        Dim abc As New MySqlConnectionStringBuilder

        With abc
            .UserID = "cympathy"
            .Password = "NEONBEACH"
            .Server = My.Settings.city85
            .Database = "we_learndb"
        End With

        Return abc.ToString

    End Function
End Class
