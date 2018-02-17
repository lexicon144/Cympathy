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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClassroomID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClassroomName = New System.Windows.Forms.TextBox()
        Me.grpUser = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.btnToggleRO = New System.Windows.Forms.CheckBox()
        Me.grpGrades = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnMakeGrades = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLetter = New System.Windows.Forms.TextBox()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.grpClassroom.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpUser.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.grpGrades.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClassroomBrowser
        '
        Me.btnClassroomBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClassroomBrowser.Location = New System.Drawing.Point(119, 3)
        Me.btnClassroomBrowser.Name = "btnClassroomBrowser"
        Me.btnClassroomBrowser.Size = New System.Drawing.Size(110, 50)
        Me.btnClassroomBrowser.TabIndex = 0
        Me.btnClassroomBrowser.Text = "Browse"
        Me.btnClassroomBrowser.UseVisualStyleBackColor = True
        '
        'btnUserBrowser
        '
        Me.btnUserBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUserBrowser.Location = New System.Drawing.Point(119, 3)
        Me.btnUserBrowser.Name = "btnUserBrowser"
        Me.btnUserBrowser.Size = New System.Drawing.Size(110, 50)
        Me.btnUserBrowser.TabIndex = 1
        Me.btnUserBrowser.Text = "Browser"
        Me.btnUserBrowser.UseVisualStyleBackColor = True
        '
        'btnFinalizeGrades
        '
        Me.btnFinalizeGrades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFinalizeGrades.Location = New System.Drawing.Point(122, 3)
        Me.btnFinalizeGrades.Name = "btnFinalizeGrades"
        Me.btnFinalizeGrades.Size = New System.Drawing.Size(113, 37)
        Me.btnFinalizeGrades.TabIndex = 2
        Me.btnFinalizeGrades.Text = "Finalize"
        Me.btnFinalizeGrades.UseVisualStyleBackColor = True
        '
        'grpClassroom
        '
        Me.grpClassroom.Controls.Add(Me.TableLayoutPanel1)
        Me.grpClassroom.Location = New System.Drawing.Point(3, 3)
        Me.grpClassroom.Name = "grpClassroom"
        Me.grpClassroom.Size = New System.Drawing.Size(238, 188)
        Me.grpClassroom.TabIndex = 3
        Me.grpClassroom.TabStop = False
        Me.grpClassroom.Text = "Classroom"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnClassroomBrowser, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtClassroomID, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtClassroomName, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(232, 169)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 57)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        '
        'txtClassroomID
        '
        Me.txtClassroomID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtClassroomID.Location = New System.Drawing.Point(119, 59)
        Me.txtClassroomID.Name = "txtClassroomID"
        Me.txtClassroomID.ReadOnly = True
        Me.txtClassroomID.Size = New System.Drawing.Size(110, 20)
        Me.txtClassroomID.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 56)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID"
        '
        'txtClassroomName
        '
        Me.txtClassroomName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtClassroomName.Location = New System.Drawing.Point(119, 115)
        Me.txtClassroomName.Name = "txtClassroomName"
        Me.txtClassroomName.ReadOnly = True
        Me.txtClassroomName.Size = New System.Drawing.Size(110, 20)
        Me.txtClassroomName.TabIndex = 1
        '
        'grpUser
        '
        Me.grpUser.Controls.Add(Me.TableLayoutPanel2)
        Me.grpUser.Location = New System.Drawing.Point(247, 3)
        Me.grpUser.Name = "grpUser"
        Me.grpUser.Size = New System.Drawing.Size(238, 188)
        Me.grpUser.TabIndex = 4
        Me.grpUser.TabStop = False
        Me.grpUser.Text = "User"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnUserBrowser, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtUserID, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtUserName, 1, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(232, 169)
        Me.TableLayoutPanel2.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 57)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 56)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID"
        '
        'txtUserID
        '
        Me.txtUserID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUserID.Location = New System.Drawing.Point(119, 59)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(110, 20)
        Me.txtUserID.TabIndex = 3
        '
        'txtUserName
        '
        Me.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUserName.Location = New System.Drawing.Point(119, 115)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.ReadOnly = True
        Me.txtUserName.Size = New System.Drawing.Size(110, 20)
        Me.txtUserName.TabIndex = 2
        '
        'btnToggleRO
        '
        Me.btnToggleRO.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnToggleRO.AutoSize = True
        Me.btnToggleRO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnToggleRO.Location = New System.Drawing.Point(3, 3)
        Me.btnToggleRO.Name = "btnToggleRO"
        Me.btnToggleRO.Size = New System.Drawing.Size(113, 37)
        Me.btnToggleRO.TabIndex = 5
        Me.btnToggleRO.Text = "Freeze Editing"
        Me.btnToggleRO.UseVisualStyleBackColor = True
        '
        'grpGrades
        '
        Me.grpGrades.Controls.Add(Me.TableLayoutPanel3)
        Me.grpGrades.Location = New System.Drawing.Point(491, 3)
        Me.grpGrades.Name = "grpGrades"
        Me.grpGrades.Size = New System.Drawing.Size(238, 188)
        Me.grpGrades.TabIndex = 6
        Me.grpGrades.TabStop = False
        Me.grpGrades.Text = "Grades"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnMakeGrades, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtLetter, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtAverage, 1, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(232, 169)
        Me.TableLayoutPanel3.TabIndex = 9
        '
        'btnMakeGrades
        '
        Me.btnMakeGrades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMakeGrades.Location = New System.Drawing.Point(119, 3)
        Me.btnMakeGrades.Name = "btnMakeGrades"
        Me.btnMakeGrades.Size = New System.Drawing.Size(110, 50)
        Me.btnMakeGrades.TabIndex = 2
        Me.btnMakeGrades.Text = "Compute"
        Me.btnMakeGrades.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 57)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Average"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 56)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Mark"
        '
        'txtLetter
        '
        Me.txtLetter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLetter.Location = New System.Drawing.Point(119, 59)
        Me.txtLetter.Name = "txtLetter"
        Me.txtLetter.ReadOnly = True
        Me.txtLetter.Size = New System.Drawing.Size(110, 20)
        Me.txtLetter.TabIndex = 0
        '
        'txtAverage
        '
        Me.txtAverage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAverage.Location = New System.Drawing.Point(119, 115)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.ReadOnly = True
        Me.txtAverage.Size = New System.Drawing.Size(110, 20)
        Me.txtAverage.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.grpClassroom)
        Me.FlowLayoutPanel1.Controls.Add(Me.grpUser)
        Me.FlowLayoutPanel1.Controls.Add(Me.grpGrades)
        Me.FlowLayoutPanel1.Controls.Add(Me.TableLayoutPanel4)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(740, 249)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnToggleRO, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnFinalizeGrades, 1, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(2, 196)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(238, 43)
        Me.TableLayoutPanel4.TabIndex = 9
        '
        'frmGradesClassroomCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 249)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "frmGradesClassroomCreator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGradesClassroomCreator"
        Me.grpClassroom.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.grpUser.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.grpGrades.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
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
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
End Class
