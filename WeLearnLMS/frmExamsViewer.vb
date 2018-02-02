''' <summary>
''' Exam Viewing, Marking and Pregrading happen here
''' </summary>
''' <remarks></remarks>
Public Class frmExamsViewer

    Private _exam As New c_Exam
    Private _PreGrade As New c_PreGrade
    Private UserID As String
    Private ClassroomID As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public Sub New(ByRef ThisExam As c_Exam)
        InitializeComponent()
        Me._exam = ThisExam
    End Sub

    Private Sub frmExamViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Security As New frmQuestSecurity()
        If Security.DialogResult = Windows.Forms.DialogResult.OK Then
            If Not Security.PassState Then
                Me.Close()
            End If

            MarkExam()

            Dim viewer As New frmQuestionnaireViewer(Me._exam)
            If viewer.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me._PreGrade = viewer.GetPregrade
            End If

            Dim grader As New frmGradesExamPreCreator(Me._exam.QuestionnaireID, Me.UserID, Me._PreGrade)
            grader.ShowDialog()
            grader.Procure()
        End If
    End Sub

    ''' <summary>
    ''' Mark Exam
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MarkExam()
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
                                .AddWithValue("UserID", UserID)
                                .AddWithValue("ExamID", Me._exam.QuestionnaireID)
                            End With
                            .ExecuteNonQuery()
                            MarkingTransaction.Commit()
                            MessageBox.Show("This Exam has been marked", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End With
                    End Using
                Catch XXX As MySqlException
                    MarkingTransaction.Rollback()
                    MessageBox.Show("This Exam cannot be marked", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

End Class