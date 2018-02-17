Public Class ImpTimeMapperOut
    Implements ITimeMapper

    Public Sub New()
        Console.WriteLine("New {0}", Me.ToString)
    End Sub

    Public Sub TimeIn(ByRef UserID As String, ByRef ClassroomID As String) Implements ITimeMapper.TimeMapper

        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Dim MapperTransaction As MySqlTransaction = Connection.BeginTransaction
            Try
                Using Command As New MySqlCommand
                    With Command
                        .Connection = Connection
                        .CommandText = "InsertTimeOut"
                        .CommandType = CommandType.StoredProcedure
                        With .Parameters
                            .AddWithValue("UserID", UserID)
                            .AddWithValue("ClassroomID", ClassroomID)
                        End With
                    End With
                End Using
            Catch XXX As Exception
                WeLearnMessageDisplay.Display(WeLearnExceptions.General, Me, XXX)
            End Try
        End Using
    End Sub
End Class
