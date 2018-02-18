Public Class frmReportHub

    Private Sub btnScheduleReports_Click(sender As Object, e As EventArgs) Handles btnScheduleReports.Click
        Using Hub As New frmScheduleReportCreator
            Hub.ShowDialog()
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using hub As New frmQuizGradesReporter
            hub.ShowDialog()
        End Using
    End Sub
End Class