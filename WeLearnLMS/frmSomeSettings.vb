Public Class frmSomeSettings

    Private Sub btnSetFontSizeSettings_Click(sender As Object, e As EventArgs) Handles btnSetFontSizeSettings.Click
        Try
            If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

                My.Settings("MainFont") = FontDialog1.Font
            End If

        Catch XXX As Exception
            WeLearnMessageDisplay.Display(WeLearnExceptions.General, Me, XXX)
        End Try
    End Sub

    Private Sub btnSetMainColoursSettings_Click(sender As Object, e As EventArgs) Handles btnSetMainColoursSettings.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings("AllMainBackground") = ColorDialog1.Color
        End If
    End Sub

    Private Sub btnSetQuestBackgrounds_Click(sender As Object, e As EventArgs) Handles btnSetQuestBackgrounds.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings("QuestMainBackground") = ColorDialog1.Color
        End If
    End Sub

    Private Sub frmSomeSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class