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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpClassroom.SuspendLayout()
        Me.grpUser.SuspendLayout()
        Me.grpGrades.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClassroomBrowser
        '
        Me.btnClassroomBrowser.Location = New System.Drawing.Point(8, 23)
        Me.btnClassroomBrowser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClassroomBrowser.Name = "btnClassroomBrowser"
        Me.btnClassroomBrowser.Size = New System.Drawing.Size(100, 28)
        Me.btnClassroomBrowser.TabIndex = 0
        Me.btnClassroomBrowser.Text = "Browse"
        Me.btnClassroomBrowser.UseVisualStyleBackColor = True
        '
        'btnUserBrowser
        '
        Me.btnUserBrowser.Location = New System.Drawing.Point(8, 23)
        Me.btnUserBrowser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUserBrowser.Name = "btnUserBrowser"
        Me.btnUserBrowser.Size = New System.Drawing.Size(100, 28)
        Me.btnUserBrowser.TabIndex = 1
        Me.btnUserBrowser.Text = "Browser"
        Me.btnUserBrowser.UseVisualStyleBackColor = True
        '
        'btnFinalizeGrades
        '
        Me.btnFinalizeGrades.Location = New System.Drawing.Point(724, 198)
        Me.btnFinalizeGrades.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFinalizeGrades.Name = "btnFinalizeGrades"
        Me.btnFinalizeGrades.Size = New System.Drawing.Size(100, 28)
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
        Me.grpClassroom.Location = New System.Drawing.Point(4, 4)
        Me.grpClassroom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpClassroom.Name = "grpClassroom"
        Me.grpClassroom.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpClassroom.Size = New System.Drawing.Size(267, 186)
        Me.grpClassroom.TabIndex = 3
        Me.grpClassroom.TabStop = False
        Me.grpClassroom.Text = "Classroom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID"
        '
        'txtClassroomID
        '
        Me.txtClassroomID.Location = New System.Drawing.Point(125, 68)
        Me.txtClassroomID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClassroomID.Name = "txtClassroomID"
        Me.txtClassroomID.ReadOnly = True
        Me.txtClassroomID.Size = New System.Drawing.Size(132, 22)
        Me.txtClassroomID.TabIndex = 2
        '
        'txtClassroomName
        '
        Me.txtClassroomName.Location = New System.Drawing.Point(125, 101)
        Me.txtClassroomName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClassroomName.Name = "txtClassroomName"
        Me.txtClassroomName.ReadOnly = True
        Me.txtClassroomName.Size = New System.Drawing.Size(132, 22)
        Me.txtClassroomName.TabIndex = 1
        '
        'grpUser
        '
        Me.grpUser.Controls.Add(Me.Label4)
        Me.grpUser.Controls.Add(Me.Label3)
        Me.grpUser.Controls.Add(Me.txtUserID)
        Me.grpUser.Controls.Add(Me.txtUserName)
        Me.grpUser.Controls.Add(Me.btnUserBrowser)
        Me.grpUser.Location = New System.Drawing.Point(279, 4)
        Me.grpUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpUser.Name = "grpUser"
        Me.grpUser.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpUser.Size = New System.Drawing.Size(267, 186)
        Me.grpUser.TabIndex = 4
        Me.grpUser.TabStop = False
        Me.grpUser.Text = "User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 103)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID"
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(116, 68)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(141, 22)
        Me.txtUserID.TabIndex = 3
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(116, 100)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.ReadOnly = True
        Me.txtUserName.Size = New System.Drawing.Size(141, 22)
        Me.txtUserName.TabIndex = 2
        '
        'btnToggleRO
        '
        Me.btnToggleRO.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnToggleRO.AutoSize = True
        Me.btnToggleRO.Location = New System.Drawing.Point(367, 197)
        Me.btnToggleRO.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnToggleRO.Name = "btnToggleRO"
        Me.btnToggleRO.Size = New System.Drawing.Size(109, 27)
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
        Me.grpGrades.Location = New System.Drawing.Point(553, 4)
        Me.grpGrades.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpGrades.Name = "grpGrades"
        Me.grpGrades.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpGrades.Size = New System.Drawing.Size(271, 186)
        Me.grpGrades.TabIndex = 6
        Me.grpGrades.TabStop = False
        Me.grpGrades.Text = "Grades"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(65, 70)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Mark"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 103)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Average"
        '
        'btnMakeGrades
        '
        Me.btnMakeGrades.Location = New System.Drawing.Point(8, 23)
        Me.btnMakeGrades.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMakeGrades.Name = "btnMakeGrades"
        Me.btnMakeGrades.Size = New System.Drawing.Size(100, 28)
        Me.btnMakeGrades.TabIndex = 2
        Me.btnMakeGrades.Text = "Compute"
        Me.btnMakeGrades.UseVisualStyleBackColor = True
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(125, 98)
        Me.txtAverage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.ReadOnly = True
        Me.txtAverage.Size = New System.Drawing.Size(132, 22)
        Me.txtAverage.TabIndex = 1
        '
        'txtLetter
        '
        Me.txtLetter.Location = New System.Drawing.Point(125, 66)
        Me.txtLetter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLetter.Name = "txtLetter"
        Me.txtLetter.ReadOnly = True
        Me.txtLetter.Size = New System.Drawing.Size(132, 22)
        Me.txtLetter.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grpClassroom)
        Me.Panel1.Controls.Add(Me.btnFinalizeGrades)
        Me.Panel1.Controls.Add(Me.grpGrades)
        Me.Panel1.Controls.Add(Me.grpUser)
        Me.Panel1.Controls.Add(Me.btnToggleRO)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(830, 236)
        Me.Panel1.TabIndex = 7
        '
        'frmGradesClassroomCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 255)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmGradesClassroomCreator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGradesClassroomCreator"
        Me.grpClassroom.ResumeLayout(False)
        Me.grpClassroom.PerformLayout()
        Me.grpUser.ResumeLayout(False)
        Me.grpUser.PerformLayout()
        Me.grpGrades.ResumeLayout(False)
        Me.grpGrades.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
