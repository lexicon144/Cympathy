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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPersonal.SuspendLayout()
        Me.grpCredentials.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Location = New System.Drawing.Point(221, 325)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(1)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(174, 23)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 324)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Birth Date"
        '
        'txtMi
        '
        Me.txtMi.Location = New System.Drawing.Point(221, 37)
        Me.txtMi.Margin = New System.Windows.Forms.Padding(1)
        Me.txtMi.MaxLength = 1
        Me.txtMi.Name = "txtMi"
        Me.txtMi.Size = New System.Drawing.Size(72, 23)
        Me.txtMi.TabIndex = 1
        '
        'txtCitizenship
        '
        Me.txtCitizenship.Location = New System.Drawing.Point(221, 289)
        Me.txtCitizenship.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCitizenship.MaxLength = 20
        Me.txtCitizenship.Name = "txtCitizenship"
        Me.txtCitizenship.Size = New System.Drawing.Size(174, 23)
        Me.txtCitizenship.TabIndex = 8
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(221, 253)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(1)
        Me.txtAddress.MaxLength = 225
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(174, 23)
        Me.txtAddress.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1, 288)
        Me.Label14.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 17)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Citizenship"
        '
        'rdTeacher
        '
        Me.rdTeacher.AutoSize = True
        Me.rdTeacher.Location = New System.Drawing.Point(101, 1)
        Me.rdTeacher.Margin = New System.Windows.Forms.Padding(1)
        Me.rdTeacher.Name = "rdTeacher"
        Me.rdTeacher.Size = New System.Drawing.Size(82, 20)
        Me.rdTeacher.TabIndex = 12
        Me.rdTeacher.TabStop = True
        Me.rdTeacher.Text = "Teacher"
        Me.rdTeacher.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(221, 217)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(1)
        Me.txtEmail.MaxLength = 40
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(174, 23)
        Me.txtEmail.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1, 252)
        Me.Label13.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 17)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Address"
        '
        'rdStudent
        '
        Me.rdStudent.AutoSize = True
        Me.rdStudent.Location = New System.Drawing.Point(1, 1)
        Me.rdStudent.Margin = New System.Windows.Forms.Padding(1)
        Me.rdStudent.Name = "rdStudent"
        Me.rdStudent.Size = New System.Drawing.Size(78, 20)
        Me.rdStudent.TabIndex = 11
        Me.rdStudent.TabStop = True
        Me.rdStudent.Text = "Student"
        Me.rdStudent.UseVisualStyleBackColor = True
        '
        'grpPersonal
        '
        Me.grpPersonal.Controls.Add(Me.TableLayoutPanel2)
        Me.grpPersonal.Location = New System.Drawing.Point(1, 143)
        Me.grpPersonal.Margin = New System.Windows.Forms.Padding(1)
        Me.grpPersonal.Name = "grpPersonal"
        Me.grpPersonal.Padding = New System.Windows.Forms.Padding(1)
        Me.grpPersonal.Size = New System.Drawing.Size(443, 461)
        Me.grpPersonal.TabIndex = 5
        Me.grpPersonal.TabStop = False
        Me.grpPersonal.Text = "Personal Info"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Full Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1, 360)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Age"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(221, 1)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(1)
        Me.txtFirstname.MaxLength = 10
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(72, 23)
        Me.txtFirstname.TabIndex = 0
        Me.txtFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 108)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Gender"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1, 144)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Cellular Number"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(221, 73)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(1)
        Me.txtSurname.MaxLength = 10
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(72, 23)
        Me.txtSurname.TabIndex = 2
        Me.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1, 216)
        Me.Label12.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "E-Mail"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(221, 361)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(1)
        Me.txtAge.MaxLength = 2
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(30, 23)
        Me.txtAge.TabIndex = 10
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1, 180)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Landline"
        '
        'txtLandlineNumber
        '
        Me.txtLandlineNumber.Location = New System.Drawing.Point(221, 181)
        Me.txtLandlineNumber.Margin = New System.Windows.Forms.Padding(1)
        Me.txtLandlineNumber.MaxLength = 8
        Me.txtLandlineNumber.Name = "txtLandlineNumber"
        Me.txtLandlineNumber.Size = New System.Drawing.Size(174, 23)
        Me.txtLandlineNumber.TabIndex = 5
        Me.txtLandlineNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cellNumber
        '
        Me.cellNumber.Location = New System.Drawing.Point(221, 145)
        Me.cellNumber.Margin = New System.Windows.Forms.Padding(1)
        Me.cellNumber.MaxLength = 16
        Me.cellNumber.Name = "cellNumber"
        Me.cellNumber.Size = New System.Drawing.Size(174, 23)
        Me.cellNumber.TabIndex = 4
        Me.cellNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(221, 109)
        Me.cmbGender.Margin = New System.Windows.Forms.Padding(1)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(72, 25)
        Me.cmbGender.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1, 60)
        Me.Label11.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 17)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Security Question"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1, 90)
        Me.Label10.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 17)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Secret Answer"
        '
        'questionIndex
        '
        Me.questionIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.questionIndex.FormattingEnabled = True
        Me.questionIndex.Items.AddRange(New Object() {"Who was your childhood hero?", "What is life to you?", "What was your childhood nickname?"})
        Me.questionIndex.Location = New System.Drawing.Point(222, 61)
        Me.questionIndex.Margin = New System.Windows.Forms.Padding(1)
        Me.questionIndex.Name = "questionIndex"
        Me.questionIndex.Size = New System.Drawing.Size(174, 25)
        Me.questionIndex.TabIndex = 3
        '
        'txtSecretAnswer
        '
        Me.txtSecretAnswer.Location = New System.Drawing.Point(222, 91)
        Me.txtSecretAnswer.Margin = New System.Windows.Forms.Padding(1)
        Me.txtSecretAnswer.MaxLength = 50
        Me.txtSecretAnswer.Name = "txtSecretAnswer"
        Me.txtSecretAnswer.Size = New System.Drawing.Size(174, 23)
        Me.txtSecretAnswer.TabIndex = 4
        '
        'grpCredentials
        '
        Me.grpCredentials.Controls.Add(Me.TableLayoutPanel1)
        Me.grpCredentials.Location = New System.Drawing.Point(1, 1)
        Me.grpCredentials.Margin = New System.Windows.Forms.Padding(1)
        Me.grpCredentials.Name = "grpCredentials"
        Me.grpCredentials.Padding = New System.Windows.Forms.Padding(1)
        Me.grpCredentials.Size = New System.Drawing.Size(444, 140)
        Me.grpCredentials.TabIndex = 4
        Me.grpCredentials.TabStop = False
        Me.grpCredentials.Text = "Credentials"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(222, 1)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(1)
        Me.txtUsername.MaxLength = 50
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(174, 23)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(222, 31)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPassword.MaxLength = 12
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(174, 23)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(1, 606)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(109, 51)
        Me.btn_save.TabIndex = 6
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtUsername, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPassword, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSecretAnswer, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.questionIndex, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 17)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(442, 122)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.txtAge, 1, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.DateTimePicker1, 1, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.txtMi, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtSurname, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbGender, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.cellNumber, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtLandlineNumber, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.txtEmail, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.txtAddress, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.txtCitizenship, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.txtFirstname, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(1, 17)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 12
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(441, 443)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.rdStudent, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.rdTeacher, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(223, 399)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(200, 22)
        Me.TableLayoutPanel3.TabIndex = 9
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.grpCredentials)
        Me.FlowLayoutPanel1.Controls.Add(Me.grpPersonal)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_save)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(445, 668)
        Me.FlowLayoutPanel1.TabIndex = 7
        '
        'frmUserRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 668)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.WeLearnLMS.My.MySettings.Default, "MainFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.WeLearnLMS.My.MySettings.Default.MainFont
        Me.Name = "frmUserRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formRegistration"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPersonal.ResumeLayout(False)
        Me.grpCredentials.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
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
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
End Class
