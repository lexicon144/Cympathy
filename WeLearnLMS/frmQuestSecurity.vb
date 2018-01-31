Public Class frmQuestSecurity

    Private _CorrectPIN As String
    Private _PassState As Boolean

    Private C_Exam As New c_Exam
    Private C_Quiz As New c_Quiz
    Private _IsExam As Boolean
    Private _UserID As String

    Private _ExamMarked As Boolean = True

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub New(ByRef UserID As String, ByRef Quiz As c_Quiz)
        InitializeComponent()
        Me._IsExam = False
        Me._UserID = UserID
    End Sub

    Public Sub New(ByRef UserID As String, ByRef Exam As c_Exam)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.C_Exam = Exam
        Me._UserID = UserID
        Me._IsExam = True
    End Sub

    Friend ReadOnly Property PassState As Boolean
        Get
            Return _PassState
        End Get
    End Property

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        _PassState = (C_Exam.PIN = TextBox1.Text)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub MarkThis(ByRef ThisExam As c_Exam)
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
                            .CommandText = "MarkThisExam"
                            With .Parameters
                                .AddWithValue("ExamID", ThisExam.QuestionnaireID)
                                .AddWithValue("UserID", _UserID)
                                .AddWithValue("Existence", MySqlDbType.Bit)
                            End With
                            .Parameters("Existence").Direction = ParameterDirection.Output
                            .ExecuteNonQuery()

                            _ExamMarked = .Parameters("Existence").Value
                            If _ExamMarked Then Throw New Exception("Exam already has been marked")

                            MarkingTransaction.Commit()
                            Console.WriteLine("This Exam is now Marked")
                        End With
                    End Using
                Catch XXX As Exception
                    MarkingTransaction.Rollback()
                    Console.WriteLine("This Exam cannot be marked. Reasons: {0} ", XXX.Message)
                End Try
            End Using
        End Using
    End Sub


    Private Sub MarkThis(ByRef ThisExam As c_Quiz)
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
                                .AddWithValue("QuizID", ThisExam.QuestionnaireID)
                                .AddWithValue("UserID", _UserID)
                            End With
                            .ExecuteNonQuery()
                            MarkingTransaction.Commit()
                            Console.WriteLine("This Quiz has been Marked")
                            _PassState = True
                        End With
                    End Using
                Catch XXX As Exception
                    MarkingTransaction.Rollback()
                    Console.WriteLine("This Quiz has NOT been marked")
                    _PassState = False
                End Try
            End Using
        End Using
    End Sub


End Class