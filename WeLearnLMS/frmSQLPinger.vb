Imports System.Text

Public Class frmSQLPinger
    Private Safe As Boolean
    Private builder As New StringBuilder
    Friend ReadOnly Property Safety As Boolean
        Get
            Return Safe
        End Get
    End Property

    Private ConState As ConnectionState

    Friend ReadOnly Property Safeness As ConnectionState
        Get
            Return ConState
        End Get
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmSQLPinger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub nl()
        rtb.AppendText(vbNewLine)
    End Sub

    Private Sub rtb_TextChanged(sender As Object, e As EventArgs) Handles rtb.Click
        Timer1.Stop()
    End Sub

    Private Sub frmSQLPinger_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub rtb_TextChanged_1(sender As Object, e As EventArgs) Handles rtb.TextChanged

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            BackgroundWorker1.ReportProgress(10)
            Using ConnectionObject As New MySqlConnection
                With ConnectionObject

                    BackgroundWorker1.ReportProgress(50)
                    .ConnectionString = _SharedConnString.ConnString

                    With builder

                        .AppendLine("New Mysql Connection ")
                        .AppendLine("This Connection ")
                        .AppendLine(ConnectionObject.GetHashCode)
                        .AppendLine()
                        .AppendLine("State: ")
                        .AppendLine(ConnectionObject.State.ToString)
                        .AppendLine()

                    End With

                    builder.AppendLine("Trying to Open the connection...")
                    If .State = ConnectionState.Closed Then
                        .Open()
                        Safe = True
                    End If
                    builder.AppendLine("Connection was openned!!")
                    Safe = True
                    BackgroundWorker1.ReportProgress(90)
                End With
            End Using
        Catch XXX As Exception
            Safe = False
            With builder
                .AppendLine("An Error happened! ")
                .AppendLine()
                .AppendLine(XXX.Message)
                .AppendLine()
                .AppendLine(XXX.Source)
                .AppendLine()
                .AppendLine(XXX.StackTrace)
                .AppendLine()
                .AppendLine("Please Contact Your System Admin for details and help on this occurance")
            End With
        Finally

            BackgroundWorker1.ReportProgress(100)
        End Try
        Me.Timer1.Start()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        rtb.Text = builder.ToString
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ToolStripProgressBar1.Value = e.ProgressPercentage
    End Sub

End Class