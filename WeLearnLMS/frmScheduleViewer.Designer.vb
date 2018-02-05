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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTimeslot.SuspendLayout()
        Me.grpClassroom.SuspendLayout()
        Me.grpDay.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(612, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'grpTimeslot
        '
        Me.grpTimeslot.Controls.Add(Me.Label10)
        Me.grpTimeslot.Controls.Add(Me.txtTimeslotID)
        Me.grpTimeslot.Controls.Add(Me.Label7)
        Me.grpTimeslot.Controls.Add(Me.Label6)
        Me.grpTimeslot.Controls.Add(Me.txtTimestart)
        Me.grpTimeslot.Controls.Add(Me.txtTimeDescription)
        Me.grpTimeslot.Controls.Add(Me.Label5)
        Me.grpTimeslot.Controls.Add(Me.txtTimeID)
        Me.grpTimeslot.Location = New System.Drawing.Point(218, 168)
        Me.grpTimeslot.Name = "grpTimeslot"
        Me.grpTimeslot.Size = New System.Drawing.Size(200, 129)
        Me.grpTimeslot.TabIndex = 3
        Me.grpTimeslot.TabStop = False
        Me.grpTimeslot.Text = "Timeslot"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Timeslot ID"
        '
        'txtTimeslotID
        '
        Me.txtTimeslotID.Location = New System.Drawing.Point(94, 20)
        Me.txtTimeslotID.Name = "txtTimeslotID"
        Me.txtTimeslotID.ReadOnly = True
        Me.txtTimeslotID.Size = New System.Drawing.Size(100, 20)
        Me.txtTimeslotID.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Time Start"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Time Description"
        '
        'txtTimestart
        '
        Me.txtTimestart.Location = New System.Drawing.Point(94, 98)
        Me.txtTimestart.Name = "txtTimestart"
        Me.txtTimestart.ReadOnly = True
        Me.txtTimestart.Size = New System.Drawing.Size(100, 20)
        Me.txtTimestart.TabIndex = 3
        '
        'txtTimeDescription
        '
        Me.txtTimeDescription.Location = New System.Drawing.Point(94, 72)
        Me.txtTimeDescription.Name = "txtTimeDescription"
        Me.txtTimeDescription.ReadOnly = True
        Me.txtTimeDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtTimeDescription.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Time"
        '
        'txtTimeID
        '
        Me.txtTimeID.Location = New System.Drawing.Point(94, 46)
        Me.txtTimeID.Name = "txtTimeID"
        Me.txtTimeID.ReadOnly = True
        Me.txtTimeID.Size = New System.Drawing.Size(100, 20)
        Me.txtTimeID.TabIndex = 0
        '
        'grpClassroom
        '
        Me.grpClassroom.Controls.Add(Me.Label4)
        Me.grpClassroom.Controls.Add(Me.txtClassroomID)
        Me.grpClassroom.Controls.Add(Me.Label3)
        Me.grpClassroom.Controls.Add(Me.txtClassroomName)
        Me.grpClassroom.Controls.Add(Me.Label2)
        Me.grpClassroom.Controls.Add(Me.txtClassroomDescription)
        Me.grpClassroom.Controls.Add(Me.Label1)
        Me.grpClassroom.Controls.Add(Me.txtClassroomType)
        Me.grpClassroom.Location = New System.Drawing.Point(12, 168)
        Me.grpClassroom.Name = "grpClassroom"
        Me.grpClassroom.Size = New System.Drawing.Size(200, 129)
        Me.grpClassroom.TabIndex = 2
        Me.grpClassroom.TabStop = False
        Me.grpClassroom.Text = "Classroom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Type"
        '
        'txtClassroomID
        '
        Me.txtClassroomID.Location = New System.Drawing.Point(81, 19)
        Me.txtClassroomID.Name = "txtClassroomID"
        Me.txtClassroomID.ReadOnly = True
        Me.txtClassroomID.Size = New System.Drawing.Size(100, 20)
        Me.txtClassroomID.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Description"
        '
        'txtClassroomName
        '
        Me.txtClassroomName.Location = New System.Drawing.Point(81, 45)
        Me.txtClassroomName.Name = "txtClassroomName"
        Me.txtClassroomName.ReadOnly = True
        Me.txtClassroomName.Size = New System.Drawing.Size(100, 20)
        Me.txtClassroomName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name"
        '
        'txtClassroomDescription
        '
        Me.txtClassroomDescription.Location = New System.Drawing.Point(81, 71)
        Me.txtClassroomDescription.Name = "txtClassroomDescription"
        Me.txtClassroomDescription.ReadOnly = True
        Me.txtClassroomDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtClassroomDescription.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'txtClassroomType
        '
        Me.txtClassroomType.Location = New System.Drawing.Point(81, 97)
        Me.txtClassroomType.Name = "txtClassroomType"
        Me.txtClassroomType.ReadOnly = True
        Me.txtClassroomType.Size = New System.Drawing.Size(100, 20)
        Me.txtClassroomType.TabIndex = 4
        '
        'grpDay
        '
        Me.grpDay.Controls.Add(Me.Label9)
        Me.grpDay.Controls.Add(Me.Label8)
        Me.grpDay.Controls.Add(Me.txtDayID)
        Me.grpDay.Controls.Add(Me.txtDayDescription)
        Me.grpDay.Location = New System.Drawing.Point(424, 168)
        Me.grpDay.Name = "grpDay"
        Me.grpDay.Size = New System.Drawing.Size(200, 129)
        Me.grpDay.TabIndex = 4
        Me.grpDay.TabStop = False
        Me.grpDay.Text = "Day"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(48, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Day ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Day Description"
        '
        'txtDayID
        '
        Me.txtDayID.Location = New System.Drawing.Point(94, 20)
        Me.txtDayID.Name = "txtDayID"
        Me.txtDayID.ReadOnly = True
        Me.txtDayID.Size = New System.Drawing.Size(100, 20)
        Me.txtDayID.TabIndex = 1
        '
        'txtDayDescription
        '
        Me.txtDayDescription.Location = New System.Drawing.Point(94, 46)
        Me.txtDayDescription.Name = "txtDayDescription"
        Me.txtDayDescription.ReadOnly = True
        Me.txtDayDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtDayDescription.TabIndex = 0
        '
        'frmScheduleViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 308)
        Me.Controls.Add(Me.grpDay)
        Me.Controls.Add(Me.grpTimeslot)
        Me.Controls.Add(Me.grpClassroom)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmScheduleViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmScheduleViewer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTimeslot.ResumeLayout(False)
        Me.grpTimeslot.PerformLayout()
        Me.grpClassroom.ResumeLayout(False)
        Me.grpClassroom.PerformLayout()
        Me.grpDay.ResumeLayout(False)
        Me.grpDay.PerformLayout()
        Me.ResumeLayout(False)

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
End Class
