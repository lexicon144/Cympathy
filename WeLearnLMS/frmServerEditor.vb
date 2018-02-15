Public Class frmServerEditor

    Private IPHost As String

    Private Sub ChangeHostName()
        My.Settings("city85") = TextBox1.Text
        MessageBox.Show("Saved", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ChangeHostName()
        Catch XXX As Exception
            WeLearnMessageDisplay.Display(WeLearnExceptions.General, Me, XXX)
        End Try
    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        If Not _SharedValidator.Verify(VMethodology.IPAddress, DirectCast(sender, TextBox).Text) Then
            ErrorProvider1.SetError(DirectCast(sender, TextBox), "Invalid IP / Hostname")
            e.Cancel = True
            btnSave.Enabled = False
            DirectCast(sender, TextBox).SelectAll()
            Exit Sub
        End If
        ErrorProvider1.SetError(DirectCast(sender, TextBox), "")
    End Sub

    Private Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles TextBox1.Validated
        TextBox1.Enabled = True

    End Sub

    Private Sub txtTypeOK_TextChanged(sender As Object, e As EventArgs) Handles txtTypeOK.TextChanged
        If txtTypeOK.Text = "OK" Then btnSave.Enabled = True Else btnSave.Enabled = False
    End Sub
End Class