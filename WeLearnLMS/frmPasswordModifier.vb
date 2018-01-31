Imports System.Text

Public Class frmPasswordModifier

    Private _MainCredentials As c_MainCredentials
    Private _NewPassword As String
    Private _HashedPassword As String
    Private _Salt As String
    Private _Hasher As IHashing = New StrategyHashingSHA512
    Private _Salter As ISalter = New ImpSalter

    Private Sub frmPasswordModifier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GenerateSalt()
        Me._Salt = Me._Salter.SaltThis()
    End Sub

    Private Sub Hasher()
        Me._HashedPassword = Me._Hasher.HashThis(_NewPassword, _Salt)
    End Sub

    Private Sub PasswordModifier()
        Using Connection As New MySqlConnection
            With Connection
                .ConnectionString = _SharedConnString.ConnString
            End With

            Dim PasswordModifierTransaction As MySqlTransaction = Connection.BeginTransaction
            Try
                Using Command As New MySqlCommand
                    With Command
                        .Connection = Connection
                        .CommandText = "UpdateUserPassword"
                        .Transaction = PasswordModifierTransaction
                        With .Parameters
                            .AddWithValue("UserID", Me._MainCredentials.UserID)
                            .AddWithValue("Salt", Me._Salt)
                            .AddWithValue("SaltedPassword", Me._Salter)
                        End With

                        .ExecuteNonQuery()
                    End With
                    PasswordModifierTransaction.Commit()
                    MessageBox.Show("Password Modification Succeded", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Catch EEE As Exception
                PasswordModifierTransaction.Rollback()
                MessageBox.Show("Password Modification Failed. Changes were not comitted", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub txtPassword2_Validated(sender As Object, e As EventArgs) Handles txtPassword2.Validated
        Me._NewPassword = DirectCast(sender, TextBox).Text
    End Sub

    Private Sub txtPassword2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPassword2.Validating
        With DirectCast(sender, TextBox)
            If .Text = Me.txtPassword1.Text Then
                _NewPassword = .Text
                Exit Sub
            End If
            e.Cancel = True
        End With
    End Sub
End Class