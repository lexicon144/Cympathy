Public Class frmClassStanding

    Private _StandingDatatable As New DataTable
    Private _HTMLString As String

    Friend ReadOnly Property GetMyTable As DataTable
        Get
            Return Me._StandingDatatable
        End Get
    End Property

    Private Sub frmClassStanding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub FormatGrid()
        If Not DataGridView1.Rows.Count > 0 Then Exit Sub
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("isOnline").Value Then row.DefaultCellStyle.BackColor = Color.LightGreen Else row.DefaultCellStyle.BackColor = Color.LightGray
        Next
    End Sub

    Private Sub ShowAll()

        With Me.DataGridView1
            .DataSource = _StandingDatatable
            .Columns("user_id").Visible = False
            .Columns("user_fname").Visible = False
            .Columns("user_mi").Visible = False
            .Columns("user_lname").Visible = False
            .Columns("isOnline").Visible = False
            .Columns("id").Visible = False
        End With
    End Sub

    Friend Sub GrabAllChildren(ByRef ClassroomID As String)
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Using Command As New MySqlCommand
                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "DisplayAllStudentsInThisClass"
                    With .Parameters
                        .AddWithValue("ClassroomID", ClassroomID)
                    End With
                End With
                Using Adapter As New MySqlDataAdapter(Command)
                    With Adapter
                        .Fill(Me._StandingDatatable)
                    End With
                End Using
            End Using
        End Using
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            BackgroundWorker1.ReportProgress(90)

            GrabAllChildren(_SharedClassroom.ClassroomId)

            BackgroundWorker1.ReportProgress(100)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ToolStripProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Error IsNot Nothing Then
            WeLearnMessageDisplay.Display(WeLearnExceptions.Simple, Me, e.Error)
            Exit Sub
        End If

        ShowAll()
        FormatGrid()

    End Sub


End Class