Public Class frmQuizGradesReporter

    Private _Table As New DataTable
    Private _Maker As IMakeHTML = New ImpMakeHTMLQuizGrades
    Private _HTMLString As String

    Private _AllQuizCount As UInt32
    Private _RecordedCount As UInt32
    Private _GradeSummation As Double = 0.0
    Private _FullAverage As Double = 0.0

    Private Sub frmQuizGradesCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub FillMyDatatable()
        Dim Computer As New frmGradesQuizComputer

        With Computer
            Me._Table = .GetMyDatatable()
            .TriggerNecessaryFunctions()
            Me._AllQuizCount = .QuizCount
            Me._RecordedCount = .RecordedCount
            Me._GradeSummation = .GradeSummation
            Me._FullAverage = .FullAverage
        End With
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try

            BackgroundWorker1.ReportProgress(10)
            FillMyDatatable()
            BackgroundWorker1.ReportProgress(50)
            Me._HTMLString = _Maker.MakeHTML(Me._Table)
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