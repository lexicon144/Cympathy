Public Class frmReportHub

    Private Sub btnScheduleReports_Click(sender As Object, e As EventArgs) Handles btnScheduleReports.Click
        Using Hub As New frmScheduleReportCreator
            Hub.ShowDialog()
        End Using
    End Sub
End Class