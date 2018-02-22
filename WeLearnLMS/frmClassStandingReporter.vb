Public Class frmClassStandingReporter

    Private _Table As New DataTable
    Private _FormattedTable As New DataTable
    Private _Maker As IMakeHTML = New ImpMakeHTMLClassStanding
    Private _HTMLString As String = ""

    Private Sub frmClassStandingReporter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub FillMyDatatable()
        Using hub As New frmClassStanding
            With hub
                .GrabAllChildren(_SharedClassroom.ClassroomId)
                Me._Table = hub.GetMyTable
            End With
        End Using
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            FillMyDatatable()
            BackgroundWorker1.ReportProgress(60)
            With Me._Table
                .Columns("user_id").ColumnName = "ID"
                .Columns("user_name").ColumnName = "UserName"
                .Columns("user_fname").ColumnName = "FName"
                .Columns("user_mi").ColumnName = "MI"
                .Columns("user_lname").ColumnName = "SName"
            End With
            With Me._FormattedTable.Columns
                .Add("ID")
                .Add("UserName")
                .Add("FullName")
            End With
            For Each row As DataRow In Me._Table.Rows
                Dim NewRow As String() = New String() {row("ID"), row("UserName"), String.Format("{0} {1} {2}", row("FName"), row("MI"), row("SName"))}
                _FormattedTable.Rows.Add(NewRow)
            Next
            _HTMLString = _Maker.MakeHTML(Me._FormattedTable)
            BackgroundWorker1.ReportProgress(100)
        Catch ex As Exception
            Throw ex
            BackgroundWorker1.CancelAsync()
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        If e.Error IsNot Nothing Then
            WeLearnMessageDisplay.Display(WeLearnExceptions.Simple, Me, e.Error)
            SaveToolStripMenuItem.Enabled = False
        Else
            SaveToolStripMenuItem.Enabled = True
        End If

        Me.Cursor = Cursors.Default
        Me.WebBrowser1.DocumentText = _HTMLString


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
End Class