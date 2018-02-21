Public Class frmClassroomGradeReporter

    Private _Table As New DataTable
    Private _Maker As IMakeHTML = New ImpMakeHTMLClassroomGrades
    Private _HTMLString As String
    Private _FormattedTable As New DataTable

    Private Sub frmQuizGradesCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub FillMyDatatable()
        Dim Computer As New frmGradesClassroomViewer
        With Computer
            .GetAllClassroomGrades(_SharedClassroom.ClassroomId)
            Me._Table = .GetMyTable
        End With
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            FillMyDatatable()
            With Me._Table
                .Columns("user_id").ColumnName = "UserID"
                .Columns("user_name").ColumnName = "UserName"
                .Columns("class_name").ColumnName = "ClassName"
                .Columns("class_grade").ColumnName = "Grade"
            End With

            With Me._FormattedTable.Columns
                .Add("UserID")
                .Add("UserName")
                .Add("ClassName")
                .Add("Grade")
            End With

            BackgroundWorker1.ReportProgress(90)

            For Each row As DataRow In Me._Table.Rows
                Dim NewRow As String() = New String() {row("UserID"), row("UserName"), row("ClassName"), row("Grade")}
                _FormattedTable.Rows.Add(NewRow)
            Next

            Me._HTMLString = Me._Maker.MakeHTML(Me._FormattedTable)
            BackgroundWorker1.ReportProgress(100)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        backgroundProgress.Value = e.ProgressPercentage
    End Sub


    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.Cursor = Cursors.Default
        Me.WebBrowser1.DocumentText = Me._HTMLString
        If e.Error IsNot Nothing Then
            WeLearnMessageDisplay.Display(WeLearnExceptions.Simple, Me, e.Error)
            SaveToolStripMenuItem.Enabled = False
        Else
            SaveToolStripMenuItem.Enabled = True
        End If

    End Sub
End Class