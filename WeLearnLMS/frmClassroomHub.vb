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

        frmScheduleClassroomLifeSpanControl.Show(Me)
        frmAttendanceControl.Show(Me)
        FrmUAC.DisableAllMe(_SharedAdvancedCredentials.MyUserType, mainpanel)
        _SharedClassroom.ClassroomId = Me._Classroom.ClassroomId

    End Sub

    Private Sub btnOpenQuestionnaire_Click(sender As Object, e As EventArgs) Handles btnOpenQuestionnaire.Click
        Using ViewQuizes As New frmQuizHub(_Classroom.ClassroomId)
            ViewQuizes.ShowDialog()
        End Using
    End Sub

    Private Sub btnViewArticles_Click(sender As Object, e As EventArgs) Handles btnViewArticles.Click
        Using ViewArticles As New frmArticleHub(_Classroom.ClassroomId)
            ViewArticles.ShowDialog()
        End Using
    End Sub

    Private Sub btnViewMaterials_Click(sender As Object, e As EventArgs) Handles btnViewMaterials.Click
        Using ViewMaterials As New frmStudyMaterialsHub(_Classroom.ClassroomId)
            ViewMaterials.ShowDialog()
        End Using
    End Sub
#End Region

#Region "Linker"
    Private Sub btnLinkStudentToClassroom_Click(sender As Object, e As EventArgs) Handles btnLinkStudentToClassroom.Click
        Using StudentLinker As New frmClassroomLinker(Me._Classroom)
            StudentLinker.ShowDialog()
        End Using
    End Sub

    Private Sub btnLinkArticleHere_Click(sender As Object, e As EventArgs) Handles btnLinkArticleHere.Click

        Using ArticleLinker As New frmArticleLinker(Me._Classroom)
            ArticleLinker.ShowDialog()
        End Using
    End Sub

    Private Sub btnLinkMaterialHere_Click(sender As Object, e As EventArgs) Handles btnLinkMaterialHere.Click
        Using MaterialLinker As New frmStudyMaterialsLinker(Me._Classroom)
            MaterialLinker.ShowDialog()
        End Using
    End Sub

    Private Sub btnLinkQuizHere_Click(sender As Object, e As EventArgs) Handles btnLinkQuizHere.Click
        Using QuizLinker As New frmQuizLinker(Me._Classroom)
            QuizLinker.ShowDialog()
        End Using
    End Sub

    Private Sub btnLinkExamHere_Click(sender As Object, e As EventArgs) Handles btnLinkExamHere.Click
        Using ExamLinker As New frmExamsLinker(Me._Classroom)
            ExamLinker.ShowDialog()
        End Using
    End Sub

    Private Sub btnViewLessonlist_Click(sender As Object, e As EventArgs) Handles btnViewLessonlist.Click
        Using ViewLessonList As New frmLessonListHub()
            ViewLessonList.ShowDialog()
        End Using
    End Sub

    Private Sub btnViewExams_Click(sender As Object, e As EventArgs) Handles btnViewExams.Click
        Using ViewExams As New frmExamsViewer()
            ViewExams.ShowDialog()
        End Using
    End Sub
#End Region

    Private Sub frmViewGrades_Click(sender As Object, e As EventArgs) Handles frmViewGrades.Click
        Using previewer As New frmGradesQuizComputer()
            With previewer
                .ShowDialog()
            End With
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnViewExamGrades.Click
        Using previewer As New frmGradeExamComputer()
            With previewer
                .ShowDialog()
            End With
        End Using
    End Sub

    Private Sub btnLinkUserHere_Click(sender As Object, e As EventArgs) Handles btnLinkUserHere.Click
        Using linker As New frmClassroomLinker(_SharedClassroom)
            linker.ShowDialog()
        End Using
    End Sub

    Private Sub btnViewClassGrades_Click(sender As Object, e As EventArgs) Handles btnViewClassGrades.Click
        Using viewer As New frmGradesClassroomViewer
            viewer.ShowDialog()
        End Using
    End Sub

    Private Sub ChangeColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub SchedulesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchedulesToolStripMenuItem.Click
        Using scheduleviewer As New frmScheduleViewer(Me._Classroom.ClassroomId)
            scheduleviewer.ShowDialog()
        End Using
    End Sub

    Private Sub ClassStandingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassStandingToolStripMenuItem.Click
        Using standing As New frmClassStanding()
            standing.ShowDialog()
        End Using
    End Sub

End Class