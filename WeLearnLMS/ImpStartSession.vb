Public Class ImpStartSession


    Private _CookieString As String = ""
    Private _Hasher As IHashing = New StrategyHashingSHA512
    Private _UserID, _UserName As String


    Public Sub New()
        Console.WriteLine("NYOOOM is Powered by Cympathy")
    End Sub

    Friend Sub MakeNyoooms(ByRef UserName As String)
        Dim NYOOOM As String = Application.StartupPath & "\foo\" & UserName & ".nyooom"
        'CLEAN SESSION
        Using objWriter As New System.IO.StreamWriter(NYOOOM)
            objWriter.Write(_CookieString)
        End Using
        Console.WriteLine("Session Generated Successfully")
    End Sub

    Friend Function NyooomsExist(ByRef UserName As String) As Boolean
        Dim NYOOOM As String = Application.StartupPath & "\foo\" & UserName & ".nyooom"
        If System.IO.File.Exists(NYOOOM) Then

            Console.WriteLine("Session Corrupted")
            MessageBox.Show("Your session has closed unexpectedly. Cympathy's got this, hold on!", "Cympathy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Function

    ''' <summary>
    ''' Log UserID out if proven to be corrupted
    ''' </summary>
    ''' <param name="UserID"></param>
    ''' <remarks></remarks>
    Friend Sub LogMeOut(ByRef UserID As String)
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)

            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Dim transaction As MySqlTransaction = Connection.BeginTransaction
            Try
                Using Command As New MySqlCommand
                    With Command
                        .Connection = Connection
                        .CommandType = CommandType.StoredProcedure
                        .Transaction = transaction
                        .CommandText = "SetUserOnline"
                        With .Parameters
                            .AddWithValue("UserID", UserID)
                            .AddWithValue("UserState", False)
                        End With
                        .ExecuteNonQuery()
                        transaction.Commit()
                    End With
                End Using

            Catch xxx As Exception
                transaction.Rollback()
                WeLearnMessageDisplay.Display(WeLearnExceptions.Simple, Me, xxx)
            End Try
        End Using
    End Sub


End Class
