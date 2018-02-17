Public Class frmScheduleReportCreator
    Private _Table As New DataTable
    Private _FormattedTable As New DataTable
    Private _Maker As IMakeHTML = New ImpMakeHTMLString
    Private _HTMLString As String

    Private Sub frmScheduleReportCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub FillMyDatatable()
        Using ScheduleHub As New frmScheduleViewer
            With ScheduleHub
                .LoadSchedules(_SharedClassroom.ClassroomId)
                Me._Table = .MyDatatable
            End With
        End Using
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        BackgroundWorker1.ReportProgress(10)
        FillMyDatatable()
        BackgroundWorker1.ReportProgress(60)
        With Me._Table
            .Columns("class_name").ColumnName = "Class Name"
            .Columns("class_description").ColumnName = "Desc"
            .Columns("classType").ColumnName = "Type"
            .Columns("day_number").ColumnName = "DAY"
            .Columns("hour_start").ColumnName = "START"
            .Columns("hour_end").ColumnName = "END"
        End With
        With Me._FormattedTable.Columns
            .Add("ID")
            .Add("Class Name")
            .Add("Desc")
            .Add("Type")
            .Add("DAY")
            .Add("SPAN")
        End With
        BackgroundWorker1.ReportProgress(90)
        For Each row As DataRow In Me._Table.Rows
            Dim NewRow As String() = New String() {row("id"), row("Class Name"), row("Desc"), [Enum].GetName(GetType(eClassType), row("Type")), [Enum].GetName(GetType(DayOfWeek), row("DAY")), row("START") & " -> " & row("END")}
            _FormattedTable.Rows.Add(NewRow)
        Next
        Me._HTMLString = Me._Maker.MakeHTML(Me._FormattedTable)
        BackgroundWorker1.ReportProgress(100)
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Me.backgroundProgress.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.WebBrowser1.DocumentText = Me._HTMLString
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using Saver As New SaveFileDialog
            With Saver
                .Filter = "HTLM File|*.HTML"
                .Title = "Save the HTML Report"
                If .ShowDialog() = DialogResult.OK Then
                    System.IO.File.WriteAllText(.FileName, Me._HTMLString)
                End If
            End With
        End Using
    End Sub
End Class