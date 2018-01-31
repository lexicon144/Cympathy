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
Public Class frmLogin
    Private _PreInfo As New DataTable
    Private _ConString As IConStringBuilder = New ImpConStringBuilder
    Private _UserMainCredentials As New c_MainCredentials
    Private _UserAdvancedCredentials As New c_AdvancedCredentials

    Private _UserQuestionIndex As UInt16
    Private _UserQuestionAnswer As String

    Private _Hasher As IHashing = New StrategyHashingSHA512

    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogMeIn()
        Using Connection As New MySqlConnection
            With Connection
                .ConnectionString = _ConString.ConnString
            End With

            Dim LoginTransaction As MySqlTransaction = Connection.BeginTransaction(IsolationLevel.ReadCommitted)
            Try
                Using Command As New MySqlCommand

                    With Command
                        .Connection = Connection
                        .CommandText = "SELECT * FROM tbl_user WHERE user_name = @UserName"
                        With .Parameters
                            .AddWithValue("@UserName", txtUsername.Text)
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

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        LogMeIn()
        PreInfoToCredentialsParser()

        If ValidateLogin() Then

        End If
    End Sub
End Class
