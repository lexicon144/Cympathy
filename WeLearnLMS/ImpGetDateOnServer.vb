Public Class ImpGetDateOnServer
    Implements IGetDate

    Public Function GetDate() As Date Implements IGetDate.GetDate
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            Using Command As New MySqlCommand

                With Command

                End With

            End Using
        End Using

    End Function
End Class
