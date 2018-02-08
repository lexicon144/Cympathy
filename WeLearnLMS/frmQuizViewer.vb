Public Class frmQuizViewer

    Private _Quiz As New c_Quiz
    Private _Pregrade As New c_PreGrade
    Private _UserID As String

    ''' <summary>
    '''  Null constructor
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    ''' <summary>
    ''' Constructor for making QuizRelated
    ''' </summary>
    ''' <param name="ThisQuiz"></param>
    ''' <remarks></remarks>
    Public Sub New(ByRef ThisQuiz As c_Quiz)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._Quiz = ThisQuiz
    End Sub

    Private Sub frmQuizViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim viewer As New frmQuestionnaireViewer(_Quiz)
        
        If viewer.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Me._Pregrade = viewer.GetPregrade
        End If

        MarkQuiz()

        Dim procure As New frmGradesQuizPreCreator(Me._Quiz.QuestionnaireID, _SharedUserID, Me._Pregrade)
        procure.ShowDialog()
    End Sub

    ''' <summary>
    ''' Mark Quiz
    ''' only mark the quiz, not grade it
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MarkQuiz()
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
                                .AddWithValue("UserID", _SharedUserID)
                                .AddWithValue("QuizID", Me._Quiz.QuestionnaireID)
                            End With
                            .ExecuteNonQuery()
                            MarkingTransaction.Commit()
                            MessageBox.Show("This Quiz has been marked", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End With
                    End Using
                Catch XXX As MySqlException
                    MarkingTransaction.Rollback()
                    DisplayLinkingTransactionFailed(XXX)
                End Try
            End Using
        End Using
    End Sub

End Class