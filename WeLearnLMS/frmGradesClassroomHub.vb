Public Class frmGradesClassroomHub

    Private Sub btnCreateGrades_Click(sender As Object, e As EventArgs) Handles btnCreateGrades.Click
        Dim creator As New frmGradesClassroomCreator()
        creator.ShowDialog()
    End Sub

    Private Sub frmGradesClassroomHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class