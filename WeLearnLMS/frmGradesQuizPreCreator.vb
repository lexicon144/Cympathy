Public Class frmGradesQuizPreCreator

    Private _MainCredentials As New c_MainCredentials

    Private _QuizID, _UserID, _QuizName As String

    Private _PreGrade As New c_PreGrade

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef QuizID As String, ByRef UserID As String, ByRef PreGrade As c_PreGrade)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With Me
            ._QuizID = QuizID
            ._UserID = UserID
            ._PreGrade = PreGrade

        End With
    End Sub

    Public Sub New(ByRef QuizID As String, ByRef QuizName As String, ByRef UserID As String, ByRef PreGrade As c_PreGrade)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With Me
            ._QuizID = QuizID
            ._UserID = UserID
            ._PreGrade = PreGrade
            ._QuizName = QuizName
        End With
    End Sub

    Private Sub frmGradesPre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Procure()
    End Sub

    Private Sub RefreshText()
        With Me
            .txtGradeFullScore.Text = ._PreGrade.ReturnFullScore
            .txtGradeNumber.Text = ._PreGrade.ReturnFullAverage
            .txtQuizID.Text = ._QuizID
            .txtQuizName.Text = ._QuizName
        End With
    End Sub

    Private Sub Procure()
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
                            .CommandText = "InsertGradesPreQuiz"
                            Dim ViewString As String
                            ViewString = "UID: " & _UserID & " QuizID : " & _QuizID & " Grade : " & Me._PreGrade.ReturnFullScore & " HITS : " & _PreGrade.Hits & "QUESTIONS : " & _PreGrade.TotalQuestions
                            Console.WriteLine(ViewString)
                            With .Parameters
                                .AddWithValue("@UserID", Me._UserID)
                                .AddWithValue("@QuizID", Me._QuizID)
                                .AddWithValue("@QuizGrade", Me._PreGrade.ReturnFullScore)
                                .AddWithValue("@Hits", Me._PreGrade.Hits)
                                .AddWithValue("@Questions", Me._PreGrade.TotalQuestions)

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
                        .Text = "An error occurred when committing your Progress: " & XXX.Message
                    End With
                End Try
            End Using
        End Using
    End Sub

End Class