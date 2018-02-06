Public Class frmServerEditor

    Private IPHost As String

    Private Sub ChangeHostName()
        My.Settings("city85") = IPHost
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ChangeHostName()
        Catch XXX As Exception
            DisplayGeneralException(XXX)
        End Try
    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        If Not _SharedValidator.Verify(VMethodology.IPAddress, DirectCast(sender, TextBox).Text) Then
            ErrorProvider1.SetError(DirectCast(sender, TextBox), "Invalid IP / Hostname")
            e.Cancel = True
            DirectCast(sender, TextBox).SelectAll()
            Exit Sub
        End If
        ErrorProvider1.SetError(DirectCast(sender, TextBox), "")
    End Sub

    Private Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles TextBox1.Validated
        Me.IPHost = DirectCast(sender, TextBox).Text
    End Sub
End Class