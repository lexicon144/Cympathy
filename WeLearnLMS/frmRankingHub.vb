Public Class frmRankingHub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmRankingHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVote_Click(sender As Object, e As EventArgs) Handles btnVote.Click
        Dim voter As New frmRankingCreator(_SharedMainCredentials)
        voter.ShowDialog()
    End Sub
End Class