''' <summary>
''' Exam Viewing, Marking and Pregrading happen here
''' </summary>
''' <remarks></remarks>
Public Class frmExamsViewer

    Private _exam As New c_Exam
    Private _PreGrade As New c_PreGrade
    Private UserID As String
    Private ClassroomID As String
    Private _Marked As UInt16 = 0
    Private Marker As New ContextQuestMarker
    Private _Checked As UInt16 = 0
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
        Using Hub As New frmExamsHub(_SharedClassroom)
            If Hub.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me._exam = Hub.GetExam
                Dim Security As New frmQuestSecurity(Me._exam)
                IsChecked(Me._exam.QuestionnaireID)
                If Security.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If Me._Checked = 0 Then

                        Dim viewer As New frmQuestionnaireViewer(Me._exam)
                        If viewer.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                            Me._PreGrade = viewer.GetPregrade
                        End If

                        Dim grader As New frmGradesExamPreCreator(Me._exam.QuestionnaireID, _SharedUserID, Me._PreGrade, _SharedClassroom.ClassroomId)
                        grader.ShowDialog()
                        ''''
                        Marker.MarkThis(SharedMod2.Marker.Exam, _SharedUserID, Me._exam.QuestionnaireID)

                    Else
                        MessageBox.Show("Exam Has Been Taken Already", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else

                    MessageBox.Show("Exam Authentication Failed", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If

        End Using
    End Sub

    Private Sub IsChecked(ByRef ExamID As String)
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
                    .CommandText = "CheckThisExam"
                    With .Parameters
                        .AddWithValue("UserID", _SharedUserID)
                        .AddWithValue("ExamID", ExamID)
                    End With
                    Me._Checked = .ExecuteScalar()
                End With
            End Using
        End Using
        Console.WriteLine(_Checked)
    End Sub

End Class