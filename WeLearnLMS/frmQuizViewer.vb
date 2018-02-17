Public Class frmQuizViewer

    Private _Quiz As New c_Quiz
    Private _Pregrade As New c_PreGrade
    Private _UserID As String
    Private _ClassroomID As String
    Private Marker As New ContextQuestMarker()
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


    ''' <summary>
    ''' Constructor for making QuizRelated
    ''' </summary>
    ''' <param name="ThisQuiz"></param>
    ''' <remarks></remarks>
    Public Sub New(ByRef ThisQuiz As c_Quiz, ByRef ClassroomID As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._Quiz = ThisQuiz
        Me._ClassroomID = ClassroomID
    End Sub

    Private Sub frmQuizViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim viewer As New frmQuestionnaireViewer(_Quiz)

            If viewer.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me._Pregrade = viewer.GetPregrade

                Marker.MarkThis(SharedMod2.Marker.Quiz, _SharedUserID, Me._Quiz.QuestionnaireID)

                Dim procure As New frmGradesQuizPreCreator(Me._Quiz.QuestionnaireID, Me._Quiz.QuestionnaireName, _SharedUserID, Me._Pregrade, _SharedClassroom.ClassroomId)
                procure.ShowDialog()
            End If
        Catch ex As Exception

        End Try

    End Sub


End Class