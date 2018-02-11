Public Class ImpGetDateOnServer
    Implements IGetDate
    Private MySqlDate As DateTime

    Public Function GetDate() As Date Implements IGetDate.GetDate

        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Using Command As New MySqlCommand
                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "GetNowDateScalar"
                    MySqlDate = .ExecuteScalar()
                End With
            End Using
        End Using
        Return MySqlDate
    End Function
End Class
