﻿Public Class frmReportHub

    Private Sub btnScheduleReports_Click(sender As Object, e As EventArgs) Handles btnScheduleReports.Click
        Using hub As New frmScheduleReporter
            hub.ShowDialog(Me)
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnQuizReports.Click
        Using hub As New frmClassroomGradeReporter
            hub.ShowDialog(Me)
        End Using
    End Sub

    Private Sub btnClassStanding_Click(sender As Object, e As EventArgs) Handles btnClassStanding.Click
        Using hub As New frmClassStandingReporter
            hub.ShowDialog(Me)
        End Using
    End Sub
End Class