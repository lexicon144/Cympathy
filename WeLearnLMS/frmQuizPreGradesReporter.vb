Public Class frmQuizPreGradesReporter
    Private _Table As New DataTable

    Private _Maker As IMakeHTML = New ImpMakeHTMLPreGradeReport
    Private _HTMLString As String
    Private _ClassID As String
    Private _UserID As String
    Private Sub frmQuizPreGradesReporter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub SetMyData()
        Using ClassroomHub As New frmClassroomDialog
            With ClassroomHub
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then Me._ClassID = .GetClassroom.ClassroomId
            End With
        End Using

        If Me._ClassID = "" Then Exit Sub
        Using UserViewer As New frmUsersViewer
            With UserViewer
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then Me._UserID = .GetSmallCredentials.UserID
            End With
        End Using

        Using ScheduleHub As New frmGradesQuizComputer
            With ScheduleHub
                Me._Table = .GetAnsweredQuizes(Me._UserID, Me._ClassID)
            End With
        End Using
    End Sub


    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            SetMyData()

            BackgroundWorker1.ReportProgress(90)

            Me._HTMLString = Me._Maker.MakeHTML(Me._Table)
            BackgroundWorker1.ReportProgress(100)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Using Saver As New SaveFileDialog
            With Saver
                .FileName = "CYMPATHY_REPORTS_" & POSIXEpoch.DateTimeToEpoch(DateTime.Now).ToString & ".HTML"
                .Filter = "HTLM File|*.HTML"
                .Title = "Save the HTML Report"
                If .ShowDialog() = DialogResult.OK Then
                    System.IO.File.WriteAllText(.FileName, Me._HTMLString)
                End If
            End With
        End Using
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ToolStripProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Error IsNot Nothing Then
            WeLearnMessageDisplay.Display(WeLearnExceptions.Simple, Me, e.Error)
            SaveToolStripMenuItem.Enabled = False
        Else
            SaveToolStripMenuItem.Enabled = True
        End If

        Me.WebBrowser1.DocumentText = Me._HTMLString
        Me.Cursor = Cursors.Default
    End Sub
End Class