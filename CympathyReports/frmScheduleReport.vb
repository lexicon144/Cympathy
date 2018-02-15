Imports Microsoft.Reporting.WinForms

Public Class frmScheduleReport

    Private Sub frmScheduleReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub backgroundReportLoader_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles backgroundReportLoader.DoWork
        Using Connection As New MySqlConnection()
            With Connection

                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Using Command As New MySqlCommand

                Using Adapter As New MySqlDataAdapter

                    Using Sauce As New DataSet

                        With Me.ReportViewer1
                            .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                            .LocalReport.ReportPath = System.Environment.CurrentDirectory & "\r_ScheduleReport.rdlc"
                            .LocalReport.DataSources.Clear()
                            .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Sauce.Tables(0)))
                            .DocumentMapCollapsed = True
                        End With
                    End Using
                End Using
            End Using
        End Using
    End Sub
End Class
