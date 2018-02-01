Public Class frmGradesExamPreCreator

    Private _ExamID As String
    Private _ExamName As String
    Private _UserID As String
    Private _PreGrade As New c_PreGrade

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByRef ExamID As String, ByRef UserID As String, ByRef PreGrade As c_PreGrade)
        InitializeComponent()
        With Me
            ._ExamID = ExamID
            ._UserID = UserID
            ._PreGrade = PreGrade

            .txtExamID.Text = ExamID
            .txtGrade.Text = _PreGrade.ReturnFullScore
        End With
    End Sub

    Friend Sub Procure()
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
                            .CommandText = "InsertGradeExam"
                            With .Parameters
                                .AddWithValue("UserID", Me._UserID)
                                .AddWithValue("ExamID", Me._ExamID)
                                .AddWithValue("ExamGrade", Me._PreGrade.ReturnFullScore)
                                .AddWithValue("ExamHits", Me._PreGrade.Hits)
                                .AddWithValue("ExamQuestions", Me._PreGrade.TotalQuestions)
                            End With
                            .ExecuteNonQuery()
                            MarkingTransaction.Commit()
                            With Label5
                                .ForeColor = Color.Green
                                .Text = "Successfully Committed your Progress"
                            End With
                        End With
                    End Using
                Catch XXX As Exception
                    MarkingTransaction.Rollback()
                    With Label5
                        .ForeColor = Color.Red
                        .Text = "An error occurred when committing your Progress: REason " & XXX.Message
                    End With
                End Try
            End Using
        End Using
    End Sub

    Private Sub frmGradesExamPreCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Procure()
    End Sub
End Class