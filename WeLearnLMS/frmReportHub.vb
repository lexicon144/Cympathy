Public Class frmReportHub

    Private Sub ScheduleReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScheduleReportsToolStripMenuItem.Click
        Using hub As New frmScheduleReporter
            hub.ShowDialog(Me)
        End Using
    End Sub

    Private Sub ClassStandingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassStandingToolStripMenuItem.Click
        Using hub As New frmClassStandingReporter
            hub.ShowDialog(Me)
        End Using
    End Sub

    Private Sub QuizPartialToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuizPartialToolStripMenuItem1.Click
        Using hub As New frmQuizPreGradesReporter
            hub.ShowDialog(Me)
        End Using
    End Sub

    Private Sub ClassroomFullToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassroomFullToolStripMenuItem.Click
        Using hub As New frmClassroomGradeReporter
            hub.ShowDialog(Me)
        End Using
    End Sub
End Class