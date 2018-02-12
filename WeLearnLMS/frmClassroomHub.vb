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
            txtClassType.Text = [Enum].GetName(GetType(eClassType), _Classroom.ClassType)
            _SharedClassroom.ClassroomId = _Classroom.ClassroomId
        End With
    End Sub


#Region "Loader"
    Private Sub frmClassroomHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NewClassroomDialog As New frmClassroomDialog()
        If NewClassroomDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me._Classroom = NewClassroomDialog.GetClassroom
            REView()
        End If

        FrmUAC.DisableAllMe(_SharedAdvancedCredentials.MyUserType, mainpanel)
        _SharedClassroom.ClassroomId = Me._Classroom.ClassroomId
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
        Dim ViewExams As New frmExamsViewer()
        ViewExams.ShowDialog()
    End Sub
#End Region

    Private Sub frmViewGrades_Click(sender As Object, e As EventArgs) Handles frmViewGrades.Click
        Dim previewer As New frmGradesQuizComputer()
        With previewer
            .ShowDialog()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnViewExamGrades.Click
        Dim previewer As New frmGradeExamComputer()
        With previewer
            .ShowDialog()
        End With
    End Sub

    Private Sub btnClassStanding_Click(sender As Object, e As EventArgs) Handles btnClassStanding.Click
        Dim standing As New frmClassStanding()
        standing.ShowDialog()
    End Sub

    Private Sub btnLinkUserHere_Click(sender As Object, e As EventArgs) Handles btnLinkUserHere.Click
        Dim linker As New frmClassroomLinker(_SharedClassroom)
        linker.ShowDialog()
    End Sub

    Private Sub btnViewClassGrades_Click(sender As Object, e As EventArgs) Handles btnViewClassGrades.Click
        Dim viewer As New frmGradesClassroomViewer
        viewer.ShowDialog()
    End Sub

    Private Sub ChangeColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub ScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScheduleToolStripMenuItem.Click
        Dim scheduleviewer As New frmScheduleViewer(Me._Classroom.ClassroomId)
        scheduleviewer.ShowDialog()
    End Sub

End Class