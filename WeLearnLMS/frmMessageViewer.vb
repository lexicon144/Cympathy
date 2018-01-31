Public Class frmMessageViewer
    Private _Feedback As New c_Message

    Public Sub New(ByRef Feedback As c_Message)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With Me
            ._Feedback = Feedback
        End With
    End Sub

    Private Sub frmFeedbackViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cFeedbackParser()

    End Sub

    Private Sub cFeedbackParser()
        With Me

            txtMessage.Text = ._Feedback.Payload
            txtReceiverID.Text = ._Feedback.ReceiverID
            txtReceiverNAME.Text = ._Feedback.ReceiverName
            txtSenderID.Text = ._Feedback.SenderID
            txtSenderNAME.Text = ._Feedback.SenderName
            txtTimeDate.Text = ._Feedback.TimeStamp

        End With
    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        DirectCast(sender, Label).Text = "(You)"
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        DirectCast(sender, Label).Text = "Sender ID"
    End Sub
End Class