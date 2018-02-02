<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserRegistration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMi = New System.Windows.Forms.TextBox()
        Me.txtCitizenship = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rdTeacher = New System.Windows.Forms.RadioButton()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.rdStudent = New System.Windows.Forms.RadioButton()
        Me.grpPersonal = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLandlineNumber = New System.Windows.Forms.TextBox()
        Me.cellNumber = New System.Windows.Forms.TextBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.questionIndex = New System.Windows.Forms.ComboBox()
        Me.txtSecretAnswer = New System.Windows.Forms.TextBox()
        Me.grpCredentials = New System.Windows.Forms.GroupBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPersonal.SuspendLayout()
        Me.grpCredentials.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Location = New System.Drawing.Point(107, 171)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(1)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(174, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 176)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Birth Date"
        '
        'txtMi
        '
        Me.txtMi.Location = New System.Drawing.Point(178, 16)
        Me.txtMi.Margin = New System.Windows.Forms.Padding(1)
        Me.txtMi.MaxLength = 1
        Me.txtMi.Name = "txtMi"
        Me.txtMi.Size = New System.Drawing.Size(30, 20)
        Me.txtMi.TabIndex = 1
        '
        'txtCitizenship
        '
        Me.txtCitizenship.Location = New System.Drawing.Point(107, 149)
        Me.txtCitizenship.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCitizenship.MaxLength = 20
        Me.txtCitizenship.Name = "txtCitizenship"
        Me.txtCitizenship.Size = New System.Drawing.Size(174, 20)
        Me.txtCitizenship.TabIndex = 8
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(107, 127)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(1)
        Me.txtAddress.MaxLength = 225
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(174, 20)
        Me.txtAddress.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(48, 152)
        Me.Label14.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Citizenship"
        '
        'rdTeacher
        '
        Me.rdTeacher.AutoSize = True
        Me.rdTeacher.Location = New System.Drawing.Point(171, 213)
        Me.rdTeacher.Margin = New System.Windows.Forms.Padding(1)
        Me.rdTeacher.Name = "rdTeacher"
        Me.rdTeacher.Size = New System.Drawing.Size(65, 17)
        Me.rdTeacher.TabIndex = 12
        Me.rdTeacher.TabStop = True
        Me.rdTeacher.Text = "Teacher"
        Me.rdTeacher.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(107, 105)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(1)
        Me.txtEmail.MaxLength = 40
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(174, 20)
        Me.txtEmail.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(60, 130)
        Me.Label13.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Address"
        '
        'rdStudent
        '
        Me.rdStudent.AutoSize = True
        Me.rdStudent.Location = New System.Drawing.Point(107, 213)
        Me.rdStudent.Margin = New System.Windows.Forms.Padding(1)
        Me.rdStudent.Name = "rdStudent"
        Me.rdStudent.Size = New System.Drawing.Size(62, 17)
        Me.rdStudent.TabIndex = 11
        Me.rdStudent.TabStop = True
        Me.rdStudent.Text = "Student"
        Me.rdStudent.UseVisualStyleBackColor = True
        '
        'grpPersonal
        '
        Me.grpPersonal.Controls.Add(Me.DateTimePicker1)
        Me.grpPersonal.Controls.Add(Me.Label4)
        Me.grpPersonal.Controls.Add(Me.txtMi)
        Me.grpPersonal.Controls.Add(Me.txtCitizenship)
        Me.grpPersonal.Controls.Add(Me.txtAddress)
        Me.grpPersonal.Controls.Add(Me.Label14)
        Me.grpPersonal.Controls.Add(Me.rdTeacher)
        Me.grpPersonal.Controls.Add(Me.Label3)
        Me.grpPersonal.Controls.Add(Me.Label6)
        Me.grpPersonal.Controls.Add(Me.txtEmail)
        Me.grpPersonal.Controls.Add(Me.Label13)
        Me.grpPersonal.Controls.Add(Me.txtFirstname)
        Me.grpPersonal.Controls.Add(Me.Label5)
        Me.grpPersonal.Controls.Add(Me.rdStudent)
        Me.grpPersonal.Controls.Add(Me.Label7)
        Me.grpPersonal.Controls.Add(Me.txtSurname)
        Me.grpPersonal.Controls.Add(Me.Label12)
        Me.grpPersonal.Controls.Add(Me.txtAge)
        Me.grpPersonal.Controls.Add(Me.Label8)
        Me.grpPersonal.Controls.Add(Me.txtLandlineNumber)
        Me.grpPersonal.Controls.Add(Me.cellNumber)
        Me.grpPersonal.Controls.Add(Me.cmbGender)
        Me.grpPersonal.Location = New System.Drawing.Point(10, 123)
        Me.grpPersonal.Margin = New System.Windows.Forms.Padding(1)
        Me.grpPersonal.Name = "grpPersonal"
        Me.grpPersonal.Padding = New System.Windows.Forms.Padding(1)
        Me.grpPersonal.Size = New System.Drawing.Size(317, 274)
        Me.grpPersonal.TabIndex = 5
        Me.grpPersonal.TabStop = False
        Me.grpPersonal.Text = "Personal Info"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Full Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(79, 196)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Age"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(107, 16)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(1)
        Me.txtFirstname.MaxLength = 10
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(69, 20)
        Me.txtFirstname.TabIndex = 0
        Me.txtFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 41)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Gender"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 62)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Cellular Number"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(209, 16)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(1)
        Me.txtSurname.MaxLength = 10
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(72, 20)
        Me.txtSurname.TabIndex = 2
        Me.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(69, 108)
        Me.Label12.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "E-Mail"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(107, 193)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(1)
        Me.txtAge.MaxLength = 2
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(30, 20)
        Me.txtAge.TabIndex = 10
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 86)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Landline"
        '
        'txtLandlineNumber
        '
        Me.txtLandlineNumber.Location = New System.Drawing.Point(107, 83)
        Me.txtLandlineNumber.Margin = New System.Windows.Forms.Padding(1)
        Me.txtLandlineNumber.MaxLength = 8
        Me.txtLandlineNumber.Name = "txtLandlineNumber"
        Me.txtLandlineNumber.Size = New System.Drawing.Size(174, 20)
        Me.txtLandlineNumber.TabIndex = 5
        Me.txtLandlineNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cellNumber
        '
        Me.cellNumber.Location = New System.Drawing.Point(107, 61)
        Me.cellNumber.Margin = New System.Windows.Forms.Padding(1)
        Me.cellNumber.MaxLength = 16
        Me.cellNumber.Name = "cellNumber"
        Me.cellNumber.Size = New System.Drawing.Size(174, 20)
        Me.cellNumber.TabIndex = 4
        Me.cellNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(107, 38)
        Me.cmbGender.Margin = New System.Windows.Forms.Padding(1)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(53, 21)
        Me.cmbGender.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 67)
        Me.Label11.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Security Question"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 85)
        Me.Label10.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Secret Answer"
        '
        'questionIndex
        '
        Me.questionIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.questionIndex.FormattingEnabled = True
        Me.questionIndex.Items.AddRange(New Object() {"Who was your childhood hero?", "What is life to you?", "What was your childhood nickname?"})
        Me.questionIndex.Location = New System.Drawing.Point(107, 59)
        Me.questionIndex.Margin = New System.Windows.Forms.Padding(1)
        Me.questionIndex.Name = "questionIndex"
        Me.questionIndex.Size = New System.Drawing.Size(174, 21)
        Me.questionIndex.TabIndex = 3
        '
        'txtSecretAnswer
        '
        Me.txtSecretAnswer.Location = New System.Drawing.Point(107, 82)
        Me.txtSecretAnswer.Margin = New System.Windows.Forms.Padding(1)
        Me.txtSecretAnswer.MaxLength = 50
        Me.txtSecretAnswer.Name = "txtSecretAnswer"
        Me.txtSecretAnswer.Size = New System.Drawing.Size(174, 20)
        Me.txtSecretAnswer.TabIndex = 4
        '
        'grpCredentials
        '
        Me.grpCredentials.Controls.Add(Me.Label11)
        Me.grpCredentials.Controls.Add(Me.Label10)
        Me.grpCredentials.Controls.Add(Me.questionIndex)
        Me.grpCredentials.Controls.Add(Me.txtUsername)
        Me.grpCredentials.Controls.Add(Me.txtPassword)
        Me.grpCredentials.Controls.Add(Me.txtSecretAnswer)
        Me.grpCredentials.Controls.Add(Me.Label1)
        Me.grpCredentials.Controls.Add(Me.Label2)
        Me.grpCredentials.Location = New System.Drawing.Point(10, 10)
        Me.grpCredentials.Margin = New System.Windows.Forms.Padding(1)
        Me.grpCredentials.Name = "grpCredentials"
        Me.grpCredentials.Padding = New System.Windows.Forms.Padding(1)
        Me.grpCredentials.Size = New System.Drawing.Size(317, 111)
        Me.grpCredentials.TabIndex = 4
        Me.grpCredentials.TabStop = False
        Me.grpCredentials.Text = "Credentials"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(107, 16)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(1)
        Me.txtUsername.MaxLength = 50
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(174, 20)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(107, 38)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPassword.MaxLength = 12
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(174, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(259, 413)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(68, 28)
        Me.btn_save.TabIndex = 6
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'frmUserRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 451)
        Me.Controls.Add(Me.grpPersonal)
        Me.Controls.Add(Me.grpCredentials)
        Me.Controls.Add(Me.btn_save)
        Me.Name = "frmUserRegistration"
        Me.Text = "formRegistration"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPersonal.ResumeLayout(False)
        Me.grpPersonal.PerformLayout()
        Me.grpCredentials.ResumeLayout(False)
        Me.grpCredentials.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents grpPersonal As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMi As System.Windows.Forms.TextBox
    Friend WithEvents txtCitizenship As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents rdTeacher As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rdStudent As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtLandlineNumber As System.Windows.Forms.TextBox
    Friend WithEvents cellNumber As System.Windows.Forms.TextBox
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents grpCredentials As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents questionIndex As System.Windows.Forms.ComboBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtSecretAnswer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
End Class
