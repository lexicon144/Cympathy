Public Class frmScheduleReport
    Private _Table As New DataTable
    Private Sub frmScheduleReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub backgroundReportLoader_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles backgroundReportLoader.DoWork
        Using Connection As New MySqlConnection()
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Using Command As New MySqlCommand
                With Command

                End With
                Using Adapter As New MySqlDataAdapter

                    Using Sauce As New DataSet

                    End Using
                End Using
            End Using
        End Using
    End Sub


End Class
