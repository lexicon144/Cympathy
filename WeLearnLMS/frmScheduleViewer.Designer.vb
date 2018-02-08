<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheduleViewer
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grpTimeslot = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTimeslotID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTimestart = New System.Windows.Forms.TextBox()
        Me.txtTimeDescription = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTimeID = New System.Windows.Forms.TextBox()
        Me.grpClassroom = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtClassroomID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClassroomName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClassroomDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClassroomType = New System.Windows.Forms.TextBox()
        Me.grpDay = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDayID = New System.Windows.Forms.TextBox()
        Me.txtDayDescription = New System.Windows.Forms.TextBox()
        Me.chkVisible = New System.Windows.Forms.CheckBox()
        Me.tblClassroomPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.tblTimeslotPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.tblDayPanel = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTimeslot.SuspendLayout()
        Me.grpClassroom.SuspendLayout()
        Me.grpDay.SuspendLayout()
        Me.tblClassroomPanel.SuspendLayout()
        Me.tblTimeslotPanel.SuspendLayout()
        Me.tblDayPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(816, 185)
        Me.DataGridView1.TabIndex = 0
        '
        'grpTimeslot
        '
        Me.grpTimeslot.Controls.Add(Me.tblTimeslotPanel)
        Me.grpTimeslot.Location = New System.Drawing.Point(291, 207)
        Me.grpTimeslot.Margin = New System.Windows.Forms.Padding(4)
        Me.grpTimeslot.Name = "grpTimeslot"
        Me.grpTimeslot.Padding = New System.Windows.Forms.Padding(4)
        Me.grpTimeslot.Size = New System.Drawing.Size(267, 159)
        Me.grpTimeslot.TabIndex = 3
        Me.grpTimeslot.TabStop = False
        Me.grpTimeslot.Text = "Timeslot"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 0)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Timeslot ID"
        '
        'txtTimeslotID
        '
        Me.txtTimeslotID.Location = New System.Drawing.Point(130, 4)
        Me.txtTimeslotID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTimeslotID.Name = "txtTimeslotID"
        Me.txtTimeslotID.ReadOnly = True
        Me.txtTimeslotID.Size = New System.Drawing.Size(119, 22)
        Me.txtTimeslotID.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 96)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Time Start"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 64)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Time Description"
        '
        'txtTimestart
        '
        Me.txtTimestart.Location = New System.Drawing.Point(130, 100)
        Me.txtTimestart.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTimestart.Name = "txtTimestart"
        Me.txtTimestart.ReadOnly = True
        Me.txtTimestart.Size = New System.Drawing.Size(119, 22)
        Me.txtTimestart.TabIndex = 3
        '
        'txtTimeDescription
        '
        Me.txtTimeDescription.Location = New System.Drawing.Point(130, 68)
        Me.txtTimeDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTimeDescription.Name = "txtTimeDescription"
        Me.txtTimeDescription.ReadOnly = True
        Me.txtTimeDescription.Size = New System.Drawing.Size(119, 22)
        Me.txtTimeDescription.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 32)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Time"
        '
        'txtTimeID
        '
        Me.txtTimeID.Location = New System.Drawing.Point(130, 36)
        Me.txtTimeID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTimeID.Name = "txtTimeID"
        Me.txtTimeID.ReadOnly = True
        Me.txtTimeID.Size = New System.Drawing.Size(119, 22)
        Me.txtTimeID.TabIndex = 0
        '
        'grpClassroom
        '
        Me.grpClassroom.Controls.Add(Me.tblClassroomPanel)
        Me.grpClassroom.Location = New System.Drawing.Point(16, 207)
        Me.grpClassroom.Margin = New System.Windows.Forms.Padding(4)
        Me.grpClassroom.Name = "grpClassroom"
        Me.grpClassroom.Padding = New System.Windows.Forms.Padding(4)
        Me.grpClassroom.Size = New System.Drawing.Size(267, 159)
        Me.grpClassroom.TabIndex = 2
        Me.grpClassroom.TabStop = False
        Me.grpClassroom.Text = "Classroom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 96)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Type"
        '
        'txtClassroomID
        '
        Me.txtClassroomID.Location = New System.Drawing.Point(130, 4)
        Me.txtClassroomID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClassroomID.Name = "txtClassroomID"
        Me.txtClassroomID.ReadOnly = True
        Me.txtClassroomID.Size = New System.Drawing.Size(119, 22)
        Me.txtClassroomID.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 64)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Description"
        '
        'txtClassroomName
        '
        Me.txtClassroomName.Location = New System.Drawing.Point(130, 36)
        Me.txtClassroomName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClassroomName.Name = "txtClassroomName"
        Me.txtClassroomName.ReadOnly = True
        Me.txtClassroomName.Size = New System.Drawing.Size(119, 22)
        Me.txtClassroomName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name"
        '
        'txtClassroomDescription
        '
        Me.txtClassroomDescription.Location = New System.Drawing.Point(130, 68)
        Me.txtClassroomDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClassroomDescription.Name = "txtClassroomDescription"
        Me.txtClassroomDescription.ReadOnly = True
        Me.txtClassroomDescription.Size = New System.Drawing.Size(119, 22)
        Me.txtClassroomDescription.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'txtClassroomType
        '
        Me.txtClassroomType.Location = New System.Drawing.Point(130, 100)
        Me.txtClassroomType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClassroomType.Name = "txtClassroomType"
        Me.txtClassroomType.ReadOnly = True
        Me.txtClassroomType.Size = New System.Drawing.Size(119, 22)
        Me.txtClassroomType.TabIndex = 4
        '
        'grpDay
        '
        Me.grpDay.Controls.Add(Me.tblDayPanel)
        Me.grpDay.Location = New System.Drawing.Point(565, 207)
        Me.grpDay.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDay.Name = "grpDay"
        Me.grpDay.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDay.Size = New System.Drawing.Size(267, 159)
        Me.grpDay.TabIndex = 4
        Me.grpDay.TabStop = False
        Me.grpDay.Text = "Day"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Day ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 65)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Day Description"
        '
        'txtDayID
        '
        Me.txtDayID.Location = New System.Drawing.Point(130, 4)
        Me.txtDayID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDayID.Name = "txtDayID"
        Me.txtDayID.ReadOnly = True
        Me.txtDayID.Size = New System.Drawing.Size(119, 22)
        Me.txtDayID.TabIndex = 1
        '
        'txtDayDescription
        '
        Me.txtDayDescription.Location = New System.Drawing.Point(130, 69)
        Me.txtDayDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDayDescription.Name = "txtDayDescription"
        Me.txtDayDescription.ReadOnly = True
        Me.txtDayDescription.Size = New System.Drawing.Size(119, 22)
        Me.txtDayDescription.TabIndex = 0
        '
        'chkVisible
        '
        Me.chkVisible.AutoSize = True
        Me.chkVisible.Checked = True
        Me.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVisible.Location = New System.Drawing.Point(720, 373)
        Me.chkVisible.Name = "chkVisible"
        Me.chkVisible.Size = New System.Drawing.Size(112, 21)
        Me.chkVisible.TabIndex = 5
        Me.chkVisible.Text = "Show More..."
        Me.chkVisible.UseVisualStyleBackColor = True
        '
        'tblClassroomPanel
        '
        Me.tblClassroomPanel.ColumnCount = 2
        Me.tblClassroomPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblClassroomPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblClassroomPanel.Controls.Add(Me.Label4, 0, 3)
        Me.tblClassroomPanel.Controls.Add(Me.Label1, 0, 0)
        Me.tblClassroomPanel.Controls.Add(Me.Label3, 0, 2)
        Me.tblClassroomPanel.Controls.Add(Me.txtClassroomID, 1, 0)
        Me.tblClassroomPanel.Controls.Add(Me.txtClassroomType, 1, 3)
        Me.tblClassroomPanel.Controls.Add(Me.txtClassroomDescription, 1, 2)
        Me.tblClassroomPanel.Controls.Add(Me.txtClassroomName, 1, 1)
        Me.tblClassroomPanel.Controls.Add(Me.Label2, 0, 1)
        Me.tblClassroomPanel.Location = New System.Drawing.Point(7, 22)
        Me.tblClassroomPanel.Name = "tblClassroomPanel"
        Me.tblClassroomPanel.RowCount = 4
        Me.tblClassroomPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblClassroomPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblClassroomPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblClassroomPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblClassroomPanel.Size = New System.Drawing.Size(253, 130)
        Me.tblClassroomPanel.TabIndex = 6
        '
        'tblTimeslotPanel
        '
        Me.tblTimeslotPanel.ColumnCount = 2
        Me.tblTimeslotPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTimeslotPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTimeslotPanel.Controls.Add(Me.txtTimestart, 1, 3)
        Me.tblTimeslotPanel.Controls.Add(Me.txtTimeslotID, 1, 0)
        Me.tblTimeslotPanel.Controls.Add(Me.txtTimeDescription, 1, 2)
        Me.tblTimeslotPanel.Controls.Add(Me.Label10, 0, 0)
        Me.tblTimeslotPanel.Controls.Add(Me.txtTimeID, 1, 1)
        Me.tblTimeslotPanel.Controls.Add(Me.Label7, 0, 3)
        Me.tblTimeslotPanel.Controls.Add(Me.Label5, 0, 1)
        Me.tblTimeslotPanel.Controls.Add(Me.Label6, 0, 2)
        Me.tblTimeslotPanel.Location = New System.Drawing.Point(7, 22)
        Me.tblTimeslotPanel.Name = "tblTimeslotPanel"
        Me.tblTimeslotPanel.RowCount = 4
        Me.tblTimeslotPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblTimeslotPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblTimeslotPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblTimeslotPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblTimeslotPanel.Size = New System.Drawing.Size(253, 130)
        Me.tblTimeslotPanel.TabIndex = 6
        '
        'tblDayPanel
        '
        Me.tblDayPanel.ColumnCount = 2
        Me.tblDayPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDayPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDayPanel.Controls.Add(Me.txtDayDescription, 1, 1)
        Me.tblDayPanel.Controls.Add(Me.txtDayID, 1, 0)
        Me.tblDayPanel.Controls.Add(Me.Label8, 0, 1)
        Me.tblDayPanel.Controls.Add(Me.Label9, 0, 0)
        Me.tblDayPanel.Location = New System.Drawing.Point(7, 22)
        Me.tblDayPanel.Name = "tblDayPanel"
        Me.tblDayPanel.RowCount = 2
        Me.tblDayPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDayPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDayPanel.Size = New System.Drawing.Size(253, 130)
        Me.tblDayPanel.TabIndex = 6
        '
        'frmScheduleViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 404)
        Me.Controls.Add(Me.chkVisible)
        Me.Controls.Add(Me.grpDay)
        Me.Controls.Add(Me.grpTimeslot)
        Me.Controls.Add(Me.grpClassroom)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmScheduleViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmScheduleViewer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTimeslot.ResumeLayout(False)
        Me.grpClassroom.ResumeLayout(False)
        Me.grpDay.ResumeLayout(False)
        Me.tblClassroomPanel.ResumeLayout(False)
        Me.tblClassroomPanel.PerformLayout()
        Me.tblTimeslotPanel.ResumeLayout(False)
        Me.tblTimeslotPanel.PerformLayout()
        Me.tblDayPanel.ResumeLayout(False)
        Me.tblDayPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents grpTimeslot As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTimestart As System.Windows.Forms.TextBox
    Friend WithEvents txtTimeDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTimeID As System.Windows.Forms.TextBox
    Friend WithEvents grpClassroom As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtClassroomID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtClassroomName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtClassroomDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtClassroomType As System.Windows.Forms.TextBox
    Friend WithEvents grpDay As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDayID As System.Windows.Forms.TextBox
    Friend WithEvents txtDayDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTimeslotID As System.Windows.Forms.TextBox
    Friend WithEvents chkVisible As System.Windows.Forms.CheckBox
    Friend WithEvents tblTimeslotPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblClassroomPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblDayPanel As System.Windows.Forms.TableLayoutPanel
End Class
