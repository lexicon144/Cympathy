Public Class frmMessageCreator
    Private _ConnString As IConStringBuilder = New ImpConStringBuilder

    ''' <summary>
    ''' Constructor for me
    ''' </summary>
    ''' <param name="Sender"></param>
    ''' <remarks></remarks>
    Public Sub New(ByRef Sender As c_MainCredentials)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtSenderID.Text = Sender.UserID
        txtSenderNAME.Text = Sender.UserName

        Dim UserBrowser As New frmUsersViewer
        If UserBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtReceiverID.Text = UserBrowser.GetSmallCredentials.UserID
            txtReceiverNAME.Text = UserBrowser.GetSmallCredentials.UserName
        End If

    End Sub

    Public Sub New(ByRef SenderID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtSenderID.Text = SenderID

        Dim UserBrowser As New frmUsersViewer
        If UserBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtReceiverID.Text = UserBrowser.GetSmallCredentials.UserID
            txtReceiverNAME.Text = UserBrowser.GetSmallCredentials.UserName
        End If

    End Sub

    ''' <summary>
    ''' Inserts Feedback into the database
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveFeedback()
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Dim Transaction As MySqlTransaction = Connection.BeginTransaction
            Try
                Using Command As New MySqlCommand
                    With Command
                        .Transaction = Transaction
                        .CommandType = CommandType.StoredProcedure
                        .Connection = Connection
                        .CommandText = "InsertNewMessage"
                        With .Parameters
                            .AddWithValue("ReceiverID", txtReceiverID.Text)
                            .AddWithValue("SenderID", txtSenderID.Text)
                            .AddWithValue("Payload", txtMessage.Text)
                        End With
                        .ExecuteNonQuery()
                        Transaction.Commit()
                        MessageBox.Show("Successfully sent feedback!!", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End With
                End Using
            Catch xxx As Exception
                Transaction.Rollback()
                MessageBox.Show("Something Wrong Happened - " & xxx.Message, "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveFeedback()
    End Sub

    Private Sub txtTimeStamp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles txtTimeStamp.LinkClicked
        txtTimeStamp.Text = EpochToDateTime(CInt(DirectCast(sender, LinkLabel).Text))
    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        DirectCast(sender, Label).Text = "(You)"
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        DirectCast(sender, Label).Text = "Sender ID"
    End Sub

    Private Sub frmMessageCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Timer1.Enabled = False
        Me.Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.txtTimeStamp.Text = POSIXEpoch.DateTimeToEpoch(DateTime.Now)
    End Sub

    Private Sub txtSenderID_MouseHover(sender As Object, e As EventArgs) Handles txtSenderID.MouseHover
        Label2.Text = "(You)"
    End Sub

    Private Sub txtSenderID_MouseLeave(sender As Object, e As EventArgs) Handles txtSenderID.MouseLeave
        Label2.Text = "Sender ID"
    End Sub
End Class