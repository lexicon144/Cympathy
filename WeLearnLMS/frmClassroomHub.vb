Public Class frmClassroomHub
    Private _AdvancedCredentials As New c_AdvancedCredentials
    Private _Classroom As New c_Classroom
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub REView()
        With Me
            txtClassDescription.Text = _Classroom.ClassroomDesc
            txtClassId.Text = _Classroom.ClassroomId
            txtClassName.Text = _Classroom.ClassroomName
            txtClassType.Text = _Classroom.ClassType
        End With
    End Sub

#Region "Loader"
    Private Sub frmClassroomHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NewClassroomDialog As New frmClassroomDialog(TryCast(_AdvancedCredentials, c_MainCredentials))

        If NewClassroomDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me._Classroom = NewClassroomDialog.GetClassroom

            REView()
        End If
    End Sub

    Private Sub btnOpenQuestionnaire_Click(sender As Object, e As EventArgs) Handles btnOpenQuestionnaire.Click
        Dim ViewQuizes As New frmQuizHub(_Classroom.ClassroomId)
        ViewQuizes.ShowDialog()
    End Sub

    Private Sub btnViewArticles_Click(sender As Object, e As EventArgs) Handles btnViewArticles.Click
        Dim ViewArticles As New frmArticleHub(_Classroom.ClassroomId)
        ViewArticles.ShowDialog()
    End Sub

    Private Sub btnViewMaterials_Click(sender As Object, e As EventArgs) Handles btnViewMaterials.Click
        Dim ViewMaterials As New frmStudyMaterialsHub(_Classroom.ClassroomId)
        ViewMaterials.ShowDialog()
    End Sub
#End Region

#Region "Creator"
    Private Sub btnCreateQuestionnaire_Click(sender As Object, e As EventArgs)
        Dim QuizCreator As New frmQuizCreator
        QuizCreator.ShowDialog()
    End Sub

    Private Sub btnCreateExam_Click(sender As Object, e As EventArgs)
        Dim CreateExam As New frmExamsCreator()
        CreateExam.ShowDialog()
    End Sub

    Private Sub btnCreateMaterials_Click(sender As Object, e As EventArgs)
        Dim CreateMaterial As New frmStudyMaterialsCreator()
        CreateMaterial.ShowDialog()

    End Sub

    Private Sub btnCreateArticles_Click(sender As Object, e As EventArgs)
        Dim CreateArticle As New frmArticleCreator()
        CreateArticle.ShowDialog()
    End Sub
#End Region

#Region "Linker"
    Private Sub btnLinkStudentToClassroom_Click(sender As Object, e As EventArgs) Handles btnLinkStudentToClassroom.Click
        Dim StudentLinker As New frmClassroomLinker(Me._Classroom)
        StudentLinker.ShowDialog()
    End Sub

    Private Sub btnLinkArticleHere_Click(sender As Object, e As EventArgs) Handles btnLinkArticleHere.Click

        Dim ArticleLinker As New frmArticleLinker(Me._Classroom)
        ArticleLinker.ShowDialog()
    End Sub

    Private Sub btnLinkMaterialHere_Click(sender As Object, e As EventArgs) Handles btnLinkMaterialHere.Click
        Dim MaterialLinker As New frmStudyMaterialsLinker(Me._Classroom)
        MaterialLinker.ShowDialog()
    End Sub

    Private Sub btnLinkQuizHere_Click(sender As Object, e As EventArgs) Handles btnLinkQuizHere.Click
        Dim QuizLinker As New frmQuizLinker(Me._Classroom)
        QuizLinker.ShowDialog()
    End Sub

    Private Sub btnLinkExamHere_Click(sender As Object, e As EventArgs) Handles btnLinkExamHere.Click
        Dim ExamLinker As New frmExamsLinker(Me._Classroom)
        ExamLinker.ShowDialog()
    End Sub

    Private Sub btnViewLessonlist_Click(sender As Object, e As EventArgs) Handles btnViewLessonlist.Click
        Dim ViewLessonList As New frmLessonListHub()
        ViewLessonList.ShowDialog()
    End Sub

    Private Sub btnViewExams_Click(sender As Object, e As EventArgs) Handles btnViewExams.Click
        Dim ViewExams As New frmExamsHub()
        ViewExams.ShowDialog()
    End Sub
#End Region
End Class