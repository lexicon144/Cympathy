Public Class ImpMarkQuestionnaireQuiz
    Implements IMarkQuestionnaire

    Public Sub MarkThisQuest(ByRef UserID As String, ByRef QuestID As String) Implements IMarkQuestionnaire.MarkThisQuest
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Using MarkingTransaction As MySqlTransaction = Connection.BeginTransaction

                Try
                    Using Command As New MySqlCommand
                        With Command
                            .Connection = Connection
                            .Transaction = MarkingTransaction
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "MarkThisQuiz"
                            With .Parameters
                                .AddWithValue("UserID", UserID)
                                .AddWithValue("QuizID", QuestID)
                            End With
                            .ExecuteNonQuery()
                            MarkingTransaction.Commit()
                            MessageBox.Show("This Quiz has been marked", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End With
                    End Using
                Catch XXX As MySqlException
                    MarkingTransaction.Rollback()
                    WeLearnMessageDisplay.Display(WeLearnExceptions.Linking, Me, XXX)
                End Try
            End Using
        End Using
    End Sub
End Class
