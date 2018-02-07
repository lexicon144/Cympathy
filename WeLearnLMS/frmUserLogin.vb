''' <summary>
'''░░░░░░░█▐▓▓░████▄▄▄█▀▄▓▓▓▌█ 
'''░░░░░▄█▌▀▄▓▓▄▄▄▄▀▀▀▄▓▓▓▓▓▌█ 
'''░░░▄█▀▀▄▓█▓▓▓▓▓▓▓▓▓▓▓▓▀░▓▌█ 
'''░░█▀▄▓▓▓███▓▓▓███▓▓▓▄░░▄▓▐█▌ 
'''░█▌▓▓▓▀▀▓▓▓▓███▓▓▓▓▓▓▓▄▀▓▓▐█ 
'''▐█▐██▐░▄▓▓▓▓▓▀▄░▀▓▓▓▓▓▓▓▓▓▌█▌ Big Doge is watching
'''█▌███▓▓▓▓▓▓▓▓▐░░▄▓▓███▓▓▓▄▀▐█ 
'''█▐█▓▀░░▀▓▓▓▓▓▓▓▓▓██████▓▓▓▓▐█ 
'''▌▓▄▌▀░▀░▐▀█▄▓▓██████████▓▓▓▌█▌ 
'''▌▓▓▓▄▄▀▀▓▓▓▀▓▓▓▓▓▓▓▓█▓█▓█▓▓▌█▌ 
'''█▐▓▓▓▓▓▓▄▄▄▓▓▓▓▓▓█▓█▓█▓█▓▓▓▐█
''' </summary>
''' <remarks></remarks>
Public Class frmUserLogin
    Private _PreInfo As New DataTable

    Private _UserMainCredentials As New c_MainCredentials
    Private _UserAdvancedCredentials As New c_AdvancedCredentials

    Private _UserQuestionIndex As UInt16
    Private _UserQuestionAnswer As String

    Private _Hasher As IHashing = New StrategyHashingSHA512

    Private _Username As String
    Private _Validator As New ContextVerification
    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Pinger As New frmSQLPinger
        If Pinger.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.btnLogin.Enabled = Pinger.Safety
        End If
    End Sub

    Private Sub LogMeIn()
        Using Connection As New MySqlConnection
            With Connection
                .ConnectionString = _SharedConnString.ConnString
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With

            Dim LoginTransaction As MySqlTransaction = Connection.BeginTransaction(IsolationLevel.ReadCommitted)
            Try
                Using Command As New MySqlCommand

                    With Command
                        .Connection = Connection
                        .CommandText = "SELECT * FROM tbl_user WHERE user_name = @UserName"
                        With .Parameters
                            .AddWithValue("@UserName", _Username)
                        End With
                    End With

                    Using Adapter As New MySqlDataAdapter
                        With Adapter
                            .SelectCommand = Command
                            .Fill(_PreInfo)
                        End With
                    End Using
                End Using
            Catch eee As Exception
            End Try

        End Using
    End Sub

    Private Function ValidateLogin() As Boolean

        Dim TestingPassword As String
        TestingPassword = _Hasher.HashThis(Me.txtPassword.Text, Me._UserMainCredentials.UserSalt)
        Return TestingPassword = Me._UserMainCredentials.UserSaltedPassword

    End Function

    Private Sub PreInfoToCredentialsParser()
        With Me
            ._UserQuestionIndex = _PreInfo.Rows(0)("questionIndex").ToString()
            ._UserQuestionAnswer = _PreInfo.Rows(0)("sec_ans").ToString()
            With ._UserMainCredentials
                _SharedUserID = _PreInfo.Rows(0)("user_id").ToString()
                .UserID = _PreInfo.Rows(0)("user_id").ToString()
                .MyUserType = _PreInfo.Rows(0)("user_type").ToString()
                .UserName = _PreInfo.Rows(0)("user_name").ToString()
                .UserSalt = _PreInfo.Rows(0)("user_leagueoflegends").ToString()
                .UserSaltedPassword = _PreInfo.Rows(0)("user_password").ToString()
            End With
        End With
        With Me._UserAdvancedCredentials
            .UserFirstName = _PreInfo.Rows(0)("user_fname").ToString()
            .UserMiddleName = _PreInfo.Rows(0)("user_mi").ToString()
            .UserLastName = _PreInfo.Rows(0)("user_lname").ToString()
            .UserGender = _PreInfo.Rows(0)("user_gender").ToString()
            .UserCellularNumber = _PreInfo.Rows(0)("user_cellularnumber").ToString()
            .UserLandline = _PreInfo.Rows(0)("user_landline").ToString()
            '. = _PreInfo.Rows(0)("user_dob").ToString()
            .UserAddress = _PreInfo.Rows(0)("address").ToString()
            .UserEmail = _PreInfo.Rows(0)("email").ToString()
        End With
    End Sub

    Private Sub ShareMe()
        _SharedAdvancedCredentials = Me._UserAdvancedCredentials
        _SharedMainCredentials = Me._UserMainCredentials
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Me._PreInfo.Clear()
            LogMeIn()

            If _PreInfo Is Nothing And _PreInfo.Rows.Count = 0 Then
                MessageBox.Show("(You) do not exist!", "Non-existent Username", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            PreInfoToCredentialsParser()

            BackgroundWorker1.RunWorkerAsync(ValidateLogin())
            Me.LinkLabel2.Enabled = True
        Catch XXX As Exception
            MessageBox.Show("Something wrong happened when (You) tried to login. Reason: " & XXX.Message, "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim value As Boolean = e.Argument
        e.Result = value
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        
        If e.Result Then
            ShareMe()

            Dim MainMenu As New frmMenu(Me._UserAdvancedCredentials)

            MainMenu.ShowDialog()
            _SharedAdvancedCredentials = Nothing
            _SharedMainCredentials = Nothing

            Exit Sub
        End If
        MessageBox.Show("Your password or username was incorrect", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim registration As New frmUserRegistration
        registration.ShowDialog()
    End Sub

    Private Sub txtUsername_Validated(sender As Object, e As EventArgs) Handles txtUsername.Validated
        Me._Username = DirectCast(sender, TextBox).Text
    End Sub

    Private Sub txtUsername_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUsername.Validating
        If Not _Validator.Verify(VMethodology.Username, DirectCast(sender, TextBox).Text) Then
            ErrorProvider1.SetError(DirectCast(sender, TextBox), "Invalid Username")
            e.Cancel = True
            DirectCast(sender, TextBox).SelectAll()
            Exit Sub
        End If
        ErrorProvider1.SetError(DirectCast(sender, TextBox), "")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        'check if this user id exists
        If Me._PreInfo.Rows(0)("user_id").ToString() Is Nothing Then Exit Sub

        Dim passwordchallenge As New frmPasswordModifier(_PreInfo.Rows(0)("user_id").ToString())
        passwordchallenge.ShowDialog()
    End Sub

    Private Sub lblChangeServer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblChangeServer.LinkClicked
        Dim editor As New frmServerEditor()
        editor.ShowDialog()
    End Sub
End Class
