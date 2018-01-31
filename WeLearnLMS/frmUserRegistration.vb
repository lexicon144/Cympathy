Public Class frmUserRegistration

    Private _Information As New c_AdvancedCredentials
    Private _Validator As New ContextVerification
    Private _Hasher As IHashing = New StrategyHashingSHA512
    Private _Salter As ISalter = New ImpSalter

    Private MainSalt As String

    Private Sub frmUserRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainSalt = _Salter.SaltThis()
        _Information.UserSalt = MainSalt
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        Using Connection As New MySqlConnection()

            With Connection
                .ConnectionString = _SharedConnString.ConnString
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With

            Dim RegistrationTransaction As MySqlTransaction = Connection.BeginTransaction
            Using Command = New MySqlCommand()
                Try
                    With Command
                        .Transaction = RegistrationTransaction
                        .Connection = Connection
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "InsertNewUser"
                        With .Parameters
                            .AddWithValue("userType", Me._Information.MyUserType)
                            .AddWithValue("userFname", Me._Information.UserFirstName)
                            .AddWithValue("userMi", Me._Information.UserMiddleName)
                            .AddWithValue("userLname", Me._Information.UserLastName)
                            .AddWithValue("userName", Me._Information.UserName)
                            .AddWithValue("userLOL", Me._Information.UserSalt)
                            .AddWithValue("userHash", Me._Information.UserSaltedPassword)
                            .AddWithValue("questionIndex", Me._Information.QuestionIndex)
                            .AddWithValue("secAnswer", Me._Information.SaltedAnswer)
                            .AddWithValue("userGender", Me._Information.UserGender)
                            .AddWithValue("userCell", Me._Information.UserCellularNumber)
                            .AddWithValue("userLandline", Me._Information.UserLandline)
                            .AddWithValue("userDob", Me._Information.UserDOB)
                            .AddWithValue("address", Me._Information.UserAddress)
                            .AddWithValue("email", Me._Information.UserEmail)
                            .AddWithValue("isActive", True)
                        End With
                    End With
                    Command.ExecuteNonQuery()
                    RegistrationTransaction.Commit()
                    MessageBox.Show("User has been registered to the system", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch x As MySqlException
                    RegistrationTransaction.Rollback()
                    MessageBox.Show("User has not been registered to the system. Changes were not applied to the database" & vbNewLine & x.Message, "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End Try
            End Using
        End Using
    End Sub

    Private Sub txtUsername_Validated(sender As Object, e As EventArgs) Handles txtUsername.Validated
        Me._Information.UserName = DirectCast(sender, TextBox).Text
    End Sub

    Private Sub txtPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPassword.Validating
        Me._Information.UserSaltedPassword = _Hasher.HashThis(DirectCast(sender, TextBox).Text, MainSalt)
    End Sub

    Private Sub txtSecretAnswer_Validated(sender As Object, e As EventArgs) Handles txtSecretAnswer.Validated
        Me._Information.SaltedAnswer = DirectCast(sender, TextBox).Text
    End Sub

    Private Sub txtFirstname_Validated(sender As Object, e As EventArgs) Handles txtFirstname.Validated
        Me._Information.UserFirstName = DirectCast(sender, TextBox).Text
    End Sub

    Private Sub txtMi_Validated(sender As Object, e As EventArgs) Handles txtMi.Validated
        Me._Information.UserMiddleName = DirectCast(sender, TextBox).Text
    End Sub

    Private Sub txtSurname_Validated(sender As Object, e As EventArgs) Handles txtSurname.Validated
        Me._Information.UserLastName = DirectCast(sender, TextBox).Text
        Console.WriteLine(txtSurname.Text)
    End Sub

    Private Sub cmbGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGender.SelectedIndexChanged
        Me._Information.UserGender = DirectCast(sender, ComboBox).SelectedIndex
    End Sub

    Private Sub cellNumber_Validated(sender As Object, e As EventArgs) Handles cellNumber.Validated
        Me._Information.UserCellularNumber = DirectCast(sender, TextBox).Text
    End Sub

    Private Sub txtLandlineNumber_Validated(sender As Object, e As EventArgs) Handles txtLandlineNumber.Validated
        Me._Information.UserLandline = DirectCast(sender, TextBox).Text
    End Sub

    Private Sub txtEmail_Validated(sender As Object, e As EventArgs) Handles txtEmail.Validated
        Me._Information.UserEmail = DirectCast(sender, TextBox).Text
    End Sub

    Private Sub txtAddress_Validated(sender As Object, e As EventArgs) Handles txtAddress.Validated
        Me._Information.UserAddress = DirectCast(sender, TextBox).Text
    End Sub

    Private Sub txtCitizenship_Validated(sender As Object, e As EventArgs) Handles txtCitizenship.Validated
        Me._Information.Citizenship = DirectCast(sender, TextBox).Text
    End Sub

    Private Sub txtAge_Validated(sender As Object, e As EventArgs) Handles txtAge.Validated
        Me._Information.UserAge = DirectCast(sender, TextBox).Text
    End Sub

    Private Sub rdTeacher_CheckedChanged(sender As Object, e As EventArgs) Handles rdTeacher.CheckedChanged
        Me._Information.MyUserType = c_MainCredentials.UserType.PRO
    End Sub

    Private Sub rdStudent_CheckedChanged(sender As Object, e As EventArgs) Handles rdStudent.CheckedChanged
        Me._Information.MyUserType = c_MainCredentials.UserType.STU
    End Sub

    Private Sub UsernameValidation(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating, txtUsername.Validating, txtSecretAnswer.Validating, txtFirstname.Validating, txtMi.Validating, txtSurname.Validating, txtCitizenship.Validating
        If Not _Validator.Verify(VMethodology.Username, DirectCast(sender, TextBox).Text) Then
            ErrorProvider1.SetError(DirectCast(sender, TextBox), "Invalid Username")
            e.Cancel = True
            DirectCast(sender, TextBox).SelectAll()
            Exit Sub
        End If
        ErrorProvider1.SetError(DirectCast(sender, TextBox), "")
    End Sub

    Private Sub cellNumber_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cellNumber.Validating
        If Not _Validator.Verify(VMethodology.Cellular, DirectCast(sender, TextBox).Text) Then
            ErrorProvider1.SetError(DirectCast(sender, TextBox), "Invalid Username")
            e.Cancel = True
            DirectCast(sender, TextBox).SelectAll()
            Exit Sub
        End If
        ErrorProvider1.SetError(DirectCast(sender, TextBox), "")
    End Sub

    Private Sub txtLandlineNumber_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtLandlineNumber.Validating
        If Not _Validator.Verify(VMethodology.Landline, DirectCast(sender, TextBox).Text) Then
            ErrorProvider1.SetError(DirectCast(sender, TextBox), "Invalid Username")
            e.Cancel = True
            DirectCast(sender, TextBox).SelectAll()
            Exit Sub
        End If
        ErrorProvider1.SetError(DirectCast(sender, TextBox), "")
    End Sub

    Private Sub txtAddress_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAddress.Validating
        If Not _Validator.Verify(VMethodology.Username, DirectCast(sender, TextBox).Text) Then
            ErrorProvider1.SetError(DirectCast(sender, TextBox), "Invalid Username")
            e.Cancel = True
            DirectCast(sender, TextBox).SelectAll()
            Exit Sub
        End If
        ErrorProvider1.SetError(DirectCast(sender, TextBox), "")
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        With DirectCast(sender, DateTimePicker)

            txtAge.Text = GetBaseAge(.Value.Date).ToString
            Me._Information.UserDOB = .Value.Date
        End With

    End Sub

    Private Function GetBaseAge(ByVal dob As Date) As Integer
        Dim age As Integer = Today.Year - dob.Year
        If (dob > Today.AddYears(-age)) Then age -= 1
        Return age
    End Function

End Class