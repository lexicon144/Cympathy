<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradesClassroomCreator
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
        Me.btnClassroomBrowser = New System.Windows.Forms.Button()
        Me.btnUserBrowser = New System.Windows.Forms.Button()
        Me.btnFinalizeGrades = New System.Windows.Forms.Button()
        Me.grpClassroom = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClassroomID = New System.Windows.Forms.TextBox()
        Me.txtClassroomName = New System.Windows.Forms.TextBox()
        Me.grpUser = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.btnToggleRO = New System.Windows.Forms.CheckBox()
        Me.grpGrades = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnMakeGrades = New System.Windows.Forms.Button()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.txtLetter = New System.Windows.Forms.TextBox()
        Me.grpClassroom.SuspendLayout()
        Me.grpUser.SuspendLayout()
        Me.grpGrades.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClassroomBrowser
        '
        Me.btnClassroomBrowser.Location = New System.Drawing.Point(6, 19)
        Me.btnClassroomBrowser.Name = "btnClassroomBrowser"
        Me.btnClassroomBrowser.Size = New System.Drawing.Size(75, 23)
        Me.btnClassroomBrowser.TabIndex = 0
        Me.btnClassroomBrowser.Text = "Browse"
        Me.btnClassroomBrowser.UseVisualStyleBackColor = True
        '
        'btnUserBrowser
        '
        Me.btnUserBrowser.Location = New System.Drawing.Point(6, 19)
        Me.btnUserBrowser.Name = "btnUserBrowser"
        Me.btnUserBrowser.Size = New System.Drawing.Size(75, 23)
        Me.btnUserBrowser.TabIndex = 1
        Me.btnUserBrowser.Text = "Browser"
        Me.btnUserBrowser.UseVisualStyleBackColor = True
        '
        'btnFinalizeGrades
        '
        Me.btnFinalizeGrades.Location = New System.Drawing.Point(552, 226)
        Me.btnFinalizeGrades.Name = "btnFinalizeGrades"
        Me.btnFinalizeGrades.Size = New System.Drawing.Size(75, 23)
        Me.btnFinalizeGrades.TabIndex = 2
        Me.btnFinalizeGrades.Text = "Finalize"
        Me.btnFinalizeGrades.UseVisualStyleBackColor = True
        '
        'grpClassroom
        '
        Me.grpClassroom.Controls.Add(Me.Label2)
        Me.grpClassroom.Controls.Add(Me.Label1)
        Me.grpClassroom.Controls.Add(Me.txtClassroomID)
        Me.grpClassroom.Controls.Add(Me.txtClassroomName)
        Me.grpClassroom.Controls.Add(Me.btnClassroomBrowser)
        Me.grpClassroom.Location = New System.Drawing.Point(12, 12)
        Me.grpClassroom.Name = "grpClassroom"
        Me.grpClassroom.Size = New System.Drawing.Size(200, 151)
        Me.grpClassroom.TabIndex = 3
        Me.grpClassroom.TabStop = False
        Me.grpClassroom.Text = "Classroom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID"
        '
        'txtClassroomID
        '
        Me.txtClassroomID.Location = New System.Drawing.Point(94, 55)
        Me.txtClassroomID.Name = "txtClassroomID"
        Me.txtClassroomID.ReadOnly = True
        Me.txtClassroomID.Size = New System.Drawing.Size(100, 20)
        Me.txtClassroomID.TabIndex = 2
        '
        'txtClassroomName
        '
        Me.txtClassroomName.Location = New System.Drawing.Point(94, 82)
        Me.txtClassroomName.Name = "txtClassroomName"
        Me.txtClassroomName.ReadOnly = True
        Me.txtClassroomName.Size = New System.Drawing.Size(100, 20)
        Me.txtClassroomName.TabIndex = 1
        '
        'grpUser
        '
        Me.grpUser.Controls.Add(Me.Label4)
        Me.grpUser.Controls.Add(Me.Label3)
        Me.grpUser.Controls.Add(Me.txtUserID)
        Me.grpUser.Controls.Add(Me.txtUserName)
        Me.grpUser.Controls.Add(Me.btnUserBrowser)
        Me.grpUser.Location = New System.Drawing.Point(218, 12)
        Me.grpUser.Name = "grpUser"
        Me.grpUser.Size = New System.Drawing.Size(200, 151)
        Me.grpUser.TabIndex = 4
        Me.grpUser.TabStop = False
        Me.grpUser.Text = "User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID"
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(87, 55)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(107, 20)
        Me.txtUserID.TabIndex = 3
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(87, 81)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.ReadOnly = True
        Me.txtUserName.Size = New System.Drawing.Size(107, 20)
        Me.txtUserName.TabIndex = 2
        '
        'btnToggleRO
        '
        Me.btnToggleRO.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnToggleRO.AutoSize = True
        Me.btnToggleRO.Location = New System.Drawing.Point(284, 169)
        Me.btnToggleRO.Name = "btnToggleRO"
        Me.btnToggleRO.Size = New System.Drawing.Size(84, 23)
        Me.btnToggleRO.TabIndex = 5
        Me.btnToggleRO.Text = "Freeze Editing"
        Me.btnToggleRO.UseVisualStyleBackColor = True
        '
        'grpGrades
        '
        Me.grpGrades.Controls.Add(Me.Label6)
        Me.grpGrades.Controls.Add(Me.Label5)
        Me.grpGrades.Controls.Add(Me.btnMakeGrades)
        Me.grpGrades.Controls.Add(Me.txtAverage)
        Me.grpGrades.Controls.Add(Me.txtLetter)
        Me.grpGrades.Location = New System.Drawing.Point(424, 12)
        Me.grpGrades.Name = "grpGrades"
        Me.grpGrades.Size = New System.Drawing.Size(203, 151)
        Me.grpGrades.TabIndex = 6
        Me.grpGrades.TabStop = False
        Me.grpGrades.Text = "Grades"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Mark"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Average"
        '
        'btnMakeGrades
        '
        Me.btnMakeGrades.Location = New System.Drawing.Point(6, 19)
        Me.btnMakeGrades.Name = "btnMakeGrades"
        Me.btnMakeGrades.Size = New System.Drawing.Size(75, 23)
        Me.btnMakeGrades.TabIndex = 2
        Me.btnMakeGrades.Text = "Compute"
        Me.btnMakeGrades.UseVisualStyleBackColor = True
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(94, 80)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.ReadOnly = True
        Me.txtAverage.Size = New System.Drawing.Size(100, 20)
        Me.txtAverage.TabIndex = 1
        '
        'txtLetter
        '
        Me.txtLetter.Location = New System.Drawing.Point(94, 54)
        Me.txtLetter.Name = "txtLetter"
        Me.txtLetter.ReadOnly = True
        Me.txtLetter.Size = New System.Drawing.Size(100, 20)
        Me.txtLetter.TabIndex = 0
        '
        'frmGradesClassroomCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 261)
        Me.Controls.Add(Me.grpGrades)
        Me.Controls.Add(Me.btnToggleRO)
        Me.Controls.Add(Me.grpUser)
        Me.Controls.Add(Me.grpClassroom)
        Me.Controls.Add(Me.btnFinalizeGrades)
        Me.Name = "frmGradesClassroomCreator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGradesClassroomCreator"
        Me.grpClassroom.ResumeLayout(False)
        Me.grpClassroom.PerformLayout()
        Me.grpUser.ResumeLayout(False)
        Me.grpUser.PerformLayout()
        Me.grpGrades.ResumeLayout(False)
        Me.grpGrades.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClassroomBrowser As System.Windows.Forms.Button
    Friend WithEvents btnUserBrowser As System.Windows.Forms.Button
    Friend WithEvents btnFinalizeGrades As System.Windows.Forms.Button
    Friend WithEvents grpClassroom As System.Windows.Forms.GroupBox
    Friend WithEvents txtClassroomID As System.Windows.Forms.TextBox
    Friend WithEvents txtClassroomName As System.Windows.Forms.TextBox
    Friend WithEvents grpUser As System.Windows.Forms.GroupBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents btnToggleRO As System.Windows.Forms.CheckBox
    Friend WithEvents grpGrades As System.Windows.Forms.GroupBox
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents txtLetter As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnMakeGrades As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
