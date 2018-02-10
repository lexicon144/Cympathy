Public Class frmScheduleCreator
    
    Private _Schedule As New c_Schedule
    Private _VanillaSchedule As New c_VanillaSchedule

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmScheduleCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub PerformLink()
        Using Connection As New MySqlConnection
            With Connection
                .ConnectionString = _SharedConnString.ConnString
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Dim LinkingTransaction As MySqlTransaction = Connection.BeginTransaction
            Try
                Using Command As New MySqlCommand
                    With Command
                        .Connection = Connection
                        .CommandType = CommandType.StoredProcedure
                        .Transaction = LinkingTransaction
                        .CommandText = "InsertSchedule"

                        With .Parameters
                            .AddWithValue("DayNumber", Me._VanillaSchedule.Day)
                            .AddWithValue("HourStart", Me._VanillaSchedule.Hour)
                            .AddWithValue("HourEnd", Me._VanillaSchedule.HourEnd)
                            .AddWithValue("ClassID", Me._VanillaSchedule.ClassroomID)
                        End With

                        .ExecuteNonQuery()

                        LinkingTransaction.Commit()
                        MessageBox.Show("Linking Transaction Succeeded!", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End With
                End Using
            Catch Ex As Exception
                LinkingTransaction.Rollback()
                DisplayLinkingTransactionFailed(Ex)
            End Try
        End Using
    End Sub

    Private Sub btnBrowseClassroom_Click(sender As Object, e As EventArgs) Handles btnBrowseClassroom.Click
        Dim browse As New frmClassroomDialog()
        If browse.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me._VanillaSchedule.ClassroomID = browse.GetClassroom.ClassroomId
            txtClassroom.Text = browse.GetClassroom.ClassroomName
        End If
    End Sub

    Private Sub btnBrowseTime_Click(sender As Object, e As EventArgs) Handles btnBrowseTime.Click
        Dim browse As New frmTimeDialog()
        With browse
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Me._VanillaSchedule.Hour = .GetTime
                Me._VanillaSchedule.HourEnd = .GetTimeEnd
                Me.txtTime.Text = _VanillaSchedule.Hour.ToString & " -> " & _VanillaSchedule.HourEnd.ToString
            End If
        End With
    End Sub

    Private Sub btnBrowseDays_Click(sender As Object, e As EventArgs) Handles btnBrowseDays.Click
        Dim browse As New frmDayDialog()
        With browse
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Me._VanillaSchedule.Day = .GetDay
                Me.txtDay.Text = [Enum].GetName(GetType(DayOfWeek), .GetDay)
            End If
        End With
    End Sub

    Private Function Evaluated()
        Return (txtClassroom.Text IsNot "") AndAlso (txtDay.Text IsNot "") AndAlso (txtTime.Text IsNot "")
    End Function

    Private Sub btnCreateSchedule_Click(sender As Object, e As EventArgs) Handles btnCreateSchedule.Click
        If Evaluated() Then PerformLink()
    End Sub
End Class