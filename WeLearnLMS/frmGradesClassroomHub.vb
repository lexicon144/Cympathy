Public Class frmGradesClassroomHub

    Private _MyGrades As New c_Grades

    Private Sub btnCreateGrades_Click(sender As Object, e As EventArgs) Handles btnCreateGrades.Click
        Dim creator As New frmGradesClassroomCreator()
        creator.ShowDialog()
    End Sub

    Private Sub frmGradesClassroomHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FrmUAC.DisableAllMe(_SharedMainCredentials.MyUserType, Me.TableLayoutPanel1)

    End Sub

    Private Sub btnViewGrades_Click(sender As Object, e As EventArgs) Handles btnViewGrades.Click
        Dim viewer As New frmGradesClassroomViewer(_SharedUserID, _SharedClassroom.ClassroomId)
        viewer.ShowDialog()
    End Sub
End Class