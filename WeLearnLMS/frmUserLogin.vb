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
    Private _IsOnline As Boolean
    Private _UserMainCredentials As New c_MainCredentials
    Private _UserAdvancedCredentials As New c_AdvancedCredentials

    Private _UserQuestionIndex As UInt16
    Private _UserQuestionAnswer As String

    Private _Hasher As IHashing = New StrategyHashingSHA512

    Private _StopWatch As New Stopwatch

    Private _Username As String
    Private _Validator As New ContextVerification

    Private _Attempts As UInt16 = 0
    Private _LoginStopwatch As New Stopwatch

    Private _MySession As New ImpStartSession

    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Pinger As New frmSQLPinger
        If Pinger.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.btnLogin.Enabled = Pinger.Safety
        End If
        _StopWatch.Start()
        Timer1.Start()
    End Sub

    Private Sub SelectThisUser()
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
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "SelectUser"
                        With .Parameters
                            .AddWithValue("UserName", _Username)
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
                Console.WriteLine(eee.Message)
            End Try
        End Using
    End Sub

    ''' <summary>
    ''' Validate the Login
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LoginValidated() As Boolean

        Dim TestingPassword As String
        TestingPassword = _Hasher.HashThis(Me.txtPassword.Text, Me._UserMainCredentials.UserSalt)
        Return TestingPassword = Me._UserMainCredentials.UserSaltedPassword

    End Function

    ''' <summary>
    ''' Parse Datatables to Credentials
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PreInfoToCredentialsParser()
        With Me
            ._UserQuestionIndex = _PreInfo.Rows(0)("questionIndex").ToString()
            ._UserQuestionAnswer = _PreInfo.Rows(0)("sec_ans").ToString()
            With ._UserMainCredentials
                _SharedUserID = _PreInfo.Rows(0)("user_id").ToString
                .UserID = _PreInfo.Rows(0)("user_id").ToString()
                .MyUserType = _PreInfo.Rows(0)("user_type").ToString()
                .UserName = _PreInfo.Rows(0)("user_name").ToString()
                .UserSalt = _PreInfo.Rows(0)("user_leagueoflegends").ToString()
                .UserSaltedPassword = _PreInfo.Rows(0)("user_password").ToString()
            End With
            ._IsOnline = _PreInfo.Rows(0)("isOnline").ToString()
        End With
        With Me._UserAdvancedCredentials

            .QuestionIndex = _PreInfo.Rows(0)("questionIndex").ToString()
            .SaltedAnswer = _PreInfo.Rows(0)("sec_ans").ToString()
            .UserID = _PreInfo.Rows(0)("user_id").ToString()
            .MyUserType = _PreInfo.Rows(0)("user_type").ToString()
            .UserName = _PreInfo.Rows(0)("user_name").ToString()
            .UserSalt = _PreInfo.Rows(0)("user_leagueoflegends").ToString()
            .UserSaltedPassword = _PreInfo.Rows(0)("user_password").ToString()
            .UserFirstName = _PreInfo.Rows(0)("user_fname").ToString()
            .UserMiddleName = _PreInfo.Rows(0)("user_mi").ToString()
            .UserLastName = _PreInfo.Rows(0)("user_lname").ToString()
            .UserGender = _PreInfo.Rows(0)("user_gender").ToString()
            .UserCellularNumber = _PreInfo.Rows(0)("user_cellularnumber").ToString()
            .UserLandline = _PreInfo.Rows(0)("user_landline").ToString()
            .UserAddress = _PreInfo.Rows(0)("address").ToString()
            .UserEmail = _PreInfo.Rows(0)("email").ToString()
        End With
    End Sub

    Private Sub ShareMe()
        _SharedAdvancedCredentials = Me._UserAdvancedCredentials
        _SharedMainCredentials = Me._UserMainCredentials
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        SelectThisUser()
        PreInfoToCredentialsParser()
        ShareMe()
        Dim NYOOOMS As String = Application.StartupPath & "\foo\" & _SharedMainCredentials.UserName & ".nyooom"
        'Password and Username Verified
        If LoginValidated() Then

            If Me._IsOnline Then
                MessageBox.Show("YOU ARE ONLINE ELSEWHERE", "me", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                If System.IO.File.Exists(NYOOOMS) Then 'corrupted session most likeley
                    MessageBox.Show("YOUR SESSION FILE WAS FOUND! You might not have logged out correctly earlier!! Cympathy will make a new sesssion for you!", "Cympathy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\foo\" & _SharedMainCredentials.UserName & ".nyooom", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
                End If
            Else
                MessageBox.Show("YOU ARE NOT ONLINE ELSEWHERE", "me", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


            Using MainMenu As New frmMenu(Me._UserAdvancedCredentials)
                MainMenu.ShowDialog()
                _SharedAdvancedCredentials = Nothing
                _SharedMainCredentials = Nothing
                LinkLabel2.Enabled = False
            End Using

            _Attempts = 0

        Else
            'Password and username wrong
            MessageBox.Show("There was a problem when (You) tried to login! Your username or password might not have been registered", "Cympathy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            LinkLabel2.Enabled = True
            _Attempts += 1
            LoginControl()
        End If

        If System.IO.File.Exists(NYOOOMS) Then
            Console.WriteLine("Found session file")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\foo\" & _SharedMainCredentials.UserName & ".nyooom", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        End If
    End Sub

#Region "validation"
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
#End Region

#Region "Misc"

    ''' <summary>
    ''' Register a user
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Using registration As New frmUserRegistration
            registration.DisableProfessors = True
            registration.ShowDialog()
        End Using

    End Sub

    ''' <summary>
    ''' open the forgot password
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        'check if this user id exists
        If Me._PreInfo.Rows(0)("user_id").ToString() Is "" Then Exit Sub

        Dim passwordchallenge As New frmPasswordModifier(_PreInfo.Rows(0)("user_id").ToString())
        passwordchallenge.ShowDialog()
    End Sub

    ''' <summary>
    ''' Open Server Management
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub lblChangeServer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblChangeServer.LinkClicked
        Dim editor As New frmServerEditor()
        editor.ShowDialog()
    End Sub

    ''' <summary>
    ''' Client Log Timer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHH.Text = _StopWatch.Elapsed.Hours
        lblMM.Text = _StopWatch.Elapsed.Minutes
        lblSS.Text = _StopWatch.Elapsed.Seconds
    End Sub

    ''' <summary>
    ''' Login Limit Timer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub LoginTimer_Tick(sender As Object, e As EventArgs) Handles LoginTimer.Tick
        With Me
            If ._LoginStopwatch.Elapsed.Seconds = 5 Then
                .LoginTimer.Enabled = False
                ._LoginStopwatch.Stop()
                ._LoginStopwatch.Reset()
                .btnLogin.Enabled = True
            End If
        End With
    End Sub
    ''' <summary>
    ''' Login Control
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoginControl()

        If _Attempts = 5 Then
            Me._LoginStopwatch.Start()
            btnLogin.Enabled = False
            Me._StopWatch.Start()
        End If

    End Sub

#End Region
End Class
