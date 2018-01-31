Public Class frmMenu

    Private _AdvancedCredentials As New c_AdvancedCredentials

    Public Sub New(ByRef AdvancedCredentials As c_AdvancedCredentials)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With Me
            ._AdvancedCredentials = AdvancedCredentials
        End With
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClassroomHub_Click(sender As Object, e As EventArgs) Handles btnClassroomHub.Click
        Dim ClassroomHub As New frmClassroomHub
        ClassroomHub.ShowDialog()
    End Sub

    Private Sub btnTimeManagement_Click(sender As Object, e As EventArgs) Handles btnTimeManagement.Click
        Dim TimeManagement As New frmTimeManagementHub(TryCast(_AdvancedCredentials, c_MainCredentials))
        TimeManagement.ShowDialog()
    End Sub

    Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click
        Dim bbbFeedback As New frmMessageHub(TryCast(_AdvancedCredentials, c_MainCredentials))
        bbbFeedback.ShowDialog()
    End Sub

#Region "Creator"
    Private Sub btnCreateQuestionnaire_Click(sender As Object, e As EventArgs) Handles btnCreateQuestionnaire.Click
        Dim QuizCreator As New frmQuizCreator
        QuizCreator.ShowDialog()
    End Sub

    Private Sub btnCreateExam_Click(sender As Object, e As EventArgs) Handles btnCreateExam.Click
        Dim CreateExam As New frmExamsCreator
        CreateExam.ShowDialog()
    End Sub

    Private Sub btnCreateMaterials_Click(sender As Object, e As EventArgs) Handles btnCreateMaterials.Click
        Dim CreateMaterial As New frmStudyMaterialsCreator()
        CreateMaterial.ShowDialog()
    End Sub

    Private Sub btnCreateArticles_Click(sender As Object, e As EventArgs) Handles btnCreateArticles.Click
        Dim CreateArticle As New frmArticleCreator
        CreateArticle.ShowDialog()
    End Sub
#End Region

    Private Sub btnLessonList_Click(sender As Object, e As EventArgs) Handles btnLessonList.Click
        Dim viewer As New frmLessonListHub
        viewer.ShowDialog()
    End Sub

    Private Sub btnRanking_Click(sender As Object, e As EventArgs) Handles btnRanking.Click
        Dim viewer As New frmRankingHub()
        viewer.ShowDialog()
    End SubS

    Private Sub btnGrades_Click(sender As Object, e As EventArgs) Handles btnGrades.Click
        Dim viewer As New frmGradesHub
        viewer.ShowDialog()
    End Sub
End Class