Imports System.Text

Public Class frmPasswordModifier

    Private _MainCredentials As c_MainCredentials
    Private _NewPassword As String
    Private _HashedPassword As String
    Private _Salt As String
    Private _Hasher As IHashing = New StrategyHashingSHA512
    Private _Salter As ISalter = New ImpSalter
    Private _UserID As String

    Public Sub New(ByRef UserID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        btnOK.Enabled = False
        Me._UserID = UserID
    End Sub

    Private Sub frmPasswordModifier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Challenge As New frmPasswordChallenge(_UserID)
        If Challenge.ShowDialog = Windows.Forms.DialogResult.Yes Then
            btnOK.Enabled = True
            Exit Sub
        End If
        btnOK.Enabled = False
    End Sub

    Private Sub GenerateSalt()
        Me._Salt = Me._Salter.SaltThis()
    End Sub

    Private Sub Hasher()
        Me._HashedPassword = Me._Hasher.HashThis(_NewPassword, _Salt)
    End Sub

    Private Sub PasswordModifier()
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With

            Dim PasswordModifierTransaction As MySqlTransaction = Connection.BeginTransaction
            Try
                Using Command As New MySqlCommand
                    With Command
                        .Connection = Connection
                        .CommandText = "UpdateUserPassword"
                        .Transaction = PasswordModifierTransaction
                        With .Parameters
                            .AddWithValue("UserID", _SharedUserID)
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
                DisplayLinkingTransactionFailed(EEE)
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

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        GenerateSalt()
        Hasher()
        PasswordModifier()
    End Sub

    Private Sub Checker_TextChanged(sender As Object, e As EventArgs) Handles txtPassword2.TextChanged, txtPassword2.TextChanged

        If (txtPassword1.Text = txtPassword2.Text) Then
            btnOK.Enabled = True
            Exit Sub
        End If
        btnOK.Enabled = False
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        With Me
            .txtPassword1.UseSystemPasswordChar = False
            .txtPassword2.UseSystemPasswordChar = False
        End With
    End Sub

    Private Sub Button1_MouseUp(sender As Object, e As MouseEventArgs) Handles Button1.MouseUp
        With Me
            .txtPassword1.UseSystemPasswordChar = True
            .txtPassword2.UseSystemPasswordChar = True
        End With
    End Sub
End Class