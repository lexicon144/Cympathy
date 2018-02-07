Public Class frmRankingViewer

    Private _RankingDatatable As New DataTable

    Private Sub frmRankingViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DisplayData()
        With Me.DataGridView1
            .DataSource = Me._RankingDatatable
        End With
    End Sub


    Private Sub FormatChart()
        Chart1.Series.Add("Ranking")

        For Each Row As DataRow In _RankingDatatable.Rows
            Chart1.Series("Ranking").Points.AddXY(Row("candidate_id").ToString, Val(Row("COUNT(*)").ToString))
        Next

        Chart1.Series("Ranking").Color = Color.LimeGreen

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        BackgroundWorker1.ReportProgress(10)
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            BackgroundWorker1.ReportProgress(20)
            With Connection
                If .State = ConnectionState.Open Then .Open()
            End With
            BackgroundWorker1.ReportProgress(50)
            Using Command As New MySqlCommand
                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SelectAllRanks"
                End With
                BackgroundWorker1.ReportProgress(90)
                Using Adapter As New MySqlDataAdapter
                    With Adapter
                        .SelectCommand = Command
                        .Fill(Me._RankingDatatable)
                    End With
                End Using
                BackgroundWorker1.ReportProgress(100)
            End Using
        End Using
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        DisplayData()
        FormatChart()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ToolStripProgressBar1.Value = e.ProgressPercentage
    End Sub
End Class