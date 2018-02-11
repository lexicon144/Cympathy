Public Class frmTimeDialog

    Private _Time As String
    Private _TimeEnd As String

    Friend ReadOnly Property GetTime
        Get
            Return _Time
        End Get
    End Property

    Friend ReadOnly Property GetTimeEnd
        Get
            Return _TimeEnd
        End Get
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub dtpStartTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartTime.ValueChanged
        Me._Time = DirectCast(sender, DateTimePicker).Value.Hour
        btnOK.Enabled = IsEvaluated()
    End Sub

    Private Sub dtpEndTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndTime.ValueChanged
        Me._TimeEnd = DirectCast(sender, DateTimePicker).Value.Hour
        btnOK.Enabled = IsEvaluated()
    End Sub
    Private Function IsEvaluated() As Boolean
        Return (Me.dtpStartTime.Value.Hour < Me.dtpEndTime.Value.Hour)
    End Function

End Class